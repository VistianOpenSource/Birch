using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Birch.Annotations;
using Birch.Collections;
using Birch.Components;
using Birch.Shadows;
using Birch.Transactions;

namespace Birch.Views
{
    public class ListGroupViewConnector:IDataConnector<ListViewGroupedChild>
    {
        public IShadow<Xamarin.Forms.ListView> Shadow { get; }

        private readonly ObservableCollection<ListGroupChildrenSource> _items;

        public ListGroupViewConnector(IShadow<Xamarin.Forms.ListView> shadow)
        {
            Shadow = shadow;
            // create the backing store ...
            _items = new ObservableCollection<ListGroupChildrenSource>();
            Shadow.Item.ItemsSource = _items;
        }

        public void Insert(int index, ListViewGroupedChild item)
        {
            var newItem = new ListGroupChildrenSource(item.Items.Select(i => new PrimitiveHolder() {Primitive = i}))
            {
                LongName = item.LongName, 
                ShortName = item.ShortName
            };

            Transaction.Current.Add(() =>
            {
                (_items as IList<ListGroupChildrenSource>).SmartInsert(index,newItem);
            });
        }

        public void Move(int oldIndex, int newIndex)
        {
            Transaction.Current.Add(() => _items.Move(oldIndex, newIndex));
        }

        public void Remove(int index, ListViewGroupedChild item)
        {
            Transaction.Current.Add(() => _items.RemoveAt(index));
        }

        public void Update(int index, ListViewGroupedChild current, ListViewGroupedChild next)
        {
            var item = _items[index];

            Transaction.Current.Add(() =>
            {
                Shadow.Item.BatchBegin();
            });
            

            if (current.LongName != next.LongName)
            {
                Transaction.Current.Add(() =>
                {
                    item.LongName = next.LongName;
                });
            }

            if (current.ShortName != next.ShortName)
            {
                Transaction.Current.Add(() =>
                {
                    item.ShortName = next.ShortName;
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

            Transaction.Current.Add(() =>
            {
                Shadow.Item.BatchCommit();
            });
        }
    }
}