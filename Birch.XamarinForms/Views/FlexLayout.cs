using System;
using System.Collections.Generic;
using System.Text;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Attribute = Birch.Components.Attribute;

namespace Birch.Views
{
    [ShadowMapper(typeof(ShadowMapper))]
    public class FlexLayout : XamFormsVisualElement<Xamarin.Forms.FlexLayout>
    {
        public FlexLayout(IPrimitive[] children):base()
        {
            // we need to set a child attribute for it
            this.Attributes.SetAttribute(XamLayoutGroup.ChildrenAttribute, children);
        }

        /// <summary>
        /// Provides a default shadow mapping operation for <see cref="FlexLayout"/>
        /// </summary>
        public class ShadowMapper : XamFormsListShadowMapper<Xamarin.Forms.FlexLayout,Birch.Views.FlexLayout>
        {
            private class FlexLayoutConnection:IShadowChildGroup<Xamarin.Forms.View>
            {
                private readonly IShadow<Xamarin.Forms.FlexLayout> _shadow;

                public FlexLayoutConnection(IShadow<Xamarin.Forms.FlexLayout> shadow)
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


            private static IDataConnector<IPrimitive> ConnectorFactory(XamFormsContext context,
                IShadow<Xamarin.Forms.FlexLayout> shadow)
            {
                return new ShadowGroupConnector<Xamarin.Forms.View>(context,new FlexLayoutConnection(shadow));
            }
            public ShadowMapper() : base(ConnectorFactory)
            {
            }


        }

    }
}
