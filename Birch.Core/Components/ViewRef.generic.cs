using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Components
{
    /// <summary>
    /// Main generic implementation for a <see cref="ViewRef"/>
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    /// <remarks>
    /// Typically used in code whereby access is required to the underlying UI component, e.g. performs for some animation.</remarks>
    public class ViewRef<TView>:ViewRef where TView : class
    {
        private WeakReference<TView> _view;

        public bool TryGetValue(out TView view) => _view.TryGetTarget(out view);

        public override void Set(object value)
        {
            Set((TView)value);
        }

        public void Set(TView view)
        {
            if (_view == null)
            {
                _view = new WeakReference<TView>(view);
            }
            else
            {
                _view.SetTarget(view);                
            }
        }
    }
}
