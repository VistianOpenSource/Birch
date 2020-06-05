using System;
using System.Collections.Generic;
using Birch.Components;
using Birch.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Birch.Compose
{
    /// <summary>
    /// Registers and resolves <see cref="ILayoutProvider"/> instances for <see cref="IElement"/> 
    /// </summary>
    public class LayoutResolver
    {
        /// <summary>
        /// Our dictionary of layout providers.
        /// </summary>
        private readonly Dictionary<Type,Func<LayoutContext,IElement,IPrimitive>> _layoutProviders = new Dictionary<Type, Func<LayoutContext,IElement,IPrimitive>>();

        /// <summary>
        /// Register a function that will ultimately perform the layout for <see cref="TComposite"/> 
        /// </summary>
        /// <typeparam name="TComposite"></typeparam>
        /// <param name="func"></param>
        public void Register<TComposite>(Func<LayoutContext,TComposite, IPrimitive> func) where TComposite:IComposite
        {
            _layoutProviders[typeof(TComposite)] = (context,composite) => func(context,(TComposite)composite);
        }

        /// <summary>
        /// Register a <see cref="ILayoutProvider"/> for <see cref="TComposite"/>
        /// </summary>
        /// <typeparam name="TComposite"></typeparam>
        /// <param name="layoutProvider"></param>
        public void Register<TComposite>(ILayoutProvider layoutProvider)
        {
            _layoutProviders[typeof(TComposite)] = layoutProvider.PerformLayout;
        }

        /// <summary>
        /// Layout a <see cref="IElement"/>
        /// </summary>
        /// <param name="element"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public IPrimitive Layout(IElement element,LayoutContext context)
        {
            //have we seen the type of the element before ?
            if (_layoutProviders.Count > 0 && _layoutProviders.TryGetValue(element.GetType(), out var func))
            {
                return func(context,element);
            }

            // this type hasn't been seen before, lets look to see if we can find it 
            var method = element.GetType().GetMethod(nameof(IInlineComposite.PerformLayout));

            if (method == null)
            {
                Logging.Instance.LogError("No Layout resolver for {type}.  Either register a layout resolver when you create your HostEnvironment or implement the IInlineComposite interface on {type}",element.GetType(),element.GetType());
                throw new ArgumentException($"No layout resolver for {element.GetType()}.");
            }

            func = (layoutContext, e) =>
            {
                try
                {
                    return (IPrimitive) method.Invoke(e, new object[] {layoutContext});
                }
                catch (Exception exception)
                {
                    Logging.Instance.LogError(exception,"Layout method execution failure for {type}" ,element.GetType());

                    throw new InvalidOperationException($"Layout method execution failure for {element.GetType()}. See the inner exception for more details.",exception);
                }
            };
            // store the layout provider away
            _layoutProviders[element.GetType()] = func;

            // and call it to get the result
            return func(context, element);
        }
    }
}