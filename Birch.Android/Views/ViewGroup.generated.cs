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

    public class BaseX
    {
        public int X { get; set; }
    }

    public class DerX : BaseX
    {
        public new float X { get; set; }
    }

    public static partial class Primitives
    {

        public static GridLayout GridLayout(IEnumerable<IPrimitive> children)
        {
            Android.Widget.AutoCompleteTextView ss = null;
            var control = new GridLayout(children);
            return control;
        }    
    }

    [ShadowMapper(typeof(ShadowMapper))]
    public class GridLayout : AndroidViewGroup<Android.Widget.GridLayout>
    {
        public GridLayout():this(default)
        {
        }

        public GridLayout(IEnumerable<IPrimitive> children):base((dimensions) => new Android.Widget.GridLayout.LayoutParams())
        {
            if (children != null)
            {
                this.Attributes.SetAttribute(Group.ChildrenAttribute, children.ToArray());
            }
        }

        public class ShadowMapper : ViewGroupShadowMapper<GridLayout,Android.Widget.GridLayout>
        {
        }
    }




    public static partial class Android_Widget_GridLayout_Extensions
    {
        private static readonly Attribute<Android.Widget.GridAlign> Attribute_GridAlign_AlignmentMode = AttributeReflectionHelper.ResolveFor<Android.Widget.GridLayout, Android.Widget.GridAlign>
        (v => v.AlignmentMode);

        public static TControl AlignmentMode<TControl>(this TControl component, Android.Widget.GridAlign alignmentMode)  where TControl:IReflectedPrimitive<Android.Widget.GridLayout>
            {
            component.Attributes.SetAttribute(Attribute_GridAlign_AlignmentMode,alignmentMode);
            return component;
            }
    }
    public static partial class Android_Widget_GridLayout_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_ColumnCount = AttributeReflectionHelper.ResolveFor<Android.Widget.GridLayout, System.Int32>
        (v => v.ColumnCount);

        public static TControl ColumnCount<TControl>(this TControl component, System.Int32 columnCount)  where TControl:IReflectedPrimitive<Android.Widget.GridLayout>
            {
            component.Attributes.SetAttribute(Attribute_Int32_ColumnCount,columnCount);
            return component;
            }
    }
    public static partial class Android_Widget_GridLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ColumnOrderPreserved = AttributeReflectionHelper.ResolveFor<Android.Widget.GridLayout, System.Boolean>
        (v => v.ColumnOrderPreserved);

        public static TControl ColumnOrderPreserved<TControl>(this TControl component, System.Boolean columnOrderPreserved)  where TControl:IReflectedPrimitive<Android.Widget.GridLayout>
            {
            component.Attributes.SetAttribute(Attribute_Boolean_ColumnOrderPreserved,columnOrderPreserved);
            return component;
            }
    }
    public static partial class Android_Widget_GridLayout_Extensions
    {
        private static readonly Attribute<Android.Widget.GridOrientation> Attribute_GridOrientation_Orientation = AttributeReflectionHelper.ResolveFor<Android.Widget.GridLayout, Android.Widget.GridOrientation>
        (v => v.Orientation);

        public static TControl Orientation<TControl>(this TControl component, Android.Widget.GridOrientation orientation)  where TControl:IReflectedPrimitive<Android.Widget.GridLayout>
            {
            component.Attributes.SetAttribute(Attribute_GridOrientation_Orientation,orientation);
            return component;
            }
    }
    public static partial class Android_Widget_GridLayout_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_RowCount = AttributeReflectionHelper.ResolveFor<Android.Widget.GridLayout, System.Int32>
        (v => v.RowCount);

        public static TControl RowCount<TControl>(this TControl component, System.Int32 rowCount)  where TControl:IReflectedPrimitive<Android.Widget.GridLayout>
            {
            component.Attributes.SetAttribute(Attribute_Int32_RowCount,rowCount);
            return component;
            }
    }
    public static partial class Android_Widget_GridLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_RowOrderPreserved = AttributeReflectionHelper.ResolveFor<Android.Widget.GridLayout, System.Boolean>
        (v => v.RowOrderPreserved);

        public static TControl RowOrderPreserved<TControl>(this TControl component, System.Boolean rowOrderPreserved)  where TControl:IReflectedPrimitive<Android.Widget.GridLayout>
            {
            component.Attributes.SetAttribute(Attribute_Boolean_RowOrderPreserved,rowOrderPreserved);
            return component;
            }
    }
    public static partial class Android_Widget_GridLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_UseDefaultMargins = AttributeReflectionHelper.ResolveFor<Android.Widget.GridLayout, System.Boolean>
        (v => v.UseDefaultMargins);

        public static TControl UseDefaultMargins<TControl>(this TControl component, System.Boolean useDefaultMargins)  where TControl:IReflectedPrimitive<Android.Widget.GridLayout>
            {
            component.Attributes.SetAttribute(Attribute_Boolean_UseDefaultMargins,useDefaultMargins);
            return component;
            }
    }


    public static partial class Primitives
    {
        public static LinearLayout LinearLayout(IEnumerable<IPrimitive> children)
        {
            var control = new LinearLayout(children);
            return control;
        }    
    }

    [ShadowMapper(typeof(ShadowMapper))]
    public class LinearLayout : AndroidViewGroup<Android.Widget.LinearLayout>
    {
        public LinearLayout():this(default)
        {
        }

        public LinearLayout(IEnumerable<IPrimitive> children):base((dimensions) => new Android.Widget.LinearLayout.LayoutParams(dimensions.Width, dimensions.Height))
        {
            if (children != null)
            {
                this.Attributes.SetAttribute(Group.ChildrenAttribute, children.ToArray());
            }
        }

        public class ShadowMapper : ViewGroupShadowMapper<LinearLayout,Android.Widget.LinearLayout>
        {
        }
    }




    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_BaselineAligned = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Boolean>
        (v => v.BaselineAligned);

        public static TControl BaselineAligned<TControl>(this TControl component, System.Boolean baselineAligned)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
            {
            component.Attributes.SetAttribute(Attribute_Boolean_BaselineAligned,baselineAligned);
            return component;
            }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_BaselineAlignedChildIndex = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Int32>
        (v => v.BaselineAlignedChildIndex);

        public static TControl BaselineAlignedChildIndex<TControl>(this TControl component, System.Int32 baselineAlignedChildIndex)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
            {
            component.Attributes.SetAttribute(Attribute_Int32_BaselineAlignedChildIndex,baselineAlignedChildIndex);
            return component;
            }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Int32> Attribute_Int32_DividerPadding = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Int32>
        (v => v.DividerPadding);

        public static TControl DividerPadding<TControl>(this TControl component, System.Int32 dividerPadding)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
            {
            component.Attributes.SetAttribute(Attribute_Int32_DividerPadding,dividerPadding);
            return component;
            }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_MeasureWithLargestChildEnabled = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Boolean>
        (v => v.MeasureWithLargestChildEnabled);

        public static TControl MeasureWithLargestChildEnabled<TControl>(this TControl component, System.Boolean measureWithLargestChildEnabled)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
            {
            component.Attributes.SetAttribute(Attribute_Boolean_MeasureWithLargestChildEnabled,measureWithLargestChildEnabled);
            return component;
            }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<Android.Widget.Orientation> Attribute_Orientation_Orientation = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, Android.Widget.Orientation>
        (v => v.Orientation);

        public static TControl Orientation<TControl>(this TControl component, Android.Widget.Orientation orientation)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
            {
            component.Attributes.SetAttribute(Attribute_Orientation_Orientation,orientation);
            return component;
            }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<Android.Widget.ShowDividers> Attribute_ShowDividers_ShowDividers = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, Android.Widget.ShowDividers>
        (v => v.ShowDividers);

        public static TControl ShowDividers<TControl>(this TControl component, Android.Widget.ShowDividers showDividers)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
            {
            component.Attributes.SetAttribute(Attribute_ShowDividers_ShowDividers,showDividers);
            return component;
            }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static readonly Attribute<System.Single> Attribute_Single_WeightSum = AttributeReflectionHelper.ResolveFor<Android.Widget.LinearLayout, System.Single>
        (v => v.WeightSum);

        public static TControl WeightSum<TControl>(this TControl component, System.Single weightSum)  where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
            {
            component.Attributes.SetAttribute(Attribute_Single_WeightSum,weightSum);
            return component;
            }
    }


    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static Expression<Action<Android.Widget.LinearLayout, Android.Graphics.Drawables.Drawable>> _callExpression_SetDividerDrawable_Android_Widget_LinearLayout__Android_Graphics_Drawables_Drawable = (view, param1) => view.SetDividerDrawable(param1);
        public static TControl SetDividerDrawable<TControl>(this TControl component, Android.Graphics.Drawables.Drawable divider) where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            var callExpression = _callExpression_SetDividerDrawable_Android_Widget_LinearLayout__Android_Graphics_Drawables_Drawable;

            Reflect<Android.Widget.LinearLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, divider);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static Expression<Action<Android.Widget.LinearLayout, Android.Views.GravityFlags>> _callExpression_SetGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags = (view, param1) => view.SetGravity(param1);
        public static TControl SetGravity<TControl>(this TControl component, Android.Views.GravityFlags gravity) where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            var callExpression = _callExpression_SetGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.LinearLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, gravity);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static Expression<Action<Android.Widget.LinearLayout, Android.Views.GravityFlags>> _callExpression_SetHorizontalGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags = (view, param1) => view.SetHorizontalGravity(param1);
        public static TControl SetHorizontalGravity<TControl>(this TControl component, Android.Views.GravityFlags horizontalGravity) where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            var callExpression = _callExpression_SetHorizontalGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.LinearLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, horizontalGravity);
            return component;
        }
    }
    public static partial class Android_Widget_LinearLayout_Extensions
    {
        private static Expression<Action<Android.Widget.LinearLayout, Android.Views.GravityFlags>> _callExpression_SetVerticalGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags = (view, param1) => view.SetVerticalGravity(param1);
        public static TControl SetVerticalGravity<TControl>(this TControl component, Android.Views.GravityFlags verticalGravity) where TControl:IReflectedPrimitive<Android.Widget.LinearLayout>
        {
            var callExpression = _callExpression_SetVerticalGravity_Android_Widget_LinearLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.LinearLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, verticalGravity);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static RelativeLayout RelativeLayout(IEnumerable<IPrimitive> children)
        {
            var control = new RelativeLayout(children);
            return control;
        }    
    }

    [ShadowMapper(typeof(ShadowMapper))]
    public class RelativeLayout : AndroidViewGroup<Android.Widget.RelativeLayout>
    {
        public RelativeLayout():this(default)
        {
        }

        public RelativeLayout(IEnumerable<IPrimitive> children):base((dimensions) => new Android.Widget.RelativeLayout.LayoutParams(dimensions.Width, dimensions.Height))
        {
            if (children != null)
            {
                this.Attributes.SetAttribute(Group.ChildrenAttribute, children.ToArray());
            }
        }

        public class ShadowMapper : ViewGroupShadowMapper<RelativeLayout,Android.Widget.RelativeLayout>
        {
        }
    }






    public static partial class Android_Widget_RelativeLayout_Extensions
    {
        private static Expression<Action<Android.Widget.RelativeLayout, Android.Views.GravityFlags>> _callExpression_SetGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags = (view, param1) => view.SetGravity(param1);
        public static TControl SetGravity<TControl>(this TControl component, Android.Views.GravityFlags gravity) where TControl:IReflectedPrimitive<Android.Widget.RelativeLayout>
        {
            var callExpression = _callExpression_SetGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.RelativeLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, gravity);
            return component;
        }
    }
    public static partial class Android_Widget_RelativeLayout_Extensions
    {
        private static Expression<Action<Android.Widget.RelativeLayout, Android.Views.GravityFlags>> _callExpression_SetHorizontalGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags = (view, param1) => view.SetHorizontalGravity(param1);
        public static TControl SetHorizontalGravity<TControl>(this TControl component, Android.Views.GravityFlags horizontalGravity) where TControl:IReflectedPrimitive<Android.Widget.RelativeLayout>
        {
            var callExpression = _callExpression_SetHorizontalGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.RelativeLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, horizontalGravity);
            return component;
        }
    }
    public static partial class Android_Widget_RelativeLayout_Extensions
    {
        private static Expression<Action<Android.Widget.RelativeLayout, System.Int32>> _callExpression_SetIgnoreGravity_Android_Widget_RelativeLayout__System_Int32 = (view, param1) => view.SetIgnoreGravity(param1);
        public static TControl SetIgnoreGravity<TControl>(this TControl component, System.Int32 viewId) where TControl:IReflectedPrimitive<Android.Widget.RelativeLayout>
        {
            var callExpression = _callExpression_SetIgnoreGravity_Android_Widget_RelativeLayout__System_Int32;

            Reflect<Android.Widget.RelativeLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, viewId);
            return component;
        }
    }
    public static partial class Android_Widget_RelativeLayout_Extensions
    {
        private static Expression<Action<Android.Widget.RelativeLayout, Android.Views.GravityFlags>> _callExpression_SetVerticalGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags = (view, param1) => view.SetVerticalGravity(param1);
        public static TControl SetVerticalGravity<TControl>(this TControl component, Android.Views.GravityFlags verticalGravity) where TControl:IReflectedPrimitive<Android.Widget.RelativeLayout>
        {
            var callExpression = _callExpression_SetVerticalGravity_Android_Widget_RelativeLayout__Android_Views_GravityFlags;

            Reflect<Android.Widget.RelativeLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, verticalGravity);
            return component;
        }
    }
    public static partial class Primitives
    {
        public static TableLayout TableLayout(IEnumerable<IPrimitive> children)
        {
            var control = new TableLayout(children);
            return control;
        }    
    }

    [ShadowMapper(typeof(ShadowMapper))]
    public class TableLayout : AndroidViewGroup<Android.Widget.TableLayout>
    {
        public TableLayout():this(default)
        {
        }

        public TableLayout(IEnumerable<IPrimitive> children):base((dimensions) => new Android.Widget.TableLayout.LayoutParams(dimensions.Width, dimensions.Height))
        {
            if (children != null)
            {
                this.Attributes.SetAttribute(Group.ChildrenAttribute, children.ToArray());
            }
        }

        public class ShadowMapper : ViewGroupShadowMapper<TableLayout,Android.Widget.TableLayout>
        {
        }
    }




    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_ShrinkAllColumns = AttributeReflectionHelper.ResolveFor<Android.Widget.TableLayout, System.Boolean>
        (v => v.ShrinkAllColumns);

        public static TControl ShrinkAllColumns<TControl>(this TControl component, System.Boolean shrinkAllColumns)  where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
            {
            component.Attributes.SetAttribute(Attribute_Boolean_ShrinkAllColumns,shrinkAllColumns);
            return component;
            }
    }
    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static readonly Attribute<System.Boolean> Attribute_Boolean_StretchAllColumns = AttributeReflectionHelper.ResolveFor<Android.Widget.TableLayout, System.Boolean>
        (v => v.StretchAllColumns);

        public static TControl StretchAllColumns<TControl>(this TControl component, System.Boolean stretchAllColumns)  where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
            {
            component.Attributes.SetAttribute(Attribute_Boolean_StretchAllColumns,stretchAllColumns);
            return component;
            }
    }


    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static Expression<Action<Android.Widget.TableLayout, System.Int32, System.Boolean>> _callExpression_SetColumnCollapsed_Android_Widget_TableLayout__System_Int32_System_Boolean = (view, param1, param2) => view.SetColumnCollapsed(param1, param2);
        public static TControl SetColumnCollapsed<TControl>(this TControl component, System.Int32 columnIndex, System.Boolean isCollapsed) where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
        {
            var callExpression = _callExpression_SetColumnCollapsed_Android_Widget_TableLayout__System_Int32_System_Boolean;

            Reflect<Android.Widget.TableLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, columnIndex, isCollapsed);
            return component;
        }
    }
    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static Expression<Action<Android.Widget.TableLayout, System.Int32, System.Boolean>> _callExpression_SetColumnShrinkable_Android_Widget_TableLayout__System_Int32_System_Boolean = (view, param1, param2) => view.SetColumnShrinkable(param1, param2);
        public static TControl SetColumnShrinkable<TControl>(this TControl component, System.Int32 columnIndex, System.Boolean isShrinkable) where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
        {
            var callExpression = _callExpression_SetColumnShrinkable_Android_Widget_TableLayout__System_Int32_System_Boolean;

            Reflect<Android.Widget.TableLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, columnIndex, isShrinkable);
            return component;
        }
    }
    public static partial class Android_Widget_TableLayout_Extensions
    {
        private static Expression<Action<Android.Widget.TableLayout, System.Int32, System.Boolean>> _callExpression_SetColumnStretchable_Android_Widget_TableLayout__System_Int32_System_Boolean = (view, param1, param2) => view.SetColumnStretchable(param1, param2);
        public static TControl SetColumnStretchable<TControl>(this TControl component, System.Int32 columnIndex, System.Boolean isStretchable) where TControl:IReflectedPrimitive<Android.Widget.TableLayout>
        {
            var callExpression = _callExpression_SetColumnStretchable_Android_Widget_TableLayout__System_Int32_System_Boolean;

            Reflect<Android.Widget.TableLayout>.ReflectionHelpers.Call(component.Attributes,callExpression, columnIndex, isStretchable);
            return component;
        }
    }
}