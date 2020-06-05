using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Birch.Components;
using Birch.Reflection;
using Xamarin.Forms;

namespace Birch.Views
{
    public static partial class Primitives
    { 
        public static CollectionView CollectionView(IEnumerable<IPrimitive> children) => new CollectionView(children.ToArray());

        public static CollectionViewGrouped CollectionViewGrouped(IEnumerable<CollectionViewGroupedChild> children) => new CollectionViewGrouped(children.ToArray());

        public static ContentView<TElement> ContentView<TElement>(IReflectedPrimitive<TElement> content) where TElement : ContentView => new ContentView<TElement>(content);

        public static FlexLayout FlexLayout(IEnumerable<IPrimitive> children)  => new FlexLayout(children.ToArray());

        public static Frame Frame(IPrimitive content) => new Frame(content);

        public static Grid Grid(IEnumerable<IPrimitive> children, RowDefinition[] rowDefinitionCollection,
            ColumnDefinition[] columnDefinitionCollection) => new Grid(children.ToArray(), rowDefinitionCollection, columnDefinitionCollection);

        public static ListView ListView(IEnumerable<IReflectedPrimitive<Xamarin.Forms.Cell>> children) => new ListView(children.ToArray());

        public static ListViewGrouped ListViewGrouped(IEnumerable<ListViewGroupedChild> children) => new ListViewGrouped(children.ToArray());

        public static ScrollView ScrollView(IPrimitive content) => new ScrollView(content);

        public static StackLayout StackLayout(IEnumerable<IPrimitive> children) => new StackLayout(children.ToArray());
    }
}
