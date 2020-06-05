using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Shadows;
using Birch.Transactions;

namespace Birch.Compose
{
    public static class IShadowExtensions
    {
        private const string ContentKey = nameof(IShadowExtensions) + ".Content";

        /// <summary>
        /// Simple extension to assign / update a <see cref="IShadow{TItem}"/> when it has content within it, with 
        /// updates being automatically wrapped in a <see cref="Transaction"/>
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        /// <param name="set"></param>
        /// <param name="clear"></param>
        public static void UpdateContent<TItem>(this IShadow shadow,IShadowContext context, IPrimitive current,
            IPrimitive next,
            Action<IShadow<TItem>> set,
            Action<IShadow<TItem>> clear)
        {
            var content = shadow.Get<IShadow<TItem>>(ContentKey);

            Shadow.Update(context, current, next, content, (s) =>
            {
                Transaction.Current.Add(() =>
                {
                    shadow.Set<IShadow<TItem>>(ContentKey, s);
                    set(s);
                });
            }, (s) =>
            {
                Transaction.Current.Add(() =>
                {
                    shadow.State.Delete<IShadow<TItem>>(ContentKey);
                    clear(s);
                });
            });

        }

    }
}
