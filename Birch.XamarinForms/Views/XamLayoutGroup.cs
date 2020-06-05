using System.Collections.Generic;
using Birch.Collections;
using Birch.Collections.Comparers;
using Birch.Components;
using Birch.Reflection;
using Xamarin.Forms;

namespace Birch.Views
{
    public static class XamLayoutGroup
    {
        public static Attribute<IPrimitive[]> ChildrenAttribute = Components.Attribute.Register(Components.Attribute.Name<Group>(nameof(ChildrenAttribute)),true,ArrayComparer<IPrimitive>.Default);

//        public static Attribute<IGroupedPrimitive[]> GroupedChildrenAttribute = Components.Attribute.Register(Components.Attribute.Name<Group>(nameof(GroupedChildrenAttribute)),true,ArrayComparer<IGroupedPrimitive>.Default);

        public static Attribute<GridItemLayout> GridItemLayoutAttribute = Components.Attribute.Register(Components.Attribute.Name<Group>(nameof(GridItemLayout)),false,EqualityComparer<GridItemLayout>.Default);

        public static Attribute<RowDefinition[]> GridRowDefinitionsAttribute = Components.Attribute.Register(Components.Attribute.Name<Xamarin.Forms.Grid>(nameof(GridRowDefinitionsAttribute)),false,new ArrayComparer<RowDefinition>(RowDefinitionComparer.Default));

        public static Attribute<ColumnDefinition[]> GridColumnDefinitionsAttribute = Components.Attribute.Register(Components.Attribute.Name<Xamarin.Forms.Grid>(nameof(GridColumnDefinitionsAttribute)),false,new ArrayComparer<ColumnDefinition>(ColumnDefinitionComparer.Default));

        public static Attribute<IPrimitive> GroupHeaderAttribute = Components.Attribute.Register(Components.Attribute.Name<Group>(nameof(GroupHeaderAttribute)),true,EqualityComparer<IPrimitive>.Default);

        public static Attribute<IPrimitive> HeaderAttribute = 
            Components.Attribute.Register(Components.Attribute.Name<Group>(nameof(HeaderAttribute)),true,EqualityComparer<IPrimitive>.Default);

        public static Attribute<IPrimitive> FooterAttribute =
            Components.Attribute.Register(Components.Attribute.Name<Group>(nameof(FooterAttribute)),true,EqualityComparer<IPrimitive>.Default);

        static XamLayoutGroup()
        {
            // setup the attribute mappers for ItemLayout...

            AttributeMapperStore.Default.Register(GridItemLayoutAttribute, GridItemLayoutAttribute.Mapper<GridItemLayout, Xamarin.Forms.View>((s, a) =>
            {
                if (a.ColumnSpan != 0)
                {
                    Xamarin.Forms.Grid.SetColumnSpan(s.Item, a.ColumnSpan);
                }

                if (a.RowSpan != 0)
                {
                    Xamarin.Forms.Grid.SetRowSpan(s.Item,a.RowSpan);
                }

                if (a.Row != 0)
                {
                    Xamarin.Forms.Grid.SetRow(s.Item,a.Row);
                }

                if (a.Column != 0)
                {
                    Xamarin.Forms.Grid.SetColumn(s.Item,a.Column);
                }

            },update: (s, c, n) =>
            {
                if (c.ColumnSpan != n.ColumnSpan)
                {
                    Xamarin.Forms.Grid.SetColumnSpan(s.Item, n.ColumnSpan);
                }

                if (c.RowSpan != n.RowSpan)
                {
                    Xamarin.Forms.Grid.SetRowSpan(s.Item,n.RowSpan);
                }

                if (c.Row != n.Row)
                {
                    Xamarin.Forms.Grid.SetRow(s.Item,n.Row);
                }

                if (c.Column != n.Row)
                {
                    Xamarin.Forms.Grid.SetColumn(s.Item,n.Column);
                }

            }));


            AttributeMapperStore.Default.Register(GridColumnDefinitionsAttribute,
                GridColumnDefinitionsAttribute.Mapper<ColumnDefinition[], Xamarin.Forms.Grid>(
                    (s, a) =>
                    {
                        var cdc = new ColumnDefinitionCollection();

                        foreach (var item in a)
                        {
                            cdc.Add(item);
                        }
                        s.Item.ColumnDefinitions = cdc;
                    },
                    (s, c, n) =>
                    {
                        // we need to identify the collection changes and apply them...
                        var md = Birch.Collections.Comparers.Myers.Implementation.Diff(c, n, ColumnDefinitionComparer.Default);

                        // and apply them to the list
                        md.Apply(s.Item.ColumnDefinitions);
                    }));

            AttributeMapperStore.Default.Register(GridRowDefinitionsAttribute, GridRowDefinitionsAttribute.Mapper<RowDefinition[], Xamarin.Forms.Grid>((s, a) =>
                    {
                        var cdc = new RowDefinitionCollection();

                        foreach (var item in a)
                        {
                            cdc.Add(item);
                        }
                        s.Item.RowDefinitions = cdc;
                    },
                    (s, c, n) =>
                    {
                        // we need to identify the collection changes and apply them...
                        var md = Birch.Collections.Comparers.Myers.Implementation.Diff(c, n, RowDefinitionComparer.Default);

                        // and apply them to the list
                        md.Apply(s.Item.RowDefinitions);
                    }));

        }
    }
}