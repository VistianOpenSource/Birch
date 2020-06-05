using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Collections.Comparers.Myers
{
   /// <summary>
    /// Any two dimensional point structure
    /// </summary>
    /// <typeparam name="T">Runtime type of coordinates</typeparam>
    public struct Point2D<T>
        where T : struct
    {
        /// <summary>
        /// X coordinate
        /// </summary>
        public T X { get; }

        /// <summary>
        /// Y coordinate
        /// </summary>
        public T Y { get; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Returns hashcode for this struct
        /// </summary>
        /// <returns>Hashcode of the current structure</returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <summary>
        /// Decide if the input object is equal to this one
        /// </summary>
        /// <param name="obj">Input object</param>
        /// <returns>True - input object and this struct is equals</returns>
        public override bool Equals(object? obj)
        {
            return obj is Point2D<T> && Equals((Point2D<T>)obj);
        }

        /// <summary>
        /// Decide if the input point is equal to this one
        /// </summary>
        /// <param name="other">Input point</param>
        /// <returns>True - input point and this one is equals</returns>
        public bool Equals(Point2D<T> other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        /// <summary>
        /// Custom equality operator
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>True - points are equal</returns>
        public static bool operator ==(Point2D<T> left, Point2D<T> right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Custom non-equality operator
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>True - points are NOT equal</returns>
        public static bool operator !=(Point2D<T> left, Point2D<T> right)
        {
            return !left.Equals(right);
        }
    }}
