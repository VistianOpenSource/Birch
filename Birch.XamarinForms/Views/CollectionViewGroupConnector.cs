using System.Collections.ObjectModel;
using System.Linq;
using Birch.Collections;
using Birch.Components;
using Birch.Shadows;
using Birch.Transactions;

namespace Birch.Views
{
    public class CollectionViewGroupConnector:IDataConnector<CollectionViewGroupedChild>
    {
        public IShadow<Xamarin.Forms.CollectionView> Shadow { get; }

        private readonly ObservableCollection<CollectionViewGroupSource> _items;

        public CollectionViewGroupConnector(IShadow<Xamarin.Forms.CollectionView> shadow)
        {
            Shadow = shadow;
            // create the backing store ...
            _items = new ObservableCollection<CollectionViewGroupSource>();
            Shadow.Item.ItemsSource = _items;
        }

        public void Insert(int index, CollectionViewGroupedChild item)
        {
            var newItem = new CollectionViewGroupSource(item.Items.Select(i => new PrimitiveHolder() {Primitive = i}))
            {
                GroupHeader = item.Header
            };

            Transaction.Current.Add(() =>
            {
                _items.SmartInsert(index,newItem);
            });
        }

        public void Move(int oldIndex, int newIndex)
        {
            Transaction.Current.Add(() => _items.Move(oldIndex, newIndex));
        }

        public void Remove(int index, CollectionViewGroupedChild item)
        {
            Transaction.Current.Add(() => _items.RemoveAt(index));
        }

        public void Update(int index, CollectionViewGroupedChild current, CollectionViewGroupedChild next)
        {
            var item = _items[index];

            if (!current.Header.Equals(next.Header))
            {
                Transaction.Current.Add(() =>
                {
                    item.GroupHeader = next.Header;
                });
            }

            // we need to issue a collection of updates to the backing list , not just a global replace ...
            // and this needs to run through the standard transactional approach
            var comparer = new MyerComparer<IPrimitive>();

            comparer.Compare(current.Items, next.Items, 
                (i, p) =>
                {
                    Transaction.Current.Add(() =>
                    {
                        item.SmartInsert(i,new PrimitiveHolder() { Primitive = p });
                    });
                },
                (i,p) =>
                {
                    Transaction.Current.Add(() => { item.RemoveAt(i);

                    });
                    ;    
                },
                (f, t, p) =>
                {
                    Transaction.Current.Add(() =>
                    {
                        item.Move(f,t);
                    });
                },
                (i, c, n) =>
                {
                    Transaction.Current.Add(() =>
                    {
                        item[i].Primitive = n;
                    });
                }
            );
        }
    }
}