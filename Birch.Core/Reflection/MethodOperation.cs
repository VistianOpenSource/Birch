using System;
using System.Reflection;
using Birch.Diagnostics;
using Birch.Shadows;
using Microsoft.Extensions.Logging;

namespace Birch.Reflection
{
    /// <summary>
    /// A <see cref="AttributeMapper{TAttribute,T}"/> used for invocation of methods on an object
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    [Preserve(AllMembers = true)]
    internal class MethodOperation<TView> : AttributeMapper<object[], TView>
    {
        /// <summary>
        /// The associated method
        /// </summary>
        private readonly MethodInfo _method;

        public MethodOperation(MethodInfo method)
        {
            _method = method;
        }

        /// <summary>
        /// Invoke the method with the specified values
        /// </summary>
        /// <param name="shadow"></param>
        /// <param name="attributes"></param>
        protected override void Set(IShadow<TView> shadow, object[] attributes)
        {
            if (MethodOperation.IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation("Method called:{name} on:{object} with:{attributes}",_method.Name,shadow.Item.GetType().Name,attributes);
            }

            try
            {
                _method.Invoke(shadow.Item, attributes);
            }
            catch (Exception exception)
            {
                throw new ArgumentException($"Invocation of method:{_method.Name} failure on type:{shadow.Item.GetType()} ",exception);
            }

        }

        /// <summary>
        /// Invoke the method with the specified values
        /// </summary>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        protected override void Update(IShadow<TView> shadow, object[] current, object[] next)
        {
            if (MethodOperation.IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation("Method update called:{name} on:{object} from:{current} to:{next}",_method.Name,shadow.Item.GetType().Name,current,next);
            }

            try
            {
                _method.Invoke(shadow.Item, next);
            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,"Invocation of method:{name} failure on type:{typeName} ",_method.Name,shadow.Item.GetType());
                throw new ArgumentException($"Invocation of method:{_method.Name} failure on type:{shadow.Item.GetType()} ",exception);
            }

        }
    }


    internal class MethodOperation
    {
        public static Lazy<bool> IsLoggingEnabled = new Lazy<bool>(() => LoggingRules.For(Categories.Reflection).Any);
    }
}