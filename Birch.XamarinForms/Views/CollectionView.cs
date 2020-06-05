using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;
using Xamarin.Forms;

namespace Birch.Views
{
    [ShadowMapper(typeof(ShadowMapper))]
    public class CollectionView : XamFormsVisualElement<Xamarin.Forms.CollectionView>
    {
        public CollectionView(IPrimitive[] children):base()
        {
            this.Attributes.SetAttribute(XamLayoutGroup.ChildrenAttribute, children);
        }


        /// <summary>
        /// Shadow mapper for <see cref="Xamarin.Forms.CollectionView"/>
        /// </summary>
        public class ShadowMapper:XamFormsListShadowMapper<Xamarin.Forms.CollectionView, CollectionView>
        {
            internal class CollectionViewConnector:IDataConnector<IPrimitive>
            {
                public IShadow<Xamarin.Forms.CollectionView> Shadow { get; }

                private readonly ObservableCollection<PrimitiveHolder> _items;

                public CollectionViewConnector(IShadow<Xamarin.Forms.CollectionView> shadow)
                {
                    Shadow = shadow;
                    // create the backing store ...
                    _items = new ObservableCollection<PrimitiveHolder>();
                    Shadow.Item.ItemsSource = _items;
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

            private static IDataConnector<IPrimitive> ConnectorFactory(IShadowContext context,IShadow<Xamarin.Forms.CollectionView> shadow)
            {
                return new CollectionViewConnector(shadow);
            }
            public ShadowMapper() : base(ConnectorFactory)
            {
            }

            protected override Xamarin.Forms.CollectionView CreateItem(XamFormsContext context, CollectionView element)
            {
                var control = base.CreateItem(context, element);

                control.ItemTemplate = new PrimitiveDataTemplateSelector(context,bindingSelector:(o) => (o.Item?.BindingContext as PrimitiveHolder));
                
                return control;
            }
        }
    }

}
