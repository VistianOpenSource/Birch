# Birch

A platform agnostic .NET library for the creation of code first user interfaces.

Code your user interface, update your state, and let Birch do the rest.

## Key Functionality

* **Platform agnostic**-Not tied to either native platforms like Android/iOS or cross platform solutions like Xamarin Forms.
* **Familiarity**-Use the same control names, types, properties & events you are already using, no need to learn a new set of abstractions.
* **3rd party controls**-Easily onboarded with typically a minimal amount of additional code.
* **Composite components**-Greater code reuse.
* **Responsive apps by default**-Majority of work occurs background threads;UI thread used only to apply changes.
* **Linker aware**-Full linking supported allowing for the smaller faster applications.
* **Extensible**-Customizable behaviour of core functionality e.g. error handling, comparators etc.
* **Logging**-Logging provided through Microsoft logging abstractions, plumb in your favour logging library.
* **Performance Metrics**-Observe the inner workings of you User Interface.
* **Separation of Concerns**-Use different user interface layouts on different platforms. 

See the Wiki for lots more information  [Wiki](https://github.com/VistianOpenSource/Birch/wiki).

## Sample Usage

A simple Activity in which the UserDetails widget is created and used for the layout. 

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

## Sample Component

* A random component that allows the user to enter a name and a password. 
* If the name is less than 10 characters, an error message is shown. 
* When the component is first used the **InitState** method would be called to get the initial model.
* Upon first layout, the focus is set to the user name edit. 
* Everytime the user makes a change the model is updated with the new username and the new model is specified through the **SetState** method.

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



  