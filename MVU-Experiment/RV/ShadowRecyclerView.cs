using Android.Support.V7.Widget;
using Birch;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;
using Birch.Views;

namespace MVU_Experiment.RV
{
    // takes an IBackingDataStore and , observes the changed and actts upon to to drive an update to the appropriate 
    // visual
    // so for an rv it would , create the adapter - suspect this would need to be stored in the shadow state


    [ShadowMapper(typeof(RecyclerViewShadowMapper))]
    [Preserve(AllMembers = true)]
    public class ShadowRecyclerView:AndroidViewGroup<RecyclerView>
    {
        
        public ShadowRecyclerView():base((dimensions) => new RecyclerView.LayoutParams(dimensions.Width,dimensions.Height))
        {
            if (Birch.Components.Primitives.NeverInclude)
            {
                var rv = new RecyclerView(null);
            }
        }
    }

    [Preserve(AllMembers = true)]
    public class RecyclerViewShadowMapper:AndroidViewGroupShadowMapper<RecyclerView> 
    {
        protected override IShadow<RecyclerView> Create(AndroidContext context, AndroidViewGroup<RecyclerView> initial)
        {
            var shadow = (Shadow<RecyclerView>)base.Create(context, initial);

            // and now setup the data connection
            var rvac = new RecyclerViewAdapterConnector(context);
            var collectionComparer = initial.Attributes.GetAttributeOrDefault(Group.ComparerAttribute);

            var dataH = new BackingStoreUpdateHandler<AndroidContext,RecyclerView,IPrimitive>(rvac,Group.ChildrenAttribute,collectionComparer);

            this.SetChildrenAdapter(context,shadow,dataH);

            Transaction.Current.Add(() =>
            {
                // and set the adapter in the recycler view
                shadow.Item.SetAdapter(rvac.Adapter);
            });

            return shadow;
        }

        protected override void Remove(AndroidContext context, IShadow<RecyclerView> shadow, AndroidViewGroup<RecyclerView> current)
        {
            base.Remove(context, shadow, current);

            // clear down the recycler view adapter
            shadow.Item.SetAdapter(null);
        }
    }


    public class SampleUsage
    {
        // 1. we want to be able to use reflection over all of the properties
        // 2. we have two options: 1. fixed list updated through attributes
        //                          2. observable/builder in which updates come in a different way
        // 3. 2 is probably just a 'short cut' for one, with a 'secret' model
        // for now, going with the 'secret' model which forces an update of the underlying recycler view
        // seems most appropriate, since this then allows for updates to the items which have been brought in
        // BUT, if it has its own state, then it needs to be a stateful container....
        // If static list, we have this one covered already
        // its just the "builder" route , but we have a 'hidden' 
        //  

        // so, against the RV, since its the only stateful location we have, we store the subscription
        // 1. an observed IViewComponent2 appears
        // 2. this is 'added' to a backing store
        // 3. this would be the 'same' backing store as we have for non builder approaches ?
        // 4. the UI is updated in some way - either directly, or , not...
        // 5. it could shortcut going through the normal channels of element updates and just going directly to the adapter related code , esp since
        // will be in the UI ? the 'standard' update elements collection uses a ... 
    }


    //ItemsAttribute.UpdateElementCollection(context, view, viewElement, nextElement,
    //(i, ve) =>
    //{
    //var adapter = (NewRvAdapter)view.View.GetAdapter();
    //adapter.Insert(i, ve);
    //adapter.NotifyItemRangeInserted(i, 1);

    //}, (i, ve) =>
    //{
    //var adapter = (NewRvAdapter)view.View.GetAdapter();
    //adapter.RemoveAt(i);
    //adapter.NotifyItemRangeRemoved(i, 1);
    //}, (f, t) =>
    //{
    //// need to move the item...
    ////adapter.Elements.

    //var adapter = (NewRvAdapter)view.View.GetAdapter();
    //adapter.NotifyItemMoved(f, t);
    //}, (i, ov, nv) =>
    //{
    //var adapter = (NewRvAdapter)view.View.GetAdapter();
    //adapter.Update(i, nv);
    //adapter.NotifyItemChanged(i);
    //});
}