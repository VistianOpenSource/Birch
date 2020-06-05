using System;
using System.Collections.Generic;
using System.Linq;
using Android.Views;
using Birch.Components;

namespace Birch.Views
{
    public static partial class Primitives
    {
        /// <summary>
        /// Create a <see cref="AndroidView{TView}"/> instance without optional dimensions and id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dimensions"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static AndroidView<T> View<T>(Dimensions dimensions=default,int? id=default) where T : Android.Views.View
        {
            var control = new AndroidView<T>();

            if (dimensions != default)
            {
                control.Dimensions(dimensions);
            }

            if (id.HasValue)
            {
                control.Id(id.Value);
            }

            return control;
        }

        /// <summary>
        /// Create a <see cref="AndroidViewGroup{TView}"/> instance with a specified <see cref="Android.Views.ViewGroup.LayoutParams"/> factory.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="children"></param>
        /// <param name="layoutParams"></param>
        /// <param name="dimensions"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static AndroidViewGroup<T> ViewGroup<T>(IEnumerable<IPrimitive> children,Func<Dimensions,ViewGroup.LayoutParams> layoutParams,Dimensions dimensions=default,int? id=default) where T : Android.Views.ViewGroup
        {
            var control = new AndroidViewGroup<T>(layoutParams);

            if (dimensions != default)
            {
                control.Dimensions(dimensions);
            }

            if (id.HasValue)
            {
                control.Id(id.Value);
            }

            if (children != null)
            {
                control.Attributes.SetAttribute(Group.ChildrenAttribute, children.ToArray());
            }
            return control;
        }
    }
}