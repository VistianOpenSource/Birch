using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Birch.Collections.Comparers.Myers
{
   /// <summary>
    /// This class implements the differencing algorithm from
    /// "An O(ND) Difference Algorithm And Its Variations" by
    /// Eugene W. Myers.  It is the standard algorithm used by
    /// the UNIX diff utilities.
    ///
    /// This implementation diffs two comparable lists.  It is
    /// typically used with lists of hash values where each
    /// hash corresponds to a line of text.  Then it can be
    /// used to diff two text files on a line-by-line basis.
    /// </summary>
    /// <remarks>
    /// Code based on https://github.com/ErlinEmrys/Lib.Common/tree/master/Erlin.Lib.Common/Text
    /// </remarks>
    public sealed class MyersDiffArraySegment<T>
    {
        private readonly T[] _listA;// Sequence A
        private readonly T[] _listB;// Sequence B

        private readonly bool _supportChangeEditType;

        private readonly IEqualityComparer<T> _equalityComparer;

        private readonly DiagonalVector _vectorForward;
        private readonly DiagonalVector _vectorReverse;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="listA">Left sequence</param>
        /// <param name="listB">Right sequence</param>
        /// <param name="supportChangeEditType">If "Change" EditType is allowed (default is delete and insert only)</param>
        /// <param name="equalityComparer"></param>
        public MyersDiffArraySegment(T[] listA, T[] listB, bool supportChangeEditType,IEqualityComparer<T> equalityComparer=default)
        {
            _listA = listA;
            _listB = listB;
            _supportChangeEditType = supportChangeEditType;
            _equalityComparer = equalityComparer ?? EqualityComparer<T>.Default;

            var n = listA.Length;
            var m = listB.Length;

            _vectorForward = new DiagonalVector(n, m);
            _vectorReverse = new DiagonalVector(n, m);
        }


        /// <summary>
        /// Returns an EditScript instance that gives all the Edits
        /// necessary to transform A into B.
        /// </summary>
        /// <returns>Complete edit script</returns>
        public EditScript Execute()
        {
            var matchPoints = new List<Point2D<int>>();

            var subArrayA =  new ArraySegment<T>(_listA);
            var subArrayB =  new ArraySegment<T>(_listB);


            GetMatchPoints(subArrayA, subArrayB, matchPoints);
            //Debug.Assert(matchPoints.Count == GetLongestCommonSubsequenceLength(), "The number of match points must equal the LCS length.");

            var result = ConvertMatchPointsToEditScript(subArrayA.Count, subArrayB.Count, matchPoints);
            //Debug.Assert(result.TotalEditLength == GetShortestEditScriptLength(), "The total edit length must equal the SES length.");

            return result;
        }

        /// <summary>
        /// Returns the longest common subsequence from A and B.
        /// </summary>
        /// <returns>LCS of entered sequences</returns>
        public IList<T> GetLongestCommonSubsequence()
        {
            var result = new List<T>();

            GetLcs(new ArraySegment<T>(_listA), new ArraySegment<T>(_listB), result);

            return result;
        }

        /// <summary>
        /// Calculates the length that the LCS should be without
        /// actually determining the LCS.
        /// </summary>
        /// <returns>LCS length</returns>
        public int GetLongestCommonSubsequenceLength()
            /* Per Myers's paper, we should always have D+2L == N+M.  So L == (N+M-D)/2. */
        {
            return (_listA.Length + _listB.Length - GetShortestEditScriptLength()) / 2;
        }


        /// <summary>
        /// Calculates the length of the "shortest edit script"
        /// as defined in Myers's paper.
        ///
        /// Note: This may not be the same as the Count property
        /// of an EditScript instance returned by Execute().  If
        /// an EditScript instance has any Edits with Length > 1,
        /// then those groupings will make EditScript.Count less
        /// than GetSESLength().  Similarly, an Edit with EditType
        /// Change should be thought of as a combined Delete and
        /// Insert for the specified Length.
        /// </summary>
        /// <returns>SES length</returns>
        public int GetShortestEditScriptLength()
        {
            var subArrayA = new ArraySegment<T>(_listA);
            var subArrayB = new ArraySegment<T>(_listB);

            if (SetupFictitiousPoints(subArrayA, subArrayB))
            {
                var n = _listA.Length;
                var m = _listB.Length;

                for (var d = 0; d <= n + m; d++)
                {
                    for (var k = -d; k <= d; k += 2)
                    {
                        var x = GetForwardDPaths(subArrayA, subArrayB, d, k);
                        var y = x - k;
                        if (x >= n && y >= m)
                        {
                            return d;
                        }
                    }
                }

                // We should never get here if the algorithm is coded correctly.
                //Debug.Assert(false, "This code should be unreachable.");
                return -1;
            }

            return _listA.Length == 0 ? _listB.Length : _listA.Length;
        }

        /// <summary>
        /// Returns a similarity index between 0 and 1 inclusive.
        /// 0 means A and B are completely different.  1 means
        /// they are exactly alike.  The similarity index is
        /// calculated as twice the length of the LCS divided
        /// by the sum of A and B's lengths.
        /// </summary>
        /// <returns>Similarity index (0=>completely different, 1=>same)</returns>
        public double GetSimilarity()
        {
            var result = GetSimilarity(_listA.Length, _listB.Length, GetLongestCommonSubsequenceLength());
            return result;
        }

        /// <summary>
        /// Returns a similarity index between 0 and 1 inclusive.
        /// 0 means A and B are completely different.  1 means
        /// they are exactly alike.  The similarity index is
        /// calculated as twice the length of the LCS divided
        /// by the sum of A and B's lengths.
        /// </summary>
        /// <param name="lengthA">Length of sequence A</param>
        /// <param name="lengthB">Length of sequence B</param>
        /// <param name="lengthLcs">Length of LCS of A and B</param>
        /// <returns>Similarity index (0=>completely different, 1=>same)</returns>
        private static double GetSimilarity(int lengthA, int lengthB, int lengthLcs)
        {
            var result = 2.0 * lengthLcs / (lengthA + lengthB);
            return result;
        }

        /// <summary>
        /// Turns Myers match points to final edit script
        /// </summary>
        /// <param name="n">Length of A sequence</param>
        /// <param name="m">Length of B sequence</param>
        /// <param name="matchPoints">Match points</param>
        /// <returns>Final edit script</returns>
        private EditScript ConvertMatchPointsToEditScript(int n, int m, ICollection<Point2D<int>> matchPoints)
        {
            // The Execute method already has an assertion that the number of MatchPoints
            // equals the LCS length, so we can use it to calculate similarity, but we must do
            // it before we add a fictitious match point below.
            var similarity = GetSimilarity(n, m, matchPoints.Count);
            var script = new EditScript(similarity);

            var currentX = 1;
            var currentY = 1;

            // Add a fictitious match point at (N+1, M+1) so we're guaranteed to
            // pick up all edits with a single loop.
            matchPoints.Add(new Point2D<int>(n + 1, m + 1));

            // NOTE: When we create new Edit instances, we'll store iCurrX and iCurrY
            // minus 1 because we want to convert them back to 0-based indexes for
            // the user.  The user shouldn't have to know that internally we use any
            // 1-based types.
            foreach (var point in matchPoints)
            {
                var matchX = point.X;
                var matchY = point.Y;

                // A one-to-one grouping of inserts and deletes will be considered a change.
                if (_supportChangeEditType && currentX < matchX && currentY < matchY)
                {
                    var changeLength = Math.Min(matchX - currentX, matchY - currentY);
                    script.Add(new Edit(TextEditType.Change, currentX - 1, currentY - 1, changeLength));
                    currentX += changeLength;
                    currentY += changeLength;
                }

                if (currentX < matchX)
                {
                    script.Add(new Edit(TextEditType.Delete, currentX - 1, currentY - 1, matchX - currentX));
                }

                if (currentY < matchY)
                {
                    script.Add(new Edit(TextEditType.Insert, currentX - 1, currentY - 1, matchY - currentY));
                }

                currentX = matchX + 1;
                currentY = matchY + 1;
            }

            return script;
        }

        /// <summary>
        /// Find middle snake by myers algorithm
        /// </summary>
        /// <param name="subArrayA">Sub-Sequence A</param>
        /// <param name="subArrayB">Sub-Sequence B</param>
        /// <param name="pathStartX">X start</param>
        /// <param name="pathEndX">X end</param>
        /// <param name="pathK">K path</param>
        /// <returns>SES length</returns>
        private int FindMiddleSnake(ArraySegment<T> subArrayA, ArraySegment<T> subArrayB, out int pathStartX, out int pathEndX, out int pathK)
        {
            // We don't have to check the result of this because the calling procedure
            // has already check the length preconditions.
            SetupFictitiousPoints(subArrayA, subArrayB);

            pathStartX = -1;
            pathEndX = -1;
            pathK = 0;

            var delta = subArrayA.Count - subArrayB.Count;
            var ceiling = (int)Math.Ceiling((subArrayA.Count + subArrayB.Count) / 2.0);

            for (var d = 0; d <= ceiling; d++)
            {
                for (var k = -d; k <= d; k += 2)
                {
                    // Find the end of the furthest reaching forward D-path in diagonal k.
                    GetForwardDPaths(subArrayA, subArrayB, d, k);

                    // If delta is odd (i.e. remainder == 1 or -1) and ...
                    if (delta % 2 != 0 && k >= delta - (d - 1) && k <= delta + (d - 1))
                    {
                        // If the path overlaps the furthest reaching reverse (D-1)-path in diagonal k.
                        if (_vectorForward[k] >= _vectorReverse[k])
                        {
                            // The last snake of the forward path is the middle snake.
                            pathK = k;
                            pathEndX = _vectorForward[k];
                            pathStartX = pathEndX;
                            int pathStartY = pathStartX - pathK;
                            while (pathStartX > 0 && pathStartY > 0 && _equalityComparer.Equals(subArrayA[pathStartX-1],subArrayB[pathStartY-1]) )
                            {
                                pathStartX--;
                                pathStartY--;
                            }

                            // Length of an SES is 2D-1.
                            return 2 * d - 1;
                        }
                    }
                }

                for (var k = -d; k <= d; k += 2)
                {
                    // Find the end of the furthest reaching reverse D=path in diagonal k+iDelta
                    GetReverseDPaths(subArrayA, subArrayB, d, k, delta);

                    // If iDelta is even and ...
                    if (delta % 2 == 0 && k + delta >= -d && k + delta <= d)
                    {
                        // If the path overlaps the furthest reaching forward D-path in diagonal k+iDelta.
                        if (_vectorReverse[k + delta] <= _vectorForward[k + delta])
                        {
                            // The last snake of the reverse path is the middle snake.
                            pathK = k + delta;
                            pathStartX = _vectorReverse[pathK];
                            pathEndX = pathStartX;
                            int pathEndY = pathEndX - pathK;
                            while (pathEndX < subArrayA.Count &&
                                   pathEndY < subArrayB.Count &&
                                   _equalityComparer.Equals(subArrayA[pathEndX + 1-1],subArrayB[pathEndY + 1-1]))
                            {
                                pathEndX++;
                                pathEndY++;
                            }

                            // Length of an SES is 2D.
                            return 2 * d;
                        }
                    }
                }
            }

            // We should never get here if the algorithm is coded correctly.
            //Debug.Assert(false, "This code should be unreachable.");
            return -1;
        }

        /// <summary>
        /// Returns forward D path
        /// </summary>
        /// <param name="subArrayA">Sub-sequence A</param>
        /// <param name="subArrayB">Sub-sequence B</param>
        /// <param name="d">D index</param>
        /// <param name="k">K index</param>
        /// <returns>X coordinate</returns>
        private int GetForwardDPaths(ArraySegment<T> subArrayA, ArraySegment<T> subArrayB, int d, int k)
        {
            var vector = _vectorForward;

            int x;
            if (k == -d || k != d && vector[k - 1] < vector[k + 1])
            {
                x = vector[k + 1];
            }
            else
            {
                x = vector[k - 1] + 1;
            }

            var y = x - k;

            while (x < subArrayA.Count && y < subArrayB.Count && _equalityComparer.Equals(subArrayA[x + 1-1],subArrayB[y + 1-1]))
            {
                x++;
                y++;
            }

            vector[k] = x;

            return x;
        }

        /// <summary>
        /// Returns Longest Common Subsequence
        /// </summary>
        /// <param name="subArrayA">Sub-sequence A</param>
        /// <param name="subArrayB">Sub-sequence B</param>
        /// <param name="output">LCS output</param>
        private void GetLcs(ArraySegment<T> subArrayA, ArraySegment<T> subArrayB, List<T> output)
        {
            while (true)
            {
                if (subArrayA.Count > 0 && subArrayB.Count > 0)
                {
                    // Find the length D and the middle snake from (x,y) to (u,v)
                    var d = FindMiddleSnake(subArrayA, subArrayB, out int x, out int u, out int k);
                    var y = x - k;
                    var v = u - k;

                    if (d > 1)
                    {
                        GetLcs(subArrayA.Slice(0, x), subArrayB.Slice(0,y), output);

                        for (var i = x + 1; i <= u; i++)
                        {
                            output.Add(subArrayA[i]);
                        }

                        subArrayA = subArrayA.Slice(u,subArrayA.Count - u);
                        subArrayB = subArrayB.Slice(v, subArrayB.Count - v);
                        continue;
                    }

                    if (subArrayB.Count > subArrayA.Count)
                    {
                        for (var i = 1; i <= subArrayA.Count; i++)
                        {
                            output.Add(subArrayA[i-1]);
                        }
                    }
                    else
                    {
                        for (var i = 1; i <= subArrayB.Count; i++)
                        {
                            output.Add(subArrayB[i-1]);
                        }
                    }
                }

                break;
            }
        }

        /// <summary>
        /// Returns match points for entered sequences
        /// </summary>
        /// <param name="subArrayA">Sub-sequence A</param>
        /// <param name="subArrayB">Sub-sequence B</param>
        /// <param name="matchPoints">Match points</param>
        private void GetMatchPoints(ArraySegment<T> subArrayA, ArraySegment<T> subArrayB, ICollection<Point2D<int>> matchPoints)
        {
            while (true)
            {
                if (subArrayA.Count > 0 && subArrayB.Count > 0)
                {
                    // Find the middle snake from (x,y) to (u,v)
                    var d = FindMiddleSnake(subArrayA, subArrayB, out var x, out var u, out var k);
                    var y = x - k;
                    var v = u - k;

                    if (d > 1)
                    {
                        GetMatchPoints(new ArraySegment<T>(subArrayA.Array, subArrayA.Offset, x), new ArraySegment<T>(subArrayB.Array, subArrayB.Offset, y), matchPoints);

                        for (var i = x + 1; i <= u; i++)
                        {
                            // Output absolute X and Y (not relative to the current subarray)
                            matchPoints.Add(new Point2D<int>(i + subArrayA.Offset, i - k + subArrayB.Offset));
                        }

                        subArrayA = subArrayA.Slice(u,subArrayA.Count - u);
                        subArrayB = subArrayB.Slice(v , subArrayB.Count - v);
                        continue;
                    }

                    // If there are no differences, we have to output all of the points.
                    // If there's only one difference, we have to output all of the
                    // match points, skipping the single point that is different.
                    //Debug.Assert(d == 0 || Math.Abs(subArrayA.Length - subArrayB.Length) == 1, "A and B's lengths must differ by 1 if D == 1");

                    // Only go to the minimum of the two lengths since that's the
                    // most that can possibly match between the two sub sequences.
                    var n = subArrayA.Count;
                    var m = subArrayB.Count;
                    if (m > n)
                    {
                        // Output A[1..N] as match points
                        var currentY = 1;
                        for (var i = 1; i <= n; i++)
                        {
                            // We must skip the one difference when we hit it
                            if (!_equalityComparer.Equals(subArrayA[i-1],subArrayB[currentY-1]))
                            {
                                currentY++;
                            }

                            matchPoints.Add(new Point2D<int>(i + subArrayA.Offset, currentY + subArrayB.Offset));
                            currentY++;
                        }
                    }
                    else
                    {
                        // Output B[1..M] as match points
                        var currentX = 1;
                        for (var i = 1; i <= m; i++)
                        {
                            // We must skip the one difference when we hit it
                            if (!_equalityComparer.Equals(subArrayA[currentX-1],subArrayB[i-1]))
                            {
                                currentX++;
                            }

                            matchPoints.Add(new Point2D<int>(currentX + subArrayA.Offset, i + subArrayB.Offset));
                            currentX++;
                        }
                    }
                }

                break;
            }
        }

        /// <summary>
        /// Returns reverse D path
        /// </summary>
        /// <param name="subArrayA">Sub-sequence A</param>
        /// <param name="subArrayB">Sub-sequence B</param>
        /// <param name="d">D index</param>
        /// <param name="k">K index</param>
        /// <param name="delta">Delta</param>
        /// <returns>X coordinate</returns>
        private int GetReverseDPaths(ArraySegment<T> subArrayA, ArraySegment<T> subArrayB, int d, int k, int delta)
        {
            var vector = _vectorReverse;

            var p = k + delta;

            int x;
            if (k == -d || k != d && vector[p + 1] <= vector[p - 1])
            {
                x = vector[p + 1] - 1;
            }
            else
            {
                x = vector[p - 1];
            }

            var y = x - p;

            while (x > 0 && y > 0 && _equalityComparer.Equals(subArrayA[x-1],subArrayB[y-1]) )
            {
                x--;
                y--;
            }

            vector[p] = x;

            return x;
        }

        /// <summary>
        /// Setup some "fictitious" endpoints for initial forward and reverse path navigation.
        /// </summary>
        /// <param name="subArrayA">Sub-sequence A</param>
        /// <param name="subArrayB">Sub-sequence B</param>
        /// <returns>True - fictitious points added</returns>
        private bool SetupFictitiousPoints(ArraySegment<T> subArrayA, ArraySegment<T> subArrayB)
        {
            if (subArrayA.Count > 0 && subArrayB.Count > 0)
            {
                // Setup some "fictitious" endpoints for initial forward
                // and reverse path navigation.
                _vectorForward[1] = 0;
                var n = subArrayA.Count;
                var m = subArrayB.Count;
                var delta = n - m;
                _vectorReverse[delta + 1] = n + 1;

                return true;
            }

            return false;
        }
    }}
