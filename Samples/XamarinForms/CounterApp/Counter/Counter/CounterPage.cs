using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Birch.Components;
using Birch.Compose;
using Birch.Hosts;
using Birch.Views;
using Xamarin.Forms;
using static Birch.Views.Primitives;

namespace Counter
{
    public class CounterPage : BaseContentPage<CounterPage.Model>
    {
        private readonly Timer _timer = new Timer(100) {Enabled = false, AutoReset = true};
        private Model _model;

        public class Model
        {
            public double Count { get; set; }
            public double Step { get; set; }
            public bool TimerOn { get; set; }
        }

        public CounterPage()
        {
            _timer.Elapsed += (_, __) =>
            {
                _model.Count += _model.Step;
                this.SetModel(_model);
            };
        }

        public override Model InitState() => _model = new Model() {Count = 0, Step = 1, TimerOn = false};

        protected override IPrimitive PerformLayout(LayoutContext layoutContext, CounterPage.Model model)
        {
            return StackLayout(
                new IPrimitive[]
                {
                    Label($"{model.Count}").HorizontalOptions(LayoutOptions.Center).WidthRequest(200.0)
                        .HorizontalTextAlignment(TextAlignment.Center),
                    Button("Increment").OnClicked(Increment),
                    Button("Decrement").OnClicked(Decrement),
                    StackLayout(new IPrimitive[]
                    {
                        Label("Timer"),
                        Switch(model.TimerOn).OnToggled((t) => Toggled(t.Value))
                    }).Orientation(StackOrientation.Horizontal).HorizontalOptions(LayoutOptions.Center),
                    Slider(0, 10).Value(model.Step).OnValueChanged(x => SetStep(x.NewValue)),
                    Label($"Step size {model.Step}").HorizontalOptions(LayoutOptions.Center),
                    Button("Reset").HorizontalOptions(LayoutOptions.Center).OnClicked(Reset)
                }
            ).Padding(new Thickness(30.0)).VerticalOptions(LayoutOptions.Center);
        }

        private void Toggled(bool on)
        {
            _timer.Enabled = on;
            _model.TimerOn = on;
            this.SetModel(_model);
        }

        private void Reset()
        {
            _timer.Enabled = false;
            _ = InitState();
            this.SetModel(_model);
        }

        private void SetStep(double amount)
        {
            _model.Step = amount;
            this.SetModel(_model);
        }

        private void Decrement()
        {
            _model.Count -= _model.Step;
            this.SetModel(_model);
        }

        private void Increment()
        {
            _model.Count += _model.Step;
            this.SetModel(_model);
        }
    }
}