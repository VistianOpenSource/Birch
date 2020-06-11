using System;
using System.Collections.Generic;
using System.Text;
using Birch.Collections;
using Birch.Collections.Comparers;
using Birch.Components;
using Birch.Reflection;
using Xamarin.Forms;

namespace Birch.Views
{
    public static class VisualElementExtension
    {
        /// <summary>
        /// Attribute for attaching behaviours to visual elements.
        /// </summary>
        public static Attribute<Behavior[]> BehaviourAttribute = Components.Attribute.Register(Components.Attribute.Name<Xamarin.Forms.VisualElement>(nameof(BehaviourAttribute)),false,ArrayComparer<Behavior>.Default);

        static VisualElementExtension()
        {
            AttributeMapperStore.Default.Register(BehaviourAttribute,
                BehaviourAttribute.Mapper<Behavior[], Xamarin.Forms.VisualElement>(
                    (s, a) =>
                    {
                        foreach (var item in a)
                        {
                            s.Item.Behaviors.Add(item);       
                        }
                    },
                    (s, c, n) =>
                    {
                        var comparer = CollectionComparer<Behavior>.Default();

                        var operations = comparer.Compare(c, n);

                        // and apply them to the list
                        operations.Apply(s.Item.Behaviors);
                    },
                    (s, c) =>
                    {
                        s.Item.Behaviors.Clear();
                    }));
        }
    }

    public partial class Primitives
    {
        public static TControl Behaviours<TControl>(this TControl control, Behavior[] behaviours) where TControl:IReflectedPrimitive<Xamarin.Forms.VisualElement>
        {
            control.Attributes.SetAttribute(VisualElementExtension.BehaviourAttribute, behaviours);
            return control;
        }
    }
}
