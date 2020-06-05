using System.Collections.Generic;
using System.Linq;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Birch.Collections;
using Birch.Components;
using Birch.Reflection;
using Java.Util;
using Java.Util.Functions;

namespace Birch.Views
{
    /// <summary>
    /// Extensions to provide for additional facilities that a <see cref="Android.Widget.RelativeLayout"/> has
    /// </summary>
    public static class RelativeLayoutExtensions
    {
        public static Attribute<Dictionary<LayoutRules,LayoutRule>> LayoutRulesAttribute = Attribute.Register(Attribute.Name<Android.Widget.RelativeLayout>("RelativeLayout.LayoutParams.Rules"),false,DictionaryComparer<LayoutRules,LayoutRule>.Default);
        public static Attribute<bool> AlignWithParentAttribute = Attribute.Register<bool>(Attribute.Name<Android.Widget.RelativeLayout>("RelativeLayout.LayoutParams.AlignWithParent"));

        static RelativeLayoutExtensions()
        {
            // apply a layout rule
            static void ApplyRule(Android.Widget.RelativeLayout.LayoutParams lp, LayoutRule rule)
            {
                if (rule.Subject.HasValue)
                {
                    lp.AddRule(rule,rule.Subject.Value);
                }
                else
                {
                    lp.AddRule(rule);                                
                }
            }

            // remove a layout rule
            static void RemoveRule(Android.Widget.RelativeLayout.LayoutParams lp, LayoutRule rule)
            {
                lp.RemoveRule(rule.Verb);
            }

            AttributeMapperStore.Default.Register(LayoutRulesAttribute,
                LayoutRulesAttribute.Mapper<Dictionary<LayoutRules,LayoutRule>,Android.Views.View>((s, a) =>
                {
                    if (s.Item.LayoutParameters is Android.Widget.RelativeLayout.LayoutParams lp)
                    {
                        foreach (var layoutRule in a.Values)
                        {
                            ApplyRule(lp,layoutRule);
                        }
                    }
                },update: (s, c, n) =>
                {
                    if (s.Item.LayoutParameters is Android.Widget.RelativeLayout.LayoutParams lp)
                    {
                        // we now need to find
                        // 1 new items
                        // 2. removed items
                        // 3. updated items...

                        var differences = DictionaryUpdater<LayoutRules, LayoutRule>.Default.Compare(c, n);

                        foreach (var difference in differences)
                        {
                            switch (difference)
                            {
                                case DictionaryUpdater<LayoutRules,LayoutRule>.Add op:
                                    ApplyRule(lp,op.Value);
                                    break;

                                case DictionaryUpdater<LayoutRules,LayoutRule>.Update op:
                                    RemoveRule(lp,op.From);
                                    ApplyRule(lp,op.To);
                                    break;
                                case DictionaryUpdater<LayoutRules,LayoutRule>.Remove op:
                                    RemoveRule(lp,op.Value);
                                    break;
                            }
                        }
                    }
                }));
        }

        /// <summary>
        /// Specify the layout rules to be used for a <see cref="Android.Widget.RelativeLayout"/>
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="component"></param>
        /// <param name="layoutRules"></param>
        /// <returns></returns>
        public static TControl RelativeLayoutRules<TControl>(this TControl component, LayoutRule[] layoutRules)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            component.Attributes.SetAttribute(LayoutRulesAttribute,layoutRules.ToDictionary(lr => lr.Verb,lr => lr));
            return component;
        }

        /// <summary>
        /// Specify whether views within a <see cref="Android.Widget.RelativeLayout"/> should align with their parent or not.
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="component"></param>
        /// <param name="alignWithParent"></param>
        /// <returns></returns>
        public static TControl RelativeLayoutAlignWithParent<TControl>(this TControl component, bool alignWithParent) where TControl:IReflectedPrimitive<Android.Views.View>
        {
            component.Attributes.SetAttribute(AlignWithParentAttribute,alignWithParent);
            return component;
        }
    }
}