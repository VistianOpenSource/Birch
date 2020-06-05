using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Birch.Compose;
using Birch.Metrics;

namespace Birch.Components
{
    /// <summary>
    /// Collection of extension methods for <see cref="IElement"/>
    /// </summary>
    public static class  IElementExtensions
    {
        /// <summary>
        /// Determine if an <see cref="IElement"/> is a stateful container or not.
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public static bool IsStateful(this IElement component)
        {
            return component is IStatefulContainer;
        }

        /// <summary>
        /// Perform the layout of an <see cref="IElement"/>
        /// </summary>
        /// <param name="element"></param>
        /// <param name="layoutContext"></param>
        /// <returns></returns>
        /// <remarks>
        /// If the element is a <see cref="IComposite"/> then the <see cref="LayoutResolver"/> is used
        /// to determine the relevant implementation for performing the layout and then executes it.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IPrimitive Layout(this IElement element,LayoutContext layoutContext)
        {
            // record this layout 
            LayoutMetrics.Record(element);

            try
            {
                if (element is IComposite)
                {
                    return layoutContext.LayoutResolver.Layout(element, layoutContext);
                }
                else
                {
                    return (IPrimitive) element;
                }
            }
            finally
            {
                LayoutMetrics.Complete();                
            }
        }

        /// <summary>
        /// Perform the layout of an array of <see cref="IElement"/>
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="layoutContext"></param>
        /// <returns></returns>
        public static IPrimitive[] Layout(this IElement[] elements, LayoutContext layoutContext)
        {
            var output = new IPrimitive[elements.Length];

            for(var index = 0;index < elements.Length;index++)
            {
                output[index] = elements[index].Layout(layoutContext);
            }

            return output;
        }

        /// <summary>
        /// Perform the layout of a <see cref="IList{Element}"/>
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="layoutContext"></param>
        /// <returns></returns>
        public static IPrimitive[] Layout(this IList<IElement> elements, LayoutContext layoutContext)
        {
            var count = elements.Count;
            var output = new IPrimitive[count];

            for(var index = 0;index < count;index++)
            {
                output[index] = elements[index].Layout(layoutContext);
            }

            return output;
        }

        /// <summary>
        /// Perform the layout for an <see cref="IEnumerable{IElement}"/>
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="layoutContext"></param>
        /// <returns></returns>
        public static IPrimitive[] Layout(this IEnumerable<IElement> elements, LayoutContext layoutContext)
        {
            return elements.Select<IElement, IPrimitive>(vc => vc.Layout(layoutContext)).ToArray();
        }

        /// <summary>
        /// Determine if two <see cref="IElement"/> instances are of the same type
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool AreSameType(this IElement x, IElement y)
        {
            if (x == null && y == null) return true;

            if (x == null || y == null) return false;

            return x.GetType() == y.GetType();
        }

    }
}