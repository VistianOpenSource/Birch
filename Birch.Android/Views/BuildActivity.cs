using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Birch.Components;
using Birch.Compose;

namespace Birch.Views
{
    /// <summary>
    /// Activity for build hosts in which there is effectively no stateful root container.
    /// </summary>
    [Preserve(AllMembers = true)]
    public abstract class BuildActivity : BuildActivity<Unit>
    {
        public override Unit InitState()
        {
            return Unit.Default;
        }
        protected override IPrimitive PerformLayout(LayoutContext layoutContext, Unit model) => this.PerformLayout(layoutContext);

        protected abstract IPrimitive PerformLayout(LayoutContext layoutContext);
    }
}