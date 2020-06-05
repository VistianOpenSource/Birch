using System;
using Birch.Shadows;

namespace Birch.Reflection
{
    /// <summary>
    /// A function based AttributeMapper.
    /// </summary>
    /// <typeparam name="TAttribute"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <remarks>
    /// Three functions for set,update and clear are provided and invoked
    /// when needed.</remarks>
    public sealed class FuncAttributeMapper<TAttribute, T> : AttributeMapper<TAttribute, T>
    {
        /// <summary>
        /// The initial set function
        /// </summary>
        private readonly Action<IShadow<T>, TAttribute> _set;

        /// <summary>
        /// The value updated function
        /// </summary>
        private readonly Action<IShadow<T>, TAttribute, TAttribute> _update;

        /// <summary>
        /// The attribute no longer in use function.
        /// </summary>
        private readonly Action<IShadow<T>, TAttribute> _clear;


        public FuncAttributeMapper(Action<IShadow<T>, TAttribute> set,
            Action<IShadow<T>, TAttribute, TAttribute> update=default, Action<IShadow<T>, TAttribute> clear = default)
        {
            _set = set;
            _update = update;
            _clear = clear;
        }
        protected override void Set(IShadow<T> shadow, TAttribute attribute)
        {
            _set?.Invoke(shadow,attribute);
        }

        protected override void Update(IShadow<T> shadow, TAttribute current, TAttribute next)
        {
            _update?.Invoke(shadow,current,next);
        }

        protected override void Clear(IShadow<T> shadow, TAttribute current)
        {
            _clear?.Invoke(shadow,current);
        }
    }
}