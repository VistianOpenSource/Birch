using Android.Views;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;

namespace Birch.Views
{
    /// <summary>
    /// <see cref="IElement"/> representing a standard <see cref="Android.App.Activity"/>
    /// 
    /// </summary>
    [ShadowMapper(typeof(ShadowMapper))]
    public class Activity : BasePrimitive<Android.App.Activity>
    {
        /// <summary>
        /// The actual activity
        /// </summary>
        public Android.App.Activity TheActivity { get; }

        /// <summary>
        /// The content view 
        /// </summary>
        public IPrimitive ContentView { get; }

        public Activity(Android.App.Activity activity,IPrimitive contentView)
        {
            TheActivity = activity;
            ContentView = contentView;
        }

        [Preserve(AllMembers = true)]
        public class ShadowMapper : BasePrimitiveShadowMapper<AndroidContext,Android.App.Activity,Activity>
        {
            protected override Android.App.Activity CreateItem(AndroidContext context, Activity element)
            {
                return element.TheActivity;
            }

            protected override void Update(AndroidContext context, IShadow<Android.App.Activity> shadow, Activity current, Activity next)
            {
                shadow.UpdateContent<Android.Views.View>(context,current?.ContentView,next?.ContentView, (s) =>
                {
                    shadow.Item.SetContentView(s.Item);
                }, (s) =>
                {
                    shadow.Item.SetContentView(null);
                });
            }
        }
    }
}