using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Object = Java.Lang.Object;

namespace MVU_Experiment.RV
{
        public class ShadowRecyclerViewAdapter:RecyclerView.Adapter
    {
        /// <summary>
        /// The associated context
        /// </summary>
        private readonly AndroidContext _context;

        /// <summary>
        /// The list of data providing backing for the recycler view.
        /// </summary>
        private readonly List<PrimitiveShadowPair> _items = new List<PrimitiveShadowPair>();

        /// <summary>
        /// Given a view type (an integer) get the associated element
        /// </summary>
        private readonly Dictionary<int,PrimitiveShadowPair> _viewTypeItemMap = new Dictionary<int, PrimitiveShadowPair>();

        public ShadowRecyclerViewAdapter(AndroidContext context)
        {
            _context = context;
        }

        public void Add(IPrimitive component)
        {
            Insert(_items.Count,component);
        }

        public void Insert(int position, IPrimitive component)
        {
            var item = PrimitiveShadowPair.Create(component);

            if (position == _items.Count)
            {
                _items.Add(item);
            }
            else
            {
                _items.Insert(position,item);    
            }
            
            _viewTypeItemMap[item.ViewType] = item;
            NotifyItemInserted(position);
        }

        public void Remove(int index)
        {
            var item = _items[index];

            _items.RemoveAt(index);
            _viewTypeItemMap.Remove(item.ViewType);

            NotifyItemRemoved(index);
        }

        public void Move(int fromIndex, int toIndex)
        {
            var item = _items[fromIndex];
            if (toIndex == _items.Count)
            {
                _items.Add(item);
            }
            else
            {
                _items.Insert(toIndex, item);
            }

            NotifyItemMoved(fromIndex,toIndex);
        }

        public void Update(int position, IPrimitive current,IPrimitive next)
        {
            var item = _items[position];

            item.Update(_context,next);
        }

        public override int ItemCount => _items.Count;

        /// <summary>
        /// The view holder is being bound to the view at the specified position.
        /// </summary>
        /// <param name="holder"></param>
        /// <param name="position"></param>
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var actualViewHolder = (ShadowViewHolder)holder;

            var item = _items[position];

            item.Bind(actualViewHolder.ItemView,_context);
        }


        /// <summary>
        /// The view has been detached.
        /// </summary>
        /// <param name="holder"></param>
        /// <remarks>
        /// The view detaching means that, due to us marking it as not recycling in the viewholder, it should now be unbound.</remarks>
        public override void OnViewDetachedFromWindow(Object holder)
        {
            base.OnViewDetachedFromWindow(holder);

            var viewHolder = (ShadowViewHolder)holder;

            if (viewHolder.AdapterPosition >= 0 && viewHolder.AdapterPosition < _items.Count)
            {
                var item = _items[viewHolder.AdapterPosition];
                // now need to 'detach' the view from the shadow so this ensures that all the relevant events etc are 'released'
                // BUT, an important but, 

                item.UnBind(_context);
            }
        }

        /// <summary>
        /// On View being recycled we unbind.
        /// </summary>
        /// <param name="holder"></param>
        ///<remarks>
        /// This code SHOULD NOT be used anymore. To allow for Create and Destroy events instead the view holder is marked as
        /// not allowing recycling to occur.
        /// We could allow for recycling, but this means that create and destroy events wouldn't occur when expected.
        /// </remarks>
        public override void OnViewRecycled(Object holder)
        {
            base.OnViewRecycled(holder);

            var viewHolder = (ShadowViewHolder)holder;

            if (viewHolder.AdapterPosition >= 0 && viewHolder.AdapterPosition < _items.Count)
            {
                var item = _items[viewHolder.AdapterPosition];
                // now need to 'detach' the view from the shadow so this ensures that all the relevant events etc are 'released'
                // BUT, an important but, 

                item.UnBind(_context);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(Android.Views.ViewGroup parent, int viewType)
        {
            // create the view - given the view type we need to...
            var item = _viewTypeItemMap[viewType];

            // and create
            item.Create(_context);
            
            // and finally return the shadow view holder
            return new ShadowViewHolder(item.Shadow);
        }

        /// <summary>
        /// Get the view type for a specified position
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public override int GetItemViewType(int position)
        {
            return _items[position].ViewType;
        }
    }
}