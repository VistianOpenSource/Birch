// Copyright 2020. See LICENSE.MD for license.
//
using System;
using System.Linq.Expressions;
using Android.Widget;
using Birch.Components;
using Birch.Reflection;
using Birch.Compose;
using System.Collections.Generic;
using System.Linq;

namespace Birch.Views
{
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.AutoCompleteTextView> AutoCompleteTextView(System.String pText, Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.AutoCompleteTextView(default);
            }

            var control = View<Android.Widget.AutoCompleteTextView>(dimensions:dimensions,id:id);
            control.Text(pText);
            return control;
        }    
    }

    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<Android.Widget.IListAdapter> Attribute_IListAdapter_Adapter = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, Android.Widget.IListAdapter>
        (v => v.Adapter);


        public static TControl Adapter<TControl>(this TControl component, Android.Widget.IListAdapter pAdapter)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.Adapter = default;
            }

            component.Attributes.SetAttribute(Attribute_IListAdapter_Adapter,pAdapter);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DropDownAnchor = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, System.Int32>
        (v => v.DropDownAnchor);


        public static TControl DropDownAnchor<TControl>(this TControl component, System.Int32 pDropDownAnchor)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.DropDownAnchor = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DropDownAnchor,pDropDownAnchor);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DropDownHeight = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, System.Int32>
        (v => v.DropDownHeight);


        public static TControl DropDownHeight<TControl>(this TControl component, System.Int32 pDropDownHeight)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.DropDownHeight = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DropDownHeight,pDropDownHeight);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DropDownHorizontalOffset = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, System.Int32>
        (v => v.DropDownHorizontalOffset);


        public static TControl DropDownHorizontalOffset<TControl>(this TControl component, System.Int32 pDropDownHorizontalOffset)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.DropDownHorizontalOffset = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DropDownHorizontalOffset,pDropDownHorizontalOffset);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DropDownVerticalOffset = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, System.Int32>
        (v => v.DropDownVerticalOffset);


        public static TControl DropDownVerticalOffset<TControl>(this TControl component, System.Int32 pDropDownVerticalOffset)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.DropDownVerticalOffset = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DropDownVerticalOffset,pDropDownVerticalOffset);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DropDownWidth = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, System.Int32>
        (v => v.DropDownWidth);


        public static TControl DropDownWidth<TControl>(this TControl component, System.Int32 pDropDownWidth)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.DropDownWidth = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DropDownWidth,pDropDownWidth);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ListSelection = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, System.Int32>
        (v => v.ListSelection);


        public static TControl ListSelection<TControl>(this TControl component, System.Int32 pListSelection)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.ListSelection = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ListSelection,pListSelection);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<Android.Widget.AdapterView.IOnItemClickListener> Attribute_IOnItemClickListener_OnItemClickListener = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, Android.Widget.AdapterView.IOnItemClickListener>
        (v => v.OnItemClickListener);


        public static TControl OnItemClickListener<TControl>(this TControl component, Android.Widget.AdapterView.IOnItemClickListener pOnItemClickListener)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.OnItemClickListener = default;
            }

            component.Attributes.SetAttribute(Attribute_IOnItemClickListener_OnItemClickListener,pOnItemClickListener);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<Android.Widget.AdapterView.IOnItemSelectedListener> Attribute_IOnItemSelectedListener_OnItemSelectedListener = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, Android.Widget.AdapterView.IOnItemSelectedListener>
        (v => v.OnItemSelectedListener);


        public static TControl OnItemSelectedListener<TControl>(this TControl component, Android.Widget.AdapterView.IOnItemSelectedListener pOnItemSelectedListener)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.OnItemSelectedListener = default;
            }

            component.Attributes.SetAttribute(Attribute_IOnItemSelectedListener_OnItemSelectedListener,pOnItemSelectedListener);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Threshold = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, System.Int32>
        (v => v.Threshold);


        public static TControl Threshold<TControl>(this TControl component, System.Int32 pThreshold)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.Threshold = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Threshold,pThreshold);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static readonly Attribute<Android.Widget.AutoCompleteTextView.IValidator> Attribute_IValidator_Validator = AttributeReflectionHelper.ResolveFor<Android.Widget.AutoCompleteTextView, Android.Widget.AutoCompleteTextView.IValidator>
        (v => v.Validator);


        public static TControl Validator<TControl>(this TControl component, Android.Widget.AutoCompleteTextView.IValidator pValidator)  where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AutoCompleteTextView t = default;
                t.Validator = default;
            }

            component.Attributes.SetAttribute(Attribute_IValidator_Validator,pValidator);
            return component;
        }
    }

public static partial class Android_Widget_AutoCompleteTextView_Extensions
{
    public static TControl OnItemSelectionCleared<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.AutoCompleteTextView tv = null;

            tv.ItemSelectionCleared += handler;
            tv.ItemSelectionCleared -= handler;
        }

        control.Event(x => nameof(x.ItemSelectionCleared),action);
        return control;
    }
}
public static partial class Android_Widget_AutoCompleteTextView_Extensions
{
    public static TControl OnDismiss<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.AutoCompleteTextView tv = null;

            tv.Dismiss += handler;
            tv.Dismiss -= handler;
        }

        control.Event(x => nameof(x.Dismiss),action);
        return control;
    }
}
public static partial class Android_Widget_AutoCompleteTextView_Extensions
{
    public static TControl OnItemClick<TControl>(this TControl control,Action<Android.Widget.AdapterView.ItemClickEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.AutoCompleteTextView tv = null;

            tv.ItemClick += handler;
            tv.ItemClick -= handler;
        }

        control.Event(x => nameof(x.ItemClick),action);
        return control;
    }
}
public static partial class Android_Widget_AutoCompleteTextView_Extensions
{
    public static TControl OnItemSelected<TControl>(this TControl control,Action<Android.Widget.AdapterView.ItemSelectedEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.AutoCompleteTextView tv = null;

            tv.ItemSelected += handler;
            tv.ItemSelected -= handler;
        }

        control.Event(x => nameof(x.ItemSelected),action);
        return control;
    }
}
public static partial class Android_Widget_AutoCompleteTextView_Extensions
{
    public static TControl OnNothingSelected<TControl>(this TControl control,Action<Android.Widget.AdapterView.NothingSelectedEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.AutoCompleteTextView tv = null;

            tv.NothingSelected += handler;
            tv.NothingSelected -= handler;
        }

        control.Event(x => nameof(x.NothingSelected),action);
        return control;
    }
}

    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView>> _callExpression_ClearListSelection_Android_Widget_AutoCompleteTextView_ = (view) => view.ClearListSelection();
        public static TControl ClearListSelection<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_ClearListSelection_Android_Widget_AutoCompleteTextView_;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView>> _callExpression_DismissDropDown_Android_Widget_AutoCompleteTextView_ = (view) => view.DismissDropDown();
        public static TControl DismissDropDown<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_DismissDropDown_Android_Widget_AutoCompleteTextView_;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView>> _callExpression_PerformCompletion_Android_Widget_AutoCompleteTextView_ = (view) => view.PerformCompletion();
        public static TControl PerformCompletion<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_PerformCompletion_Android_Widget_AutoCompleteTextView_;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView>> _callExpression_PerformValidation_Android_Widget_AutoCompleteTextView_ = (view) => view.PerformValidation();
        public static TControl PerformValidation<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_PerformValidation_Android_Widget_AutoCompleteTextView_;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView, Java.Lang.ICharSequence>> _callExpression_SetCompletionHint_Android_Widget_AutoCompleteTextView__Java_Lang_ICharSequence = (view, param1) => view.SetCompletionHint(param1);
        public static TControl SetCompletionHint<TControl>(this TControl component, Java.Lang.ICharSequence phint) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_SetCompletionHint_Android_Widget_AutoCompleteTextView__Java_Lang_ICharSequence;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, phint);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView, System.String>> _callExpression_SetCompletionHint_Android_Widget_AutoCompleteTextView__System_String = (view, param1) => view.SetCompletionHint(param1);
        public static TControl SetCompletionHint<TControl>(this TControl component, System.String phint) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_SetCompletionHint_Android_Widget_AutoCompleteTextView__System_String;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, phint);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView, Android.Graphics.Drawables.Drawable>> _callExpression_SetDropDownBackgroundDrawable_Android_Widget_AutoCompleteTextView__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetDropDownBackgroundDrawable(param1);
        public static TControl SetDropDownBackgroundDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pd) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_SetDropDownBackgroundDrawable_Android_Widget_AutoCompleteTextView__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pd);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView, System.Int32>> _callExpression_SetDropDownBackgroundResource_Android_Widget_AutoCompleteTextView__System_Int32 = (view, param1) => view.SetDropDownBackgroundResource(param1);
        public static TControl SetDropDownBackgroundResource<TControl>(this TControl component, System.Int32 pid) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_SetDropDownBackgroundResource_Android_Widget_AutoCompleteTextView__System_Int32;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pid);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView, Android.Widget.AutoCompleteTextView.IOnDismissListener>> _callExpression_SetOnDismissListener_Android_Widget_AutoCompleteTextView__Android_Widget_AutoCompleteTextView_IOnDismissListener = (view, param1) => view.SetOnDismissListener(param1);
        public static TControl SetOnDismissListener<TControl>(this TControl component, Android.Widget.AutoCompleteTextView.IOnDismissListener pdismissListener) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_SetOnDismissListener_Android_Widget_AutoCompleteTextView__Android_Widget_AutoCompleteTextView_IOnDismissListener;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pdismissListener);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView, Java.Lang.ICharSequence, System.Boolean>> _callExpression_SetText_Android_Widget_AutoCompleteTextView__Java_Lang_ICharSequence_System_Boolean = (view, param1, param2) => view.SetText(param1, param2);
        public static TControl SetText<TControl>(this TControl component, Java.Lang.ICharSequence ptext, System.Boolean pfilter) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_SetText_Android_Widget_AutoCompleteTextView__Java_Lang_ICharSequence_System_Boolean;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext, pfilter);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView, System.String, System.Boolean>> _callExpression_SetText_Android_Widget_AutoCompleteTextView__System_String_System_Boolean = (view, param1, param2) => view.SetText(param1, param2);
        public static TControl SetText<TControl>(this TControl component, System.String ptext, System.Boolean pfilter) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_SetText_Android_Widget_AutoCompleteTextView__System_String_System_Boolean;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext, pfilter);
            return component;
        }
    }
    public static partial class Android_Widget_AutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.AutoCompleteTextView>> _callExpression_ShowDropDown_Android_Widget_AutoCompleteTextView_ = (view) => view.ShowDropDown();
        public static TControl ShowDropDown<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.AutoCompleteTextView>
        {
            var callExpression = _callExpression_ShowDropDown_Android_Widget_AutoCompleteTextView_;

            Reflect<Android.Widget.AutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.DatePicker> DatePicker(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.DatePicker(default);
            }

            var control = View<Android.Widget.DatePicker>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_DatePicker_Extensions
    {
        private static readonly Attribute<System.DateTime> Attribute_DateTime_DateTime = AttributeReflectionHelper.ResolveFor<Android.Widget.DatePicker, System.DateTime>
        (v => v.DateTime);


        public static TControl DateTime<TControl>(this TControl component, System.DateTime pDateTime)  where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.DatePicker t = default;
                t.DateTime = default;
            }

            component.Attributes.SetAttribute(Attribute_DateTime_DateTime,pDateTime);
            return component;
        }
    }
    public static partial class Android_Widget_DatePicker_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_CalendarViewShown = AttributeReflectionHelper.ResolveFor<Android.Widget.DatePicker, System.Boolean>
        (v => v.CalendarViewShown);


        public static TControl CalendarViewShown<TControl>(this TControl component, System.Boolean pCalendarViewShown)  where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.DatePicker t = default;
                t.CalendarViewShown = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_CalendarViewShown,pCalendarViewShown);
            return component;
        }
    }
    public static partial class Android_Widget_DatePicker_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_FirstDayOfWeek = AttributeReflectionHelper.ResolveFor<Android.Widget.DatePicker, System.Int32>
        (v => v.FirstDayOfWeek);


        public static TControl FirstDayOfWeek<TControl>(this TControl component, System.Int32 pFirstDayOfWeek)  where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.DatePicker t = default;
                t.FirstDayOfWeek = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_FirstDayOfWeek,pFirstDayOfWeek);
            return component;
        }
    }
    public static partial class Android_Widget_DatePicker_Extensions
    {
        private static readonly Attribute<System.Int64> Attribute_Int64_MaxDate = AttributeReflectionHelper.ResolveFor<Android.Widget.DatePicker, System.Int64>
        (v => v.MaxDate);


        public static TControl MaxDate<TControl>(this TControl component, System.Int64 pMaxDate)  where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.DatePicker t = default;
                t.MaxDate = default;
            }

            component.Attributes.SetAttribute(Attribute_Int64_MaxDate,pMaxDate);
            return component;
        }
    }
    public static partial class Android_Widget_DatePicker_Extensions
    {
        private static readonly Attribute<System.Int64> Attribute_Int64_MinDate = AttributeReflectionHelper.ResolveFor<Android.Widget.DatePicker, System.Int64>
        (v => v.MinDate);


        public static TControl MinDate<TControl>(this TControl component, System.Int64 pMinDate)  where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.DatePicker t = default;
                t.MinDate = default;
            }

            component.Attributes.SetAttribute(Attribute_Int64_MinDate,pMinDate);
            return component;
        }
    }
    public static partial class Android_Widget_DatePicker_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_SpinnersShown = AttributeReflectionHelper.ResolveFor<Android.Widget.DatePicker, System.Boolean>
        (v => v.SpinnersShown);


        public static TControl SpinnersShown<TControl>(this TControl component, System.Boolean pSpinnersShown)  where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.DatePicker t = default;
                t.SpinnersShown = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_SpinnersShown,pSpinnersShown);
            return component;
        }
    }

public static partial class Android_Widget_DatePicker_Extensions
{
    public static TControl OnDateChanged<TControl>(this TControl control,Action<Android.Widget.DatePicker.DateChangedEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.DatePicker tv = null;

            tv.DateChanged += handler;
            tv.DateChanged -= handler;
        }

        control.Event(x => nameof(x.DateChanged),action);
        return control;
    }
}

    public static partial class Android_Widget_DatePicker_Extensions
    {
        private static Expression<Action<Android.Widget.DatePicker, System.Int32, System.Int32, System.Int32, Android.Widget.DatePicker.IOnDateChangedListener>> _callExpression_Init_Android_Widget_DatePicker__System_Int32_System_Int32_System_Int32_Android_Widget_DatePicker_IOnDateChangedListener = (view, param1, param2, param3, param4) => view.Init(param1, param2, param3, param4);
        public static TControl Init<TControl>(this TControl component, System.Int32 pyear, System.Int32 pmonthOfYear, System.Int32 pdayOfMonth, Android.Widget.DatePicker.IOnDateChangedListener ponDateChangedListener) where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
        {
            var callExpression = _callExpression_Init_Android_Widget_DatePicker__System_Int32_System_Int32_System_Int32_Android_Widget_DatePicker_IOnDateChangedListener;

            Reflect<Android.Widget.DatePicker>.ReflectionHelpers.Call(component.Attributes,callExpression, pyear, pmonthOfYear, pdayOfMonth, ponDateChangedListener);
            return component;
        }
    }
    public static partial class Android_Widget_DatePicker_Extensions
    {
        private static Expression<Action<Android.Widget.DatePicker, Android.Widget.DatePicker.IOnDateChangedListener>> _callExpression_SetOnDateChangedListener_Android_Widget_DatePicker__Android_Widget_DatePicker_IOnDateChangedListener = (view, param1) => view.SetOnDateChangedListener(param1);
        public static TControl SetOnDateChangedListener<TControl>(this TControl component, Android.Widget.DatePicker.IOnDateChangedListener ponDateChangedListener) where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
        {
            var callExpression = _callExpression_SetOnDateChangedListener_Android_Widget_DatePicker__Android_Widget_DatePicker_IOnDateChangedListener;

            Reflect<Android.Widget.DatePicker>.ReflectionHelpers.Call(component.Attributes,callExpression, ponDateChangedListener);
            return component;
        }
    }
    public static partial class Android_Widget_DatePicker_Extensions
    {
        private static Expression<Action<Android.Widget.DatePicker, System.Int32, System.Int32, System.Int32>> _callExpression_UpdateDate_Android_Widget_DatePicker__System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3) => view.UpdateDate(param1, param2, param3);
        public static TControl UpdateDate<TControl>(this TControl component, System.Int32 pyear, System.Int32 pmonth, System.Int32 pdayOfMonth) where TControl:IReflectedPrimitive<Android.Widget.DatePicker>
        {
            var callExpression = _callExpression_UpdateDate_Android_Widget_DatePicker__System_Int32_System_Int32_System_Int32;

            Reflect<Android.Widget.DatePicker>.ReflectionHelpers.Call(component.Attributes,callExpression, pyear, pmonth, pdayOfMonth);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.TextView> TextView(System.String pText, Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.TextView(default);
            }

            var control = View<Android.Widget.TextView>(dimensions:dimensions,id:id);
            control.Text(pText);
            return control;
        }    
    }

    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Text.Util.MatchOptions> Attribute_MatchOptions_AutoLinkMask = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Text.Util.MatchOptions>
        (v => v.AutoLinkMask);


        public static TControl AutoLinkMask<TControl>(this TControl component, Android.Text.Util.MatchOptions pAutoLinkMask)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.AutoLinkMask = default;
            }

            component.Attributes.SetAttribute(Attribute_MatchOptions_AutoLinkMask,pAutoLinkMask);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Text.BreakStrategy> Attribute_BreakStrategy_BreakStrategy = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Text.BreakStrategy>
        (v => v.BreakStrategy);


        public static TControl BreakStrategy<TControl>(this TControl component, Android.Text.BreakStrategy pBreakStrategy)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.BreakStrategy = default;
            }

            component.Attributes.SetAttribute(Attribute_BreakStrategy_BreakStrategy,pBreakStrategy);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_CompoundDrawablePadding = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Int32>
        (v => v.CompoundDrawablePadding);


        public static TControl CompoundDrawablePadding<TControl>(this TControl component, System.Int32 pCompoundDrawablePadding)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.CompoundDrawablePadding = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_CompoundDrawablePadding,pCompoundDrawablePadding);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_CompoundDrawableTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Content.Res.ColorStateList>
        (v => v.CompoundDrawableTintList);


        public static TControl CompoundDrawableTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pCompoundDrawableTintList)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.CompoundDrawableTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_CompoundDrawableTintList,pCompoundDrawableTintList);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_CompoundDrawableTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Graphics.PorterDuff.Mode>
        (v => v.CompoundDrawableTintMode);


        public static TControl CompoundDrawableTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pCompoundDrawableTintMode)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.CompoundDrawableTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_CompoundDrawableTintMode,pCompoundDrawableTintMode);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Views.ActionMode.ICallback> Attribute_ICallback_CustomInsertionActionModeCallback = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Views.ActionMode.ICallback>
        (v => v.CustomInsertionActionModeCallback);


        public static TControl CustomInsertionActionModeCallback<TControl>(this TControl component, Android.Views.ActionMode.ICallback pCustomInsertionActionModeCallback)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.CustomInsertionActionModeCallback = default;
            }

            component.Attributes.SetAttribute(Attribute_ICallback_CustomInsertionActionModeCallback,pCustomInsertionActionModeCallback);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Views.ActionMode.ICallback> Attribute_ICallback_CustomSelectionActionModeCallback = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Views.ActionMode.ICallback>
        (v => v.CustomSelectionActionModeCallback);


        public static TControl CustomSelectionActionModeCallback<TControl>(this TControl component, Android.Views.ActionMode.ICallback pCustomSelectionActionModeCallback)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.CustomSelectionActionModeCallback = default;
            }

            component.Attributes.SetAttribute(Attribute_ICallback_CustomSelectionActionModeCallback,pCustomSelectionActionModeCallback);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Text.TextUtils.TruncateAt> Attribute_TruncateAt_Ellipsize = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Text.TextUtils.TruncateAt>
        (v => v.Ellipsize);


        public static TControl Ellipsize<TControl>(this TControl component, Android.Text.TextUtils.TruncateAt pEllipsize)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.Ellipsize = default;
            }

            component.Attributes.SetAttribute(Attribute_TruncateAt_Ellipsize,pEllipsize);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_ErrorFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Java.Lang.ICharSequence>
        (v => v.ErrorFormatted);


        public static TControl ErrorFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pErrorFormatted)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.ErrorFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_ErrorFormatted,pErrorFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Error = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.String>
        (v => v.Error);


        public static TControl Error<TControl>(this TControl component, System.String pError)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.Error = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Error,pError);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_FallbackLineSpacing = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Boolean>
        (v => v.FallbackLineSpacing);


        public static TControl FallbackLineSpacing<TControl>(this TControl component, System.Boolean pFallbackLineSpacing)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.FallbackLineSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_FallbackLineSpacing,pFallbackLineSpacing);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_FirstBaselineToTopHeight = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Int32>
        (v => v.FirstBaselineToTopHeight);


        public static TControl FirstBaselineToTopHeight<TControl>(this TControl component, System.Int32 pFirstBaselineToTopHeight)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.FirstBaselineToTopHeight = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_FirstBaselineToTopHeight,pFirstBaselineToTopHeight);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_FontFeatureSettings = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.String>
        (v => v.FontFeatureSettings);


        public static TControl FontFeatureSettings<TControl>(this TControl component, System.String pFontFeatureSettings)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.FontFeatureSettings = default;
            }

            component.Attributes.SetAttribute(Attribute_String_FontFeatureSettings,pFontFeatureSettings);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_FreezesText = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Boolean>
        (v => v.FreezesText);


        public static TControl FreezesText<TControl>(this TControl component, System.Boolean pFreezesText)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.FreezesText = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_FreezesText,pFreezesText);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Views.GravityFlags> Attribute_GravityFlags_Gravity = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Views.GravityFlags>
        (v => v.Gravity);


        public static TControl Gravity<TControl>(this TControl component, Android.Views.GravityFlags pGravity)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.Gravity = default;
            }

            component.Attributes.SetAttribute(Attribute_GravityFlags_Gravity,pGravity);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_HintFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Java.Lang.ICharSequence>
        (v => v.HintFormatted);


        public static TControl HintFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pHintFormatted)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.HintFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_HintFormatted,pHintFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Hint = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.String>
        (v => v.Hint);


        public static TControl Hint<TControl>(this TControl component, System.String pHint)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.Hint = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Hint,pHint);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Text.HyphenationFrequency> Attribute_HyphenationFrequency_HyphenationFrequency = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Text.HyphenationFrequency>
        (v => v.HyphenationFrequency);


        public static TControl HyphenationFrequency<TControl>(this TControl component, Android.Text.HyphenationFrequency pHyphenationFrequency)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.HyphenationFrequency = default;
            }

            component.Attributes.SetAttribute(Attribute_HyphenationFrequency_HyphenationFrequency,pHyphenationFrequency);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.OS.LocaleList> Attribute_LocaleList_ImeHintLocales = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.OS.LocaleList>
        (v => v.ImeHintLocales);


        public static TControl ImeHintLocales<TControl>(this TControl component, Android.OS.LocaleList pImeHintLocales)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.ImeHintLocales = default;
            }

            component.Attributes.SetAttribute(Attribute_LocaleList_ImeHintLocales,pImeHintLocales);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Views.InputMethods.ImeAction> Attribute_ImeAction_ImeOptions = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Views.InputMethods.ImeAction>
        (v => v.ImeOptions);


        public static TControl ImeOptions<TControl>(this TControl component, Android.Views.InputMethods.ImeAction pImeOptions)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.ImeOptions = default;
            }

            component.Attributes.SetAttribute(Attribute_ImeAction_ImeOptions,pImeOptions);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Text.InputTypes> Attribute_InputTypes_InputType = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Text.InputTypes>
        (v => v.InputType);


        public static TControl InputType<TControl>(this TControl component, Android.Text.InputTypes pInputType)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.InputType = default;
            }

            component.Attributes.SetAttribute(Attribute_InputTypes_InputType,pInputType);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Text.JustificationMode> Attribute_JustificationMode_JustificationMode = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Text.JustificationMode>
        (v => v.JustificationMode);


        public static TControl JustificationMode<TControl>(this TControl component, Android.Text.JustificationMode pJustificationMode)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.JustificationMode = default;
            }

            component.Attributes.SetAttribute(Attribute_JustificationMode_JustificationMode,pJustificationMode);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Text.Method.IKeyListener> Attribute_IKeyListener_KeyListener = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Text.Method.IKeyListener>
        (v => v.KeyListener);


        public static TControl KeyListener<TControl>(this TControl component, Android.Text.Method.IKeyListener pKeyListener)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.KeyListener = default;
            }

            component.Attributes.SetAttribute(Attribute_IKeyListener_KeyListener,pKeyListener);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_LastBaselineToBottomHeight = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Int32>
        (v => v.LastBaselineToBottomHeight);


        public static TControl LastBaselineToBottomHeight<TControl>(this TControl component, System.Int32 pLastBaselineToBottomHeight)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.LastBaselineToBottomHeight = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_LastBaselineToBottomHeight,pLastBaselineToBottomHeight);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_LetterSpacing = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Single>
        (v => v.LetterSpacing);


        public static TControl LetterSpacing<TControl>(this TControl component, System.Single pLetterSpacing)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.LetterSpacing = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_LetterSpacing,pLetterSpacing);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_LineHeight = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Int32>
        (v => v.LineHeight);


        public static TControl LineHeight<TControl>(this TControl component, System.Int32 pLineHeight)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.LineHeight = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_LineHeight,pLineHeight);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_LinksClickable = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Boolean>
        (v => v.LinksClickable);


        public static TControl LinksClickable<TControl>(this TControl component, System.Boolean pLinksClickable)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.LinksClickable = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_LinksClickable,pLinksClickable);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Text.Method.IMovementMethod> Attribute_IMovementMethod_MovementMethod = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Text.Method.IMovementMethod>
        (v => v.MovementMethod);


        public static TControl MovementMethod<TControl>(this TControl component, Android.Text.Method.IMovementMethod pMovementMethod)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.MovementMethod = default;
            }

            component.Attributes.SetAttribute(Attribute_IMovementMethod_MovementMethod,pMovementMethod);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Graphics.PaintFlags> Attribute_PaintFlags_PaintFlags = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Graphics.PaintFlags>
        (v => v.PaintFlags);


        public static TControl PaintFlags<TControl>(this TControl component, Android.Graphics.PaintFlags pPaintFlags)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.PaintFlags = default;
            }

            component.Attributes.SetAttribute(Attribute_PaintFlags_PaintFlags,pPaintFlags);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_PrivateImeOptions = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.String>
        (v => v.PrivateImeOptions);


        public static TControl PrivateImeOptions<TControl>(this TControl component, System.String pPrivateImeOptions)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.PrivateImeOptions = default;
            }

            component.Attributes.SetAttribute(Attribute_String_PrivateImeOptions,pPrivateImeOptions);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ShowSoftInputOnFocus = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Boolean>
        (v => v.ShowSoftInputOnFocus);


        public static TControl ShowSoftInputOnFocus<TControl>(this TControl component, System.Boolean pShowSoftInputOnFocus)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.ShowSoftInputOnFocus = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_ShowSoftInputOnFocus,pShowSoftInputOnFocus);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_TextFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Java.Lang.ICharSequence>
        (v => v.TextFormatted);


        public static TControl TextFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pTextFormatted)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.TextFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_TextFormatted,pTextFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Text = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.String>
        (v => v.Text);


        public static TControl Text<TControl>(this TControl component, System.String pText)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.Text = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Text,pText);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Views.TextClassifiers.ITextClassifier> Attribute_ITextClassifier_TextClassifier = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Views.TextClassifiers.ITextClassifier>
        (v => v.TextClassifier);


        public static TControl TextClassifier<TControl>(this TControl component, Android.Views.TextClassifiers.ITextClassifier pTextClassifier)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.TextClassifier = default;
            }

            component.Attributes.SetAttribute(Attribute_ITextClassifier_TextClassifier,pTextClassifier);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Java.Util.Locale> Attribute_Locale_TextLocale = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Java.Util.Locale>
        (v => v.TextLocale);


        public static TControl TextLocale<TControl>(this TControl component, Java.Util.Locale pTextLocale)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.TextLocale = default;
            }

            component.Attributes.SetAttribute(Attribute_Locale_TextLocale,pTextLocale);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.OS.LocaleList> Attribute_LocaleList_TextLocales = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.OS.LocaleList>
        (v => v.TextLocales);


        public static TControl TextLocales<TControl>(this TControl component, Android.OS.LocaleList pTextLocales)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.TextLocales = default;
            }

            component.Attributes.SetAttribute(Attribute_LocaleList_TextLocales,pTextLocales);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_TextScaleX = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Single>
        (v => v.TextScaleX);


        public static TControl TextScaleX<TControl>(this TControl component, System.Single pTextScaleX)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.TextScaleX = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_TextScaleX,pTextScaleX);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_TextSize = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, System.Single>
        (v => v.TextSize);


        public static TControl TextSize<TControl>(this TControl component, System.Single pTextSize)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.TextSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_TextSize,pTextSize);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Text.Method.ITransformationMethod> Attribute_ITransformationMethod_TransformationMethod = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Text.Method.ITransformationMethod>
        (v => v.TransformationMethod);


        public static TControl TransformationMethod<TControl>(this TControl component, Android.Text.Method.ITransformationMethod pTransformationMethod)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.TransformationMethod = default;
            }

            component.Attributes.SetAttribute(Attribute_ITransformationMethod_TransformationMethod,pTransformationMethod);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static readonly Attribute<Android.Graphics.Typeface> Attribute_Typeface_Typeface = AttributeReflectionHelper.ResolveFor<Android.Widget.TextView, Android.Graphics.Typeface>
        (v => v.Typeface);


        public static TControl Typeface<TControl>(this TControl component, Android.Graphics.Typeface pTypeface)  where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextView t = default;
                t.Typeface = default;
            }

            component.Attributes.SetAttribute(Attribute_Typeface_Typeface,pTypeface);
            return component;
        }
    }

public static partial class Android_Widget_TextView_Extensions
{
    public static TControl OnAfterTextChanged<TControl>(this TControl control,Action<Android.Text.AfterTextChangedEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.TextView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.TextView tv = null;

            tv.AfterTextChanged += handler;
            tv.AfterTextChanged -= handler;
        }

        control.Event(x => nameof(x.AfterTextChanged),action);
        return control;
    }
}
public static partial class Android_Widget_TextView_Extensions
{
    public static TControl OnBeforeTextChanged<TControl>(this TControl control,Action<Android.Text.TextChangedEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.TextView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.TextView tv = null;

            tv.BeforeTextChanged += handler;
            tv.BeforeTextChanged -= handler;
        }

        control.Event(x => nameof(x.BeforeTextChanged),action);
        return control;
    }
}
public static partial class Android_Widget_TextView_Extensions
{
    public static TControl OnTextChanged<TControl>(this TControl control,Action<Android.Text.TextChangedEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.TextView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.TextView tv = null;

            tv.TextChanged += handler;
            tv.TextChanged -= handler;
        }

        control.Event(x => nameof(x.TextChanged),action);
        return control;
    }
}
public static partial class Android_Widget_TextView_Extensions
{
    public static TControl OnEditorAction<TControl>(this TControl control,Action<Android.Widget.TextView.EditorActionEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.TextView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.TextView tv = null;

            tv.EditorAction += handler;
            tv.EditorAction -= handler;
        }

        control.Event(x => nameof(x.EditorAction),action);
        return control;
    }
}

    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Text.ITextWatcher>> _callExpression_AddTextChangedListener_Android_Widget_TextView__Android_Text_ITextWatcher = (view, param1) => view.AddTextChangedListener(param1);
        public static TControl AddTextChangedListener<TControl>(this TControl component, Android.Text.ITextWatcher pwatcher) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_AddTextChangedListener_Android_Widget_TextView__Android_Text_ITextWatcher;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pwatcher);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Java.Lang.ICharSequence>> _callExpression_Append_Android_Widget_TextView__Java_Lang_ICharSequence = (view, param1) => view.Append(param1);
        public static TControl Append<TControl>(this TControl component, Java.Lang.ICharSequence ptext) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_Append_Android_Widget_TextView__Java_Lang_ICharSequence;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.String>> _callExpression_Append_Android_Widget_TextView__System_String = (view, param1) => view.Append(param1);
        public static TControl Append<TControl>(this TControl component, System.String ptext) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_Append_Android_Widget_TextView__System_String;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Java.Lang.ICharSequence, System.Int32, System.Int32>> _callExpression_Append_Android_Widget_TextView__Java_Lang_ICharSequence_System_Int32_System_Int32 = (view, param1, param2, param3) => view.Append(param1, param2, param3);
        public static TControl Append<TControl>(this TControl component, Java.Lang.ICharSequence ptext, System.Int32 pstart, System.Int32 pend) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_Append_Android_Widget_TextView__Java_Lang_ICharSequence_System_Int32_System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext, pstart, pend);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.String, System.Int32, System.Int32>> _callExpression_Append_Android_Widget_TextView__System_String_System_Int32_System_Int32 = (view, param1, param2, param3) => view.Append(param1, param2, param3);
        public static TControl Append<TControl>(this TControl component, System.String ptext, System.Int32 pstart, System.Int32 pend) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_Append_Android_Widget_TextView__System_String_System_Int32_System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext, pstart, pend);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView>> _callExpression_BeginBatchEdit_Android_Widget_TextView_ = (view) => view.BeginBatchEdit();
        public static TControl BeginBatchEdit<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_BeginBatchEdit_Android_Widget_TextView_;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView>> _callExpression_ClearComposingText_Android_Widget_TextView_ = (view) => view.ClearComposingText();
        public static TControl ClearComposingText<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_ClearComposingText_Android_Widget_TextView_;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_Debug_Android_Widget_TextView__System_Int32 = (view, param1) => view.Debug(param1);
        public static TControl Debug<TControl>(this TControl component, System.Int32 pdepth) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_Debug_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pdepth);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView>> _callExpression_EndBatchEdit_Android_Widget_TextView_ = (view) => view.EndBatchEdit();
        public static TControl EndBatchEdit<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_EndBatchEdit_Android_Widget_TextView_;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Text.ITextWatcher>> _callExpression_RemoveTextChangedListener_Android_Widget_TextView__Android_Text_ITextWatcher = (view, param1) => view.RemoveTextChangedListener(param1);
        public static TControl RemoveTextChangedListener<TControl>(this TControl component, Android.Text.ITextWatcher pwatcher) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_RemoveTextChangedListener_Android_Widget_TextView__Android_Text_ITextWatcher;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pwatcher);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Boolean>> _callExpression_SetAllCaps_Android_Widget_TextView__System_Boolean = (view, param1) => view.SetAllCaps(param1);
        public static TControl SetAllCaps<TControl>(this TControl component, System.Boolean pallCaps) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetAllCaps_Android_Widget_TextView__System_Boolean;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pallCaps);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_SetAutoSizeTextTypeUniformWithConfiguration_Android_Widget_TextView__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.SetAutoSizeTextTypeUniformWithConfiguration(param1, param2, param3, param4);
        public static TControl SetAutoSizeTextTypeUniformWithConfiguration<TControl>(this TControl component, System.Int32 pautoSizeMinTextSize, System.Int32 pautoSizeMaxTextSize, System.Int32 pautoSizeStepGranularity, System.Int32 punit) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetAutoSizeTextTypeUniformWithConfiguration_Android_Widget_TextView__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pautoSizeMinTextSize, pautoSizeMaxTextSize, pautoSizeStepGranularity, punit);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32[], System.Int32>> _callExpression_SetAutoSizeTextTypeUniformWithPresetSizes_Android_Widget_TextView__System_Int32__System_Int32 = (view, param1, param2) => view.SetAutoSizeTextTypeUniformWithPresetSizes(param1, param2);
        public static TControl SetAutoSizeTextTypeUniformWithPresetSizes<TControl>(this TControl component, System.Int32[] ppresetSizes, System.Int32 punit) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetAutoSizeTextTypeUniformWithPresetSizes_Android_Widget_TextView__System_Int32__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ppresetSizes, punit);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Widget.AutoSizeTextType>> _callExpression_SetAutoSizeTextTypeWithDefaults_Android_Widget_TextView__Android_Widget_AutoSizeTextType = (view, param1) => view.SetAutoSizeTextTypeWithDefaults(param1);
        public static TControl SetAutoSizeTextTypeWithDefaults<TControl>(this TControl component, Android.Widget.AutoSizeTextType pautoSizeTextType) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetAutoSizeTextTypeWithDefaults_Android_Widget_TextView__Android_Widget_AutoSizeTextType;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pautoSizeTextType);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable>> _callExpression_SetCompoundDrawables_Android_Widget_TextView__Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable = (view, param1, param2, param3, param4) => view.SetCompoundDrawables(param1, param2, param3, param4);
        public static TControl SetCompoundDrawables<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pleft, Android.Graphics.Drawables.Drawable ptop, Android.Graphics.Drawables.Drawable pright, Android.Graphics.Drawables.Drawable pbottom) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetCompoundDrawables_Android_Widget_TextView__Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pleft, ptop, pright, pbottom);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable>> _callExpression_SetCompoundDrawablesRelative_Android_Widget_TextView__Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable = (view, param1, param2, param3, param4) => view.SetCompoundDrawablesRelative(param1, param2, param3, param4);
        public static TControl SetCompoundDrawablesRelative<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pstart, Android.Graphics.Drawables.Drawable ptop, Android.Graphics.Drawables.Drawable pend, Android.Graphics.Drawables.Drawable pbottom) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetCompoundDrawablesRelative_Android_Widget_TextView__Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pstart, ptop, pend, pbottom);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable>> _callExpression_SetCompoundDrawablesRelativeWithIntrinsicBounds_Android_Widget_TextView__Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable = (view, param1, param2, param3, param4) => view.SetCompoundDrawablesRelativeWithIntrinsicBounds(param1, param2, param3, param4);
        public static TControl SetCompoundDrawablesRelativeWithIntrinsicBounds<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pstart, Android.Graphics.Drawables.Drawable ptop, Android.Graphics.Drawables.Drawable pend, Android.Graphics.Drawables.Drawable pbottom) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetCompoundDrawablesRelativeWithIntrinsicBounds_Android_Widget_TextView__Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pstart, ptop, pend, pbottom);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_SetCompoundDrawablesRelativeWithIntrinsicBounds_Android_Widget_TextView__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.SetCompoundDrawablesRelativeWithIntrinsicBounds(param1, param2, param3, param4);
        public static TControl SetCompoundDrawablesRelativeWithIntrinsicBounds<TControl>(this TControl component, System.Int32 pstart, System.Int32 ptop, System.Int32 pend, System.Int32 pbottom) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetCompoundDrawablesRelativeWithIntrinsicBounds_Android_Widget_TextView__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pstart, ptop, pend, pbottom);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable, Android.Graphics.Drawables.Drawable>> _callExpression_SetCompoundDrawablesWithIntrinsicBounds_Android_Widget_TextView__Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable = (view, param1, param2, param3, param4) => view.SetCompoundDrawablesWithIntrinsicBounds(param1, param2, param3, param4);
        public static TControl SetCompoundDrawablesWithIntrinsicBounds<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pleft, Android.Graphics.Drawables.Drawable ptop, Android.Graphics.Drawables.Drawable pright, Android.Graphics.Drawables.Drawable pbottom) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetCompoundDrawablesWithIntrinsicBounds_Android_Widget_TextView__Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable_Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pleft, ptop, pright, pbottom);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_SetCompoundDrawablesWithIntrinsicBounds_Android_Widget_TextView__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.SetCompoundDrawablesWithIntrinsicBounds(param1, param2, param3, param4);
        public static TControl SetCompoundDrawablesWithIntrinsicBounds<TControl>(this TControl component, System.Int32 pleft, System.Int32 ptop, System.Int32 pright, System.Int32 pbottom) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetCompoundDrawablesWithIntrinsicBounds_Android_Widget_TextView__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pleft, ptop, pright, pbottom);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Boolean>> _callExpression_SetCursorVisible_Android_Widget_TextView__System_Boolean = (view, param1) => view.SetCursorVisible(param1);
        public static TControl SetCursorVisible<TControl>(this TControl component, System.Boolean pvisible) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetCursorVisible_Android_Widget_TextView__System_Boolean;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pvisible);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Text.EditableFactory>> _callExpression_SetEditableFactory_Android_Widget_TextView__Android_Text_EditableFactory = (view, param1) => view.SetEditableFactory(param1);
        public static TControl SetEditableFactory<TControl>(this TControl component, Android.Text.EditableFactory pfactory) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetEditableFactory_Android_Widget_TextView__Android_Text_EditableFactory;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pfactory);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Boolean>> _callExpression_SetElegantTextHeight_Android_Widget_TextView__System_Boolean = (view, param1) => view.SetElegantTextHeight(param1);
        public static TControl SetElegantTextHeight<TControl>(this TControl component, System.Boolean pelegant) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetElegantTextHeight_Android_Widget_TextView__System_Boolean;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pelegant);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetEms_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetEms(param1);
        public static TControl SetEms<TControl>(this TControl component, System.Int32 pems) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetEms_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pems);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Java.Lang.ICharSequence, Android.Graphics.Drawables.Drawable>> _callExpression_SetError_Android_Widget_TextView__Java_Lang_ICharSequence_Android_Graphics_Drawables_Drawable = (view, param1, param2) => view.SetError(param1, param2);
        public static TControl SetError<TControl>(this TControl component, Java.Lang.ICharSequence perror, Android.Graphics.Drawables.Drawable picon) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetError_Android_Widget_TextView__Java_Lang_ICharSequence_Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, perror, picon);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.String, Android.Graphics.Drawables.Drawable>> _callExpression_SetError_Android_Widget_TextView__System_String_Android_Graphics_Drawables_Drawable = (view, param1, param2) => view.SetError(param1, param2);
        public static TControl SetError<TControl>(this TControl component, System.String perror, Android.Graphics.Drawables.Drawable picon) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetError_Android_Widget_TextView__System_String_Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, perror, picon);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Views.InputMethods.ExtractedText>> _callExpression_SetExtractedText_Android_Widget_TextView__Android_Views_InputMethods_ExtractedText = (view, param1) => view.SetExtractedText(param1);
        public static TControl SetExtractedText<TControl>(this TControl component, Android.Views.InputMethods.ExtractedText ptext) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetExtractedText_Android_Widget_TextView__Android_Views_InputMethods_ExtractedText;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Text.IInputFilter[]>> _callExpression_SetFilters_Android_Widget_TextView__Android_Text_IInputFilter_ = (view, param1) => view.SetFilters(param1);
        public static TControl SetFilters<TControl>(this TControl component, Android.Text.IInputFilter[] pfilters) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetFilters_Android_Widget_TextView__Android_Text_IInputFilter_;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pfilters);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetHeight_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetHeight(param1);
        public static TControl SetHeight<TControl>(this TControl component, System.Int32 ppixels) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetHeight_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ppixels);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Graphics.Color>> _callExpression_SetHighlightColor_Android_Widget_TextView__Android_Graphics_Color = (view, param1) => view.SetHighlightColor(param1);
        public static TControl SetHighlightColor<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetHighlightColor_Android_Widget_TextView__Android_Graphics_Color;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetHint_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetHint(param1);
        public static TControl SetHint<TControl>(this TControl component, System.Int32 presid) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetHint_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, presid);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Content.Res.ColorStateList>> _callExpression_SetHintTextColor_Android_Widget_TextView__Android_Content_Res_ColorStateList = (view, param1) => view.SetHintTextColor(param1);
        public static TControl SetHintTextColor<TControl>(this TControl component, Android.Content.Res.ColorStateList pcolors) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetHintTextColor_Android_Widget_TextView__Android_Content_Res_ColorStateList;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolors);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Graphics.Color>> _callExpression_SetHintTextColor_Android_Widget_TextView__Android_Graphics_Color = (view, param1) => view.SetHintTextColor(param1);
        public static TControl SetHintTextColor<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetHintTextColor_Android_Widget_TextView__Android_Graphics_Color;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Boolean>> _callExpression_SetHorizontallyScrolling_Android_Widget_TextView__System_Boolean = (view, param1) => view.SetHorizontallyScrolling(param1);
        public static TControl SetHorizontallyScrolling<TControl>(this TControl component, System.Boolean pwhether) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetHorizontallyScrolling_Android_Widget_TextView__System_Boolean;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pwhether);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Java.Lang.ICharSequence, Android.Views.InputMethods.ImeAction>> _callExpression_SetImeActionLabel_Android_Widget_TextView__Java_Lang_ICharSequence_Android_Views_InputMethods_ImeAction = (view, param1, param2) => view.SetImeActionLabel(param1, param2);
        public static TControl SetImeActionLabel<TControl>(this TControl component, Java.Lang.ICharSequence plabel, Android.Views.InputMethods.ImeAction pactionId) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetImeActionLabel_Android_Widget_TextView__Java_Lang_ICharSequence_Android_Views_InputMethods_ImeAction;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, plabel, pactionId);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.String, Android.Views.InputMethods.ImeAction>> _callExpression_SetImeActionLabel_Android_Widget_TextView__System_String_Android_Views_InputMethods_ImeAction = (view, param1, param2) => view.SetImeActionLabel(param1, param2);
        public static TControl SetImeActionLabel<TControl>(this TControl component, System.String plabel, Android.Views.InputMethods.ImeAction pactionId) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetImeActionLabel_Android_Widget_TextView__System_String_Android_Views_InputMethods_ImeAction;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, plabel, pactionId);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Boolean>> _callExpression_SetIncludeFontPadding_Android_Widget_TextView__System_Boolean = (view, param1) => view.SetIncludeFontPadding(param1);
        public static TControl SetIncludeFontPadding<TControl>(this TControl component, System.Boolean pincludepad) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetIncludeFontPadding_Android_Widget_TextView__System_Boolean;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pincludepad);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetInputExtras_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetInputExtras(param1);
        public static TControl SetInputExtras<TControl>(this TControl component, System.Int32 pxmlResId) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetInputExtras_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pxmlResId);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetLines_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetLines(param1);
        public static TControl SetLines<TControl>(this TControl component, System.Int32 plines) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetLines_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, plines);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Single, System.Single>> _callExpression_SetLineSpacing_Android_Widget_TextView__System_Single_System_Single = (view, param1, param2) => view.SetLineSpacing(param1, param2);
        public static TControl SetLineSpacing<TControl>(this TControl component, System.Single padd, System.Single pmult) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetLineSpacing_Android_Widget_TextView__System_Single_System_Single;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, padd, pmult);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Content.Res.ColorStateList>> _callExpression_SetLinkTextColor_Android_Widget_TextView__Android_Content_Res_ColorStateList = (view, param1) => view.SetLinkTextColor(param1);
        public static TControl SetLinkTextColor<TControl>(this TControl component, Android.Content.Res.ColorStateList pcolors) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetLinkTextColor_Android_Widget_TextView__Android_Content_Res_ColorStateList;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolors);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Graphics.Color>> _callExpression_SetLinkTextColor_Android_Widget_TextView__Android_Graphics_Color = (view, param1) => view.SetLinkTextColor(param1);
        public static TControl SetLinkTextColor<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetLinkTextColor_Android_Widget_TextView__Android_Graphics_Color;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetMarqueeRepeatLimit_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetMarqueeRepeatLimit(param1);
        public static TControl SetMarqueeRepeatLimit<TControl>(this TControl component, System.Int32 pmarqueeLimit) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetMarqueeRepeatLimit_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pmarqueeLimit);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetMaxEms_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetMaxEms(param1);
        public static TControl SetMaxEms<TControl>(this TControl component, System.Int32 pmaxEms) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetMaxEms_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pmaxEms);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetMaxHeight_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetMaxHeight(param1);
        public static TControl SetMaxHeight<TControl>(this TControl component, System.Int32 pmaxPixels) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetMaxHeight_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pmaxPixels);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetMaxLines_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetMaxLines(param1);
        public static TControl SetMaxLines<TControl>(this TControl component, System.Int32 pmaxLines) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetMaxLines_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pmaxLines);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetMaxWidth_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetMaxWidth(param1);
        public static TControl SetMaxWidth<TControl>(this TControl component, System.Int32 pmaxPixels) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetMaxWidth_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pmaxPixels);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetMinEms_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetMinEms(param1);
        public static TControl SetMinEms<TControl>(this TControl component, System.Int32 pminEms) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetMinEms_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pminEms);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetMinHeight_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetMinHeight(param1);
        public static TControl SetMinHeight<TControl>(this TControl component, System.Int32 pminPixels) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetMinHeight_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pminPixels);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetMinLines_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetMinLines(param1);
        public static TControl SetMinLines<TControl>(this TControl component, System.Int32 pminLines) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetMinLines_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pminLines);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetMinWidth_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetMinWidth(param1);
        public static TControl SetMinWidth<TControl>(this TControl component, System.Int32 pminPixels) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetMinWidth_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pminPixels);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Widget.TextView.IOnEditorActionListener>> _callExpression_SetOnEditorActionListener_Android_Widget_TextView__Android_Widget_TextView_IOnEditorActionListener = (view, param1) => view.SetOnEditorActionListener(param1);
        public static TControl SetOnEditorActionListener<TControl>(this TControl component, Android.Widget.TextView.IOnEditorActionListener pl) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetOnEditorActionListener_Android_Widget_TextView__Android_Widget_TextView_IOnEditorActionListener;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_SetPaddingRelative_Android_Widget_TextView__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.SetPaddingRelative(param1, param2, param3, param4);
        public static TControl SetPaddingRelative<TControl>(this TControl component, System.Int32 pstart, System.Int32 ptop, System.Int32 pend, System.Int32 pbottom) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetPaddingRelative_Android_Widget_TextView__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pstart, ptop, pend, pbottom);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Text.InputTypes>> _callExpression_SetRawInputType_Android_Widget_TextView__Android_Text_InputTypes = (view, param1) => view.SetRawInputType(param1);
        public static TControl SetRawInputType<TControl>(this TControl component, Android.Text.InputTypes ptype) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetRawInputType_Android_Widget_TextView__Android_Text_InputTypes;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptype);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Widget.Scroller>> _callExpression_SetScroller_Android_Widget_TextView__Android_Widget_Scroller = (view, param1) => view.SetScroller(param1);
        public static TControl SetScroller<TControl>(this TControl component, Android.Widget.Scroller ps) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetScroller_Android_Widget_TextView__Android_Widget_Scroller;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ps);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Boolean>> _callExpression_SetSelectAllOnFocus_Android_Widget_TextView__System_Boolean = (view, param1) => view.SetSelectAllOnFocus(param1);
        public static TControl SetSelectAllOnFocus<TControl>(this TControl component, System.Boolean pselectAllOnFocus) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetSelectAllOnFocus_Android_Widget_TextView__System_Boolean;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pselectAllOnFocus);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Single, System.Single, System.Single, Android.Graphics.Color>> _callExpression_SetShadowLayer_Android_Widget_TextView__System_Single_System_Single_System_Single_Android_Graphics_Color = (view, param1, param2, param3, param4) => view.SetShadowLayer(param1, param2, param3, param4);
        public static TControl SetShadowLayer<TControl>(this TControl component, System.Single pradius, System.Single pdx, System.Single pdy, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetShadowLayer_Android_Widget_TextView__System_Single_System_Single_System_Single_Android_Graphics_Color;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pradius, pdx, pdy, pcolor);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView>> _callExpression_SetSingleLine_Android_Widget_TextView_ = (view) => view.SetSingleLine();
        public static TControl SetSingleLine<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetSingleLine_Android_Widget_TextView_;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Boolean>> _callExpression_SetSingleLine_Android_Widget_TextView__System_Boolean = (view, param1) => view.SetSingleLine(param1);
        public static TControl SetSingleLine<TControl>(this TControl component, System.Boolean psingleLine) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetSingleLine_Android_Widget_TextView__System_Boolean;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, psingleLine);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Text.SpannableFactory>> _callExpression_SetSpannableFactory_Android_Widget_TextView__Android_Text_SpannableFactory = (view, param1) => view.SetSpannableFactory(param1);
        public static TControl SetSpannableFactory<TControl>(this TControl component, Android.Text.SpannableFactory pfactory) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetSpannableFactory_Android_Widget_TextView__Android_Text_SpannableFactory;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pfactory);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Char[], System.Int32, System.Int32>> _callExpression_SetText_Android_Widget_TextView__System_Char__System_Int32_System_Int32 = (view, param1, param2, param3) => view.SetText(param1, param2, param3);
        public static TControl SetText<TControl>(this TControl component, System.Char[] ptext, System.Int32 pstart, System.Int32 plen) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetText_Android_Widget_TextView__System_Char__System_Int32_System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext, pstart, plen);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetText_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetText(param1);
        public static TControl SetText<TControl>(this TControl component, System.Int32 presid) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetText_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, presid);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32, Android.Widget.TextView.BufferType>> _callExpression_SetText_Android_Widget_TextView__System_Int32_Android_Widget_TextView_BufferType = (view, param1, param2) => view.SetText(param1, param2);
        public static TControl SetText<TControl>(this TControl component, System.Int32 presid, Android.Widget.TextView.BufferType ptype) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetText_Android_Widget_TextView__System_Int32_Android_Widget_TextView_BufferType;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, presid, ptype);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Java.Lang.ICharSequence, Android.Widget.TextView.BufferType>> _callExpression_SetText_Android_Widget_TextView__Java_Lang_ICharSequence_Android_Widget_TextView_BufferType = (view, param1, param2) => view.SetText(param1, param2);
        public static TControl SetText<TControl>(this TControl component, Java.Lang.ICharSequence ptext, Android.Widget.TextView.BufferType ptype) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetText_Android_Widget_TextView__Java_Lang_ICharSequence_Android_Widget_TextView_BufferType;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext, ptype);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.String, Android.Widget.TextView.BufferType>> _callExpression_SetText_Android_Widget_TextView__System_String_Android_Widget_TextView_BufferType = (view, param1, param2) => view.SetText(param1, param2);
        public static TControl SetText<TControl>(this TControl component, System.String ptext, Android.Widget.TextView.BufferType ptype) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetText_Android_Widget_TextView__System_String_Android_Widget_TextView_BufferType;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext, ptype);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Content.Context, System.Int32>> _callExpression_SetTextAppearance_Android_Widget_TextView__Android_Content_Context_System_Int32 = (view, param1, param2) => view.SetTextAppearance(param1, param2);
        public static TControl SetTextAppearance<TControl>(this TControl component, Android.Content.Context pcontext, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextAppearance_Android_Widget_TextView__Android_Content_Context_System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontext, presId);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetTextAppearance_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetTextAppearance(param1);
        public static TControl SetTextAppearance<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextAppearance_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Content.Res.ColorStateList>> _callExpression_SetTextColor_Android_Widget_TextView__Android_Content_Res_ColorStateList = (view, param1) => view.SetTextColor(param1);
        public static TControl SetTextColor<TControl>(this TControl component, Android.Content.Res.ColorStateList pcolors) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextColor_Android_Widget_TextView__Android_Content_Res_ColorStateList;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolors);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Graphics.Color>> _callExpression_SetTextColor_Android_Widget_TextView__Android_Graphics_Color = (view, param1) => view.SetTextColor(param1);
        public static TControl SetTextColor<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextColor_Android_Widget_TextView__Android_Graphics_Color;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Boolean>> _callExpression_SetTextIsSelectable_Android_Widget_TextView__System_Boolean = (view, param1) => view.SetTextIsSelectable(param1);
        public static TControl SetTextIsSelectable<TControl>(this TControl component, System.Boolean pselectable) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextIsSelectable_Android_Widget_TextView__System_Boolean;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pselectable);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Java.Lang.ICharSequence>> _callExpression_SetTextKeepState_Android_Widget_TextView__Java_Lang_ICharSequence = (view, param1) => view.SetTextKeepState(param1);
        public static TControl SetTextKeepState<TControl>(this TControl component, Java.Lang.ICharSequence ptext) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextKeepState_Android_Widget_TextView__Java_Lang_ICharSequence;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.String>> _callExpression_SetTextKeepState_Android_Widget_TextView__System_String = (view, param1) => view.SetTextKeepState(param1);
        public static TControl SetTextKeepState<TControl>(this TControl component, System.String ptext) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextKeepState_Android_Widget_TextView__System_String;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Java.Lang.ICharSequence, Android.Widget.TextView.BufferType>> _callExpression_SetTextKeepState_Android_Widget_TextView__Java_Lang_ICharSequence_Android_Widget_TextView_BufferType = (view, param1, param2) => view.SetTextKeepState(param1, param2);
        public static TControl SetTextKeepState<TControl>(this TControl component, Java.Lang.ICharSequence ptext, Android.Widget.TextView.BufferType ptype) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextKeepState_Android_Widget_TextView__Java_Lang_ICharSequence_Android_Widget_TextView_BufferType;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext, ptype);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.String, Android.Widget.TextView.BufferType>> _callExpression_SetTextKeepState_Android_Widget_TextView__System_String_Android_Widget_TextView_BufferType = (view, param1, param2) => view.SetTextKeepState(param1, param2);
        public static TControl SetTextKeepState<TControl>(this TControl component, System.String ptext, Android.Widget.TextView.BufferType ptype) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextKeepState_Android_Widget_TextView__System_String_Android_Widget_TextView_BufferType;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext, ptype);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Util.ComplexUnitType, System.Single>> _callExpression_SetTextSize_Android_Widget_TextView__Android_Util_ComplexUnitType_System_Single = (view, param1, param2) => view.SetTextSize(param1, param2);
        public static TControl SetTextSize<TControl>(this TControl component, Android.Util.ComplexUnitType punit, System.Single psize) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTextSize_Android_Widget_TextView__Android_Util_ComplexUnitType_System_Single;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, punit, psize);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, Android.Graphics.Typeface, Android.Graphics.TypefaceStyle>> _callExpression_SetTypeface_Android_Widget_TextView__Android_Graphics_Typeface_Android_Graphics_TypefaceStyle = (view, param1, param2) => view.SetTypeface(param1, param2);
        public static TControl SetTypeface<TControl>(this TControl component, Android.Graphics.Typeface ptf, Android.Graphics.TypefaceStyle pstyle) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetTypeface_Android_Widget_TextView__Android_Graphics_Typeface_Android_Graphics_TypefaceStyle;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptf, pstyle);
            return component;
        }
    }
    public static partial class Android_Widget_TextView_Extensions
    {
        private static Expression<Action<Android.Widget.TextView, System.Int32>> _callExpression_SetWidth_Android_Widget_TextView__System_Int32 = (view, param1) => view.SetWidth(param1);
        public static TControl SetWidth<TControl>(this TControl component, System.Int32 ppixels) where TControl:IReflectedPrimitive<Android.Widget.TextView>
        {
            var callExpression = _callExpression_SetWidth_Android_Widget_TextView__System_Int32;

            Reflect<Android.Widget.TextView>.ReflectionHelpers.Call(component.Attributes,callExpression, ppixels);
            return component;
        }
    }

    public static partial class Android_Widget_AbsSeekBar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_KeyProgressIncrement = AttributeReflectionHelper.ResolveFor<Android.Widget.AbsSeekBar, System.Int32>
        (v => v.KeyProgressIncrement);


        public static TControl KeyProgressIncrement<TControl>(this TControl component, System.Int32 pKeyProgressIncrement)  where TControl:IReflectedPrimitive<Android.Widget.AbsSeekBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AbsSeekBar t = default;
                t.KeyProgressIncrement = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_KeyProgressIncrement,pKeyProgressIncrement);
            return component;
        }
    }
    public static partial class Android_Widget_AbsSeekBar_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_SplitTrack = AttributeReflectionHelper.ResolveFor<Android.Widget.AbsSeekBar, System.Boolean>
        (v => v.SplitTrack);


        public static TControl SplitTrack<TControl>(this TControl component, System.Boolean pSplitTrack)  where TControl:IReflectedPrimitive<Android.Widget.AbsSeekBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AbsSeekBar t = default;
                t.SplitTrack = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_SplitTrack,pSplitTrack);
            return component;
        }
    }
    public static partial class Android_Widget_AbsSeekBar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ThumbOffset = AttributeReflectionHelper.ResolveFor<Android.Widget.AbsSeekBar, System.Int32>
        (v => v.ThumbOffset);


        public static TControl ThumbOffset<TControl>(this TControl component, System.Int32 pThumbOffset)  where TControl:IReflectedPrimitive<Android.Widget.AbsSeekBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AbsSeekBar t = default;
                t.ThumbOffset = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ThumbOffset,pThumbOffset);
            return component;
        }
    }
    public static partial class Android_Widget_AbsSeekBar_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_ThumbTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.AbsSeekBar, Android.Content.Res.ColorStateList>
        (v => v.ThumbTintList);


        public static TControl ThumbTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pThumbTintList)  where TControl:IReflectedPrimitive<Android.Widget.AbsSeekBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AbsSeekBar t = default;
                t.ThumbTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_ThumbTintList,pThumbTintList);
            return component;
        }
    }
    public static partial class Android_Widget_AbsSeekBar_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_ThumbTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.AbsSeekBar, Android.Graphics.PorterDuff.Mode>
        (v => v.ThumbTintMode);


        public static TControl ThumbTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pThumbTintMode)  where TControl:IReflectedPrimitive<Android.Widget.AbsSeekBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AbsSeekBar t = default;
                t.ThumbTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_ThumbTintMode,pThumbTintMode);
            return component;
        }
    }
    public static partial class Android_Widget_AbsSeekBar_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_TickMark = AttributeReflectionHelper.ResolveFor<Android.Widget.AbsSeekBar, Android.Graphics.Drawables.Drawable>
        (v => v.TickMark);


        public static TControl TickMark<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pTickMark)  where TControl:IReflectedPrimitive<Android.Widget.AbsSeekBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AbsSeekBar t = default;
                t.TickMark = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_TickMark,pTickMark);
            return component;
        }
    }
    public static partial class Android_Widget_AbsSeekBar_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_TickMarkTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.AbsSeekBar, Android.Content.Res.ColorStateList>
        (v => v.TickMarkTintList);


        public static TControl TickMarkTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pTickMarkTintList)  where TControl:IReflectedPrimitive<Android.Widget.AbsSeekBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AbsSeekBar t = default;
                t.TickMarkTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_TickMarkTintList,pTickMarkTintList);
            return component;
        }
    }
    public static partial class Android_Widget_AbsSeekBar_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_TickMarkTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.AbsSeekBar, Android.Graphics.PorterDuff.Mode>
        (v => v.TickMarkTintMode);


        public static TControl TickMarkTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pTickMarkTintMode)  where TControl:IReflectedPrimitive<Android.Widget.AbsSeekBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AbsSeekBar t = default;
                t.TickMarkTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_TickMarkTintMode,pTickMarkTintMode);
            return component;
        }
    }


    public static partial class Android_Widget_AbsSeekBar_Extensions
    {
        private static Expression<Action<Android.Widget.AbsSeekBar, Android.Graphics.Drawables.Drawable>> _callExpression_SetThumb_Android_Widget_AbsSeekBar__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetThumb(param1);
        public static TControl SetThumb<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pthumb) where TControl:IReflectedPrimitive<Android.Widget.AbsSeekBar>
        {
            var callExpression = _callExpression_SetThumb_Android_Widget_AbsSeekBar__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.AbsSeekBar>.ReflectionHelpers.Call(component.Attributes,callExpression, pthumb);
            return component;
        }
    }

    public static partial class Android_Widget_AbsSpinner_Extensions
    {
        private static readonly Attribute<Android.Widget.ISpinnerAdapter> Attribute_ISpinnerAdapter_Adapter = AttributeReflectionHelper.ResolveFor<Android.Widget.AbsSpinner, Android.Widget.ISpinnerAdapter>
        (v => v.Adapter);


        public static TControl Adapter<TControl>(this TControl component, Android.Widget.ISpinnerAdapter pAdapter)  where TControl:IReflectedPrimitive<Android.Widget.AbsSpinner>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.AbsSpinner t = default;
                t.Adapter = default;
            }

            component.Attributes.SetAttribute(Attribute_ISpinnerAdapter_Adapter,pAdapter);
            return component;
        }
    }


    public static partial class Android_Widget_AbsSpinner_Extensions
    {
        private static Expression<Action<Android.Widget.AbsSpinner, System.Int32>> _callExpression_SetSelection_Android_Widget_AbsSpinner__System_Int32 = (view, param1) => view.SetSelection(param1);
        public static TControl SetSelection<TControl>(this TControl component, System.Int32 pposition) where TControl:IReflectedPrimitive<Android.Widget.AbsSpinner>
        {
            var callExpression = _callExpression_SetSelection_Android_Widget_AbsSpinner__System_Int32;

            Reflect<Android.Widget.AbsSpinner>.ReflectionHelpers.Call(component.Attributes,callExpression, pposition);
            return component;
        }
    }
    public static partial class Android_Widget_AbsSpinner_Extensions
    {
        private static Expression<Action<Android.Widget.AbsSpinner, System.Int32, System.Boolean>> _callExpression_SetSelection_Android_Widget_AbsSpinner__System_Int32_System_Boolean = (view, param1, param2) => view.SetSelection(param1, param2);
        public static TControl SetSelection<TControl>(this TControl component, System.Int32 pposition, System.Boolean panimate) where TControl:IReflectedPrimitive<Android.Widget.AbsSpinner>
        {
            var callExpression = _callExpression_SetSelection_Android_Widget_AbsSpinner__System_Int32_System_Boolean;

            Reflect<Android.Widget.AbsSpinner>.ReflectionHelpers.Call(component.Attributes,callExpression, pposition, panimate);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.AnalogClock> AnalogClock(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.AnalogClock(default);
            }

            var control = View<Android.Widget.AnalogClock>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.Button> Button(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.Button(default);
            }

            var control = View<Android.Widget.Button>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.CalendarView> CalendarView(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.CalendarView(default);
            }

            var control = View<Android.Widget.CalendarView>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<System.Int64> Attribute_Int64_Date = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, System.Int64>
        (v => v.Date);


        public static TControl Date<TControl>(this TControl component, System.Int64 pDate)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.Date = default;
            }

            component.Attributes.SetAttribute(Attribute_Int64_Date,pDate);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DateTextAppearance = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, System.Int32>
        (v => v.DateTextAppearance);


        public static TControl DateTextAppearance<TControl>(this TControl component, System.Int32 pDateTextAppearance)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.DateTextAppearance = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DateTextAppearance,pDateTextAppearance);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_FirstDayOfWeek = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, System.Int32>
        (v => v.FirstDayOfWeek);


        public static TControl FirstDayOfWeek<TControl>(this TControl component, System.Int32 pFirstDayOfWeek)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.FirstDayOfWeek = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_FirstDayOfWeek,pFirstDayOfWeek);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<Android.Graphics.Color> Attribute_Color_FocusedMonthDateColor = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, Android.Graphics.Color>
        (v => v.FocusedMonthDateColor);


        public static TControl FocusedMonthDateColor<TControl>(this TControl component, Android.Graphics.Color pFocusedMonthDateColor)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.FocusedMonthDateColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_FocusedMonthDateColor,pFocusedMonthDateColor);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<System.Int64> Attribute_Int64_MaxDate = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, System.Int64>
        (v => v.MaxDate);


        public static TControl MaxDate<TControl>(this TControl component, System.Int64 pMaxDate)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.MaxDate = default;
            }

            component.Attributes.SetAttribute(Attribute_Int64_MaxDate,pMaxDate);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<System.Int64> Attribute_Int64_MinDate = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, System.Int64>
        (v => v.MinDate);


        public static TControl MinDate<TControl>(this TControl component, System.Int64 pMinDate)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.MinDate = default;
            }

            component.Attributes.SetAttribute(Attribute_Int64_MinDate,pMinDate);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_SelectedDateVerticalBar = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, Android.Graphics.Drawables.Drawable>
        (v => v.SelectedDateVerticalBar);


        public static TControl SelectedDateVerticalBar<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pSelectedDateVerticalBar)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.SelectedDateVerticalBar = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_SelectedDateVerticalBar,pSelectedDateVerticalBar);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<Android.Graphics.Color> Attribute_Color_SelectedWeekBackgroundColor = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, Android.Graphics.Color>
        (v => v.SelectedWeekBackgroundColor);


        public static TControl SelectedWeekBackgroundColor<TControl>(this TControl component, Android.Graphics.Color pSelectedWeekBackgroundColor)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.SelectedWeekBackgroundColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_SelectedWeekBackgroundColor,pSelectedWeekBackgroundColor);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ShowWeekNumber = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, System.Boolean>
        (v => v.ShowWeekNumber);


        public static TControl ShowWeekNumber<TControl>(this TControl component, System.Boolean pShowWeekNumber)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.ShowWeekNumber = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_ShowWeekNumber,pShowWeekNumber);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ShownWeekCount = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, System.Int32>
        (v => v.ShownWeekCount);


        public static TControl ShownWeekCount<TControl>(this TControl component, System.Int32 pShownWeekCount)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.ShownWeekCount = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ShownWeekCount,pShownWeekCount);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<Android.Graphics.Color> Attribute_Color_UnfocusedMonthDateColor = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, Android.Graphics.Color>
        (v => v.UnfocusedMonthDateColor);


        public static TControl UnfocusedMonthDateColor<TControl>(this TControl component, Android.Graphics.Color pUnfocusedMonthDateColor)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.UnfocusedMonthDateColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_UnfocusedMonthDateColor,pUnfocusedMonthDateColor);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_WeekDayTextAppearance = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, System.Int32>
        (v => v.WeekDayTextAppearance);


        public static TControl WeekDayTextAppearance<TControl>(this TControl component, System.Int32 pWeekDayTextAppearance)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.WeekDayTextAppearance = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_WeekDayTextAppearance,pWeekDayTextAppearance);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<Android.Graphics.Color> Attribute_Color_WeekNumberColor = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, Android.Graphics.Color>
        (v => v.WeekNumberColor);


        public static TControl WeekNumberColor<TControl>(this TControl component, Android.Graphics.Color pWeekNumberColor)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.WeekNumberColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_WeekNumberColor,pWeekNumberColor);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static readonly Attribute<Android.Graphics.Color> Attribute_Color_WeekSeparatorLineColor = AttributeReflectionHelper.ResolveFor<Android.Widget.CalendarView, Android.Graphics.Color>
        (v => v.WeekSeparatorLineColor);


        public static TControl WeekSeparatorLineColor<TControl>(this TControl component, Android.Graphics.Color pWeekSeparatorLineColor)  where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CalendarView t = default;
                t.WeekSeparatorLineColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_WeekSeparatorLineColor,pWeekSeparatorLineColor);
            return component;
        }
    }

public static partial class Android_Widget_CalendarView_Extensions
{
    public static TControl OnDateChange<TControl>(this TControl control,Action<Android.Widget.CalendarView.DateChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.CalendarView tv = null;

            tv.DateChange += handler;
            tv.DateChange -= handler;
        }

        control.Event(x => nameof(x.DateChange),action);
        return control;
    }
}

    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static Expression<Action<Android.Widget.CalendarView, System.Int64, System.Boolean, System.Boolean>> _callExpression_SetDate_Android_Widget_CalendarView__System_Int64_System_Boolean_System_Boolean = (view, param1, param2, param3) => view.SetDate(param1, param2, param3);
        public static TControl SetDate<TControl>(this TControl component, System.Int64 pdate, System.Boolean panimate, System.Boolean pcenter) where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            var callExpression = _callExpression_SetDate_Android_Widget_CalendarView__System_Int64_System_Boolean_System_Boolean;

            Reflect<Android.Widget.CalendarView>.ReflectionHelpers.Call(component.Attributes,callExpression, pdate, panimate, pcenter);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static Expression<Action<Android.Widget.CalendarView, Android.Widget.CalendarView.IOnDateChangeListener>> _callExpression_SetOnDateChangeListener_Android_Widget_CalendarView__Android_Widget_CalendarView_IOnDateChangeListener = (view, param1) => view.SetOnDateChangeListener(param1);
        public static TControl SetOnDateChangeListener<TControl>(this TControl component, Android.Widget.CalendarView.IOnDateChangeListener plistener) where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            var callExpression = _callExpression_SetOnDateChangeListener_Android_Widget_CalendarView__Android_Widget_CalendarView_IOnDateChangeListener;

            Reflect<Android.Widget.CalendarView>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Widget_CalendarView_Extensions
    {
        private static Expression<Action<Android.Widget.CalendarView, System.Int32>> _callExpression_SetSelectedDateVerticalBar_Android_Widget_CalendarView__System_Int32 = (view, param1) => view.SetSelectedDateVerticalBar(param1);
        public static TControl SetSelectedDateVerticalBar<TControl>(this TControl component, System.Int32 presourceId) where TControl:IReflectedPrimitive<Android.Widget.CalendarView>
        {
            var callExpression = _callExpression_SetSelectedDateVerticalBar_Android_Widget_CalendarView__System_Int32;

            Reflect<Android.Widget.CalendarView>.ReflectionHelpers.Call(component.Attributes,callExpression, presourceId);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.CheckBox> CheckBox(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.CheckBox(default);
            }

            var control = View<Android.Widget.CheckBox>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.CheckedTextView> CheckedTextView(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.CheckedTextView(default);
            }

            var control = View<Android.Widget.CheckedTextView>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_CheckedTextView_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_CheckMarkTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.CheckedTextView, Android.Content.Res.ColorStateList>
        (v => v.CheckMarkTintList);


        public static TControl CheckMarkTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pCheckMarkTintList)  where TControl:IReflectedPrimitive<Android.Widget.CheckedTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CheckedTextView t = default;
                t.CheckMarkTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_CheckMarkTintList,pCheckMarkTintList);
            return component;
        }
    }
    public static partial class Android_Widget_CheckedTextView_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_CheckMarkTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.CheckedTextView, Android.Graphics.PorterDuff.Mode>
        (v => v.CheckMarkTintMode);


        public static TControl CheckMarkTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pCheckMarkTintMode)  where TControl:IReflectedPrimitive<Android.Widget.CheckedTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CheckedTextView t = default;
                t.CheckMarkTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_CheckMarkTintMode,pCheckMarkTintMode);
            return component;
        }
    }
    public static partial class Android_Widget_CheckedTextView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Checked = AttributeReflectionHelper.ResolveFor<Android.Widget.CheckedTextView, System.Boolean>
        (v => v.Checked);


        public static TControl Checked<TControl>(this TControl component, System.Boolean pChecked)  where TControl:IReflectedPrimitive<Android.Widget.CheckedTextView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CheckedTextView t = default;
                t.Checked = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Checked,pChecked);
            return component;
        }
    }


    public static partial class Android_Widget_CheckedTextView_Extensions
    {
        private static Expression<Action<Android.Widget.CheckedTextView, Android.Graphics.Drawables.Drawable>> _callExpression_SetCheckMarkDrawable_Android_Widget_CheckedTextView__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetCheckMarkDrawable(param1);
        public static TControl SetCheckMarkDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pd) where TControl:IReflectedPrimitive<Android.Widget.CheckedTextView>
        {
            var callExpression = _callExpression_SetCheckMarkDrawable_Android_Widget_CheckedTextView__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.CheckedTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pd);
            return component;
        }
    }
    public static partial class Android_Widget_CheckedTextView_Extensions
    {
        private static Expression<Action<Android.Widget.CheckedTextView, System.Int32>> _callExpression_SetCheckMarkDrawable_Android_Widget_CheckedTextView__System_Int32 = (view, param1) => view.SetCheckMarkDrawable(param1);
        public static TControl SetCheckMarkDrawable<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.CheckedTextView>
        {
            var callExpression = _callExpression_SetCheckMarkDrawable_Android_Widget_CheckedTextView__System_Int32;

            Reflect<Android.Widget.CheckedTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_CheckedTextView_Extensions
    {
        private static Expression<Action<Android.Widget.CheckedTextView>> _callExpression_Toggle_Android_Widget_CheckedTextView_ = (view) => view.Toggle();
        public static TControl Toggle<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.CheckedTextView>
        {
            var callExpression = _callExpression_Toggle_Android_Widget_CheckedTextView_;

            Reflect<Android.Widget.CheckedTextView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.Chronometer> Chronometer(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.Chronometer(default);
            }

            var control = View<Android.Widget.Chronometer>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_Chronometer_Extensions
    {
        private static readonly Attribute<System.Int64> Attribute_Int64_Base = AttributeReflectionHelper.ResolveFor<Android.Widget.Chronometer, System.Int64>
        (v => v.Base);


        public static TControl Base<TControl>(this TControl component, System.Int64 pBase)  where TControl:IReflectedPrimitive<Android.Widget.Chronometer>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Chronometer t = default;
                t.Base = default;
            }

            component.Attributes.SetAttribute(Attribute_Int64_Base,pBase);
            return component;
        }
    }
    public static partial class Android_Widget_Chronometer_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_CountDown = AttributeReflectionHelper.ResolveFor<Android.Widget.Chronometer, System.Boolean>
        (v => v.CountDown);


        public static TControl CountDown<TControl>(this TControl component, System.Boolean pCountDown)  where TControl:IReflectedPrimitive<Android.Widget.Chronometer>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Chronometer t = default;
                t.CountDown = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_CountDown,pCountDown);
            return component;
        }
    }
    public static partial class Android_Widget_Chronometer_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Format = AttributeReflectionHelper.ResolveFor<Android.Widget.Chronometer, System.String>
        (v => v.Format);


        public static TControl Format<TControl>(this TControl component, System.String pFormat)  where TControl:IReflectedPrimitive<Android.Widget.Chronometer>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Chronometer t = default;
                t.Format = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Format,pFormat);
            return component;
        }
    }
    public static partial class Android_Widget_Chronometer_Extensions
    {
        private static readonly Attribute<Android.Widget.Chronometer.IOnChronometerTickListener> Attribute_IOnChronometerTickListener_OnChronometerTickListener = AttributeReflectionHelper.ResolveFor<Android.Widget.Chronometer, Android.Widget.Chronometer.IOnChronometerTickListener>
        (v => v.OnChronometerTickListener);


        public static TControl OnChronometerTickListener<TControl>(this TControl component, Android.Widget.Chronometer.IOnChronometerTickListener pOnChronometerTickListener)  where TControl:IReflectedPrimitive<Android.Widget.Chronometer>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Chronometer t = default;
                t.OnChronometerTickListener = default;
            }

            component.Attributes.SetAttribute(Attribute_IOnChronometerTickListener_OnChronometerTickListener,pOnChronometerTickListener);
            return component;
        }
    }

public static partial class Android_Widget_Chronometer_Extensions
{
    public static TControl OnChronometerTick<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Android.Widget.Chronometer>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.Chronometer tv = null;

            tv.ChronometerTick += handler;
            tv.ChronometerTick -= handler;
        }

        control.Event(x => nameof(x.ChronometerTick),action);
        return control;
    }
}

    public static partial class Android_Widget_Chronometer_Extensions
    {
        private static Expression<Action<Android.Widget.Chronometer>> _callExpression_Start_Android_Widget_Chronometer_ = (view) => view.Start();
        public static TControl Start<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.Chronometer>
        {
            var callExpression = _callExpression_Start_Android_Widget_Chronometer_;

            Reflect<Android.Widget.Chronometer>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_Chronometer_Extensions
    {
        private static Expression<Action<Android.Widget.Chronometer>> _callExpression_Stop_Android_Widget_Chronometer_ = (view) => view.Stop();
        public static TControl Stop<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.Chronometer>
        {
            var callExpression = _callExpression_Stop_Android_Widget_Chronometer_;

            Reflect<Android.Widget.Chronometer>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }

    public static partial class Android_Widget_CompoundButton_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_ButtonTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.CompoundButton, Android.Content.Res.ColorStateList>
        (v => v.ButtonTintList);


        public static TControl ButtonTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pButtonTintList)  where TControl:IReflectedPrimitive<Android.Widget.CompoundButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CompoundButton t = default;
                t.ButtonTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_ButtonTintList,pButtonTintList);
            return component;
        }
    }
    public static partial class Android_Widget_CompoundButton_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_ButtonTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.CompoundButton, Android.Graphics.PorterDuff.Mode>
        (v => v.ButtonTintMode);


        public static TControl ButtonTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pButtonTintMode)  where TControl:IReflectedPrimitive<Android.Widget.CompoundButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CompoundButton t = default;
                t.ButtonTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_ButtonTintMode,pButtonTintMode);
            return component;
        }
    }
    public static partial class Android_Widget_CompoundButton_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Checked = AttributeReflectionHelper.ResolveFor<Android.Widget.CompoundButton, System.Boolean>
        (v => v.Checked);


        public static TControl Checked<TControl>(this TControl component, System.Boolean pChecked)  where TControl:IReflectedPrimitive<Android.Widget.CompoundButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.CompoundButton t = default;
                t.Checked = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Checked,pChecked);
            return component;
        }
    }

public static partial class Android_Widget_CompoundButton_Extensions
{
    public static TControl OnCheckedChange<TControl>(this TControl control,Action<Android.Widget.CompoundButton.CheckedChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.CompoundButton>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.CompoundButton tv = null;

            tv.CheckedChange += handler;
            tv.CheckedChange -= handler;
        }

        control.Event(x => nameof(x.CheckedChange),action);
        return control;
    }
}

    public static partial class Android_Widget_CompoundButton_Extensions
    {
        private static Expression<Action<Android.Widget.CompoundButton, Android.Graphics.Drawables.Drawable>> _callExpression_SetButtonDrawable_Android_Widget_CompoundButton__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetButtonDrawable(param1);
        public static TControl SetButtonDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pdrawable) where TControl:IReflectedPrimitive<Android.Widget.CompoundButton>
        {
            var callExpression = _callExpression_SetButtonDrawable_Android_Widget_CompoundButton__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.CompoundButton>.ReflectionHelpers.Call(component.Attributes,callExpression, pdrawable);
            return component;
        }
    }
    public static partial class Android_Widget_CompoundButton_Extensions
    {
        private static Expression<Action<Android.Widget.CompoundButton, System.Int32>> _callExpression_SetButtonDrawable_Android_Widget_CompoundButton__System_Int32 = (view, param1) => view.SetButtonDrawable(param1);
        public static TControl SetButtonDrawable<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.CompoundButton>
        {
            var callExpression = _callExpression_SetButtonDrawable_Android_Widget_CompoundButton__System_Int32;

            Reflect<Android.Widget.CompoundButton>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_CompoundButton_Extensions
    {
        private static Expression<Action<Android.Widget.CompoundButton, Android.Widget.CompoundButton.IOnCheckedChangeListener>> _callExpression_SetOnCheckedChangeListener_Android_Widget_CompoundButton__Android_Widget_CompoundButton_IOnCheckedChangeListener = (view, param1) => view.SetOnCheckedChangeListener(param1);
        public static TControl SetOnCheckedChangeListener<TControl>(this TControl component, Android.Widget.CompoundButton.IOnCheckedChangeListener plistener) where TControl:IReflectedPrimitive<Android.Widget.CompoundButton>
        {
            var callExpression = _callExpression_SetOnCheckedChangeListener_Android_Widget_CompoundButton__Android_Widget_CompoundButton_IOnCheckedChangeListener;

            Reflect<Android.Widget.CompoundButton>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Widget_CompoundButton_Extensions
    {
        private static Expression<Action<Android.Widget.CompoundButton>> _callExpression_Toggle_Android_Widget_CompoundButton_ = (view) => view.Toggle();
        public static TControl Toggle<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.CompoundButton>
        {
            var callExpression = _callExpression_Toggle_Android_Widget_CompoundButton_;

            Reflect<Android.Widget.CompoundButton>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.DigitalClock> DigitalClock(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.DigitalClock(default);
            }

            var control = View<Android.Widget.DigitalClock>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.EditText> EditText(System.String pText, Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.EditText(default);
            }

            var control = View<Android.Widget.EditText>(dimensions:dimensions,id:id);
            control.Text(pText);
            return control;
        }    
    }



    public static partial class Android_Widget_EditText_Extensions
    {
        private static Expression<Action<Android.Widget.EditText, System.Int32>> _callExpression_ExtendSelection_Android_Widget_EditText__System_Int32 = (view, param1) => view.ExtendSelection(param1);
        public static TControl ExtendSelection<TControl>(this TControl component, System.Int32 pindex) where TControl:IReflectedPrimitive<Android.Widget.EditText>
        {
            var callExpression = _callExpression_ExtendSelection_Android_Widget_EditText__System_Int32;

            Reflect<Android.Widget.EditText>.ReflectionHelpers.Call(component.Attributes,callExpression, pindex);
            return component;
        }
    }
    public static partial class Android_Widget_EditText_Extensions
    {
        private static Expression<Action<Android.Widget.EditText>> _callExpression_SelectAll_Android_Widget_EditText_ = (view) => view.SelectAll();
        public static TControl SelectAll<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.EditText>
        {
            var callExpression = _callExpression_SelectAll_Android_Widget_EditText_;

            Reflect<Android.Widget.EditText>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_EditText_Extensions
    {
        private static Expression<Action<Android.Widget.EditText, System.Int32>> _callExpression_SetSelection_Android_Widget_EditText__System_Int32 = (view, param1) => view.SetSelection(param1);
        public static TControl SetSelection<TControl>(this TControl component, System.Int32 pindex) where TControl:IReflectedPrimitive<Android.Widget.EditText>
        {
            var callExpression = _callExpression_SetSelection_Android_Widget_EditText__System_Int32;

            Reflect<Android.Widget.EditText>.ReflectionHelpers.Call(component.Attributes,callExpression, pindex);
            return component;
        }
    }
    public static partial class Android_Widget_EditText_Extensions
    {
        private static Expression<Action<Android.Widget.EditText, System.Int32, System.Int32>> _callExpression_SetSelection_Android_Widget_EditText__System_Int32_System_Int32 = (view, param1, param2) => view.SetSelection(param1, param2);
        public static TControl SetSelection<TControl>(this TControl component, System.Int32 pstart, System.Int32 pstop) where TControl:IReflectedPrimitive<Android.Widget.EditText>
        {
            var callExpression = _callExpression_SetSelection_Android_Widget_EditText__System_Int32_System_Int32;

            Reflect<Android.Widget.EditText>.ReflectionHelpers.Call(component.Attributes,callExpression, pstart, pstop);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.ImageButton> ImageButton(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.ImageButton(default);
            }

            var control = View<Android.Widget.ImageButton>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.ImageSwitcher> ImageSwitcher(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.ImageSwitcher(default);
            }

            var control = View<Android.Widget.ImageSwitcher>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Android_Widget_ImageSwitcher_Extensions
    {
        private static Expression<Action<Android.Widget.ImageSwitcher, Android.Graphics.Drawables.Drawable>> _callExpression_SetImageDrawable_Android_Widget_ImageSwitcher__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetImageDrawable(param1);
        public static TControl SetImageDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pdrawable) where TControl:IReflectedPrimitive<Android.Widget.ImageSwitcher>
        {
            var callExpression = _callExpression_SetImageDrawable_Android_Widget_ImageSwitcher__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.ImageSwitcher>.ReflectionHelpers.Call(component.Attributes,callExpression, pdrawable);
            return component;
        }
    }
    public static partial class Android_Widget_ImageSwitcher_Extensions
    {
        private static Expression<Action<Android.Widget.ImageSwitcher, System.Int32>> _callExpression_SetImageResource_Android_Widget_ImageSwitcher__System_Int32 = (view, param1) => view.SetImageResource(param1);
        public static TControl SetImageResource<TControl>(this TControl component, System.Int32 presid) where TControl:IReflectedPrimitive<Android.Widget.ImageSwitcher>
        {
            var callExpression = _callExpression_SetImageResource_Android_Widget_ImageSwitcher__System_Int32;

            Reflect<Android.Widget.ImageSwitcher>.ReflectionHelpers.Call(component.Attributes,callExpression, presid);
            return component;
        }
    }
    public static partial class Android_Widget_ImageSwitcher_Extensions
    {
        private static Expression<Action<Android.Widget.ImageSwitcher, Android.Net.Uri>> _callExpression_SetImageURI_Android_Widget_ImageSwitcher__Android_Net_Uri = (view, param1) => view.SetImageURI(param1);
        public static TControl SetImageURI<TControl>(this TControl component, Android.Net.Uri puri) where TControl:IReflectedPrimitive<Android.Widget.ImageSwitcher>
        {
            var callExpression = _callExpression_SetImageURI_Android_Widget_ImageSwitcher__Android_Net_Uri;

            Reflect<Android.Widget.ImageSwitcher>.ReflectionHelpers.Call(component.Attributes,callExpression, puri);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.ImageView> ImageView(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.ImageView(default);
            }

            var control = View<Android.Widget.ImageView>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_ImageView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_BaselineAlignBottom = AttributeReflectionHelper.ResolveFor<Android.Widget.ImageView, System.Boolean>
        (v => v.BaselineAlignBottom);


        public static TControl BaselineAlignBottom<TControl>(this TControl component, System.Boolean pBaselineAlignBottom)  where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ImageView t = default;
                t.BaselineAlignBottom = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_BaselineAlignBottom,pBaselineAlignBottom);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_CropToPadding = AttributeReflectionHelper.ResolveFor<Android.Widget.ImageView, System.Boolean>
        (v => v.CropToPadding);


        public static TControl CropToPadding<TControl>(this TControl component, System.Boolean pCropToPadding)  where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ImageView t = default;
                t.CropToPadding = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_CropToPadding,pCropToPadding);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ImageAlpha = AttributeReflectionHelper.ResolveFor<Android.Widget.ImageView, System.Int32>
        (v => v.ImageAlpha);


        public static TControl ImageAlpha<TControl>(this TControl component, System.Int32 pImageAlpha)  where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ImageView t = default;
                t.ImageAlpha = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ImageAlpha,pImageAlpha);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static readonly Attribute<Android.Graphics.Matrix> Attribute_Matrix_ImageMatrix = AttributeReflectionHelper.ResolveFor<Android.Widget.ImageView, Android.Graphics.Matrix>
        (v => v.ImageMatrix);


        public static TControl ImageMatrix<TControl>(this TControl component, Android.Graphics.Matrix pImageMatrix)  where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ImageView t = default;
                t.ImageMatrix = default;
            }

            component.Attributes.SetAttribute(Attribute_Matrix_ImageMatrix,pImageMatrix);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_ImageTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.ImageView, Android.Content.Res.ColorStateList>
        (v => v.ImageTintList);


        public static TControl ImageTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pImageTintList)  where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ImageView t = default;
                t.ImageTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_ImageTintList,pImageTintList);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_ImageTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.ImageView, Android.Graphics.PorterDuff.Mode>
        (v => v.ImageTintMode);


        public static TControl ImageTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pImageTintMode)  where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ImageView t = default;
                t.ImageTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_ImageTintMode,pImageTintMode);
            return component;
        }
    }


    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView>> _callExpression_ClearColorFilter_Android_Widget_ImageView_ = (view) => view.ClearColorFilter();
        public static TControl ClearColorFilter<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_ClearColorFilter_Android_Widget_ImageView_;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, System.Boolean>> _callExpression_SetAdjustViewBounds_Android_Widget_ImageView__System_Boolean = (view, param1) => view.SetAdjustViewBounds(param1);
        public static TControl SetAdjustViewBounds<TControl>(this TControl component, System.Boolean padjustViewBounds) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetAdjustViewBounds_Android_Widget_ImageView__System_Boolean;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, padjustViewBounds);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, System.Int32>> _callExpression_SetAlpha_Android_Widget_ImageView__System_Int32 = (view, param1) => view.SetAlpha(param1);
        public static TControl SetAlpha<TControl>(this TControl component, System.Int32 palpha) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetAlpha_Android_Widget_ImageView__System_Int32;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, palpha);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, System.Int32>> _callExpression_SetBaseline_Android_Widget_ImageView__System_Int32 = (view, param1) => view.SetBaseline(param1);
        public static TControl SetBaseline<TControl>(this TControl component, System.Int32 pbaseline) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetBaseline_Android_Widget_ImageView__System_Int32;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pbaseline);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, Android.Graphics.ColorFilter>> _callExpression_SetColorFilter_Android_Widget_ImageView__Android_Graphics_ColorFilter = (view, param1) => view.SetColorFilter(param1);
        public static TControl SetColorFilter<TControl>(this TControl component, Android.Graphics.ColorFilter pcf) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetColorFilter_Android_Widget_ImageView__Android_Graphics_ColorFilter;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcf);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, Android.Graphics.Color>> _callExpression_SetColorFilter_Android_Widget_ImageView__Android_Graphics_Color = (view, param1) => view.SetColorFilter(param1);
        public static TControl SetColorFilter<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetColorFilter_Android_Widget_ImageView__Android_Graphics_Color;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, Android.Graphics.Color, Android.Graphics.PorterDuff.Mode>> _callExpression_SetColorFilter_Android_Widget_ImageView__Android_Graphics_Color_Android_Graphics_PorterDuff_Mode = (view, param1, param2) => view.SetColorFilter(param1, param2);
        public static TControl SetColorFilter<TControl>(this TControl component, Android.Graphics.Color pcolor, Android.Graphics.PorterDuff.Mode pmode) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetColorFilter_Android_Widget_ImageView__Android_Graphics_Color_Android_Graphics_PorterDuff_Mode;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor, pmode);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, Android.Graphics.Bitmap>> _callExpression_SetImageBitmap_Android_Widget_ImageView__Android_Graphics_Bitmap = (view, param1) => view.SetImageBitmap(param1);
        public static TControl SetImageBitmap<TControl>(this TControl component, Android.Graphics.Bitmap pbm) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetImageBitmap_Android_Widget_ImageView__Android_Graphics_Bitmap;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pbm);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, Android.Graphics.Drawables.Drawable>> _callExpression_SetImageDrawable_Android_Widget_ImageView__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetImageDrawable(param1);
        public static TControl SetImageDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pdrawable) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetImageDrawable_Android_Widget_ImageView__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pdrawable);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, Android.Graphics.Drawables.Icon>> _callExpression_SetImageIcon_Android_Widget_ImageView__Android_Graphics_Drawables_Icon = (view, param1) => view.SetImageIcon(param1);
        public static TControl SetImageIcon<TControl>(this TControl component, Android.Graphics.Drawables.Icon picon) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetImageIcon_Android_Widget_ImageView__Android_Graphics_Drawables_Icon;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, picon);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, System.Int32>> _callExpression_SetImageLevel_Android_Widget_ImageView__System_Int32 = (view, param1) => view.SetImageLevel(param1);
        public static TControl SetImageLevel<TControl>(this TControl component, System.Int32 plevel) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetImageLevel_Android_Widget_ImageView__System_Int32;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, plevel);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, System.Int32>> _callExpression_SetImageResource_Android_Widget_ImageView__System_Int32 = (view, param1) => view.SetImageResource(param1);
        public static TControl SetImageResource<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetImageResource_Android_Widget_ImageView__System_Int32;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, System.Int32[], System.Boolean>> _callExpression_SetImageState_Android_Widget_ImageView__System_Int32__System_Boolean = (view, param1, param2) => view.SetImageState(param1, param2);
        public static TControl SetImageState<TControl>(this TControl component, System.Int32[] pstate, System.Boolean pmerge) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetImageState_Android_Widget_ImageView__System_Int32__System_Boolean;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pstate, pmerge);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, Android.Net.Uri>> _callExpression_SetImageURI_Android_Widget_ImageView__Android_Net_Uri = (view, param1) => view.SetImageURI(param1);
        public static TControl SetImageURI<TControl>(this TControl component, Android.Net.Uri puri) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetImageURI_Android_Widget_ImageView__Android_Net_Uri;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, puri);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, System.Int32>> _callExpression_SetMaxHeight_Android_Widget_ImageView__System_Int32 = (view, param1) => view.SetMaxHeight(param1);
        public static TControl SetMaxHeight<TControl>(this TControl component, System.Int32 pmaxHeight) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetMaxHeight_Android_Widget_ImageView__System_Int32;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pmaxHeight);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, System.Int32>> _callExpression_SetMaxWidth_Android_Widget_ImageView__System_Int32 = (view, param1) => view.SetMaxWidth(param1);
        public static TControl SetMaxWidth<TControl>(this TControl component, System.Int32 pmaxWidth) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetMaxWidth_Android_Widget_ImageView__System_Int32;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pmaxWidth);
            return component;
        }
    }
    public static partial class Android_Widget_ImageView_Extensions
    {
        private static Expression<Action<Android.Widget.ImageView, Android.Widget.ImageView.ScaleType>> _callExpression_SetScaleType_Android_Widget_ImageView__Android_Widget_ImageView_ScaleType = (view, param1) => view.SetScaleType(param1);
        public static TControl SetScaleType<TControl>(this TControl component, Android.Widget.ImageView.ScaleType pscaleType) where TControl:IReflectedPrimitive<Android.Widget.ImageView>
        {
            var callExpression = _callExpression_SetScaleType_Android_Widget_ImageView__Android_Widget_ImageView_ScaleType;

            Reflect<Android.Widget.ImageView>.ReflectionHelpers.Call(component.Attributes,callExpression, pscaleType);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidViewGroup<Android.Widget.LinearLayout> LinearLayout(IEnumerable<IPrimitive> children,Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.LinearLayout(default);
            }

            var control = ViewGroup<Android.Widget.LinearLayout>(children,(dimensions) => new Android.Widget.LinearLayout.LayoutParams(dimensions.Width, dimensions.Height), dimensions, id);
            return control;
        }    
    }

    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_BaselineAligned = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Boolean>
        (v => v.BaselineAligned);


        public static TControl BaselineAligned<TControl>(this TControl component, System.Boolean pBaselineAligned)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.LinearLayout t = default;
                t.BaselineAligned = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_BaselineAligned,pBaselineAligned);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_BaselineAlignedChildIndex = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Int32>
        (v => v.BaselineAlignedChildIndex);


        public static TControl BaselineAlignedChildIndex<TControl>(this TControl component, System.Int32 pBaselineAlignedChildIndex)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.LinearLayout t = default;
                t.BaselineAlignedChildIndex = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_BaselineAlignedChildIndex,pBaselineAlignedChildIndex);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DividerPadding = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Int32>
        (v => v.DividerPadding);


        public static TControl DividerPadding<TControl>(this TControl component, System.Int32 pDividerPadding)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.LinearLayout t = default;
                t.DividerPadding = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DividerPadding,pDividerPadding);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_MeasureWithLargestChildEnabled = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Boolean>
        (v => v.MeasureWithLargestChildEnabled);


        public static TControl MeasureWithLargestChildEnabled<TControl>(this TControl component, System.Boolean pMeasureWithLargestChildEnabled)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.LinearLayout t = default;
                t.MeasureWithLargestChildEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_MeasureWithLargestChildEnabled,pMeasureWithLargestChildEnabled);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<Android.Widget.Orientation> Attribute_Orientation_Orientation = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, Android.Widget.Orientation>
        (v => v.Orientation);


        public static TControl Orientation<TControl>(this TControl component, Android.Widget.Orientation pOrientation)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.LinearLayout t = default;
                t.Orientation = default;
            }

            component.Attributes.SetAttribute(Attribute_Orientation_Orientation,pOrientation);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<Android.Widget.ShowDividers> Attribute_ShowDividers_ShowDividers = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, Android.Widget.ShowDividers>
        (v => v.ShowDividers);


        public static TControl ShowDividers<TControl>(this TControl component, Android.Widget.ShowDividers pShowDividers)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.LinearLayout t = default;
                t.ShowDividers = default;
            }

            component.Attributes.SetAttribute(Attribute_ShowDividers_ShowDividers,pShowDividers);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_WeightSum = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Single>
        (v => v.WeightSum);


        public static TControl WeightSum<TControl>(this TControl component, System.Single pWeightSum)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.LinearLayout t = default;
                t.WeightSum = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_WeightSum,pWeightSum);
            return component;
        }
    }


    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static Expression<Action<Android.Widget.LinearLayout, Android.Graphics.Drawables.Drawable>> _callExpression_SetDividerDrawable_Android_Widget_LinearLayout__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetDividerDrawable(param1);
        public static TControl SetDividerDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pdivider) where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            var callExpression = _callExpression_SetDividerDrawable_Android_Widget_LinearLayout__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.LinearLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, pdivider);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static Expression<Action<Android.Widget.LinearLayout, Android.Views.GravityFlags>> _callExpression_SetGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags = (view, param1) => view.SetGravity(param1);
        public static TControl SetGravity<TControl>(this TControl component, Android.Views.GravityFlags pgravity) where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            var callExpression = _callExpression_SetGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.LinearLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, pgravity);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static Expression<Action<Android.Widget.LinearLayout, Android.Views.GravityFlags>> _callExpression_SetHorizontalGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags = (view, param1) => view.SetHorizontalGravity(param1);
        public static TControl SetHorizontalGravity<TControl>(this TControl component, Android.Views.GravityFlags phorizontalGravity) where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            var callExpression = _callExpression_SetHorizontalGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.LinearLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, phorizontalGravity);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static Expression<Action<Android.Widget.LinearLayout, Android.Views.GravityFlags>> _callExpression_SetVerticalGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags = (view, param1) => view.SetVerticalGravity(param1);
        public static TControl SetVerticalGravity<TControl>(this TControl component, Android.Views.GravityFlags pverticalGravity) where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            var callExpression = _callExpression_SetVerticalGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.LinearLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, pverticalGravity);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.MultiAutoCompleteTextView> MultiAutoCompleteTextView(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.MultiAutoCompleteTextView(default);
            }

            var control = View<Android.Widget.MultiAutoCompleteTextView>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Android_Widget_MultiAutoCompleteTextView_Extensions
    {
        private static Expression<Action<Android.Widget.MultiAutoCompleteTextView, Android.Widget.MultiAutoCompleteTextView.ITokenizer>> _callExpression_SetTokenizer_Android_Widget_MultiAutoCompleteTextView__Android_Widget_MultiAutoCompleteTextView_ITokenizer = (view, param1) => view.SetTokenizer(param1);
        public static TControl SetTokenizer<TControl>(this TControl component, Android.Widget.MultiAutoCompleteTextView.ITokenizer pt) where TControl:IReflectedPrimitive<Android.Widget.MultiAutoCompleteTextView>
        {
            var callExpression = _callExpression_SetTokenizer_Android_Widget_MultiAutoCompleteTextView__Android_Widget_MultiAutoCompleteTextView_ITokenizer;

            Reflect<Android.Widget.MultiAutoCompleteTextView>.ReflectionHelpers.Call(component.Attributes,callExpression, pt);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.NumberPicker> NumberPicker(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.NumberPicker(default);
            }

            var control = View<Android.Widget.NumberPicker>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_NumberPicker_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_MaxValue = AttributeReflectionHelper.ResolveFor<Android.Widget.NumberPicker, System.Int32>
        (v => v.MaxValue);


        public static TControl MaxValue<TControl>(this TControl component, System.Int32 pMaxValue)  where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.NumberPicker t = default;
                t.MaxValue = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_MaxValue,pMaxValue);
            return component;
        }
    }
    public static partial class Android_Widget_NumberPicker_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_MinValue = AttributeReflectionHelper.ResolveFor<Android.Widget.NumberPicker, System.Int32>
        (v => v.MinValue);


        public static TControl MinValue<TControl>(this TControl component, System.Int32 pMinValue)  where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.NumberPicker t = default;
                t.MinValue = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_MinValue,pMinValue);
            return component;
        }
    }
    public static partial class Android_Widget_NumberPicker_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Value = AttributeReflectionHelper.ResolveFor<Android.Widget.NumberPicker, System.Int32>
        (v => v.Value);


        public static TControl Value<TControl>(this TControl component, System.Int32 pValue)  where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.NumberPicker t = default;
                t.Value = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Value,pValue);
            return component;
        }
    }
    public static partial class Android_Widget_NumberPicker_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_WrapSelectorWheel = AttributeReflectionHelper.ResolveFor<Android.Widget.NumberPicker, System.Boolean>
        (v => v.WrapSelectorWheel);


        public static TControl WrapSelectorWheel<TControl>(this TControl component, System.Boolean pWrapSelectorWheel)  where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.NumberPicker t = default;
                t.WrapSelectorWheel = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_WrapSelectorWheel,pWrapSelectorWheel);
            return component;
        }
    }

public static partial class Android_Widget_NumberPicker_Extensions
{
    public static TControl OnScroll<TControl>(this TControl control,Action<Android.Widget.NumberPicker.ScrollEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.NumberPicker tv = null;

            tv.Scroll += handler;
            tv.Scroll -= handler;
        }

        control.Event(x => nameof(x.Scroll),action);
        return control;
    }
}
public static partial class Android_Widget_NumberPicker_Extensions
{
    public static TControl OnValueChanged<TControl>(this TControl control,Action<Android.Widget.NumberPicker.ValueChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.NumberPicker tv = null;

            tv.ValueChanged += handler;
            tv.ValueChanged -= handler;
        }

        control.Event(x => nameof(x.ValueChanged),action);
        return control;
    }
}

    public static partial class Android_Widget_NumberPicker_Extensions
    {
        private static Expression<Action<Android.Widget.NumberPicker, System.String[]>> _callExpression_SetDisplayedValues_Android_Widget_NumberPicker__System_String_ = (view, param1) => view.SetDisplayedValues(param1);
        public static TControl SetDisplayedValues<TControl>(this TControl component, System.String[] pdisplayedValues) where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
        {
            var callExpression = _callExpression_SetDisplayedValues_Android_Widget_NumberPicker__System_String_;

            Reflect<Android.Widget.NumberPicker>.ReflectionHelpers.Call(component.Attributes,callExpression, pdisplayedValues);
            return component;
        }
    }
    public static partial class Android_Widget_NumberPicker_Extensions
    {
        private static Expression<Action<Android.Widget.NumberPicker, Android.Widget.NumberPicker.IFormatter>> _callExpression_SetFormatter_Android_Widget_NumberPicker__Android_Widget_NumberPicker_IFormatter = (view, param1) => view.SetFormatter(param1);
        public static TControl SetFormatter<TControl>(this TControl component, Android.Widget.NumberPicker.IFormatter pformatter) where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
        {
            var callExpression = _callExpression_SetFormatter_Android_Widget_NumberPicker__Android_Widget_NumberPicker_IFormatter;

            Reflect<Android.Widget.NumberPicker>.ReflectionHelpers.Call(component.Attributes,callExpression, pformatter);
            return component;
        }
    }
    public static partial class Android_Widget_NumberPicker_Extensions
    {
        private static Expression<Action<Android.Widget.NumberPicker, System.Int64>> _callExpression_SetOnLongPressUpdateInterval_Android_Widget_NumberPicker__System_Int64 = (view, param1) => view.SetOnLongPressUpdateInterval(param1);
        public static TControl SetOnLongPressUpdateInterval<TControl>(this TControl component, System.Int64 pintervalMillis) where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
        {
            var callExpression = _callExpression_SetOnLongPressUpdateInterval_Android_Widget_NumberPicker__System_Int64;

            Reflect<Android.Widget.NumberPicker>.ReflectionHelpers.Call(component.Attributes,callExpression, pintervalMillis);
            return component;
        }
    }
    public static partial class Android_Widget_NumberPicker_Extensions
    {
        private static Expression<Action<Android.Widget.NumberPicker, Android.Widget.NumberPicker.IOnScrollListener>> _callExpression_SetOnScrollListener_Android_Widget_NumberPicker__Android_Widget_NumberPicker_IOnScrollListener = (view, param1) => view.SetOnScrollListener(param1);
        public static TControl SetOnScrollListener<TControl>(this TControl component, Android.Widget.NumberPicker.IOnScrollListener ponScrollListener) where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
        {
            var callExpression = _callExpression_SetOnScrollListener_Android_Widget_NumberPicker__Android_Widget_NumberPicker_IOnScrollListener;

            Reflect<Android.Widget.NumberPicker>.ReflectionHelpers.Call(component.Attributes,callExpression, ponScrollListener);
            return component;
        }
    }
    public static partial class Android_Widget_NumberPicker_Extensions
    {
        private static Expression<Action<Android.Widget.NumberPicker, Android.Widget.NumberPicker.IOnValueChangeListener>> _callExpression_SetOnValueChangedListener_Android_Widget_NumberPicker__Android_Widget_NumberPicker_IOnValueChangeListener = (view, param1) => view.SetOnValueChangedListener(param1);
        public static TControl SetOnValueChangedListener<TControl>(this TControl component, Android.Widget.NumberPicker.IOnValueChangeListener ponValueChangedListener) where TControl:IReflectedPrimitive<Android.Widget.NumberPicker>
        {
            var callExpression = _callExpression_SetOnValueChangedListener_Android_Widget_NumberPicker__Android_Widget_NumberPicker_IOnValueChangeListener;

            Reflect<Android.Widget.NumberPicker>.ReflectionHelpers.Call(component.Attributes,callExpression, ponValueChangedListener);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.ProgressBar> ProgressBar(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.ProgressBar(default);
            }

            var control = View<Android.Widget.ProgressBar>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Indeterminate = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, System.Boolean>
        (v => v.Indeterminate);


        public static TControl Indeterminate<TControl>(this TControl component, System.Boolean pIndeterminate)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.Indeterminate = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Indeterminate,pIndeterminate);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_IndeterminateDrawable = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Graphics.Drawables.Drawable>
        (v => v.IndeterminateDrawable);


        public static TControl IndeterminateDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pIndeterminateDrawable)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.IndeterminateDrawable = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_IndeterminateDrawable,pIndeterminateDrawable);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_IndeterminateTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Content.Res.ColorStateList>
        (v => v.IndeterminateTintList);


        public static TControl IndeterminateTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pIndeterminateTintList)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.IndeterminateTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_IndeterminateTintList,pIndeterminateTintList);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_IndeterminateTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Graphics.PorterDuff.Mode>
        (v => v.IndeterminateTintMode);


        public static TControl IndeterminateTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pIndeterminateTintMode)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.IndeterminateTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_IndeterminateTintMode,pIndeterminateTintMode);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Views.Animations.IInterpolator> Attribute_IInterpolator_Interpolator = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Views.Animations.IInterpolator>
        (v => v.Interpolator);


        public static TControl Interpolator<TControl>(this TControl component, Android.Views.Animations.IInterpolator pInterpolator)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.Interpolator = default;
            }

            component.Attributes.SetAttribute(Attribute_IInterpolator_Interpolator,pInterpolator);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Max = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, System.Int32>
        (v => v.Max);


        public static TControl Max<TControl>(this TControl component, System.Int32 pMax)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.Max = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Max,pMax);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Min = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, System.Int32>
        (v => v.Min);


        public static TControl Min<TControl>(this TControl component, System.Int32 pMin)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.Min = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Min,pMin);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Progress = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, System.Int32>
        (v => v.Progress);


        public static TControl Progress<TControl>(this TControl component, System.Int32 pProgress)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.Progress = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Progress,pProgress);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_ProgressBackgroundTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Content.Res.ColorStateList>
        (v => v.ProgressBackgroundTintList);


        public static TControl ProgressBackgroundTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pProgressBackgroundTintList)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.ProgressBackgroundTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_ProgressBackgroundTintList,pProgressBackgroundTintList);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_ProgressBackgroundTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Graphics.PorterDuff.Mode>
        (v => v.ProgressBackgroundTintMode);


        public static TControl ProgressBackgroundTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pProgressBackgroundTintMode)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.ProgressBackgroundTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_ProgressBackgroundTintMode,pProgressBackgroundTintMode);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_ProgressDrawable = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Graphics.Drawables.Drawable>
        (v => v.ProgressDrawable);


        public static TControl ProgressDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pProgressDrawable)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.ProgressDrawable = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_ProgressDrawable,pProgressDrawable);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_ProgressTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Content.Res.ColorStateList>
        (v => v.ProgressTintList);


        public static TControl ProgressTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pProgressTintList)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.ProgressTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_ProgressTintList,pProgressTintList);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_ProgressTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Graphics.PorterDuff.Mode>
        (v => v.ProgressTintMode);


        public static TControl ProgressTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pProgressTintMode)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.ProgressTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_ProgressTintMode,pProgressTintMode);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_SecondaryProgress = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, System.Int32>
        (v => v.SecondaryProgress);


        public static TControl SecondaryProgress<TControl>(this TControl component, System.Int32 pSecondaryProgress)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.SecondaryProgress = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_SecondaryProgress,pSecondaryProgress);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_SecondaryProgressTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Content.Res.ColorStateList>
        (v => v.SecondaryProgressTintList);


        public static TControl SecondaryProgressTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pSecondaryProgressTintList)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.SecondaryProgressTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_SecondaryProgressTintList,pSecondaryProgressTintList);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_SecondaryProgressTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.ProgressBar, Android.Graphics.PorterDuff.Mode>
        (v => v.SecondaryProgressTintMode);


        public static TControl SecondaryProgressTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pSecondaryProgressTintMode)  where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ProgressBar t = default;
                t.SecondaryProgressTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_SecondaryProgressTintMode,pSecondaryProgressTintMode);
            return component;
        }
    }


    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static Expression<Action<Android.Widget.ProgressBar, System.Int32>> _callExpression_IncrementProgressBy_Android_Widget_ProgressBar__System_Int32 = (view, param1) => view.IncrementProgressBy(param1);
        public static TControl IncrementProgressBy<TControl>(this TControl component, System.Int32 pdiff) where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            var callExpression = _callExpression_IncrementProgressBy_Android_Widget_ProgressBar__System_Int32;

            Reflect<Android.Widget.ProgressBar>.ReflectionHelpers.Call(component.Attributes,callExpression, pdiff);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static Expression<Action<Android.Widget.ProgressBar, System.Int32>> _callExpression_IncrementSecondaryProgressBy_Android_Widget_ProgressBar__System_Int32 = (view, param1) => view.IncrementSecondaryProgressBy(param1);
        public static TControl IncrementSecondaryProgressBy<TControl>(this TControl component, System.Int32 pdiff) where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            var callExpression = _callExpression_IncrementSecondaryProgressBy_Android_Widget_ProgressBar__System_Int32;

            Reflect<Android.Widget.ProgressBar>.ReflectionHelpers.Call(component.Attributes,callExpression, pdiff);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static Expression<Action<Android.Widget.ProgressBar, Android.Graphics.Drawables.Drawable>> _callExpression_SetIndeterminateDrawableTiled_Android_Widget_ProgressBar__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetIndeterminateDrawableTiled(param1);
        public static TControl SetIndeterminateDrawableTiled<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pd) where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            var callExpression = _callExpression_SetIndeterminateDrawableTiled_Android_Widget_ProgressBar__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.ProgressBar>.ReflectionHelpers.Call(component.Attributes,callExpression, pd);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static Expression<Action<Android.Widget.ProgressBar, Android.Content.Context, System.Int32>> _callExpression_SetInterpolator_Android_Widget_ProgressBar__Android_Content_Context_System_Int32 = (view, param1, param2) => view.SetInterpolator(param1, param2);
        public static TControl SetInterpolator<TControl>(this TControl component, Android.Content.Context pcontext, System.Int32 presID) where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            var callExpression = _callExpression_SetInterpolator_Android_Widget_ProgressBar__Android_Content_Context_System_Int32;

            Reflect<Android.Widget.ProgressBar>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontext, presID);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static Expression<Action<Android.Widget.ProgressBar, System.Int32, System.Boolean>> _callExpression_SetProgress_Android_Widget_ProgressBar__System_Int32_System_Boolean = (view, param1, param2) => view.SetProgress(param1, param2);
        public static TControl SetProgress<TControl>(this TControl component, System.Int32 pprogress, System.Boolean panimate) where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            var callExpression = _callExpression_SetProgress_Android_Widget_ProgressBar__System_Int32_System_Boolean;

            Reflect<Android.Widget.ProgressBar>.ReflectionHelpers.Call(component.Attributes,callExpression, pprogress, panimate);
            return component;
        }
    }
    public static partial class Android_Widget_ProgressBar_Extensions
    {
        private static Expression<Action<Android.Widget.ProgressBar, Android.Graphics.Drawables.Drawable>> _callExpression_SetProgressDrawableTiled_Android_Widget_ProgressBar__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetProgressDrawableTiled(param1);
        public static TControl SetProgressDrawableTiled<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pd) where TControl:IReflectedPrimitive<Android.Widget.ProgressBar>
        {
            var callExpression = _callExpression_SetProgressDrawableTiled_Android_Widget_ProgressBar__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.ProgressBar>.ReflectionHelpers.Call(component.Attributes,callExpression, pd);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.QuickContactBadge> QuickContactBadge(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.QuickContactBadge(default);
            }

            var control = View<Android.Widget.QuickContactBadge>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge, System.String, System.Boolean>> _callExpression_AssignContactFromEmail_Android_Widget_QuickContactBadge__System_String_System_Boolean = (view, param1, param2) => view.AssignContactFromEmail(param1, param2);
        public static TControl AssignContactFromEmail<TControl>(this TControl component, System.String pemailAddress, System.Boolean plazyLookup) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_AssignContactFromEmail_Android_Widget_QuickContactBadge__System_String_System_Boolean;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression, pemailAddress, plazyLookup);
            return component;
        }
    }
    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge, System.String, System.Boolean, Android.OS.Bundle>> _callExpression_AssignContactFromEmail_Android_Widget_QuickContactBadge__System_String_System_Boolean_Android_OS_Bundle = (view, param1, param2, param3) => view.AssignContactFromEmail(param1, param2, param3);
        public static TControl AssignContactFromEmail<TControl>(this TControl component, System.String pemailAddress, System.Boolean plazyLookup, Android.OS.Bundle pextras) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_AssignContactFromEmail_Android_Widget_QuickContactBadge__System_String_System_Boolean_Android_OS_Bundle;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression, pemailAddress, plazyLookup, pextras);
            return component;
        }
    }
    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge, System.String, System.Boolean>> _callExpression_AssignContactFromPhone_Android_Widget_QuickContactBadge__System_String_System_Boolean = (view, param1, param2) => view.AssignContactFromPhone(param1, param2);
        public static TControl AssignContactFromPhone<TControl>(this TControl component, System.String pphoneNumber, System.Boolean plazyLookup) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_AssignContactFromPhone_Android_Widget_QuickContactBadge__System_String_System_Boolean;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression, pphoneNumber, plazyLookup);
            return component;
        }
    }
    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge, System.String, System.Boolean, Android.OS.Bundle>> _callExpression_AssignContactFromPhone_Android_Widget_QuickContactBadge__System_String_System_Boolean_Android_OS_Bundle = (view, param1, param2, param3) => view.AssignContactFromPhone(param1, param2, param3);
        public static TControl AssignContactFromPhone<TControl>(this TControl component, System.String pphoneNumber, System.Boolean plazyLookup, Android.OS.Bundle pextras) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_AssignContactFromPhone_Android_Widget_QuickContactBadge__System_String_System_Boolean_Android_OS_Bundle;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression, pphoneNumber, plazyLookup, pextras);
            return component;
        }
    }
    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge, Android.Net.Uri>> _callExpression_AssignContactUri_Android_Widget_QuickContactBadge__Android_Net_Uri = (view, param1) => view.AssignContactUri(param1);
        public static TControl AssignContactUri<TControl>(this TControl component, Android.Net.Uri pcontactUri) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_AssignContactUri_Android_Widget_QuickContactBadge__Android_Net_Uri;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontactUri);
            return component;
        }
    }
    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge, System.String[]>> _callExpression_SetExcludeMimes_Android_Widget_QuickContactBadge__System_String_ = (view, param1) => view.SetExcludeMimes(param1);
        public static TControl SetExcludeMimes<TControl>(this TControl component, System.String[] pexcludeMimes) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_SetExcludeMimes_Android_Widget_QuickContactBadge__System_String_;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression, pexcludeMimes);
            return component;
        }
    }
    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge>> _callExpression_SetImageToDefault_Android_Widget_QuickContactBadge_ = (view) => view.SetImageToDefault();
        public static TControl SetImageToDefault<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_SetImageToDefault_Android_Widget_QuickContactBadge_;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge, System.Int32>> _callExpression_SetMode_Android_Widget_QuickContactBadge__System_Int32 = (view, param1) => view.SetMode(param1);
        public static TControl SetMode<TControl>(this TControl component, System.Int32 psize) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_SetMode_Android_Widget_QuickContactBadge__System_Int32;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression, psize);
            return component;
        }
    }
    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge, Android.Graphics.Drawables.Drawable>> _callExpression_SetOverlay_Android_Widget_QuickContactBadge__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetOverlay(param1);
        public static TControl SetOverlay<TControl>(this TControl component, Android.Graphics.Drawables.Drawable poverlay) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_SetOverlay_Android_Widget_QuickContactBadge__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression, poverlay);
            return component;
        }
    }
    public static partial class Android_Widget_QuickContactBadge_Extensions
    {
        private static Expression<Action<Android.Widget.QuickContactBadge, System.String>> _callExpression_SetPrioritizedMimeType_Android_Widget_QuickContactBadge__System_String = (view, param1) => view.SetPrioritizedMimeType(param1);
        public static TControl SetPrioritizedMimeType<TControl>(this TControl component, System.String pprioritizedMimeType) where TControl:IReflectedPrimitive<Android.Widget.QuickContactBadge>
        {
            var callExpression = _callExpression_SetPrioritizedMimeType_Android_Widget_QuickContactBadge__System_String;

            Reflect<Android.Widget.QuickContactBadge>.ReflectionHelpers.Call(component.Attributes,callExpression, pprioritizedMimeType);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.RadioButton> RadioButton(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.RadioButton(default);
            }

            var control = View<Android.Widget.RadioButton>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.RadioGroup> RadioGroup(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.RadioGroup(default);
            }

            var control = View<Android.Widget.RadioGroup>(dimensions:dimensions,id:id);
            return control;
        }    
    }


public static partial class Android_Widget_RadioGroup_Extensions
{
    public static TControl OnCheckedChange<TControl>(this TControl control,Action<Android.Widget.RadioGroup.CheckedChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.RadioGroup>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.RadioGroup tv = null;

            tv.CheckedChange += handler;
            tv.CheckedChange -= handler;
        }

        control.Event(x => nameof(x.CheckedChange),action);
        return control;
    }
}

    public static partial class Android_Widget_RadioGroup_Extensions
    {
        private static Expression<Action<Android.Widget.RadioGroup, System.Int32>> _callExpression_Check_Android_Widget_RadioGroup__System_Int32 = (view, param1) => view.Check(param1);
        public static TControl Check<TControl>(this TControl component, System.Int32 pid) where TControl:IReflectedPrimitive<Android.Widget.RadioGroup>
        {
            var callExpression = _callExpression_Check_Android_Widget_RadioGroup__System_Int32;

            Reflect<Android.Widget.RadioGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pid);
            return component;
        }
    }
    public static partial class Android_Widget_RadioGroup_Extensions
    {
        private static Expression<Action<Android.Widget.RadioGroup>> _callExpression_ClearCheck_Android_Widget_RadioGroup_ = (view) => view.ClearCheck();
        public static TControl ClearCheck<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.RadioGroup>
        {
            var callExpression = _callExpression_ClearCheck_Android_Widget_RadioGroup_;

            Reflect<Android.Widget.RadioGroup>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_RadioGroup_Extensions
    {
        private static Expression<Action<Android.Widget.RadioGroup, Android.Widget.RadioGroup.IOnCheckedChangeListener>> _callExpression_SetOnCheckedChangeListener_Android_Widget_RadioGroup__Android_Widget_RadioGroup_IOnCheckedChangeListener = (view, param1) => view.SetOnCheckedChangeListener(param1);
        public static TControl SetOnCheckedChangeListener<TControl>(this TControl component, Android.Widget.RadioGroup.IOnCheckedChangeListener plistener) where TControl:IReflectedPrimitive<Android.Widget.RadioGroup>
        {
            var callExpression = _callExpression_SetOnCheckedChangeListener_Android_Widget_RadioGroup__Android_Widget_RadioGroup_IOnCheckedChangeListener;

            Reflect<Android.Widget.RadioGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.RatingBar> RatingBar(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.RatingBar(default);
            }

            var control = View<Android.Widget.RatingBar>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_RatingBar_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_IsIndicator = AttributeReflectionHelper.ResolveFor<Android.Widget.RatingBar, System.Boolean>
        (v => v.IsIndicator);


        public static TControl IsIndicator<TControl>(this TControl component, System.Boolean pIsIndicator)  where TControl:IReflectedPrimitive<Android.Widget.RatingBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.RatingBar t = default;
                t.IsIndicator = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_IsIndicator,pIsIndicator);
            return component;
        }
    }
    public static partial class Android_Widget_RatingBar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_NumStars = AttributeReflectionHelper.ResolveFor<Android.Widget.RatingBar, System.Int32>
        (v => v.NumStars);


        public static TControl NumStars<TControl>(this TControl component, System.Int32 pNumStars)  where TControl:IReflectedPrimitive<Android.Widget.RatingBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.RatingBar t = default;
                t.NumStars = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_NumStars,pNumStars);
            return component;
        }
    }
    public static partial class Android_Widget_RatingBar_Extensions
    {
        private static readonly Attribute<Android.Widget.RatingBar.IOnRatingBarChangeListener> Attribute_IOnRatingBarChangeListener_OnRatingBarChangeListener = AttributeReflectionHelper.ResolveFor<Android.Widget.RatingBar, Android.Widget.RatingBar.IOnRatingBarChangeListener>
        (v => v.OnRatingBarChangeListener);


        public static TControl OnRatingBarChangeListener<TControl>(this TControl component, Android.Widget.RatingBar.IOnRatingBarChangeListener pOnRatingBarChangeListener)  where TControl:IReflectedPrimitive<Android.Widget.RatingBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.RatingBar t = default;
                t.OnRatingBarChangeListener = default;
            }

            component.Attributes.SetAttribute(Attribute_IOnRatingBarChangeListener_OnRatingBarChangeListener,pOnRatingBarChangeListener);
            return component;
        }
    }
    public static partial class Android_Widget_RatingBar_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_Rating = AttributeReflectionHelper.ResolveFor<Android.Widget.RatingBar, System.Single>
        (v => v.Rating);


        public static TControl Rating<TControl>(this TControl component, System.Single pRating)  where TControl:IReflectedPrimitive<Android.Widget.RatingBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.RatingBar t = default;
                t.Rating = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_Rating,pRating);
            return component;
        }
    }
    public static partial class Android_Widget_RatingBar_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_StepSize = AttributeReflectionHelper.ResolveFor<Android.Widget.RatingBar, System.Single>
        (v => v.StepSize);


        public static TControl StepSize<TControl>(this TControl component, System.Single pStepSize)  where TControl:IReflectedPrimitive<Android.Widget.RatingBar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.RatingBar t = default;
                t.StepSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_StepSize,pStepSize);
            return component;
        }
    }

public static partial class Android_Widget_RatingBar_Extensions
{
    public static TControl OnRatingBarChange<TControl>(this TControl control,Action<Android.Widget.RatingBar.RatingBarChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.RatingBar>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.RatingBar tv = null;

            tv.RatingBarChange += handler;
            tv.RatingBarChange -= handler;
        }

        control.Event(x => nameof(x.RatingBarChange),action);
        return control;
    }
}

    public static partial class Primitives
    {
        public static AndroidViewGroup<Android.Widget.RelativeLayout> RelativeLayout(IEnumerable<IPrimitive> children,Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.RelativeLayout(default);
            }

            var control = ViewGroup<Android.Widget.RelativeLayout>(children,(dimensions) => new Android.Widget.RelativeLayout.LayoutParams(dimensions.Width, dimensions.Height), dimensions, id);
            return control;
        }    
    }



    public static partial class Android_Widget_RelativeLayout_Extensions
    {
        private static Expression<Action<Android.Widget.RelativeLayout, Android.Views.GravityFlags>> _callExpression_SetGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags = (view, param1) => view.SetGravity(param1);
        public static TControl SetGravity<TControl>(this TControl component, Android.Views.GravityFlags pgravity) where TControl:IReflectedPrimitive<Android.Widget.RelativeLayout>
        {
            var callExpression = _callExpression_SetGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.RelativeLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, pgravity);
            return component;
        }
    }
    public static partial class Android_Widget_RelativeLayout_Extensions
    {
        private static Expression<Action<Android.Widget.RelativeLayout, Android.Views.GravityFlags>> _callExpression_SetHorizontalGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags = (view, param1) => view.SetHorizontalGravity(param1);
        public static TControl SetHorizontalGravity<TControl>(this TControl component, Android.Views.GravityFlags phorizontalGravity) where TControl:IReflectedPrimitive<Android.Widget.RelativeLayout>
        {
            var callExpression = _callExpression_SetHorizontalGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.RelativeLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, phorizontalGravity);
            return component;
        }
    }
    public static partial class Android_Widget_RelativeLayout_Extensions
    {
        private static Expression<Action<Android.Widget.RelativeLayout, System.Int32>> _callExpression_SetIgnoreGravity_Android_Widget_RelativeLayout__System_Int32 = (view, param1) => view.SetIgnoreGravity(param1);
        public static TControl SetIgnoreGravity<TControl>(this TControl component, System.Int32 pviewId) where TControl:IReflectedPrimitive<Android.Widget.RelativeLayout>
        {
            var callExpression = _callExpression_SetIgnoreGravity_Android_Widget_RelativeLayout__System_Int32;

            Reflect<Android.Widget.RelativeLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, pviewId);
            return component;
        }
    }
    public static partial class Android_Widget_RelativeLayout_Extensions
    {
        private static Expression<Action<Android.Widget.RelativeLayout, Android.Views.GravityFlags>> _callExpression_SetVerticalGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags = (view, param1) => view.SetVerticalGravity(param1);
        public static TControl SetVerticalGravity<TControl>(this TControl component, Android.Views.GravityFlags pverticalGravity) where TControl:IReflectedPrimitive<Android.Widget.RelativeLayout>
        {
            var callExpression = _callExpression_SetVerticalGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.RelativeLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, pverticalGravity);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.ScrollView> ScrollView(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.ScrollView(default);
            }

            var control = View<Android.Widget.ScrollView>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_ScrollView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_FillViewport = AttributeReflectionHelper.ResolveFor<Android.Widget.ScrollView, System.Boolean>
        (v => v.FillViewport);


        public static TControl FillViewport<TControl>(this TControl component, System.Boolean pFillViewport)  where TControl:IReflectedPrimitive<Android.Widget.ScrollView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ScrollView t = default;
                t.FillViewport = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_FillViewport,pFillViewport);
            return component;
        }
    }
    public static partial class Android_Widget_ScrollView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_SmoothScrollingEnabled = AttributeReflectionHelper.ResolveFor<Android.Widget.ScrollView, System.Boolean>
        (v => v.SmoothScrollingEnabled);


        public static TControl SmoothScrollingEnabled<TControl>(this TControl component, System.Boolean pSmoothScrollingEnabled)  where TControl:IReflectedPrimitive<Android.Widget.ScrollView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ScrollView t = default;
                t.SmoothScrollingEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_SmoothScrollingEnabled,pSmoothScrollingEnabled);
            return component;
        }
    }


    public static partial class Android_Widget_ScrollView_Extensions
    {
        private static Expression<Action<Android.Widget.ScrollView, System.Int32>> _callExpression_Fling_Android_Widget_ScrollView__System_Int32 = (view, param1) => view.Fling(param1);
        public static TControl Fling<TControl>(this TControl component, System.Int32 pvelocityY) where TControl:IReflectedPrimitive<Android.Widget.ScrollView>
        {
            var callExpression = _callExpression_Fling_Android_Widget_ScrollView__System_Int32;

            Reflect<Android.Widget.ScrollView>.ReflectionHelpers.Call(component.Attributes,callExpression, pvelocityY);
            return component;
        }
    }
    public static partial class Android_Widget_ScrollView_Extensions
    {
        private static Expression<Action<Android.Widget.ScrollView, System.Int32, System.Int32>> _callExpression_SmoothScrollBy_Android_Widget_ScrollView__System_Int32_System_Int32 = (view, param1, param2) => view.SmoothScrollBy(param1, param2);
        public static TControl SmoothScrollBy<TControl>(this TControl component, System.Int32 pdx, System.Int32 pdy) where TControl:IReflectedPrimitive<Android.Widget.ScrollView>
        {
            var callExpression = _callExpression_SmoothScrollBy_Android_Widget_ScrollView__System_Int32_System_Int32;

            Reflect<Android.Widget.ScrollView>.ReflectionHelpers.Call(component.Attributes,callExpression, pdx, pdy);
            return component;
        }
    }
    public static partial class Android_Widget_ScrollView_Extensions
    {
        private static Expression<Action<Android.Widget.ScrollView, System.Int32, System.Int32>> _callExpression_SmoothScrollTo_Android_Widget_ScrollView__System_Int32_System_Int32 = (view, param1, param2) => view.SmoothScrollTo(param1, param2);
        public static TControl SmoothScrollTo<TControl>(this TControl component, System.Int32 px, System.Int32 py) where TControl:IReflectedPrimitive<Android.Widget.ScrollView>
        {
            var callExpression = _callExpression_SmoothScrollTo_Android_Widget_ScrollView__System_Int32_System_Int32;

            Reflect<Android.Widget.ScrollView>.ReflectionHelpers.Call(component.Attributes,callExpression, px, py);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.SearchView> SearchView(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.SearchView(default);
            }

            var control = View<Android.Widget.SearchView>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_SearchView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Iconified = AttributeReflectionHelper.ResolveFor<Android.Widget.SearchView, System.Boolean>
        (v => v.Iconified);


        public static TControl Iconified<TControl>(this TControl component, System.Boolean pIconified)  where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.SearchView t = default;
                t.Iconified = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Iconified,pIconified);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_QueryRefinementEnabled = AttributeReflectionHelper.ResolveFor<Android.Widget.SearchView, System.Boolean>
        (v => v.QueryRefinementEnabled);


        public static TControl QueryRefinementEnabled<TControl>(this TControl component, System.Boolean pQueryRefinementEnabled)  where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.SearchView t = default;
                t.QueryRefinementEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_QueryRefinementEnabled,pQueryRefinementEnabled);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_SubmitButtonEnabled = AttributeReflectionHelper.ResolveFor<Android.Widget.SearchView, System.Boolean>
        (v => v.SubmitButtonEnabled);


        public static TControl SubmitButtonEnabled<TControl>(this TControl component, System.Boolean pSubmitButtonEnabled)  where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.SearchView t = default;
                t.SubmitButtonEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_SubmitButtonEnabled,pSubmitButtonEnabled);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static readonly Attribute<Android.Widget.CursorAdapter> Attribute_CursorAdapter_SuggestionsAdapter = AttributeReflectionHelper.ResolveFor<Android.Widget.SearchView, Android.Widget.CursorAdapter>
        (v => v.SuggestionsAdapter);


        public static TControl SuggestionsAdapter<TControl>(this TControl component, Android.Widget.CursorAdapter pSuggestionsAdapter)  where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.SearchView t = default;
                t.SuggestionsAdapter = default;
            }

            component.Attributes.SetAttribute(Attribute_CursorAdapter_SuggestionsAdapter,pSuggestionsAdapter);
            return component;
        }
    }

public static partial class Android_Widget_SearchView_Extensions
{
    public static TControl OnClose<TControl>(this TControl control,Action<Android.Widget.SearchView.CloseEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SearchView tv = null;

            tv.Close += handler;
            tv.Close -= handler;
        }

        control.Event(x => nameof(x.Close),action);
        return control;
    }
}
public static partial class Android_Widget_SearchView_Extensions
{
    public static TControl OnQueryTextFocusChange<TControl>(this TControl control,Action<Android.Views.View.FocusChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SearchView tv = null;

            tv.QueryTextFocusChange += handler;
            tv.QueryTextFocusChange -= handler;
        }

        control.Event(x => nameof(x.QueryTextFocusChange),action);
        return control;
    }
}
public static partial class Android_Widget_SearchView_Extensions
{
    public static TControl OnQueryTextChange<TControl>(this TControl control,Action<Android.Widget.SearchView.QueryTextChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SearchView tv = null;

            tv.QueryTextChange += handler;
            tv.QueryTextChange -= handler;
        }

        control.Event(x => nameof(x.QueryTextChange),action);
        return control;
    }
}
public static partial class Android_Widget_SearchView_Extensions
{
    public static TControl OnQueryTextSubmit<TControl>(this TControl control,Action<Android.Widget.SearchView.QueryTextSubmitEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SearchView tv = null;

            tv.QueryTextSubmit += handler;
            tv.QueryTextSubmit -= handler;
        }

        control.Event(x => nameof(x.QueryTextSubmit),action);
        return control;
    }
}
public static partial class Android_Widget_SearchView_Extensions
{
    public static TControl OnSearchClick<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SearchView tv = null;

            tv.SearchClick += handler;
            tv.SearchClick -= handler;
        }

        control.Event(x => nameof(x.SearchClick),action);
        return control;
    }
}
public static partial class Android_Widget_SearchView_Extensions
{
    public static TControl OnSuggestionClick<TControl>(this TControl control,Action<Android.Widget.SearchView.SuggestionClickEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SearchView tv = null;

            tv.SuggestionClick += handler;
            tv.SuggestionClick -= handler;
        }

        control.Event(x => nameof(x.SuggestionClick),action);
        return control;
    }
}
public static partial class Android_Widget_SearchView_Extensions
{
    public static TControl OnSuggestionSelect<TControl>(this TControl control,Action<Android.Widget.SearchView.SuggestionSelectEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SearchView tv = null;

            tv.SuggestionSelect += handler;
            tv.SuggestionSelect -= handler;
        }

        control.Event(x => nameof(x.SuggestionSelect),action);
        return control;
    }
}

    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, System.Boolean>> _callExpression_SetIconifiedByDefault_Android_Widget_SearchView__System_Boolean = (view, param1) => view.SetIconifiedByDefault(param1);
        public static TControl SetIconifiedByDefault<TControl>(this TControl component, System.Boolean piconified) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetIconifiedByDefault_Android_Widget_SearchView__System_Boolean;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, piconified);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Android.Views.InputMethods.ImeAction>> _callExpression_SetImeOptions_Android_Widget_SearchView__Android_Views_InputMethods_ImeAction = (view, param1) => view.SetImeOptions(param1);
        public static TControl SetImeOptions<TControl>(this TControl component, Android.Views.InputMethods.ImeAction pimeOptions) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetImeOptions_Android_Widget_SearchView__Android_Views_InputMethods_ImeAction;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, pimeOptions);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Android.Text.InputTypes>> _callExpression_SetInputType_Android_Widget_SearchView__Android_Text_InputTypes = (view, param1) => view.SetInputType(param1);
        public static TControl SetInputType<TControl>(this TControl component, Android.Text.InputTypes pinputType) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetInputType_Android_Widget_SearchView__Android_Text_InputTypes;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, pinputType);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, System.Int32>> _callExpression_SetMaxWidth_Android_Widget_SearchView__System_Int32 = (view, param1) => view.SetMaxWidth(param1);
        public static TControl SetMaxWidth<TControl>(this TControl component, System.Int32 pmaxpixels) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetMaxWidth_Android_Widget_SearchView__System_Int32;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, pmaxpixels);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Android.Widget.SearchView.IOnCloseListener>> _callExpression_SetOnCloseListener_Android_Widget_SearchView__Android_Widget_SearchView_IOnCloseListener = (view, param1) => view.SetOnCloseListener(param1);
        public static TControl SetOnCloseListener<TControl>(this TControl component, Android.Widget.SearchView.IOnCloseListener plistener) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetOnCloseListener_Android_Widget_SearchView__Android_Widget_SearchView_IOnCloseListener;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Android.Views.View.IOnFocusChangeListener>> _callExpression_SetOnQueryTextFocusChangeListener_Android_Widget_SearchView__Android_Views_View_IOnFocusChangeListener = (view, param1) => view.SetOnQueryTextFocusChangeListener(param1);
        public static TControl SetOnQueryTextFocusChangeListener<TControl>(this TControl component, Android.Views.View.IOnFocusChangeListener plistener) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetOnQueryTextFocusChangeListener_Android_Widget_SearchView__Android_Views_View_IOnFocusChangeListener;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Android.Widget.SearchView.IOnQueryTextListener>> _callExpression_SetOnQueryTextListener_Android_Widget_SearchView__Android_Widget_SearchView_IOnQueryTextListener = (view, param1) => view.SetOnQueryTextListener(param1);
        public static TControl SetOnQueryTextListener<TControl>(this TControl component, Android.Widget.SearchView.IOnQueryTextListener plistener) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetOnQueryTextListener_Android_Widget_SearchView__Android_Widget_SearchView_IOnQueryTextListener;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Android.Views.View.IOnClickListener>> _callExpression_SetOnSearchClickListener_Android_Widget_SearchView__Android_Views_View_IOnClickListener = (view, param1) => view.SetOnSearchClickListener(param1);
        public static TControl SetOnSearchClickListener<TControl>(this TControl component, Android.Views.View.IOnClickListener plistener) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetOnSearchClickListener_Android_Widget_SearchView__Android_Views_View_IOnClickListener;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Android.Widget.SearchView.IOnSuggestionListener>> _callExpression_SetOnSuggestionListener_Android_Widget_SearchView__Android_Widget_SearchView_IOnSuggestionListener = (view, param1) => view.SetOnSuggestionListener(param1);
        public static TControl SetOnSuggestionListener<TControl>(this TControl component, Android.Widget.SearchView.IOnSuggestionListener plistener) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetOnSuggestionListener_Android_Widget_SearchView__Android_Widget_SearchView_IOnSuggestionListener;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Java.Lang.ICharSequence, System.Boolean>> _callExpression_SetQuery_Android_Widget_SearchView__Java_Lang_ICharSequence_System_Boolean = (view, param1, param2) => view.SetQuery(param1, param2);
        public static TControl SetQuery<TControl>(this TControl component, Java.Lang.ICharSequence pquery, System.Boolean psubmit) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetQuery_Android_Widget_SearchView__Java_Lang_ICharSequence_System_Boolean;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, pquery, psubmit);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, System.String, System.Boolean>> _callExpression_SetQuery_Android_Widget_SearchView__System_String_System_Boolean = (view, param1, param2) => view.SetQuery(param1, param2);
        public static TControl SetQuery<TControl>(this TControl component, System.String pquery, System.Boolean psubmit) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetQuery_Android_Widget_SearchView__System_String_System_Boolean;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, pquery, psubmit);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Java.Lang.ICharSequence>> _callExpression_SetQueryHint_Android_Widget_SearchView__Java_Lang_ICharSequence = (view, param1) => view.SetQueryHint(param1);
        public static TControl SetQueryHint<TControl>(this TControl component, Java.Lang.ICharSequence phint) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetQueryHint_Android_Widget_SearchView__Java_Lang_ICharSequence;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, phint);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, System.String>> _callExpression_SetQueryHint_Android_Widget_SearchView__System_String = (view, param1) => view.SetQueryHint(param1);
        public static TControl SetQueryHint<TControl>(this TControl component, System.String phint) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetQueryHint_Android_Widget_SearchView__System_String;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, phint);
            return component;
        }
    }
    public static partial class Android_Widget_SearchView_Extensions
    {
        private static Expression<Action<Android.Widget.SearchView, Android.App.SearchableInfo>> _callExpression_SetSearchableInfo_Android_Widget_SearchView__Android_App_SearchableInfo = (view, param1) => view.SetSearchableInfo(param1);
        public static TControl SetSearchableInfo<TControl>(this TControl component, Android.App.SearchableInfo psearchable) where TControl:IReflectedPrimitive<Android.Widget.SearchView>
        {
            var callExpression = _callExpression_SetSearchableInfo_Android_Widget_SearchView__Android_App_SearchableInfo;

            Reflect<Android.Widget.SearchView>.ReflectionHelpers.Call(component.Attributes,callExpression, psearchable);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.SeekBar> SeekBar(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.SeekBar(default);
            }

            var control = View<Android.Widget.SeekBar>(dimensions:dimensions,id:id);
            return control;
        }    
    }


public static partial class Android_Widget_SeekBar_Extensions
{
    public static TControl OnProgressChanged<TControl>(this TControl control,Action<Android.Widget.SeekBar.ProgressChangedEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.SeekBar>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SeekBar tv = null;

            tv.ProgressChanged += handler;
            tv.ProgressChanged -= handler;
        }

        control.Event(x => nameof(x.ProgressChanged),action);
        return control;
    }
}
public static partial class Android_Widget_SeekBar_Extensions
{
    public static TControl OnStartTrackingTouch<TControl>(this TControl control,Action<Android.Widget.SeekBar.StartTrackingTouchEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.SeekBar>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SeekBar tv = null;

            tv.StartTrackingTouch += handler;
            tv.StartTrackingTouch -= handler;
        }

        control.Event(x => nameof(x.StartTrackingTouch),action);
        return control;
    }
}
public static partial class Android_Widget_SeekBar_Extensions
{
    public static TControl OnStopTrackingTouch<TControl>(this TControl control,Action<Android.Widget.SeekBar.StopTrackingTouchEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.SeekBar>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.SeekBar tv = null;

            tv.StopTrackingTouch += handler;
            tv.StopTrackingTouch -= handler;
        }

        control.Event(x => nameof(x.StopTrackingTouch),action);
        return control;
    }
}

    public static partial class Android_Widget_SeekBar_Extensions
    {
        private static Expression<Action<Android.Widget.SeekBar, Android.Widget.SeekBar.IOnSeekBarChangeListener>> _callExpression_SetOnSeekBarChangeListener_Android_Widget_SeekBar__Android_Widget_SeekBar_IOnSeekBarChangeListener = (view, param1) => view.SetOnSeekBarChangeListener(param1);
        public static TControl SetOnSeekBarChangeListener<TControl>(this TControl component, Android.Widget.SeekBar.IOnSeekBarChangeListener pl) where TControl:IReflectedPrimitive<Android.Widget.SeekBar>
        {
            var callExpression = _callExpression_SetOnSeekBarChangeListener_Android_Widget_SeekBar__Android_Widget_SeekBar_IOnSeekBarChangeListener;

            Reflect<Android.Widget.SeekBar>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.Space> Space(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.Space(default);
            }

            var control = View<Android.Widget.Space>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.Spinner> Spinner(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.Spinner(default);
            }

            var control = View<Android.Widget.Spinner>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_Spinner_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DropDownHorizontalOffset = AttributeReflectionHelper.ResolveFor<Android.Widget.Spinner, System.Int32>
        (v => v.DropDownHorizontalOffset);


        public static TControl DropDownHorizontalOffset<TControl>(this TControl component, System.Int32 pDropDownHorizontalOffset)  where TControl:IReflectedPrimitive<Android.Widget.Spinner>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Spinner t = default;
                t.DropDownHorizontalOffset = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DropDownHorizontalOffset,pDropDownHorizontalOffset);
            return component;
        }
    }
    public static partial class Android_Widget_Spinner_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DropDownVerticalOffset = AttributeReflectionHelper.ResolveFor<Android.Widget.Spinner, System.Int32>
        (v => v.DropDownVerticalOffset);


        public static TControl DropDownVerticalOffset<TControl>(this TControl component, System.Int32 pDropDownVerticalOffset)  where TControl:IReflectedPrimitive<Android.Widget.Spinner>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Spinner t = default;
                t.DropDownVerticalOffset = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DropDownVerticalOffset,pDropDownVerticalOffset);
            return component;
        }
    }
    public static partial class Android_Widget_Spinner_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DropDownWidth = AttributeReflectionHelper.ResolveFor<Android.Widget.Spinner, System.Int32>
        (v => v.DropDownWidth);


        public static TControl DropDownWidth<TControl>(this TControl component, System.Int32 pDropDownWidth)  where TControl:IReflectedPrimitive<Android.Widget.Spinner>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Spinner t = default;
                t.DropDownWidth = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DropDownWidth,pDropDownWidth);
            return component;
        }
    }
    public static partial class Android_Widget_Spinner_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_PromptFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.Spinner, Java.Lang.ICharSequence>
        (v => v.PromptFormatted);


        public static TControl PromptFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pPromptFormatted)  where TControl:IReflectedPrimitive<Android.Widget.Spinner>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Spinner t = default;
                t.PromptFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_PromptFormatted,pPromptFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_Spinner_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Prompt = AttributeReflectionHelper.ResolveFor<Android.Widget.Spinner, System.String>
        (v => v.Prompt);


        public static TControl Prompt<TControl>(this TControl component, System.String pPrompt)  where TControl:IReflectedPrimitive<Android.Widget.Spinner>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Spinner t = default;
                t.Prompt = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Prompt,pPrompt);
            return component;
        }
    }


    public static partial class Android_Widget_Spinner_Extensions
    {
        private static Expression<Action<Android.Widget.Spinner, Android.Views.GravityFlags>> _callExpression_SetGravity_Android_Widget_Spinner__Android_Views_GravityFlags = (view, param1) => view.SetGravity(param1);
        public static TControl SetGravity<TControl>(this TControl component, Android.Views.GravityFlags pgravity) where TControl:IReflectedPrimitive<Android.Widget.Spinner>
        {
            var callExpression = _callExpression_SetGravity_Android_Widget_Spinner__Android_Views_GravityFlags;

            Reflect<Android.Widget.Spinner>.ReflectionHelpers.Call(component.Attributes,callExpression, pgravity);
            return component;
        }
    }
    public static partial class Android_Widget_Spinner_Extensions
    {
        private static Expression<Action<Android.Widget.Spinner, Android.Graphics.Drawables.Drawable>> _callExpression_SetPopupBackgroundDrawable_Android_Widget_Spinner__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetPopupBackgroundDrawable(param1);
        public static TControl SetPopupBackgroundDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pbackground) where TControl:IReflectedPrimitive<Android.Widget.Spinner>
        {
            var callExpression = _callExpression_SetPopupBackgroundDrawable_Android_Widget_Spinner__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.Spinner>.ReflectionHelpers.Call(component.Attributes,callExpression, pbackground);
            return component;
        }
    }
    public static partial class Android_Widget_Spinner_Extensions
    {
        private static Expression<Action<Android.Widget.Spinner, System.Int32>> _callExpression_SetPopupBackgroundResource_Android_Widget_Spinner__System_Int32 = (view, param1) => view.SetPopupBackgroundResource(param1);
        public static TControl SetPopupBackgroundResource<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Spinner>
        {
            var callExpression = _callExpression_SetPopupBackgroundResource_Android_Widget_Spinner__System_Int32;

            Reflect<Android.Widget.Spinner>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Spinner_Extensions
    {
        private static Expression<Action<Android.Widget.Spinner, System.Int32>> _callExpression_SetPromptId_Android_Widget_Spinner__System_Int32 = (view, param1) => view.SetPromptId(param1);
        public static TControl SetPromptId<TControl>(this TControl component, System.Int32 ppromptId) where TControl:IReflectedPrimitive<Android.Widget.Spinner>
        {
            var callExpression = _callExpression_SetPromptId_Android_Widget_Spinner__System_Int32;

            Reflect<Android.Widget.Spinner>.ReflectionHelpers.Call(component.Attributes,callExpression, ppromptId);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.Switch> Switch(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.Switch(default);
            }

            var control = View<Android.Widget.Switch>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ShowText = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, System.Boolean>
        (v => v.ShowText);


        public static TControl ShowText<TControl>(this TControl component, System.Boolean pShowText)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.ShowText = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_ShowText,pShowText);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_SplitTrack = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, System.Boolean>
        (v => v.SplitTrack);


        public static TControl SplitTrack<TControl>(this TControl component, System.Boolean pSplitTrack)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.SplitTrack = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_SplitTrack,pSplitTrack);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_SwitchMinWidth = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, System.Int32>
        (v => v.SwitchMinWidth);


        public static TControl SwitchMinWidth<TControl>(this TControl component, System.Int32 pSwitchMinWidth)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.SwitchMinWidth = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_SwitchMinWidth,pSwitchMinWidth);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_SwitchPadding = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, System.Int32>
        (v => v.SwitchPadding);


        public static TControl SwitchPadding<TControl>(this TControl component, System.Int32 pSwitchPadding)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.SwitchPadding = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_SwitchPadding,pSwitchPadding);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_TextOffFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, Java.Lang.ICharSequence>
        (v => v.TextOffFormatted);


        public static TControl TextOffFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pTextOffFormatted)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.TextOffFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_TextOffFormatted,pTextOffFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_TextOff = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, System.String>
        (v => v.TextOff);


        public static TControl TextOff<TControl>(this TControl component, System.String pTextOff)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.TextOff = default;
            }

            component.Attributes.SetAttribute(Attribute_String_TextOff,pTextOff);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_TextOnFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, Java.Lang.ICharSequence>
        (v => v.TextOnFormatted);


        public static TControl TextOnFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pTextOnFormatted)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.TextOnFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_TextOnFormatted,pTextOnFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_TextOn = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, System.String>
        (v => v.TextOn);


        public static TControl TextOn<TControl>(this TControl component, System.String pTextOn)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.TextOn = default;
            }

            component.Attributes.SetAttribute(Attribute_String_TextOn,pTextOn);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_ThumbDrawable = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, Android.Graphics.Drawables.Drawable>
        (v => v.ThumbDrawable);


        public static TControl ThumbDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pThumbDrawable)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.ThumbDrawable = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_ThumbDrawable,pThumbDrawable);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ThumbTextPadding = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, System.Int32>
        (v => v.ThumbTextPadding);


        public static TControl ThumbTextPadding<TControl>(this TControl component, System.Int32 pThumbTextPadding)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.ThumbTextPadding = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ThumbTextPadding,pThumbTextPadding);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_ThumbTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, Android.Content.Res.ColorStateList>
        (v => v.ThumbTintList);


        public static TControl ThumbTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pThumbTintList)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.ThumbTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_ThumbTintList,pThumbTintList);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_ThumbTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, Android.Graphics.PorterDuff.Mode>
        (v => v.ThumbTintMode);


        public static TControl ThumbTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pThumbTintMode)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.ThumbTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_ThumbTintMode,pThumbTintMode);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_TrackDrawable = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, Android.Graphics.Drawables.Drawable>
        (v => v.TrackDrawable);


        public static TControl TrackDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pTrackDrawable)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.TrackDrawable = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_TrackDrawable,pTrackDrawable);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_TrackTintList = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, Android.Content.Res.ColorStateList>
        (v => v.TrackTintList);


        public static TControl TrackTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pTrackTintList)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.TrackTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_TrackTintList,pTrackTintList);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_TrackTintMode = AttributeReflectionHelper.ResolveFor<Android.Widget.Switch, Android.Graphics.PorterDuff.Mode>
        (v => v.TrackTintMode);


        public static TControl TrackTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pTrackTintMode)  where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Switch t = default;
                t.TrackTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_TrackTintMode,pTrackTintMode);
            return component;
        }
    }


    public static partial class Android_Widget_Switch_Extensions
    {
        private static Expression<Action<Android.Widget.Switch, Android.Content.Context, System.Int32>> _callExpression_SetSwitchTextAppearance_Android_Widget_Switch__Android_Content_Context_System_Int32 = (view, param1, param2) => view.SetSwitchTextAppearance(param1, param2);
        public static TControl SetSwitchTextAppearance<TControl>(this TControl component, Android.Content.Context pcontext, System.Int32 presid) where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            var callExpression = _callExpression_SetSwitchTextAppearance_Android_Widget_Switch__Android_Content_Context_System_Int32;

            Reflect<Android.Widget.Switch>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontext, presid);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static Expression<Action<Android.Widget.Switch, Android.Graphics.Typeface>> _callExpression_SetSwitchTypeface_Android_Widget_Switch__Android_Graphics_Typeface = (view, param1) => view.SetSwitchTypeface(param1);
        public static TControl SetSwitchTypeface<TControl>(this TControl component, Android.Graphics.Typeface ptf) where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            var callExpression = _callExpression_SetSwitchTypeface_Android_Widget_Switch__Android_Graphics_Typeface;

            Reflect<Android.Widget.Switch>.ReflectionHelpers.Call(component.Attributes,callExpression, ptf);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static Expression<Action<Android.Widget.Switch, Android.Graphics.Typeface, Android.Graphics.TypefaceStyle>> _callExpression_SetSwitchTypeface_Android_Widget_Switch__Android_Graphics_Typeface_Android_Graphics_TypefaceStyle = (view, param1, param2) => view.SetSwitchTypeface(param1, param2);
        public static TControl SetSwitchTypeface<TControl>(this TControl component, Android.Graphics.Typeface ptf, Android.Graphics.TypefaceStyle pstyle) where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            var callExpression = _callExpression_SetSwitchTypeface_Android_Widget_Switch__Android_Graphics_Typeface_Android_Graphics_TypefaceStyle;

            Reflect<Android.Widget.Switch>.ReflectionHelpers.Call(component.Attributes,callExpression, ptf, pstyle);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static Expression<Action<Android.Widget.Switch, System.Int32>> _callExpression_SetThumbResource_Android_Widget_Switch__System_Int32 = (view, param1) => view.SetThumbResource(param1);
        public static TControl SetThumbResource<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            var callExpression = _callExpression_SetThumbResource_Android_Widget_Switch__System_Int32;

            Reflect<Android.Widget.Switch>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Switch_Extensions
    {
        private static Expression<Action<Android.Widget.Switch, System.Int32>> _callExpression_SetTrackResource_Android_Widget_Switch__System_Int32 = (view, param1) => view.SetTrackResource(param1);
        public static TControl SetTrackResource<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Switch>
        {
            var callExpression = _callExpression_SetTrackResource_Android_Widget_Switch__System_Int32;

            Reflect<Android.Widget.Switch>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidViewGroup<Android.Widget.TableLayout> TableLayout(IEnumerable<IPrimitive> children,Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.TableLayout(default);
            }

            var control = ViewGroup<Android.Widget.TableLayout>(children,(dimensions) => new Android.Widget.TableLayout.LayoutParams(dimensions.Width, dimensions.Height), dimensions, id);
            return control;
        }    
    }

    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ShrinkAllColumns = AttributeReflectionHelper.ResolveFor<Android.Widget.TableLayout, System.Boolean>
        (v => v.ShrinkAllColumns);


        public static TControl ShrinkAllColumns<TControl>(this TControl component, System.Boolean pShrinkAllColumns)  where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TableLayout t = default;
                t.ShrinkAllColumns = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_ShrinkAllColumns,pShrinkAllColumns);
            return component;
        }
    }
    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_StretchAllColumns = AttributeReflectionHelper.ResolveFor<Android.Widget.TableLayout, System.Boolean>
        (v => v.StretchAllColumns);


        public static TControl StretchAllColumns<TControl>(this TControl component, System.Boolean pStretchAllColumns)  where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TableLayout t = default;
                t.StretchAllColumns = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_StretchAllColumns,pStretchAllColumns);
            return component;
        }
    }


    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static Expression<Action<Android.Widget.TableLayout, System.Int32, System.Boolean>> _callExpression_SetColumnCollapsed_Android_Widget_TableLayout__System_Int32_System_Boolean = (view, param1, param2) => view.SetColumnCollapsed(param1, param2);
        public static TControl SetColumnCollapsed<TControl>(this TControl component, System.Int32 pcolumnIndex, System.Boolean pisCollapsed) where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
        {
            var callExpression = _callExpression_SetColumnCollapsed_Android_Widget_TableLayout__System_Int32_System_Boolean;

            Reflect<Android.Widget.TableLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolumnIndex, pisCollapsed);
            return component;
        }
    }
    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static Expression<Action<Android.Widget.TableLayout, System.Int32, System.Boolean>> _callExpression_SetColumnShrinkable_Android_Widget_TableLayout__System_Int32_System_Boolean = (view, param1, param2) => view.SetColumnShrinkable(param1, param2);
        public static TControl SetColumnShrinkable<TControl>(this TControl component, System.Int32 pcolumnIndex, System.Boolean pisShrinkable) where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
        {
            var callExpression = _callExpression_SetColumnShrinkable_Android_Widget_TableLayout__System_Int32_System_Boolean;

            Reflect<Android.Widget.TableLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolumnIndex, pisShrinkable);
            return component;
        }
    }
    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static Expression<Action<Android.Widget.TableLayout, System.Int32, System.Boolean>> _callExpression_SetColumnStretchable_Android_Widget_TableLayout__System_Int32_System_Boolean = (view, param1, param2) => view.SetColumnStretchable(param1, param2);
        public static TControl SetColumnStretchable<TControl>(this TControl component, System.Int32 pcolumnIndex, System.Boolean pisStretchable) where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
        {
            var callExpression = _callExpression_SetColumnStretchable_Android_Widget_TableLayout__System_Int32_System_Boolean;

            Reflect<Android.Widget.TableLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolumnIndex, pisStretchable);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.TextClock> TextClock(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.TextClock(default);
            }

            var control = View<Android.Widget.TextClock>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_TextClock_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_Format12HourFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.TextClock, Java.Lang.ICharSequence>
        (v => v.Format12HourFormatted);


        public static TControl Format12HourFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pFormat12HourFormatted)  where TControl:IReflectedPrimitive<Android.Widget.TextClock>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextClock t = default;
                t.Format12HourFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_Format12HourFormatted,pFormat12HourFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_TextClock_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Format12Hour = AttributeReflectionHelper.ResolveFor<Android.Widget.TextClock, System.String>
        (v => v.Format12Hour);


        public static TControl Format12Hour<TControl>(this TControl component, System.String pFormat12Hour)  where TControl:IReflectedPrimitive<Android.Widget.TextClock>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextClock t = default;
                t.Format12Hour = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Format12Hour,pFormat12Hour);
            return component;
        }
    }
    public static partial class Android_Widget_TextClock_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_Format24HourFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.TextClock, Java.Lang.ICharSequence>
        (v => v.Format24HourFormatted);


        public static TControl Format24HourFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pFormat24HourFormatted)  where TControl:IReflectedPrimitive<Android.Widget.TextClock>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextClock t = default;
                t.Format24HourFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_Format24HourFormatted,pFormat24HourFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_TextClock_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Format24Hour = AttributeReflectionHelper.ResolveFor<Android.Widget.TextClock, System.String>
        (v => v.Format24Hour);


        public static TControl Format24Hour<TControl>(this TControl component, System.String pFormat24Hour)  where TControl:IReflectedPrimitive<Android.Widget.TextClock>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextClock t = default;
                t.Format24Hour = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Format24Hour,pFormat24Hour);
            return component;
        }
    }
    public static partial class Android_Widget_TextClock_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_TimeZone = AttributeReflectionHelper.ResolveFor<Android.Widget.TextClock, System.String>
        (v => v.TimeZone);


        public static TControl TimeZone<TControl>(this TControl component, System.String pTimeZone)  where TControl:IReflectedPrimitive<Android.Widget.TextClock>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TextClock t = default;
                t.TimeZone = default;
            }

            component.Attributes.SetAttribute(Attribute_String_TimeZone,pTimeZone);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.TextSwitcher> TextSwitcher(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.TextSwitcher(default);
            }

            var control = View<Android.Widget.TextSwitcher>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Android_Widget_TextSwitcher_Extensions
    {
        private static Expression<Action<Android.Widget.TextSwitcher, Java.Lang.ICharSequence>> _callExpression_SetCurrentText_Android_Widget_TextSwitcher__Java_Lang_ICharSequence = (view, param1) => view.SetCurrentText(param1);
        public static TControl SetCurrentText<TControl>(this TControl component, Java.Lang.ICharSequence ptext) where TControl:IReflectedPrimitive<Android.Widget.TextSwitcher>
        {
            var callExpression = _callExpression_SetCurrentText_Android_Widget_TextSwitcher__Java_Lang_ICharSequence;

            Reflect<Android.Widget.TextSwitcher>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Widget_TextSwitcher_Extensions
    {
        private static Expression<Action<Android.Widget.TextSwitcher, System.String>> _callExpression_SetCurrentText_Android_Widget_TextSwitcher__System_String = (view, param1) => view.SetCurrentText(param1);
        public static TControl SetCurrentText<TControl>(this TControl component, System.String ptext) where TControl:IReflectedPrimitive<Android.Widget.TextSwitcher>
        {
            var callExpression = _callExpression_SetCurrentText_Android_Widget_TextSwitcher__System_String;

            Reflect<Android.Widget.TextSwitcher>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Widget_TextSwitcher_Extensions
    {
        private static Expression<Action<Android.Widget.TextSwitcher, Java.Lang.ICharSequence>> _callExpression_SetText_Android_Widget_TextSwitcher__Java_Lang_ICharSequence = (view, param1) => view.SetText(param1);
        public static TControl SetText<TControl>(this TControl component, Java.Lang.ICharSequence ptext) where TControl:IReflectedPrimitive<Android.Widget.TextSwitcher>
        {
            var callExpression = _callExpression_SetText_Android_Widget_TextSwitcher__Java_Lang_ICharSequence;

            Reflect<Android.Widget.TextSwitcher>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Widget_TextSwitcher_Extensions
    {
        private static Expression<Action<Android.Widget.TextSwitcher, System.String>> _callExpression_SetText_Android_Widget_TextSwitcher__System_String = (view, param1) => view.SetText(param1);
        public static TControl SetText<TControl>(this TControl component, System.String ptext) where TControl:IReflectedPrimitive<Android.Widget.TextSwitcher>
        {
            var callExpression = _callExpression_SetText_Android_Widget_TextSwitcher__System_String;

            Reflect<Android.Widget.TextSwitcher>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.TimePicker> TimePicker(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.TimePicker(default);
            }

            var control = View<Android.Widget.TimePicker>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_TimePicker_Extensions
    {
        private static readonly Attribute<Java.Lang.Integer> Attribute_Integer_CurrentHour = AttributeReflectionHelper.ResolveFor<Android.Widget.TimePicker, Java.Lang.Integer>
        (v => v.CurrentHour);


        public static TControl CurrentHour<TControl>(this TControl component, Java.Lang.Integer pCurrentHour)  where TControl:IReflectedPrimitive<Android.Widget.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TimePicker t = default;
                t.CurrentHour = default;
            }

            component.Attributes.SetAttribute(Attribute_Integer_CurrentHour,pCurrentHour);
            return component;
        }
    }
    public static partial class Android_Widget_TimePicker_Extensions
    {
        private static readonly Attribute<Java.Lang.Integer> Attribute_Integer_CurrentMinute = AttributeReflectionHelper.ResolveFor<Android.Widget.TimePicker, Java.Lang.Integer>
        (v => v.CurrentMinute);


        public static TControl CurrentMinute<TControl>(this TControl component, Java.Lang.Integer pCurrentMinute)  where TControl:IReflectedPrimitive<Android.Widget.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TimePicker t = default;
                t.CurrentMinute = default;
            }

            component.Attributes.SetAttribute(Attribute_Integer_CurrentMinute,pCurrentMinute);
            return component;
        }
    }
    public static partial class Android_Widget_TimePicker_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Hour = AttributeReflectionHelper.ResolveFor<Android.Widget.TimePicker, System.Int32>
        (v => v.Hour);


        public static TControl Hour<TControl>(this TControl component, System.Int32 pHour)  where TControl:IReflectedPrimitive<Android.Widget.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TimePicker t = default;
                t.Hour = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Hour,pHour);
            return component;
        }
    }
    public static partial class Android_Widget_TimePicker_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Minute = AttributeReflectionHelper.ResolveFor<Android.Widget.TimePicker, System.Int32>
        (v => v.Minute);


        public static TControl Minute<TControl>(this TControl component, System.Int32 pMinute)  where TControl:IReflectedPrimitive<Android.Widget.TimePicker>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.TimePicker t = default;
                t.Minute = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Minute,pMinute);
            return component;
        }
    }

public static partial class Android_Widget_TimePicker_Extensions
{
    public static TControl OnTimeChanged<TControl>(this TControl control,Action<Android.Widget.TimePicker.TimeChangedEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.TimePicker>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.TimePicker tv = null;

            tv.TimeChanged += handler;
            tv.TimeChanged -= handler;
        }

        control.Event(x => nameof(x.TimeChanged),action);
        return control;
    }
}

    public static partial class Android_Widget_TimePicker_Extensions
    {
        private static Expression<Action<Android.Widget.TimePicker, Java.Lang.Boolean>> _callExpression_SetIs24HourView_Android_Widget_TimePicker__Java_Lang_Boolean = (view, param1) => view.SetIs24HourView(param1);
        public static TControl SetIs24HourView<TControl>(this TControl component, Java.Lang.Boolean pis24HourView) where TControl:IReflectedPrimitive<Android.Widget.TimePicker>
        {
            var callExpression = _callExpression_SetIs24HourView_Android_Widget_TimePicker__Java_Lang_Boolean;

            Reflect<Android.Widget.TimePicker>.ReflectionHelpers.Call(component.Attributes,callExpression, pis24HourView);
            return component;
        }
    }
    public static partial class Android_Widget_TimePicker_Extensions
    {
        private static Expression<Action<Android.Widget.TimePicker, Android.Widget.TimePicker.IOnTimeChangedListener>> _callExpression_SetOnTimeChangedListener_Android_Widget_TimePicker__Android_Widget_TimePicker_IOnTimeChangedListener = (view, param1) => view.SetOnTimeChangedListener(param1);
        public static TControl SetOnTimeChangedListener<TControl>(this TControl component, Android.Widget.TimePicker.IOnTimeChangedListener ponTimeChangedListener) where TControl:IReflectedPrimitive<Android.Widget.TimePicker>
        {
            var callExpression = _callExpression_SetOnTimeChangedListener_Android_Widget_TimePicker__Android_Widget_TimePicker_IOnTimeChangedListener;

            Reflect<Android.Widget.TimePicker>.ReflectionHelpers.Call(component.Attributes,callExpression, ponTimeChangedListener);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.ToggleButton> ToggleButton(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.ToggleButton(default);
            }

            var control = View<Android.Widget.ToggleButton>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_ToggleButton_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_TextOffFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.ToggleButton, Java.Lang.ICharSequence>
        (v => v.TextOffFormatted);


        public static TControl TextOffFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pTextOffFormatted)  where TControl:IReflectedPrimitive<Android.Widget.ToggleButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ToggleButton t = default;
                t.TextOffFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_TextOffFormatted,pTextOffFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_ToggleButton_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_TextOff = AttributeReflectionHelper.ResolveFor<Android.Widget.ToggleButton, System.String>
        (v => v.TextOff);


        public static TControl TextOff<TControl>(this TControl component, System.String pTextOff)  where TControl:IReflectedPrimitive<Android.Widget.ToggleButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ToggleButton t = default;
                t.TextOff = default;
            }

            component.Attributes.SetAttribute(Attribute_String_TextOff,pTextOff);
            return component;
        }
    }
    public static partial class Android_Widget_ToggleButton_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_TextOnFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.ToggleButton, Java.Lang.ICharSequence>
        (v => v.TextOnFormatted);


        public static TControl TextOnFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pTextOnFormatted)  where TControl:IReflectedPrimitive<Android.Widget.ToggleButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ToggleButton t = default;
                t.TextOnFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_TextOnFormatted,pTextOnFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_ToggleButton_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_TextOn = AttributeReflectionHelper.ResolveFor<Android.Widget.ToggleButton, System.String>
        (v => v.TextOn);


        public static TControl TextOn<TControl>(this TControl component, System.String pTextOn)  where TControl:IReflectedPrimitive<Android.Widget.ToggleButton>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ToggleButton t = default;
                t.TextOn = default;
            }

            component.Attributes.SetAttribute(Attribute_String_TextOn,pTextOn);
            return component;
        }
    }


    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.Toolbar> Toolbar(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.Toolbar(default);
            }

            var control = View<Android.Widget.Toolbar>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ContentInsetEndWithActions = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.Int32>
        (v => v.ContentInsetEndWithActions);


        public static TControl ContentInsetEndWithActions<TControl>(this TControl component, System.Int32 pContentInsetEndWithActions)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.ContentInsetEndWithActions = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ContentInsetEndWithActions,pContentInsetEndWithActions);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ContentInsetStartWithNavigation = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.Int32>
        (v => v.ContentInsetStartWithNavigation);


        public static TControl ContentInsetStartWithNavigation<TControl>(this TControl component, System.Int32 pContentInsetStartWithNavigation)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.ContentInsetStartWithNavigation = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ContentInsetStartWithNavigation,pContentInsetStartWithNavigation);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_Logo = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, Android.Graphics.Drawables.Drawable>
        (v => v.Logo);


        public static TControl Logo<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pLogo)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.Logo = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_Logo,pLogo);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_LogoDescriptionFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, Java.Lang.ICharSequence>
        (v => v.LogoDescriptionFormatted);


        public static TControl LogoDescriptionFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pLogoDescriptionFormatted)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.LogoDescriptionFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_LogoDescriptionFormatted,pLogoDescriptionFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_LogoDescription = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.String>
        (v => v.LogoDescription);


        public static TControl LogoDescription<TControl>(this TControl component, System.String pLogoDescription)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.LogoDescription = default;
            }

            component.Attributes.SetAttribute(Attribute_String_LogoDescription,pLogoDescription);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_NavigationContentDescriptionFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, Java.Lang.ICharSequence>
        (v => v.NavigationContentDescriptionFormatted);


        public static TControl NavigationContentDescriptionFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pNavigationContentDescriptionFormatted)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.NavigationContentDescriptionFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_NavigationContentDescriptionFormatted,pNavigationContentDescriptionFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_NavigationContentDescription = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.String>
        (v => v.NavigationContentDescription);


        public static TControl NavigationContentDescription<TControl>(this TControl component, System.String pNavigationContentDescription)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.NavigationContentDescription = default;
            }

            component.Attributes.SetAttribute(Attribute_String_NavigationContentDescription,pNavigationContentDescription);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_NavigationIcon = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, Android.Graphics.Drawables.Drawable>
        (v => v.NavigationIcon);


        public static TControl NavigationIcon<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pNavigationIcon)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.NavigationIcon = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_NavigationIcon,pNavigationIcon);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_OverflowIcon = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, Android.Graphics.Drawables.Drawable>
        (v => v.OverflowIcon);


        public static TControl OverflowIcon<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pOverflowIcon)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.OverflowIcon = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_OverflowIcon,pOverflowIcon);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_PopupTheme = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.Int32>
        (v => v.PopupTheme);


        public static TControl PopupTheme<TControl>(this TControl component, System.Int32 pPopupTheme)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.PopupTheme = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_PopupTheme,pPopupTheme);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_SubtitleFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, Java.Lang.ICharSequence>
        (v => v.SubtitleFormatted);


        public static TControl SubtitleFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pSubtitleFormatted)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.SubtitleFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_SubtitleFormatted,pSubtitleFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Subtitle = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.String>
        (v => v.Subtitle);


        public static TControl Subtitle<TControl>(this TControl component, System.String pSubtitle)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.Subtitle = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Subtitle,pSubtitle);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_TitleFormatted = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, Java.Lang.ICharSequence>
        (v => v.TitleFormatted);


        public static TControl TitleFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pTitleFormatted)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.TitleFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_TitleFormatted,pTitleFormatted);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Title = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.String>
        (v => v.Title);


        public static TControl Title<TControl>(this TControl component, System.String pTitle)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.Title = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Title,pTitle);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_TitleMarginBottom = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.Int32>
        (v => v.TitleMarginBottom);


        public static TControl TitleMarginBottom<TControl>(this TControl component, System.Int32 pTitleMarginBottom)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.TitleMarginBottom = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_TitleMarginBottom,pTitleMarginBottom);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_TitleMarginEnd = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.Int32>
        (v => v.TitleMarginEnd);


        public static TControl TitleMarginEnd<TControl>(this TControl component, System.Int32 pTitleMarginEnd)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.TitleMarginEnd = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_TitleMarginEnd,pTitleMarginEnd);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_TitleMarginStart = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.Int32>
        (v => v.TitleMarginStart);


        public static TControl TitleMarginStart<TControl>(this TControl component, System.Int32 pTitleMarginStart)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.TitleMarginStart = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_TitleMarginStart,pTitleMarginStart);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_TitleMarginTop = AttributeReflectionHelper.ResolveFor<Android.Widget.Toolbar, System.Int32>
        (v => v.TitleMarginTop);


        public static TControl TitleMarginTop<TControl>(this TControl component, System.Int32 pTitleMarginTop)  where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.Toolbar t = default;
                t.TitleMarginTop = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_TitleMarginTop,pTitleMarginTop);
            return component;
        }
    }

public static partial class Android_Widget_Toolbar_Extensions
{
    public static TControl OnNavigationOnClick<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.Toolbar tv = null;

            tv.NavigationOnClick += handler;
            tv.NavigationOnClick -= handler;
        }

        control.Event(x => nameof(x.NavigationOnClick),action);
        return control;
    }
}
public static partial class Android_Widget_Toolbar_Extensions
{
    public static TControl OnMenuItemClick<TControl>(this TControl control,Action<Android.Widget.Toolbar.MenuItemClickEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.Toolbar tv = null;

            tv.MenuItemClick += handler;
            tv.MenuItemClick -= handler;
        }

        control.Event(x => nameof(x.MenuItemClick),action);
        return control;
    }
}

    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar>> _callExpression_CollapseActionView_Android_Widget_Toolbar_ = (view) => view.CollapseActionView();
        public static TControl CollapseActionView<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_CollapseActionView_Android_Widget_Toolbar_;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar>> _callExpression_DismissPopupMenus_Android_Widget_Toolbar_ = (view) => view.DismissPopupMenus();
        public static TControl DismissPopupMenus<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_DismissPopupMenus_Android_Widget_Toolbar_;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32>> _callExpression_InflateMenu_Android_Widget_Toolbar__System_Int32 = (view, param1) => view.InflateMenu(param1);
        public static TControl InflateMenu<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_InflateMenu_Android_Widget_Toolbar__System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32, System.Int32>> _callExpression_SetContentInsetsAbsolute_Android_Widget_Toolbar__System_Int32_System_Int32 = (view, param1, param2) => view.SetContentInsetsAbsolute(param1, param2);
        public static TControl SetContentInsetsAbsolute<TControl>(this TControl component, System.Int32 pcontentInsetLeft, System.Int32 pcontentInsetRight) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetContentInsetsAbsolute_Android_Widget_Toolbar__System_Int32_System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontentInsetLeft, pcontentInsetRight);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32, System.Int32>> _callExpression_SetContentInsetsRelative_Android_Widget_Toolbar__System_Int32_System_Int32 = (view, param1, param2) => view.SetContentInsetsRelative(param1, param2);
        public static TControl SetContentInsetsRelative<TControl>(this TControl component, System.Int32 pcontentInsetStart, System.Int32 pcontentInsetEnd) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetContentInsetsRelative_Android_Widget_Toolbar__System_Int32_System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontentInsetStart, pcontentInsetEnd);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32>> _callExpression_SetLogo_Android_Widget_Toolbar__System_Int32 = (view, param1) => view.SetLogo(param1);
        public static TControl SetLogo<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetLogo_Android_Widget_Toolbar__System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32>> _callExpression_SetLogoDescription_Android_Widget_Toolbar__System_Int32 = (view, param1) => view.SetLogoDescription(param1);
        public static TControl SetLogoDescription<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetLogoDescription_Android_Widget_Toolbar__System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32>> _callExpression_SetNavigationContentDescription_Android_Widget_Toolbar__System_Int32 = (view, param1) => view.SetNavigationContentDescription(param1);
        public static TControl SetNavigationContentDescription<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetNavigationContentDescription_Android_Widget_Toolbar__System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32>> _callExpression_SetNavigationIcon_Android_Widget_Toolbar__System_Int32 = (view, param1) => view.SetNavigationIcon(param1);
        public static TControl SetNavigationIcon<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetNavigationIcon_Android_Widget_Toolbar__System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, Android.Views.View.IOnClickListener>> _callExpression_SetNavigationOnClickListener_Android_Widget_Toolbar__Android_Views_View_IOnClickListener = (view, param1) => view.SetNavigationOnClickListener(param1);
        public static TControl SetNavigationOnClickListener<TControl>(this TControl component, Android.Views.View.IOnClickListener plistener) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetNavigationOnClickListener_Android_Widget_Toolbar__Android_Views_View_IOnClickListener;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, Android.Widget.Toolbar.IOnMenuItemClickListener>> _callExpression_SetOnMenuItemClickListener_Android_Widget_Toolbar__Android_Widget_Toolbar_IOnMenuItemClickListener = (view, param1) => view.SetOnMenuItemClickListener(param1);
        public static TControl SetOnMenuItemClickListener<TControl>(this TControl component, Android.Widget.Toolbar.IOnMenuItemClickListener plistener) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetOnMenuItemClickListener_Android_Widget_Toolbar__Android_Widget_Toolbar_IOnMenuItemClickListener;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32>> _callExpression_SetSubtitle_Android_Widget_Toolbar__System_Int32 = (view, param1) => view.SetSubtitle(param1);
        public static TControl SetSubtitle<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetSubtitle_Android_Widget_Toolbar__System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, Android.Content.Context, System.Int32>> _callExpression_SetSubtitleTextAppearance_Android_Widget_Toolbar__Android_Content_Context_System_Int32 = (view, param1, param2) => view.SetSubtitleTextAppearance(param1, param2);
        public static TControl SetSubtitleTextAppearance<TControl>(this TControl component, Android.Content.Context pcontext, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetSubtitleTextAppearance_Android_Widget_Toolbar__Android_Content_Context_System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontext, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, Android.Graphics.Color>> _callExpression_SetSubtitleTextColor_Android_Widget_Toolbar__Android_Graphics_Color = (view, param1) => view.SetSubtitleTextColor(param1);
        public static TControl SetSubtitleTextColor<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetSubtitleTextColor_Android_Widget_Toolbar__Android_Graphics_Color;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32>> _callExpression_SetTitle_Android_Widget_Toolbar__System_Int32 = (view, param1) => view.SetTitle(param1);
        public static TControl SetTitle<TControl>(this TControl component, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetTitle_Android_Widget_Toolbar__System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_SetTitleMargin_Android_Widget_Toolbar__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.SetTitleMargin(param1, param2, param3, param4);
        public static TControl SetTitleMargin<TControl>(this TControl component, System.Int32 pstart, System.Int32 ptop, System.Int32 pend, System.Int32 pbottom) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetTitleMargin_Android_Widget_Toolbar__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, pstart, ptop, pend, pbottom);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, Android.Content.Context, System.Int32>> _callExpression_SetTitleTextAppearance_Android_Widget_Toolbar__Android_Content_Context_System_Int32 = (view, param1, param2) => view.SetTitleTextAppearance(param1, param2);
        public static TControl SetTitleTextAppearance<TControl>(this TControl component, Android.Content.Context pcontext, System.Int32 presId) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetTitleTextAppearance_Android_Widget_Toolbar__Android_Content_Context_System_Int32;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontext, presId);
            return component;
        }
    }
    public static partial class Android_Widget_Toolbar_Extensions
    {
        private static Expression<Action<Android.Widget.Toolbar, Android.Graphics.Color>> _callExpression_SetTitleTextColor_Android_Widget_Toolbar__Android_Graphics_Color = (view, param1) => view.SetTitleTextColor(param1);
        public static TControl SetTitleTextColor<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Widget.Toolbar>
        {
            var callExpression = _callExpression_SetTitleTextColor_Android_Widget_Toolbar__Android_Graphics_Color;

            Reflect<Android.Widget.Toolbar>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.VideoView> VideoView(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.VideoView(default);
            }

            var control = View<Android.Widget.VideoView>(dimensions:dimensions,id:id);
            return control;
        }    
    }


public static partial class Android_Widget_VideoView_Extensions
{
    public static TControl OnCompletion<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.VideoView tv = null;

            tv.Completion += handler;
            tv.Completion -= handler;
        }

        control.Event(x => nameof(x.Completion),action);
        return control;
    }
}
public static partial class Android_Widget_VideoView_Extensions
{
    public static TControl OnError<TControl>(this TControl control,Action<Android.Media.MediaPlayer.ErrorEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.VideoView tv = null;

            tv.Error += handler;
            tv.Error -= handler;
        }

        control.Event(x => nameof(x.Error),action);
        return control;
    }
}
public static partial class Android_Widget_VideoView_Extensions
{
    public static TControl OnInfo<TControl>(this TControl control,Action<Android.Media.MediaPlayer.InfoEventArgs> action) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.VideoView tv = null;

            tv.Info += handler;
            tv.Info -= handler;
        }

        control.Event(x => nameof(x.Info),action);
        return control;
    }
}
public static partial class Android_Widget_VideoView_Extensions
{
    public static TControl OnPrepared<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Widget.VideoView tv = null;

            tv.Prepared += handler;
            tv.Prepared -= handler;
        }

        control.Event(x => nameof(x.Prepared),action);
        return control;
    }
}

    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, System.IO.Stream, Android.Media.MediaFormat>> _callExpression_AddSubtitleSource_Android_Widget_VideoView__System_IO_Stream_Android_Media_MediaFormat = (view, param1, param2) => view.AddSubtitleSource(param1, param2);
        public static TControl AddSubtitleSource<TControl>(this TControl component, System.IO.Stream pis, Android.Media.MediaFormat pformat) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_AddSubtitleSource_Android_Widget_VideoView__System_IO_Stream_Android_Media_MediaFormat;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, pis, pformat);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView>> _callExpression_Pause_Android_Widget_VideoView_ = (view) => view.Pause();
        public static TControl Pause<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_Pause_Android_Widget_VideoView_;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView>> _callExpression_Resume_Android_Widget_VideoView_ = (view) => view.Resume();
        public static TControl Resume<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_Resume_Android_Widget_VideoView_;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, System.Int32>> _callExpression_SeekTo_Android_Widget_VideoView__System_Int32 = (view, param1) => view.SeekTo(param1);
        public static TControl SeekTo<TControl>(this TControl component, System.Int32 pmsec) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SeekTo_Android_Widget_VideoView__System_Int32;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, pmsec);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, Android.Media.AudioAttributes>> _callExpression_SetAudioAttributes_Android_Widget_VideoView__Android_Media_AudioAttributes = (view, param1) => view.SetAudioAttributes(param1);
        public static TControl SetAudioAttributes<TControl>(this TControl component, Android.Media.AudioAttributes pattributes) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetAudioAttributes_Android_Widget_VideoView__Android_Media_AudioAttributes;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, pattributes);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, Android.Media.AudioFocus>> _callExpression_SetAudioFocusRequest_Android_Widget_VideoView__Android_Media_AudioFocus = (view, param1) => view.SetAudioFocusRequest(param1);
        public static TControl SetAudioFocusRequest<TControl>(this TControl component, Android.Media.AudioFocus pfocusGain) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetAudioFocusRequest_Android_Widget_VideoView__Android_Media_AudioFocus;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, pfocusGain);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, Android.Widget.MediaController>> _callExpression_SetMediaController_Android_Widget_VideoView__Android_Widget_MediaController = (view, param1) => view.SetMediaController(param1);
        public static TControl SetMediaController<TControl>(this TControl component, Android.Widget.MediaController pcontroller) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetMediaController_Android_Widget_VideoView__Android_Widget_MediaController;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontroller);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, Android.Media.MediaPlayer.IOnCompletionListener>> _callExpression_SetOnCompletionListener_Android_Widget_VideoView__Android_Media_MediaPlayer_IOnCompletionListener = (view, param1) => view.SetOnCompletionListener(param1);
        public static TControl SetOnCompletionListener<TControl>(this TControl component, Android.Media.MediaPlayer.IOnCompletionListener pl) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetOnCompletionListener_Android_Widget_VideoView__Android_Media_MediaPlayer_IOnCompletionListener;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, Android.Media.MediaPlayer.IOnErrorListener>> _callExpression_SetOnErrorListener_Android_Widget_VideoView__Android_Media_MediaPlayer_IOnErrorListener = (view, param1) => view.SetOnErrorListener(param1);
        public static TControl SetOnErrorListener<TControl>(this TControl component, Android.Media.MediaPlayer.IOnErrorListener pl) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetOnErrorListener_Android_Widget_VideoView__Android_Media_MediaPlayer_IOnErrorListener;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, Android.Media.MediaPlayer.IOnInfoListener>> _callExpression_SetOnInfoListener_Android_Widget_VideoView__Android_Media_MediaPlayer_IOnInfoListener = (view, param1) => view.SetOnInfoListener(param1);
        public static TControl SetOnInfoListener<TControl>(this TControl component, Android.Media.MediaPlayer.IOnInfoListener pl) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetOnInfoListener_Android_Widget_VideoView__Android_Media_MediaPlayer_IOnInfoListener;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, Android.Media.MediaPlayer.IOnPreparedListener>> _callExpression_SetOnPreparedListener_Android_Widget_VideoView__Android_Media_MediaPlayer_IOnPreparedListener = (view, param1) => view.SetOnPreparedListener(param1);
        public static TControl SetOnPreparedListener<TControl>(this TControl component, Android.Media.MediaPlayer.IOnPreparedListener pl) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetOnPreparedListener_Android_Widget_VideoView__Android_Media_MediaPlayer_IOnPreparedListener;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, System.String>> _callExpression_SetVideoPath_Android_Widget_VideoView__System_String = (view, param1) => view.SetVideoPath(param1);
        public static TControl SetVideoPath<TControl>(this TControl component, System.String ppath) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetVideoPath_Android_Widget_VideoView__System_String;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, ppath);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, Android.Net.Uri>> _callExpression_SetVideoURI_Android_Widget_VideoView__Android_Net_Uri = (view, param1) => view.SetVideoURI(param1);
        public static TControl SetVideoURI<TControl>(this TControl component, Android.Net.Uri puri) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetVideoURI_Android_Widget_VideoView__Android_Net_Uri;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, puri);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView, Android.Net.Uri, System.Collections.Generic.IDictionary<System.String,System.String>>> _callExpression_SetVideoURI_Android_Widget_VideoView__Android_Net_Uri_System_Collections_Generic_IDictionary_System_String_System_String_ = (view, param1, param2) => view.SetVideoURI(param1, param2);
        public static TControl SetVideoURI<TControl>(this TControl component, Android.Net.Uri puri, System.Collections.Generic.IDictionary<System.String,System.String> pheaders) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_SetVideoURI_Android_Widget_VideoView__Android_Net_Uri_System_Collections_Generic_IDictionary_System_String_System_String_;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression, puri, pheaders);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView>> _callExpression_Start_Android_Widget_VideoView_ = (view) => view.Start();
        public static TControl Start<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_Start_Android_Widget_VideoView_;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView>> _callExpression_StopPlayback_Android_Widget_VideoView_ = (view) => view.StopPlayback();
        public static TControl StopPlayback<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_StopPlayback_Android_Widget_VideoView_;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_VideoView_Extensions
    {
        private static Expression<Action<Android.Widget.VideoView>> _callExpression_Suspend_Android_Widget_VideoView_ = (view) => view.Suspend();
        public static TControl Suspend<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.VideoView>
        {
            var callExpression = _callExpression_Suspend_Android_Widget_VideoView_;

            Reflect<Android.Widget.VideoView>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.ViewAnimator> ViewAnimator(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.ViewAnimator(default);
            }

            var control = View<Android.Widget.ViewAnimator>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_ViewAnimator_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DisplayedChild = AttributeReflectionHelper.ResolveFor<Android.Widget.ViewAnimator, System.Int32>
        (v => v.DisplayedChild);


        public static TControl DisplayedChild<TControl>(this TControl component, System.Int32 pDisplayedChild)  where TControl:IReflectedPrimitive<Android.Widget.ViewAnimator>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ViewAnimator t = default;
                t.DisplayedChild = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_DisplayedChild,pDisplayedChild);
            return component;
        }
    }
    public static partial class Android_Widget_ViewAnimator_Extensions
    {
        private static readonly Attribute<Android.Views.Animations.Animation> Attribute_Animation_InAnimation = AttributeReflectionHelper.ResolveFor<Android.Widget.ViewAnimator, Android.Views.Animations.Animation>
        (v => v.InAnimation);


        public static TControl InAnimation<TControl>(this TControl component, Android.Views.Animations.Animation pInAnimation)  where TControl:IReflectedPrimitive<Android.Widget.ViewAnimator>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ViewAnimator t = default;
                t.InAnimation = default;
            }

            component.Attributes.SetAttribute(Attribute_Animation_InAnimation,pInAnimation);
            return component;
        }
    }
    public static partial class Android_Widget_ViewAnimator_Extensions
    {
        private static readonly Attribute<Android.Views.Animations.Animation> Attribute_Animation_OutAnimation = AttributeReflectionHelper.ResolveFor<Android.Widget.ViewAnimator, Android.Views.Animations.Animation>
        (v => v.OutAnimation);


        public static TControl OutAnimation<TControl>(this TControl component, Android.Views.Animations.Animation pOutAnimation)  where TControl:IReflectedPrimitive<Android.Widget.ViewAnimator>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ViewAnimator t = default;
                t.OutAnimation = default;
            }

            component.Attributes.SetAttribute(Attribute_Animation_OutAnimation,pOutAnimation);
            return component;
        }
    }


    public static partial class Android_Widget_ViewAnimator_Extensions
    {
        private static Expression<Action<Android.Widget.ViewAnimator, System.Boolean>> _callExpression_SetAnimateFirstView_Android_Widget_ViewAnimator__System_Boolean = (view, param1) => view.SetAnimateFirstView(param1);
        public static TControl SetAnimateFirstView<TControl>(this TControl component, System.Boolean panimate) where TControl:IReflectedPrimitive<Android.Widget.ViewAnimator>
        {
            var callExpression = _callExpression_SetAnimateFirstView_Android_Widget_ViewAnimator__System_Boolean;

            Reflect<Android.Widget.ViewAnimator>.ReflectionHelpers.Call(component.Attributes,callExpression, panimate);
            return component;
        }
    }
    public static partial class Android_Widget_ViewAnimator_Extensions
    {
        private static Expression<Action<Android.Widget.ViewAnimator, Android.Content.Context, System.Int32>> _callExpression_SetInAnimation_Android_Widget_ViewAnimator__Android_Content_Context_System_Int32 = (view, param1, param2) => view.SetInAnimation(param1, param2);
        public static TControl SetInAnimation<TControl>(this TControl component, Android.Content.Context pcontext, System.Int32 presourceID) where TControl:IReflectedPrimitive<Android.Widget.ViewAnimator>
        {
            var callExpression = _callExpression_SetInAnimation_Android_Widget_ViewAnimator__Android_Content_Context_System_Int32;

            Reflect<Android.Widget.ViewAnimator>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontext, presourceID);
            return component;
        }
    }
    public static partial class Android_Widget_ViewAnimator_Extensions
    {
        private static Expression<Action<Android.Widget.ViewAnimator, Android.Content.Context, System.Int32>> _callExpression_SetOutAnimation_Android_Widget_ViewAnimator__Android_Content_Context_System_Int32 = (view, param1, param2) => view.SetOutAnimation(param1, param2);
        public static TControl SetOutAnimation<TControl>(this TControl component, Android.Content.Context pcontext, System.Int32 presourceID) where TControl:IReflectedPrimitive<Android.Widget.ViewAnimator>
        {
            var callExpression = _callExpression_SetOutAnimation_Android_Widget_ViewAnimator__Android_Content_Context_System_Int32;

            Reflect<Android.Widget.ViewAnimator>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontext, presourceID);
            return component;
        }
    }
    public static partial class Android_Widget_ViewAnimator_Extensions
    {
        private static Expression<Action<Android.Widget.ViewAnimator>> _callExpression_ShowNext_Android_Widget_ViewAnimator_ = (view) => view.ShowNext();
        public static TControl ShowNext<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.ViewAnimator>
        {
            var callExpression = _callExpression_ShowNext_Android_Widget_ViewAnimator_;

            Reflect<Android.Widget.ViewAnimator>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_ViewAnimator_Extensions
    {
        private static Expression<Action<Android.Widget.ViewAnimator>> _callExpression_ShowPrevious_Android_Widget_ViewAnimator_ = (view) => view.ShowPrevious();
        public static TControl ShowPrevious<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.ViewAnimator>
        {
            var callExpression = _callExpression_ShowPrevious_Android_Widget_ViewAnimator_;

            Reflect<Android.Widget.ViewAnimator>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Widget.ViewFlipper> ViewFlipper(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Widget.ViewFlipper(default);
            }

            var control = View<Android.Widget.ViewFlipper>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Widget_ViewFlipper_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_AutoStart = AttributeReflectionHelper.ResolveFor<Android.Widget.ViewFlipper, System.Boolean>
        (v => v.AutoStart);


        public static TControl AutoStart<TControl>(this TControl component, System.Boolean pAutoStart)  where TControl:IReflectedPrimitive<Android.Widget.ViewFlipper>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Widget.ViewFlipper t = default;
                t.AutoStart = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_AutoStart,pAutoStart);
            return component;
        }
    }


    public static partial class Android_Widget_ViewFlipper_Extensions
    {
        private static Expression<Action<Android.Widget.ViewFlipper, System.Int32>> _callExpression_SetFlipInterval_Android_Widget_ViewFlipper__System_Int32 = (view, param1) => view.SetFlipInterval(param1);
        public static TControl SetFlipInterval<TControl>(this TControl component, System.Int32 pmilliseconds) where TControl:IReflectedPrimitive<Android.Widget.ViewFlipper>
        {
            var callExpression = _callExpression_SetFlipInterval_Android_Widget_ViewFlipper__System_Int32;

            Reflect<Android.Widget.ViewFlipper>.ReflectionHelpers.Call(component.Attributes,callExpression, pmilliseconds);
            return component;
        }
    }
    public static partial class Android_Widget_ViewFlipper_Extensions
    {
        private static Expression<Action<Android.Widget.ViewFlipper>> _callExpression_StartFlipping_Android_Widget_ViewFlipper_ = (view) => view.StartFlipping();
        public static TControl StartFlipping<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.ViewFlipper>
        {
            var callExpression = _callExpression_StartFlipping_Android_Widget_ViewFlipper_;

            Reflect<Android.Widget.ViewFlipper>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_ViewFlipper_Extensions
    {
        private static Expression<Action<Android.Widget.ViewFlipper>> _callExpression_StopFlipping_Android_Widget_ViewFlipper_ = (view) => view.StopFlipping();
        public static TControl StopFlipping<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.ViewFlipper>
        {
            var callExpression = _callExpression_StopFlipping_Android_Widget_ViewFlipper_;

            Reflect<Android.Widget.ViewFlipper>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }



    public static partial class Android_Widget_ViewSwitcher_Extensions
    {
        private static Expression<Action<Android.Widget.ViewSwitcher>> _callExpression_Reset_Android_Widget_ViewSwitcher_ = (view) => view.Reset();
        public static TControl Reset<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Widget.ViewSwitcher>
        {
            var callExpression = _callExpression_Reset_Android_Widget_ViewSwitcher_;

            Reflect<Android.Widget.ViewSwitcher>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Widget_ViewSwitcher_Extensions
    {
        private static Expression<Action<Android.Widget.ViewSwitcher, Android.Widget.ViewSwitcher.IViewFactory>> _callExpression_SetFactory_Android_Widget_ViewSwitcher__Android_Widget_ViewSwitcher_IViewFactory = (view, param1) => view.SetFactory(param1);
        public static TControl SetFactory<TControl>(this TControl component, Android.Widget.ViewSwitcher.IViewFactory pfactory) where TControl:IReflectedPrimitive<Android.Widget.ViewSwitcher>
        {
            var callExpression = _callExpression_SetFactory_Android_Widget_ViewSwitcher__Android_Widget_ViewSwitcher_IViewFactory;

            Reflect<Android.Widget.ViewSwitcher>.ReflectionHelpers.Call(component.Attributes,callExpression, pfactory);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Views.View> View(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Views.View(default);
            }

            var control = View<Android.Views.View>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_AccessibilityHeading = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.AccessibilityHeading);


        public static TControl AccessibilityHeading<TControl>(this TControl component, System.Boolean pAccessibilityHeading)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.AccessibilityHeading = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_AccessibilityHeading,pAccessibilityHeading);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.AccessibilityLiveRegion> Attribute_AccessibilityLiveRegion_AccessibilityLiveRegion = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.AccessibilityLiveRegion>
        (v => v.AccessibilityLiveRegion);


        public static TControl AccessibilityLiveRegion<TControl>(this TControl component, Android.Views.AccessibilityLiveRegion pAccessibilityLiveRegion)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.AccessibilityLiveRegion = default;
            }

            component.Attributes.SetAttribute(Attribute_AccessibilityLiveRegion_AccessibilityLiveRegion,pAccessibilityLiveRegion);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_AccessibilityPaneTitleFormatted = AttributeReflectionHelper.ResolveFor<Android.Views.View, Java.Lang.ICharSequence>
        (v => v.AccessibilityPaneTitleFormatted);


        public static TControl AccessibilityPaneTitleFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pAccessibilityPaneTitleFormatted)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.AccessibilityPaneTitleFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_AccessibilityPaneTitleFormatted,pAccessibilityPaneTitleFormatted);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_AccessibilityPaneTitle = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.String>
        (v => v.AccessibilityPaneTitle);


        public static TControl AccessibilityPaneTitle<TControl>(this TControl component, System.String pAccessibilityPaneTitle)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.AccessibilityPaneTitle = default;
            }

            component.Attributes.SetAttribute(Attribute_String_AccessibilityPaneTitle,pAccessibilityPaneTitle);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_AccessibilityTraversalAfter = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.AccessibilityTraversalAfter);


        public static TControl AccessibilityTraversalAfter<TControl>(this TControl component, System.Int32 pAccessibilityTraversalAfter)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.AccessibilityTraversalAfter = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_AccessibilityTraversalAfter,pAccessibilityTraversalAfter);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_AccessibilityTraversalBefore = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.AccessibilityTraversalBefore);


        public static TControl AccessibilityTraversalBefore<TControl>(this TControl component, System.Int32 pAccessibilityTraversalBefore)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.AccessibilityTraversalBefore = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_AccessibilityTraversalBefore,pAccessibilityTraversalBefore);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Activated = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.Activated);


        public static TControl Activated<TControl>(this TControl component, System.Boolean pActivated)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Activated = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Activated,pActivated);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_Alpha = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.Alpha);


        public static TControl Alpha<TControl>(this TControl component, System.Single pAlpha)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Alpha = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_Alpha,pAlpha);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.Animations.Animation> Attribute_Animation_Animation = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.Animations.Animation>
        (v => v.Animation);


        public static TControl Animation<TControl>(this TControl component, Android.Views.Animations.Animation pAnimation)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Animation = default;
            }

            component.Attributes.SetAttribute(Attribute_Animation_Animation,pAnimation);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.Autofill.AutofillId> Attribute_AutofillId_AutofillId = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.Autofill.AutofillId>
        (v => v.AutofillId);


        public static TControl AutofillId<TControl>(this TControl component, Android.Views.Autofill.AutofillId pAutofillId)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.AutofillId = default;
            }

            component.Attributes.SetAttribute(Attribute_AutofillId_AutofillId,pAutofillId);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_Background = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Graphics.Drawables.Drawable>
        (v => v.Background);


        public static TControl Background<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pBackground)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Background = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_Background,pBackground);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_BackgroundTintList = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Content.Res.ColorStateList>
        (v => v.BackgroundTintList);


        public static TControl BackgroundTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pBackgroundTintList)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.BackgroundTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_BackgroundTintList,pBackgroundTintList);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_BackgroundTintMode = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Graphics.PorterDuff.Mode>
        (v => v.BackgroundTintMode);


        public static TControl BackgroundTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pBackgroundTintMode)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.BackgroundTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_BackgroundTintMode,pBackgroundTintMode);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Bottom = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.Bottom);


        public static TControl Bottom<TControl>(this TControl component, System.Int32 pBottom)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Bottom = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Bottom,pBottom);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Clickable = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.Clickable);


        public static TControl Clickable<TControl>(this TControl component, System.Boolean pClickable)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Clickable = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Clickable,pClickable);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Graphics.Rect> Attribute_Rect_ClipBounds = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Graphics.Rect>
        (v => v.ClipBounds);


        public static TControl ClipBounds<TControl>(this TControl component, Android.Graphics.Rect pClipBounds)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ClipBounds = default;
            }

            component.Attributes.SetAttribute(Attribute_Rect_ClipBounds,pClipBounds);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ClipToOutline = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.ClipToOutline);


        public static TControl ClipToOutline<TControl>(this TControl component, System.Boolean pClipToOutline)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ClipToOutline = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_ClipToOutline,pClipToOutline);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_ContentDescriptionFormatted = AttributeReflectionHelper.ResolveFor<Android.Views.View, Java.Lang.ICharSequence>
        (v => v.ContentDescriptionFormatted);


        public static TControl ContentDescriptionFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pContentDescriptionFormatted)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ContentDescriptionFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_ContentDescriptionFormatted,pContentDescriptionFormatted);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_ContentDescription = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.String>
        (v => v.ContentDescription);


        public static TControl ContentDescription<TControl>(this TControl component, System.String pContentDescription)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ContentDescription = default;
            }

            component.Attributes.SetAttribute(Attribute_String_ContentDescription,pContentDescription);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ContextClickable = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.ContextClickable);


        public static TControl ContextClickable<TControl>(this TControl component, System.Boolean pContextClickable)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ContextClickable = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_ContextClickable,pContextClickable);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_DefaultFocusHighlightEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.DefaultFocusHighlightEnabled);


        public static TControl DefaultFocusHighlightEnabled<TControl>(this TControl component, System.Boolean pDefaultFocusHighlightEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.DefaultFocusHighlightEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_DefaultFocusHighlightEnabled,pDefaultFocusHighlightEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Graphics.Color> Attribute_Color_DrawingCacheBackgroundColor = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Graphics.Color>
        (v => v.DrawingCacheBackgroundColor);


        public static TControl DrawingCacheBackgroundColor<TControl>(this TControl component, Android.Graphics.Color pDrawingCacheBackgroundColor)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.DrawingCacheBackgroundColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_DrawingCacheBackgroundColor,pDrawingCacheBackgroundColor);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_DrawingCacheEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.DrawingCacheEnabled);


        public static TControl DrawingCacheEnabled<TControl>(this TControl component, System.Boolean pDrawingCacheEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.DrawingCacheEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_DrawingCacheEnabled,pDrawingCacheEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.DrawingCacheQuality> Attribute_DrawingCacheQuality_DrawingCacheQuality = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.DrawingCacheQuality>
        (v => v.DrawingCacheQuality);


        public static TControl DrawingCacheQuality<TControl>(this TControl component, Android.Views.DrawingCacheQuality pDrawingCacheQuality)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.DrawingCacheQuality = default;
            }

            component.Attributes.SetAttribute(Attribute_DrawingCacheQuality_DrawingCacheQuality,pDrawingCacheQuality);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_DuplicateParentStateEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.DuplicateParentStateEnabled);


        public static TControl DuplicateParentStateEnabled<TControl>(this TControl component, System.Boolean pDuplicateParentStateEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.DuplicateParentStateEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_DuplicateParentStateEnabled,pDuplicateParentStateEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_Elevation = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.Elevation);


        public static TControl Elevation<TControl>(this TControl component, System.Single pElevation)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Elevation = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_Elevation,pElevation);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Enabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.Enabled);


        public static TControl Enabled<TControl>(this TControl component, System.Boolean pEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Enabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Enabled,pEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_FilterTouchesWhenObscured = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.FilterTouchesWhenObscured);


        public static TControl FilterTouchesWhenObscured<TControl>(this TControl component, System.Boolean pFilterTouchesWhenObscured)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.FilterTouchesWhenObscured = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_FilterTouchesWhenObscured,pFilterTouchesWhenObscured);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Focusable = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.Focusable);


        public static TControl Focusable<TControl>(this TControl component, System.Boolean pFocusable)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Focusable = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Focusable,pFocusable);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_FocusableInTouchMode = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.FocusableInTouchMode);


        public static TControl FocusableInTouchMode<TControl>(this TControl component, System.Boolean pFocusableInTouchMode)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.FocusableInTouchMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_FocusableInTouchMode,pFocusableInTouchMode);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_FocusedByDefault = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.FocusedByDefault);


        public static TControl FocusedByDefault<TControl>(this TControl component, System.Boolean pFocusedByDefault)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.FocusedByDefault = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_FocusedByDefault,pFocusedByDefault);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Graphics.Drawables.Drawable> Attribute_Drawable_Foreground = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Graphics.Drawables.Drawable>
        (v => v.Foreground);


        public static TControl Foreground<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pForeground)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Foreground = default;
            }

            component.Attributes.SetAttribute(Attribute_Drawable_Foreground,pForeground);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Content.Res.ColorStateList> Attribute_ColorStateList_ForegroundTintList = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Content.Res.ColorStateList>
        (v => v.ForegroundTintList);


        public static TControl ForegroundTintList<TControl>(this TControl component, Android.Content.Res.ColorStateList pForegroundTintList)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ForegroundTintList = default;
            }

            component.Attributes.SetAttribute(Attribute_ColorStateList_ForegroundTintList,pForegroundTintList);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Graphics.PorterDuff.Mode> Attribute_Mode_ForegroundTintMode = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Graphics.PorterDuff.Mode>
        (v => v.ForegroundTintMode);


        public static TControl ForegroundTintMode<TControl>(this TControl component, Android.Graphics.PorterDuff.Mode pForegroundTintMode)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ForegroundTintMode = default;
            }

            component.Attributes.SetAttribute(Attribute_Mode_ForegroundTintMode,pForegroundTintMode);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_HapticFeedbackEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.HapticFeedbackEnabled);


        public static TControl HapticFeedbackEnabled<TControl>(this TControl component, System.Boolean pHapticFeedbackEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.HapticFeedbackEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_HapticFeedbackEnabled,pHapticFeedbackEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_HasTransientState = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.HasTransientState);


        public static TControl HasTransientState<TControl>(this TControl component, System.Boolean pHasTransientState)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.HasTransientState = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_HasTransientState,pHasTransientState);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_HorizontalFadingEdgeEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.HorizontalFadingEdgeEnabled);


        public static TControl HorizontalFadingEdgeEnabled<TControl>(this TControl component, System.Boolean pHorizontalFadingEdgeEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.HorizontalFadingEdgeEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_HorizontalFadingEdgeEnabled,pHorizontalFadingEdgeEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_HorizontalScrollBarEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.HorizontalScrollBarEnabled);


        public static TControl HorizontalScrollBarEnabled<TControl>(this TControl component, System.Boolean pHorizontalScrollBarEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.HorizontalScrollBarEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_HorizontalScrollBarEnabled,pHorizontalScrollBarEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Hovered = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.Hovered);


        public static TControl Hovered<TControl>(this TControl component, System.Boolean pHovered)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Hovered = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Hovered,pHovered);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Id = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.Id);


        public static TControl Id<TControl>(this TControl component, System.Int32 pId)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Id = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Id,pId);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.ImportantForAccessibility> Attribute_ImportantForAccessibility_ImportantForAccessibility = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.ImportantForAccessibility>
        (v => v.ImportantForAccessibility);


        public static TControl ImportantForAccessibility<TControl>(this TControl component, Android.Views.ImportantForAccessibility pImportantForAccessibility)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ImportantForAccessibility = default;
            }

            component.Attributes.SetAttribute(Attribute_ImportantForAccessibility_ImportantForAccessibility,pImportantForAccessibility);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.ImportantForAutofill> Attribute_ImportantForAutofill_ImportantForAutofill = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.ImportantForAutofill>
        (v => v.ImportantForAutofill);


        public static TControl ImportantForAutofill<TControl>(this TControl component, Android.Views.ImportantForAutofill pImportantForAutofill)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ImportantForAutofill = default;
            }

            component.Attributes.SetAttribute(Attribute_ImportantForAutofill_ImportantForAutofill,pImportantForAutofill);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_KeepScreenOn = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.KeepScreenOn);


        public static TControl KeepScreenOn<TControl>(this TControl component, System.Boolean pKeepScreenOn)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.KeepScreenOn = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_KeepScreenOn,pKeepScreenOn);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_KeyboardNavigationCluster = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.KeyboardNavigationCluster);


        public static TControl KeyboardNavigationCluster<TControl>(this TControl component, System.Boolean pKeyboardNavigationCluster)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.KeyboardNavigationCluster = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_KeyboardNavigationCluster,pKeyboardNavigationCluster);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_LabelFor = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.LabelFor);


        public static TControl LabelFor<TControl>(this TControl component, System.Int32 pLabelFor)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.LabelFor = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_LabelFor,pLabelFor);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.LayoutDirection> Attribute_LayoutDirection_LayoutDirection = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.LayoutDirection>
        (v => v.LayoutDirection);


        public static TControl LayoutDirection<TControl>(this TControl component, Android.Views.LayoutDirection pLayoutDirection)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.LayoutDirection = default;
            }

            component.Attributes.SetAttribute(Attribute_LayoutDirection_LayoutDirection,pLayoutDirection);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.ViewGroup.LayoutParams> Attribute_LayoutParams_LayoutParameters = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.ViewGroup.LayoutParams>
        (v => v.LayoutParameters);


        public static TControl LayoutParameters<TControl>(this TControl component, Android.Views.ViewGroup.LayoutParams pLayoutParameters)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.LayoutParameters = default;
            }

            component.Attributes.SetAttribute(Attribute_LayoutParams_LayoutParameters,pLayoutParameters);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Left = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.Left);


        public static TControl Left<TControl>(this TControl component, System.Int32 pLeft)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Left = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Left,pLeft);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_LongClickable = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.LongClickable);


        public static TControl LongClickable<TControl>(this TControl component, System.Boolean pLongClickable)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.LongClickable = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_LongClickable,pLongClickable);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_NestedScrollingEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.NestedScrollingEnabled);


        public static TControl NestedScrollingEnabled<TControl>(this TControl component, System.Boolean pNestedScrollingEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.NestedScrollingEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_NestedScrollingEnabled,pNestedScrollingEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_NextClusterForwardId = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.NextClusterForwardId);


        public static TControl NextClusterForwardId<TControl>(this TControl component, System.Int32 pNextClusterForwardId)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.NextClusterForwardId = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_NextClusterForwardId,pNextClusterForwardId);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_NextFocusDownId = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.NextFocusDownId);


        public static TControl NextFocusDownId<TControl>(this TControl component, System.Int32 pNextFocusDownId)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.NextFocusDownId = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_NextFocusDownId,pNextFocusDownId);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_NextFocusForwardId = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.NextFocusForwardId);


        public static TControl NextFocusForwardId<TControl>(this TControl component, System.Int32 pNextFocusForwardId)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.NextFocusForwardId = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_NextFocusForwardId,pNextFocusForwardId);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_NextFocusLeftId = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.NextFocusLeftId);


        public static TControl NextFocusLeftId<TControl>(this TControl component, System.Int32 pNextFocusLeftId)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.NextFocusLeftId = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_NextFocusLeftId,pNextFocusLeftId);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_NextFocusRightId = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.NextFocusRightId);


        public static TControl NextFocusRightId<TControl>(this TControl component, System.Int32 pNextFocusRightId)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.NextFocusRightId = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_NextFocusRightId,pNextFocusRightId);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_NextFocusUpId = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.NextFocusUpId);


        public static TControl NextFocusUpId<TControl>(this TControl component, System.Int32 pNextFocusUpId)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.NextFocusUpId = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_NextFocusUpId,pNextFocusUpId);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.View.IOnFocusChangeListener> Attribute_IOnFocusChangeListener_OnFocusChangeListener = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.View.IOnFocusChangeListener>
        (v => v.OnFocusChangeListener);


        public static TControl OnFocusChangeListener<TControl>(this TControl component, Android.Views.View.IOnFocusChangeListener pOnFocusChangeListener)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.OnFocusChangeListener = default;
            }

            component.Attributes.SetAttribute(Attribute_IOnFocusChangeListener_OnFocusChangeListener,pOnFocusChangeListener);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.ViewOutlineProvider> Attribute_ViewOutlineProvider_OutlineProvider = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.ViewOutlineProvider>
        (v => v.OutlineProvider);


        public static TControl OutlineProvider<TControl>(this TControl component, Android.Views.ViewOutlineProvider pOutlineProvider)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.OutlineProvider = default;
            }

            component.Attributes.SetAttribute(Attribute_ViewOutlineProvider_OutlineProvider,pOutlineProvider);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.OverScrollMode> Attribute_OverScrollMode_OverScrollMode = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.OverScrollMode>
        (v => v.OverScrollMode);


        public static TControl OverScrollMode<TControl>(this TControl component, Android.Views.OverScrollMode pOverScrollMode)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.OverScrollMode = default;
            }

            component.Attributes.SetAttribute(Attribute_OverScrollMode_OverScrollMode,pOverScrollMode);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_PivotX = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.PivotX);


        public static TControl PivotX<TControl>(this TControl component, System.Single pPivotX)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.PivotX = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_PivotX,pPivotX);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_PivotY = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.PivotY);


        public static TControl PivotY<TControl>(this TControl component, System.Single pPivotY)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.PivotY = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_PivotY,pPivotY);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.PointerIcon> Attribute_PointerIcon_PointerIcon = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.PointerIcon>
        (v => v.PointerIcon);


        public static TControl PointerIcon<TControl>(this TControl component, Android.Views.PointerIcon pPointerIcon)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.PointerIcon = default;
            }

            component.Attributes.SetAttribute(Attribute_PointerIcon_PointerIcon,pPointerIcon);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Pressed = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.Pressed);


        public static TControl Pressed<TControl>(this TControl component, System.Boolean pPressed)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Pressed = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Pressed,pPressed);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_RevealOnFocusHint = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.RevealOnFocusHint);


        public static TControl RevealOnFocusHint<TControl>(this TControl component, System.Boolean pRevealOnFocusHint)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.RevealOnFocusHint = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_RevealOnFocusHint,pRevealOnFocusHint);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Right = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.Right);


        public static TControl Right<TControl>(this TControl component, System.Int32 pRight)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Right = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Right,pRight);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_Rotation = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.Rotation);


        public static TControl Rotation<TControl>(this TControl component, System.Single pRotation)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Rotation = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_Rotation,pRotation);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_RotationX = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.RotationX);


        public static TControl RotationX<TControl>(this TControl component, System.Single pRotationX)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.RotationX = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_RotationX,pRotationX);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_RotationY = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.RotationY);


        public static TControl RotationY<TControl>(this TControl component, System.Single pRotationY)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.RotationY = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_RotationY,pRotationY);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_SaveEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.SaveEnabled);


        public static TControl SaveEnabled<TControl>(this TControl component, System.Boolean pSaveEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.SaveEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_SaveEnabled,pSaveEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_SaveFromParentEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.SaveFromParentEnabled);


        public static TControl SaveFromParentEnabled<TControl>(this TControl component, System.Boolean pSaveFromParentEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.SaveFromParentEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_SaveFromParentEnabled,pSaveFromParentEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_ScaleX = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.ScaleX);


        public static TControl ScaleX<TControl>(this TControl component, System.Single pScaleX)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScaleX = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_ScaleX,pScaleX);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_ScaleY = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.ScaleY);


        public static TControl ScaleY<TControl>(this TControl component, System.Single pScaleY)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScaleY = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_ScaleY,pScaleY);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ScreenReaderFocusable = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.ScreenReaderFocusable);


        public static TControl ScreenReaderFocusable<TControl>(this TControl component, System.Boolean pScreenReaderFocusable)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScreenReaderFocusable = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_ScreenReaderFocusable,pScreenReaderFocusable);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ScrollBarDefaultDelayBeforeFade = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.ScrollBarDefaultDelayBeforeFade);


        public static TControl ScrollBarDefaultDelayBeforeFade<TControl>(this TControl component, System.Int32 pScrollBarDefaultDelayBeforeFade)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScrollBarDefaultDelayBeforeFade = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ScrollBarDefaultDelayBeforeFade,pScrollBarDefaultDelayBeforeFade);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ScrollBarFadeDuration = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.ScrollBarFadeDuration);


        public static TControl ScrollBarFadeDuration<TControl>(this TControl component, System.Int32 pScrollBarFadeDuration)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScrollBarFadeDuration = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ScrollBarFadeDuration,pScrollBarFadeDuration);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ScrollBarSize = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.ScrollBarSize);


        public static TControl ScrollBarSize<TControl>(this TControl component, System.Int32 pScrollBarSize)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScrollBarSize = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ScrollBarSize,pScrollBarSize);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.ScrollbarStyles> Attribute_ScrollbarStyles_ScrollBarStyle = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.ScrollbarStyles>
        (v => v.ScrollBarStyle);


        public static TControl ScrollBarStyle<TControl>(this TControl component, Android.Views.ScrollbarStyles pScrollBarStyle)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScrollBarStyle = default;
            }

            component.Attributes.SetAttribute(Attribute_ScrollbarStyles_ScrollBarStyle,pScrollBarStyle);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ScrollX = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.ScrollX);


        public static TControl ScrollX<TControl>(this TControl component, System.Int32 pScrollX)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScrollX = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ScrollX,pScrollX);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ScrollY = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.ScrollY);


        public static TControl ScrollY<TControl>(this TControl component, System.Int32 pScrollY)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScrollY = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_ScrollY,pScrollY);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ScrollbarFadingEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.ScrollbarFadingEnabled);


        public static TControl ScrollbarFadingEnabled<TControl>(this TControl component, System.Boolean pScrollbarFadingEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ScrollbarFadingEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_ScrollbarFadingEnabled,pScrollbarFadingEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Selected = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.Selected);


        public static TControl Selected<TControl>(this TControl component, System.Boolean pSelected)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Selected = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Selected,pSelected);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_SoundEffectsEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.SoundEffectsEnabled);


        public static TControl SoundEffectsEnabled<TControl>(this TControl component, System.Boolean pSoundEffectsEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.SoundEffectsEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_SoundEffectsEnabled,pSoundEffectsEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Animation.StateListAnimator> Attribute_StateListAnimator_StateListAnimator = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Animation.StateListAnimator>
        (v => v.StateListAnimator);


        public static TControl StateListAnimator<TControl>(this TControl component, Android.Animation.StateListAnimator pStateListAnimator)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.StateListAnimator = default;
            }

            component.Attributes.SetAttribute(Attribute_StateListAnimator_StateListAnimator,pStateListAnimator);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.StatusBarVisibility> Attribute_StatusBarVisibility_SystemUiVisibility = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.StatusBarVisibility>
        (v => v.SystemUiVisibility);


        public static TControl SystemUiVisibility<TControl>(this TControl component, Android.Views.StatusBarVisibility pSystemUiVisibility)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.SystemUiVisibility = default;
            }

            component.Attributes.SetAttribute(Attribute_StatusBarVisibility_SystemUiVisibility,pSystemUiVisibility);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Java.Lang.Object> Attribute_Object_Tag = AttributeReflectionHelper.ResolveFor<Android.Views.View, Java.Lang.Object>
        (v => v.Tag);


        public static TControl Tag<TControl>(this TControl component, Java.Lang.Object pTag)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Tag = default;
            }

            component.Attributes.SetAttribute(Attribute_Object_Tag,pTag);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.TextAlignment> Attribute_TextAlignment_TextAlignment = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.TextAlignment>
        (v => v.TextAlignment);


        public static TControl TextAlignment<TControl>(this TControl component, Android.Views.TextAlignment pTextAlignment)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.TextAlignment = default;
            }

            component.Attributes.SetAttribute(Attribute_TextAlignment_TextAlignment,pTextAlignment);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.TextDirection> Attribute_TextDirection_TextDirection = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.TextDirection>
        (v => v.TextDirection);


        public static TControl TextDirection<TControl>(this TControl component, Android.Views.TextDirection pTextDirection)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.TextDirection = default;
            }

            component.Attributes.SetAttribute(Attribute_TextDirection_TextDirection,pTextDirection);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_TooltipTextFormatted = AttributeReflectionHelper.ResolveFor<Android.Views.View, Java.Lang.ICharSequence>
        (v => v.TooltipTextFormatted);


        public static TControl TooltipTextFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pTooltipTextFormatted)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.TooltipTextFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_TooltipTextFormatted,pTooltipTextFormatted);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_TooltipText = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.String>
        (v => v.TooltipText);


        public static TControl TooltipText<TControl>(this TControl component, System.String pTooltipText)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.TooltipText = default;
            }

            component.Attributes.SetAttribute(Attribute_String_TooltipText,pTooltipText);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_Top = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Int32>
        (v => v.Top);


        public static TControl Top<TControl>(this TControl component, System.Int32 pTop)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Top = default;
            }

            component.Attributes.SetAttribute(Attribute_Int32_Top,pTop);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.TouchDelegate> Attribute_TouchDelegate_TouchDelegate = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.TouchDelegate>
        (v => v.TouchDelegate);


        public static TControl TouchDelegate<TControl>(this TControl component, Android.Views.TouchDelegate pTouchDelegate)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.TouchDelegate = default;
            }

            component.Attributes.SetAttribute(Attribute_TouchDelegate_TouchDelegate,pTouchDelegate);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_TransitionName = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.String>
        (v => v.TransitionName);


        public static TControl TransitionName<TControl>(this TControl component, System.String pTransitionName)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.TransitionName = default;
            }

            component.Attributes.SetAttribute(Attribute_String_TransitionName,pTransitionName);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_TranslationX = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.TranslationX);


        public static TControl TranslationX<TControl>(this TControl component, System.Single pTranslationX)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.TranslationX = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_TranslationX,pTranslationX);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_TranslationY = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.TranslationY);


        public static TControl TranslationY<TControl>(this TControl component, System.Single pTranslationY)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.TranslationY = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_TranslationY,pTranslationY);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_TranslationZ = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Single>
        (v => v.TranslationZ);


        public static TControl TranslationZ<TControl>(this TControl component, System.Single pTranslationZ)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.TranslationZ = default;
            }

            component.Attributes.SetAttribute(Attribute_Single_TranslationZ,pTranslationZ);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_VerticalFadingEdgeEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.VerticalFadingEdgeEnabled);


        public static TControl VerticalFadingEdgeEnabled<TControl>(this TControl component, System.Boolean pVerticalFadingEdgeEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.VerticalFadingEdgeEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_VerticalFadingEdgeEnabled,pVerticalFadingEdgeEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_VerticalScrollBarEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.View, System.Boolean>
        (v => v.VerticalScrollBarEnabled);


        public static TControl VerticalScrollBarEnabled<TControl>(this TControl component, System.Boolean pVerticalScrollBarEnabled)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.VerticalScrollBarEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_VerticalScrollBarEnabled,pVerticalScrollBarEnabled);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.ScrollbarPosition> Attribute_ScrollbarPosition_VerticalScrollbarPosition = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.ScrollbarPosition>
        (v => v.VerticalScrollbarPosition);


        public static TControl VerticalScrollbarPosition<TControl>(this TControl component, Android.Views.ScrollbarPosition pVerticalScrollbarPosition)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.VerticalScrollbarPosition = default;
            }

            component.Attributes.SetAttribute(Attribute_ScrollbarPosition_VerticalScrollbarPosition,pVerticalScrollbarPosition);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.ViewStates> Attribute_ViewStates_Visibility = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.ViewStates>
        (v => v.Visibility);


        public static TControl Visibility<TControl>(this TControl component, Android.Views.ViewStates pVisibility)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.Visibility = default;
            }

            component.Attributes.SetAttribute(Attribute_ViewStates_Visibility,pVisibility);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static readonly Attribute<Android.Views.View.ApplyWindowInsetsHandler> Attribute_ApplyWindowInsetsHandler_ApplyWindowInsets = AttributeReflectionHelper.ResolveFor<Android.Views.View, Android.Views.View.ApplyWindowInsetsHandler>
        (v => v.ApplyWindowInsets);


        public static TControl ApplyWindowInsets<TControl>(this TControl component, Android.Views.View.ApplyWindowInsetsHandler pApplyWindowInsets)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.View t = default;
                t.ApplyWindowInsets = default;
            }

            component.Attributes.SetAttribute(Attribute_ApplyWindowInsetsHandler_ApplyWindowInsets,pApplyWindowInsets);
            return component;
        }
    }

public static partial class Android_Views_View_Extensions
{
    public static TControl OnViewAttachedToWindow<TControl>(this TControl control,Action<Android.Views.View.ViewAttachedToWindowEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.ViewAttachedToWindow += handler;
            tv.ViewAttachedToWindow -= handler;
        }

        control.Event(x => nameof(x.ViewAttachedToWindow),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnViewDetachedFromWindow<TControl>(this TControl control,Action<Android.Views.View.ViewDetachedFromWindowEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.ViewDetachedFromWindow += handler;
            tv.ViewDetachedFromWindow -= handler;
        }

        control.Event(x => nameof(x.ViewDetachedFromWindow),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnLayoutChange<TControl>(this TControl control,Action<Android.Views.View.LayoutChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.LayoutChange += handler;
            tv.LayoutChange -= handler;
        }

        control.Event(x => nameof(x.LayoutChange),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnUnhandledKeyEvent<TControl>(this TControl control,Action<Android.Views.View.UnhandledKeyEventEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.UnhandledKeyEvent += handler;
            tv.UnhandledKeyEvent -= handler;
        }

        control.Event(x => nameof(x.UnhandledKeyEvent),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnCapturedPointer<TControl>(this TControl control,Action<Android.Views.View.CapturedPointerEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.CapturedPointer += handler;
            tv.CapturedPointer -= handler;
        }

        control.Event(x => nameof(x.CapturedPointer),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnClick<TControl>(this TControl control,Action action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.Click += handler;
            tv.Click -= handler;
        }

        control.Event(x => nameof(x.Click),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnContextClick<TControl>(this TControl control,Action<Android.Views.View.ContextClickEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.ContextClick += handler;
            tv.ContextClick -= handler;
        }

        control.Event(x => nameof(x.ContextClick),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnContextMenuCreated<TControl>(this TControl control,Action<Android.Views.View.CreateContextMenuEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.ContextMenuCreated += handler;
            tv.ContextMenuCreated -= handler;
        }

        control.Event(x => nameof(x.ContextMenuCreated),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnDrag<TControl>(this TControl control,Action<Android.Views.View.DragEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.Drag += handler;
            tv.Drag -= handler;
        }

        control.Event(x => nameof(x.Drag),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnGenericMotion<TControl>(this TControl control,Action<Android.Views.View.GenericMotionEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.GenericMotion += handler;
            tv.GenericMotion -= handler;
        }

        control.Event(x => nameof(x.GenericMotion),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnHover<TControl>(this TControl control,Action<Android.Views.View.HoverEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.Hover += handler;
            tv.Hover -= handler;
        }

        control.Event(x => nameof(x.Hover),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnKeyPress<TControl>(this TControl control,Action<Android.Views.View.KeyEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.KeyPress += handler;
            tv.KeyPress -= handler;
        }

        control.Event(x => nameof(x.KeyPress),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnLongClick<TControl>(this TControl control,Action<Android.Views.View.LongClickEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.LongClick += handler;
            tv.LongClick -= handler;
        }

        control.Event(x => nameof(x.LongClick),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnScrollChange<TControl>(this TControl control,Action<Android.Views.View.ScrollChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.ScrollChange += handler;
            tv.ScrollChange -= handler;
        }

        control.Event(x => nameof(x.ScrollChange),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnSystemUiVisibilityChange<TControl>(this TControl control,Action<Android.Views.View.SystemUiVisibilityChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.SystemUiVisibilityChange += handler;
            tv.SystemUiVisibilityChange -= handler;
        }

        control.Event(x => nameof(x.SystemUiVisibilityChange),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnTouch<TControl>(this TControl control,Action<Android.Views.View.TouchEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.Touch += handler;
            tv.Touch -= handler;
        }

        control.Event(x => nameof(x.Touch),action);
        return control;
    }
}
public static partial class Android_Views_View_Extensions
{
    public static TControl OnFocusChange<TControl>(this TControl control,Action<Android.Views.View.FocusChangeEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.View>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.View tv = null;

            tv.FocusChange += handler;
            tv.FocusChange -= handler;
        }

        control.Event(x => nameof(x.FocusChange),action);
        return control;
    }
}

    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Collections.Generic.IList<Android.Views.View>>> _callExpression_AddChildrenForAccessibility_Android_Views_View__System_Collections_Generic_IList_Android_Views_View_ = (view, param1) => view.AddChildrenForAccessibility(param1);
        public static TControl AddChildrenForAccessibility<TControl>(this TControl component, System.Collections.Generic.IList<Android.Views.View> poutChildren) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AddChildrenForAccessibility_Android_Views_View__System_Collections_Generic_IList_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poutChildren);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.Accessibility.AccessibilityNodeInfo, System.String, Android.OS.Bundle>> _callExpression_AddExtraDataToAccessibilityNodeInfo_Android_Views_View__Android_Views_Accessibility_AccessibilityNodeInfo_System_String_Android_OS_Bundle = (view, param1, param2, param3) => view.AddExtraDataToAccessibilityNodeInfo(param1, param2, param3);
        public static TControl AddExtraDataToAccessibilityNodeInfo<TControl>(this TControl component, Android.Views.Accessibility.AccessibilityNodeInfo pinfo, System.String pextraDataKey, Android.OS.Bundle parguments) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AddExtraDataToAccessibilityNodeInfo_Android_Views_View__Android_Views_Accessibility_AccessibilityNodeInfo_System_String_Android_OS_Bundle;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pinfo, pextraDataKey, parguments);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Collections.Generic.IList<Android.Views.View>, Android.Views.FocusSearchDirection>> _callExpression_AddFocusables_Android_Views_View__System_Collections_Generic_IList_Android_Views_View__Android_Views_FocusSearchDirection = (view, param1, param2) => view.AddFocusables(param1, param2);
        public static TControl AddFocusables<TControl>(this TControl component, System.Collections.Generic.IList<Android.Views.View> pviews, Android.Views.FocusSearchDirection pdirection) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AddFocusables_Android_Views_View__System_Collections_Generic_IList_Android_Views_View__Android_Views_FocusSearchDirection;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pviews, pdirection);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Collections.Generic.IList<Android.Views.View>, Android.Views.FocusSearchDirection, Android.Views.FocusablesFlags>> _callExpression_AddFocusables_Android_Views_View__System_Collections_Generic_IList_Android_Views_View__Android_Views_FocusSearchDirection_Android_Views_FocusablesFlags = (view, param1, param2, param3) => view.AddFocusables(param1, param2, param3);
        public static TControl AddFocusables<TControl>(this TControl component, System.Collections.Generic.IList<Android.Views.View> pviews, Android.Views.FocusSearchDirection pdirection, Android.Views.FocusablesFlags pfocusableMode) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AddFocusables_Android_Views_View__System_Collections_Generic_IList_Android_Views_View__Android_Views_FocusSearchDirection_Android_Views_FocusablesFlags;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pviews, pdirection, pfocusableMode);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Collections.Generic.ICollection<Android.Views.View>, Android.Views.FocusSearchDirection>> _callExpression_AddKeyboardNavigationClusters_Android_Views_View__System_Collections_Generic_ICollection_Android_Views_View__Android_Views_FocusSearchDirection = (view, param1, param2) => view.AddKeyboardNavigationClusters(param1, param2);
        public static TControl AddKeyboardNavigationClusters<TControl>(this TControl component, System.Collections.Generic.ICollection<Android.Views.View> pviews, Android.Views.FocusSearchDirection pdirection) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AddKeyboardNavigationClusters_Android_Views_View__System_Collections_Generic_ICollection_Android_Views_View__Android_Views_FocusSearchDirection;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pviews, pdirection);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnAttachStateChangeListener>> _callExpression_AddOnAttachStateChangeListener_Android_Views_View__Android_Views_View_IOnAttachStateChangeListener = (view, param1) => view.AddOnAttachStateChangeListener(param1);
        public static TControl AddOnAttachStateChangeListener<TControl>(this TControl component, Android.Views.View.IOnAttachStateChangeListener plistener) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AddOnAttachStateChangeListener_Android_Views_View__Android_Views_View_IOnAttachStateChangeListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnLayoutChangeListener>> _callExpression_AddOnLayoutChangeListener_Android_Views_View__Android_Views_View_IOnLayoutChangeListener = (view, param1) => view.AddOnLayoutChangeListener(param1);
        public static TControl AddOnLayoutChangeListener<TControl>(this TControl component, Android.Views.View.IOnLayoutChangeListener plistener) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AddOnLayoutChangeListener_Android_Views_View__Android_Views_View_IOnLayoutChangeListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnUnhandledKeyEventListener>> _callExpression_AddOnUnhandledKeyEventListener_Android_Views_View__Android_Views_View_IOnUnhandledKeyEventListener = (view, param1) => view.AddOnUnhandledKeyEventListener(param1);
        public static TControl AddOnUnhandledKeyEventListener<TControl>(this TControl component, Android.Views.View.IOnUnhandledKeyEventListener plistener) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AddOnUnhandledKeyEventListener_Android_Views_View__Android_Views_View_IOnUnhandledKeyEventListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Collections.Generic.IList<Android.Views.View>>> _callExpression_AddTouchables_Android_Views_View__System_Collections_Generic_IList_Android_Views_View_ = (view, param1) => view.AddTouchables(param1);
        public static TControl AddTouchables<TControl>(this TControl component, System.Collections.Generic.IList<Android.Views.View> pviews) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AddTouchables_Android_Views_View__System_Collections_Generic_IList_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pviews);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Java.Lang.ICharSequence>> _callExpression_AnnounceForAccessibility_Android_Views_View__Java_Lang_ICharSequence = (view, param1) => view.AnnounceForAccessibility(param1);
        public static TControl AnnounceForAccessibility<TControl>(this TControl component, Java.Lang.ICharSequence ptext) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AnnounceForAccessibility_Android_Views_View__Java_Lang_ICharSequence;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.String>> _callExpression_AnnounceForAccessibility_Android_Views_View__System_String = (view, param1) => view.AnnounceForAccessibility(param1);
        public static TControl AnnounceForAccessibility<TControl>(this TControl component, System.String ptext) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_AnnounceForAccessibility_Android_Views_View__System_String;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, ptext);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Util.SparseArray>> _callExpression_Autofill_Android_Views_View__Android_Util_SparseArray = (view, param1) => view.Autofill(param1);
        public static TControl Autofill<TControl>(this TControl component, Android.Util.SparseArray pvalues) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_Autofill_Android_Views_View__Android_Util_SparseArray;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pvalues);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.Autofill.AutofillValue>> _callExpression_Autofill_Android_Views_View__Android_Views_Autofill_AutofillValue = (view, param1) => view.Autofill(param1);
        public static TControl Autofill<TControl>(this TControl component, Android.Views.Autofill.AutofillValue pvalue) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_Autofill_Android_Views_View__Android_Views_Autofill_AutofillValue;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pvalue);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_BringToFront_Android_Views_View_ = (view) => view.BringToFront();
        public static TControl BringToFront<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_BringToFront_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_BuildDrawingCache_Android_Views_View_ = (view) => view.BuildDrawingCache();
        public static TControl BuildDrawingCache<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_BuildDrawingCache_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Boolean>> _callExpression_BuildDrawingCache_Android_Views_View__System_Boolean = (view, param1) => view.BuildDrawingCache(param1);
        public static TControl BuildDrawingCache<TControl>(this TControl component, System.Boolean pautoScale) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_BuildDrawingCache_Android_Views_View__System_Boolean;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pautoScale);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_BuildLayer_Android_Views_View_ = (view) => view.BuildLayer();
        public static TControl BuildLayer<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_BuildLayer_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_CancelDragAndDrop_Android_Views_View_ = (view) => view.CancelDragAndDrop();
        public static TControl CancelDragAndDrop<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_CancelDragAndDrop_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_CancelLongPress_Android_Views_View_ = (view) => view.CancelLongPress();
        public static TControl CancelLongPress<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_CancelLongPress_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_CancelPendingInputEvents_Android_Views_View_ = (view) => view.CancelPendingInputEvents();
        public static TControl CancelPendingInputEvents<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_CancelPendingInputEvents_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_ClearAnimation_Android_Views_View_ = (view) => view.ClearAnimation();
        public static TControl ClearAnimation<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ClearAnimation_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_ClearFocus_Android_Views_View_ = (view) => view.ClearFocus();
        public static TControl ClearFocus<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ClearFocus_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_ComputeScroll_Android_Views_View_ = (view) => view.ComputeScroll();
        public static TControl ComputeScroll<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ComputeScroll_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.IContextMenu>> _callExpression_CreateContextMenu_Android_Views_View__Android_Views_IContextMenu = (view, param1) => view.CreateContextMenu(param1);
        public static TControl CreateContextMenu<TControl>(this TControl component, Android.Views.IContextMenu pmenu) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_CreateContextMenu_Android_Views_View__Android_Views_IContextMenu;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pmenu);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_DestroyDrawingCache_Android_Views_View_ = (view) => view.DestroyDrawingCache();
        public static TControl DestroyDrawingCache<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DestroyDrawingCache_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Content.Res.Configuration>> _callExpression_DispatchConfigurationChanged_Android_Views_View__Android_Content_Res_Configuration = (view, param1) => view.DispatchConfigurationChanged(param1);
        public static TControl DispatchConfigurationChanged<TControl>(this TControl component, Android.Content.Res.Configuration pnewConfig) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchConfigurationChanged_Android_Views_View__Android_Content_Res_Configuration;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pnewConfig);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.ViewStates>> _callExpression_DispatchDisplayHint_Android_Views_View__Android_Views_ViewStates = (view, param1) => view.DispatchDisplayHint(param1);
        public static TControl DispatchDisplayHint<TControl>(this TControl component, Android.Views.ViewStates phint) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchDisplayHint_Android_Views_View__Android_Views_ViewStates;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, phint);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Single, System.Single>> _callExpression_DispatchDrawableHotspotChanged_Android_Views_View__System_Single_System_Single = (view, param1, param2) => view.DispatchDrawableHotspotChanged(param1, param2);
        public static TControl DispatchDrawableHotspotChanged<TControl>(this TControl component, System.Single px, System.Single py) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchDrawableHotspotChanged_Android_Views_View__System_Single_System_Single;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, px, py);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_DispatchFinishTemporaryDetach_Android_Views_View_ = (view) => view.DispatchFinishTemporaryDetach();
        public static TControl DispatchFinishTemporaryDetach<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchFinishTemporaryDetach_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Boolean>> _callExpression_DispatchPointerCaptureChanged_Android_Views_View__System_Boolean = (view, param1) => view.DispatchPointerCaptureChanged(param1);
        public static TControl DispatchPointerCaptureChanged<TControl>(this TControl component, System.Boolean phasCapture) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchPointerCaptureChanged_Android_Views_View__System_Boolean;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, phasCapture);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.ViewStructure, Android.Views.AutofillFlags>> _callExpression_DispatchProvideAutofillStructure_Android_Views_View__Android_Views_ViewStructure_Android_Views_AutofillFlags = (view, param1, param2) => view.DispatchProvideAutofillStructure(param1, param2);
        public static TControl DispatchProvideAutofillStructure<TControl>(this TControl component, Android.Views.ViewStructure pstructure, Android.Views.AutofillFlags pflags) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchProvideAutofillStructure_Android_Views_View__Android_Views_ViewStructure_Android_Views_AutofillFlags;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pstructure, pflags);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.ViewStructure>> _callExpression_DispatchProvideStructure_Android_Views_View__Android_Views_ViewStructure = (view, param1) => view.DispatchProvideStructure(param1);
        public static TControl DispatchProvideStructure<TControl>(this TControl component, Android.Views.ViewStructure pstructure) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchProvideStructure_Android_Views_View__Android_Views_ViewStructure;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pstructure);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_DispatchStartTemporaryDetach_Android_Views_View_ = (view) => view.DispatchStartTemporaryDetach();
        public static TControl DispatchStartTemporaryDetach<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchStartTemporaryDetach_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32>> _callExpression_DispatchSystemUiVisibilityChanged_Android_Views_View__System_Int32 = (view, param1) => view.DispatchSystemUiVisibilityChanged(param1);
        public static TControl DispatchSystemUiVisibilityChanged<TControl>(this TControl component, System.Int32 pvisibility) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchSystemUiVisibilityChanged_Android_Views_View__System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pvisibility);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.SystemUiFlags>> _callExpression_DispatchSystemUiVisibilityChanged_Android_Views_View__Android_Views_SystemUiFlags = (view, param1) => view.DispatchSystemUiVisibilityChanged(param1);
        public static TControl DispatchSystemUiVisibilityChanged<TControl>(this TControl component, Android.Views.SystemUiFlags pvisibility) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchSystemUiVisibilityChanged_Android_Views_View__Android_Views_SystemUiFlags;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pvisibility);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Boolean>> _callExpression_DispatchWindowFocusChanged_Android_Views_View__System_Boolean = (view, param1) => view.DispatchWindowFocusChanged(param1);
        public static TControl DispatchWindowFocusChanged<TControl>(this TControl component, System.Boolean phasFocus) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchWindowFocusChanged_Android_Views_View__System_Boolean;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, phasFocus);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.SystemUiFlags>> _callExpression_DispatchWindowSystemUiVisiblityChanged_Android_Views_View__Android_Views_SystemUiFlags = (view, param1) => view.DispatchWindowSystemUiVisiblityChanged(param1);
        public static TControl DispatchWindowSystemUiVisiblityChanged<TControl>(this TControl component, Android.Views.SystemUiFlags pvisible) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchWindowSystemUiVisiblityChanged_Android_Views_View__Android_Views_SystemUiFlags;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pvisible);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.ViewStates>> _callExpression_DispatchWindowVisibilityChanged_Android_Views_View__Android_Views_ViewStates = (view, param1) => view.DispatchWindowVisibilityChanged(param1);
        public static TControl DispatchWindowVisibilityChanged<TControl>(this TControl component, Android.Views.ViewStates pvisibility) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DispatchWindowVisibilityChanged_Android_Views_View__Android_Views_ViewStates;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pvisibility);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Canvas>> _callExpression_Draw_Android_Views_View__Android_Graphics_Canvas = (view, param1) => view.Draw(param1);
        public static TControl Draw<TControl>(this TControl component, Android.Graphics.Canvas pcanvas) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_Draw_Android_Views_View__Android_Graphics_Canvas;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pcanvas);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Single, System.Single>> _callExpression_DrawableHotspotChanged_Android_Views_View__System_Single_System_Single = (view, param1, param2) => view.DrawableHotspotChanged(param1, param2);
        public static TControl DrawableHotspotChanged<TControl>(this TControl component, System.Single px, System.Single py) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_DrawableHotspotChanged_Android_Views_View__System_Single_System_Single;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, px, py);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Collections.Generic.IList<Android.Views.View>, Java.Lang.ICharSequence, Android.Views.FindViewsWith>> _callExpression_FindViewsWithText_Android_Views_View__System_Collections_Generic_IList_Android_Views_View__Java_Lang_ICharSequence_Android_Views_FindViewsWith = (view, param1, param2, param3) => view.FindViewsWithText(param1, param2, param3);
        public static TControl FindViewsWithText<TControl>(this TControl component, System.Collections.Generic.IList<Android.Views.View> poutViews, Java.Lang.ICharSequence psearched, Android.Views.FindViewsWith pflags) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_FindViewsWithText_Android_Views_View__System_Collections_Generic_IList_Android_Views_View__Java_Lang_ICharSequence_Android_Views_FindViewsWith;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poutViews, psearched, pflags);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Collections.Generic.IList<Android.Views.View>, System.String, Android.Views.FindViewsWith>> _callExpression_FindViewsWithText_Android_Views_View__System_Collections_Generic_IList_Android_Views_View__System_String_Android_Views_FindViewsWith = (view, param1, param2, param3) => view.FindViewsWithText(param1, param2, param3);
        public static TControl FindViewsWithText<TControl>(this TControl component, System.Collections.Generic.IList<Android.Views.View> poutViews, System.String psearched, Android.Views.FindViewsWith pflags) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_FindViewsWithText_Android_Views_View__System_Collections_Generic_IList_Android_Views_View__System_String_Android_Views_FindViewsWith;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poutViews, psearched, pflags);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Boolean>> _callExpression_ForceHasOverlappingRendering_Android_Views_View__System_Boolean = (view, param1) => view.ForceHasOverlappingRendering(param1);
        public static TControl ForceHasOverlappingRendering<TControl>(this TControl component, System.Boolean phasOverlappingRendering) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ForceHasOverlappingRendering_Android_Views_View__System_Boolean;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, phasOverlappingRendering);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_ForceLayout_Android_Views_View_ = (view) => view.ForceLayout();
        public static TControl ForceLayout<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ForceLayout_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Rect>> _callExpression_GetDrawingRect_Android_Views_View__Android_Graphics_Rect = (view, param1) => view.GetDrawingRect(param1);
        public static TControl GetDrawingRect<TControl>(this TControl component, Android.Graphics.Rect poutRect) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_GetDrawingRect_Android_Views_View__Android_Graphics_Rect;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poutRect);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Rect>> _callExpression_GetFocusedRect_Android_Views_View__Android_Graphics_Rect = (view, param1) => view.GetFocusedRect(param1);
        public static TControl GetFocusedRect<TControl>(this TControl component, Android.Graphics.Rect pr) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_GetFocusedRect_Android_Views_View__Android_Graphics_Rect;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pr);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Rect>> _callExpression_GetHitRect_Android_Views_View__Android_Graphics_Rect = (view, param1) => view.GetHitRect(param1);
        public static TControl GetHitRect<TControl>(this TControl component, Android.Graphics.Rect poutRect) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_GetHitRect_Android_Views_View__Android_Graphics_Rect;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poutRect);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32[]>> _callExpression_GetLocationInWindow_Android_Views_View__System_Int32_ = (view, param1) => view.GetLocationInWindow(param1);
        public static TControl GetLocationInWindow<TControl>(this TControl component, System.Int32[] poutLocation) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_GetLocationInWindow_Android_Views_View__System_Int32_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poutLocation);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32[]>> _callExpression_GetLocationOnScreen_Android_Views_View__System_Int32_ = (view, param1) => view.GetLocationOnScreen(param1);
        public static TControl GetLocationOnScreen<TControl>(this TControl component, System.Int32[] poutLocation) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_GetLocationOnScreen_Android_Views_View__System_Int32_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poutLocation);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Rect>> _callExpression_GetWindowVisibleDisplayFrame_Android_Views_View__Android_Graphics_Rect = (view, param1) => view.GetWindowVisibleDisplayFrame(param1);
        public static TControl GetWindowVisibleDisplayFrame<TControl>(this TControl component, Android.Graphics.Rect poutRect) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_GetWindowVisibleDisplayFrame_Android_Views_View__Android_Graphics_Rect;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poutRect);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_Invalidate_Android_Views_View_ = (view) => view.Invalidate();
        public static TControl Invalidate<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_Invalidate_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Rect>> _callExpression_Invalidate_Android_Views_View__Android_Graphics_Rect = (view, param1) => view.Invalidate(param1);
        public static TControl Invalidate<TControl>(this TControl component, Android.Graphics.Rect pdirty) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_Invalidate_Android_Views_View__Android_Graphics_Rect;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pdirty);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_Invalidate_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.Invalidate(param1, param2, param3, param4);
        public static TControl Invalidate<TControl>(this TControl component, System.Int32 pl, System.Int32 pt, System.Int32 pr, System.Int32 pb) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_Invalidate_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl, pt, pr, pb);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Drawables.Drawable>> _callExpression_InvalidateDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable = (view, param1) => view.InvalidateDrawable(param1);
        public static TControl InvalidateDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pdrawable) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_InvalidateDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pdrawable);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_InvalidateOutline_Android_Views_View_ = (view) => view.InvalidateOutline();
        public static TControl InvalidateOutline<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_InvalidateOutline_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_JumpDrawablesToCurrentState_Android_Views_View_ = (view) => view.JumpDrawablesToCurrentState();
        public static TControl JumpDrawablesToCurrentState<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_JumpDrawablesToCurrentState_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_Layout_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.Layout(param1, param2, param3, param4);
        public static TControl Layout<TControl>(this TControl component, System.Int32 pl, System.Int32 pt, System.Int32 pr, System.Int32 pb) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_Layout_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl, pt, pr, pb);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32>> _callExpression_Measure_Android_Views_View__System_Int32_System_Int32 = (view, param1, param2) => view.Measure(param1, param2);
        public static TControl Measure<TControl>(this TControl component, System.Int32 pwidthMeasureSpec, System.Int32 pheightMeasureSpec) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_Measure_Android_Views_View__System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pwidthMeasureSpec, pheightMeasureSpec);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32>> _callExpression_OffsetLeftAndRight_Android_Views_View__System_Int32 = (view, param1) => view.OffsetLeftAndRight(param1);
        public static TControl OffsetLeftAndRight<TControl>(this TControl component, System.Int32 poffset) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_OffsetLeftAndRight_Android_Views_View__System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poffset);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32>> _callExpression_OffsetTopAndBottom_Android_Views_View__System_Int32 = (view, param1) => view.OffsetTopAndBottom(param1);
        public static TControl OffsetTopAndBottom<TControl>(this TControl component, System.Int32 poffset) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_OffsetTopAndBottom_Android_Views_View__System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, poffset);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.SoundEffects>> _callExpression_PlaySoundEffect_Android_Views_View__Android_Views_SoundEffects = (view, param1) => view.PlaySoundEffect(param1);
        public static TControl PlaySoundEffect<TControl>(this TControl component, Android.Views.SoundEffects psoundConstant) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_PlaySoundEffect_Android_Views_View__Android_Views_SoundEffects;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, psoundConstant);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_PostInvalidate_Android_Views_View_ = (view) => view.PostInvalidate();
        public static TControl PostInvalidate<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_PostInvalidate_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_PostInvalidate_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.PostInvalidate(param1, param2, param3, param4);
        public static TControl PostInvalidate<TControl>(this TControl component, System.Int32 pleft, System.Int32 ptop, System.Int32 pright, System.Int32 pbottom) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_PostInvalidate_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pleft, ptop, pright, pbottom);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int64>> _callExpression_PostInvalidateDelayed_Android_Views_View__System_Int64 = (view, param1) => view.PostInvalidateDelayed(param1);
        public static TControl PostInvalidateDelayed<TControl>(this TControl component, System.Int64 pdelayMilliseconds) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_PostInvalidateDelayed_Android_Views_View__System_Int64;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pdelayMilliseconds);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_PostInvalidateOnAnimation_Android_Views_View_ = (view) => view.PostInvalidateOnAnimation();
        public static TControl PostInvalidateOnAnimation<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_PostInvalidateOnAnimation_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_PostInvalidateOnAnimation_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.PostInvalidateOnAnimation(param1, param2, param3, param4);
        public static TControl PostInvalidateOnAnimation<TControl>(this TControl component, System.Int32 pleft, System.Int32 ptop, System.Int32 pright, System.Int32 pbottom) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_PostInvalidateOnAnimation_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pleft, ptop, pright, pbottom);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Java.Lang.IRunnable>> _callExpression_PostOnAnimation_Android_Views_View__Java_Lang_IRunnable = (view, param1) => view.PostOnAnimation(param1);
        public static TControl PostOnAnimation<TControl>(this TControl component, Java.Lang.IRunnable paction) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_PostOnAnimation_Android_Views_View__Java_Lang_IRunnable;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, paction);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Java.Lang.IRunnable, System.Int64>> _callExpression_PostOnAnimationDelayed_Android_Views_View__Java_Lang_IRunnable_System_Int64 = (view, param1, param2) => view.PostOnAnimationDelayed(param1, param2);
        public static TControl PostOnAnimationDelayed<TControl>(this TControl component, Java.Lang.IRunnable paction, System.Int64 pdelayMillis) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_PostOnAnimationDelayed_Android_Views_View__Java_Lang_IRunnable_System_Int64;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, paction, pdelayMillis);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_RefreshDrawableState_Android_Views_View_ = (view) => view.RefreshDrawableState();
        public static TControl RefreshDrawableState<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RefreshDrawableState_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_ReleasePointerCapture_Android_Views_View_ = (view) => view.ReleasePointerCapture();
        public static TControl ReleasePointerCapture<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ReleasePointerCapture_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnAttachStateChangeListener>> _callExpression_RemoveOnAttachStateChangeListener_Android_Views_View__Android_Views_View_IOnAttachStateChangeListener = (view, param1) => view.RemoveOnAttachStateChangeListener(param1);
        public static TControl RemoveOnAttachStateChangeListener<TControl>(this TControl component, Android.Views.View.IOnAttachStateChangeListener plistener) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RemoveOnAttachStateChangeListener_Android_Views_View__Android_Views_View_IOnAttachStateChangeListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnLayoutChangeListener>> _callExpression_RemoveOnLayoutChangeListener_Android_Views_View__Android_Views_View_IOnLayoutChangeListener = (view, param1) => view.RemoveOnLayoutChangeListener(param1);
        public static TControl RemoveOnLayoutChangeListener<TControl>(this TControl component, Android.Views.View.IOnLayoutChangeListener plistener) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RemoveOnLayoutChangeListener_Android_Views_View__Android_Views_View_IOnLayoutChangeListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnUnhandledKeyEventListener>> _callExpression_RemoveOnUnhandledKeyEventListener_Android_Views_View__Android_Views_View_IOnUnhandledKeyEventListener = (view, param1) => view.RemoveOnUnhandledKeyEventListener(param1);
        public static TControl RemoveOnUnhandledKeyEventListener<TControl>(this TControl component, Android.Views.View.IOnUnhandledKeyEventListener plistener) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RemoveOnUnhandledKeyEventListener_Android_Views_View__Android_Views_View_IOnUnhandledKeyEventListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_RequestApplyInsets_Android_Views_View_ = (view) => view.RequestApplyInsets();
        public static TControl RequestApplyInsets<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RequestApplyInsets_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_RequestFitSystemWindows_Android_Views_View_ = (view) => view.RequestFitSystemWindows();
        public static TControl RequestFitSystemWindows<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RequestFitSystemWindows_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_RequestLayout_Android_Views_View_ = (view) => view.RequestLayout();
        public static TControl RequestLayout<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RequestLayout_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_RequestPointerCapture_Android_Views_View_ = (view) => view.RequestPointerCapture();
        public static TControl RequestPointerCapture<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RequestPointerCapture_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.MotionEvent>> _callExpression_RequestUnbufferedDispatch_Android_Views_View__Android_Views_MotionEvent = (view, param1) => view.RequestUnbufferedDispatch(param1);
        public static TControl RequestUnbufferedDispatch<TControl>(this TControl component, Android.Views.MotionEvent pe) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RequestUnbufferedDispatch_Android_Views_View__Android_Views_MotionEvent;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pe);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_ResetPivot_Android_Views_View_ = (view) => view.ResetPivot();
        public static TControl ResetPivot<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ResetPivot_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Util.SparseArray>> _callExpression_RestoreHierarchyState_Android_Views_View__Android_Util_SparseArray = (view, param1) => view.RestoreHierarchyState(param1);
        public static TControl RestoreHierarchyState<TControl>(this TControl component, Android.Util.SparseArray pcontainer) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_RestoreHierarchyState_Android_Views_View__Android_Util_SparseArray;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontainer);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Util.SparseArray>> _callExpression_SaveHierarchyState_Android_Views_View__Android_Util_SparseArray = (view, param1) => view.SaveHierarchyState(param1);
        public static TControl SaveHierarchyState<TControl>(this TControl component, Android.Util.SparseArray pcontainer) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SaveHierarchyState_Android_Views_View__Android_Util_SparseArray;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pcontainer);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Drawables.Drawable, System.Action, System.Int64>> _callExpression_ScheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable_System_Action_System_Int64 = (view, param1, param2, param3) => view.ScheduleDrawable(param1, param2, param3);
        public static TControl ScheduleDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pwho, System.Action pwhat, System.Int64 pwhen) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ScheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable_System_Action_System_Int64;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pwho, pwhat, pwhen);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Drawables.Drawable, Java.Lang.IRunnable, System.Int64>> _callExpression_ScheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable_Java_Lang_IRunnable_System_Int64 = (view, param1, param2, param3) => view.ScheduleDrawable(param1, param2, param3);
        public static TControl ScheduleDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pwho, Java.Lang.IRunnable pwhat, System.Int64 pwhen) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ScheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable_Java_Lang_IRunnable_System_Int64;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pwho, pwhat, pwhen);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32>> _callExpression_ScrollBy_Android_Views_View__System_Int32_System_Int32 = (view, param1, param2) => view.ScrollBy(param1, param2);
        public static TControl ScrollBy<TControl>(this TControl component, System.Int32 px, System.Int32 py) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ScrollBy_Android_Views_View__System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, px, py);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32>> _callExpression_ScrollTo_Android_Views_View__System_Int32_System_Int32 = (view, param1, param2) => view.ScrollTo(param1, param2);
        public static TControl ScrollTo<TControl>(this TControl component, System.Int32 px, System.Int32 py) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_ScrollTo_Android_Views_View__System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, px, py);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.Accessibility.EventTypes>> _callExpression_SendAccessibilityEvent_Android_Views_View__Android_Views_Accessibility_EventTypes = (view, param1) => view.SendAccessibilityEvent(param1);
        public static TControl SendAccessibilityEvent<TControl>(this TControl component, Android.Views.Accessibility.EventTypes peventType) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SendAccessibilityEvent_Android_Views_View__Android_Views_Accessibility_EventTypes;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, peventType);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.Accessibility.AccessibilityEvent>> _callExpression_SendAccessibilityEventUnchecked_Android_Views_View__Android_Views_Accessibility_AccessibilityEvent = (view, param1) => view.SendAccessibilityEventUnchecked(param1);
        public static TControl SendAccessibilityEventUnchecked<TControl>(this TControl component, Android.Views.Accessibility.AccessibilityEvent pe) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SendAccessibilityEventUnchecked_Android_Views_View__Android_Views_Accessibility_AccessibilityEvent;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pe);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.AccessibilityDelegate>> _callExpression_SetAccessibilityDelegate_Android_Views_View__Android_Views_View_AccessibilityDelegate = (view, param1) => view.SetAccessibilityDelegate(param1);
        public static TControl SetAccessibilityDelegate<TControl>(this TControl component, Android.Views.View.AccessibilityDelegate pdelegate) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetAccessibilityDelegate_Android_Views_View__Android_Views_View_AccessibilityDelegate;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pdelegate);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.String[]>> _callExpression_SetAutofillHints_Android_Views_View__System_String_ = (view, param1) => view.SetAutofillHints(param1);
        public static TControl SetAutofillHints<TControl>(this TControl component, System.String[] pautofillHints) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetAutofillHints_Android_Views_View__System_String_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pautofillHints);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Color>> _callExpression_SetBackgroundColor_Android_Views_View__Android_Graphics_Color = (view, param1) => view.SetBackgroundColor(param1);
        public static TControl SetBackgroundColor<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetBackgroundColor_Android_Views_View__Android_Graphics_Color;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Drawables.Drawable>> _callExpression_SetBackgroundDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetBackgroundDrawable(param1);
        public static TControl SetBackgroundDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pbackground) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetBackgroundDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pbackground);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32>> _callExpression_SetBackgroundResource_Android_Views_View__System_Int32 = (view, param1) => view.SetBackgroundResource(param1);
        public static TControl SetBackgroundResource<TControl>(this TControl component, System.Int32 presid) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetBackgroundResource_Android_Views_View__System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, presid);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Single>> _callExpression_SetCameraDistance_Android_Views_View__System_Single = (view, param1) => view.SetCameraDistance(param1);
        public static TControl SetCameraDistance<TControl>(this TControl component, System.Single pdistance) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetCameraDistance_Android_Views_View__System_Single;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pdistance);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32>> _callExpression_SetFadingEdgeLength_Android_Views_View__System_Int32 = (view, param1) => view.SetFadingEdgeLength(param1);
        public static TControl SetFadingEdgeLength<TControl>(this TControl component, System.Int32 plength) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetFadingEdgeLength_Android_Views_View__System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, plength);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Boolean>> _callExpression_SetFitsSystemWindows_Android_Views_View__System_Boolean = (view, param1) => view.SetFitsSystemWindows(param1);
        public static TControl SetFitsSystemWindows<TControl>(this TControl component, System.Boolean pfitSystemWindows) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetFitsSystemWindows_Android_Views_View__System_Boolean;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pfitSystemWindows);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.ViewFocusability>> _callExpression_SetFocusable_Android_Views_View__Android_Views_ViewFocusability = (view, param1) => view.SetFocusable(param1);
        public static TControl SetFocusable<TControl>(this TControl component, Android.Views.ViewFocusability pfocusable) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetFocusable_Android_Views_View__Android_Views_ViewFocusability;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pfocusable);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.GravityFlags>> _callExpression_SetForegroundGravity_Android_Views_View__Android_Views_GravityFlags = (view, param1) => view.SetForegroundGravity(param1);
        public static TControl SetForegroundGravity<TControl>(this TControl component, Android.Views.GravityFlags pgravity) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetForegroundGravity_Android_Views_View__Android_Views_GravityFlags;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pgravity);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Paint>> _callExpression_SetLayerPaint_Android_Views_View__Android_Graphics_Paint = (view, param1) => view.SetLayerPaint(param1);
        public static TControl SetLayerPaint<TControl>(this TControl component, Android.Graphics.Paint ppaint) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetLayerPaint_Android_Views_View__Android_Graphics_Paint;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, ppaint);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.LayerType, Android.Graphics.Paint>> _callExpression_SetLayerType_Android_Views_View__Android_Views_LayerType_Android_Graphics_Paint = (view, param1, param2) => view.SetLayerType(param1, param2);
        public static TControl SetLayerType<TControl>(this TControl component, Android.Views.LayerType playerType, Android.Graphics.Paint ppaint) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetLayerType_Android_Views_View__Android_Views_LayerType_Android_Graphics_Paint;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, playerType, ppaint);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32>> _callExpression_SetMinimumHeight_Android_Views_View__System_Int32 = (view, param1) => view.SetMinimumHeight(param1);
        public static TControl SetMinimumHeight<TControl>(this TControl component, System.Int32 pminHeight) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetMinimumHeight_Android_Views_View__System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pminHeight);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32>> _callExpression_SetMinimumWidth_Android_Views_View__System_Int32 = (view, param1) => view.SetMinimumWidth(param1);
        public static TControl SetMinimumWidth<TControl>(this TControl component, System.Int32 pminWidth) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetMinimumWidth_Android_Views_View__System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pminWidth);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnApplyWindowInsetsListener>> _callExpression_SetOnApplyWindowInsetsListener_Android_Views_View__Android_Views_View_IOnApplyWindowInsetsListener = (view, param1) => view.SetOnApplyWindowInsetsListener(param1);
        public static TControl SetOnApplyWindowInsetsListener<TControl>(this TControl component, Android.Views.View.IOnApplyWindowInsetsListener plistener) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnApplyWindowInsetsListener_Android_Views_View__Android_Views_View_IOnApplyWindowInsetsListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnCapturedPointerListener>> _callExpression_SetOnCapturedPointerListener_Android_Views_View__Android_Views_View_IOnCapturedPointerListener = (view, param1) => view.SetOnCapturedPointerListener(param1);
        public static TControl SetOnCapturedPointerListener<TControl>(this TControl component, Android.Views.View.IOnCapturedPointerListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnCapturedPointerListener_Android_Views_View__Android_Views_View_IOnCapturedPointerListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnClickListener>> _callExpression_SetOnClickListener_Android_Views_View__Android_Views_View_IOnClickListener = (view, param1) => view.SetOnClickListener(param1);
        public static TControl SetOnClickListener<TControl>(this TControl component, Android.Views.View.IOnClickListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnClickListener_Android_Views_View__Android_Views_View_IOnClickListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnContextClickListener>> _callExpression_SetOnContextClickListener_Android_Views_View__Android_Views_View_IOnContextClickListener = (view, param1) => view.SetOnContextClickListener(param1);
        public static TControl SetOnContextClickListener<TControl>(this TControl component, Android.Views.View.IOnContextClickListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnContextClickListener_Android_Views_View__Android_Views_View_IOnContextClickListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnCreateContextMenuListener>> _callExpression_SetOnCreateContextMenuListener_Android_Views_View__Android_Views_View_IOnCreateContextMenuListener = (view, param1) => view.SetOnCreateContextMenuListener(param1);
        public static TControl SetOnCreateContextMenuListener<TControl>(this TControl component, Android.Views.View.IOnCreateContextMenuListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnCreateContextMenuListener_Android_Views_View__Android_Views_View_IOnCreateContextMenuListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnDragListener>> _callExpression_SetOnDragListener_Android_Views_View__Android_Views_View_IOnDragListener = (view, param1) => view.SetOnDragListener(param1);
        public static TControl SetOnDragListener<TControl>(this TControl component, Android.Views.View.IOnDragListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnDragListener_Android_Views_View__Android_Views_View_IOnDragListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnGenericMotionListener>> _callExpression_SetOnGenericMotionListener_Android_Views_View__Android_Views_View_IOnGenericMotionListener = (view, param1) => view.SetOnGenericMotionListener(param1);
        public static TControl SetOnGenericMotionListener<TControl>(this TControl component, Android.Views.View.IOnGenericMotionListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnGenericMotionListener_Android_Views_View__Android_Views_View_IOnGenericMotionListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnHoverListener>> _callExpression_SetOnHoverListener_Android_Views_View__Android_Views_View_IOnHoverListener = (view, param1) => view.SetOnHoverListener(param1);
        public static TControl SetOnHoverListener<TControl>(this TControl component, Android.Views.View.IOnHoverListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnHoverListener_Android_Views_View__Android_Views_View_IOnHoverListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnKeyListener>> _callExpression_SetOnKeyListener_Android_Views_View__Android_Views_View_IOnKeyListener = (view, param1) => view.SetOnKeyListener(param1);
        public static TControl SetOnKeyListener<TControl>(this TControl component, Android.Views.View.IOnKeyListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnKeyListener_Android_Views_View__Android_Views_View_IOnKeyListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnLongClickListener>> _callExpression_SetOnLongClickListener_Android_Views_View__Android_Views_View_IOnLongClickListener = (view, param1) => view.SetOnLongClickListener(param1);
        public static TControl SetOnLongClickListener<TControl>(this TControl component, Android.Views.View.IOnLongClickListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnLongClickListener_Android_Views_View__Android_Views_View_IOnLongClickListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnScrollChangeListener>> _callExpression_SetOnScrollChangeListener_Android_Views_View__Android_Views_View_IOnScrollChangeListener = (view, param1) => view.SetOnScrollChangeListener(param1);
        public static TControl SetOnScrollChangeListener<TControl>(this TControl component, Android.Views.View.IOnScrollChangeListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnScrollChangeListener_Android_Views_View__Android_Views_View_IOnScrollChangeListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnSystemUiVisibilityChangeListener>> _callExpression_SetOnSystemUiVisibilityChangeListener_Android_Views_View__Android_Views_View_IOnSystemUiVisibilityChangeListener = (view, param1) => view.SetOnSystemUiVisibilityChangeListener(param1);
        public static TControl SetOnSystemUiVisibilityChangeListener<TControl>(this TControl component, Android.Views.View.IOnSystemUiVisibilityChangeListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnSystemUiVisibilityChangeListener_Android_Views_View__Android_Views_View_IOnSystemUiVisibilityChangeListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.IOnTouchListener>> _callExpression_SetOnTouchListener_Android_Views_View__Android_Views_View_IOnTouchListener = (view, param1) => view.SetOnTouchListener(param1);
        public static TControl SetOnTouchListener<TControl>(this TControl component, Android.Views.View.IOnTouchListener pl) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOnTouchListener_Android_Views_View__Android_Views_View_IOnTouchListener;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pl);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Color>> _callExpression_SetOutlineAmbientShadowColor_Android_Views_View__Android_Graphics_Color = (view, param1) => view.SetOutlineAmbientShadowColor(param1);
        public static TControl SetOutlineAmbientShadowColor<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOutlineAmbientShadowColor_Android_Views_View__Android_Graphics_Color;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Color>> _callExpression_SetOutlineSpotShadowColor_Android_Views_View__Android_Graphics_Color = (view, param1) => view.SetOutlineSpotShadowColor(param1);
        public static TControl SetOutlineSpotShadowColor<TControl>(this TControl component, Android.Graphics.Color pcolor) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetOutlineSpotShadowColor_Android_Views_View__Android_Graphics_Color;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pcolor);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_SetPadding_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.SetPadding(param1, param2, param3, param4);
        public static TControl SetPadding<TControl>(this TControl component, System.Int32 pleft, System.Int32 ptop, System.Int32 pright, System.Int32 pbottom) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetPadding_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pleft, ptop, pright, pbottom);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_SetPaddingRelative_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.SetPaddingRelative(param1, param2, param3, param4);
        public static TControl SetPaddingRelative<TControl>(this TControl component, System.Int32 pstart, System.Int32 ptop, System.Int32 pend, System.Int32 pbottom) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetPaddingRelative_Android_Views_View__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pstart, ptop, pend, pbottom);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Boolean>> _callExpression_SetScrollContainer_Android_Views_View__System_Boolean = (view, param1) => view.SetScrollContainer(param1);
        public static TControl SetScrollContainer<TControl>(this TControl component, System.Boolean pisScrollContainer) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetScrollContainer_Android_Views_View__System_Boolean;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pisScrollContainer);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32>> _callExpression_SetScrollIndicators_Android_Views_View__System_Int32 = (view, param1) => view.SetScrollIndicators(param1);
        public static TControl SetScrollIndicators<TControl>(this TControl component, System.Int32 pindicators) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetScrollIndicators_Android_Views_View__System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pindicators);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, System.Int32>> _callExpression_SetScrollIndicators_Android_Views_View__System_Int32_System_Int32 = (view, param1, param2) => view.SetScrollIndicators(param1, param2);
        public static TControl SetScrollIndicators<TControl>(this TControl component, System.Int32 pindicators, System.Int32 pmask) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetScrollIndicators_Android_Views_View__System_Int32_System_Int32;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pindicators, pmask);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Int32, Java.Lang.Object>> _callExpression_SetTag_Android_Views_View__System_Int32_Java_Lang_Object = (view, param1, param2) => view.SetTag(param1, param2);
        public static TControl SetTag<TControl>(this TControl component, System.Int32 pkey, Java.Lang.Object ptag) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetTag_Android_Views_View__System_Int32_Java_Lang_Object;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pkey, ptag);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Boolean>> _callExpression_SetWillNotCacheDrawing_Android_Views_View__System_Boolean = (view, param1) => view.SetWillNotCacheDrawing(param1);
        public static TControl SetWillNotCacheDrawing<TControl>(this TControl component, System.Boolean pwillNotCacheDrawing) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetWillNotCacheDrawing_Android_Views_View__System_Boolean;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pwillNotCacheDrawing);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Boolean>> _callExpression_SetWillNotDraw_Android_Views_View__System_Boolean = (view, param1) => view.SetWillNotDraw(param1);
        public static TControl SetWillNotDraw<TControl>(this TControl component, System.Boolean pwillNotDraw) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetWillNotDraw_Android_Views_View__System_Boolean;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pwillNotDraw);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Single>> _callExpression_SetX_Android_Views_View__System_Single = (view, param1) => view.SetX(param1);
        public static TControl SetX<TControl>(this TControl component, System.Single px) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetX_Android_Views_View__System_Single;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, px);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Single>> _callExpression_SetY_Android_Views_View__System_Single = (view, param1) => view.SetY(param1);
        public static TControl SetY<TControl>(this TControl component, System.Single py) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetY_Android_Views_View__System_Single;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, py);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, System.Single>> _callExpression_SetZ_Android_Views_View__System_Single = (view, param1) => view.SetZ(param1);
        public static TControl SetZ<TControl>(this TControl component, System.Single pz) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_SetZ_Android_Views_View__System_Single;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pz);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.Animations.Animation>> _callExpression_StartAnimation_Android_Views_View__Android_Views_Animations_Animation = (view, param1) => view.StartAnimation(param1);
        public static TControl StartAnimation<TControl>(this TControl component, Android.Views.Animations.Animation panimation) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_StartAnimation_Android_Views_View__Android_Views_Animations_Animation;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, panimation);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View>> _callExpression_StopNestedScroll_Android_Views_View_ = (view) => view.StopNestedScroll();
        public static TControl StopNestedScroll<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_StopNestedScroll_Android_Views_View_;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Drawables.Drawable, System.Action>> _callExpression_UnscheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable_System_Action = (view, param1, param2) => view.UnscheduleDrawable(param1, param2);
        public static TControl UnscheduleDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pwho, System.Action pwhat) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_UnscheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable_System_Action;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pwho, pwhat);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Drawables.Drawable>> _callExpression_UnscheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable = (view, param1) => view.UnscheduleDrawable(param1);
        public static TControl UnscheduleDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pwho) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_UnscheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pwho);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Graphics.Drawables.Drawable, Java.Lang.IRunnable>> _callExpression_UnscheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable_Java_Lang_IRunnable = (view, param1, param2) => view.UnscheduleDrawable(param1, param2);
        public static TControl UnscheduleDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable pwho, Java.Lang.IRunnable pwhat) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_UnscheduleDrawable_Android_Views_View__Android_Graphics_Drawables_Drawable_Java_Lang_IRunnable;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pwho, pwhat);
            return component;
        }
    }
    public static partial class Android_Views_View_Extensions
    {
        private static Expression<Action<Android.Views.View, Android.Views.View.DragShadowBuilder>> _callExpression_UpdateDragShadow_Android_Views_View__Android_Views_View_DragShadowBuilder = (view, param1) => view.UpdateDragShadow(param1);
        public static TControl UpdateDragShadow<TControl>(this TControl component, Android.Views.View.DragShadowBuilder pshadowBuilder) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            var callExpression = _callExpression_UpdateDragShadow_Android_Views_View__Android_Views_View_DragShadowBuilder;

            Reflect<Android.Views.View>.ReflectionHelpers.Call(component.Attributes,callExpression, pshadowBuilder);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Views.SurfaceView> SurfaceView(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Views.SurfaceView(default);
            }

            var control = View<Android.Views.SurfaceView>(dimensions:dimensions,id:id);
            return control;
        }    
    }



    public static partial class Android_Views_SurfaceView_Extensions
    {
        private static Expression<Action<Android.Views.SurfaceView, System.Boolean>> _callExpression_SetSecure_Android_Views_SurfaceView__System_Boolean = (view, param1) => view.SetSecure(param1);
        public static TControl SetSecure<TControl>(this TControl component, System.Boolean pisSecure) where TControl:IReflectedPrimitive<Android.Views.SurfaceView>
        {
            var callExpression = _callExpression_SetSecure_Android_Views_SurfaceView__System_Boolean;

            Reflect<Android.Views.SurfaceView>.ReflectionHelpers.Call(component.Attributes,callExpression, pisSecure);
            return component;
        }
    }
    public static partial class Android_Views_SurfaceView_Extensions
    {
        private static Expression<Action<Android.Views.SurfaceView, System.Boolean>> _callExpression_SetZOrderMediaOverlay_Android_Views_SurfaceView__System_Boolean = (view, param1) => view.SetZOrderMediaOverlay(param1);
        public static TControl SetZOrderMediaOverlay<TControl>(this TControl component, System.Boolean pisMediaOverlay) where TControl:IReflectedPrimitive<Android.Views.SurfaceView>
        {
            var callExpression = _callExpression_SetZOrderMediaOverlay_Android_Views_SurfaceView__System_Boolean;

            Reflect<Android.Views.SurfaceView>.ReflectionHelpers.Call(component.Attributes,callExpression, pisMediaOverlay);
            return component;
        }
    }
    public static partial class Android_Views_SurfaceView_Extensions
    {
        private static Expression<Action<Android.Views.SurfaceView, System.Boolean>> _callExpression_SetZOrderOnTop_Android_Views_SurfaceView__System_Boolean = (view, param1) => view.SetZOrderOnTop(param1);
        public static TControl SetZOrderOnTop<TControl>(this TControl component, System.Boolean ponTop) where TControl:IReflectedPrimitive<Android.Views.SurfaceView>
        {
            var callExpression = _callExpression_SetZOrderOnTop_Android_Views_SurfaceView__System_Boolean;

            Reflect<Android.Views.SurfaceView>.ReflectionHelpers.Call(component.Attributes,callExpression, ponTop);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static AndroidView<Android.Views.TextureView> TextureView(Dimensions dimensions=default,int?id=default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var instance = new Android.Views.TextureView(default);
            }

            var control = View<Android.Views.TextureView>(dimensions:dimensions,id:id);
            return control;
        }    
    }

    public static partial class Android_Views_TextureView_Extensions
    {
        private static readonly Attribute<Android.Graphics.SurfaceTexture> Attribute_SurfaceTexture_SurfaceTexture = AttributeReflectionHelper.ResolveFor<Android.Views.TextureView, Android.Graphics.SurfaceTexture>
        (v => v.SurfaceTexture);


        public static TControl SurfaceTexture<TControl>(this TControl component, Android.Graphics.SurfaceTexture pSurfaceTexture)  where TControl:IReflectedPrimitive<Android.Views.TextureView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.TextureView t = default;
                t.SurfaceTexture = default;
            }

            component.Attributes.SetAttribute(Attribute_SurfaceTexture_SurfaceTexture,pSurfaceTexture);
            return component;
        }
    }
    public static partial class Android_Views_TextureView_Extensions
    {
        private static readonly Attribute<Android.Views.TextureView.ISurfaceTextureListener> Attribute_ISurfaceTextureListener_SurfaceTextureListener = AttributeReflectionHelper.ResolveFor<Android.Views.TextureView, Android.Views.TextureView.ISurfaceTextureListener>
        (v => v.SurfaceTextureListener);


        public static TControl SurfaceTextureListener<TControl>(this TControl component, Android.Views.TextureView.ISurfaceTextureListener pSurfaceTextureListener)  where TControl:IReflectedPrimitive<Android.Views.TextureView>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.TextureView t = default;
                t.SurfaceTextureListener = default;
            }

            component.Attributes.SetAttribute(Attribute_ISurfaceTextureListener_SurfaceTextureListener,pSurfaceTextureListener);
            return component;
        }
    }

public static partial class Android_Views_TextureView_Extensions
{
    public static TControl OnSurfaceTextureAvailable<TControl>(this TControl control,Action<Android.Views.TextureView.SurfaceTextureAvailableEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.TextureView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.TextureView tv = null;

            tv.SurfaceTextureAvailable += handler;
            tv.SurfaceTextureAvailable -= handler;
        }

        control.Event(x => nameof(x.SurfaceTextureAvailable),action);
        return control;
    }
}
public static partial class Android_Views_TextureView_Extensions
{
    public static TControl OnSurfaceTextureDestroyed<TControl>(this TControl control,Action<Android.Views.TextureView.SurfaceTextureDestroyedEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.TextureView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.TextureView tv = null;

            tv.SurfaceTextureDestroyed += handler;
            tv.SurfaceTextureDestroyed -= handler;
        }

        control.Event(x => nameof(x.SurfaceTextureDestroyed),action);
        return control;
    }
}
public static partial class Android_Views_TextureView_Extensions
{
    public static TControl OnSurfaceTextureSizeChanged<TControl>(this TControl control,Action<Android.Views.TextureView.SurfaceTextureSizeChangedEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.TextureView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.TextureView tv = null;

            tv.SurfaceTextureSizeChanged += handler;
            tv.SurfaceTextureSizeChanged -= handler;
        }

        control.Event(x => nameof(x.SurfaceTextureSizeChanged),action);
        return control;
    }
}
public static partial class Android_Views_TextureView_Extensions
{
    public static TControl OnSurfaceTextureUpdated<TControl>(this TControl control,Action<Android.Views.TextureView.SurfaceTextureUpdatedEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.TextureView>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.TextureView tv = null;

            tv.SurfaceTextureUpdated += handler;
            tv.SurfaceTextureUpdated -= handler;
        }

        control.Event(x => nameof(x.SurfaceTextureUpdated),action);
        return control;
    }
}

    public static partial class Android_Views_TextureView_Extensions
    {
        private static Expression<Action<Android.Views.TextureView, Android.Graphics.Canvas>> _callExpression_Draw_Android_Views_TextureView__Android_Graphics_Canvas = (view, param1) => view.Draw(param1);
        public static TControl Draw<TControl>(this TControl component, Android.Graphics.Canvas pcanvas) where TControl:IReflectedPrimitive<Android.Views.TextureView>
        {
            var callExpression = _callExpression_Draw_Android_Views_TextureView__Android_Graphics_Canvas;

            Reflect<Android.Views.TextureView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcanvas);
            return component;
        }
    }
    public static partial class Android_Views_TextureView_Extensions
    {
        private static Expression<Action<Android.Views.TextureView, System.Boolean>> _callExpression_SetOpaque_Android_Views_TextureView__System_Boolean = (view, param1) => view.SetOpaque(param1);
        public static TControl SetOpaque<TControl>(this TControl component, System.Boolean popaque) where TControl:IReflectedPrimitive<Android.Views.TextureView>
        {
            var callExpression = _callExpression_SetOpaque_Android_Views_TextureView__System_Boolean;

            Reflect<Android.Views.TextureView>.ReflectionHelpers.Call(component.Attributes,callExpression, popaque);
            return component;
        }
    }
    public static partial class Android_Views_TextureView_Extensions
    {
        private static Expression<Action<Android.Views.TextureView, Android.Graphics.Matrix>> _callExpression_SetTransform_Android_Views_TextureView__Android_Graphics_Matrix = (view, param1) => view.SetTransform(param1);
        public static TControl SetTransform<TControl>(this TControl component, Android.Graphics.Matrix ptransform) where TControl:IReflectedPrimitive<Android.Views.TextureView>
        {
            var callExpression = _callExpression_SetTransform_Android_Views_TextureView__Android_Graphics_Matrix;

            Reflect<Android.Views.TextureView>.ReflectionHelpers.Call(component.Attributes,callExpression, ptransform);
            return component;
        }
    }
    public static partial class Android_Views_TextureView_Extensions
    {
        private static Expression<Action<Android.Views.TextureView, Android.Graphics.Canvas>> _callExpression_UnlockCanvasAndPost_Android_Views_TextureView__Android_Graphics_Canvas = (view, param1) => view.UnlockCanvasAndPost(param1);
        public static TControl UnlockCanvasAndPost<TControl>(this TControl component, Android.Graphics.Canvas pcanvas) where TControl:IReflectedPrimitive<Android.Views.TextureView>
        {
            var callExpression = _callExpression_UnlockCanvasAndPost_Android_Views_TextureView__Android_Graphics_Canvas;

            Reflect<Android.Views.TextureView>.ReflectionHelpers.Call(component.Attributes,callExpression, pcanvas);
            return component;
        }
    }


    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_AlwaysDrawnWithCacheEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, System.Boolean>
        (v => v.AlwaysDrawnWithCacheEnabled);


        public static TControl AlwaysDrawnWithCacheEnabled<TControl>(this TControl component, System.Boolean pAlwaysDrawnWithCacheEnabled)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.AlwaysDrawnWithCacheEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_AlwaysDrawnWithCacheEnabled,pAlwaysDrawnWithCacheEnabled);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_AnimationCacheEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, System.Boolean>
        (v => v.AnimationCacheEnabled);


        public static TControl AnimationCacheEnabled<TControl>(this TControl component, System.Boolean pAnimationCacheEnabled)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.AnimationCacheEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_AnimationCacheEnabled,pAnimationCacheEnabled);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<Android.Views.DescendantFocusability> Attribute_DescendantFocusability_DescendantFocusability = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, Android.Views.DescendantFocusability>
        (v => v.DescendantFocusability);


        public static TControl DescendantFocusability<TControl>(this TControl component, Android.Views.DescendantFocusability pDescendantFocusability)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.DescendantFocusability = default;
            }

            component.Attributes.SetAttribute(Attribute_DescendantFocusability_DescendantFocusability,pDescendantFocusability);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<Android.Views.Animations.LayoutAnimationController> Attribute_LayoutAnimationController_LayoutAnimation = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, Android.Views.Animations.LayoutAnimationController>
        (v => v.LayoutAnimation);


        public static TControl LayoutAnimation<TControl>(this TControl component, Android.Views.Animations.LayoutAnimationController pLayoutAnimation)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.LayoutAnimation = default;
            }

            component.Attributes.SetAttribute(Attribute_LayoutAnimationController_LayoutAnimation,pLayoutAnimation);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<Android.Views.Animations.Animation.IAnimationListener> Attribute_IAnimationListener_LayoutAnimationListener = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, Android.Views.Animations.Animation.IAnimationListener>
        (v => v.LayoutAnimationListener);


        public static TControl LayoutAnimationListener<TControl>(this TControl component, Android.Views.Animations.Animation.IAnimationListener pLayoutAnimationListener)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.LayoutAnimationListener = default;
            }

            component.Attributes.SetAttribute(Attribute_IAnimationListener_LayoutAnimationListener,pLayoutAnimationListener);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<Android.Views.ViewLayoutMode> Attribute_ViewLayoutMode_LayoutMode = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, Android.Views.ViewLayoutMode>
        (v => v.LayoutMode);


        public static TControl LayoutMode<TControl>(this TControl component, Android.Views.ViewLayoutMode pLayoutMode)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.LayoutMode = default;
            }

            component.Attributes.SetAttribute(Attribute_ViewLayoutMode_LayoutMode,pLayoutMode);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<Android.Animation.LayoutTransition> Attribute_LayoutTransition_LayoutTransition = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, Android.Animation.LayoutTransition>
        (v => v.LayoutTransition);


        public static TControl LayoutTransition<TControl>(this TControl component, Android.Animation.LayoutTransition pLayoutTransition)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.LayoutTransition = default;
            }

            component.Attributes.SetAttribute(Attribute_LayoutTransition_LayoutTransition,pLayoutTransition);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_MotionEventSplittingEnabled = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, System.Boolean>
        (v => v.MotionEventSplittingEnabled);


        public static TControl MotionEventSplittingEnabled<TControl>(this TControl component, System.Boolean pMotionEventSplittingEnabled)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.MotionEventSplittingEnabled = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_MotionEventSplittingEnabled,pMotionEventSplittingEnabled);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<Android.Views.PersistentDrawingCaches> Attribute_PersistentDrawingCaches_PersistentDrawingCache = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, Android.Views.PersistentDrawingCaches>
        (v => v.PersistentDrawingCache);


        public static TControl PersistentDrawingCache<TControl>(this TControl component, Android.Views.PersistentDrawingCaches pPersistentDrawingCache)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.PersistentDrawingCache = default;
            }

            component.Attributes.SetAttribute(Attribute_PersistentDrawingCaches_PersistentDrawingCache,pPersistentDrawingCache);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_TouchscreenBlocksFocus = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, System.Boolean>
        (v => v.TouchscreenBlocksFocus);


        public static TControl TouchscreenBlocksFocus<TControl>(this TControl component, System.Boolean pTouchscreenBlocksFocus)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.TouchscreenBlocksFocus = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_TouchscreenBlocksFocus,pTouchscreenBlocksFocus);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_TransitionGroup = AttributeReflectionHelper.ResolveFor<Android.Views.ViewGroup, System.Boolean>
        (v => v.TransitionGroup);


        public static TControl TransitionGroup<TControl>(this TControl component, System.Boolean pTransitionGroup)  where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.Views.ViewGroup t = default;
                t.TransitionGroup = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_TransitionGroup,pTransitionGroup);
            return component;
        }
    }

public static partial class Android_Views_ViewGroup_Extensions
{
    public static TControl OnChildViewAdded<TControl>(this TControl control,Action<Android.Views.ViewGroup.ChildViewAddedEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.ViewGroup tv = null;

            tv.ChildViewAdded += handler;
            tv.ChildViewAdded -= handler;
        }

        control.Event(x => nameof(x.ChildViewAdded),action);
        return control;
    }
}
public static partial class Android_Views_ViewGroup_Extensions
{
    public static TControl OnChildViewRemoved<TControl>(this TControl control,Action<Android.Views.ViewGroup.ChildViewRemovedEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.ViewGroup tv = null;

            tv.ChildViewRemoved += handler;
            tv.ChildViewRemoved -= handler;
        }

        control.Event(x => nameof(x.ChildViewRemoved),action);
        return control;
    }
}
public static partial class Android_Views_ViewGroup_Extensions
{
    public static TControl OnAnimationEnd<TControl>(this TControl control,Action<Android.Views.Animations.Animation.AnimationEndEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.ViewGroup tv = null;

            tv.AnimationEnd += handler;
            tv.AnimationEnd -= handler;
        }

        control.Event(x => nameof(x.AnimationEnd),action);
        return control;
    }
}
public static partial class Android_Views_ViewGroup_Extensions
{
    public static TControl OnAnimationRepeat<TControl>(this TControl control,Action<Android.Views.Animations.Animation.AnimationRepeatEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.ViewGroup tv = null;

            tv.AnimationRepeat += handler;
            tv.AnimationRepeat -= handler;
        }

        control.Event(x => nameof(x.AnimationRepeat),action);
        return control;
    }
}
public static partial class Android_Views_ViewGroup_Extensions
{
    public static TControl OnAnimationStart<TControl>(this TControl control,Action<Android.Views.Animations.Animation.AnimationStartEventArgs> action) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
    {
        if (Components.Primitives.NeverInclude)
        {
            static void handler(object sender, EventArgs e)
            {
            }

            Android.Views.ViewGroup tv = null;

            tv.AnimationStart += handler;
            tv.AnimationStart -= handler;
        }

        control.Event(x => nameof(x.AnimationStart),action);
        return control;
    }
}

    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.AddView(param1);
        public static TControl AddView<TControl>(this TControl component, Android.Views.View pchild) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, Android.Views.ViewGroup.LayoutParams>> _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View_Android_Views_ViewGroup_LayoutParams = (view, param1, param2) => view.AddView(param1, param2);
        public static TControl AddView<TControl>(this TControl component, Android.Views.View pchild, Android.Views.ViewGroup.LayoutParams pparams) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View_Android_Views_ViewGroup_LayoutParams;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, pparams);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, System.Int32>> _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View_System_Int32 = (view, param1, param2) => view.AddView(param1, param2);
        public static TControl AddView<TControl>(this TControl component, Android.Views.View pchild, System.Int32 pindex) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View_System_Int32;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, pindex);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, System.Int32, Android.Views.ViewGroup.LayoutParams>> _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View_System_Int32_Android_Views_ViewGroup_LayoutParams = (view, param1, param2, param3) => view.AddView(param1, param2, param3);
        public static TControl AddView<TControl>(this TControl component, Android.Views.View pchild, System.Int32 pindex, Android.Views.ViewGroup.LayoutParams pparams) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View_System_Int32_Android_Views_ViewGroup_LayoutParams;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, pindex, pparams);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, System.Int32, System.Int32>> _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View_System_Int32_System_Int32 = (view, param1, param2, param3) => view.AddView(param1, param2, param3);
        public static TControl AddView<TControl>(this TControl component, Android.Views.View pchild, System.Int32 pwidth, System.Int32 pheight) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_AddView_Android_Views_ViewGroup__Android_Views_View_System_Int32_System_Int32;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, pwidth, pheight);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_BringChildToFront_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.BringChildToFront(param1);
        public static TControl BringChildToFront<TControl>(this TControl component, Android.Views.View pchild) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_BringChildToFront_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_ChildDrawableStateChanged_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.ChildDrawableStateChanged(param1);
        public static TControl ChildDrawableStateChanged<TControl>(this TControl component, Android.Views.View pchild) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_ChildDrawableStateChanged_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, System.Boolean>> _callExpression_ChildHasTransientStateChanged_Android_Views_ViewGroup__Android_Views_View_System_Boolean = (view, param1, param2) => view.ChildHasTransientStateChanged(param1, param2);
        public static TControl ChildHasTransientStateChanged<TControl>(this TControl component, Android.Views.View pchild, System.Boolean pchildHasTransientState) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_ChildHasTransientStateChanged_Android_Views_ViewGroup__Android_Views_View_System_Boolean;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, pchildHasTransientState);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_ClearChildFocus_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.ClearChildFocus(param1);
        public static TControl ClearChildFocus<TControl>(this TControl component, Android.Views.View pchild) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_ClearChildFocus_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup>> _callExpression_ClearDisappearingChildren_Android_Views_ViewGroup_ = (view) => view.ClearDisappearingChildren();
        public static TControl ClearDisappearingChildren<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_ClearDisappearingChildren_Android_Views_ViewGroup_;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Boolean>> _callExpression_DispatchSetActivated_Android_Views_ViewGroup__System_Boolean = (view, param1) => view.DispatchSetActivated(param1);
        public static TControl DispatchSetActivated<TControl>(this TControl component, System.Boolean pactivated) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_DispatchSetActivated_Android_Views_ViewGroup__System_Boolean;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pactivated);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Boolean>> _callExpression_DispatchSetSelected_Android_Views_ViewGroup__System_Boolean = (view, param1) => view.DispatchSetSelected(param1);
        public static TControl DispatchSetSelected<TControl>(this TControl component, System.Boolean pselected) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_DispatchSetSelected_Android_Views_ViewGroup__System_Boolean;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pselected);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_EndViewTransition_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.EndViewTransition(param1);
        public static TControl EndViewTransition<TControl>(this TControl component, Android.Views.View pview) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_EndViewTransition_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_FocusableViewAvailable_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.FocusableViewAvailable(param1);
        public static TControl FocusableViewAvailable<TControl>(this TControl component, Android.Views.View pv) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_FocusableViewAvailable_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pv);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, Android.Graphics.Rect>> _callExpression_InvalidateChild_Android_Views_ViewGroup__Android_Views_View_Android_Graphics_Rect = (view, param1, param2) => view.InvalidateChild(param1, param2);
        public static TControl InvalidateChild<TControl>(this TControl component, Android.Views.View pchild, Android.Graphics.Rect pdirty) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_InvalidateChild_Android_Views_ViewGroup__Android_Views_View_Android_Graphics_Rect;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, pdirty);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Int32, System.Int32, System.Int32, System.Int32>> _callExpression_Layout_Android_Views_ViewGroup__System_Int32_System_Int32_System_Int32_System_Int32 = (view, param1, param2, param3, param4) => view.Layout(param1, param2, param3, param4);
        public static TControl Layout<TControl>(this TControl component, System.Int32 pl, System.Int32 pt, System.Int32 pr, System.Int32 pb) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_Layout_Android_Views_ViewGroup__System_Int32_System_Int32_System_Int32_System_Int32;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pl, pt, pr, pb);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, Android.Views.View, Android.Views.Accessibility.ContentChangeTypes>> _callExpression_NotifySubtreeAccessibilityStateChanged_Android_Views_ViewGroup__Android_Views_View_Android_Views_View_Android_Views_Accessibility_ContentChangeTypes = (view, param1, param2, param3) => view.NotifySubtreeAccessibilityStateChanged(param1, param2, param3);
        public static TControl NotifySubtreeAccessibilityStateChanged<TControl>(this TControl component, Android.Views.View pchild, Android.Views.View psource, Android.Views.Accessibility.ContentChangeTypes pchangeType) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_NotifySubtreeAccessibilityStateChanged_Android_Views_ViewGroup__Android_Views_View_Android_Views_View_Android_Views_Accessibility_ContentChangeTypes;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, psource, pchangeType);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, Android.Graphics.Rect>> _callExpression_OffsetDescendantRectToMyCoords_Android_Views_ViewGroup__Android_Views_View_Android_Graphics_Rect = (view, param1, param2) => view.OffsetDescendantRectToMyCoords(param1, param2);
        public static TControl OffsetDescendantRectToMyCoords<TControl>(this TControl component, Android.Views.View pdescendant, Android.Graphics.Rect prect) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_OffsetDescendantRectToMyCoords_Android_Views_ViewGroup__Android_Views_View_Android_Graphics_Rect;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pdescendant, prect);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, Android.Graphics.Rect>> _callExpression_OffsetRectIntoDescendantCoords_Android_Views_ViewGroup__Android_Views_View_Android_Graphics_Rect = (view, param1, param2) => view.OffsetRectIntoDescendantCoords(param1, param2);
        public static TControl OffsetRectIntoDescendantCoords<TControl>(this TControl component, Android.Views.View pdescendant, Android.Graphics.Rect prect) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_OffsetRectIntoDescendantCoords_Android_Views_ViewGroup__Android_Views_View_Android_Graphics_Rect;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pdescendant, prect);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_RecomputeViewAttributes_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.RecomputeViewAttributes(param1);
        public static TControl RecomputeViewAttributes<TControl>(this TControl component, Android.Views.View pchild) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RecomputeViewAttributes_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup>> _callExpression_RemoveAllViews_Android_Views_ViewGroup_ = (view) => view.RemoveAllViews();
        public static TControl RemoveAllViews<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RemoveAllViews_Android_Views_ViewGroup_;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup>> _callExpression_RemoveAllViewsInLayout_Android_Views_ViewGroup_ = (view) => view.RemoveAllViewsInLayout();
        public static TControl RemoveAllViewsInLayout<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RemoveAllViewsInLayout_Android_Views_ViewGroup_;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_RemoveView_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.RemoveView(param1);
        public static TControl RemoveView<TControl>(this TControl component, Android.Views.View pview) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RemoveView_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Int32>> _callExpression_RemoveViewAt_Android_Views_ViewGroup__System_Int32 = (view, param1) => view.RemoveViewAt(param1);
        public static TControl RemoveViewAt<TControl>(this TControl component, System.Int32 pindex) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RemoveViewAt_Android_Views_ViewGroup__System_Int32;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pindex);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_RemoveViewInLayout_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.RemoveViewInLayout(param1);
        public static TControl RemoveViewInLayout<TControl>(this TControl component, Android.Views.View pview) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RemoveViewInLayout_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Int32, System.Int32>> _callExpression_RemoveViews_Android_Views_ViewGroup__System_Int32_System_Int32 = (view, param1, param2) => view.RemoveViews(param1, param2);
        public static TControl RemoveViews<TControl>(this TControl component, System.Int32 pstart, System.Int32 pcount) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RemoveViews_Android_Views_ViewGroup__System_Int32_System_Int32;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pstart, pcount);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Int32, System.Int32>> _callExpression_RemoveViewsInLayout_Android_Views_ViewGroup__System_Int32_System_Int32 = (view, param1, param2) => view.RemoveViewsInLayout(param1, param2);
        public static TControl RemoveViewsInLayout<TControl>(this TControl component, System.Int32 pstart, System.Int32 pcount) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RemoveViewsInLayout_Android_Views_ViewGroup__System_Int32_System_Int32;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pstart, pcount);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, Android.Views.View>> _callExpression_RequestChildFocus_Android_Views_ViewGroup__Android_Views_View_Android_Views_View = (view, param1, param2) => view.RequestChildFocus(param1, param2);
        public static TControl RequestChildFocus<TControl>(this TControl component, Android.Views.View pchild, Android.Views.View pfocused) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RequestChildFocus_Android_Views_ViewGroup__Android_Views_View_Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, pfocused);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Boolean>> _callExpression_RequestDisallowInterceptTouchEvent_Android_Views_ViewGroup__System_Boolean = (view, param1) => view.RequestDisallowInterceptTouchEvent(param1);
        public static TControl RequestDisallowInterceptTouchEvent<TControl>(this TControl component, System.Boolean pdisallowIntercept) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RequestDisallowInterceptTouchEvent_Android_Views_ViewGroup__System_Boolean;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pdisallowIntercept);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_RequestTransparentRegion_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.RequestTransparentRegion(param1);
        public static TControl RequestTransparentRegion<TControl>(this TControl component, Android.Views.View pchild) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_RequestTransparentRegion_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup>> _callExpression_ScheduleLayoutAnimation_Android_Views_ViewGroup_ = (view) => view.ScheduleLayoutAnimation();
        public static TControl ScheduleLayoutAnimation<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_ScheduleLayoutAnimation_Android_Views_ViewGroup_;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Boolean>> _callExpression_SetAddStatesFromChildren_Android_Views_ViewGroup__System_Boolean = (view, param1) => view.SetAddStatesFromChildren(param1);
        public static TControl SetAddStatesFromChildren<TControl>(this TControl component, System.Boolean paddsStates) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_SetAddStatesFromChildren_Android_Views_ViewGroup__System_Boolean;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, paddsStates);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Boolean>> _callExpression_SetClipChildren_Android_Views_ViewGroup__System_Boolean = (view, param1) => view.SetClipChildren(param1);
        public static TControl SetClipChildren<TControl>(this TControl component, System.Boolean pclipChildren) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_SetClipChildren_Android_Views_ViewGroup__System_Boolean;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pclipChildren);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, System.Boolean>> _callExpression_SetClipToPadding_Android_Views_ViewGroup__System_Boolean = (view, param1) => view.SetClipToPadding(param1);
        public static TControl SetClipToPadding<TControl>(this TControl component, System.Boolean pclipToPadding) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_SetClipToPadding_Android_Views_ViewGroup__System_Boolean;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pclipToPadding);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.ViewGroup.IOnHierarchyChangeListener>> _callExpression_SetOnHierarchyChangeListener_Android_Views_ViewGroup__Android_Views_ViewGroup_IOnHierarchyChangeListener = (view, param1) => view.SetOnHierarchyChangeListener(param1);
        public static TControl SetOnHierarchyChangeListener<TControl>(this TControl component, Android.Views.ViewGroup.IOnHierarchyChangeListener plistener) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_SetOnHierarchyChangeListener_Android_Views_ViewGroup__Android_Views_ViewGroup_IOnHierarchyChangeListener;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, plistener);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup>> _callExpression_StartLayoutAnimation_Android_Views_ViewGroup_ = (view) => view.StartLayoutAnimation();
        public static TControl StartLayoutAnimation<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_StartLayoutAnimation_Android_Views_ViewGroup_;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View>> _callExpression_StartViewTransition_Android_Views_ViewGroup__Android_Views_View = (view, param1) => view.StartViewTransition(param1);
        public static TControl StartViewTransition<TControl>(this TControl component, Android.Views.View pview) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_StartViewTransition_Android_Views_ViewGroup__Android_Views_View;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }
    public static partial class Android_Views_ViewGroup_Extensions
    {
        private static Expression<Action<Android.Views.ViewGroup, Android.Views.View, Android.Views.ViewGroup.LayoutParams>> _callExpression_UpdateViewLayout_Android_Views_ViewGroup__Android_Views_View_Android_Views_ViewGroup_LayoutParams = (view, param1, param2) => view.UpdateViewLayout(param1, param2);
        public static TControl UpdateViewLayout<TControl>(this TControl component, Android.Views.View pview, Android.Views.ViewGroup.LayoutParams pparams) where TControl:IReflectedPrimitive<Android.Views.ViewGroup>
        {
            var callExpression = _callExpression_UpdateViewLayout_Android_Views_ViewGroup__Android_Views_View_Android_Views_ViewGroup_LayoutParams;

            Reflect<Android.Views.ViewGroup>.ReflectionHelpers.Call(component.Attributes,callExpression, pview, pparams);
            return component;
        }
    }

    public static partial class Android_App_Activity_Extensions
    {
        private static readonly Attribute<Android.Transitions.TransitionManager> Attribute_TransitionManager_ContentTransitionManager = AttributeReflectionHelper.ResolveFor<Android.App.Activity, Android.Transitions.TransitionManager>
        (v => v.ContentTransitionManager);


        public static TControl ContentTransitionManager<TControl>(this TControl component, Android.Transitions.TransitionManager pContentTransitionManager)  where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.App.Activity t = default;
                t.ContentTransitionManager = default;
            }

            component.Attributes.SetAttribute(Attribute_TransitionManager_ContentTransitionManager,pContentTransitionManager);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_Immersive = AttributeReflectionHelper.ResolveFor<Android.App.Activity, System.Boolean>
        (v => v.Immersive);


        public static TControl Immersive<TControl>(this TControl component, System.Boolean pImmersive)  where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.App.Activity t = default;
                t.Immersive = default;
            }

            component.Attributes.SetAttribute(Attribute_Boolean_Immersive,pImmersive);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static readonly Attribute<Android.Content.Intent> Attribute_Intent_Intent = AttributeReflectionHelper.ResolveFor<Android.App.Activity, Android.Content.Intent>
        (v => v.Intent);


        public static TControl Intent<TControl>(this TControl component, Android.Content.Intent pIntent)  where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.App.Activity t = default;
                t.Intent = default;
            }

            component.Attributes.SetAttribute(Attribute_Intent_Intent,pIntent);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static readonly Attribute<Android.Media.Session.MediaController> Attribute_MediaController_MediaController = AttributeReflectionHelper.ResolveFor<Android.App.Activity, Android.Media.Session.MediaController>
        (v => v.MediaController);


        public static TControl MediaController<TControl>(this TControl component, Android.Media.Session.MediaController pMediaController)  where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.App.Activity t = default;
                t.MediaController = default;
            }

            component.Attributes.SetAttribute(Attribute_MediaController_MediaController,pMediaController);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static readonly Attribute<Android.Content.PM.ScreenOrientation> Attribute_ScreenOrientation_RequestedOrientation = AttributeReflectionHelper.ResolveFor<Android.App.Activity, Android.Content.PM.ScreenOrientation>
        (v => v.RequestedOrientation);


        public static TControl RequestedOrientation<TControl>(this TControl component, Android.Content.PM.ScreenOrientation pRequestedOrientation)  where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.App.Activity t = default;
                t.RequestedOrientation = default;
            }

            component.Attributes.SetAttribute(Attribute_ScreenOrientation_RequestedOrientation,pRequestedOrientation);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static readonly Attribute<Java.Lang.ICharSequence> Attribute_ICharSequence_TitleFormatted = AttributeReflectionHelper.ResolveFor<Android.App.Activity, Java.Lang.ICharSequence>
        (v => v.TitleFormatted);


        public static TControl TitleFormatted<TControl>(this TControl component, Java.Lang.ICharSequence pTitleFormatted)  where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.App.Activity t = default;
                t.TitleFormatted = default;
            }

            component.Attributes.SetAttribute(Attribute_ICharSequence_TitleFormatted,pTitleFormatted);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static readonly Attribute<System.String> Attribute_String_Title = AttributeReflectionHelper.ResolveFor<Android.App.Activity, System.String>
        (v => v.Title);


        public static TControl Title<TControl>(this TControl component, System.String pTitle)  where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.App.Activity t = default;
                t.Title = default;
            }

            component.Attributes.SetAttribute(Attribute_String_Title,pTitle);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static readonly Attribute<Android.Graphics.Color> Attribute_Color_TitleColor = AttributeReflectionHelper.ResolveFor<Android.App.Activity, Android.Graphics.Color>
        (v => v.TitleColor);


        public static TControl TitleColor<TControl>(this TControl component, Android.Graphics.Color pTitleColor)  where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.App.Activity t = default;
                t.TitleColor = default;
            }

            component.Attributes.SetAttribute(Attribute_Color_TitleColor,pTitleColor);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static readonly Attribute<Android.Media.Stream> Attribute_Stream_VolumeControlStream = AttributeReflectionHelper.ResolveFor<Android.App.Activity, Android.Media.Stream>
        (v => v.VolumeControlStream);


        public static TControl VolumeControlStream<TControl>(this TControl component, Android.Media.Stream pVolumeControlStream)  where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            if (Components.Primitives.NeverInclude)   
            {
                Android.App.Activity t = default;
                t.VolumeControlStream = default;
            }

            component.Attributes.SetAttribute(Attribute_Stream_VolumeControlStream,pVolumeControlStream);
            return component;
        }
    }


    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.View, Android.Views.ViewGroup.LayoutParams>> _callExpression_AddContentView_Android_App_Activity__Android_Views_View_Android_Views_ViewGroup_LayoutParams = (view, param1, param2) => view.AddContentView(param1, param2);
        public static TControl AddContentView<TControl>(this TControl component, Android.Views.View pview, Android.Views.ViewGroup.LayoutParams pparams) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_AddContentView_Android_App_Activity__Android_Views_View_Android_Views_ViewGroup_LayoutParams;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pview, pparams);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_CloseContextMenu_Android_App_Activity_ = (view) => view.CloseContextMenu();
        public static TControl CloseContextMenu<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_CloseContextMenu_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_CloseOptionsMenu_Android_App_Activity_ = (view) => view.CloseOptionsMenu();
        public static TControl CloseOptionsMenu<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_CloseOptionsMenu_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32>> _callExpression_DismissDialog_Android_App_Activity__System_Int32 = (view, param1) => view.DismissDialog(param1);
        public static TControl DismissDialog<TControl>(this TControl component, System.Int32 pid) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_DismissDialog_Android_App_Activity__System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pid);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_DismissKeyboardShortcutsHelper_Android_App_Activity_ = (view) => view.DismissKeyboardShortcutsHelper();
        public static TControl DismissKeyboardShortcutsHelper<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_DismissKeyboardShortcutsHelper_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.String, Java.IO.FileDescriptor, Java.IO.PrintWriter, System.String[]>> _callExpression_Dump_Android_App_Activity__System_String_Java_IO_FileDescriptor_Java_IO_PrintWriter_System_String_ = (view, param1, param2, param3, param4) => view.Dump(param1, param2, param3, param4);
        public static TControl Dump<TControl>(this TControl component, System.String pprefix, Java.IO.FileDescriptor pfd, Java.IO.PrintWriter pwriter, System.String[] pargs) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_Dump_Android_App_Activity__System_String_Java_IO_FileDescriptor_Java_IO_PrintWriter_System_String_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pprefix, pfd, pwriter, pargs);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_EnterPictureInPictureMode_Android_App_Activity_ = (view) => view.EnterPictureInPictureMode();
        public static TControl EnterPictureInPictureMode<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_EnterPictureInPictureMode_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.PictureInPictureParams>> _callExpression_EnterPictureInPictureMode_Android_App_Activity__Android_App_PictureInPictureParams = (view, param1) => view.EnterPictureInPictureMode(param1);
        public static TControl EnterPictureInPictureMode<TControl>(this TControl component, Android.App.PictureInPictureParams pparams) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_EnterPictureInPictureMode_Android_App_Activity__Android_App_PictureInPictureParams;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pparams);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_Finish_Android_App_Activity_ = (view) => view.Finish();
        public static TControl Finish<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_Finish_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32>> _callExpression_FinishActivity_Android_App_Activity__System_Int32 = (view, param1) => view.FinishActivity(param1);
        public static TControl FinishActivity<TControl>(this TControl component, System.Int32 prequestCode) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_FinishActivity_Android_App_Activity__System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, prequestCode);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.Activity, System.Int32>> _callExpression_FinishActivityFromChild_Android_App_Activity__Android_App_Activity_System_Int32 = (view, param1, param2) => view.FinishActivityFromChild(param1, param2);
        public static TControl FinishActivityFromChild<TControl>(this TControl component, Android.App.Activity pchild, System.Int32 prequestCode) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_FinishActivityFromChild_Android_App_Activity__Android_App_Activity_System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, prequestCode);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_FinishAffinity_Android_App_Activity_ = (view) => view.FinishAffinity();
        public static TControl FinishAffinity<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_FinishAffinity_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_FinishAfterTransition_Android_App_Activity_ = (view) => view.FinishAfterTransition();
        public static TControl FinishAfterTransition<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_FinishAfterTransition_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_FinishAndRemoveTask_Android_App_Activity_ = (view) => view.FinishAndRemoveTask();
        public static TControl FinishAndRemoveTask<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_FinishAndRemoveTask_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.Activity>> _callExpression_FinishFromChild_Android_App_Activity__Android_App_Activity = (view, param1) => view.FinishFromChild(param1);
        public static TControl FinishFromChild<TControl>(this TControl component, Android.App.Activity pchild) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_FinishFromChild_Android_App_Activity__Android_App_Activity;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_InvalidateOptionsMenu_Android_App_Activity_ = (view) => view.InvalidateOptionsMenu();
        public static TControl InvalidateOptionsMenu<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_InvalidateOptionsMenu_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.View>> _callExpression_OpenContextMenu_Android_App_Activity__Android_Views_View = (view, param1) => view.OpenContextMenu(param1);
        public static TControl OpenContextMenu<TControl>(this TControl component, Android.Views.View pview) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_OpenContextMenu_Android_App_Activity__Android_Views_View;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_OpenOptionsMenu_Android_App_Activity_ = (view) => view.OpenOptionsMenu();
        public static TControl OpenOptionsMenu<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_OpenOptionsMenu_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32, System.Int32>> _callExpression_OverridePendingTransition_Android_App_Activity__System_Int32_System_Int32 = (view, param1, param2) => view.OverridePendingTransition(param1, param2);
        public static TControl OverridePendingTransition<TControl>(this TControl component, System.Int32 penterAnim, System.Int32 pexitAnim) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_OverridePendingTransition_Android_App_Activity__System_Int32_System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, penterAnim, pexitAnim);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_PostponeEnterTransition_Android_App_Activity_ = (view) => view.PostponeEnterTransition();
        public static TControl PostponeEnterTransition<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_PostponeEnterTransition_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_Recreate_Android_App_Activity_ = (view) => view.Recreate();
        public static TControl Recreate<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_Recreate_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.View>> _callExpression_RegisterForContextMenu_Android_App_Activity__Android_Views_View = (view, param1) => view.RegisterForContextMenu(param1);
        public static TControl RegisterForContextMenu<TControl>(this TControl component, Android.Views.View pview) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_RegisterForContextMenu_Android_App_Activity__Android_Views_View;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32>> _callExpression_RemoveDialog_Android_App_Activity__System_Int32 = (view, param1) => view.RemoveDialog(param1);
        public static TControl RemoveDialog<TControl>(this TControl component, System.Int32 pid) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_RemoveDialog_Android_App_Activity__System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pid);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_ReportFullyDrawn_Android_App_Activity_ = (view) => view.ReportFullyDrawn();
        public static TControl ReportFullyDrawn<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_ReportFullyDrawn_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.String[], System.Int32>> _callExpression_RequestPermissions_Android_App_Activity__System_String__System_Int32 = (view, param1, param2) => view.RequestPermissions(param1, param2);
        public static TControl RequestPermissions<TControl>(this TControl component, System.String[] ppermissions, System.Int32 prequestCode) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_RequestPermissions_Android_App_Activity__System_String__System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, ppermissions, prequestCode);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_RequestShowKeyboardShortcuts_Android_App_Activity_ = (view) => view.RequestShowKeyboardShortcuts();
        public static TControl RequestShowKeyboardShortcuts<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_RequestShowKeyboardShortcuts_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Action>> _callExpression_RunOnUiThread_Android_App_Activity__System_Action = (view, param1) => view.RunOnUiThread(param1);
        public static TControl RunOnUiThread<TControl>(this TControl component, System.Action paction) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_RunOnUiThread_Android_App_Activity__System_Action;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, paction);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Java.Lang.IRunnable>> _callExpression_RunOnUiThread_Android_App_Activity__Java_Lang_IRunnable = (view, param1) => view.RunOnUiThread(param1);
        public static TControl RunOnUiThread<TControl>(this TControl component, Java.Lang.IRunnable paction) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_RunOnUiThread_Android_App_Activity__Java_Lang_IRunnable;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, paction);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Widget.Toolbar>> _callExpression_SetActionBar_Android_App_Activity__Android_Widget_Toolbar = (view, param1) => view.SetActionBar(param1);
        public static TControl SetActionBar<TControl>(this TControl component, Android.Widget.Toolbar ptoolbar) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetActionBar_Android_App_Activity__Android_Widget_Toolbar;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, ptoolbar);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.View>> _callExpression_SetContentView_Android_App_Activity__Android_Views_View = (view, param1) => view.SetContentView(param1);
        public static TControl SetContentView<TControl>(this TControl component, Android.Views.View pview) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetContentView_Android_App_Activity__Android_Views_View;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.View, Android.Views.ViewGroup.LayoutParams>> _callExpression_SetContentView_Android_App_Activity__Android_Views_View_Android_Views_ViewGroup_LayoutParams = (view, param1, param2) => view.SetContentView(param1, param2);
        public static TControl SetContentView<TControl>(this TControl component, Android.Views.View pview, Android.Views.ViewGroup.LayoutParams pparams) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetContentView_Android_App_Activity__Android_Views_View_Android_Views_ViewGroup_LayoutParams;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pview, pparams);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32>> _callExpression_SetContentView_Android_App_Activity__System_Int32 = (view, param1) => view.SetContentView(param1);
        public static TControl SetContentView<TControl>(this TControl component, System.Int32 playoutResID) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetContentView_Android_App_Activity__System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, playoutResID);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.DefaultKey>> _callExpression_SetDefaultKeyMode_Android_App_Activity__Android_App_DefaultKey = (view, param1) => view.SetDefaultKeyMode(param1);
        public static TControl SetDefaultKeyMode<TControl>(this TControl component, Android.App.DefaultKey pmode) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetDefaultKeyMode_Android_App_Activity__Android_App_DefaultKey;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pmode);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.SharedElementCallback>> _callExpression_SetEnterSharedElementCallback_Android_App_Activity__Android_App_SharedElementCallback = (view, param1) => view.SetEnterSharedElementCallback(param1);
        public static TControl SetEnterSharedElementCallback<TControl>(this TControl component, Android.App.SharedElementCallback pcallback) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetEnterSharedElementCallback_Android_App_Activity__Android_App_SharedElementCallback;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pcallback);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.SharedElementCallback>> _callExpression_SetExitSharedElementCallback_Android_App_Activity__Android_App_SharedElementCallback = (view, param1) => view.SetExitSharedElementCallback(param1);
        public static TControl SetExitSharedElementCallback<TControl>(this TControl component, Android.App.SharedElementCallback pcallback) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetExitSharedElementCallback_Android_App_Activity__Android_App_SharedElementCallback;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pcallback);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.WindowFeatures, Android.Graphics.Drawables.Drawable>> _callExpression_SetFeatureDrawable_Android_App_Activity__Android_Views_WindowFeatures_Android_Graphics_Drawables_Drawable = (view, param1, param2) => view.SetFeatureDrawable(param1, param2);
        public static TControl SetFeatureDrawable<TControl>(this TControl component, Android.Views.WindowFeatures pfeatureId, Android.Graphics.Drawables.Drawable pdrawable) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetFeatureDrawable_Android_App_Activity__Android_Views_WindowFeatures_Android_Graphics_Drawables_Drawable;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pfeatureId, pdrawable);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.WindowFeatures, System.Int32>> _callExpression_SetFeatureDrawableAlpha_Android_App_Activity__Android_Views_WindowFeatures_System_Int32 = (view, param1, param2) => view.SetFeatureDrawableAlpha(param1, param2);
        public static TControl SetFeatureDrawableAlpha<TControl>(this TControl component, Android.Views.WindowFeatures pfeatureId, System.Int32 palpha) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetFeatureDrawableAlpha_Android_App_Activity__Android_Views_WindowFeatures_System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pfeatureId, palpha);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.WindowFeatures, System.Int32>> _callExpression_SetFeatureDrawableResource_Android_App_Activity__Android_Views_WindowFeatures_System_Int32 = (view, param1, param2) => view.SetFeatureDrawableResource(param1, param2);
        public static TControl SetFeatureDrawableResource<TControl>(this TControl component, Android.Views.WindowFeatures pfeatureId, System.Int32 presId) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetFeatureDrawableResource_Android_App_Activity__Android_Views_WindowFeatures_System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pfeatureId, presId);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.WindowFeatures, Android.Net.Uri>> _callExpression_SetFeatureDrawableUri_Android_App_Activity__Android_Views_WindowFeatures_Android_Net_Uri = (view, param1, param2) => view.SetFeatureDrawableUri(param1, param2);
        public static TControl SetFeatureDrawableUri<TControl>(this TControl component, Android.Views.WindowFeatures pfeatureId, Android.Net.Uri puri) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetFeatureDrawableUri_Android_App_Activity__Android_Views_WindowFeatures_Android_Net_Uri;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pfeatureId, puri);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean>> _callExpression_SetFinishOnTouchOutside_Android_App_Activity__System_Boolean = (view, param1) => view.SetFinishOnTouchOutside(param1);
        public static TControl SetFinishOnTouchOutside<TControl>(this TControl component, System.Boolean pfinish) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetFinishOnTouchOutside_Android_App_Activity__System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pfinish);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean>> _callExpression_SetPersistent_Android_App_Activity__System_Boolean = (view, param1) => view.SetPersistent(param1);
        public static TControl SetPersistent<TControl>(this TControl component, System.Boolean pisPersistent) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetPersistent_Android_App_Activity__System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pisPersistent);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.PictureInPictureParams>> _callExpression_SetPictureInPictureParams_Android_App_Activity__Android_App_PictureInPictureParams = (view, param1) => view.SetPictureInPictureParams(param1);
        public static TControl SetPictureInPictureParams<TControl>(this TControl component, Android.App.PictureInPictureParams pparams) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetPictureInPictureParams_Android_App_Activity__Android_App_PictureInPictureParams;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pparams);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32>> _callExpression_SetProgress_Android_App_Activity__System_Int32 = (view, param1) => view.SetProgress(param1);
        public static TControl SetProgress<TControl>(this TControl component, System.Int32 pprogress) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetProgress_Android_App_Activity__System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pprogress);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean>> _callExpression_SetProgressBarIndeterminate_Android_App_Activity__System_Boolean = (view, param1) => view.SetProgressBarIndeterminate(param1);
        public static TControl SetProgressBarIndeterminate<TControl>(this TControl component, System.Boolean pindeterminate) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetProgressBarIndeterminate_Android_App_Activity__System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pindeterminate);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean>> _callExpression_SetProgressBarIndeterminateVisibility_Android_App_Activity__System_Boolean = (view, param1) => view.SetProgressBarIndeterminateVisibility(param1);
        public static TControl SetProgressBarIndeterminateVisibility<TControl>(this TControl component, System.Boolean pvisible) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetProgressBarIndeterminateVisibility_Android_App_Activity__System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pvisible);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean>> _callExpression_SetProgressBarVisibility_Android_App_Activity__System_Boolean = (view, param1) => view.SetProgressBarVisibility(param1);
        public static TControl SetProgressBarVisibility<TControl>(this TControl component, System.Boolean pvisible) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetProgressBarVisibility_Android_App_Activity__System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pvisible);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.Result>> _callExpression_SetResult_Android_App_Activity__Android_App_Result = (view, param1) => view.SetResult(param1);
        public static TControl SetResult<TControl>(this TControl component, Android.App.Result presultCode) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetResult_Android_App_Activity__Android_App_Result;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, presultCode);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.Result, Android.Content.Intent>> _callExpression_SetResult_Android_App_Activity__Android_App_Result_Android_Content_Intent = (view, param1, param2) => view.SetResult(param1, param2);
        public static TControl SetResult<TControl>(this TControl component, Android.App.Result presultCode, Android.Content.Intent pdata) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetResult_Android_App_Activity__Android_App_Result_Android_Content_Intent;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, presultCode, pdata);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32>> _callExpression_SetSecondaryProgress_Android_App_Activity__System_Int32 = (view, param1) => view.SetSecondaryProgress(param1);
        public static TControl SetSecondaryProgress<TControl>(this TControl component, System.Int32 psecondaryProgress) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetSecondaryProgress_Android_App_Activity__System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, psecondaryProgress);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean>> _callExpression_SetShowWhenLocked_Android_App_Activity__System_Boolean = (view, param1) => view.SetShowWhenLocked(param1);
        public static TControl SetShowWhenLocked<TControl>(this TControl component, System.Boolean pshowWhenLocked) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetShowWhenLocked_Android_App_Activity__System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pshowWhenLocked);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.ActivityManager.TaskDescription>> _callExpression_SetTaskDescription_Android_App_Activity__Android_App_ActivityManager_TaskDescription = (view, param1) => view.SetTaskDescription(param1);
        public static TControl SetTaskDescription<TControl>(this TControl component, Android.App.ActivityManager.TaskDescription ptaskDescription) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetTaskDescription_Android_App_Activity__Android_App_ActivityManager_TaskDescription;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, ptaskDescription);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32>> _callExpression_SetTitle_Android_App_Activity__System_Int32 = (view, param1) => view.SetTitle(param1);
        public static TControl SetTitle<TControl>(this TControl component, System.Int32 ptitleId) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetTitle_Android_App_Activity__System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, ptitleId);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean>> _callExpression_SetTurnScreenOn_Android_App_Activity__System_Boolean = (view, param1) => view.SetTurnScreenOn(param1);
        public static TControl SetTurnScreenOn<TControl>(this TControl component, System.Boolean pturnScreenOn) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetTurnScreenOn_Android_App_Activity__System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pturnScreenOn);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean>> _callExpression_SetVisible_Android_App_Activity__System_Boolean = (view, param1) => view.SetVisible(param1);
        public static TControl SetVisible<TControl>(this TControl component, System.Boolean pvisible) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetVisible_Android_App_Activity__System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pvisible);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean, Android.Content.ComponentName>> _callExpression_SetVrModeEnabled_Android_App_Activity__System_Boolean_Android_Content_ComponentName = (view, param1, param2) => view.SetVrModeEnabled(param1, param2);
        public static TControl SetVrModeEnabled<TControl>(this TControl component, System.Boolean penabled, Android.Content.ComponentName prequestedComponent) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_SetVrModeEnabled_Android_App_Activity__System_Boolean_Android_Content_ComponentName;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, penabled, prequestedComponent);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32>> _callExpression_ShowDialog_Android_App_Activity__System_Int32 = (view, param1) => view.ShowDialog(param1);
        public static TControl ShowDialog<TControl>(this TControl component, System.Int32 pid) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_ShowDialog_Android_App_Activity__System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pid);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Int32, Android.OS.Bundle>> _callExpression_ShowDialog_Android_App_Activity__System_Int32_Android_OS_Bundle = (view, param1, param2) => view.ShowDialog(param1, param2);
        public static TControl ShowDialog<TControl>(this TControl component, System.Int32 pid, Android.OS.Bundle pargs) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_ShowDialog_Android_App_Activity__System_Int32_Android_OS_Bundle;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pid, pargs);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_ShowLockTaskEscapeMessage_Android_App_Activity_ = (view) => view.ShowLockTaskEscapeMessage();
        public static TControl ShowLockTaskEscapeMessage<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_ShowLockTaskEscapeMessage_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Type, System.Int32>> _callExpression_StartActivityForResult_Android_App_Activity__System_Type_System_Int32 = (view, param1, param2) => view.StartActivityForResult(param1, param2);
        public static TControl StartActivityForResult<TControl>(this TControl component, System.Type pactivityType, System.Int32 prequestCode) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartActivityForResult_Android_App_Activity__System_Type_System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pactivityType, prequestCode);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Content.Intent, System.Int32>> _callExpression_StartActivityForResult_Android_App_Activity__Android_Content_Intent_System_Int32 = (view, param1, param2) => view.StartActivityForResult(param1, param2);
        public static TControl StartActivityForResult<TControl>(this TControl component, Android.Content.Intent pintent, System.Int32 prequestCode) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartActivityForResult_Android_App_Activity__Android_Content_Intent_System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pintent, prequestCode);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Content.Intent, System.Int32, Android.OS.Bundle>> _callExpression_StartActivityForResult_Android_App_Activity__Android_Content_Intent_System_Int32_Android_OS_Bundle = (view, param1, param2, param3) => view.StartActivityForResult(param1, param2, param3);
        public static TControl StartActivityForResult<TControl>(this TControl component, Android.Content.Intent pintent, System.Int32 prequestCode, Android.OS.Bundle poptions) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartActivityForResult_Android_App_Activity__Android_Content_Intent_System_Int32_Android_OS_Bundle;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pintent, prequestCode, poptions);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.Activity, Android.Content.Intent, System.Int32>> _callExpression_StartActivityFromChild_Android_App_Activity__Android_App_Activity_Android_Content_Intent_System_Int32 = (view, param1, param2, param3) => view.StartActivityFromChild(param1, param2, param3);
        public static TControl StartActivityFromChild<TControl>(this TControl component, Android.App.Activity pchild, Android.Content.Intent pintent, System.Int32 prequestCode) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartActivityFromChild_Android_App_Activity__Android_App_Activity_Android_Content_Intent_System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, pintent, prequestCode);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.Activity, Android.Content.Intent, System.Int32, Android.OS.Bundle>> _callExpression_StartActivityFromChild_Android_App_Activity__Android_App_Activity_Android_Content_Intent_System_Int32_Android_OS_Bundle = (view, param1, param2, param3, param4) => view.StartActivityFromChild(param1, param2, param3, param4);
        public static TControl StartActivityFromChild<TControl>(this TControl component, Android.App.Activity pchild, Android.Content.Intent pintent, System.Int32 prequestCode, Android.OS.Bundle poptions) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartActivityFromChild_Android_App_Activity__Android_App_Activity_Android_Content_Intent_System_Int32_Android_OS_Bundle;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pchild, pintent, prequestCode, poptions);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.Fragment, Android.Content.Intent, System.Int32>> _callExpression_StartActivityFromFragment_Android_App_Activity__Android_App_Fragment_Android_Content_Intent_System_Int32 = (view, param1, param2, param3) => view.StartActivityFromFragment(param1, param2, param3);
        public static TControl StartActivityFromFragment<TControl>(this TControl component, Android.App.Fragment pfragment, Android.Content.Intent pintent, System.Int32 prequestCode) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartActivityFromFragment_Android_App_Activity__Android_App_Fragment_Android_Content_Intent_System_Int32;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pfragment, pintent, prequestCode);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.App.Fragment, Android.Content.Intent, System.Int32, Android.OS.Bundle>> _callExpression_StartActivityFromFragment_Android_App_Activity__Android_App_Fragment_Android_Content_Intent_System_Int32_Android_OS_Bundle = (view, param1, param2, param3, param4) => view.StartActivityFromFragment(param1, param2, param3, param4);
        public static TControl StartActivityFromFragment<TControl>(this TControl component, Android.App.Fragment pfragment, Android.Content.Intent pintent, System.Int32 prequestCode, Android.OS.Bundle poptions) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartActivityFromFragment_Android_App_Activity__Android_App_Fragment_Android_Content_Intent_System_Int32_Android_OS_Bundle;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pfragment, pintent, prequestCode, poptions);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.OS.Bundle>> _callExpression_StartLocalVoiceInteraction_Android_App_Activity__Android_OS_Bundle = (view, param1) => view.StartLocalVoiceInteraction(param1);
        public static TControl StartLocalVoiceInteraction<TControl>(this TControl component, Android.OS.Bundle pprivateOptions) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartLocalVoiceInteraction_Android_App_Activity__Android_OS_Bundle;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pprivateOptions);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_StartLockTask_Android_App_Activity_ = (view) => view.StartLockTask();
        public static TControl StartLockTask<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartLockTask_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Database.ICursor>> _callExpression_StartManagingCursor_Android_App_Activity__Android_Database_ICursor = (view, param1) => view.StartManagingCursor(param1);
        public static TControl StartManagingCursor<TControl>(this TControl component, Android.Database.ICursor pc) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartManagingCursor_Android_App_Activity__Android_Database_ICursor;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pc);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_StartPostponedEnterTransition_Android_App_Activity_ = (view) => view.StartPostponedEnterTransition();
        public static TControl StartPostponedEnterTransition<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartPostponedEnterTransition_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.String, System.Boolean, Android.OS.Bundle, System.Boolean>> _callExpression_StartSearch_Android_App_Activity__System_String_System_Boolean_Android_OS_Bundle_System_Boolean = (view, param1, param2, param3, param4) => view.StartSearch(param1, param2, param3, param4);
        public static TControl StartSearch<TControl>(this TControl component, System.String pinitialQuery, System.Boolean pselectInitialQuery, Android.OS.Bundle pappSearchData, System.Boolean pglobalSearch) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StartSearch_Android_App_Activity__System_String_System_Boolean_Android_OS_Bundle_System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pinitialQuery, pselectInitialQuery, pappSearchData, pglobalSearch);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_StopLocalVoiceInteraction_Android_App_Activity_ = (view) => view.StopLocalVoiceInteraction();
        public static TControl StopLocalVoiceInteraction<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StopLocalVoiceInteraction_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity>> _callExpression_StopLockTask_Android_App_Activity_ = (view) => view.StopLockTask();
        public static TControl StopLockTask<TControl>(this TControl component) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StopLockTask_Android_App_Activity_;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Database.ICursor>> _callExpression_StopManagingCursor_Android_App_Activity__Android_Database_ICursor = (view, param1) => view.StopManagingCursor(param1);
        public static TControl StopManagingCursor<TControl>(this TControl component, Android.Database.ICursor pc) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_StopManagingCursor_Android_App_Activity__Android_Database_ICursor;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pc);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.Boolean>> _callExpression_TakeKeyEvents_Android_App_Activity__System_Boolean = (view, param1) => view.TakeKeyEvents(param1);
        public static TControl TakeKeyEvents<TControl>(this TControl component, System.Boolean pget) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_TakeKeyEvents_Android_App_Activity__System_Boolean;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pget);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, System.String, Android.OS.Bundle>> _callExpression_TriggerSearch_Android_App_Activity__System_String_Android_OS_Bundle = (view, param1, param2) => view.TriggerSearch(param1, param2);
        public static TControl TriggerSearch<TControl>(this TControl component, System.String pquery, Android.OS.Bundle pappSearchData) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_TriggerSearch_Android_App_Activity__System_String_Android_OS_Bundle;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pquery, pappSearchData);
            return component;
        }
    }
    public static partial class Android_App_Activity_Extensions
    {
        private static Expression<Action<Android.App.Activity, Android.Views.View>> _callExpression_UnregisterForContextMenu_Android_App_Activity__Android_Views_View = (view, param1) => view.UnregisterForContextMenu(param1);
        public static TControl UnregisterForContextMenu<TControl>(this TControl component, Android.Views.View pview) where TControl:IReflectedPrimitive<Android.App.Activity>
        {
            var callExpression = _callExpression_UnregisterForContextMenu_Android_App_Activity__Android_Views_View;

            Reflect<Android.App.Activity>.ReflectionHelpers.Call(component.Attributes,callExpression, pview);
            return component;
        }
    }
}