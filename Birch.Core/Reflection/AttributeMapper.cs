using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Diagnostics;
using Birch.Shadows;
using Microsoft.Extensions.Logging;

namespace Birch.Reflection
{
    /// <summary>
    /// Abstract base for an <see cref="IAttributeMapper"/> implementation.
    /// </summary>
    /// <typeparam name="TAttribute"></typeparam>
    /// <typeparam name="TControl"></typeparam>
    public abstract class AttributeMapper<TAttribute, TControl> : IAttributeMapper
    {
        public void Set(IShadow shadow, object next)
        {
            try
            {
                Set((IShadow<TControl>)shadow,(TAttribute)next);
            }
            catch (Exception exception)
            {
                // TODO: fix the exception 
                Logging.Instance.LogError(exception, $"Attribute Mapper<{typeof(TAttribute).Name},{typeof(TControl).Name}> setting to {next} failed");

                throw;
            }
        }

        public void Update(IShadow shadow, object current, object next)
        {
            this.Update((IShadow<TControl>)shadow,(TAttribute)current,(TAttribute)next);
        }

        public void Clear(IShadow shadow, object current)
        {
            this.Clear((IShadow<TControl>)shadow,(TAttribute)current);
        }

        protected abstract void Set(IShadow<TControl> shadow, TAttribute attribute);

        protected virtual void Update(IShadow<TControl> shadow, TAttribute current, TAttribute next)
        { }

        protected virtual void Clear(IShadow<TControl> shadow, TAttribute current)
        {
        }
    }
}
