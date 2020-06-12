// Copyright 2020. See LICENSE.MD for license.
//
using System;
using System.Linq.Expressions;
using Birch.Components;
using Birch.Reflection;
using Birch.Compose;
using System.Collections.Generic;
using System.Linq;

namespace Birch.Views
{
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.ActivityIndicator> ActivityIndicator()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.ActivityIndicator();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.ActivityIndicator>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_ActivityIndicator_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_Color = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ActivityIndicator, Xamarin.Forms.Color>
        (v => v.Color);

        public static TControl Color<TControl>(this TControl component, Xamarin.Forms.Color pColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.ActivityIndicator>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ActivityIndicator t = default;
                t.Color = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_Color,pColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ActivityIndicator_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsRunning = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ActivityIndicator, System.Boolean>
        (v => v.IsRunning);

        public static TControl IsRunning<TControl>(this TControl component, System.Boolean pIsRunning)  where TControl:IReflectedPrimitive<Xamarin.Forms.ActivityIndicator>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ActivityIndicator t = default;
                t.IsRunning = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsRunning,pIsRunning);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.BoxView> BoxView(Xamarin.Forms.Color pColor=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.BoxView();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.BoxView>();
            if(pColor != default)
                control.Color(pColor);
            return control;
        }    
    }

    public static partial class Xamarin_Forms_BoxView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_Color = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.BoxView, Xamarin.Forms.Color>(v => v.Color,equalityComparer:EqualityComparer<Xamarin.Forms.Color>.Default);
    
        public static TControl Color<TControl>(this TControl component, Xamarin.Forms.Color pColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.BoxView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.BoxView t = default;
                t.Color = default;
            }
    
            component.Attributes.SetAttribute(Attribute_Color_Color,pColor);
            return component;
        }
    }    public static partial class Xamarin_Forms_BoxView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.CornerRadius> Attribute_CornerRadius_CornerRadius = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.BoxView, Xamarin.Forms.CornerRadius>(v => v.CornerRadius);
    
        public static TControl CornerRadius<TControl>(this TControl component, Xamarin.Forms.CornerRadius pCornerRadius)  where TControl:IReflectedPrimitive<Xamarin.Forms.BoxView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.BoxView t = default;
                t.CornerRadius = default;
            }
    
            component.Attributes.SetAttribute(Attribute_CornerRadius_CornerRadius,pCornerRadius);
            return component;
        }
    }

    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.Button> Button(System.String pText=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.Button();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.Button>();
            if(pText != default)
            control.Text(pText);
            return control;
        }    
    }

    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Thickness> Attribute_Thickness_Padding = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, Xamarin.Forms.Thickness>
        (v => v.Padding);

        public static TControl Padding<TControl>(this TControl component, Xamarin.Forms.Thickness pPadding)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.Padding = default;
            }

            component.Attributes.SetAttribute(Attribute_Thickness_Padding,pPadding);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_BorderColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, Xamarin.Forms.Color>
        (v => v.BorderColor);

        public static TControl BorderColor<TControl>(this TControl component, Xamarin.Forms.Color pBorderColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.BorderColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_BorderColor,pBorderColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_BorderRadius = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, System.Int32>
        (v => v.BorderRadius);

        [Obsolete("BorderRadius is obsolete as of 2.5.0. Please use CornerRadius instead.")]
        public static TControl BorderRadius<TControl>(this TControl component, System.Int32 pBorderRadius)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.BorderRadius = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_BorderRadius,pBorderRadius);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_CornerRadius = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, System.Int32>
        (v => v.CornerRadius);

        public static TControl CornerRadius<TControl>(this TControl component, System.Int32 pCornerRadius)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.CornerRadius = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_CornerRadius,pCornerRadius);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_BorderWidth = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, System.Double>
        (v => v.BorderWidth);

        public static TControl BorderWidth<TControl>(this TControl component, System.Double pBorderWidth)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.BorderWidth = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_BorderWidth,pBorderWidth);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Button.ButtonContentLayout> Attribute_ButtonContentLayout_ContentLayout = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, Xamarin.Forms.Button.ButtonContentLayout>
        (v => v.ContentLayout);

        ///<remarks>
        /// Xamarin.Forms.Button.ButtonContentLayout doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ContentLayout<TControl>(this TControl component, Xamarin.Forms.Button.ButtonContentLayout pContentLayout)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.ContentLayout = default;
            }

            component.Attributes.SetAttribute(Attribute_ButtonContentLayout_ContentLayout,pContentLayout);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Font> Attribute_Font_Font = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, Xamarin.Forms.Font>
        (v => v.Font);

        public static TControl Font<TControl>(this TControl component, Xamarin.Forms.Font pFont)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.Font = default;
            }

            component.Attributes.SetAttribute(Attribute_Font_Font,pFont);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Text = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, System.String>
        (v => v.Text);

        public static TControl Text<TControl>(this TControl component, System.String pText)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.Text = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Text,pText);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_TextColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, Xamarin.Forms.Color>
        (v => v.TextColor);

        public static TControl TextColor<TControl>(this TControl component, Xamarin.Forms.Color pTextColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.TextColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_TextColor,pTextColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_CharacterSpacing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, System.Double>
        (v => v.CharacterSpacing);

        public static TControl CharacterSpacing<TControl>(this TControl component, System.Double pCharacterSpacing)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.CharacterSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_CharacterSpacing,pCharacterSpacing);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FontAttributes> Attribute_FontAttributes_FontAttributes = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, Xamarin.Forms.FontAttributes>
        (v => v.FontAttributes);

        public static TControl FontAttributes<TControl>(this TControl component, Xamarin.Forms.FontAttributes pFontAttributes)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.FontAttributes = default;
            }

            component.Attributes.SetAttribute(Attribute_FontAttributes_FontAttributes,pFontAttributes);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_FontFamily = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, System.String>
        (v => v.FontFamily);

        public static TControl FontFamily<TControl>(this TControl component, System.String pFontFamily)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.FontFamily = default;
            }

            component.Attributes.SetAttribute(Attribute_String_FontFamily,pFontFamily);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_FontSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Button, System.Double>
        (v => v.FontSize);

        public static TControl FontSize<TControl>(this TControl component, System.Double pFontSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Button t = default;
                t.FontSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_FontSize,pFontSize);
            return component;
        }
    }

public static partial class Xamarin_Forms_Button_Extensions
{
    public static TControl OnClicked<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Button tv = null;

            tv.Clicked += handler;
            tv.Clicked -= handler;
        }

        control.Event(x => nameof(x.Clicked),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Button_Extensions
{
    public static TControl OnPressed<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Button tv = null;

            tv.Pressed += handler;
            tv.Pressed -= handler;
        }

        control.Event(x => nameof(x.Pressed),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Button_Extensions
{
    public static TControl OnReleased<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Button tv = null;

            tv.Released += handler;
            tv.Released -= handler;
        }

        control.Event(x => nameof(x.Released),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Button>> _callExpression_SendClicked_Xamarin_Forms_Button_ = (view) => view.SendClicked();

        public static TControl SendClicked<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            var callExpression = _callExpression_SendClicked_Xamarin_Forms_Button_;

            Reflect<Xamarin.Forms.Button>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Button>> _callExpression_SendPressed_Xamarin_Forms_Button_ = (view) => view.SendPressed();

        public static TControl SendPressed<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            var callExpression = _callExpression_SendPressed_Xamarin_Forms_Button_;

            Reflect<Xamarin.Forms.Button>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Button_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Button>> _callExpression_SendReleased_Xamarin_Forms_Button_ = (view) => view.SendReleased();

        public static TControl SendReleased<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.Button>
        {
            var callExpression = _callExpression_SendReleased_Xamarin_Forms_Button_;

            Reflect<Xamarin.Forms.Button>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }

    public static partial class Xamarin_Forms_Cell_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsContextActionsLegacyModeEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Cell, System.Boolean>
        (v => v.IsContextActionsLegacyModeEnabled);

        public static TControl IsContextActionsLegacyModeEnabled<TControl>(this TControl component, System.Boolean pIsContextActionsLegacyModeEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Cell t = default;
                t.IsContextActionsLegacyModeEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsContextActionsLegacyModeEnabled,pIsContextActionsLegacyModeEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Cell_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Height = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Cell, System.Double>
        (v => v.Height);

        public static TControl Height<TControl>(this TControl component, System.Double pHeight)  where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Cell t = default;
                t.Height = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Height,pHeight);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Cell_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Cell, System.Boolean>
        (v => v.IsEnabled);

        public static TControl IsEnabled<TControl>(this TControl component, System.Boolean pIsEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Cell t = default;
                t.IsEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsEnabled,pIsEnabled);
            return component;
        }
    }

public static partial class Xamarin_Forms_Cell_Extensions
{
    public static TControl OnAppearing<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Cell tv = null;

            tv.Appearing += handler;
            tv.Appearing -= handler;
        }

        control.Event(x => nameof(x.Appearing),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Cell_Extensions
{
    public static TControl OnDisappearing<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Cell tv = null;

            tv.Disappearing += handler;
            tv.Disappearing -= handler;
        }

        control.Event(x => nameof(x.Disappearing),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Cell_Extensions
{
    public static TControl OnForceUpdateSizeRequested<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Cell tv = null;

            tv.ForceUpdateSizeRequested += handler;
            tv.ForceUpdateSizeRequested -= handler;
        }

        control.Event(x => nameof(x.ForceUpdateSizeRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Cell_Extensions
{
    public static TControl OnTapped<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Cell tv = null;

            tv.Tapped += handler;
            tv.Tapped -= handler;
        }

        control.Event(x => nameof(x.Tapped),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_Cell_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Cell>> _callExpression_ForceUpdateSize_Xamarin_Forms_Cell_ = (view) => view.ForceUpdateSize();

        public static TControl ForceUpdateSize<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
        {
            var callExpression = _callExpression_ForceUpdateSize_Xamarin_Forms_Cell_;

            Reflect<Xamarin.Forms.Cell>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Cell_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Cell>> _callExpression_SendAppearing_Xamarin_Forms_Cell_ = (view) => view.SendAppearing();

        public static TControl SendAppearing<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
        {
            var callExpression = _callExpression_SendAppearing_Xamarin_Forms_Cell_;

            Reflect<Xamarin.Forms.Cell>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Cell_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Cell>> _callExpression_SendDisappearing_Xamarin_Forms_Cell_ = (view) => view.SendDisappearing();

        public static TControl SendDisappearing<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.Cell>
        {
            var callExpression = _callExpression_SendDisappearing_Xamarin_Forms_Cell_;

            Reflect<Xamarin.Forms.Cell>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.EntryCell> EntryCell()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.EntryCell();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.EntryCell>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_EntryCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_HorizontalTextAlignment = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.EntryCell, Xamarin.Forms.TextAlignment>
        (v => v.HorizontalTextAlignment);

        public static TControl HorizontalTextAlignment<TControl>(this TControl component, Xamarin.Forms.TextAlignment pHorizontalTextAlignment)  where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.EntryCell t = default;
                t.HorizontalTextAlignment = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_HorizontalTextAlignment,pHorizontalTextAlignment);
            return component;
        }
    }
    public static partial class Xamarin_Forms_EntryCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_VerticalTextAlignment = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.EntryCell, Xamarin.Forms.TextAlignment>
        (v => v.VerticalTextAlignment);

        public static TControl VerticalTextAlignment<TControl>(this TControl component, Xamarin.Forms.TextAlignment pVerticalTextAlignment)  where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.EntryCell t = default;
                t.VerticalTextAlignment = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_VerticalTextAlignment,pVerticalTextAlignment);
            return component;
        }
    }
    public static partial class Xamarin_Forms_EntryCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Keyboard> Attribute_Keyboard_Keyboard = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.EntryCell, Xamarin.Forms.Keyboard>
        (v => v.Keyboard);

        ///<remarks>
        /// Xamarin.Forms.Keyboard doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Keyboard<TControl>(this TControl component, Xamarin.Forms.Keyboard pKeyboard)  where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.EntryCell t = default;
                t.Keyboard = default;
            }

            component.Attributes.SetAttribute(Attribute_Keyboard_Keyboard,pKeyboard);
            return component;
        }
    }
    public static partial class Xamarin_Forms_EntryCell_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Label = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.EntryCell, System.String>
        (v => v.Label);

        public static TControl Label<TControl>(this TControl component, System.String pLabel)  where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.EntryCell t = default;
                t.Label = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Label,pLabel);
            return component;
        }
    }
    public static partial class Xamarin_Forms_EntryCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_LabelColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.EntryCell, Xamarin.Forms.Color>
        (v => v.LabelColor);

        public static TControl LabelColor<TControl>(this TControl component, Xamarin.Forms.Color pLabelColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.EntryCell t = default;
                t.LabelColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_LabelColor,pLabelColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_EntryCell_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Placeholder = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.EntryCell, System.String>
        (v => v.Placeholder);

        public static TControl Placeholder<TControl>(this TControl component, System.String pPlaceholder)  where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.EntryCell t = default;
                t.Placeholder = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Placeholder,pPlaceholder);
            return component;
        }
    }
    public static partial class Xamarin_Forms_EntryCell_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Text = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.EntryCell, System.String>
        (v => v.Text);

        public static TControl Text<TControl>(this TControl component, System.String pText)  where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.EntryCell t = default;
                t.Text = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Text,pText);
            return component;
        }
    }
    public static partial class Xamarin_Forms_EntryCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_XAlign = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.EntryCell, Xamarin.Forms.TextAlignment>
        (v => v.XAlign);

        [Obsolete("XAlign is obsolete as of version 2.0.0. Please use HorizontalTextAlignment instead.")]
        public static TControl XAlign<TControl>(this TControl component, Xamarin.Forms.TextAlignment pXAlign)  where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.EntryCell t = default;
                t.XAlign = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_XAlign,pXAlign);
            return component;
        }
    }

public static partial class Xamarin_Forms_EntryCell_Extensions
{
    public static TControl OnCompleted<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.EntryCell tv = null;

            tv.Completed += handler;
            tv.Completed -= handler;
        }

        control.Event(x => nameof(x.Completed),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_EntryCell_Extensions
    {
        private static Expression<Action<Xamarin.Forms.EntryCell>> _callExpression_SendCompleted_Xamarin_Forms_EntryCell_ = (view) => view.SendCompleted();

        public static TControl SendCompleted<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.EntryCell>
        {
            var callExpression = _callExpression_SendCompleted_Xamarin_Forms_EntryCell_;

            Reflect<Xamarin.Forms.EntryCell>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.ImageCell> ImageCell()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.ImageCell();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.ImageCell>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_ImageCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ImageSource> Attribute_ImageSource_ImageSource = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageCell, Xamarin.Forms.ImageSource>
        (v => v.ImageSource);

        ///<remarks>
        /// Xamarin.Forms.ImageSource doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ImageSource<TControl>(this TControl component, Xamarin.Forms.ImageSource pImageSource)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageCell t = default;
                t.ImageSource = default;
            }

            component.Attributes.SetAttribute(Attribute_ImageSource_ImageSource,pImageSource);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.SwitchCell> SwitchCell(System.Boolean pOn)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.SwitchCell();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.SwitchCell>();
            
            control.On(pOn);
            return control;
        }    
    }

    public static partial class Xamarin_Forms_SwitchCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_OnColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SwitchCell, Xamarin.Forms.Color>
        (v => v.OnColor);

        public static TControl OnColor<TControl>(this TControl component, Xamarin.Forms.Color pOnColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.SwitchCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SwitchCell t = default;
                t.OnColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_OnColor,pOnColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SwitchCell_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_On = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SwitchCell, System.Boolean>
        (v => v.On);

        public static TControl On<TControl>(this TControl component, System.Boolean pOn)  where TControl:IReflectedPrimitive<Xamarin.Forms.SwitchCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SwitchCell t = default;
                t.On = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_On,pOn);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SwitchCell_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Text = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SwitchCell, System.String>
        (v => v.Text);

        public static TControl Text<TControl>(this TControl component, System.String pText)  where TControl:IReflectedPrimitive<Xamarin.Forms.SwitchCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SwitchCell t = default;
                t.Text = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Text,pText);
            return component;
        }
    }

public static partial class Xamarin_Forms_SwitchCell_Extensions
{
    public static TControl OnOnChanged<TControl>(this TControl control,Action<Xamarin.Forms.ToggledEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.SwitchCell>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.SwitchCell tv = null;

            tv.OnChanged += handler;
            tv.OnChanged -= handler;
        }

        control.Event(x => nameof(x.OnChanged),action);
        return control;
    }
}

    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.TextCell> TextCell(System.String pText)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.TextCell();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.TextCell>();
            
            control.Text(pText);
            return control;
        }    
    }

    public static partial class Xamarin_Forms_TextCell_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_Command = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TextCell, System.Windows.Input.ICommand>
        (v => v.Command);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Command<TControl>(this TControl component, System.Windows.Input.ICommand pCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.TextCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TextCell t = default;
                t.Command = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_Command,pCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TextCell_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_CommandParameter = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TextCell, System.Object>
        (v => v.CommandParameter);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl CommandParameter<TControl>(this TControl component, System.Object pCommandParameter)  where TControl:IReflectedPrimitive<Xamarin.Forms.TextCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TextCell t = default;
                t.CommandParameter = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_CommandParameter,pCommandParameter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TextCell_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Detail = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TextCell, System.String>
        (v => v.Detail);

        public static TControl Detail<TControl>(this TControl component, System.String pDetail)  where TControl:IReflectedPrimitive<Xamarin.Forms.TextCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TextCell t = default;
                t.Detail = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Detail,pDetail);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TextCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_DetailColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TextCell, Xamarin.Forms.Color>
        (v => v.DetailColor);

        public static TControl DetailColor<TControl>(this TControl component, Xamarin.Forms.Color pDetailColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.TextCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TextCell t = default;
                t.DetailColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_DetailColor,pDetailColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TextCell_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Text = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TextCell, System.String>
        (v => v.Text);

        public static TControl Text<TControl>(this TControl component, System.String pText)  where TControl:IReflectedPrimitive<Xamarin.Forms.TextCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TextCell t = default;
                t.Text = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Text,pText);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TextCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_TextColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TextCell, Xamarin.Forms.Color>
        (v => v.TextColor);

        public static TControl TextColor<TControl>(this TControl component, Xamarin.Forms.Color pTextColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.TextCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TextCell t = default;
                t.TextColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_TextColor,pTextColor);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.ViewCell> ViewCell()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.ViewCell();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.ViewCell>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_ViewCell_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.View> Attribute_View_View = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ViewCell, Xamarin.Forms.View>
        (v => v.View);

        ///<remarks>
        /// Xamarin.Forms.View doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl View<TControl>(this TControl component, Xamarin.Forms.View pView)  where TControl:IReflectedPrimitive<Xamarin.Forms.ViewCell>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ViewCell t = default;
                t.View = default;
            }

            component.Attributes.SetAttribute(Attribute_View_View,pView);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.CheckBox> CheckBox(System.Boolean pIsChecked)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.CheckBox();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.CheckBox>();
            
            control.IsChecked(pIsChecked);
            return control;
        }    
    }

    public static partial class Xamarin_Forms_CheckBox_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_Color = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CheckBox, Xamarin.Forms.Color>
        (v => v.Color);

        public static TControl Color<TControl>(this TControl component, Xamarin.Forms.Color pColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.CheckBox>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CheckBox t = default;
                t.Color = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_Color,pColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CheckBox_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsChecked = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CheckBox, System.Boolean>
        (v => v.IsChecked);

        public static TControl IsChecked<TControl>(this TControl component, System.Boolean pIsChecked)  where TControl:IReflectedPrimitive<Xamarin.Forms.CheckBox>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CheckBox t = default;
                t.IsChecked = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsChecked,pIsChecked);
            return component;
        }
    }

public static partial class Xamarin_Forms_CheckBox_Extensions
{
    public static TControl OnCheckedChanged<TControl>(this TControl control,Action<Xamarin.Forms.CheckedChangedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.CheckBox>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.CheckBox tv = null;

            tv.CheckedChanged += handler;
            tv.CheckedChanged -= handler;
        }

        control.Event(x => nameof(x.CheckedChanged),action);
        return control;
    }
}

    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.ContentPage> ContentPage()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.ContentPage();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.ContentPage>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_ContentPage_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.View> Attribute_View_Content = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ContentPage, Xamarin.Forms.View>
        (v => v.Content);

        ///<remarks>
        /// Xamarin.Forms.View doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Content<TControl>(this TControl component, Xamarin.Forms.View pContent)  where TControl:IReflectedPrimitive<Xamarin.Forms.ContentPage>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ContentPage t = default;
                t.Content = default;
            }

            component.Attributes.SetAttribute(Attribute_View_Content,pContent);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.ContentView> ContentView()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.ContentView();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.ContentView>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_ContentView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.View> Attribute_View_Content = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ContentView, Xamarin.Forms.View>
        (v => v.Content);

        ///<remarks>
        /// Xamarin.Forms.View doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Content<TControl>(this TControl component, Xamarin.Forms.View pContent)  where TControl:IReflectedPrimitive<Xamarin.Forms.ContentView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ContentView t = default;
                t.Content = default;
            }

            component.Attributes.SetAttribute(Attribute_View_Content,pContent);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.DatePicker> DatePicker()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.DatePicker();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.DatePicker>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_DatePicker_Extensions
    {
        private static readonly Attribute<System.DateTime> Attribute_DateTime_Date = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.DatePicker, System.DateTime>
        (v => v.Date);

        public static TControl Date<TControl>(this TControl component, System.DateTime pDate)  where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.DatePicker t = default;
                t.Date = default;
            }

            component.Attributes.SetAttribute(Attribute_DateTime_Date,pDate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_DatePicker_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Format = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.DatePicker, System.String>
        (v => v.Format);

        public static TControl Format<TControl>(this TControl component, System.String pFormat)  where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.DatePicker t = default;
                t.Format = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Format,pFormat);
            return component;
        }
    }
    public static partial class Xamarin_Forms_DatePicker_Extensions
    {
        private static readonly Attribute<System.DateTime> Attribute_DateTime_MaximumDate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.DatePicker, System.DateTime>
        (v => v.MaximumDate);

        public static TControl MaximumDate<TControl>(this TControl component, System.DateTime pMaximumDate)  where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.DatePicker t = default;
                t.MaximumDate = default;
            }

            component.Attributes.SetAttribute(Attribute_DateTime_MaximumDate,pMaximumDate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_DatePicker_Extensions
    {
        private static readonly Attribute<System.DateTime> Attribute_DateTime_MinimumDate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.DatePicker, System.DateTime>
        (v => v.MinimumDate);

        public static TControl MinimumDate<TControl>(this TControl component, System.DateTime pMinimumDate)  where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.DatePicker t = default;
                t.MinimumDate = default;
            }

            component.Attributes.SetAttribute(Attribute_DateTime_MinimumDate,pMinimumDate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_DatePicker_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_TextColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.DatePicker, Xamarin.Forms.Color>
        (v => v.TextColor);

        public static TControl TextColor<TControl>(this TControl component, Xamarin.Forms.Color pTextColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.DatePicker t = default;
                t.TextColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_TextColor,pTextColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_DatePicker_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_CharacterSpacing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.DatePicker, System.Double>
        (v => v.CharacterSpacing);

        public static TControl CharacterSpacing<TControl>(this TControl component, System.Double pCharacterSpacing)  where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.DatePicker t = default;
                t.CharacterSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_CharacterSpacing,pCharacterSpacing);
            return component;
        }
    }
    public static partial class Xamarin_Forms_DatePicker_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FontAttributes> Attribute_FontAttributes_FontAttributes = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.DatePicker, Xamarin.Forms.FontAttributes>
        (v => v.FontAttributes);

        public static TControl FontAttributes<TControl>(this TControl component, Xamarin.Forms.FontAttributes pFontAttributes)  where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.DatePicker t = default;
                t.FontAttributes = default;
            }

            component.Attributes.SetAttribute(Attribute_FontAttributes_FontAttributes,pFontAttributes);
            return component;
        }
    }
    public static partial class Xamarin_Forms_DatePicker_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_FontFamily = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.DatePicker, System.String>
        (v => v.FontFamily);

        public static TControl FontFamily<TControl>(this TControl component, System.String pFontFamily)  where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.DatePicker t = default;
                t.FontFamily = default;
            }

            component.Attributes.SetAttribute(Attribute_String_FontFamily,pFontFamily);
            return component;
        }
    }
    public static partial class Xamarin_Forms_DatePicker_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_FontSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.DatePicker, System.Double>
        (v => v.FontSize);

        public static TControl FontSize<TControl>(this TControl component, System.Double pFontSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.DatePicker t = default;
                t.FontSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_FontSize,pFontSize);
            return component;
        }
    }

public static partial class Xamarin_Forms_DatePicker_Extensions
{
    public static TControl OnDateSelected<TControl>(this TControl control,Action<Xamarin.Forms.DateChangedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.DatePicker>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.DatePicker tv = null;

            tv.DateSelected += handler;
            tv.DateSelected -= handler;
        }

        control.Event(x => nameof(x.DateSelected),action);
        return control;
    }
}

    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.Editor> Editor()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.Editor();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.Editor>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_Editor_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.EditorAutoSizeOption> Attribute_EditorAutoSizeOption_AutoSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Editor, Xamarin.Forms.EditorAutoSizeOption>
        (v => v.AutoSize);

        public static TControl AutoSize<TControl>(this TControl component, Xamarin.Forms.EditorAutoSizeOption pAutoSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.Editor>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Editor t = default;
                t.AutoSize = default;
            }

            component.Attributes.SetAttribute(Attribute_EditorAutoSizeOption_AutoSize,pAutoSize);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Editor_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FontAttributes> Attribute_FontAttributes_FontAttributes = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Editor, Xamarin.Forms.FontAttributes>
        (v => v.FontAttributes);

        public static TControl FontAttributes<TControl>(this TControl component, Xamarin.Forms.FontAttributes pFontAttributes)  where TControl:IReflectedPrimitive<Xamarin.Forms.Editor>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Editor t = default;
                t.FontAttributes = default;
            }

            component.Attributes.SetAttribute(Attribute_FontAttributes_FontAttributes,pFontAttributes);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Editor_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsTextPredictionEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Editor, System.Boolean>
        (v => v.IsTextPredictionEnabled);

        public static TControl IsTextPredictionEnabled<TControl>(this TControl component, System.Boolean pIsTextPredictionEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.Editor>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Editor t = default;
                t.IsTextPredictionEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsTextPredictionEnabled,pIsTextPredictionEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Editor_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_FontFamily = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Editor, System.String>
        (v => v.FontFamily);

        public static TControl FontFamily<TControl>(this TControl component, System.String pFontFamily)  where TControl:IReflectedPrimitive<Xamarin.Forms.Editor>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Editor t = default;
                t.FontFamily = default;
            }

            component.Attributes.SetAttribute(Attribute_String_FontFamily,pFontFamily);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Editor_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_FontSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Editor, System.Double>
        (v => v.FontSize);

        public static TControl FontSize<TControl>(this TControl component, System.Double pFontSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.Editor>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Editor t = default;
                t.FontSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_FontSize,pFontSize);
            return component;
        }
    }

public static partial class Xamarin_Forms_Editor_Extensions
{
    public static TControl OnCompleted<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Editor>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Editor tv = null;

            tv.Completed += handler;
            tv.Completed -= handler;
        }

        control.Event(x => nameof(x.Completed),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_Editor_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Editor>> _callExpression_SendCompleted_Xamarin_Forms_Editor_ = (view) => view.SendCompleted();

        public static TControl SendCompleted<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.Editor>
        {
            var callExpression = _callExpression_SendCompleted_Xamarin_Forms_Editor_;

            Reflect<Xamarin.Forms.Editor>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }

    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_AutomationId = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Element, System.String>
        (v => v.AutomationId);

        public static TControl AutomationId<TControl>(this TControl component, System.String pAutomationId)  where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Element t = default;
                t.AutomationId = default;
            }

            component.Attributes.SetAttribute(Attribute_String_AutomationId,pAutomationId);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_ClassId = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Element, System.String>
        (v => v.ClassId);

        public static TControl ClassId<TControl>(this TControl component, System.String pClassId)  where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Element t = default;
                t.ClassId = default;
            }

            component.Attributes.SetAttribute(Attribute_String_ClassId,pClassId);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_StyleId = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Element, System.String>
        (v => v.StyleId);

        public static TControl StyleId<TControl>(this TControl component, System.String pStyleId)  where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Element t = default;
                t.StyleId = default;
            }

            component.Attributes.SetAttribute(Attribute_String_StyleId,pStyleId);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Element> Attribute_Element_Parent = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Element, Xamarin.Forms.Element>
        (v => v.Parent);

        ///<remarks>
        /// Xamarin.Forms.Element doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Parent<TControl>(this TControl component, Xamarin.Forms.Element pParent)  where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Element t = default;
                t.Parent = default;
            }

            component.Attributes.SetAttribute(Attribute_Element_Parent,pParent);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.IEffectControlProvider> Attribute_IEffectControlProvider_EffectControlProvider = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Element, Xamarin.Forms.IEffectControlProvider>
        (v => v.EffectControlProvider);

        ///<remarks>
        /// Xamarin.Forms.IEffectControlProvider doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl EffectControlProvider<TControl>(this TControl component, Xamarin.Forms.IEffectControlProvider pEffectControlProvider)  where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Element t = default;
                t.EffectControlProvider = default;
            }

            component.Attributes.SetAttribute(Attribute_IEffectControlProvider_EffectControlProvider,pEffectControlProvider);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Internals.IPlatform> Attribute_IPlatform_Platform = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Element, Xamarin.Forms.Internals.IPlatform>
        (v => v.Platform);

        ///<remarks>
        /// Xamarin.Forms.Internals.IPlatform doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        [Obsolete("IPlatform is obsolete as of 3.5.0. Do not use this property.")]
        public static TControl Platform<TControl>(this TControl component, Xamarin.Forms.Internals.IPlatform pPlatform)  where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Element t = default;
                t.Platform = default;
            }

            component.Attributes.SetAttribute(Attribute_IPlatform_Platform,pPlatform);
            return component;
        }
    }

public static partial class Xamarin_Forms_Element_Extensions
{
    public static TControl OnChildAdded<TControl>(this TControl control,Action<Xamarin.Forms.ElementEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Element tv = null;

            tv.ChildAdded += handler;
            tv.ChildAdded -= handler;
        }

        control.Event(x => nameof(x.ChildAdded),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Element_Extensions
{
    public static TControl OnChildRemoved<TControl>(this TControl control,Action<Xamarin.Forms.ElementEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Element tv = null;

            tv.ChildRemoved += handler;
            tv.ChildRemoved -= handler;
        }

        control.Event(x => nameof(x.ChildRemoved),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Element_Extensions
{
    public static TControl OnDescendantAdded<TControl>(this TControl control,Action<Xamarin.Forms.ElementEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Element tv = null;

            tv.DescendantAdded += handler;
            tv.DescendantAdded -= handler;
        }

        control.Event(x => nameof(x.DescendantAdded),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Element_Extensions
{
    public static TControl OnDescendantRemoved<TControl>(this TControl control,Action<Xamarin.Forms.ElementEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Element tv = null;

            tv.DescendantRemoved += handler;
            tv.DescendantRemoved -= handler;
        }

        control.Event(x => nameof(x.DescendantRemoved),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Element_Extensions
{
    [Obsolete("PlatformSet is obsolete as of 3.5.0. Do not use this event.")]
    public static TControl OnPlatformSet<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Element tv = null;

            tv.PlatformSet += handler;
            tv.PlatformSet -= handler;
        }

        control.Event(x => nameof(x.PlatformSet),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Element, Xamarin.Forms.BindableProperty>> _callExpression_RemoveDynamicResource_Xamarin_Forms_Element__Xamarin_Forms_BindableProperty = (view, param1) => view.RemoveDynamicResource(param1);

        public static TControl RemoveDynamicResource<TControl>(this TControl component, Xamarin.Forms.BindableProperty pproperty) where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            var callExpression = _callExpression_RemoveDynamicResource_Xamarin_Forms_Element__Xamarin_Forms_BindableProperty;

            Reflect<Xamarin.Forms.Element>.ReflectionHelpers.Call(component.Attributes,callExpression, pproperty);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Element, Xamarin.Forms.BindableProperty, System.String>> _callExpression_SetDynamicResource_Xamarin_Forms_Element__Xamarin_Forms_BindableProperty_System_String = (view, param1, param2) => view.SetDynamicResource(param1, param2);

        public static TControl SetDynamicResource<TControl>(this TControl component, Xamarin.Forms.BindableProperty pproperty, System.String pkey) where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            var callExpression = _callExpression_SetDynamicResource_Xamarin_Forms_Element__Xamarin_Forms_BindableProperty_System_String;

            Reflect<Xamarin.Forms.Element>.ReflectionHelpers.Call(component.Attributes,callExpression, pproperty, pkey);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Element, Xamarin.Forms.BindableProperty, System.Object>> _callExpression_SetValueFromRenderer_Xamarin_Forms_Element__Xamarin_Forms_BindableProperty_System_Object = (view, param1, param2) => view.SetValueFromRenderer(param1, param2);

        public static TControl SetValueFromRenderer<TControl>(this TControl component, Xamarin.Forms.BindableProperty pproperty, System.Object pvalue) where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            var callExpression = _callExpression_SetValueFromRenderer_Xamarin_Forms_Element__Xamarin_Forms_BindableProperty_System_Object;

            Reflect<Xamarin.Forms.Element>.ReflectionHelpers.Call(component.Attributes,callExpression, pproperty, pvalue);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Element_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Element, Xamarin.Forms.BindablePropertyKey, System.Object>> _callExpression_SetValueFromRenderer_Xamarin_Forms_Element__Xamarin_Forms_BindablePropertyKey_System_Object = (view, param1, param2) => view.SetValueFromRenderer(param1, param2);

        public static TControl SetValueFromRenderer<TControl>(this TControl component, Xamarin.Forms.BindablePropertyKey pproperty, System.Object pvalue) where TControl:IReflectedPrimitive<Xamarin.Forms.Element>
        {
            var callExpression = _callExpression_SetValueFromRenderer_Xamarin_Forms_Element__Xamarin_Forms_BindablePropertyKey_System_Object;

            Reflect<Xamarin.Forms.Element>.ReflectionHelpers.Call(component.Attributes,callExpression, pproperty, pvalue);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.Entry> Entry()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.Entry();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.Entry>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_HorizontalTextAlignment = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, Xamarin.Forms.TextAlignment>
        (v => v.HorizontalTextAlignment);

        public static TControl HorizontalTextAlignment<TControl>(this TControl component, Xamarin.Forms.TextAlignment pHorizontalTextAlignment)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.HorizontalTextAlignment = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_HorizontalTextAlignment,pHorizontalTextAlignment);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_VerticalTextAlignment = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, Xamarin.Forms.TextAlignment>
        (v => v.VerticalTextAlignment);

        public static TControl VerticalTextAlignment<TControl>(this TControl component, Xamarin.Forms.TextAlignment pVerticalTextAlignment)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.VerticalTextAlignment = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_VerticalTextAlignment,pVerticalTextAlignment);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsPassword = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, System.Boolean>
        (v => v.IsPassword);

        public static TControl IsPassword<TControl>(this TControl component, System.Boolean pIsPassword)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.IsPassword = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsPassword,pIsPassword);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FontAttributes> Attribute_FontAttributes_FontAttributes = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, Xamarin.Forms.FontAttributes>
        (v => v.FontAttributes);

        public static TControl FontAttributes<TControl>(this TControl component, Xamarin.Forms.FontAttributes pFontAttributes)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.FontAttributes = default;
            }

            component.Attributes.SetAttribute(Attribute_FontAttributes_FontAttributes,pFontAttributes);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_FontFamily = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, System.String>
        (v => v.FontFamily);

        public static TControl FontFamily<TControl>(this TControl component, System.String pFontFamily)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.FontFamily = default;
            }

            component.Attributes.SetAttribute(Attribute_String_FontFamily,pFontFamily);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_FontSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, System.Double>
        (v => v.FontSize);

        public static TControl FontSize<TControl>(this TControl component, System.Double pFontSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.FontSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_FontSize,pFontSize);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsTextPredictionEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, System.Boolean>
        (v => v.IsTextPredictionEnabled);

        public static TControl IsTextPredictionEnabled<TControl>(this TControl component, System.Boolean pIsTextPredictionEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.IsTextPredictionEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsTextPredictionEnabled,pIsTextPredictionEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ReturnType> Attribute_ReturnType_ReturnType = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, Xamarin.Forms.ReturnType>
        (v => v.ReturnType);

        public static TControl ReturnType<TControl>(this TControl component, Xamarin.Forms.ReturnType pReturnType)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.ReturnType = default;
            }

            component.Attributes.SetAttribute(Attribute_ReturnType_ReturnType,pReturnType);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_CursorPosition = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, System.Int32>
        (v => v.CursorPosition);

        public static TControl CursorPosition<TControl>(this TControl component, System.Int32 pCursorPosition)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.CursorPosition = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_CursorPosition,pCursorPosition);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_SelectionLength = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, System.Int32>
        (v => v.SelectionLength);

        public static TControl SelectionLength<TControl>(this TControl component, System.Int32 pSelectionLength)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.SelectionLength = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_SelectionLength,pSelectionLength);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_ReturnCommand = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, System.Windows.Input.ICommand>
        (v => v.ReturnCommand);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ReturnCommand<TControl>(this TControl component, System.Windows.Input.ICommand pReturnCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.ReturnCommand = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_ReturnCommand,pReturnCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_ReturnCommandParameter = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, System.Object>
        (v => v.ReturnCommandParameter);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ReturnCommandParameter<TControl>(this TControl component, System.Object pReturnCommandParameter)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.ReturnCommandParameter = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_ReturnCommandParameter,pReturnCommandParameter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ClearButtonVisibility> Attribute_ClearButtonVisibility_ClearButtonVisibility = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Entry, Xamarin.Forms.ClearButtonVisibility>
        (v => v.ClearButtonVisibility);

        public static TControl ClearButtonVisibility<TControl>(this TControl component, Xamarin.Forms.ClearButtonVisibility pClearButtonVisibility)  where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Entry t = default;
                t.ClearButtonVisibility = default;
            }

            component.Attributes.SetAttribute(Attribute_ClearButtonVisibility_ClearButtonVisibility,pClearButtonVisibility);
            return component;
        }
    }

public static partial class Xamarin_Forms_Entry_Extensions
{
    public static TControl OnCompleted<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Entry tv = null;

            tv.Completed += handler;
            tv.Completed -= handler;
        }

        control.Event(x => nameof(x.Completed),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_Entry_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Entry>> _callExpression_SendCompleted_Xamarin_Forms_Entry_ = (view) => view.SendCompleted();

        public static TControl SendCompleted<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.Entry>
        {
            var callExpression = _callExpression_SendCompleted_Xamarin_Forms_Entry_;

            Reflect<Xamarin.Forms.Entry>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }

    public static partial class Xamarin_Forms_FlexLayout_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FlexDirection> Attribute_FlexDirection_Direction = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.FlexLayout, Xamarin.Forms.FlexDirection>
        (v => v.Direction);

        public static TControl Direction<TControl>(this TControl component, Xamarin.Forms.FlexDirection pDirection)  where TControl:IReflectedPrimitive<Xamarin.Forms.FlexLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.FlexLayout t = default;
                t.Direction = default;
            }

            component.Attributes.SetAttribute(Attribute_FlexDirection_Direction,pDirection);
            return component;
        }
    }
    public static partial class Xamarin_Forms_FlexLayout_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FlexJustify> Attribute_FlexJustify_JustifyContent = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.FlexLayout, Xamarin.Forms.FlexJustify>
        (v => v.JustifyContent);

        public static TControl JustifyContent<TControl>(this TControl component, Xamarin.Forms.FlexJustify pJustifyContent)  where TControl:IReflectedPrimitive<Xamarin.Forms.FlexLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.FlexLayout t = default;
                t.JustifyContent = default;
            }

            component.Attributes.SetAttribute(Attribute_FlexJustify_JustifyContent,pJustifyContent);
            return component;
        }
    }
    public static partial class Xamarin_Forms_FlexLayout_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FlexAlignContent> Attribute_FlexAlignContent_AlignContent = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.FlexLayout, Xamarin.Forms.FlexAlignContent>
        (v => v.AlignContent);

        public static TControl AlignContent<TControl>(this TControl component, Xamarin.Forms.FlexAlignContent pAlignContent)  where TControl:IReflectedPrimitive<Xamarin.Forms.FlexLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.FlexLayout t = default;
                t.AlignContent = default;
            }

            component.Attributes.SetAttribute(Attribute_FlexAlignContent_AlignContent,pAlignContent);
            return component;
        }
    }
    public static partial class Xamarin_Forms_FlexLayout_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FlexAlignItems> Attribute_FlexAlignItems_AlignItems = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.FlexLayout, Xamarin.Forms.FlexAlignItems>
        (v => v.AlignItems);

        public static TControl AlignItems<TControl>(this TControl component, Xamarin.Forms.FlexAlignItems pAlignItems)  where TControl:IReflectedPrimitive<Xamarin.Forms.FlexLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.FlexLayout t = default;
                t.AlignItems = default;
            }

            component.Attributes.SetAttribute(Attribute_FlexAlignItems_AlignItems,pAlignItems);
            return component;
        }
    }
    public static partial class Xamarin_Forms_FlexLayout_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FlexPosition> Attribute_FlexPosition_Position = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.FlexLayout, Xamarin.Forms.FlexPosition>
        (v => v.Position);

        public static TControl Position<TControl>(this TControl component, Xamarin.Forms.FlexPosition pPosition)  where TControl:IReflectedPrimitive<Xamarin.Forms.FlexLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.FlexLayout t = default;
                t.Position = default;
            }

            component.Attributes.SetAttribute(Attribute_FlexPosition_Position,pPosition);
            return component;
        }
    }
    public static partial class Xamarin_Forms_FlexLayout_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FlexWrap> Attribute_FlexWrap_Wrap = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.FlexLayout, Xamarin.Forms.FlexWrap>
        (v => v.Wrap);

        public static TControl Wrap<TControl>(this TControl component, Xamarin.Forms.FlexWrap pWrap)  where TControl:IReflectedPrimitive<Xamarin.Forms.FlexLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.FlexLayout t = default;
                t.Wrap = default;
            }

            component.Attributes.SetAttribute(Attribute_FlexWrap_Wrap,pWrap);
            return component;
        }
    }



    public static partial class Xamarin_Forms_Frame_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_HasShadow = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Frame, System.Boolean>
        (v => v.HasShadow);

        public static TControl HasShadow<TControl>(this TControl component, System.Boolean pHasShadow)  where TControl:IReflectedPrimitive<Xamarin.Forms.Frame>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Frame t = default;
                t.HasShadow = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_HasShadow,pHasShadow);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Frame_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_OutlineColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Frame, Xamarin.Forms.Color>
        (v => v.OutlineColor);

        [Obsolete("OutlineColor is obsolete as of version 3.0.0. Please use BorderColor instead.")]
        public static TControl OutlineColor<TControl>(this TControl component, Xamarin.Forms.Color pOutlineColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Frame>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Frame t = default;
                t.OutlineColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_OutlineColor,pOutlineColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Frame_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_BorderColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Frame, Xamarin.Forms.Color>
        (v => v.BorderColor);

        public static TControl BorderColor<TControl>(this TControl component, Xamarin.Forms.Color pBorderColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Frame>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Frame t = default;
                t.BorderColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_BorderColor,pBorderColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Frame_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_CornerRadius = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Frame, System.Single>
        (v => v.CornerRadius);

        public static TControl CornerRadius<TControl>(this TControl component, System.Single pCornerRadius)  where TControl:IReflectedPrimitive<Xamarin.Forms.Frame>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Frame t = default;
                t.CornerRadius = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_CornerRadius,pCornerRadius);
            return component;
        }
    }



    public static partial class Xamarin_Forms_Grid_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ColumnDefinitionCollection> Attribute_ColumnDefinitionCollection_ColumnDefinitions = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Grid, Xamarin.Forms.ColumnDefinitionCollection>
        (v => v.ColumnDefinitions);

        ///<remarks>
        /// Collection. Xamarin.Forms.ColumnDefinitionCollection doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ColumnDefinitions<TControl>(this TControl component, Xamarin.Forms.ColumnDefinitionCollection pColumnDefinitions)  where TControl:IReflectedPrimitive<Xamarin.Forms.Grid>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Grid t = default;
                t.ColumnDefinitions = default;
            }

            component.Attributes.SetAttribute(Attribute_ColumnDefinitionCollection_ColumnDefinitions,pColumnDefinitions);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Grid_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_ColumnSpacing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Grid, System.Double>
        (v => v.ColumnSpacing);

        public static TControl ColumnSpacing<TControl>(this TControl component, System.Double pColumnSpacing)  where TControl:IReflectedPrimitive<Xamarin.Forms.Grid>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Grid t = default;
                t.ColumnSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_ColumnSpacing,pColumnSpacing);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Grid_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.RowDefinitionCollection> Attribute_RowDefinitionCollection_RowDefinitions = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Grid, Xamarin.Forms.RowDefinitionCollection>
        (v => v.RowDefinitions);

        ///<remarks>
        /// Collection. Xamarin.Forms.RowDefinitionCollection doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl RowDefinitions<TControl>(this TControl component, Xamarin.Forms.RowDefinitionCollection pRowDefinitions)  where TControl:IReflectedPrimitive<Xamarin.Forms.Grid>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Grid t = default;
                t.RowDefinitions = default;
            }

            component.Attributes.SetAttribute(Attribute_RowDefinitionCollection_RowDefinitions,pRowDefinitions);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Grid_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_RowSpacing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Grid, System.Double>
        (v => v.RowSpacing);

        public static TControl RowSpacing<TControl>(this TControl component, System.Double pRowSpacing)  where TControl:IReflectedPrimitive<Xamarin.Forms.Grid>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Grid t = default;
                t.RowSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_RowSpacing,pRowSpacing);
            return component;
        }
    }


    public static partial class Xamarin_Forms_Grid_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Grid, Xamarin.Forms.Internals.InvalidationTrigger>> _callExpression_InvalidateMeasureInernalNonVirtual_Xamarin_Forms_Grid__Xamarin_Forms_Internals_InvalidationTrigger = (view, param1) => view.InvalidateMeasureInernalNonVirtual(param1);

        public static TControl InvalidateMeasureInernalNonVirtual<TControl>(this TControl component, Xamarin.Forms.Internals.InvalidationTrigger ptrigger) where TControl:IReflectedPrimitive<Xamarin.Forms.Grid>
        {
            var callExpression = _callExpression_InvalidateMeasureInernalNonVirtual_Xamarin_Forms_Grid__Xamarin_Forms_Internals_InvalidationTrigger;

            Reflect<Xamarin.Forms.Grid>.ReflectionHelpers.Call(component.Attributes,callExpression, ptrigger);
            return component;
        }
    }

    public static partial class Xamarin_Forms_HtmlWebViewSource_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_BaseUrl = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.HtmlWebViewSource, System.String>
        (v => v.BaseUrl);

        public static TControl BaseUrl<TControl>(this TControl component, System.String pBaseUrl)  where TControl:IReflectedPrimitive<Xamarin.Forms.HtmlWebViewSource>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.HtmlWebViewSource t = default;
                t.BaseUrl = default;
            }

            component.Attributes.SetAttribute(Attribute_String_BaseUrl,pBaseUrl);
            return component;
        }
    }
    public static partial class Xamarin_Forms_HtmlWebViewSource_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Html = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.HtmlWebViewSource, System.String>
        (v => v.Html);

        public static TControl Html<TControl>(this TControl component, System.String pHtml)  where TControl:IReflectedPrimitive<Xamarin.Forms.HtmlWebViewSource>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.HtmlWebViewSource t = default;
                t.Html = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Html,pHtml);
            return component;
        }
    }


    public static partial class Xamarin_Forms_HtmlWebViewSource_Extensions
    {
        private static Expression<Action<Xamarin.Forms.HtmlWebViewSource, Xamarin.Forms.IWebViewDelegate>> _callExpression_Load_Xamarin_Forms_HtmlWebViewSource__Xamarin_Forms_IWebViewDelegate = (view, param1) => view.Load(param1);

        public static TControl Load<TControl>(this TControl component, Xamarin.Forms.IWebViewDelegate prenderer) where TControl:IReflectedPrimitive<Xamarin.Forms.HtmlWebViewSource>
        {
            var callExpression = _callExpression_Load_Xamarin_Forms_HtmlWebViewSource__Xamarin_Forms_IWebViewDelegate;

            Reflect<Xamarin.Forms.HtmlWebViewSource>.ReflectionHelpers.Call(component.Attributes,callExpression, prenderer);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.Image> Image()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.Image();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.Image>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_Image_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Aspect> Attribute_Aspect_Aspect = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Image, Xamarin.Forms.Aspect>
        (v => v.Aspect);

        public static TControl Aspect<TControl>(this TControl component, Xamarin.Forms.Aspect pAspect)  where TControl:IReflectedPrimitive<Xamarin.Forms.Image>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Image t = default;
                t.Aspect = default;
            }

            component.Attributes.SetAttribute(Attribute_Aspect_Aspect,pAspect);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Image_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsOpaque = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Image, System.Boolean>
        (v => v.IsOpaque);

        public static TControl IsOpaque<TControl>(this TControl component, System.Boolean pIsOpaque)  where TControl:IReflectedPrimitive<Xamarin.Forms.Image>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Image t = default;
                t.IsOpaque = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsOpaque,pIsOpaque);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Image_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsAnimationPlaying = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Image, System.Boolean>
        (v => v.IsAnimationPlaying);

        public static TControl IsAnimationPlaying<TControl>(this TControl component, System.Boolean pIsAnimationPlaying)  where TControl:IReflectedPrimitive<Xamarin.Forms.Image>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Image t = default;
                t.IsAnimationPlaying = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsAnimationPlaying,pIsAnimationPlaying);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Image_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ImageSource> Attribute_ImageSource_Source = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Image, Xamarin.Forms.ImageSource>
        (v => v.Source);

        ///<remarks>
        /// Xamarin.Forms.ImageSource doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Source<TControl>(this TControl component, Xamarin.Forms.ImageSource pSource)  where TControl:IReflectedPrimitive<Xamarin.Forms.Image>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Image t = default;
                t.Source = default;
            }

            component.Attributes.SetAttribute(Attribute_ImageSource_Source,pSource);
            return component;
        }
    }


    public static partial class Xamarin_Forms_Image_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Image, System.Boolean>> _callExpression_SetIsLoading_Xamarin_Forms_Image__System_Boolean = (view, param1) => view.SetIsLoading(param1);

        public static TControl SetIsLoading<TControl>(this TControl component, System.Boolean pisLoading) where TControl:IReflectedPrimitive<Xamarin.Forms.Image>
        {
            var callExpression = _callExpression_SetIsLoading_Xamarin_Forms_Image__System_Boolean;

            Reflect<Xamarin.Forms.Image>.ReflectionHelpers.Call(component.Attributes,callExpression, pisLoading);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.ImageButton> ImageButton()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.ImageButton();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.ImageButton>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_BorderColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageButton, Xamarin.Forms.Color>
        (v => v.BorderColor);

        public static TControl BorderColor<TControl>(this TControl component, Xamarin.Forms.Color pBorderColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageButton t = default;
                t.BorderColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_BorderColor,pBorderColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_CornerRadius = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageButton, System.Int32>
        (v => v.CornerRadius);

        public static TControl CornerRadius<TControl>(this TControl component, System.Int32 pCornerRadius)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageButton t = default;
                t.CornerRadius = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_CornerRadius,pCornerRadius);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_BorderWidth = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageButton, System.Double>
        (v => v.BorderWidth);

        public static TControl BorderWidth<TControl>(this TControl component, System.Double pBorderWidth)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageButton t = default;
                t.BorderWidth = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_BorderWidth,pBorderWidth);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Aspect> Attribute_Aspect_Aspect = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageButton, Xamarin.Forms.Aspect>
        (v => v.Aspect);

        public static TControl Aspect<TControl>(this TControl component, Xamarin.Forms.Aspect pAspect)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageButton t = default;
                t.Aspect = default;
            }

            component.Attributes.SetAttribute(Attribute_Aspect_Aspect,pAspect);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsOpaque = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageButton, System.Boolean>
        (v => v.IsOpaque);

        public static TControl IsOpaque<TControl>(this TControl component, System.Boolean pIsOpaque)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageButton t = default;
                t.IsOpaque = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsOpaque,pIsOpaque);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_Command = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageButton, System.Windows.Input.ICommand>
        (v => v.Command);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Command<TControl>(this TControl component, System.Windows.Input.ICommand pCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageButton t = default;
                t.Command = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_Command,pCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_CommandParameter = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageButton, System.Object>
        (v => v.CommandParameter);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl CommandParameter<TControl>(this TControl component, System.Object pCommandParameter)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageButton t = default;
                t.CommandParameter = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_CommandParameter,pCommandParameter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ImageSource> Attribute_ImageSource_Source = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageButton, Xamarin.Forms.ImageSource>
        (v => v.Source);

        ///<remarks>
        /// Xamarin.Forms.ImageSource doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Source<TControl>(this TControl component, Xamarin.Forms.ImageSource pSource)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageButton t = default;
                t.Source = default;
            }

            component.Attributes.SetAttribute(Attribute_ImageSource_Source,pSource);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Thickness> Attribute_Thickness_Padding = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ImageButton, Xamarin.Forms.Thickness>
        (v => v.Padding);

        public static TControl Padding<TControl>(this TControl component, Xamarin.Forms.Thickness pPadding)  where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ImageButton t = default;
                t.Padding = default;
            }

            component.Attributes.SetAttribute(Attribute_Thickness_Padding,pPadding);
            return component;
        }
    }

public static partial class Xamarin_Forms_ImageButton_Extensions
{
    public static TControl OnClicked<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ImageButton tv = null;

            tv.Clicked += handler;
            tv.Clicked -= handler;
        }

        control.Event(x => nameof(x.Clicked),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ImageButton_Extensions
{
    public static TControl OnPressed<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ImageButton tv = null;

            tv.Pressed += handler;
            tv.Pressed -= handler;
        }

        control.Event(x => nameof(x.Pressed),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ImageButton_Extensions
{
    public static TControl OnReleased<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ImageButton tv = null;

            tv.Released += handler;
            tv.Released -= handler;
        }

        control.Event(x => nameof(x.Released),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ImageButton>> _callExpression_PropagateUpClicked_Xamarin_Forms_ImageButton_ = (view) => view.PropagateUpClicked();

        public static TControl PropagateUpClicked<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            var callExpression = _callExpression_PropagateUpClicked_Xamarin_Forms_ImageButton_;

            Reflect<Xamarin.Forms.ImageButton>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ImageButton>> _callExpression_PropagateUpPressed_Xamarin_Forms_ImageButton_ = (view) => view.PropagateUpPressed();

        public static TControl PropagateUpPressed<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            var callExpression = _callExpression_PropagateUpPressed_Xamarin_Forms_ImageButton_;

            Reflect<Xamarin.Forms.ImageButton>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ImageButton>> _callExpression_PropagateUpReleased_Xamarin_Forms_ImageButton_ = (view) => view.PropagateUpReleased();

        public static TControl PropagateUpReleased<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            var callExpression = _callExpression_PropagateUpReleased_Xamarin_Forms_ImageButton_;

            Reflect<Xamarin.Forms.ImageButton>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ImageButton>> _callExpression_RaiseImageSourcePropertyChanged_Xamarin_Forms_ImageButton_ = (view) => view.RaiseImageSourcePropertyChanged();

        public static TControl RaiseImageSourcePropertyChanged<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            var callExpression = _callExpression_RaiseImageSourcePropertyChanged_Xamarin_Forms_ImageButton_;

            Reflect<Xamarin.Forms.ImageButton>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ImageButton>> _callExpression_SendClicked_Xamarin_Forms_ImageButton_ = (view) => view.SendClicked();

        public static TControl SendClicked<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            var callExpression = _callExpression_SendClicked_Xamarin_Forms_ImageButton_;

            Reflect<Xamarin.Forms.ImageButton>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ImageButton>> _callExpression_SendPressed_Xamarin_Forms_ImageButton_ = (view) => view.SendPressed();

        public static TControl SendPressed<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            var callExpression = _callExpression_SendPressed_Xamarin_Forms_ImageButton_;

            Reflect<Xamarin.Forms.ImageButton>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ImageButton>> _callExpression_SendReleased_Xamarin_Forms_ImageButton_ = (view) => view.SendReleased();

        public static TControl SendReleased<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            var callExpression = _callExpression_SendReleased_Xamarin_Forms_ImageButton_;

            Reflect<Xamarin.Forms.ImageButton>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ImageButton, System.Boolean>> _callExpression_SetIsLoading_Xamarin_Forms_ImageButton__System_Boolean = (view, param1) => view.SetIsLoading(param1);

        public static TControl SetIsLoading<TControl>(this TControl component, System.Boolean pisLoading) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            var callExpression = _callExpression_SetIsLoading_Xamarin_Forms_ImageButton__System_Boolean;

            Reflect<Xamarin.Forms.ImageButton>.ReflectionHelpers.Call(component.Attributes,callExpression, pisLoading);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ImageButton_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ImageButton, System.Boolean>> _callExpression_SetIsPressed_Xamarin_Forms_ImageButton__System_Boolean = (view, param1) => view.SetIsPressed(param1);

        public static TControl SetIsPressed<TControl>(this TControl component, System.Boolean pisPressed) where TControl:IReflectedPrimitive<Xamarin.Forms.ImageButton>
        {
            var callExpression = _callExpression_SetIsPressed_Xamarin_Forms_ImageButton__System_Boolean;

            Reflect<Xamarin.Forms.ImageButton>.ReflectionHelpers.Call(component.Attributes,callExpression, pisPressed);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.IndicatorView> IndicatorView()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.IndicatorView();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.IndicatorView>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.IndicatorShape> Attribute_IndicatorShape_IndicatorsShape = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, Xamarin.Forms.IndicatorShape>
        (v => v.IndicatorsShape);

        public static TControl IndicatorsShape<TControl>(this TControl component, Xamarin.Forms.IndicatorShape pIndicatorsShape)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.IndicatorsShape = default;
            }

            component.Attributes.SetAttribute(Attribute_IndicatorShape_IndicatorsShape,pIndicatorsShape);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Layout<Xamarin.Forms.View>> Attribute_Layout_View__IndicatorLayout = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, Xamarin.Forms.Layout<Xamarin.Forms.View>>
        (v => v.IndicatorLayout);

        ///<remarks>
        /// Xamarin.Forms.Layout doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl IndicatorLayout<TControl>(this TControl component, Xamarin.Forms.Layout<Xamarin.Forms.View> pIndicatorLayout)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.IndicatorLayout = default;
            }

            component.Attributes.SetAttribute(Attribute_Layout_View__IndicatorLayout,pIndicatorLayout);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Position = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, System.Int32>
        (v => v.Position);

        public static TControl Position<TControl>(this TControl component, System.Int32 pPosition)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.Position = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Position,pPosition);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Count = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, System.Int32>
        (v => v.Count);

        public static TControl Count<TControl>(this TControl component, System.Int32 pCount)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.Count = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Count,pCount);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_MaximumVisible = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, System.Int32>
        (v => v.MaximumVisible);

        public static TControl MaximumVisible<TControl>(this TControl component, System.Int32 pMaximumVisible)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.MaximumVisible = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_MaximumVisible,pMaximumVisible);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.DataTemplate> Attribute_DataTemplate_IndicatorTemplate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, Xamarin.Forms.DataTemplate>
        (v => v.IndicatorTemplate);

        ///<remarks>
        /// Xamarin.Forms.DataTemplate doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl IndicatorTemplate<TControl>(this TControl component, Xamarin.Forms.DataTemplate pIndicatorTemplate)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.IndicatorTemplate = default;
            }

            component.Attributes.SetAttribute(Attribute_DataTemplate_IndicatorTemplate,pIndicatorTemplate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_HideSingle = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, System.Boolean>
        (v => v.HideSingle);

        public static TControl HideSingle<TControl>(this TControl component, System.Boolean pHideSingle)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.HideSingle = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_HideSingle,pHideSingle);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_IndicatorColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, Xamarin.Forms.Color>
        (v => v.IndicatorColor);

        public static TControl IndicatorColor<TControl>(this TControl component, Xamarin.Forms.Color pIndicatorColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.IndicatorColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_IndicatorColor,pIndicatorColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_SelectedIndicatorColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, Xamarin.Forms.Color>
        (v => v.SelectedIndicatorColor);

        public static TControl SelectedIndicatorColor<TControl>(this TControl component, Xamarin.Forms.Color pSelectedIndicatorColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.SelectedIndicatorColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_SelectedIndicatorColor,pSelectedIndicatorColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_IndicatorSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, System.Double>
        (v => v.IndicatorSize);

        public static TControl IndicatorSize<TControl>(this TControl component, System.Double pIndicatorSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.IndicatorSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_IndicatorSize,pIndicatorSize);
            return component;
        }
    }
    public static partial class Xamarin_Forms_IndicatorView_Extensions
    {
        private static readonly Attribute<System.Collections.IEnumerable> Attribute_IEnumerable_ItemsSource = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.IndicatorView, System.Collections.IEnumerable>
        (v => v.ItemsSource);

        ///<remarks>
        /// Collection. System.Collections.IEnumerable doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ItemsSource<TControl>(this TControl component, System.Collections.IEnumerable pItemsSource)  where TControl:IReflectedPrimitive<Xamarin.Forms.IndicatorView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.IndicatorView t = default;
                t.ItemsSource = default;
            }

            component.Attributes.SetAttribute(Attribute_IEnumerable_ItemsSource,pItemsSource);
            return component;
        }
    }



    public static partial class Xamarin_Forms_InputView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_MaxLength = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.InputView, System.Int32>
        (v => v.MaxLength);

        public static TControl MaxLength<TControl>(this TControl component, System.Int32 pMaxLength)  where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.InputView t = default;
                t.MaxLength = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_MaxLength,pMaxLength);
            return component;
        }
    }
    public static partial class Xamarin_Forms_InputView_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Text = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.InputView, System.String>
        (v => v.Text);

        public static TControl Text<TControl>(this TControl component, System.String pText)  where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.InputView t = default;
                t.Text = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Text,pText);
            return component;
        }
    }
    public static partial class Xamarin_Forms_InputView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Keyboard> Attribute_Keyboard_Keyboard = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.InputView, Xamarin.Forms.Keyboard>
        (v => v.Keyboard);

        ///<remarks>
        /// Xamarin.Forms.Keyboard doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Keyboard<TControl>(this TControl component, Xamarin.Forms.Keyboard pKeyboard)  where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.InputView t = default;
                t.Keyboard = default;
            }

            component.Attributes.SetAttribute(Attribute_Keyboard_Keyboard,pKeyboard);
            return component;
        }
    }
    public static partial class Xamarin_Forms_InputView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsSpellCheckEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.InputView, System.Boolean>
        (v => v.IsSpellCheckEnabled);

        public static TControl IsSpellCheckEnabled<TControl>(this TControl component, System.Boolean pIsSpellCheckEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.InputView t = default;
                t.IsSpellCheckEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsSpellCheckEnabled,pIsSpellCheckEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_InputView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsReadOnly = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.InputView, System.Boolean>
        (v => v.IsReadOnly);

        public static TControl IsReadOnly<TControl>(this TControl component, System.Boolean pIsReadOnly)  where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.InputView t = default;
                t.IsReadOnly = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsReadOnly,pIsReadOnly);
            return component;
        }
    }
    public static partial class Xamarin_Forms_InputView_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Placeholder = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.InputView, System.String>
        (v => v.Placeholder);

        public static TControl Placeholder<TControl>(this TControl component, System.String pPlaceholder)  where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.InputView t = default;
                t.Placeholder = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Placeholder,pPlaceholder);
            return component;
        }
    }
    public static partial class Xamarin_Forms_InputView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_PlaceholderColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.InputView, Xamarin.Forms.Color>
        (v => v.PlaceholderColor);

        public static TControl PlaceholderColor<TControl>(this TControl component, Xamarin.Forms.Color pPlaceholderColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.InputView t = default;
                t.PlaceholderColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_PlaceholderColor,pPlaceholderColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_InputView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_TextColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.InputView, Xamarin.Forms.Color>
        (v => v.TextColor);

        public static TControl TextColor<TControl>(this TControl component, Xamarin.Forms.Color pTextColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.InputView t = default;
                t.TextColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_TextColor,pTextColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_InputView_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_CharacterSpacing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.InputView, System.Double>
        (v => v.CharacterSpacing);

        public static TControl CharacterSpacing<TControl>(this TControl component, System.Double pCharacterSpacing)  where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.InputView t = default;
                t.CharacterSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_CharacterSpacing,pCharacterSpacing);
            return component;
        }
    }

public static partial class Xamarin_Forms_InputView_Extensions
{
    public static TControl OnTextChanged<TControl>(this TControl control,Action<Xamarin.Forms.TextChangedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.InputView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.InputView tv = null;

            tv.TextChanged += handler;
            tv.TextChanged -= handler;
        }

        control.Event(x => nameof(x.TextChanged),action);
        return control;
    }
}


    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_EmptyView = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, System.Object>
        (v => v.EmptyView);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl EmptyView<TControl>(this TControl component, System.Object pEmptyView)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.EmptyView = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_EmptyView,pEmptyView);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.DataTemplate> Attribute_DataTemplate_EmptyViewTemplate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, Xamarin.Forms.DataTemplate>
        (v => v.EmptyViewTemplate);

        ///<remarks>
        /// Xamarin.Forms.DataTemplate doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl EmptyViewTemplate<TControl>(this TControl component, Xamarin.Forms.DataTemplate pEmptyViewTemplate)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.EmptyViewTemplate = default;
            }

            component.Attributes.SetAttribute(Attribute_DataTemplate_EmptyViewTemplate,pEmptyViewTemplate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<System.Collections.IEnumerable> Attribute_IEnumerable_ItemsSource = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, System.Collections.IEnumerable>
        (v => v.ItemsSource);

        ///<remarks>
        /// Collection. System.Collections.IEnumerable doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ItemsSource<TControl>(this TControl component, System.Collections.IEnumerable pItemsSource)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.ItemsSource = default;
            }

            component.Attributes.SetAttribute(Attribute_IEnumerable_ItemsSource,pItemsSource);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_RemainingItemsThresholdReachedCommand = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, System.Windows.Input.ICommand>
        (v => v.RemainingItemsThresholdReachedCommand);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl RemainingItemsThresholdReachedCommand<TControl>(this TControl component, System.Windows.Input.ICommand pRemainingItemsThresholdReachedCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.RemainingItemsThresholdReachedCommand = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_RemainingItemsThresholdReachedCommand,pRemainingItemsThresholdReachedCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_RemainingItemsThresholdReachedCommandParameter = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, System.Object>
        (v => v.RemainingItemsThresholdReachedCommandParameter);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl RemainingItemsThresholdReachedCommandParameter<TControl>(this TControl component, System.Object pRemainingItemsThresholdReachedCommandParameter)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.RemainingItemsThresholdReachedCommandParameter = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_RemainingItemsThresholdReachedCommandParameter,pRemainingItemsThresholdReachedCommandParameter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ScrollBarVisibility> Attribute_ScrollBarVisibility_HorizontalScrollBarVisibility = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, Xamarin.Forms.ScrollBarVisibility>
        (v => v.HorizontalScrollBarVisibility);

        public static TControl HorizontalScrollBarVisibility<TControl>(this TControl component, Xamarin.Forms.ScrollBarVisibility pHorizontalScrollBarVisibility)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.HorizontalScrollBarVisibility = default;
            }

            component.Attributes.SetAttribute(Attribute_ScrollBarVisibility_HorizontalScrollBarVisibility,pHorizontalScrollBarVisibility);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ScrollBarVisibility> Attribute_ScrollBarVisibility_VerticalScrollBarVisibility = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, Xamarin.Forms.ScrollBarVisibility>
        (v => v.VerticalScrollBarVisibility);

        public static TControl VerticalScrollBarVisibility<TControl>(this TControl component, Xamarin.Forms.ScrollBarVisibility pVerticalScrollBarVisibility)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.VerticalScrollBarVisibility = default;
            }

            component.Attributes.SetAttribute(Attribute_ScrollBarVisibility_VerticalScrollBarVisibility,pVerticalScrollBarVisibility);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_RemainingItemsThreshold = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, System.Int32>
        (v => v.RemainingItemsThreshold);

        public static TControl RemainingItemsThreshold<TControl>(this TControl component, System.Int32 pRemainingItemsThreshold)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.RemainingItemsThreshold = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_RemainingItemsThreshold,pRemainingItemsThreshold);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.DataTemplate> Attribute_DataTemplate_ItemTemplate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, Xamarin.Forms.DataTemplate>
        (v => v.ItemTemplate);

        ///<remarks>
        /// Xamarin.Forms.DataTemplate doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ItemTemplate<TControl>(this TControl component, Xamarin.Forms.DataTemplate pItemTemplate)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.ItemTemplate = default;
            }

            component.Attributes.SetAttribute(Attribute_DataTemplate_ItemTemplate,pItemTemplate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ItemsUpdatingScrollMode> Attribute_ItemsUpdatingScrollMode_ItemsUpdatingScrollMode = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ItemsView, Xamarin.Forms.ItemsUpdatingScrollMode>
        (v => v.ItemsUpdatingScrollMode);

        public static TControl ItemsUpdatingScrollMode<TControl>(this TControl component, Xamarin.Forms.ItemsUpdatingScrollMode pItemsUpdatingScrollMode)  where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ItemsView t = default;
                t.ItemsUpdatingScrollMode = default;
            }

            component.Attributes.SetAttribute(Attribute_ItemsUpdatingScrollMode_ItemsUpdatingScrollMode,pItemsUpdatingScrollMode);
            return component;
        }
    }

public static partial class Xamarin_Forms_ItemsView_Extensions
{
    public static TControl OnScrollToRequested<TControl>(this TControl control,Action<Xamarin.Forms.ScrollToRequestEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ItemsView tv = null;

            tv.ScrollToRequested += handler;
            tv.ScrollToRequested -= handler;
        }

        control.Event(x => nameof(x.ScrollToRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ItemsView_Extensions
{
    public static TControl OnScrolled<TControl>(this TControl control,Action<Xamarin.Forms.ItemsViewScrolledEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ItemsView tv = null;

            tv.Scrolled += handler;
            tv.Scrolled -= handler;
        }

        control.Event(x => nameof(x.Scrolled),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ItemsView_Extensions
{
    public static TControl OnRemainingItemsThresholdReached<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ItemsView tv = null;

            tv.RemainingItemsThresholdReached += handler;
            tv.RemainingItemsThresholdReached -= handler;
        }

        control.Event(x => nameof(x.RemainingItemsThresholdReached),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ItemsView, Xamarin.Forms.Element>> _callExpression_AddLogicalChild_Xamarin_Forms_ItemsView__Xamarin_Forms_Element = (view, param1) => view.AddLogicalChild(param1);

        public static TControl AddLogicalChild<TControl>(this TControl component, Xamarin.Forms.Element pelement) where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            var callExpression = _callExpression_AddLogicalChild_Xamarin_Forms_ItemsView__Xamarin_Forms_Element;

            Reflect<Xamarin.Forms.ItemsView>.ReflectionHelpers.Call(component.Attributes,callExpression, pelement);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ItemsView, Xamarin.Forms.Element>> _callExpression_RemoveLogicalChild_Xamarin_Forms_ItemsView__Xamarin_Forms_Element = (view, param1) => view.RemoveLogicalChild(param1);

        public static TControl RemoveLogicalChild<TControl>(this TControl component, Xamarin.Forms.Element pelement) where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            var callExpression = _callExpression_RemoveLogicalChild_Xamarin_Forms_ItemsView__Xamarin_Forms_Element;

            Reflect<Xamarin.Forms.ItemsView>.ReflectionHelpers.Call(component.Attributes,callExpression, pelement);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ItemsView, System.Int32, System.Int32, Xamarin.Forms.ScrollToPosition, System.Boolean>> _callExpression_ScrollTo_Xamarin_Forms_ItemsView__System_Int32_System_Int32_Xamarin_Forms_ScrollToPosition_System_Boolean = (view, param1, param2, param3, param4) => view.ScrollTo(param1, param2, param3, param4);

        public static TControl ScrollTo<TControl>(this TControl component, System.Int32 pindex, System.Int32 pgroupIndex, Xamarin.Forms.ScrollToPosition pposition, System.Boolean panimate) where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            var callExpression = _callExpression_ScrollTo_Xamarin_Forms_ItemsView__System_Int32_System_Int32_Xamarin_Forms_ScrollToPosition_System_Boolean;

            Reflect<Xamarin.Forms.ItemsView>.ReflectionHelpers.Call(component.Attributes,callExpression, pindex, pgroupIndex, pposition, panimate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ItemsView, System.Object, System.Object, Xamarin.Forms.ScrollToPosition, System.Boolean>> _callExpression_ScrollTo_Xamarin_Forms_ItemsView__System_Object_System_Object_Xamarin_Forms_ScrollToPosition_System_Boolean = (view, param1, param2, param3, param4) => view.ScrollTo(param1, param2, param3, param4);

        public static TControl ScrollTo<TControl>(this TControl component, System.Object pitem, System.Object pgroup, Xamarin.Forms.ScrollToPosition pposition, System.Boolean panimate) where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            var callExpression = _callExpression_ScrollTo_Xamarin_Forms_ItemsView__System_Object_System_Object_Xamarin_Forms_ScrollToPosition_System_Boolean;

            Reflect<Xamarin.Forms.ItemsView>.ReflectionHelpers.Call(component.Attributes,callExpression, pitem, pgroup, pposition, panimate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ItemsView>> _callExpression_SendRemainingItemsThresholdReached_Xamarin_Forms_ItemsView_ = (view) => view.SendRemainingItemsThresholdReached();

        public static TControl SendRemainingItemsThresholdReached<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            var callExpression = _callExpression_SendRemainingItemsThresholdReached_Xamarin_Forms_ItemsView_;

            Reflect<Xamarin.Forms.ItemsView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ItemsView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ItemsView, Xamarin.Forms.ItemsViewScrolledEventArgs>> _callExpression_SendScrolled_Xamarin_Forms_ItemsView__Xamarin_Forms_ItemsViewScrolledEventArgs = (view, param1) => view.SendScrolled(param1);

        public static TControl SendScrolled<TControl>(this TControl component, Xamarin.Forms.ItemsViewScrolledEventArgs pe) where TControl:IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            var callExpression = _callExpression_SendScrolled_Xamarin_Forms_ItemsView__Xamarin_Forms_ItemsViewScrolledEventArgs;

            Reflect<Xamarin.Forms.ItemsView>.ReflectionHelpers.Call(component.Attributes,callExpression, pe);
            return component;
        }
    }

    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Thickness> Attribute_Thickness_PeekAreaInsets = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, Xamarin.Forms.Thickness>
        (v => v.PeekAreaInsets);

        public static TControl PeekAreaInsets<TControl>(this TControl component, Xamarin.Forms.Thickness pPeekAreaInsets)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.PeekAreaInsets = default;
            }

            component.Attributes.SetAttribute(Attribute_Thickness_PeekAreaInsets,pPeekAreaInsets);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsBounceEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Boolean>
        (v => v.IsBounceEnabled);

        public static TControl IsBounceEnabled<TControl>(this TControl component, System.Boolean pIsBounceEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.IsBounceEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsBounceEnabled,pIsBounceEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsSwipeEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Boolean>
        (v => v.IsSwipeEnabled);

        public static TControl IsSwipeEnabled<TControl>(this TControl component, System.Boolean pIsSwipeEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.IsSwipeEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsSwipeEnabled,pIsSwipeEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsScrollAnimated = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Boolean>
        (v => v.IsScrollAnimated);

        public static TControl IsScrollAnimated<TControl>(this TControl component, System.Boolean pIsScrollAnimated)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.IsScrollAnimated = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsScrollAnimated,pIsScrollAnimated);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_CurrentItem = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Object>
        (v => v.CurrentItem);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl CurrentItem<TControl>(this TControl component, System.Object pCurrentItem)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.CurrentItem = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_CurrentItem,pCurrentItem);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_CurrentItemChangedCommand = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Windows.Input.ICommand>
        (v => v.CurrentItemChangedCommand);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl CurrentItemChangedCommand<TControl>(this TControl component, System.Windows.Input.ICommand pCurrentItemChangedCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.CurrentItemChangedCommand = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_CurrentItemChangedCommand,pCurrentItemChangedCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_CurrentItemChangedCommandParameter = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Object>
        (v => v.CurrentItemChangedCommandParameter);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl CurrentItemChangedCommandParameter<TControl>(this TControl component, System.Object pCurrentItemChangedCommandParameter)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.CurrentItemChangedCommandParameter = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_CurrentItemChangedCommandParameter,pCurrentItemChangedCommandParameter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Position = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Int32>
        (v => v.Position);

        public static TControl Position<TControl>(this TControl component, System.Int32 pPosition)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.Position = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Position,pPosition);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_PositionChangedCommand = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Windows.Input.ICommand>
        (v => v.PositionChangedCommand);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl PositionChangedCommand<TControl>(this TControl component, System.Windows.Input.ICommand pPositionChangedCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.PositionChangedCommand = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_PositionChangedCommand,pPositionChangedCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_PositionChangedCommandParameter = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Object>
        (v => v.PositionChangedCommandParameter);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl PositionChangedCommandParameter<TControl>(this TControl component, System.Object pPositionChangedCommandParameter)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.PositionChangedCommandParameter = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_PositionChangedCommandParameter,pPositionChangedCommandParameter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.LinearItemsLayout> Attribute_LinearItemsLayout_ItemsLayout = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, Xamarin.Forms.LinearItemsLayout>
        (v => v.ItemsLayout);

        ///<remarks>
        /// Xamarin.Forms.LinearItemsLayout doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ItemsLayout<TControl>(this TControl component, Xamarin.Forms.LinearItemsLayout pItemsLayout)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.ItemsLayout = default;
            }

            component.Attributes.SetAttribute(Attribute_LinearItemsLayout_ItemsLayout,pItemsLayout);
            return component;
        }
    }
    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsScrolling = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.CarouselView, System.Boolean>
        (v => v.IsScrolling);

        public static TControl IsScrolling<TControl>(this TControl component, System.Boolean pIsScrolling)  where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.CarouselView t = default;
                t.IsScrolling = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsScrolling,pIsScrolling);
            return component;
        }
    }

public static partial class Xamarin_Forms_CarouselView_Extensions
{
    public static TControl OnCurrentItemChanged<TControl>(this TControl control,Action<Xamarin.Forms.CurrentItemChangedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.CarouselView tv = null;

            tv.CurrentItemChanged += handler;
            tv.CurrentItemChanged -= handler;
        }

        control.Event(x => nameof(x.CurrentItemChanged),action);
        return control;
    }
}
public static partial class Xamarin_Forms_CarouselView_Extensions
{
    public static TControl OnPositionChanged<TControl>(this TControl control,Action<Xamarin.Forms.PositionChangedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.CarouselView tv = null;

            tv.PositionChanged += handler;
            tv.PositionChanged -= handler;
        }

        control.Event(x => nameof(x.PositionChanged),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_CarouselView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.CarouselView, System.Boolean>> _callExpression_SetIsDragging_Xamarin_Forms_CarouselView__System_Boolean = (view, param1) => view.SetIsDragging(param1);

        public static TControl SetIsDragging<TControl>(this TControl component, System.Boolean pvalue) where TControl:IReflectedPrimitive<Xamarin.Forms.CarouselView>
        {
            var callExpression = _callExpression_SetIsDragging_Xamarin_Forms_CarouselView__System_Boolean;

            Reflect<Xamarin.Forms.CarouselView>.ReflectionHelpers.Call(component.Attributes,callExpression, pvalue);
            return component;
        }
    }




    public static partial class Xamarin_Forms_GroupableItemsView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsGrouped = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.GroupableItemsView, System.Boolean>
        (v => v.IsGrouped);

        public static TControl IsGrouped<TControl>(this TControl component, System.Boolean pIsGrouped)  where TControl:IReflectedPrimitive<Xamarin.Forms.GroupableItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.GroupableItemsView t = default;
                t.IsGrouped = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsGrouped,pIsGrouped);
            return component;
        }
    }
    public static partial class Xamarin_Forms_GroupableItemsView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.DataTemplate> Attribute_DataTemplate_GroupHeaderTemplate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.GroupableItemsView, Xamarin.Forms.DataTemplate>
        (v => v.GroupHeaderTemplate);

        ///<remarks>
        /// Xamarin.Forms.DataTemplate doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl GroupHeaderTemplate<TControl>(this TControl component, Xamarin.Forms.DataTemplate pGroupHeaderTemplate)  where TControl:IReflectedPrimitive<Xamarin.Forms.GroupableItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.GroupableItemsView t = default;
                t.GroupHeaderTemplate = default;
            }

            component.Attributes.SetAttribute(Attribute_DataTemplate_GroupHeaderTemplate,pGroupHeaderTemplate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_GroupableItemsView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.DataTemplate> Attribute_DataTemplate_GroupFooterTemplate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.GroupableItemsView, Xamarin.Forms.DataTemplate>
        (v => v.GroupFooterTemplate);

        ///<remarks>
        /// Xamarin.Forms.DataTemplate doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl GroupFooterTemplate<TControl>(this TControl component, Xamarin.Forms.DataTemplate pGroupFooterTemplate)  where TControl:IReflectedPrimitive<Xamarin.Forms.GroupableItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.GroupableItemsView t = default;
                t.GroupFooterTemplate = default;
            }

            component.Attributes.SetAttribute(Attribute_DataTemplate_GroupFooterTemplate,pGroupFooterTemplate);
            return component;
        }
    }



    public static partial class Xamarin_Forms_SelectableItemsView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_SelectedItem = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SelectableItemsView, System.Object>
        (v => v.SelectedItem);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl SelectedItem<TControl>(this TControl component, System.Object pSelectedItem)  where TControl:IReflectedPrimitive<Xamarin.Forms.SelectableItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SelectableItemsView t = default;
                t.SelectedItem = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_SelectedItem,pSelectedItem);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SelectableItemsView_Extensions
    {
        private static readonly Attribute<System.Collections.Generic.IList<System.Object>> Attribute_IList_Object__SelectedItems = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SelectableItemsView, System.Collections.Generic.IList<System.Object>>
        (v => v.SelectedItems);

        ///<remarks>
        /// Collection. System.Collections.Generic.IList doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl SelectedItems<TControl>(this TControl component, System.Collections.Generic.IList<System.Object> pSelectedItems)  where TControl:IReflectedPrimitive<Xamarin.Forms.SelectableItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SelectableItemsView t = default;
                t.SelectedItems = default;
            }

            component.Attributes.SetAttribute(Attribute_IList_Object__SelectedItems,pSelectedItems);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SelectableItemsView_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_SelectionChangedCommand = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SelectableItemsView, System.Windows.Input.ICommand>
        (v => v.SelectionChangedCommand);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl SelectionChangedCommand<TControl>(this TControl component, System.Windows.Input.ICommand pSelectionChangedCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.SelectableItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SelectableItemsView t = default;
                t.SelectionChangedCommand = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_SelectionChangedCommand,pSelectionChangedCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SelectableItemsView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_SelectionChangedCommandParameter = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SelectableItemsView, System.Object>
        (v => v.SelectionChangedCommandParameter);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl SelectionChangedCommandParameter<TControl>(this TControl component, System.Object pSelectionChangedCommandParameter)  where TControl:IReflectedPrimitive<Xamarin.Forms.SelectableItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SelectableItemsView t = default;
                t.SelectionChangedCommandParameter = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_SelectionChangedCommandParameter,pSelectionChangedCommandParameter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SelectableItemsView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.SelectionMode> Attribute_SelectionMode_SelectionMode = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SelectableItemsView, Xamarin.Forms.SelectionMode>
        (v => v.SelectionMode);

        public static TControl SelectionMode<TControl>(this TControl component, Xamarin.Forms.SelectionMode pSelectionMode)  where TControl:IReflectedPrimitive<Xamarin.Forms.SelectableItemsView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SelectableItemsView t = default;
                t.SelectionMode = default;
            }

            component.Attributes.SetAttribute(Attribute_SelectionMode_SelectionMode,pSelectionMode);
            return component;
        }
    }

public static partial class Xamarin_Forms_SelectableItemsView_Extensions
{
    public static TControl OnSelectionChanged<TControl>(this TControl control,Action<Xamarin.Forms.SelectionChangedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.SelectableItemsView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.SelectableItemsView tv = null;

            tv.SelectionChanged += handler;
            tv.SelectionChanged -= handler;
        }

        control.Event(x => nameof(x.SelectionChanged),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_SelectableItemsView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.SelectableItemsView, System.Collections.Generic.IList<System.Object>>> _callExpression_UpdateSelectedItems_Xamarin_Forms_SelectableItemsView__System_Collections_Generic_IList_System_Object_ = (view, param1) => view.UpdateSelectedItems(param1);

        public static TControl UpdateSelectedItems<TControl>(this TControl component, System.Collections.Generic.IList<System.Object> pnewSelection) where TControl:IReflectedPrimitive<Xamarin.Forms.SelectableItemsView>
        {
            var callExpression = _callExpression_UpdateSelectedItems_Xamarin_Forms_SelectableItemsView__System_Collections_Generic_IList_System_Object_;

            Reflect<Xamarin.Forms.SelectableItemsView>.ReflectionHelpers.Call(component.Attributes,callExpression, pnewSelection);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.Label> Label(System.String pText)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.Label();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.Label>();
            
            control.Text(pText);
            return control;
        }    
    }

    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Font> Attribute_Font_Font = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.Font>
        (v => v.Font);

        [Obsolete("Font is obsolete as of version 1.3.0. Please use the Font attributes which are on the class itself.")]
        public static TControl Font<TControl>(this TControl component, Xamarin.Forms.Font pFont)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.Font = default;
            }

            component.Attributes.SetAttribute(Attribute_Font_Font,pFont);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FormattedString> Attribute_FormattedString_FormattedText = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.FormattedString>
        (v => v.FormattedText);

        ///<remarks>
        /// Xamarin.Forms.FormattedString doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl FormattedText<TControl>(this TControl component, Xamarin.Forms.FormattedString pFormattedText)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.FormattedText = default;
            }

            component.Attributes.SetAttribute(Attribute_FormattedString_FormattedText,pFormattedText);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_HorizontalTextAlignment = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.TextAlignment>
        (v => v.HorizontalTextAlignment);

        public static TControl HorizontalTextAlignment<TControl>(this TControl component, Xamarin.Forms.TextAlignment pHorizontalTextAlignment)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.HorizontalTextAlignment = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_HorizontalTextAlignment,pHorizontalTextAlignment);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.LineBreakMode> Attribute_LineBreakMode_LineBreakMode = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.LineBreakMode>
        (v => v.LineBreakMode);

        public static TControl LineBreakMode<TControl>(this TControl component, Xamarin.Forms.LineBreakMode pLineBreakMode)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.LineBreakMode = default;
            }

            component.Attributes.SetAttribute(Attribute_LineBreakMode_LineBreakMode,pLineBreakMode);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Text = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, System.String>
        (v => v.Text);

        public static TControl Text<TControl>(this TControl component, System.String pText)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.Text = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Text,pText);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_TextColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.Color>
        (v => v.TextColor);

        public static TControl TextColor<TControl>(this TControl component, Xamarin.Forms.Color pTextColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.TextColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_TextColor,pTextColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_CharacterSpacing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, System.Double>
        (v => v.CharacterSpacing);

        public static TControl CharacterSpacing<TControl>(this TControl component, System.Double pCharacterSpacing)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.CharacterSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_CharacterSpacing,pCharacterSpacing);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_VerticalTextAlignment = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.TextAlignment>
        (v => v.VerticalTextAlignment);

        public static TControl VerticalTextAlignment<TControl>(this TControl component, Xamarin.Forms.TextAlignment pVerticalTextAlignment)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.VerticalTextAlignment = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_VerticalTextAlignment,pVerticalTextAlignment);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_XAlign = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.TextAlignment>
        (v => v.XAlign);

        [Obsolete("XAlign is obsolete as of version 2.0.0. Please use HorizontalTextAlignment instead.")]
        public static TControl XAlign<TControl>(this TControl component, Xamarin.Forms.TextAlignment pXAlign)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.XAlign = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_XAlign,pXAlign);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_YAlign = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.TextAlignment>
        (v => v.YAlign);

        [Obsolete("YAlign is obsolete as of version 2.0.0. Please use VerticalTextAlignment instead.")]
        public static TControl YAlign<TControl>(this TControl component, Xamarin.Forms.TextAlignment pYAlign)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.YAlign = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_YAlign,pYAlign);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FontAttributes> Attribute_FontAttributes_FontAttributes = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.FontAttributes>
        (v => v.FontAttributes);

        public static TControl FontAttributes<TControl>(this TControl component, Xamarin.Forms.FontAttributes pFontAttributes)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.FontAttributes = default;
            }

            component.Attributes.SetAttribute(Attribute_FontAttributes_FontAttributes,pFontAttributes);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextDecorations> Attribute_TextDecorations_TextDecorations = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.TextDecorations>
        (v => v.TextDecorations);

        public static TControl TextDecorations<TControl>(this TControl component, Xamarin.Forms.TextDecorations pTextDecorations)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.TextDecorations = default;
            }

            component.Attributes.SetAttribute(Attribute_TextDecorations_TextDecorations,pTextDecorations);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_FontFamily = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, System.String>
        (v => v.FontFamily);

        public static TControl FontFamily<TControl>(this TControl component, System.String pFontFamily)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.FontFamily = default;
            }

            component.Attributes.SetAttribute(Attribute_String_FontFamily,pFontFamily);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_FontSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, System.Double>
        (v => v.FontSize);

        public static TControl FontSize<TControl>(this TControl component, System.Double pFontSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.FontSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_FontSize,pFontSize);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_LineHeight = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, System.Double>
        (v => v.LineHeight);

        public static TControl LineHeight<TControl>(this TControl component, System.Double pLineHeight)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.LineHeight = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_LineHeight,pLineHeight);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_MaxLines = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, System.Int32>
        (v => v.MaxLines);

        public static TControl MaxLines<TControl>(this TControl component, System.Int32 pMaxLines)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.MaxLines = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_MaxLines,pMaxLines);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Thickness> Attribute_Thickness_Padding = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.Thickness>
        (v => v.Padding);

        public static TControl Padding<TControl>(this TControl component, Xamarin.Forms.Thickness pPadding)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.Padding = default;
            }

            component.Attributes.SetAttribute(Attribute_Thickness_Padding,pPadding);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Label_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextType> Attribute_TextType_TextType = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Label, Xamarin.Forms.TextType>
        (v => v.TextType);

        public static TControl TextType<TControl>(this TControl component, Xamarin.Forms.TextType pTextType)  where TControl:IReflectedPrimitive<Xamarin.Forms.Label>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Label t = default;
                t.TextType = default;
            }

            component.Attributes.SetAttribute(Attribute_TextType_TextType,pTextType);
            return component;
        }
    }



    public static partial class Xamarin_Forms_Layout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsClippedToBounds = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Layout, System.Boolean>
        (v => v.IsClippedToBounds);

        public static TControl IsClippedToBounds<TControl>(this TControl component, System.Boolean pIsClippedToBounds)  where TControl:IReflectedPrimitive<Xamarin.Forms.Layout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Layout t = default;
                t.IsClippedToBounds = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsClippedToBounds,pIsClippedToBounds);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Layout_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Thickness> Attribute_Thickness_Padding = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Layout, Xamarin.Forms.Thickness>
        (v => v.Padding);

        public static TControl Padding<TControl>(this TControl component, Xamarin.Forms.Thickness pPadding)  where TControl:IReflectedPrimitive<Xamarin.Forms.Layout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Layout t = default;
                t.Padding = default;
            }

            component.Attributes.SetAttribute(Attribute_Thickness_Padding,pPadding);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Layout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_CascadeInputTransparent = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Layout, System.Boolean>
        (v => v.CascadeInputTransparent);

        public static TControl CascadeInputTransparent<TControl>(this TControl component, System.Boolean pCascadeInputTransparent)  where TControl:IReflectedPrimitive<Xamarin.Forms.Layout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Layout t = default;
                t.CascadeInputTransparent = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_CascadeInputTransparent,pCascadeInputTransparent);
            return component;
        }
    }

public static partial class Xamarin_Forms_Layout_Extensions
{
    public static TControl OnLayoutChanged<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Layout>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Layout tv = null;

            tv.LayoutChanged += handler;
            tv.LayoutChanged -= handler;
        }

        control.Event(x => nameof(x.LayoutChanged),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_Layout_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Layout>> _callExpression_ForceLayout_Xamarin_Forms_Layout_ = (view) => view.ForceLayout();

        public static TControl ForceLayout<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.Layout>
        {
            var callExpression = _callExpression_ForceLayout_Xamarin_Forms_Layout_;

            Reflect<Xamarin.Forms.Layout>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Layout_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Layout, Xamarin.Forms.View>> _callExpression_LowerChild_Xamarin_Forms_Layout__Xamarin_Forms_View = (view, param1) => view.LowerChild(param1);

        public static TControl LowerChild<TControl>(this TControl component, Xamarin.Forms.View pview) where TControl:IReflectedPrimitive<Xamarin.Forms.Layout>
        {
            var callExpression = _callExpression_LowerChild_Xamarin_Forms_Layout__Xamarin_Forms_View;

            Reflect<Xamarin.Forms.Layout>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Layout_Extensions
    {
        private static Expression<Action<Xamarin.Forms.Layout, Xamarin.Forms.View>> _callExpression_RaiseChild_Xamarin_Forms_Layout__Xamarin_Forms_View = (view, param1) => view.RaiseChild(param1);

        public static TControl RaiseChild<TControl>(this TControl component, Xamarin.Forms.View pview) where TControl:IReflectedPrimitive<Xamarin.Forms.Layout>
        {
            var callExpression = _callExpression_RaiseChild_Xamarin_Forms_Layout__Xamarin_Forms_View;

            Reflect<Xamarin.Forms.Layout>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }

    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_Footer = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Object>
        (v => v.Footer);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Footer<TControl>(this TControl component, System.Object pFooter)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.Footer = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_Footer,pFooter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.DataTemplate> Attribute_DataTemplate_FooterTemplate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.DataTemplate>
        (v => v.FooterTemplate);

        ///<remarks>
        /// Xamarin.Forms.DataTemplate doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl FooterTemplate<TControl>(this TControl component, Xamarin.Forms.DataTemplate pFooterTemplate)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.FooterTemplate = default;
            }

            component.Attributes.SetAttribute(Attribute_DataTemplate_FooterTemplate,pFooterTemplate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.BindingBase> Attribute_BindingBase_GroupDisplayBinding = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.BindingBase>
        (v => v.GroupDisplayBinding);

        ///<remarks>
        /// Xamarin.Forms.BindingBase doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl GroupDisplayBinding<TControl>(this TControl component, Xamarin.Forms.BindingBase pGroupDisplayBinding)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.GroupDisplayBinding = default;
            }

            component.Attributes.SetAttribute(Attribute_BindingBase_GroupDisplayBinding,pGroupDisplayBinding);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.DataTemplate> Attribute_DataTemplate_GroupHeaderTemplate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.DataTemplate>
        (v => v.GroupHeaderTemplate);

        ///<remarks>
        /// Xamarin.Forms.DataTemplate doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl GroupHeaderTemplate<TControl>(this TControl component, Xamarin.Forms.DataTemplate pGroupHeaderTemplate)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.GroupHeaderTemplate = default;
            }

            component.Attributes.SetAttribute(Attribute_DataTemplate_GroupHeaderTemplate,pGroupHeaderTemplate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.BindingBase> Attribute_BindingBase_GroupShortNameBinding = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.BindingBase>
        (v => v.GroupShortNameBinding);

        ///<remarks>
        /// Xamarin.Forms.BindingBase doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl GroupShortNameBinding<TControl>(this TControl component, Xamarin.Forms.BindingBase pGroupShortNameBinding)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.GroupShortNameBinding = default;
            }

            component.Attributes.SetAttribute(Attribute_BindingBase_GroupShortNameBinding,pGroupShortNameBinding);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_HasUnevenRows = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Boolean>
        (v => v.HasUnevenRows);

        public static TControl HasUnevenRows<TControl>(this TControl component, System.Boolean pHasUnevenRows)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.HasUnevenRows = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_HasUnevenRows,pHasUnevenRows);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_Header = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Object>
        (v => v.Header);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Header<TControl>(this TControl component, System.Object pHeader)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.Header = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_Header,pHeader);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.DataTemplate> Attribute_DataTemplate_HeaderTemplate = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.DataTemplate>
        (v => v.HeaderTemplate);

        ///<remarks>
        /// Xamarin.Forms.DataTemplate doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl HeaderTemplate<TControl>(this TControl component, Xamarin.Forms.DataTemplate pHeaderTemplate)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.HeaderTemplate = default;
            }

            component.Attributes.SetAttribute(Attribute_DataTemplate_HeaderTemplate,pHeaderTemplate);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsGroupingEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Boolean>
        (v => v.IsGroupingEnabled);

        public static TControl IsGroupingEnabled<TControl>(this TControl component, System.Boolean pIsGroupingEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.IsGroupingEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsGroupingEnabled,pIsGroupingEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsPullToRefreshEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Boolean>
        (v => v.IsPullToRefreshEnabled);

        public static TControl IsPullToRefreshEnabled<TControl>(this TControl component, System.Boolean pIsPullToRefreshEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.IsPullToRefreshEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsPullToRefreshEnabled,pIsPullToRefreshEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsRefreshing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Boolean>
        (v => v.IsRefreshing);

        public static TControl IsRefreshing<TControl>(this TControl component, System.Boolean pIsRefreshing)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.IsRefreshing = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsRefreshing,pIsRefreshing);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_RefreshCommand = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Windows.Input.ICommand>
        (v => v.RefreshCommand);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl RefreshCommand<TControl>(this TControl component, System.Windows.Input.ICommand pRefreshCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.RefreshCommand = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_RefreshCommand,pRefreshCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_RowHeight = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Int32>
        (v => v.RowHeight);

        public static TControl RowHeight<TControl>(this TControl component, System.Int32 pRowHeight)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.RowHeight = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_RowHeight,pRowHeight);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_SelectedItem = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Object>
        (v => v.SelectedItem);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl SelectedItem<TControl>(this TControl component, System.Object pSelectedItem)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.SelectedItem = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_SelectedItem,pSelectedItem);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ListViewSelectionMode> Attribute_ListViewSelectionMode_SelectionMode = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.ListViewSelectionMode>
        (v => v.SelectionMode);

        public static TControl SelectionMode<TControl>(this TControl component, Xamarin.Forms.ListViewSelectionMode pSelectionMode)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.SelectionMode = default;
            }

            component.Attributes.SetAttribute(Attribute_ListViewSelectionMode_SelectionMode,pSelectionMode);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_SeparatorColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.Color>
        (v => v.SeparatorColor);

        public static TControl SeparatorColor<TControl>(this TControl component, Xamarin.Forms.Color pSeparatorColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.SeparatorColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_SeparatorColor,pSeparatorColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_RefreshControlColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.Color>
        (v => v.RefreshControlColor);

        public static TControl RefreshControlColor<TControl>(this TControl component, Xamarin.Forms.Color pRefreshControlColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.RefreshControlColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_RefreshControlColor,pRefreshControlColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.SeparatorVisibility> Attribute_SeparatorVisibility_SeparatorVisibility = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.SeparatorVisibility>
        (v => v.SeparatorVisibility);

        public static TControl SeparatorVisibility<TControl>(this TControl component, Xamarin.Forms.SeparatorVisibility pSeparatorVisibility)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.SeparatorVisibility = default;
            }

            component.Attributes.SetAttribute(Attribute_SeparatorVisibility_SeparatorVisibility,pSeparatorVisibility);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ScrollBarVisibility> Attribute_ScrollBarVisibility_HorizontalScrollBarVisibility = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.ScrollBarVisibility>
        (v => v.HorizontalScrollBarVisibility);

        public static TControl HorizontalScrollBarVisibility<TControl>(this TControl component, Xamarin.Forms.ScrollBarVisibility pHorizontalScrollBarVisibility)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.HorizontalScrollBarVisibility = default;
            }

            component.Attributes.SetAttribute(Attribute_ScrollBarVisibility_HorizontalScrollBarVisibility,pHorizontalScrollBarVisibility);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ScrollBarVisibility> Attribute_ScrollBarVisibility_VerticalScrollBarVisibility = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, Xamarin.Forms.ScrollBarVisibility>
        (v => v.VerticalScrollBarVisibility);

        public static TControl VerticalScrollBarVisibility<TControl>(this TControl component, Xamarin.Forms.ScrollBarVisibility pVerticalScrollBarVisibility)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.VerticalScrollBarVisibility = default;
            }

            component.Attributes.SetAttribute(Attribute_ScrollBarVisibility_VerticalScrollBarVisibility,pVerticalScrollBarVisibility);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_RefreshAllowed = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ListView, System.Boolean>
        (v => v.RefreshAllowed);

        public static TControl RefreshAllowed<TControl>(this TControl component, System.Boolean pRefreshAllowed)  where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ListView t = default;
                t.RefreshAllowed = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_RefreshAllowed,pRefreshAllowed);
            return component;
        }
    }

public static partial class Xamarin_Forms_ListView_Extensions
{
    public static TControl OnItemAppearing<TControl>(this TControl control,Action<Xamarin.Forms.ItemVisibilityEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ListView tv = null;

            tv.ItemAppearing += handler;
            tv.ItemAppearing -= handler;
        }

        control.Event(x => nameof(x.ItemAppearing),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ListView_Extensions
{
    public static TControl OnItemDisappearing<TControl>(this TControl control,Action<Xamarin.Forms.ItemVisibilityEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ListView tv = null;

            tv.ItemDisappearing += handler;
            tv.ItemDisappearing -= handler;
        }

        control.Event(x => nameof(x.ItemDisappearing),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ListView_Extensions
{
    public static TControl OnItemSelected<TControl>(this TControl control,Action<Xamarin.Forms.SelectedItemChangedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ListView tv = null;

            tv.ItemSelected += handler;
            tv.ItemSelected -= handler;
        }

        control.Event(x => nameof(x.ItemSelected),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ListView_Extensions
{
    public static TControl OnItemTapped<TControl>(this TControl control,Action<Xamarin.Forms.ItemTappedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ListView tv = null;

            tv.ItemTapped += handler;
            tv.ItemTapped -= handler;
        }

        control.Event(x => nameof(x.ItemTapped),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ListView_Extensions
{
    public static TControl OnScrolled<TControl>(this TControl control,Action<Xamarin.Forms.ScrolledEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ListView tv = null;

            tv.Scrolled += handler;
            tv.Scrolled -= handler;
        }

        control.Event(x => nameof(x.Scrolled),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ListView_Extensions
{
    public static TControl OnRefreshing<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ListView tv = null;

            tv.Refreshing += handler;
            tv.Refreshing -= handler;
        }

        control.Event(x => nameof(x.Refreshing),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ListView_Extensions
{
    public static TControl OnScrollToRequested<TControl>(this TControl control,Action<Xamarin.Forms.ScrollToRequestedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ListView tv = null;

            tv.ScrollToRequested += handler;
            tv.ScrollToRequested -= handler;
        }

        control.Event(x => nameof(x.ScrollToRequested),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView>> _callExpression_BeginRefresh_Xamarin_Forms_ListView_ = (view) => view.BeginRefresh();

        public static TControl BeginRefresh<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_BeginRefresh_Xamarin_Forms_ListView_;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView>> _callExpression_EndRefresh_Xamarin_Forms_ListView_ = (view) => view.EndRefresh();

        public static TControl EndRefresh<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_EndRefresh_Xamarin_Forms_ListView_;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView, System.Int32, System.Int32, Xamarin.Forms.Cell>> _callExpression_NotifyRowTapped_Xamarin_Forms_ListView__System_Int32_System_Int32_Xamarin_Forms_Cell = (view, param1, param2, param3) => view.NotifyRowTapped(param1, param2, param3);

        public static TControl NotifyRowTapped<TControl>(this TControl component, System.Int32 pgroupIndex, System.Int32 pinGroupIndex, Xamarin.Forms.Cell pcell) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_NotifyRowTapped_Xamarin_Forms_ListView__System_Int32_System_Int32_Xamarin_Forms_Cell;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression, pgroupIndex, pinGroupIndex, pcell);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView, System.Int32, Xamarin.Forms.Cell>> _callExpression_NotifyRowTapped_Xamarin_Forms_ListView__System_Int32_Xamarin_Forms_Cell = (view, param1, param2) => view.NotifyRowTapped(param1, param2);

        public static TControl NotifyRowTapped<TControl>(this TControl component, System.Int32 pindex, Xamarin.Forms.Cell pcell) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_NotifyRowTapped_Xamarin_Forms_ListView__System_Int32_Xamarin_Forms_Cell;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression, pindex, pcell);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView, System.Object, Xamarin.Forms.ScrollToPosition, System.Boolean>> _callExpression_ScrollTo_Xamarin_Forms_ListView__System_Object_Xamarin_Forms_ScrollToPosition_System_Boolean = (view, param1, param2, param3) => view.ScrollTo(param1, param2, param3);

        public static TControl ScrollTo<TControl>(this TControl component, System.Object pitem, Xamarin.Forms.ScrollToPosition pposition, System.Boolean panimated) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_ScrollTo_Xamarin_Forms_ListView__System_Object_Xamarin_Forms_ScrollToPosition_System_Boolean;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression, pitem, pposition, panimated);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView, System.Object, System.Object, Xamarin.Forms.ScrollToPosition, System.Boolean>> _callExpression_ScrollTo_Xamarin_Forms_ListView__System_Object_System_Object_Xamarin_Forms_ScrollToPosition_System_Boolean = (view, param1, param2, param3, param4) => view.ScrollTo(param1, param2, param3, param4);

        public static TControl ScrollTo<TControl>(this TControl component, System.Object pitem, System.Object pgroup, Xamarin.Forms.ScrollToPosition pposition, System.Boolean panimated) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_ScrollTo_Xamarin_Forms_ListView__System_Object_System_Object_Xamarin_Forms_ScrollToPosition_System_Boolean;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression, pitem, pgroup, pposition, panimated);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView, Xamarin.Forms.Cell>> _callExpression_SendCellAppearing_Xamarin_Forms_ListView__Xamarin_Forms_Cell = (view, param1) => view.SendCellAppearing(param1);

        public static TControl SendCellAppearing<TControl>(this TControl component, Xamarin.Forms.Cell pcell) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_SendCellAppearing_Xamarin_Forms_ListView__Xamarin_Forms_Cell;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcell);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView, Xamarin.Forms.Cell>> _callExpression_SendCellDisappearing_Xamarin_Forms_ListView__Xamarin_Forms_Cell = (view, param1) => view.SendCellDisappearing(param1);

        public static TControl SendCellDisappearing<TControl>(this TControl component, Xamarin.Forms.Cell pcell) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_SendCellDisappearing_Xamarin_Forms_ListView__Xamarin_Forms_Cell;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcell);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView>> _callExpression_SendRefreshing_Xamarin_Forms_ListView_ = (view) => view.SendRefreshing();

        public static TControl SendRefreshing<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_SendRefreshing_Xamarin_Forms_ListView_;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ListView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ListView, Xamarin.Forms.ScrolledEventArgs>> _callExpression_SendScrolled_Xamarin_Forms_ListView__Xamarin_Forms_ScrolledEventArgs = (view, param1) => view.SendScrolled(param1);

        public static TControl SendScrolled<TControl>(this TControl component, Xamarin.Forms.ScrolledEventArgs pargs) where TControl:IReflectedPrimitive<Xamarin.Forms.ListView>
        {
            var callExpression = _callExpression_SendScrolled_Xamarin_Forms_ListView__Xamarin_Forms_ScrolledEventArgs;

            Reflect<Xamarin.Forms.ListView>.ReflectionHelpers.Call(component.Attributes,callExpression, pargs);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.MediaElement> MediaElement()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.MediaElement();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.MediaElement>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Aspect> Attribute_Aspect_Aspect = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.MediaElement, Xamarin.Forms.Aspect>
        (v => v.Aspect);

        public static TControl Aspect<TControl>(this TControl component, Xamarin.Forms.Aspect pAspect)  where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.MediaElement t = default;
                t.Aspect = default;
            }

            component.Attributes.SetAttribute(Attribute_Aspect_Aspect,pAspect);
            return component;
        }
    }
    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_AutoPlay = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.MediaElement, System.Boolean>
        (v => v.AutoPlay);

        public static TControl AutoPlay<TControl>(this TControl component, System.Boolean pAutoPlay)  where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.MediaElement t = default;
                t.AutoPlay = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_AutoPlay,pAutoPlay);
            return component;
        }
    }
    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsLooping = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.MediaElement, System.Boolean>
        (v => v.IsLooping);

        public static TControl IsLooping<TControl>(this TControl component, System.Boolean pIsLooping)  where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.MediaElement t = default;
                t.IsLooping = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsLooping,pIsLooping);
            return component;
        }
    }
    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_KeepScreenOn = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.MediaElement, System.Boolean>
        (v => v.KeepScreenOn);

        public static TControl KeepScreenOn<TControl>(this TControl component, System.Boolean pKeepScreenOn)  where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.MediaElement t = default;
                t.KeepScreenOn = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_KeepScreenOn,pKeepScreenOn);
            return component;
        }
    }
    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ShowsPlaybackControls = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.MediaElement, System.Boolean>
        (v => v.ShowsPlaybackControls);

        public static TControl ShowsPlaybackControls<TControl>(this TControl component, System.Boolean pShowsPlaybackControls)  where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.MediaElement t = default;
                t.ShowsPlaybackControls = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_ShowsPlaybackControls,pShowsPlaybackControls);
            return component;
        }
    }
    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static readonly Attribute<System.TimeSpan> Attribute_TimeSpan_Position = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.MediaElement, System.TimeSpan>
        (v => v.Position);

        public static TControl Position<TControl>(this TControl component, System.TimeSpan pPosition)  where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.MediaElement t = default;
                t.Position = default;
            }

            component.Attributes.SetAttribute(Attribute_TimeSpan_Position,pPosition);
            return component;
        }
    }
    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.MediaSource> Attribute_MediaSource_Source = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.MediaElement, Xamarin.Forms.MediaSource>
        (v => v.Source);

        ///<remarks>
        /// Xamarin.Forms.MediaSource doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Source<TControl>(this TControl component, Xamarin.Forms.MediaSource pSource)  where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.MediaElement t = default;
                t.Source = default;
            }

            component.Attributes.SetAttribute(Attribute_MediaSource_Source,pSource);
            return component;
        }
    }
    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Volume = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.MediaElement, System.Double>
        (v => v.Volume);

        public static TControl Volume<TControl>(this TControl component, System.Double pVolume)  where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.MediaElement t = default;
                t.Volume = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Volume,pVolume);
            return component;
        }
    }

public static partial class Xamarin_Forms_MediaElement_Extensions
{
    public static TControl OnSeekRequested<TControl>(this TControl control,Action<Xamarin.Forms.SeekRequested> action) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.MediaElement tv = null;

            tv.SeekRequested += handler;
            tv.SeekRequested -= handler;
        }

        control.Event(x => nameof(x.SeekRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_MediaElement_Extensions
{
    public static TControl OnStateRequested<TControl>(this TControl control,Action<Xamarin.Forms.StateRequested> action) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.MediaElement tv = null;

            tv.StateRequested += handler;
            tv.StateRequested -= handler;
        }

        control.Event(x => nameof(x.StateRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_MediaElement_Extensions
{
    public static TControl OnPositionRequested<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.MediaElement tv = null;

            tv.PositionRequested += handler;
            tv.PositionRequested -= handler;
        }

        control.Event(x => nameof(x.PositionRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_MediaElement_Extensions
{
    public static TControl OnVolumeRequested<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.MediaElement tv = null;

            tv.VolumeRequested += handler;
            tv.VolumeRequested -= handler;
        }

        control.Event(x => nameof(x.VolumeRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_MediaElement_Extensions
{
    public static TControl OnMediaEnded<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.MediaElement tv = null;

            tv.MediaEnded += handler;
            tv.MediaEnded -= handler;
        }

        control.Event(x => nameof(x.MediaEnded),action);
        return control;
    }
}
public static partial class Xamarin_Forms_MediaElement_Extensions
{
    public static TControl OnMediaFailed<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.MediaElement tv = null;

            tv.MediaFailed += handler;
            tv.MediaFailed -= handler;
        }

        control.Event(x => nameof(x.MediaFailed),action);
        return control;
    }
}
public static partial class Xamarin_Forms_MediaElement_Extensions
{
    public static TControl OnMediaOpened<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.MediaElement tv = null;

            tv.MediaOpened += handler;
            tv.MediaOpened -= handler;
        }

        control.Event(x => nameof(x.MediaOpened),action);
        return control;
    }
}
public static partial class Xamarin_Forms_MediaElement_Extensions
{
    public static TControl OnSeekCompleted<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.MediaElement tv = null;

            tv.SeekCompleted += handler;
            tv.SeekCompleted -= handler;
        }

        control.Event(x => nameof(x.SeekCompleted),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static Expression<Action<Xamarin.Forms.MediaElement>> _callExpression_Pause_Xamarin_Forms_MediaElement_ = (view) => view.Pause();

        public static TControl Pause<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            var callExpression = _callExpression_Pause_Xamarin_Forms_MediaElement_;

            Reflect<Xamarin.Forms.MediaElement>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static Expression<Action<Xamarin.Forms.MediaElement>> _callExpression_Play_Xamarin_Forms_MediaElement_ = (view) => view.Play();

        public static TControl Play<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            var callExpression = _callExpression_Play_Xamarin_Forms_MediaElement_;

            Reflect<Xamarin.Forms.MediaElement>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_MediaElement_Extensions
    {
        private static Expression<Action<Xamarin.Forms.MediaElement>> _callExpression_Stop_Xamarin_Forms_MediaElement_ = (view) => view.Stop();

        public static TControl Stop<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.MediaElement>
        {
            var callExpression = _callExpression_Stop_Xamarin_Forms_MediaElement_;

            Reflect<Xamarin.Forms.MediaElement>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.OpenGLView> OpenGLView()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.OpenGLView();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.OpenGLView>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_OpenGLView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_HasRenderLoop = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.OpenGLView, System.Boolean>
        (v => v.HasRenderLoop);

        public static TControl HasRenderLoop<TControl>(this TControl component, System.Boolean pHasRenderLoop)  where TControl:IReflectedPrimitive<Xamarin.Forms.OpenGLView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.OpenGLView t = default;
                t.HasRenderLoop = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_HasRenderLoop,pHasRenderLoop);
            return component;
        }
    }

public static partial class Xamarin_Forms_OpenGLView_Extensions
{
    public static TControl OnDisplayRequested<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.OpenGLView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.OpenGLView tv = null;

            tv.DisplayRequested += handler;
            tv.DisplayRequested -= handler;
        }

        control.Event(x => nameof(x.DisplayRequested),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_OpenGLView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.OpenGLView>> _callExpression_Display_Xamarin_Forms_OpenGLView_ = (view) => view.Display();

        public static TControl Display<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.OpenGLView>
        {
            var callExpression = _callExpression_Display_Xamarin_Forms_OpenGLView_;

            Reflect<Xamarin.Forms.OpenGLView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.Picker> Picker()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.Picker();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.Picker>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FontAttributes> Attribute_FontAttributes_FontAttributes = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, Xamarin.Forms.FontAttributes>
        (v => v.FontAttributes);

        public static TControl FontAttributes<TControl>(this TControl component, Xamarin.Forms.FontAttributes pFontAttributes)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.FontAttributes = default;
            }

            component.Attributes.SetAttribute(Attribute_FontAttributes_FontAttributes,pFontAttributes);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_FontFamily = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, System.String>
        (v => v.FontFamily);

        public static TControl FontFamily<TControl>(this TControl component, System.String pFontFamily)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.FontFamily = default;
            }

            component.Attributes.SetAttribute(Attribute_String_FontFamily,pFontFamily);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_FontSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, System.Double>
        (v => v.FontSize);

        public static TControl FontSize<TControl>(this TControl component, System.Double pFontSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.FontSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_FontSize,pFontSize);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<System.Collections.IList> Attribute_IList_ItemsSource = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, System.Collections.IList>
        (v => v.ItemsSource);

        ///<remarks>
        /// System.Collections.IList doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ItemsSource<TControl>(this TControl component, System.Collections.IList pItemsSource)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.ItemsSource = default;
            }

            component.Attributes.SetAttribute(Attribute_IList_ItemsSource,pItemsSource);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_SelectedIndex = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, System.Int32>
        (v => v.SelectedIndex);

        public static TControl SelectedIndex<TControl>(this TControl component, System.Int32 pSelectedIndex)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.SelectedIndex = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_SelectedIndex,pSelectedIndex);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_SelectedItem = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, System.Object>
        (v => v.SelectedItem);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl SelectedItem<TControl>(this TControl component, System.Object pSelectedItem)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.SelectedItem = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_SelectedItem,pSelectedItem);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_TextColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, Xamarin.Forms.Color>
        (v => v.TextColor);

        public static TControl TextColor<TControl>(this TControl component, Xamarin.Forms.Color pTextColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.TextColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_TextColor,pTextColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_CharacterSpacing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, System.Double>
        (v => v.CharacterSpacing);

        public static TControl CharacterSpacing<TControl>(this TControl component, System.Double pCharacterSpacing)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.CharacterSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_CharacterSpacing,pCharacterSpacing);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Title = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, System.String>
        (v => v.Title);

        public static TControl Title<TControl>(this TControl component, System.String pTitle)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.Title = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Title,pTitle);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_TitleColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, Xamarin.Forms.Color>
        (v => v.TitleColor);

        public static TControl TitleColor<TControl>(this TControl component, Xamarin.Forms.Color pTitleColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.TitleColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_TitleColor,pTitleColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Picker_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.BindingBase> Attribute_BindingBase_ItemDisplayBinding = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Picker, Xamarin.Forms.BindingBase>
        (v => v.ItemDisplayBinding);

        ///<remarks>
        /// Xamarin.Forms.BindingBase doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl ItemDisplayBinding<TControl>(this TControl component, Xamarin.Forms.BindingBase pItemDisplayBinding)  where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Picker t = default;
                t.ItemDisplayBinding = default;
            }

            component.Attributes.SetAttribute(Attribute_BindingBase_ItemDisplayBinding,pItemDisplayBinding);
            return component;
        }
    }

public static partial class Xamarin_Forms_Picker_Extensions
{
    public static TControl OnSelectedIndexChanged<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Picker>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Picker tv = null;

            tv.SelectedIndexChanged += handler;
            tv.SelectedIndexChanged -= handler;
        }

        control.Event(x => nameof(x.SelectedIndexChanged),action);
        return control;
    }
}

    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.ProgressBar> ProgressBar()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.ProgressBar();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.ProgressBar>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_ProgressBar_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_ProgressColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ProgressBar, Xamarin.Forms.Color>
        (v => v.ProgressColor);

        public static TControl ProgressColor<TControl>(this TControl component, Xamarin.Forms.Color pProgressColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ProgressBar t = default;
                t.ProgressColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_ProgressColor,pProgressColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ProgressBar_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Progress = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ProgressBar, System.Double>
        (v => v.Progress);

        public static TControl Progress<TControl>(this TControl component, System.Double pProgress)  where TControl:IReflectedPrimitive<Xamarin.Forms.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ProgressBar t = default;
                t.Progress = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Progress,pProgress);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.RefreshView> RefreshView()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.RefreshView();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.RefreshView>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_RefreshView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsRefreshing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.RefreshView, System.Boolean>
        (v => v.IsRefreshing);

        public static TControl IsRefreshing<TControl>(this TControl component, System.Boolean pIsRefreshing)  where TControl:IReflectedPrimitive<Xamarin.Forms.RefreshView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.RefreshView t = default;
                t.IsRefreshing = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsRefreshing,pIsRefreshing);
            return component;
        }
    }
    public static partial class Xamarin_Forms_RefreshView_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_Command = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.RefreshView, System.Windows.Input.ICommand>
        (v => v.Command);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Command<TControl>(this TControl component, System.Windows.Input.ICommand pCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.RefreshView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.RefreshView t = default;
                t.Command = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_Command,pCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_RefreshView_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_CommandParameter = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.RefreshView, System.Object>
        (v => v.CommandParameter);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl CommandParameter<TControl>(this TControl component, System.Object pCommandParameter)  where TControl:IReflectedPrimitive<Xamarin.Forms.RefreshView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.RefreshView t = default;
                t.CommandParameter = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_CommandParameter,pCommandParameter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_RefreshView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_RefreshColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.RefreshView, Xamarin.Forms.Color>
        (v => v.RefreshColor);

        public static TControl RefreshColor<TControl>(this TControl component, Xamarin.Forms.Color pRefreshColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.RefreshView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.RefreshView t = default;
                t.RefreshColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_RefreshColor,pRefreshColor);
            return component;
        }
    }

public static partial class Xamarin_Forms_RefreshView_Extensions
{
    public static TControl OnRefreshing<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.RefreshView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.RefreshView tv = null;

            tv.Refreshing += handler;
            tv.Refreshing -= handler;
        }

        control.Event(x => nameof(x.Refreshing),action);
        return control;
    }
}





    public static partial class Xamarin_Forms_ScrollView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Rectangle> Attribute_Rectangle_LayoutAreaOverride = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ScrollView, Xamarin.Forms.Rectangle>
        (v => v.LayoutAreaOverride);

        public static TControl LayoutAreaOverride<TControl>(this TControl component, Xamarin.Forms.Rectangle pLayoutAreaOverride)  where TControl:IReflectedPrimitive<Xamarin.Forms.ScrollView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ScrollView t = default;
                t.LayoutAreaOverride = default;
            }

            component.Attributes.SetAttribute(Attribute_Rectangle_LayoutAreaOverride,pLayoutAreaOverride);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ScrollView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.View> Attribute_View_Content = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ScrollView, Xamarin.Forms.View>
        (v => v.Content);

        ///<remarks>
        /// Xamarin.Forms.View doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Content<TControl>(this TControl component, Xamarin.Forms.View pContent)  where TControl:IReflectedPrimitive<Xamarin.Forms.ScrollView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ScrollView t = default;
                t.Content = default;
            }

            component.Attributes.SetAttribute(Attribute_View_Content,pContent);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ScrollView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ScrollOrientation> Attribute_ScrollOrientation_Orientation = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ScrollView, Xamarin.Forms.ScrollOrientation>
        (v => v.Orientation);

        public static TControl Orientation<TControl>(this TControl component, Xamarin.Forms.ScrollOrientation pOrientation)  where TControl:IReflectedPrimitive<Xamarin.Forms.ScrollView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ScrollView t = default;
                t.Orientation = default;
            }

            component.Attributes.SetAttribute(Attribute_ScrollOrientation_Orientation,pOrientation);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ScrollView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ScrollBarVisibility> Attribute_ScrollBarVisibility_HorizontalScrollBarVisibility = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ScrollView, Xamarin.Forms.ScrollBarVisibility>
        (v => v.HorizontalScrollBarVisibility);

        public static TControl HorizontalScrollBarVisibility<TControl>(this TControl component, Xamarin.Forms.ScrollBarVisibility pHorizontalScrollBarVisibility)  where TControl:IReflectedPrimitive<Xamarin.Forms.ScrollView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ScrollView t = default;
                t.HorizontalScrollBarVisibility = default;
            }

            component.Attributes.SetAttribute(Attribute_ScrollBarVisibility_HorizontalScrollBarVisibility,pHorizontalScrollBarVisibility);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ScrollView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ScrollBarVisibility> Attribute_ScrollBarVisibility_VerticalScrollBarVisibility = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.ScrollView, Xamarin.Forms.ScrollBarVisibility>
        (v => v.VerticalScrollBarVisibility);

        public static TControl VerticalScrollBarVisibility<TControl>(this TControl component, Xamarin.Forms.ScrollBarVisibility pVerticalScrollBarVisibility)  where TControl:IReflectedPrimitive<Xamarin.Forms.ScrollView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.ScrollView t = default;
                t.VerticalScrollBarVisibility = default;
            }

            component.Attributes.SetAttribute(Attribute_ScrollBarVisibility_VerticalScrollBarVisibility,pVerticalScrollBarVisibility);
            return component;
        }
    }

public static partial class Xamarin_Forms_ScrollView_Extensions
{
    public static TControl OnScrollToRequested<TControl>(this TControl control,Action<Xamarin.Forms.ScrollToRequestedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ScrollView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ScrollView tv = null;

            tv.ScrollToRequested += handler;
            tv.ScrollToRequested -= handler;
        }

        control.Event(x => nameof(x.ScrollToRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_ScrollView_Extensions
{
    public static TControl OnScrolled<TControl>(this TControl control,Action<Xamarin.Forms.ScrolledEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.ScrollView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.ScrollView tv = null;

            tv.Scrolled += handler;
            tv.Scrolled -= handler;
        }

        control.Event(x => nameof(x.Scrolled),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_ScrollView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ScrollView>> _callExpression_SendScrollFinished_Xamarin_Forms_ScrollView_ = (view) => view.SendScrollFinished();

        public static TControl SendScrollFinished<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.ScrollView>
        {
            var callExpression = _callExpression_SendScrollFinished_Xamarin_Forms_ScrollView_;

            Reflect<Xamarin.Forms.ScrollView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_ScrollView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.ScrollView, System.Double, System.Double>> _callExpression_SetScrolledPosition_Xamarin_Forms_ScrollView__System_Double_System_Double = (view, param1, param2) => view.SetScrolledPosition(param1, param2);

        public static TControl SetScrolledPosition<TControl>(this TControl component, System.Double px, System.Double py) where TControl:IReflectedPrimitive<Xamarin.Forms.ScrollView>
        {
            var callExpression = _callExpression_SetScrolledPosition_Xamarin_Forms_ScrollView__System_Double_System_Double;

            Reflect<Xamarin.Forms.ScrollView>.ReflectionHelpers.Call(component.Attributes,callExpression, px, py);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.SearchBar> SearchBar()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.SearchBar();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.SearchBar>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_SearchBar_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_CancelButtonColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SearchBar, Xamarin.Forms.Color>
        (v => v.CancelButtonColor);

        public static TControl CancelButtonColor<TControl>(this TControl component, Xamarin.Forms.Color pCancelButtonColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SearchBar t = default;
                t.CancelButtonColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_CancelButtonColor,pCancelButtonColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SearchBar_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_HorizontalTextAlignment = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SearchBar, Xamarin.Forms.TextAlignment>
        (v => v.HorizontalTextAlignment);

        public static TControl HorizontalTextAlignment<TControl>(this TControl component, Xamarin.Forms.TextAlignment pHorizontalTextAlignment)  where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SearchBar t = default;
                t.HorizontalTextAlignment = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_HorizontalTextAlignment,pHorizontalTextAlignment);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SearchBar_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TextAlignment> Attribute_TextAlignment_VerticalTextAlignment = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SearchBar, Xamarin.Forms.TextAlignment>
        (v => v.VerticalTextAlignment);

        public static TControl VerticalTextAlignment<TControl>(this TControl component, Xamarin.Forms.TextAlignment pVerticalTextAlignment)  where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SearchBar t = default;
                t.VerticalTextAlignment = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_VerticalTextAlignment,pVerticalTextAlignment);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SearchBar_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_SearchCommand = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SearchBar, System.Windows.Input.ICommand>
        (v => v.SearchCommand);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl SearchCommand<TControl>(this TControl component, System.Windows.Input.ICommand pSearchCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SearchBar t = default;
                t.SearchCommand = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_SearchCommand,pSearchCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SearchBar_Extensions
    {
        private static readonly Attribute<System.Object> Attribute_Object_SearchCommandParameter = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SearchBar, System.Object>
        (v => v.SearchCommandParameter);

        ///<remarks>
        /// System.Object doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl SearchCommandParameter<TControl>(this TControl component, System.Object pSearchCommandParameter)  where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SearchBar t = default;
                t.SearchCommandParameter = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_SearchCommandParameter,pSearchCommandParameter);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SearchBar_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FontAttributes> Attribute_FontAttributes_FontAttributes = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SearchBar, Xamarin.Forms.FontAttributes>
        (v => v.FontAttributes);

        public static TControl FontAttributes<TControl>(this TControl component, Xamarin.Forms.FontAttributes pFontAttributes)  where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SearchBar t = default;
                t.FontAttributes = default;
            }

            component.Attributes.SetAttribute(Attribute_FontAttributes_FontAttributes,pFontAttributes);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SearchBar_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_FontFamily = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SearchBar, System.String>
        (v => v.FontFamily);

        public static TControl FontFamily<TControl>(this TControl component, System.String pFontFamily)  where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SearchBar t = default;
                t.FontFamily = default;
            }

            component.Attributes.SetAttribute(Attribute_String_FontFamily,pFontFamily);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SearchBar_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_FontSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SearchBar, System.Double>
        (v => v.FontSize);

        public static TControl FontSize<TControl>(this TControl component, System.Double pFontSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SearchBar t = default;
                t.FontSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_FontSize,pFontSize);
            return component;
        }
    }

public static partial class Xamarin_Forms_SearchBar_Extensions
{
    public static TControl OnSearchButtonPressed<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.SearchBar tv = null;

            tv.SearchButtonPressed += handler;
            tv.SearchButtonPressed -= handler;
        }

        control.Event(x => nameof(x.SearchButtonPressed),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_SearchBar_Extensions
    {
        private static Expression<Action<Xamarin.Forms.SearchBar>> _callExpression_OnSearchButtonPressed_Xamarin_Forms_SearchBar_ = (view) => view.OnSearchButtonPressed();

        public static TControl OnSearchButtonPressed<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.SearchBar>
        {
            var callExpression = _callExpression_OnSearchButtonPressed_Xamarin_Forms_SearchBar_;

            Reflect<Xamarin.Forms.SearchBar>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }

    public static partial class Xamarin_Forms_Slider_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_MinimumTrackColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Slider, Xamarin.Forms.Color>
        (v => v.MinimumTrackColor);

        public static TControl MinimumTrackColor<TControl>(this TControl component, Xamarin.Forms.Color pMinimumTrackColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Slider t = default;
                t.MinimumTrackColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_MinimumTrackColor,pMinimumTrackColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Slider_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_MaximumTrackColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Slider, Xamarin.Forms.Color>
        (v => v.MaximumTrackColor);

        public static TControl MaximumTrackColor<TControl>(this TControl component, Xamarin.Forms.Color pMaximumTrackColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Slider t = default;
                t.MaximumTrackColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_MaximumTrackColor,pMaximumTrackColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Slider_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_ThumbColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Slider, Xamarin.Forms.Color>
        (v => v.ThumbColor);

        public static TControl ThumbColor<TControl>(this TControl component, Xamarin.Forms.Color pThumbColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Slider t = default;
                t.ThumbColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_ThumbColor,pThumbColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Slider_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_DragStartedCommand = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Slider, System.Windows.Input.ICommand>
        (v => v.DragStartedCommand);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl DragStartedCommand<TControl>(this TControl component, System.Windows.Input.ICommand pDragStartedCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Slider t = default;
                t.DragStartedCommand = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_DragStartedCommand,pDragStartedCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Slider_Extensions
    {
        private static readonly Attribute<System.Windows.Input.ICommand> Attribute_ICommand_DragCompletedCommand = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Slider, System.Windows.Input.ICommand>
        (v => v.DragCompletedCommand);

        ///<remarks>
        /// System.Windows.Input.ICommand doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl DragCompletedCommand<TControl>(this TControl component, System.Windows.Input.ICommand pDragCompletedCommand)  where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Slider t = default;
                t.DragCompletedCommand = default;
            }

            component.Attributes.SetAttribute(Attribute_ICommand_DragCompletedCommand,pDragCompletedCommand);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Slider_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Maximum = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Slider, System.Double>
        (v => v.Maximum);

        public static TControl Maximum<TControl>(this TControl component, System.Double pMaximum)  where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Slider t = default;
                t.Maximum = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Maximum,pMaximum);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Slider_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Minimum = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Slider, System.Double>
        (v => v.Minimum);

        public static TControl Minimum<TControl>(this TControl component, System.Double pMinimum)  where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Slider t = default;
                t.Minimum = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Minimum,pMinimum);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Slider_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Value = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Slider, System.Double>
        (v => v.Value);

        public static TControl Value<TControl>(this TControl component, System.Double pValue)  where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Slider t = default;
                t.Value = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Value,pValue);
            return component;
        }
    }

public static partial class Xamarin_Forms_Slider_Extensions
{
    public static TControl OnValueChanged<TControl>(this TControl control,Action<Xamarin.Forms.ValueChangedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Slider tv = null;

            tv.ValueChanged += handler;
            tv.ValueChanged -= handler;
        }

        control.Event(x => nameof(x.ValueChanged),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Slider_Extensions
{
    public static TControl OnDragStarted<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Slider tv = null;

            tv.DragStarted += handler;
            tv.DragStarted -= handler;
        }

        control.Event(x => nameof(x.DragStarted),action);
        return control;
    }
}
public static partial class Xamarin_Forms_Slider_Extensions
{
    public static TControl OnDragCompleted<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.Slider>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Slider tv = null;

            tv.DragCompleted += handler;
            tv.DragCompleted -= handler;
        }

        control.Event(x => nameof(x.DragCompleted),action);
        return control;
    }
}


    public static partial class Xamarin_Forms_StackLayout_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.StackOrientation> Attribute_StackOrientation_Orientation = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.StackLayout, Xamarin.Forms.StackOrientation>
        (v => v.Orientation);

        public static TControl Orientation<TControl>(this TControl component, Xamarin.Forms.StackOrientation pOrientation)  where TControl:IReflectedPrimitive<Xamarin.Forms.StackLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.StackLayout t = default;
                t.Orientation = default;
            }

            component.Attributes.SetAttribute(Attribute_StackOrientation_Orientation,pOrientation);
            return component;
        }
    }
    public static partial class Xamarin_Forms_StackLayout_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Spacing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.StackLayout, System.Double>
        (v => v.Spacing);

        public static TControl Spacing<TControl>(this TControl component, System.Double pSpacing)  where TControl:IReflectedPrimitive<Xamarin.Forms.StackLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.StackLayout t = default;
                t.Spacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Spacing,pSpacing);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.SwipeView> SwipeView()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.SwipeView();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.SwipeView>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_SwipeView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.SwipeItems> Attribute_SwipeItems_LeftItems = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SwipeView, Xamarin.Forms.SwipeItems>
        (v => v.LeftItems);

        ///<remarks>
        /// Collection. Xamarin.Forms.SwipeItems doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl LeftItems<TControl>(this TControl component, Xamarin.Forms.SwipeItems pLeftItems)  where TControl:IReflectedPrimitive<Xamarin.Forms.SwipeView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SwipeView t = default;
                t.LeftItems = default;
            }

            component.Attributes.SetAttribute(Attribute_SwipeItems_LeftItems,pLeftItems);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SwipeView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.SwipeItems> Attribute_SwipeItems_RightItems = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SwipeView, Xamarin.Forms.SwipeItems>
        (v => v.RightItems);

        ///<remarks>
        /// Collection. Xamarin.Forms.SwipeItems doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl RightItems<TControl>(this TControl component, Xamarin.Forms.SwipeItems pRightItems)  where TControl:IReflectedPrimitive<Xamarin.Forms.SwipeView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SwipeView t = default;
                t.RightItems = default;
            }

            component.Attributes.SetAttribute(Attribute_SwipeItems_RightItems,pRightItems);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SwipeView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.SwipeItems> Attribute_SwipeItems_TopItems = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SwipeView, Xamarin.Forms.SwipeItems>
        (v => v.TopItems);

        ///<remarks>
        /// Collection. Xamarin.Forms.SwipeItems doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl TopItems<TControl>(this TControl component, Xamarin.Forms.SwipeItems pTopItems)  where TControl:IReflectedPrimitive<Xamarin.Forms.SwipeView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SwipeView t = default;
                t.TopItems = default;
            }

            component.Attributes.SetAttribute(Attribute_SwipeItems_TopItems,pTopItems);
            return component;
        }
    }
    public static partial class Xamarin_Forms_SwipeView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.SwipeItems> Attribute_SwipeItems_BottomItems = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.SwipeView, Xamarin.Forms.SwipeItems>
        (v => v.BottomItems);

        ///<remarks>
        /// Collection. Xamarin.Forms.SwipeItems doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl BottomItems<TControl>(this TControl component, Xamarin.Forms.SwipeItems pBottomItems)  where TControl:IReflectedPrimitive<Xamarin.Forms.SwipeView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.SwipeView t = default;
                t.BottomItems = default;
            }

            component.Attributes.SetAttribute(Attribute_SwipeItems_BottomItems,pBottomItems);
            return component;
        }
    }

public static partial class Xamarin_Forms_SwipeView_Extensions
{
    public static TControl OnSwipeStarted<TControl>(this TControl control,Action<Xamarin.Forms.SwipeStartedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.SwipeView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.SwipeView tv = null;

            tv.SwipeStarted += handler;
            tv.SwipeStarted -= handler;
        }

        control.Event(x => nameof(x.SwipeStarted),action);
        return control;
    }
}
public static partial class Xamarin_Forms_SwipeView_Extensions
{
    public static TControl OnSwipeChanging<TControl>(this TControl control,Action<Xamarin.Forms.SwipeChangingEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.SwipeView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.SwipeView tv = null;

            tv.SwipeChanging += handler;
            tv.SwipeChanging -= handler;
        }

        control.Event(x => nameof(x.SwipeChanging),action);
        return control;
    }
}
public static partial class Xamarin_Forms_SwipeView_Extensions
{
    public static TControl OnSwipeEnded<TControl>(this TControl control,Action<Xamarin.Forms.SwipeEndedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.SwipeView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.SwipeView tv = null;

            tv.SwipeEnded += handler;
            tv.SwipeEnded -= handler;
        }

        control.Event(x => nameof(x.SwipeEnded),action);
        return control;
    }
}
public static partial class Xamarin_Forms_SwipeView_Extensions
{
    public static TControl OnCloseRequested<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.SwipeView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.SwipeView tv = null;

            tv.CloseRequested += handler;
            tv.CloseRequested -= handler;
        }

        control.Event(x => nameof(x.CloseRequested),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_SwipeView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.SwipeView>> _callExpression_Close_Xamarin_Forms_SwipeView_ = (view) => view.Close();

        public static TControl Close<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.SwipeView>
        {
            var callExpression = _callExpression_Close_Xamarin_Forms_SwipeView_;

            Reflect<Xamarin.Forms.SwipeView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.Switch> Switch(System.Boolean pIsToggled)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.Switch();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.Switch>();
            
            control.IsToggled(pIsToggled);
            return control;
        }    
    }

    public static partial class Xamarin_Forms_Switch_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_OnColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Switch, Xamarin.Forms.Color>
        (v => v.OnColor);

        public static TControl OnColor<TControl>(this TControl component, Xamarin.Forms.Color pOnColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Switch t = default;
                t.OnColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_OnColor,pOnColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Switch_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_ThumbColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Switch, Xamarin.Forms.Color>
        (v => v.ThumbColor);

        public static TControl ThumbColor<TControl>(this TControl component, Xamarin.Forms.Color pThumbColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Switch t = default;
                t.ThumbColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_ThumbColor,pThumbColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_Switch_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsToggled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.Switch, System.Boolean>
        (v => v.IsToggled);

        public static TControl IsToggled<TControl>(this TControl component, System.Boolean pIsToggled)  where TControl:IReflectedPrimitive<Xamarin.Forms.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.Switch t = default;
                t.IsToggled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsToggled,pIsToggled);
            return component;
        }
    }

public static partial class Xamarin_Forms_Switch_Extensions
{
    public static TControl OnToggled<TControl>(this TControl control,Action<Xamarin.Forms.ToggledEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.Switch>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.Switch tv = null;

            tv.Toggled += handler;
            tv.Toggled -= handler;
        }

        control.Event(x => nameof(x.Toggled),action);
        return control;
    }
}


    public static partial class Xamarin_Forms_TableView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_HasUnevenRows = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TableView, System.Boolean>
        (v => v.HasUnevenRows);

        public static TControl HasUnevenRows<TControl>(this TControl component, System.Boolean pHasUnevenRows)  where TControl:IReflectedPrimitive<Xamarin.Forms.TableView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TableView t = default;
                t.HasUnevenRows = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_HasUnevenRows,pHasUnevenRows);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TableView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TableIntent> Attribute_TableIntent_Intent = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TableView, Xamarin.Forms.TableIntent>
        (v => v.Intent);

        public static TControl Intent<TControl>(this TControl component, Xamarin.Forms.TableIntent pIntent)  where TControl:IReflectedPrimitive<Xamarin.Forms.TableView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TableView t = default;
                t.Intent = default;
            }

            component.Attributes.SetAttribute(Attribute_TableIntent_Intent,pIntent);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TableView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.TableRoot> Attribute_TableRoot_Root = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TableView, Xamarin.Forms.TableRoot>
        (v => v.Root);

        ///<remarks>
        /// Collection. Xamarin.Forms.TableRoot doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Root<TControl>(this TControl component, Xamarin.Forms.TableRoot pRoot)  where TControl:IReflectedPrimitive<Xamarin.Forms.TableView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TableView t = default;
                t.Root = default;
            }

            component.Attributes.SetAttribute(Attribute_TableRoot_Root,pRoot);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TableView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_RowHeight = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TableView, System.Int32>
        (v => v.RowHeight);

        public static TControl RowHeight<TControl>(this TControl component, System.Int32 pRowHeight)  where TControl:IReflectedPrimitive<Xamarin.Forms.TableView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TableView t = default;
                t.RowHeight = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_RowHeight,pRowHeight);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TableView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Internals.TableModel> Attribute_TableModel_Model = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TableView, Xamarin.Forms.Internals.TableModel>
        (v => v.Model);

        ///<remarks>
        /// Xamarin.Forms.Internals.TableModel doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Model<TControl>(this TControl component, Xamarin.Forms.Internals.TableModel pModel)  where TControl:IReflectedPrimitive<Xamarin.Forms.TableView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TableView t = default;
                t.Model = default;
            }

            component.Attributes.SetAttribute(Attribute_TableModel_Model,pModel);
            return component;
        }
    }

public static partial class Xamarin_Forms_TableView_Extensions
{
    public static TControl OnModelChanged<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.TableView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.TableView tv = null;

            tv.ModelChanged += handler;
            tv.ModelChanged -= handler;
        }

        control.Event(x => nameof(x.ModelChanged),action);
        return control;
    }
}

    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.TimePicker> TimePicker()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.TimePicker();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.TimePicker>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_TimePicker_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Format = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TimePicker, System.String>
        (v => v.Format);

        public static TControl Format<TControl>(this TControl component, System.String pFormat)  where TControl:IReflectedPrimitive<Xamarin.Forms.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TimePicker t = default;
                t.Format = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Format,pFormat);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TimePicker_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_TextColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TimePicker, Xamarin.Forms.Color>
        (v => v.TextColor);

        public static TControl TextColor<TControl>(this TControl component, Xamarin.Forms.Color pTextColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TimePicker t = default;
                t.TextColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_TextColor,pTextColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TimePicker_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_CharacterSpacing = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TimePicker, System.Double>
        (v => v.CharacterSpacing);

        public static TControl CharacterSpacing<TControl>(this TControl component, System.Double pCharacterSpacing)  where TControl:IReflectedPrimitive<Xamarin.Forms.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TimePicker t = default;
                t.CharacterSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_CharacterSpacing,pCharacterSpacing);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TimePicker_Extensions
    {
        private static readonly Attribute<System.TimeSpan> Attribute_TimeSpan_Time = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TimePicker, System.TimeSpan>
        (v => v.Time);

        public static TControl Time<TControl>(this TControl component, System.TimeSpan pTime)  where TControl:IReflectedPrimitive<Xamarin.Forms.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TimePicker t = default;
                t.Time = default;
            }

            component.Attributes.SetAttribute(Attribute_TimeSpan_Time,pTime);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TimePicker_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FontAttributes> Attribute_FontAttributes_FontAttributes = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TimePicker, Xamarin.Forms.FontAttributes>
        (v => v.FontAttributes);

        public static TControl FontAttributes<TControl>(this TControl component, Xamarin.Forms.FontAttributes pFontAttributes)  where TControl:IReflectedPrimitive<Xamarin.Forms.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TimePicker t = default;
                t.FontAttributes = default;
            }

            component.Attributes.SetAttribute(Attribute_FontAttributes_FontAttributes,pFontAttributes);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TimePicker_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_FontFamily = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TimePicker, System.String>
        (v => v.FontFamily);

        public static TControl FontFamily<TControl>(this TControl component, System.String pFontFamily)  where TControl:IReflectedPrimitive<Xamarin.Forms.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TimePicker t = default;
                t.FontFamily = default;
            }

            component.Attributes.SetAttribute(Attribute_String_FontFamily,pFontFamily);
            return component;
        }
    }
    public static partial class Xamarin_Forms_TimePicker_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_FontSize = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.TimePicker, System.Double>
        (v => v.FontSize);

        public static TControl FontSize<TControl>(this TControl component, System.Double pFontSize)  where TControl:IReflectedPrimitive<Xamarin.Forms.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.TimePicker t = default;
                t.FontSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_FontSize,pFontSize);
            return component;
        }
    }



    public static partial class Xamarin_Forms_View_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.LayoutOptions> Attribute_LayoutOptions_HorizontalOptions = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.View, Xamarin.Forms.LayoutOptions>
        (v => v.HorizontalOptions);

        public static TControl HorizontalOptions<TControl>(this TControl component, Xamarin.Forms.LayoutOptions pHorizontalOptions)  where TControl:IReflectedPrimitive<Xamarin.Forms.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.View t = default;
                t.HorizontalOptions = default;
            }

            component.Attributes.SetAttribute(Attribute_LayoutOptions_HorizontalOptions,pHorizontalOptions);
            return component;
        }
    }
    public static partial class Xamarin_Forms_View_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Thickness> Attribute_Thickness_Margin = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.View, Xamarin.Forms.Thickness>
        (v => v.Margin);

        public static TControl Margin<TControl>(this TControl component, Xamarin.Forms.Thickness pMargin)  where TControl:IReflectedPrimitive<Xamarin.Forms.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.View t = default;
                t.Margin = default;
            }

            component.Attributes.SetAttribute(Attribute_Thickness_Margin,pMargin);
            return component;
        }
    }
    public static partial class Xamarin_Forms_View_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.LayoutOptions> Attribute_LayoutOptions_VerticalOptions = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.View, Xamarin.Forms.LayoutOptions>
        (v => v.VerticalOptions);

        public static TControl VerticalOptions<TControl>(this TControl component, Xamarin.Forms.LayoutOptions pVerticalOptions)  where TControl:IReflectedPrimitive<Xamarin.Forms.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.View t = default;
                t.VerticalOptions = default;
            }

            component.Attributes.SetAttribute(Attribute_LayoutOptions_VerticalOptions,pVerticalOptions);
            return component;
        }
    }



    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.IVisual> Attribute_IVisual_Visual = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, Xamarin.Forms.IVisual>
        (v => v.Visual);

        ///<remarks>
        /// Xamarin.Forms.IVisual doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Visual<TControl>(this TControl component, Xamarin.Forms.IVisual pVisual)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.Visual = default;
            }

            component.Attributes.SetAttribute(Attribute_IVisual_Visual,pVisual);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.FlowDirection> Attribute_FlowDirection_FlowDirection = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, Xamarin.Forms.FlowDirection>
        (v => v.FlowDirection);

        public static TControl FlowDirection<TControl>(this TControl component, Xamarin.Forms.FlowDirection pFlowDirection)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.FlowDirection = default;
            }

            component.Attributes.SetAttribute(Attribute_FlowDirection_FlowDirection,pFlowDirection);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_AnchorX = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.AnchorX);

        public static TControl AnchorX<TControl>(this TControl component, System.Double pAnchorX)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.AnchorX = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_AnchorX,pAnchorX);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_AnchorY = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.AnchorY);

        public static TControl AnchorY<TControl>(this TControl component, System.Double pAnchorY)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.AnchorY = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_AnchorY,pAnchorY);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.Color> Attribute_Color_BackgroundColor = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, Xamarin.Forms.Color>
        (v => v.BackgroundColor);

        public static TControl BackgroundColor<TControl>(this TControl component, Xamarin.Forms.Color pBackgroundColor)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.BackgroundColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_BackgroundColor,pBackgroundColor);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_HeightRequest = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.HeightRequest);

        public static TControl HeightRequest<TControl>(this TControl component, System.Double pHeightRequest)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.HeightRequest = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_HeightRequest,pHeightRequest);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_InputTransparent = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Boolean>
        (v => v.InputTransparent);

        public static TControl InputTransparent<TControl>(this TControl component, System.Boolean pInputTransparent)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.InputTransparent = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_InputTransparent,pInputTransparent);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Boolean>
        (v => v.IsEnabled);

        public static TControl IsEnabled<TControl>(this TControl component, System.Boolean pIsEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.IsEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsEnabled,pIsEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsVisible = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Boolean>
        (v => v.IsVisible);

        public static TControl IsVisible<TControl>(this TControl component, System.Boolean pIsVisible)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.IsVisible = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsVisible,pIsVisible);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_MinimumHeightRequest = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.MinimumHeightRequest);

        public static TControl MinimumHeightRequest<TControl>(this TControl component, System.Double pMinimumHeightRequest)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.MinimumHeightRequest = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_MinimumHeightRequest,pMinimumHeightRequest);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_MinimumWidthRequest = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.MinimumWidthRequest);

        public static TControl MinimumWidthRequest<TControl>(this TControl component, System.Double pMinimumWidthRequest)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.MinimumWidthRequest = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_MinimumWidthRequest,pMinimumWidthRequest);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Opacity = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.Opacity);

        public static TControl Opacity<TControl>(this TControl component, System.Double pOpacity)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.Opacity = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Opacity,pOpacity);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Rotation = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.Rotation);

        public static TControl Rotation<TControl>(this TControl component, System.Double pRotation)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.Rotation = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Rotation,pRotation);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_RotationX = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.RotationX);

        public static TControl RotationX<TControl>(this TControl component, System.Double pRotationX)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.RotationX = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_RotationX,pRotationX);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_RotationY = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.RotationY);

        public static TControl RotationY<TControl>(this TControl component, System.Double pRotationY)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.RotationY = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_RotationY,pRotationY);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_Scale = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.Scale);

        public static TControl Scale<TControl>(this TControl component, System.Double pScale)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.Scale = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_Scale,pScale);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_ScaleX = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.ScaleX);

        public static TControl ScaleX<TControl>(this TControl component, System.Double pScaleX)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.ScaleX = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_ScaleX,pScaleX);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_ScaleY = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.ScaleY);

        public static TControl ScaleY<TControl>(this TControl component, System.Double pScaleY)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.ScaleY = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_ScaleY,pScaleY);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_TabIndex = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Int32>
        (v => v.TabIndex);

        public static TControl TabIndex<TControl>(this TControl component, System.Int32 pTabIndex)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.TabIndex = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_TabIndex,pTabIndex);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsTabStop = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Boolean>
        (v => v.IsTabStop);

        public static TControl IsTabStop<TControl>(this TControl component, System.Boolean pIsTabStop)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.IsTabStop = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsTabStop,pIsTabStop);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_TranslationX = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.TranslationX);

        public static TControl TranslationX<TControl>(this TControl component, System.Double pTranslationX)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.TranslationX = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_TranslationX,pTranslationX);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_TranslationY = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.TranslationY);

        public static TControl TranslationY<TControl>(this TControl component, System.Double pTranslationY)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.TranslationY = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_TranslationY,pTranslationY);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Double> Attribute_Double_WidthRequest = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Double>
        (v => v.WidthRequest);

        public static TControl WidthRequest<TControl>(this TControl component, System.Double pWidthRequest)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.WidthRequest = default;
            }

            component.Attributes.SetAttribute(Attribute_Double_WidthRequest,pWidthRequest);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_DisableLayout = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Boolean>
        (v => v.DisableLayout);

        public static TControl DisableLayout<TControl>(this TControl component, System.Boolean pDisableLayout)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.DisableLayout = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_DisableLayout,pDisableLayout);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsInNativeLayout = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Boolean>
        (v => v.IsInNativeLayout);

        public static TControl IsInNativeLayout<TControl>(this TControl component, System.Boolean pIsInNativeLayout)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.IsInNativeLayout = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsInNativeLayout,pIsInNativeLayout);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsNativeStateConsistent = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Boolean>
        (v => v.IsNativeStateConsistent);

        public static TControl IsNativeStateConsistent<TControl>(this TControl component, System.Boolean pIsNativeStateConsistent)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.IsNativeStateConsistent = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsNativeStateConsistent,pIsNativeStateConsistent);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsPlatformEnabled = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, System.Boolean>
        (v => v.IsPlatformEnabled);

        public static TControl IsPlatformEnabled<TControl>(this TControl component, System.Boolean pIsPlatformEnabled)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.IsPlatformEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsPlatformEnabled,pIsPlatformEnabled);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.ResourceDictionary> Attribute_ResourceDictionary_Resources = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.VisualElement, Xamarin.Forms.ResourceDictionary>
        (v => v.Resources);

        ///<remarks>
        /// Xamarin.Forms.ResourceDictionary doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Resources<TControl>(this TControl component, Xamarin.Forms.ResourceDictionary pResources)  where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.VisualElement t = default;
                t.Resources = default;
            }

            component.Attributes.SetAttribute(Attribute_ResourceDictionary_Resources,pResources);
            return component;
        }
    }

public static partial class Xamarin_Forms_VisualElement_Extensions
{
    public static TControl OnChildrenReordered<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.VisualElement tv = null;

            tv.ChildrenReordered += handler;
            tv.ChildrenReordered -= handler;
        }

        control.Event(x => nameof(x.ChildrenReordered),action);
        return control;
    }
}
public static partial class Xamarin_Forms_VisualElement_Extensions
{
    public static TControl OnFocused<TControl>(this TControl control,Action<Xamarin.Forms.FocusEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.VisualElement tv = null;

            tv.Focused += handler;
            tv.Focused -= handler;
        }

        control.Event(x => nameof(x.Focused),action);
        return control;
    }
}
public static partial class Xamarin_Forms_VisualElement_Extensions
{
    public static TControl OnMeasureInvalidated<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.VisualElement tv = null;

            tv.MeasureInvalidated += handler;
            tv.MeasureInvalidated -= handler;
        }

        control.Event(x => nameof(x.MeasureInvalidated),action);
        return control;
    }
}
public static partial class Xamarin_Forms_VisualElement_Extensions
{
    public static TControl OnSizeChanged<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.VisualElement tv = null;

            tv.SizeChanged += handler;
            tv.SizeChanged -= handler;
        }

        control.Event(x => nameof(x.SizeChanged),action);
        return control;
    }
}
public static partial class Xamarin_Forms_VisualElement_Extensions
{
    public static TControl OnUnfocused<TControl>(this TControl control,Action<Xamarin.Forms.FocusEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.VisualElement tv = null;

            tv.Unfocused += handler;
            tv.Unfocused -= handler;
        }

        control.Event(x => nameof(x.Unfocused),action);
        return control;
    }
}
public static partial class Xamarin_Forms_VisualElement_Extensions
{
    public static TControl OnBatchCommitted<TControl>(this TControl control,Action<Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement>> action) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.VisualElement tv = null;

            tv.BatchCommitted += handler;
            tv.BatchCommitted -= handler;
        }

        control.Event(x => nameof(x.BatchCommitted),action);
        return control;
    }
}
public static partial class Xamarin_Forms_VisualElement_Extensions
{
    public static TControl OnFocusChangeRequested<TControl>(this TControl control,Action<Xamarin.Forms.VisualElement.FocusRequestArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.VisualElement tv = null;

            tv.FocusChangeRequested += handler;
            tv.FocusChangeRequested -= handler;
        }

        control.Event(x => nameof(x.FocusChangeRequested),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static Expression<Action<Xamarin.Forms.VisualElement>> _callExpression_BatchBegin_Xamarin_Forms_VisualElement_ = (view) => view.BatchBegin();

        public static TControl BatchBegin<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            var callExpression = _callExpression_BatchBegin_Xamarin_Forms_VisualElement_;

            Reflect<Xamarin.Forms.VisualElement>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static Expression<Action<Xamarin.Forms.VisualElement>> _callExpression_BatchCommit_Xamarin_Forms_VisualElement_ = (view) => view.BatchCommit();

        public static TControl BatchCommit<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            var callExpression = _callExpression_BatchCommit_Xamarin_Forms_VisualElement_;

            Reflect<Xamarin.Forms.VisualElement>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static Expression<Action<Xamarin.Forms.VisualElement, Xamarin.Forms.Internals.InvalidationTrigger>> _callExpression_InvalidateMeasureNonVirtual_Xamarin_Forms_VisualElement__Xamarin_Forms_Internals_InvalidationTrigger = (view, param1) => view.InvalidateMeasureNonVirtual(param1);

        public static TControl InvalidateMeasureNonVirtual<TControl>(this TControl component, Xamarin.Forms.Internals.InvalidationTrigger ptrigger) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            var callExpression = _callExpression_InvalidateMeasureNonVirtual_Xamarin_Forms_VisualElement__Xamarin_Forms_Internals_InvalidationTrigger;

            Reflect<Xamarin.Forms.VisualElement>.ReflectionHelpers.Call(component.Attributes,callExpression, ptrigger);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static Expression<Action<Xamarin.Forms.VisualElement, Xamarin.Forms.Rectangle>> _callExpression_Layout_Xamarin_Forms_VisualElement__Xamarin_Forms_Rectangle = (view, param1) => view.Layout(param1);

        public static TControl Layout<TControl>(this TControl component, Xamarin.Forms.Rectangle pbounds) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            var callExpression = _callExpression_Layout_Xamarin_Forms_VisualElement__Xamarin_Forms_Rectangle;

            Reflect<Xamarin.Forms.VisualElement>.ReflectionHelpers.Call(component.Attributes,callExpression, pbounds);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static Expression<Action<Xamarin.Forms.VisualElement>> _callExpression_NativeSizeChanged_Xamarin_Forms_VisualElement_ = (view) => view.NativeSizeChanged();

        public static TControl NativeSizeChanged<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            var callExpression = _callExpression_NativeSizeChanged_Xamarin_Forms_VisualElement_;

            Reflect<Xamarin.Forms.VisualElement>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_VisualElement_Extensions
    {
        private static Expression<Action<Xamarin.Forms.VisualElement>> _callExpression_Unfocus_Xamarin_Forms_VisualElement_ = (view) => view.Unfocus();

        public static TControl Unfocus<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            var callExpression = _callExpression_Unfocus_Xamarin_Forms_VisualElement_;

            Reflect<Xamarin.Forms.VisualElement>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static XamFormsVisualElement<Xamarin.Forms.WebView> WebView()
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Xamarin.Forms.WebView();
            }

            var control = new XamFormsVisualElement<Xamarin.Forms.WebView>();
            return control;
        }    
    }

    public static partial class Xamarin_Forms_WebView_Extensions
    {
        private static readonly Attribute<Xamarin.Forms.WebViewSource> Attribute_WebViewSource_Source = AttributeReflectionHelper.ResolveFor<Xamarin.Forms.WebView, Xamarin.Forms.WebViewSource>
        (v => v.Source);

        ///<remarks>
        /// Xamarin.Forms.WebViewSource doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.
        ///</remarks>
        public static TControl Source<TControl>(this TControl component, Xamarin.Forms.WebViewSource pSource)  where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Xamarin.Forms.WebView t = default;
                t.Source = default;
            }

            component.Attributes.SetAttribute(Attribute_WebViewSource_Source,pSource);
            return component;
        }
    }

public static partial class Xamarin_Forms_WebView_Extensions
{
    public static TControl OnNavigated<TControl>(this TControl control,Action<Xamarin.Forms.WebNavigatedEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.WebView tv = null;

            tv.Navigated += handler;
            tv.Navigated -= handler;
        }

        control.Event(x => nameof(x.Navigated),action);
        return control;
    }
}
public static partial class Xamarin_Forms_WebView_Extensions
{
    public static TControl OnNavigating<TControl>(this TControl control,Action<Xamarin.Forms.WebNavigatingEventArgs> action) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.WebView tv = null;

            tv.Navigating += handler;
            tv.Navigating -= handler;
        }

        control.Event(x => nameof(x.Navigating),action);
        return control;
    }
}
public static partial class Xamarin_Forms_WebView_Extensions
{
    public static TControl OnEvalRequested<TControl>(this TControl control,Action<Xamarin.Forms.Internals.EvalRequested> action) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.WebView tv = null;

            tv.EvalRequested += handler;
            tv.EvalRequested -= handler;
        }

        control.Event(x => nameof(x.EvalRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_WebView_Extensions
{
    public static TControl OnGoBackRequested<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.WebView tv = null;

            tv.GoBackRequested += handler;
            tv.GoBackRequested -= handler;
        }

        control.Event(x => nameof(x.GoBackRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_WebView_Extensions
{
    public static TControl OnGoForwardRequested<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.WebView tv = null;

            tv.GoForwardRequested += handler;
            tv.GoForwardRequested -= handler;
        }

        control.Event(x => nameof(x.GoForwardRequested),action);
        return control;
    }
}
public static partial class Xamarin_Forms_WebView_Extensions
{
    public static TControl OnReloadRequested<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Xamarin.Forms.WebView tv = null;

            tv.ReloadRequested += handler;
            tv.ReloadRequested -= handler;
        }

        control.Event(x => nameof(x.ReloadRequested),action);
        return control;
    }
}

    public static partial class Xamarin_Forms_WebView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.WebView, System.String>> _callExpression_Eval_Xamarin_Forms_WebView__System_String = (view, param1) => view.Eval(param1);

        public static TControl Eval<TControl>(this TControl component, System.String pscript) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
        {
            var callExpression = _callExpression_Eval_Xamarin_Forms_WebView__System_String;

            Reflect<Xamarin.Forms.WebView>.ReflectionHelpers.Call(component.Attributes,callExpression, pscript);
            return component;
        }
    }
    public static partial class Xamarin_Forms_WebView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.WebView>> _callExpression_GoBack_Xamarin_Forms_WebView_ = (view) => view.GoBack();

        public static TControl GoBack<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
        {
            var callExpression = _callExpression_GoBack_Xamarin_Forms_WebView_;

            Reflect<Xamarin.Forms.WebView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_WebView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.WebView>> _callExpression_GoForward_Xamarin_Forms_WebView_ = (view) => view.GoForward();

        public static TControl GoForward<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
        {
            var callExpression = _callExpression_GoForward_Xamarin_Forms_WebView_;

            Reflect<Xamarin.Forms.WebView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_WebView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.WebView>> _callExpression_Reload_Xamarin_Forms_WebView_ = (view) => view.Reload();

        public static TControl Reload<TControl>(this TControl component) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
        {
            var callExpression = _callExpression_Reload_Xamarin_Forms_WebView_;

            Reflect<Xamarin.Forms.WebView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Xamarin_Forms_WebView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.WebView, Xamarin.Forms.WebNavigatedEventArgs>> _callExpression_SendNavigated_Xamarin_Forms_WebView__Xamarin_Forms_WebNavigatedEventArgs = (view, param1) => view.SendNavigated(param1);

        public static TControl SendNavigated<TControl>(this TControl component, Xamarin.Forms.WebNavigatedEventArgs pargs) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
        {
            var callExpression = _callExpression_SendNavigated_Xamarin_Forms_WebView__Xamarin_Forms_WebNavigatedEventArgs;

            Reflect<Xamarin.Forms.WebView>.ReflectionHelpers.Call(component.Attributes,callExpression, pargs);
            return component;
        }
    }
    public static partial class Xamarin_Forms_WebView_Extensions
    {
        private static Expression<Action<Xamarin.Forms.WebView, Xamarin.Forms.WebNavigatingEventArgs>> _callExpression_SendNavigating_Xamarin_Forms_WebView__Xamarin_Forms_WebNavigatingEventArgs = (view, param1) => view.SendNavigating(param1);

        public static TControl SendNavigating<TControl>(this TControl component, Xamarin.Forms.WebNavigatingEventArgs pargs) where TControl:IReflectedPrimitive<Xamarin.Forms.WebView>
        {
            var callExpression = _callExpression_SendNavigating_Xamarin_Forms_WebView__Xamarin_Forms_WebNavigatingEventArgs;

            Reflect<Xamarin.Forms.WebView>.ReflectionHelpers.Call(component.Attributes,callExpression, pargs);
            return component;
        }
    }
}