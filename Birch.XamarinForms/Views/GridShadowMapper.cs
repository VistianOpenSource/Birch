using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;

namespace Birch.Views
{
    /// <summary>
    /// Provides a default shadow mapping operation for <see cref="Xamarin.Forms.Grid"/>
    /// </summary>
    public class GridShadowMapper : XamFormsListShadowMapper<Xamarin.Forms.Grid, Grid>
    {
        private class GridConnection:IShadowChildGroup<Xamarin.Forms.View>
        {
            private readonly IShadow<Xamarin.Forms.Grid> _shadow;

            public GridConnection(IShadow<Xamarin.Forms.Grid> shadow)
            {
                _shadow = shadow;
            }

            public void RemoveAt(int index)
            {
                _shadow.Item.Children.RemoveAt(index);
            }

            public void Add(IShadow<Xamarin.Forms.View> childShadow, int index)
            {
                _shadow.Item.Children.SmartInsert(index,childShadow.Item);
            }
        }

        private static IDataConnector<IPrimitive> ConnectorFactory(IShadowContext context,IShadow<Xamarin.Forms.Grid> shadow)
        {
            return new ShadowGroupConnector<Xamarin.Forms.View>(context, new GridConnection(shadow));
        }
        public GridShadowMapper() : base(ConnectorFactory)
        {
        }
    }
}