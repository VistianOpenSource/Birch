using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Birch.Reflection
{
    public static class IReflectedPrimitiveExtensions
    {
        public static IReflectedPrimitive<TView> With<TView, TProp>(this IReflectedPrimitive<TView> primitive, Expression<Func<TView, TProp>> propertySetExpression, TProp value) 
        {
            Reflect<TView>.ReflectionHelpers.Set(primitive.Attributes,propertySetExpression,value);

            return primitive;
        }

        public static IReflectedPrimitive<TView> Call<TView, TProp>(this IReflectedPrimitive<TView> primitive, Expression<Action<TView, TProp>> propertyCallExpression, TProp value) 
        {
            Reflect<TView>.ReflectionHelpers.Call(primitive.Attributes,propertyCallExpression,value);

            return primitive;
        }

        public static IReflectedPrimitive<TView> Call<TView, TParam1,TParam2>(this IReflectedPrimitive<TView> primitive, Expression<Action<TView, TParam1,TParam2>> propertyCallExpression, TParam1 value1,TParam2 value2) 
        {
            Reflect<TView>.ReflectionHelpers.Call(primitive.Attributes,propertyCallExpression,value1,value2);

            return primitive;
        }


        public static IReflectedPrimitive<TView> With<TView, TProp>(this IReflectedPrimitive<TView> primitive, Expression<Action<TView, TProp>> propertyActionExpression, TProp value) 
        {
            Reflect<TView>.ReflectionHelpers.Call(primitive.Attributes,propertyActionExpression,value);

            return primitive;
        }

        public static IReflectedPrimitive<TView> Event<TView,TArgs>(this IReflectedPrimitive<TView> primitive,Expression<Func<TView, string>> eventNameExpression, Action<TArgs> action) where TView:class 
        {
            Reflect<TView>.ReflectionHelpers.Event(primitive.Attributes,eventNameExpression,action);
            return primitive;
        }

        public static IReflectedPrimitive<TView> Event<TView>(this IReflectedPrimitive<TView> primitive,
            Expression<Func<TView, string>> eventNameExpression, Action action) where TView:class 
        {
            Reflect<TView>.ReflectionHelpers.Event(primitive.Attributes,eventNameExpression,action);
            return primitive;
        }
    }
}
