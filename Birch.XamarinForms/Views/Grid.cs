using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Xamarin.Forms;

namespace Birch.Views
{
    [ShadowMapper(typeof(GridShadowMapper))]
    public class Grid : XamFormsVisualElement<Xamarin.Forms.Grid>
    {
        public static Attribute<IPrimitive[]> ChildrenAttribute = Components.Attribute.Register(Components.Attribute.Name<Group>(nameof(ChildrenAttribute)),true,ArrayComparer<IPrimitive>.Default);

        public Grid(IPrimitive[] children,RowDefinition[] rowDefinitionCollection,ColumnDefinition[] columnDefinitionCollection):base()
        {
            // we need to set a child attribute for it
            this.Attributes.SetAttribute(XamLayoutGroup.ChildrenAttribute, children);
            this.Attributes.SetAttribute(XamLayoutGroup.GridRowDefinitionsAttribute, rowDefinitionCollection);
            this.Attributes.SetAttribute(XamLayoutGroup.GridColumnDefinitionsAttribute, columnDefinitionCollection);
        }
    }
}