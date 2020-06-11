using System;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Reflection;
using Microsoft.Extensions.Logging;

namespace Birch.Shadows
{
    public abstract class Shadow:IShadow
    {
        /// <summary>
        /// Update a shadow given current and next values.
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="context"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        /// <param name="shadow"></param>
        /// <param name="added"></param>
        /// <param name="removed"></param>
        public static void Update<TItem>(IShadowContext context,IPrimitive current,
                                                                IPrimitive next, 
                                                                IShadow<TItem> shadow,
                                                                Action<IShadow<TItem>> added=default,
                                                                Action<IShadow<TItem>> removed=default) 
        {
            // current == null and next != null implies -> new
            // current != null && next != null implies -> update/change
            // current != null && next == null, implies -> remove

            try
            {
                // now, we do have a problem in that the shadow may not exist...// 
                // if so then its a create
                if (shadow != null)
                {
                    // the shadow could well change...
                    // in this case, we need to ...

                    var sameElementType = current.AreSameType(next);

                    if (!sameElementType)
                    {
                        if (current != null)
                        {
                            // this isn't right, since the layout hasn't been retained
                            context.MapperFactory.Remove(context, shadow, current);
                            // we could want to 'drop' the content view here, how would we do that ?
                            removed?.Invoke(shadow);
                            shadow = default;
                        }
                    }
                    else
                    {
                        context.MapperFactory.Update(context,shadow,current,next);
                    }
                }

                if (shadow == null)
                {
                    var baseShadow = context.MapperFactory.Create(context, next);

                    shadow = (IShadow<TItem>) baseShadow;
        
                    added?.Invoke(shadow);
                }

            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,"Shadow:Update Current:{current} Next:{next} ShadowType:{shadowType}",current,next,shadow?.GetType().FriendlyName());
                throw;
            }
        }

        /// <summary>
        /// Create a shadow instance, with the actual assignment of the backing value occuring upon first reference.
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="create">The function which will create the backing value</param>
        /// <returns></returns>
        /// <remarks>
        /// Typically, the actual content of a shadow should not be referenced at all when
        /// transactions are being constructed but rather upon transaction commit.
        /// At this stage it is then reasonable for the create function to be
        /// invoked in a valid environment.</remarks>
        public static Shadow<TItem> Create<TItem>(Func<TItem> create) where TItem : class
        {
            var actualShadow = new ShadowImplFromFunc<TItem>(create);

            var shadow = new Shadow<TItem>(actualShadow);

            return shadow;
        }

        public static Shadow<TItem> Create<TItem>(Func<IShadow<TItem>> create) where TItem : class
        {
            var actualShadow = new ShadowImplReference<TItem>(create);

            var shadow = new Shadow<TItem>(actualShadow);

            return shadow;
        }

        
        /// <summary>
        /// The actual type of the backing value
        /// </summary>
        public abstract Type ShadowType { get; }

        public abstract ContainerBag State { get; }

        public abstract void Dispose();
    }

    /// <summary>
    /// Most common implementation of <see cref="IShadow"/>
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class Shadow<TItem>:Shadow,IShadow<TItem> where TItem : class
    {
        private readonly IShadowImpl<TItem> _implementation;

        public Shadow(IShadowImpl<TItem> implementation)
        {
            _implementation = implementation;
        }

        /// <summary>
        /// Attempt to get the underlying value
        /// </summary>
        public TItem Item => _implementation.Item;


        /// <summary>
        /// Get the actual type of backing value
        /// </summary>
        public override Type ShadowType => typeof(TItem);

        /// <summary>
        /// Get the container into which additional content can be optionally stored. 
        /// </summary>
        public override ContainerBag State => _implementation.State;

        public override void Dispose()
        {
            _implementation?.Dispose();
        }
    }


    /// <summary>
    /// Specification of an actual shadow implementation
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public interface IShadowImpl<out TItem>:IShadow<TItem>
    {
    }

    /// <summary>
    /// A shadow implementation where the backing value is specified
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public sealed class ShadowImplInline<TItem>:IShadowImpl<TItem> where TItem : class
    {
        /// <summary>
        /// A weak reference to the underlying item
        /// </summary>
        private WeakReference<TItem> _item;

        /// <summary>
        /// Attempt to get the underlying value
        /// </summary>
        public TItem Item => _item != null ? (_item.TryGetTarget(out var item) ? item : default):default;

        /// <summary>
        /// Private backing store for any state held against this shadow.
        /// </summary>
        private ContainerBag _state;

        /// <summary>
        /// Get the container into which additional content can be optionally stored. 
        /// </summary>
        public ContainerBag State => _state ??= new ContainerBag();

        public Type ShadowType => typeof(TItem);

        /// <summary>
        /// Assign the actual backing value.
        /// </summary>
        /// <param name="item"></param>
        public void Set(TItem item) => _item = new WeakReference<TItem>(item);


        public ShadowImplInline()
        {
        }

        /// <summary>
        /// Create an instance with a specified backing value.
        /// </summary>
        /// <param name="item"></param>
        public ShadowImplInline(TItem item)
        {
            _item = new WeakReference<TItem>(item);
        }

        public void Dispose()
        {
            if (_item != null)
            {
                if (_item.TryGetTarget(out var item) && item is IDisposable disposable)
                {
                    disposable.Dispose();
                }

                _item = null;
            }
        }
    }


    /// <summary>
    /// A shadow implementation where the backing value is the result of a function.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class ShadowImplFromFunc<TItem> : IShadowImpl<TItem> where TItem : class
    {
        private readonly Func<TItem> _itemFunc;

        public Type ShadowType => typeof(TItem);

        public TItem Item
        {
            get
            {
                if (_item == null)
                {
                    _item = new WeakReference<TItem>(_itemFunc());
                }

                return _item != null ? (_item.TryGetTarget(out var item) ? item : default):default;
            }
        }

        public ContainerBag State { get; } = new ContainerBag();

        private WeakReference<TItem> _item;

        public ShadowImplFromFunc(Func<TItem> itemFunc)
        {
            _itemFunc = itemFunc;
        }

        public void Dispose()
        {
            if (_item != null)
            {
                if (_item.TryGetTarget(out var item) && item is IDisposable disposable)
                {
                    disposable.Dispose();
                }

                _item = null;
            }
        }
    }

    /// <summary>
    /// A shadow implementation where the backing value is contained in another shadow.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class ShadowImplReference<TItem> : IShadowImpl<TItem> where TItem : class
    {
        private readonly Func<IShadow<TItem>> _shadow;

        public Type ShadowType => typeof(TItem);
        public TItem Item => _shadow().Item;
        public ContainerBag State => _shadow().State;


        public ShadowImplReference(Func<IShadow<TItem>> shadow)
        {
            _shadow = shadow;
        }

        public void Dispose()
        {
            // we don't do a dispose when we have received a reference 
        }
    }
}