using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Xamarin.Forms;

namespace Birch.Views
{
    /// <summary>
    /// Base replace class for <see cref="Xamarin.Forms.ContentPage"/>
    /// </summary>
    public abstract class BaseContentPage:BaseContentPage<Unit>
    {
        public override Unit InitState()
        {
            return Unit.Default;
        }
        protected override IPrimitive PerformLayout(LayoutContext layoutContext, Unit model) => this.PerformLayout(layoutContext);

        protected abstract IPrimitive PerformLayout(LayoutContext layoutContext);
    }
}
