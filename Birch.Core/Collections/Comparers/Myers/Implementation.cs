using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Collections.Comparers.Myers
{
    public static class Implementation
    {
        public static IReadOnlyList<Operation<T>> Diff<T>(T[] old, T[] @new, IEqualityComparer<T> comparer)
        {
            var diff = new MyersDiff<T>(old,@new,true);

            var result = diff.Execute();

            var steps = new List<Operation<T>>(result.Count);

            foreach (var resultItem in result)
            {
                switch (resultItem.EditType)
                {
                    case TextEditType.None:
                        break;
                    case TextEditType.Delete:
                        for (var i = resultItem.Length-1; i >= 0; i--)
                        {
                            steps.Add(new DeleteOp<T>(i+resultItem.StartA,old[i+resultItem.StartA]));
                        }
                        break;
                    case TextEditType.Insert:

                        for (var i = 0; i < resultItem.Length; i++)
                        {
                            steps.Add(new InsertOp<T>(i+resultItem.StartA, @new[i+resultItem.StartB]));
                        }

                        break;
                    case TextEditType.Change:

                        for (var i = 0; i < resultItem.Length; i++)
                        {
                            steps.Add(new UpdateOp<T>(i + resultItem.StartA, old[i + resultItem.StartA],
                                @new[i + resultItem.StartB]));
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return steps;
        }

    }
}
