using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Shadows;
using Xamarin.Forms;

namespace Birch.Views
{
    public static class GridExtensions
    {
        public static Attribute<int> Row = Components.Attribute.Register<int>(Components.Attribute.Name<Xamarin.Forms.Grid>(nameof(Xamarin.Forms.Grid.RowProperty)));
        public static Attribute<int> Column = Components.Attribute.Register<int>(Components.Attribute.Name<Xamarin.Forms.Grid>(nameof(Xamarin.Forms.Grid.ColumnProperty)));

        public static Attribute<int> RowSpan = Components.Attribute.Register<int>(Components.Attribute.Name<Xamarin.Forms.Grid>(nameof(Xamarin.Forms.Grid.RowSpanProperty)));
        public static Attribute<int> ColumnSpan = Components.Attribute.Register<int>(Components.Attribute.Name<Xamarin.Forms.Grid>(nameof(Xamarin.Forms.Grid.ColumnSpanProperty)));
    }

    public class GridListThing
    {
        private Xamarin.Forms.Grid _grid;

        public GridListThing(Xamarin.Forms.Grid grid)
        {
            _grid = grid;
        }

        public void Apply(IPrimitive primitive,IShadow<Xamarin.Forms.View> shadowView)
        {

            //_gridList.Add

            var row = primitive.Attributes.GetAttributeOrDefault(GridExtensions.Row);
            var column = primitive.Attributes.GetAttributeOrDefault(GridExtensions.Column);

            var rowSpan = primitive.Attributes.GetAttributeOrDefault(GridExtensions.RowSpan);
            var columnSpan = primitive.Attributes.GetAttributeOrDefault(GridExtensions.ColumnSpan);

            // now then, how to apply...

            _grid.Children.Add(shadowView.Item, row, column, rowSpan, columnSpan);

            // so, if the row/column, rowSpan or columnSpan have changed then
            // we need to do a remove and an insert - this is for updates

            // otherwise its an add

            // similarly, you can't do an insert at a position, its always an add !
            // which makes for collection comparison a bit interesting ?

            // the collection may say, do an insert at a position, but thats not possible with the current api , and instead
            // we have to return to using the column span and row things instead...

            // we could, just apply the view changes BUT.. we have an order problem
            //Grid.SetColumn(shadowView.Item,column);

            

        }
    }



}
