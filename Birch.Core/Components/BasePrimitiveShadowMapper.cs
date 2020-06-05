using System;
using Birch.Compose;
using Birch.Reflection;
using Birch.Shadows;
using Birch.Transactions;

namespace Birch.Components
{
    /// <summary>
    /// Base implementation of <see cref="IShadowMapper"/> providing utility for creation, update and removal of <see cref="Shadow{TItem}"/> instances.
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    /// <typeparam name="TElement"></typeparam>
    [Preserve(AllMembers = true)]
    public abstract class BasePrimitiveShadowMapper<TContext,TItem,TElement> : IShadowMapper  where TItem : class where TElement : BasePrimitive<TItem>  where TContext:IShadowContext 
    {
        protected BasePrimitiveShadowMapper()
        {
        }

        /// <summary>
        /// The shadow is to be created
        /// </summary>
        /// <param name="context"></param>
        /// <param name="viewElement"></param>
        /// <returns></returns>
        /// <remarks>
        /// It is assumed that this is invoked whilst operating under a transaction.
        /// </remarks>
        public IShadow CreateShadow(IShadowContext context, IPrimitive viewElement)
        {
            var shadow =  Create((TContext) context, (TElement) viewElement);

            Transaction.Current.Add(() => OnShadowCreated((TContext)context,(IShadow<TItem>)shadow,(TElement)viewElement));
            return shadow;
        }

        /// <summary>
        /// The shadow is potentially going to be updated
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        public void UpdateShadow(IShadowContext context, IShadow shadow, IPrimitive current,
            IPrimitive next)
        {
            UpdateImplementation((TContext)context,(IShadow<TItem>)shadow,(TElement)current,(TElement)next);
        }

        /// <summary>
        /// The shadow has been removed.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        public void RemoveShadow(IShadowContext context, IShadow shadow, IPrimitive current)
        {
            Remove((TContext)context,(IShadow<TItem>)shadow,(TElement)current);

            OnShadowDestroyed((TContext)context,(IShadow<TItem>)shadow,(TElement)current);

            // and here, we dispose of the shadow
            Transaction.Current.Add(shadow.Dispose);
        }

        /// <summary>
        /// key for state bag within the shadow view used to hold the updated action
        /// </summary>
        private const string UpdatedStateKey = "__frame";

        protected virtual IShadow<TItem> Create(TContext context, TElement initial)
        {
            return Shadow.Create(() => CreateItem(context, initial));
        }

        protected abstract TItem CreateItem(TContext context, TElement element);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="element"></param>
        /// <remarks>
        /// There is an implicit assumption this is being executed under the commit phase of a transaction</remarks>
        protected virtual void Remove(TContext context, IShadow<TItem> shadow,TElement element)
        {
            // the shadow is being removed, we need to do something ...
            // If we have a destroy attribute then we need to invoke that 
            var destroyedAttribute = element.Attributes.GetAttributeOrDefault(StandardAttributes.DestroyedAttribute);

            if (destroyedAttribute != null)
            {
                Transaction.Current.Add(() => destroyedAttribute(element, shadow));
            }
        }


        /// <summary>
        /// Called before any attribute changes and additional code has been executed
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        protected virtual void OnBeforeUpdate(TContext context, IShadow<TItem> shadow, TElement current, TElement next)
        {
        }

        /// <summary>
        /// Called after any attribute changes and additional code has been executed
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        protected virtual void OnAfterUpdate(TContext context, IShadow<TItem> shadow, TElement current, TElement next)
        {
        }


        /// <summary>
        /// Called after a shadow has been first created.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="initialState"></param>
        protected virtual void OnShadowCreated(TContext context, IShadow<TItem> shadow, TElement initialState)
        {
        }

        /// <summary>
        /// Called after a shadow has been destroyed.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="state"></param>
        protected virtual void OnShadowDestroyed(TContext context, IShadow<TItem> shadow, TElement state)
        {
        }

        private void UpdateImplementation(TContext context, IShadow<TItem> shadow, TElement current, TElement next)
        {
            OnBeforeUpdate(context,shadow,current,next);
            
            // let the inherited elements update first 
            var startTransactionsCount = Transaction.Current.Count;

            // perform the main update (!), which allows user code to update...
            Update(context,shadow,current,next);

            // get total number of transactions that occured
            var noTransactions = Transaction.Current.Count - startTransactionsCount;

            var c = ElementValue.From(current, current?.Attributes);
            var n = ElementValue.From(next, next?.Attributes);

            // update those attributes which are defined at 'this level'
            UpdateLocalAttributes(context,shadow,c,n);

            // if have any transactions trigger the callback, if a callback has been defined of course!
            if (noTransactions > 0)
            {
                var action = shadow.State.Get<Action<BasePrimitive, IShadow>>(UpdatedStateKey);

                if (action != null)
                {
                    Transaction.Current.Add(() => { action(current, shadow); });
                }
            }

            // and finally ...
            OnAfterUpdate(context, shadow, current, next);
        }

        /// <summary>
        /// Main update method for shadow handlers.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        protected virtual void Update(TContext context, IShadow<TItem> shadow, TElement current, TElement next)
        {
            // Update Attributes
            UpdateAttributesWithMappings(context,shadow,current,next);
        }
        
        

        /// <summary>
        /// Update our three key attributes.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        private void UpdateLocalAttributes(TContext context, IShadow<TItem> shadow, ElementValue<TElement> current,ElementValue<TElement> next)
        {
            StandardAttributes.CreatedAttribute.Update(current,next,context,shadow, (s, component, createFunc) => { createFunc(component,s); });
            StandardAttributes.RefAttribute.Update(current,next,context,shadow, (s, component, viewRef) => { viewRef.Set(s.Item); });
            StandardAttributes.UpdatedAttribute.Update(current, next, context, shadow, (s, component, action) =>
            {
                s.State.Set<Action<BasePrimitive,IShadow>>(UpdatedStateKey,action);
            }, (s, component, c, n) =>
            {
                s.State.Set<Action<BasePrimitive,IShadow>>(UpdatedStateKey,n);
            },
                (s, component, c) => { s.State.Delete<Action<BasePrimitive,IShadow>>(UpdatedStateKey); });
        }

        /// <summary>
        /// For those attributes which have associated mappings, apply the update using the relevant mapper.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        protected void UpdateAttributesWithMappings(TContext context, IShadow<TItem> shadow,TElement current, TElement next)
        {
            foreach (var attributeId in IPrimitiveExtensions.GetCombinedAttributes(current, next))
            {
                var mapper = AttributeMapperStore.Default.GetMapperFor((int) attributeId);
                var attribute = AttributeStore.Default.GetAttributeForId(attributeId);

                if (mapper != null)
                {
                    attribute.Update(shadow, current, next, mapper);
                }
            }
        }
    }
}