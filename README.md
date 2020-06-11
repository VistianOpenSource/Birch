# Birch

A platform agnostic .NET library for the creation of code first user interfaces.

Code your user interface, update your state, and let Birch do the rest.

## Key Functionality

* **Platform agnostic**-Not tied to native platforms like Android/iOS or cross platform solutions like Xamarin Forms.
* **Familiarity**-Use the same control names, types, properties & events you are already using, no new set of abstractions to learn.
* **3rd party controls**-Easily onboarded,frequently with no additional code required.
* **Composite components**-Greater code reuse, greater reliability.
* **Responsive apps by default**-Majority of work occurs on background threads;UI thread used only to apply changes.
* **Linker aware**-Full linking supported, allowing for smaller faster applications.
* **Extensible**-Customizable behaviour of core functionality e.g. error handling, comparators etc.
* **Logging**-Logging provided through Microsoft logging abstractions, carry on using your favour logging library.
* **Performance Metrics**-Observe the inner workings of you User Interface.
* **Separation of Concerns**-Use different user interface layouts on different platforms. 

See the Wiki for more information  [Wiki](https://github.com/VistianOpenSource/Birch/wiki).

## Sample Usage

A simple Android Activity in which the UserDetails widget is created and used for the layout. 

~~~~
[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
public class NewMainActivity : BuildActivity
{
    private UserDetails _userDetails;

    public override void Init(BuildEnvironment buildEnvironment)
    {
        _userDetails = new UserDetails(buildEnvironment);
    }

    protected override IPrimitive PerformLayout(LayoutContext layoutContext) =>
        new Activity(this, _userDetails.Layout(layoutContext))
            .Title("Edit User Details")
            .Call((a, p) => a.SetPersistent(p), true);
}
~~~~
*Illustrates the usage of expression parsing for the 'Call'.*

An implementation of a simple counter app in Xamarin Forms

~~~~
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
}
~~~~

## Sample Component

* A random component that allows the user to enter a name and a password. 
* If the name is less than 10 characters, an error message is shown. 
* When the component is first used the **InitState** method would be called to get the initial model.
* Upon first layout, the focus is set to the user name edit. 
* Everytime the user makes a change in the user name edit, the model is updated with the new username and a new model is specified through the **SetState** method. 
* Birch schedules the work required to perform any user interface updates everytime SetState is used.

~~~~
   public class UserPasswordWidget : StatefulContainer<UserPasswordWidget.Model>
    {
        public class Model
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public bool IsNameValid => Name.Length >= 10;

            public Model(string name, string password) => (Name, Password) = (name, Password);
        }

        private readonly Model _current;

        public UserPasswordWidget(BuildEnvironment environment) : base(environment)
        {
            _current = new Model("enter your user name", "this is the password");
        }

        public override Model InitState() => _current;

        protected override IPrimitive PerformLayout(LayoutContext layoutContext, Model model)
        {
            IEnumerable<IPrimitive> Items()
            {
                yield return EditText(model.Name)
                            .OnCreate((Shadow<EditText> s) => { s.Item.RequestFocus(); })
                            .OnTextChanged(OnUsernameChanged);

                if (!model.IsNameValid)
                {
                    yield return TextView("Your username isn't valid", Dimensions.MatchMatch)
                                .SetTextColor(Color.Red)
                                .SetTextSize(ComplexUnitType.Dip, 24.0f);
                }

                yield return EditText(model.Password)
                            .InputType(InputTypes.ClassText | InputTypes.TextVariationPassword);
            };

            return LinearLayout(Items(),Dimensions.MatchWrap)
                  .Orientation(Orientation.Vertical);
        }

        private void OnUsernameChanged(TextChangedEventArgs args)
        {
            _current.Name = args.Text?.ToString();
            this.SetState(_current);
        }
    }
~~~~



  