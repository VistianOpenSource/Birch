using System;
using System.Collections.Generic;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Shadows;
using Microsoft.Extensions.Logging;
using Xamarin.Forms;

namespace Birch.Views
{
    /// <summary>
    /// <see cref="DataTemplateSelector"/> implementation for <see cref="IPrimitive"/> instances.
    /// </summary>
    public class PrimitiveDataTemplateSelector : DataTemplateSelector
    {
        private readonly XamFormsContext _context;

        /// <summary>
        /// Limit to size of the cache
        /// </summary>
        private readonly int _cacheSizeLimit;

        private readonly Func<IShadow<BindableObject>, PrimitiveHolder> _bindingSelector;

        private readonly Func<object, IPrimitive> _primitiveSelector;

        /// <summary>
        /// our cache of previously looked up <see cref="PrimitiveDataTemplate"/>
        /// </summary>
        private static readonly Dictionary<(string,Type),PrimitiveDataTemplate> TemplateCache = new Dictionary<(string,Type), PrimitiveDataTemplate>();

        public PrimitiveDataTemplateSelector(XamFormsContext context,Func<IShadow<BindableObject>,PrimitiveHolder> bindingSelector,int cacheSizeLimit=0,Func<object,IPrimitive> primitiveSelector=default)
        {
            _context = context;
            _cacheSizeLimit = cacheSizeLimit;
            _bindingSelector = bindingSelector ?? throw new ArgumentNullException(nameof(bindingSelector));
            _primitiveSelector = primitiveSelector??(o => ((PrimitiveHolder)o).Primitive);
        }

        /// <summary>
        /// Determine the <see cref="DataTemplate"/> to be used for a specified <see cref="PrimitiveHolder"/>
        /// </summary>
        /// <param name="item"></param>
        /// <param name="container"></param>
        /// <returns></returns>
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var primitive = _primitiveSelector(item);

            // see if we have cached this item
            var targetKey = primitive.TargetKey();
            if (!TemplateCache.TryGetValue((targetKey,_bindingSelector.GetType()), out var template))
            {
                // do a target platform check for android & ListView limits
                if (_cacheSizeLimit > 0 && _cacheSizeLimit <= TemplateCache.Count+1)
                {
                    Logging.Instance.LogWarning("Template cache size exceeded limit:{limit} current:{current}.",_cacheSizeLimit,TemplateCache.Count);
                }

                template = new PrimitiveDataTemplate(_context,primitive,_bindingSelector);

                TemplateCache[(targetKey,_bindingSelector.GetType())] = template;
            }

            return template;
        }
    }
}