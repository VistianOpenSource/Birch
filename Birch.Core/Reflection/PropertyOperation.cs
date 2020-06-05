using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Birch.Diagnostics;
using Birch.Shadows;
using Microsoft.Extensions.Logging;

namespace Birch.Reflection
{
    /// <summary>
    /// A <see cref="AttributeMapper{TAttribute,T}"/> for properties.
    /// </summary>
    /// <typeparam name="TAttribute"></typeparam>
    /// <typeparam name="TView"></typeparam>
    [Preserve(AllMembers = true)]
    internal class PropertyOperation<TAttribute, TView>:AttributeMapper<TAttribute,TView>
    {
        /// <summary>
        /// The associated property
        /// </summary>
        private readonly PropertyInfo _property;

        /// <summary>
        /// The comparer to see whether property values have changed
        /// </summary>
        private static readonly EqualityComparer<TAttribute> EqualityComparer = EqualityComparer<TAttribute>.Default;

        /// <summary>
        /// Create an instance 
        /// </summary>
        /// <param name="property"></param>
        public PropertyOperation(PropertyInfo property)
        {
            _property = property;
        }

        /// <summary>
        /// Set the property value to a specified value.
        /// </summary>
        /// <param name="shadow"></param>
        /// <param name="attribute"></param>
        protected override void Set(IShadow<TView> shadow, TAttribute attribute)
        {
            try
            {
                var current = (TAttribute)_property.GetValue(shadow.Item);

                if (!EqualityComparer.Equals(current, attribute))
                {
                    if (PropertyOperation.IsLoggingEnabled.Value)
                    {
                        Logging.Instance.LogInformation("Property Set:{name} on:{object} value:{attribute} was:{original}",_property.Name,shadow.Item.GetType().Name,attribute,current);
                    }
                    _property.SetValue(shadow.Item,attribute);
                }

            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,"Property:{propertyName} assignment failed to:{value}",_property.Name,attribute);
                throw new InvalidOperationException($"Property:{_property.Name} assignment failed to:{attribute}",exception);
            }
        }

        /// <summary>
        /// Update the property value to a new value.
        /// </summary>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        protected override void Update(IShadow<TView> shadow, TAttribute current, TAttribute next)
        {
            try
            {
                var currentValue = (TAttribute)_property.GetValue(shadow.Item);

                // if the property hasn't changed, then don't update
                if (!EqualityComparer.Equals(currentValue, next))
                {
                    if (PropertyOperation.IsLoggingEnabled.Value)
                    {
                        Logging.Instance.LogInformation("Property Update:{name} on:{object} from:'{current}' to:'{next}'",_property.Name,shadow.Item.GetType().Name,current,next);
                    }

                    _property.SetValue(shadow.Item, next);
                }

            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,"Property:{propertyName} assignment failed to:{value}",_property.Name,next);
                throw new InvalidOperationException($"Property:{_property.Name} assignment failed to:next",exception);
            }
        }

        protected override void Clear(IShadow<TView> shadow, TAttribute current)
        {
            try
            {
                _property.SetValue(shadow.Item,GetDefaultValue(_property));
            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,"Property:{propertyName} clear failed",_property.Name);
                throw new InvalidOperationException($"Property:{_property.Name} clear failed",exception);
            }
        }

        private static object GetDefaultValue(PropertyInfo prop)
        {
            var attributes = prop.GetCustomAttributes(typeof(DefaultValueAttribute), true);
            if (attributes.Length > 0)
            {
                var defaultAttr = (DefaultValueAttribute)attributes[0];
                return defaultAttr.Value;
            }
            // Attribute not found, fall back to default value for the type
            return prop.PropertyType.IsValueType ? Activator.CreateInstance(prop.PropertyType) : null;
        }
    }

    internal class PropertyOperation
    {
        public static Lazy<bool> IsLoggingEnabled = new Lazy<bool>(() => LoggingRules.For(Categories.Reflection).Any);
    }
}