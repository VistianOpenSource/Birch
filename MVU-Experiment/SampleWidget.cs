using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Widget;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Hosts;
using Birch.Shadows;
using Birch.Views;
using static Birch.Views.Primitives;


namespace MVU_Experiment
{
    public class UserPasswordWidget : StatefulContainer<UserPasswordWidget.Model>
    {
        public class Model
        {
            public string Name { get; set; }

            public bool IsNameValid => Name.Length >= 10;

            public string Password { get; set; }

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

            this.SetModel(_current);
        }
    }
}