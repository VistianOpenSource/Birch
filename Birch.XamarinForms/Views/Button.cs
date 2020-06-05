using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Attribute = Birch.Components.Attribute;

namespace Birch.Views
{


    [ShadowMapper(typeof(ButtonShadowMapper))]
    public class Button : XamFormsVisualElement<Xamarin.Forms.Button>
    {
        public static Attribute<bool> ButtonEnabledAttribute = Components.Attribute.Register<bool>(Components.Attribute.Name<Xamarin.Forms.Button>(nameof(ButtonEnabledAttribute)));
    }

    public static class VisualElementExtensions
    {
        public static Attribute<Action> CommandAttribute =
            Components.Attribute.Register<Action>(
                Components.Attribute.Name<Xamarin.Forms.VisualElement>(nameof(CommandAttribute)));
    }

    public static class ButtonExtensions
    {
        public static Button Cmd(this Button control, Action cmd)
        {
            control.Attributes.SetAttribute(VisualElementExtensions.CommandAttribute, cmd);

            Xamarin.Forms.Button b;


            return control;
        }
    }
    
    /// <summary>
    /// Provides a default shadow mapping operation for <see cref="Xamarin.Forms.Button"/>
    /// </summary>
    public class ButtonShadowMapper : BasePrimitiveShadowMapper<XamFormsContext,Xamarin.Forms.Button,Birch.Views.Button>
    {
        protected override Xamarin.Forms.Button CreateItem(XamFormsContext context,Button element) 
        {
            var instance = new Xamarin.Forms.Button();

            return instance;
        }

        /// <summary>
        /// Create the UI
        /// </summary>
        /// <param name="context"></param>
        /// <param name="initial"></param>
        /// <returns></returns>
        protected override IShadow<Xamarin.Forms.Button> Create(XamFormsContext context, Button initial)
        {
            // call down to the base to get the shadow 
            var shadow = (Shadow<Xamarin.Forms.Button>) base.Create(context, initial);

            var cmd = new MyCommandWrapper();
            shadow.Item.Command = cmd;
            shadow.State.Set<MyCommandWrapper>(cmd);

            return shadow;
        }

        /// <summary>
        /// Update the UI
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        /// <remarks></remarks>
        /// <remarks>
        /// We do the children first, then we do 'this' level
        /// </remarks>
        protected override void Update(XamFormsContext context, IShadow<Xamarin.Forms.Button> shadow, Button current, Button next)
        {
            // and finally do this...

            Button.ButtonEnabledAttribute.Update(context, shadow, current, next, (s, c, a) =>
                {
                    var cmd = s.State.Get<MyCommandWrapper>();
                    cmd.IsEnabled = a;
                }, (s, x, c, n) =>
                {
                    var cmd = s.State.Get<MyCommandWrapper>();
                    cmd.IsEnabled = n;
                },
                (s, x,c) => { });

            base.Update(context, shadow, current, next);
        }

        /// <summary>
        /// Remove this control from the UI
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <remarks>
        ///     We remove the children first, then do any 'remove' at this level
        /// </remarks>
        protected override void Remove(XamFormsContext context, IShadow<Xamarin.Forms.Button> shadow, Button current)
        {
            base.Remove(context, shadow, current);
        }
    }

        public class MyCommandWrapper : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return IsEnabled && !_executing;
            }

            private bool _executing = false;

            public void Execute(object parameter)
            {
                try
                {
                    _executing = true;

                    CanExecuteChanged?.Invoke(this,new EventArgs());

                    Executed?.Invoke(parameter);
                }
                finally
                {
                    _executing = false;
                    CanExecuteChanged?.Invoke(this, new EventArgs());
                }

            }

            public event EventHandler CanExecuteChanged;

            private bool _isEnabled = true;

            public bool IsEnabled
            {
                get => _isEnabled;
                set
                {
                    _isEnabled = value;
                    CanExecuteChanged?.Invoke(this, new EventArgs());
                }
            }

            public Action<object> Executed { get; set; }
        }

}
