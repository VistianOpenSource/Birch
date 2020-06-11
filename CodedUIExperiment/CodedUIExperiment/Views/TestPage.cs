using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Linq;
using System.Text;
using Birch.Annotations;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Hosts;
using Birch.Reflection;
using Birch.Views;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.PlatformConfiguration;
using Attribute = Birch.Components.Attribute;
using Grid = Xamarin.Forms.Grid;
using static Birch.Views.Primitives;
using ContentPage = Xamarin.Forms.ContentPage;

namespace CodedUIExperiment.Views
{
    public class TestPage:BaseContentPage
    {
        private Lists _lists;

        public TestPage()
        {
            //Observable.Interval(TimeSpan.FromSeconds(5)).Do(x => this.SetModel((int)x)).Subscribe();
        }


        public override void Init(BuildEnvironment buildEnvironment)
        {
            // lets setup the layout tracing
            _lists = new Lists(buildEnvironment);


            //ll.SetGravity()
        }

        protected override IPrimitive PerformLayout(LayoutContext layoutContext)
        {
            return _lists.PerformLayout(layoutContext);
        }
    }


    public class Lists:StatefulContainer<int>
    {
        public Lists(BuildEnvironment environment) : base(environment)
        {
            Observable.Interval(TimeSpan.FromSeconds(1)).Take(100).Do(x => 

                this.SetModel((int)x)).
                Subscribe();
        }

        public override int InitState()
        {
            return 0;
        }

        private static GradientStopCollection _stops = new GradientStopCollection()
        {
            new GradientStop() {Color = Color.Red, Offset = 0.0f},
            new GradientStop() {Color = Color.Blue, Offset = 1.0f}
        };

        public abstract class   Msg
        {

        }
        public class Msg<TContent>:Msg
        {
            public TContent Content { get; }

            public Msg(TContent content) => Content = content;
        }

        public class ValueChangedMsg:Msg<(double oldValue,double newValue)>
        {
            public ValueChangedMsg(double oldValue, double newValue):base((oldValue,newValue))
            {
            }

            public static implicit operator ValueChangedMsg(ValueChangedEventArgs args) => new ValueChangedMsg(args.OldValue,args.NewValue);
        }

        public class PasswordUpdated : Msg
        {

        }

        protected void Dispatch<TMsg>(TMsg msg) where TMsg:Msg
        {
            // need to do something here

            Update(msg);
        }

        protected void Update(Msg message)
        {
            switch (message)
            {
                case ValueChangedMsg vcm:
                    Console.WriteLine($"Slider changes from {vcm.Content.oldValue} to {vcm.Content.newValue}");
                    break;

                case PasswordUpdated pu:
                    break;
            }
        }

        protected override IPrimitive PerformLayout(LayoutContext layoutContext, int model)
        {
            model++;

            Stopwatch sw = Stopwatch.StartNew();
            
            var primitives = Enumerable.Range(0, model).Select(r =>
            {
                var el = Label($"constructor2").FontSize(24.0); //.With(x => x.FontSize, 24.0);

                if (r == 0)
                {
                    return new Fix(() =>
                    {
                        var ff = new Birch.Views.Frame(el);

                        var el2 = Slider(0, 5000);

                        el2.OnValueChanged((v) => { Dispatch<ValueChangedMsg>(v); });

                        var pancake = new ContentView<PancakeView>(el2);
                        pancake.With(pc => pc.BackgroundColor, Color.Aqua);
                        pancake.With(c => c.CornerRadius, new CornerRadius(60, 0, 0, 60));
                        pancake.With(c => c.HeightRequest, 150);
                        pancake.With(c => c.BackgroundGradientAngle, 45).With(c => c.BackgroundGradientStops, _stops);
                        ;

                        ff.With(f => f.CornerRadius, 4.0f).With(f => f.BorderColor, Color.Red)
                            .With(f => f.HasShadow, true);

                        ff.With(f => f.Padding, new Thickness(1, 1, 1, 1));
                        ff.With(f => f.BackgroundColor, Color.Blue);
                        ff.With(f => f.Margin, new Thickness(0, 5));
                        return (IPrimitive) pancake;
                    }).PerformLayout(layoutContext);
                }
                else
                {
                    return el;
                }
            });



            //var primitiveGroupedCells = Enumerable.Range(0, model).Select(r =>
            //    {
            //        var header = new XamFormsVisualElement<TextCell>().With(x => x.Text, $"Header {r}");

            //        if (r == 0)
            //        {
            //            var el = new XamFormsVisualElement<Xamarin.Forms.TextCell>().With(x => x.Text,
            //                $"CELL-hello there {r}");

            //            return new ListViewGroupChild($"{r}-short",$"{r}-{r}-title",new IPrimitive[]{el});
            //        }
            //        else
            //        {
            //            var el = new XamFormsVisualElement<Xamarin.Forms.TextCell>().With(x => x.Text,
            //                $"CELL-hello there - {r}");

            //            return new ListViewGroupChild($"{r}-short",$"{r}-{r}-title",new IPrimitive[]{el});

            //        }
            //    })
            //    .ToArray();

            //var primitiveGrouped = Enumerable.Range(0, model).Select(r =>
            //{
            //    var header = Label($"Header {r} {System.DateTimeOffset.Now}");

            //    if (r == 0)
            //    {
            //        var el = Label($"CELL-hello there {r}");

            //        var button = Button("button").IsEnabled(model % 2 == 0);


            //        button.ImageFromUri(
            //            "https://www.ft.com/__origami/service/image/v2/images/raw/http%3A%2F%2Fprod-upp-image-read.ft.com%2Fde682e32-9932-11ea-adb1-529f96d8a00b?source=next&fit=scale-down&compression=best&width=340");

            //        return new CollectionViewGroupedChild(new IPrimitive[] {el, button}, header);
            //        //b1.With(b => b.Command);

            //    }
            //    else
            //    {
            //        var el = Label($"CELL-hello there {r}");

            //        return new CollectionViewGroupedChild(new IPrimitive[] {el}, header);

            //    }
            //});
               

            //var row = new RowDefinition() {Height = new GridLength(120)};
            //var row2 = new RowDefinition() {Height = new GridLength(60)};

            //var row3 = new RowDefinition() {Height = new GridLength(1, GridUnitType.Auto)};

            //var column = new ColumnDefinition() {Width = new GridLength(5, GridUnitType.Auto)};
            //var column2 = new ColumnDefinition() {Width = new GridLength(5, GridUnitType.Auto)};

            //var _v1 = new BoxView(){BackgroundColor=Color.Pink};
            //var _v2 = new BoxView() {BackgroundColor = Color.Blue};

            //Grid.SetColumn(_v1,0);
            //Grid.SetRow(_v1,0);

            //Grid.SetColumn(_v2,0);
            //Grid.SetRow(_v2,1);

            //var detailGrid = new Birch.Views.Grid(primitives,new RowDefinition[]{row,row2},new ColumnDefinition[]{column,column2} );

            //var detail = new Birch.Views.StackLayout(primitives);

            //var detailFlexLayout = new Birch.Views.FlexLayout(primitives);

            //detailFlexLayout.With(l => l.Direction, FlexDirection.Row);


            //var detailsGroupedList = new Birch.Views.ListViewGrouped(primitiveGroupedCells);

            //var detailsCollectionView = new Birch.Views.CollectionView(primitives);

            //var detailsGroupedCollectionView = new Birch.Views.CollectionViewGrouped(primitiveGrouped);

            //detailsGroupedCollectionView.Attributes.SetAttribute(XamLayoutGroup.HeaderAttribute,
            //    new XamFormsVisualElement<Label>().With(x => x.Text, $"TOP Header {System.DateTimeOffset.Now}"));


            //detailsGroupedCollectionView.With(d => d.ItemsLayout,LinearItemsLayout.Vertical);


            //var primitiveCells = Enumerable.Range(0, model).Select(r =>
            //    {
            //        if (r == 0)
            //        {
            //            var el = new XamFormsVisualElement<Xamarin.Forms.TextCell>().With(p,
            //                $"hello there {r}");
            //            return el;
            //        }
            //        else
            //        {
            //            var el = new XamFormsVisualElement<Xamarin.Forms.TextCell>().With(p,
            //                $"hello there {r}");
            //            return el;
            //        }
            //    })
            //    .ToArray();

            //var detailsList = ListView(Enumerable.Range(0, model).Select(r => TextCell($"Hello there {r}")));

            //var detailsGroupedCollectionView = CollectionViewGrouped(primitiveGrouped);

            Console.WriteLine($"TestPage ---------------->{sw.ElapsedMilliseconds}");

            //return detailsGroupedCollectionView;

            var detail = StackLayout(primitives);

            return ScrollView(detail).Orientation(ScrollOrientation.Vertical);
            //return detailFlexLayout;
            //return detailsList;
            //return detail;
        }
    }



    public static partial class Primitives
    {

        //public static XamarinFormsViewGroup<Xamarin.Forms.StackLayout> StackLayout(IEnumerable<IPrimitive> children)
        //{
        //    if (Components.Primitives.NeverInclude)
        //    {
        //        var instance = new Xamarin.Forms.StackLayout();
        //    }

        //    var control = ViewGroup<Xamarin.Forms.StackLayout>(children);
        //    return control;
        //}




        public interface ILayoutChild
        {
            public IPrimitive Primitive {get;}
        }

        public interface ILayoutChild<out TAttribute>:ILayoutChild
        {
            public TAttribute Attribute { get; }
        }
    }

    public class XamFormsGroup
    {
        public static Attribute<Primitives.ILayoutChild[]> ChildrenAttribute = Attribute.Register(Attribute.Name<XamFormsGroup>(nameof(ChildrenAttribute)),true,ArrayComparer<Primitives.ILayoutChild>.Default);

//        public static Attribute<ICollectionComparer> ComparerAttribute = Attribute.Register<ICollectionComparer>(Attribute.Name<Group>(nameof(ComparerAttribute)));
    }
}

