using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;

using Xamarin.Forms;

namespace CodedUIExperiment.Views
{
    public class CodeWip : ContentPage
    {
        public static IScheduler UIScheduler;

        private Frame _v1;
        private BoxView _v2
            ;

        public CodeWip()
        {
            var g = new Grid();


            Observable.Interval(TimeSpan.FromSeconds(1)).ObserveOn(UIScheduler).Do(x =>
            {
                //if ((x % 2) == 0)
                //{
                //    Grid.SetColumnSpan(_v2, 1);
                //}
                //else
                //{
                //    Grid.SetColumnSpan(_v2, 2);
                //}
            }).Subscribe();


            var row = new RowDefinition() {Height = new GridLength(120)};
            var row2 = new RowDefinition() {Height = new GridLength(60)};

            var rowCollection = new RowDefinitionCollection() {row, row2};

            g.RowDefinitions = rowCollection;

            var column = new ColumnDefinition() {Width = new GridLength(200, GridUnitType.Auto)};
            var column2 = new ColumnDefinition() {Width = new GridLength(200, GridUnitType.Auto)};

            var columnDefinition = new ColumnDefinitionCollection() {column, column2};

            g.ColumnDefinitions = columnDefinition;

            _v1 = new Frame
            {
                Content = new BoxView() {BackgroundColor = Color.Pink},
                BorderColor = Color.Chocolate,
                CornerRadius = 4.0f
            };

            _v2 = new BoxView() {BackgroundColor = Color.Blue};

            Content = g;

            g.Children.Add(_v1);

            g.Children.Add(_v2);

            Grid.SetColumn(_v1,0);
            Grid.SetRow(_v1,0);

            Grid.SetColumn(_v2,0);
            Grid.SetRow(_v2,1);

            // now then, I think we can use a standard collection, BUT we perhaps need to consider the update cycle (not initial)

            // so the object could be considered changed due to the colspan changing.
            // similarly the attached property updater is also fine for this..
            // BUT we will think the primitive has changed and force an update cycle for it,when infact it directly hasn't.
            // BUT we need the update to occur to force the attributes to be updated.... f**kin marvellous !

            // for the children, we need to retain them , as usual, i think this potentially just works?

        }
    }
}