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
        public static CollectionView CollectionView(params IPrimitive[] children) => new CollectionView(children.ToArray());

        public static CollectionViewGrouped CollectionViewGrouped(IEnumerable<CollectionViewGroupedChild> children) => new CollectionViewGrouped(children.ToArray());
        public static CollectionViewGrouped CollectionViewGrouped(params CollectionViewGroupedChild[] children) => new CollectionViewGrouped(children.ToArray());

        public static ContentView<TElement> ContentView<TElement>(IReflectedPrimitive<TElement> content) where TElement : ContentView => new ContentView<TElement>(content);

        public static FlexLayout FlexLayout(IEnumerable<IPrimitive> children)  => new FlexLayout(children.ToArray());
        public static FlexLayout FlexLayout(params IPrimitive[] children)  => new FlexLayout(children.ToArray());

        public static Frame Frame(IPrimitive content) => new Frame(content);

        public static Grid Grid(RowDefinition[] rowDefinitionCollection,
            ColumnDefinition[] columnDefinitionCollection,IEnumerable<IPrimitive> children) => new Grid(children.ToArray(), rowDefinitionCollection, columnDefinitionCollection);

        public static Grid Grid(RowDefinition[] rowDefinitionCollection,
            ColumnDefinition[] columnDefinitionCollection,params IPrimitive[] children) => new Grid(children.ToArray(), rowDefinitionCollection, columnDefinitionCollection);

        public static ListView ListView(IEnumerable<IReflectedPrimitive<Xamarin.Forms.Cell>> children) => new ListView(children.ToArray());
        public static ListView ListView(params IReflectedPrimitive<Xamarin.Forms.Cell>[] children) => new ListView(children.ToArray());

        public static ListViewGrouped ListViewGrouped(IEnumerable<ListViewGroupedChild> children) => new ListViewGrouped(children.ToArray());
        public static ListViewGrouped ListViewGrouped(params ListViewGroupedChild[] children) => new ListViewGrouped(children.ToArray());

        public static ScrollView ScrollView(IPrimitive content) => new ScrollView(content);

        public static StackLayout StackLayout(IEnumerable<IPrimitive> children) => new StackLayout(children.ToArray());
        public static StackLayout StackLayout(params IPrimitive[] children) => new StackLayout(children.ToArray());

        public static ContentPage ContentPage(Xamarin.Forms.ContentPage contentPage, IPrimitive content) => new ContentPage(contentPage, content);

        public static ViewCell ViewCell(IPrimitive content) => new ViewCell(content);

        public static CarouselView CarouselView(params IPrimitive[] children) => new CarouselView(children.ToArray());
        public static CarouselView CarouselView(IEnumerable<IPrimitive> children) => new CarouselView(children.ToArray());
    }
}
