# Birch

A platform agnostic .NET library for the creation of code first user interfaces.

Specify your user interface in code using controls that you are already familiar with and let Birch do the rest.

## Key Functionality

* Platform agnostic, not tied to either native platforms like Android/iOS or cross platform solutions like Xamarin Forms.
* Use the same control names, types, properties & events you are already using, no need to learn a new set of abstractions.
* 3rd party controls e.g. maps easily onboarded, minimal additional code typically needed.
* Create composite components for greater code reuse.
* User Interface processing performed on background threads-UI thread only used to apply changes to UI components.
* Linker aware, full linking supported allowing for the smallest fastest applications.
* Extensible, customizable behaviour of core functionality e.g. error handling, comparators etc.
* Logging & performance metrics provided through Microsoft logging abstractions, plumb in your favour logging library.

## Sample Component

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
            _current = new Model("enter your username", "this is the password");
        }

        public override Model InitState() => _current;

        protected override IPrimitive PerformLayout(LayoutContext layoutContext, Model model)
        {
            IEnumerable<IPrimitive> Items()
            {
                yield return EditText(model.Name).
                    OnCreate((Shadow<EditText> s) => { s.Item.RequestFocus(); }).
                    OnTextChanged(OnUsernameChanged);

                if (!model.IsNameValid)
                {
                    yield return TextView("Your input isn't valid", Dimensions.MatchMatch).SetTextColor(Color.Red).SetTextSize(ComplexUnitType.Dip, 24.0f);
                }

                yield return EditText(model.Password).InputType(InputTypes.ClassText | InputTypes.TextVariationPassword);
            };

            return LinearLayout(Items(),Dimensions.MatchWrap).Orientation(Orientation.Vertical).Comparer(MyerComparer<IPrimitive>.Default);
        }

        private void OnUsernameChanged(TextChangedEventArgs args)
        {
            _current.Name = args.Text?.ToString();

            this.SetState(_current);
        }
    }
~~~~



  