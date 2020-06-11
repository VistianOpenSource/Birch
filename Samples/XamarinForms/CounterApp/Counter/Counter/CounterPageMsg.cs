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
    public class CounterPageMsg : BaseContentPage<CounterPageMsg.Model>
    {
        private readonly Timer _timer = new Timer(10) {Enabled = false, AutoReset = true};
        private Model _model;

        public class Model
        {
            public double Count { get; set; }
            public double Step { get; set; }
            public bool TimerOn { get; set; }
        }

        public CounterPageMsg()
        {
            _timer.Elapsed += (sender, args) => Dispatch(new TimerTick());
        }

        public class Increment : Msg { }
        public class Decrement : Msg { }
        public class Reset : Msg { }
        public class Toggle : Msg<bool> { }
        public class SetStep : Msg<double> { }
        public class TimerTick : Msg{}

        private void Dispatch(Msg msg) => Update(msg);

        private void Update(Msg msg)
        {
            switch (msg)
            {
                case Increment _:
                    _model.Count += _model.Step;
                    break;
                case Decrement _:
                    _model.Count -= _model.Step;
                    break;
                case Reset _:
                    _timer.Enabled = false;
                    InitState();
                    break;
                case Toggle t:
                    _timer.Enabled = t;
                    _model.TimerOn = t;
                    break;
                case SetStep s:
                    _model.Step = s;
                    break;
                case TimerTick _:
                    _model.Count += _model.Step;
                    break;
            }
            SetModel(_model);
        }

        public override Model InitState() => _model = new Model() {Count = 0, Step = 1, TimerOn = false};

        protected override IPrimitive PerformLayout(LayoutContext layoutContext, Model model) =>
            StackLayout(
                Label($"{model.Count}").HorizontalOptions(LayoutOptions.Center).WidthRequest(200.0).HorizontalTextAlignment(TextAlignment.Center),
                    Button("Increment").OnClicked(() => Dispatch(new Increment())),
                    Button("Decrement").OnClicked(() => Dispatch(new Decrement())),
                    StackLayout(
                        Label("Timer"), Switch(model.TimerOn).OnToggled((t) => Dispatch(new Toggle{Content=t.Value}))).
                    Orientation(StackOrientation.Horizontal).HorizontalOptions(LayoutOptions.Center),
                    Slider(0, 10).Value(model.Step).OnValueChanged((x) => Dispatch(new SetStep{Content = x.NewValue})),
                    Label($"Step size {model.Step}").HorizontalOptions(LayoutOptions.Center),
                    Button("Reset").HorizontalOptions(LayoutOptions.Center).OnClicked(() => Dispatch(new Reset()))
            ).Padding(new Thickness(30.0)).VerticalOptions(LayoutOptions.Center);
    }
}