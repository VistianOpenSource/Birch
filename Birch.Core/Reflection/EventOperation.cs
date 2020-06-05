using System;
using System.Reflection;
using Birch.Diagnostics;
using Birch.Shadows;
using Microsoft.Extensions.Logging;

namespace Birch.Reflection
{
    internal class EventOperation
    {
        public static Lazy<bool> IsLoggingEnabled = new Lazy<bool>(() => LoggingRules.For(Categories.Reflection).Any);
    }

    /// <summary>
    /// An <see cref="AttributeMapper{TAttribute,T}"/> for the setting up of event handlers.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    [Preserve(AllMembers = true)]
    internal class EventOperation<TView> : AttributeMapper<Action,TView>
    {
        private readonly MethodInfo _addMethod;
        private readonly MethodInfo _removeMethod;
        private readonly string _name;

        public EventOperation(EventInfo @event)
        {
            _name = @event.Name;
            _addMethod = @event.AddMethod;
            _removeMethod = @event.RemoveMethod;
        }

        /// <summary>
        /// Setup the event to call a specified action when invoked.
        /// </summary>
        /// <param name="shadow"></param>
        /// <param name="attribute"></param>
        protected override void Set(IShadow<TView> shadow, Action attribute)
        {
            try
            {
                EventHandler act = (sender, e) =>
                {
                    var action = shadow.State.Get<Action>(ProxyActionName);
                    action();
                };

                shadow.State.Set(_name,act);
                shadow.State.Set<Action>(ProxyActionName,attribute);

                _addMethod.Invoke(shadow.Item, new object[]{act});

                if (EventOperation.IsLoggingEnabled.Value)
                {
                    Logging.Instance.LogInformation("EventHandler added:{name} ",_name);
                }

            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,"Event:{eventName} add failed",_name);
                throw new InvalidOperationException($"Event:{_name} add failed",exception);
            }
        }


        protected override void Update(IShadow<TView> shadow, Action current, Action next)
        {
            base.Update(shadow, current, next);

            shadow.State.Set<Action>(ProxyActionName,next);
        }

        private string ProxyActionName => $"EventOperation{typeof(TView).Name}.{_name}";


        /// <summary>
        /// Remove the event handler
        /// </summary>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        protected override void Clear(IShadow<TView> shadow, Action current)
        {
            try
            {
                var removeMethod = _removeMethod;

                if (shadow.State.TryGetValue<EventHandler>(_name, out var act))
                {
                    removeMethod.Invoke(shadow.Item, new object[] {act});
                }


                // and remove the stored action
                shadow.State.Delete<Action>(ProxyActionName);

                if (EventOperation.IsLoggingEnabled.Value)
                {
                    Logging.Instance.LogInformation("EventHandler removed:{name} ",_name);
                }

            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,"Event:{eventName} clear failed",_name);
                throw new InvalidOperationException($"Event:{_name} clear failed",exception);
            }
        }
    }

    /// <summary>
    /// An <see cref="AttributeMapper{TAttribute,T}"/> for assignment of event handlers
    /// </summary>
    /// <typeparam name="TEventArgs"></typeparam>
    /// <typeparam name="TView"></typeparam>
    [Preserve(AllMembers = true)]
    public class EventOperation<TEventArgs, TView> : AttributeMapper<Action<TEventArgs>, TView>
    {
        private readonly MethodInfo _addMethod;
        private readonly MethodInfo _removeMethod;
        private readonly string _name;

        public EventOperation(EventInfo @event)
        {
            _name = @event.Name;
            _addMethod = @event.AddMethod;
            _removeMethod = @event.RemoveMethod;
        }

        /// <summary>
        /// Setup an event handler to call a specified action.
        /// </summary>
        /// <param name="shadow"></param>
        /// <param name="next"></param>
        protected override void Set(IShadow<TView> shadow, Action<TEventArgs> next)
        {
            try
            {
                EventHandler<TEventArgs> act = (sender, e) =>
                {
                    var action = shadow.State.Get <Action<TEventArgs>>(ProxyActionName);
                    action(e);
                };

                shadow.State.Set(_name,act);
                shadow.State.Set<Action<TEventArgs>>(ProxyActionName,next);

                _addMethod.Invoke(shadow.Item, new object[]{act});

                if (EventOperation.IsLoggingEnabled.Value)
                {
                    Logging.Instance.LogInformation("EventHandler added:{name} ",_name);
                }
            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,"Event:{eventName} add failed",_name);
                throw new InvalidOperationException($"Event:{_name} add failed",exception);
            }
        }

        protected override void Update(IShadow<TView> shadow, Action<TEventArgs> current, Action<TEventArgs> next)
        {
            base.Update(shadow, current, next);
            shadow.State.Set<Action<TEventArgs>>(ProxyActionName,next);
        }

        /// <summary>
        /// Remove a previously assigned event handler 
        /// </summary>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        protected override void Clear(IShadow<TView> shadow, Action<TEventArgs> current)
        {
            try
            {
                if (shadow.State.TryGetValue<EventHandler>(_name, out var act))
                {
                    _removeMethod.Invoke(shadow.Item, new object[] {act});
                }

                shadow.State.Delete<Action<TEventArgs>>(ProxyActionName);

                if (EventOperation.IsLoggingEnabled.Value)
                {
                    Logging.Instance.LogInformation("EventHandler removed:{name} ",_name);
                }
            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,"Event:{eventName} clear failed",_name);
                throw new InvalidOperationException($"Event:{_name} clear failed",exception);
            }
        }

        private string ProxyActionName => $"EventOperation{typeof(TView).Name}.{_name}";
    }
}