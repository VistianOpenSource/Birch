using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Linq;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Xamarin.Forms.PlatformConfiguration;
using Attribute = System.Attribute;

namespace Birch.Views
{
    [ShadowMapper(typeof(ShadowMapper))]
    public class StackLayout : XamFormsVisualElement<Xamarin.Forms.StackLayout>
    {
        public StackLayout(IPrimitive[] children):base()
        {
            // we need to set a child attribute for it
            this.Attributes.SetAttribute(XamLayoutGroup.ChildrenAttribute, children);
        }
    }


    /// <summary>
    /// Provides a default shadow mapping operation for <see cref="StackLayout"/>
    /// </summary>
    public class ShadowMapper:XamFormsListShadowMapper<Xamarin.Forms.StackLayout, StackLayout>
    {
        private class StackLayoutConnection:IShadowChildGroup<Xamarin.Forms.View>
        {
            private readonly IShadow<Xamarin.Forms.StackLayout> _shadow;

            public StackLayoutConnection(IShadow<Xamarin.Forms.StackLayout> shadow)
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


        public ShadowMapper() : base(ConnectorFactory)
        {
        }

        private static IDataConnector<IPrimitive> ConnectorFactory(IShadowContext context,IShadow<Xamarin.Forms.StackLayout> shadow)
        {
            return new ShadowGroupConnector<Xamarin.Forms.View>(context, new StackLayoutConnection(shadow));
        }
    }

}
