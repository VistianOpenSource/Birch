using System;
using Birch.Diagnostics;
using Birch.Reflection;
using Birch.Shadows;
using Birch.Transactions;
using Microsoft.Extensions.Logging;

namespace Birch.Components
{
    public static class AttributeExtensions
    {
        public static (Attribute<TValue>,TValue) With<TValue>(this Attribute<TValue> attribute,TValue value) => (attribute, value);

        public static void Update(this Attribute attribute,
            IShadow shadow,
            IPrimitive current,
            IPrimitive next,
            IAttributeMapper mapper)
        {
            object currentValue = default;
            object nextValue = default;

            var hasCurrent = current?.Attributes.TryGetAttribute(attribute, out currentValue)??false;
            var hasNext = next?.Attributes.TryGetAttribute(attribute, out nextValue)??false;

            if (hasNext && !hasCurrent)
            {
                Transaction.Current.Add(() =>
                {
                    // now need to use the function that does the updating, 
                    mapper.Set(shadow,nextValue);
                });
                ;

                // set operation
                return;
            }

            if (!hasNext && hasCurrent)
            {
                Transaction.Current.Add(() =>
                {
                    mapper.Clear(shadow,currentValue);
                });

                // clear operation
                return;
            }

            // now need to do an equality comparison
            if (hasCurrent && !attribute.CompareValues(currentValue,nextValue))
            {
                Transaction.Current.Add(() =>
                {
                    try
                    {
                        mapper.Update(shadow,currentValue,nextValue);
                    }
                    catch (Exception exception)
                    {
                        Logging.Instance.LogError(exception,"Attribute Mapper update failure, current:{from} next:{next}",currentValue,nextValue);
                        throw;
                    }
                });
            }
        }

        public static void Update<TItem, TContext, TComponent, TAttribute>(this Attribute<TAttribute> attribute,ElementValue<TComponent> current,
            ElementValue<TComponent> next,
            TContext context, IShadow<TItem> item,
            Action<IShadow<TItem>, TComponent, TAttribute> set = default,
            Action<IShadow<TItem>, TComponent, TAttribute, TAttribute> update = default,
            Action<IShadow<TItem>, TComponent, TAttribute> remove = default) where TComponent : BasePrimitive
        {
            var nextValue = next.Value(attribute);
            var currentValue = current.Value(attribute);

            if (nextValue.HasValue && !currentValue.HasValue)
            {
                Transaction.Current.Add(() =>
                {
                    set?.Invoke(item, next.Primitive,nextValue );
                });
                ;

                // set operation
                return;
            }

            if (!nextValue.HasValue && currentValue.HasValue)
            {
                Transaction.Current.Add(() =>
                {
                    remove?.Invoke(item,current.Primitive,currentValue);
                });

                // clear operation
                return;
            }

            // now need to do an equality comparison
            if (currentValue.HasValue && !attribute.CompareValues(currentValue.Item,nextValue.Item))
            {
                // update
                Transaction.Current.Add(() =>
                {
                    update?.Invoke(item,current.Primitive,currentValue.Item,nextValue);
                });
            }

        }


        public static void Update<TItem,TContext, TComponent, TAttribute>(this Attribute<TAttribute> attribute,
            TContext context, IShadow<TItem> item, TComponent current, TComponent next,
            Action<IShadow<TItem>,TComponent,TAttribute> set=default,
            Action<IShadow<TItem>,TComponent,TAttribute,TAttribute> update=default,
            Action<IShadow<TItem>,TComponent,TAttribute> remove=default) where TComponent:BasePrimitive
        {
            TAttribute currentValue = default;
            TAttribute nextValue = default;

            var hasCurrent = current?.Attributes.TryGetAttribute(attribute, out currentValue)??false;
            var hasNext = next?.Attributes.TryGetAttribute(attribute, out nextValue)??false;

            if (hasNext && !hasCurrent)
            {
                Transaction.Current.Add(() =>
                {
                    set?.Invoke(item, next, nextValue);
                });
                ;

                // set operation
                return;
            }

            if (!hasNext && hasCurrent)
            {
                Transaction.Current.Add(() =>
                {
                    remove?.Invoke(item,current,currentValue);
                });

                // clear operation
                return;
            }

            // now need to do an equality comparison
            if (hasCurrent && !attribute.CompareValues(currentValue,nextValue))
            {
                // update
                Transaction.Current.Add(() =>
                {
                    update?.Invoke(item,current,currentValue,nextValue);
                });
            }
        }

        /// <summary>
        /// Attribute update for event handlers
        /// </summary>
        /// <typeparam name="TView"></typeparam>
        /// <typeparam name="TEventAttribute"></typeparam>
        /// <typeparam name="TComponent"></typeparam>
        /// <typeparam name="TContext"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="context"></param>
        /// <param name="shadowView"></param>
        /// <param name="addFunc"></param>
        /// <param name="removeFunc"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        public static void Update<TView,TContext, TComponent, TEventAttribute>(this EventAttribute<Action<TEventAttribute>> attribute,
            TContext context, 
            IShadow<TView> shadowView, 
            Action<TView,EventHandler<TEventAttribute>> addFunc,
            Action<TView,EventHandler<TEventAttribute>> removeFunc,
            TComponent current, 
            TComponent next)
            where TComponent:BasePrimitive
        {
            Action<TEventAttribute> currentValue = default;
            Action<TEventAttribute> nextValue = default;

            // problem here is that the attribute is insufficient to deal with this...
            // i.e. we could have multiple edit controls, the text changed event would have the same id !!!
            // BUT, if we did something with the shadow control, then perhaps that could be used ?

            var stateBagKey = attribute.Id.ToString();

            var hasCurrent = current?.Attributes.TryGetAttribute(attribute, out currentValue)??false;
            var hasNext = next?.Attributes.TryGetAttribute(attribute, out nextValue)??false;

            if (hasNext && !hasCurrent)
            {
                Transaction.Current.Add(() =>
                {
                    EventHandler<TEventAttribute> act = (sender, e) => { nextValue(e); };

                    addFunc(shadowView.Item, act);

                    shadowView.State.Set(stateBagKey,act);
                });
                return;
            }

            if (!hasNext && hasCurrent)
            {
                // clear operation
                Transaction.Current.Add(() => 
                {
                    if (shadowView.State.TryGetValue<EventHandler<TEventAttribute>>(stateBagKey,out var ea))
                    {
                        removeFunc(shadowView.Item, ea);
                    }
                });

                return;
            }

            // now need to do an equality comparison
            if (hasCurrent && !currentValue.Equals(nextValue))
            {
                Transaction.Current.Add(() =>
                {
                    if (shadowView.State.TryGetValue<EventHandler<TEventAttribute>>(stateBagKey,out var ea))
                    {
                        removeFunc(shadowView.Item, ea);
                    }

                    void Act(object sender, TEventAttribute e)
                    {
                        nextValue?.Invoke(e);
                    }

                    addFunc(shadowView.Item, Act);

                    shadowView.State.Set(stateBagKey,(EventHandler<TEventAttribute>) Act);
                });
            }
        }

    }
}