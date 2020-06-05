using System;
using System.Runtime.CompilerServices;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;
using Xamarin.Forms;

namespace Birch.Views
{
    /// <summary>
    /// Our <see cref="IPrimitive"/> <see cref="DataTemplate"/>
    /// </summary>
    public class PrimitiveDataTemplate:DataTemplate
    {
        public PrimitiveDataTemplate(XamFormsContext context, IPrimitive primitive,Func<IShadow<BindableObject>,PrimitiveHolder> selector) : base(() =>
        {
            // create view
            using var transaction = Transaction.Create(isolated: true);
            var shadow = (IShadow<BindableObject>) context.MapperFactory.Create(context, primitive,false);
            transaction.Commit();

            // setup binding class to track changes to the binding context and update things automatically.
            var bindingHelper = BindingHelper.Create(context,shadow,selector);

            // store the binding helper with the shadow
            shadow.State.Set(bindingHelper);

            return shadow.Item;
        })
        {
        }
    }
}
