using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Shadows;

namespace Birch.Reflection
{
    public static class AttributeMapper
    {
        /// <summary>
        /// Create a function based attribute mapper.
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="set"></param>
        /// <param name="update"></param>
        /// <param name="clear"></param>
        /// <returns></returns>
        public static AttributeMapper<TAttribute, T> Mapper<TAttribute, T>(this Attribute<TAttribute> attribute,Action<IShadow<T>, TAttribute> set,
            Action<IShadow<T>, TAttribute, TAttribute> update=default, Action<IShadow<T>, TAttribute> clear = default)
        {
            return new FuncAttributeMapper<TAttribute, T>(set, update, clear);
        }

        /// <summary>
        /// Create a single function based attribute mapper.
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="assign"></param>
        /// <returns></returns>
        public static AttributeMapper<TAttribute,T> Mapper<TAttribute, T>(this Attribute<TAttribute> attribute,Action<T, TAttribute> assign)
        {
            return new FuncAttributeMapper<TAttribute, T>((s,a) => assign(s.Item,a), (s,c,n) => assign(s.Item,n), (s,c) => assign(s.Item,default));
        }
    }
}
