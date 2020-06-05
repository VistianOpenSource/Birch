using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Birch.Annotations;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Reflection;
using Birch.Shadows;
using Birch.Transactions;

namespace Birch.Views
{
    [ShadowMapper(typeof(ShadowMapper))]
    public class ListView : XamFormsVisualElement<Xamarin.Forms.ListView>
    {
        public ListView(IReflectedPrimitive<Xamarin.Forms.Cell>[] children):base()
        {
            // ReSharper disable once CoVariantArrayConversion
            this.Attributes.SetAttribute(XamLayoutGroup.ChildrenAttribute, children);
        }

    /// <summary>
    /// Shadow mapper for <see cref="ListView"/>
    /// </summary>
    public class ShadowMapper : XamFormsListShadowMapper<Xamarin.Forms.ListView, ListView>
    {
        private class ListViewConnector:IDataConnector<IPrimitive>
        {
            private readonly ObservableCollection<PrimitiveHolder> _items;

            public ListViewConnector(IShadow<Xamarin.Forms.ListView> shadow)
            {
                // create the backing store ...
                _items = new ObservableCollection<PrimitiveHolder>();
                shadow.Item.ItemsSource = _items;
            }

            public void Insert(int index, IPrimitive item)
            {
                Transaction.Current.Add(() =>
                {
                    _items.SmartInsert(index,new PrimitiveHolder() {Primitive = item});
                });
            }

            public void Move(int oldIndex, int newIndex)
            {
                Transaction.Current.Add(() => _items.Move(oldIndex, newIndex));
            }

            public void Remove(int index, IPrimitive item)
            {
                Transaction.Current.Add(() => _items.RemoveAt(index));
            }

            public void Update(int index, IPrimitive current, IPrimitive next)
            {
                Transaction.Current.Add(() => _items[index].Primitive = next);
            }
        }

        private static IDataConnector<IPrimitive> ConnectorFactory(XamFormsContext context,IShadow<Xamarin.Forms.ListView> s) => new ListViewConnector(s);

        public ShadowMapper() : base(ConnectorFactory) { }

        protected override IShadow<Xamarin.Forms.ListView> Create(XamFormsContext context, ListView initial)
        {
            var shadow = base.Create(context, initial);

            shadow.Item.ItemTemplate = new PrimitiveDataTemplateSelector(context, (o) => (o.Item?.BindingContext as PrimitiveHolder));
            return shadow;
        }
    }

    }
   
}