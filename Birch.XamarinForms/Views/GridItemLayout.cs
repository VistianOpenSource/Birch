using System;

namespace Birch.Views
{
    /// <summary>
    /// Property for <see cref="Xamarin.Forms.Grid"/> that allows for the layout of an entry within a grid
    /// to be specified.
    /// </summary>
    public readonly struct GridItemLayout:IEquatable<GridItemLayout>
    {
        /// <summary>
        /// Get the specified row
        /// </summary>
        public int Row { get; }

        /// <summary>
        /// Get the specified column
        /// </summary>
        public int Column { get; }

        /// <summary>
        /// Get the specified row span
        /// </summary>
        public int RowSpan { get; }

        /// <summary>
        /// Get the specified column span
        /// </summary>
        public int ColumnSpan { get; }

        public GridItemLayout(int row, int column, int rowSpan, int columnSpan)
        {
            Row = row;
            Column = column;
            RowSpan = rowSpan;
            ColumnSpan = columnSpan;
        }

        public static GridItemLayout Create(int? row = default, int? column = default, int? rowSpan = default, int? columnSpan = default)
        {
            return new GridItemLayout(row ?? 0,column ?? 0,rowSpan ?? 0,columnSpan ?? 0);
        }

        public bool Equals(GridItemLayout other)
        {
            return Row == other.Row && Column == other.Column && RowSpan == other.RowSpan && ColumnSpan == other.ColumnSpan;
        }

        public override bool Equals(object obj)
        {
            return obj is GridItemLayout other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column, RowSpan, ColumnSpan);
        }

        public static bool operator ==(GridItemLayout left, GridItemLayout right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GridItemLayout left, GridItemLayout right)
        {
            return !left.Equals(right);
        }
    }
}