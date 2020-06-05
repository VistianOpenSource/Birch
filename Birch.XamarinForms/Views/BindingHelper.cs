using System;
using System.ComponentModel;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;
using Xamarin.Forms;

namespace Birch.Views
{
    public class BindingHelper:IDisposable
    {
        private readonly XamFormsContext _context;
        private readonly IShadow<BindableObject> _shadow;
        private readonly Func<IShadow<BindableObject>, PrimitiveHolder> _primitiveSelector;
        private PrimitiveHolder _primitiveHolder;

        private IPrimitive _current;

        public BindingHelper(XamFormsContext context, IShadow<BindableObject> shadow,Func<IShadow<BindableObject>,PrimitiveHolder> primitiveSelector)
        {
            _context = context;
            _shadow = shadow;
            _primitiveSelector = primitiveSelector;
        }

        public static BindingHelper Create(XamFormsContext context, IShadow<BindableObject> shadow,Func<IShadow<BindableObject>,PrimitiveHolder> primitiveSelector=default)
        {
            var bh = new BindingHelper(context,shadow,primitiveSelector??((b) => b.Item?.BindingContext as PrimitiveHolder));

            bh.MonitorBindingContextChanged();

            return bh;
        }

        // kick off the binding context monitoring...
        private void MonitorBindingContextChanged()
        {
            _shadow.Item.BindingContextChanged += Item_BindingContextChanged;
        }


        private void Item_BindingContextChanged(object sender, EventArgs e)
        {
            OnBindingChanged();
        }

        /// <summary>
        /// Dispose by getting rid of the change monitor.
        /// </summary>
        public void Dispose()
        {
            _shadow.Item.BindingContextChanged -= Item_BindingContextChanged;
        }

        public void OnBindingChanged()
        {
            if (_primitiveHolder != null )
            {
                _primitiveHolder.PropertyChanged -= NewHolderOnPropertyChanged;

                if (_current != null)
                {
                    //using var transaction = Transaction.Create(isolated: true);
                    //_context.Factory.Remove(_context, _shadow, _current);
                    //transaction.Commit();
                }
            }

            var newHolder = _primitiveSelector(_shadow) as PrimitiveHolder;

            var bc = _shadow.Item.BindingContext;

            if (newHolder == null)
            {

            }
            if (newHolder != null)
            {
                newHolder.PropertyChanged += NewHolderOnPropertyChanged;

                // now need to perform an update

                using var transaction = Transaction.Create(isolated:true);

                _context.MapperFactory.Update(_context,_shadow, _current,newHolder.Primitive);

                transaction.Commit();

                _current = newHolder.Primitive;

                _primitiveHolder = newHolder;
            }
            else
            {
                if (_current != null)
                {
                //    using var transaction = Transaction.Create(isolated: true);
                //    _context.Factory.Remove(_context, _shadow, _current);
                //    transaction.Commit();
                //    _current = null;
                }

                _primitiveHolder = null;
            }

        }

        private void NewHolderOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            using var transaction = Transaction.Create(isolated: true);
            _context.MapperFactory.Update(_context,_shadow,_current,_primitiveHolder.Primitive);
            transaction.Commit();

            _current = _primitiveHolder.Primitive;
        }
    }
}