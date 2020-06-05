using System;
using Birch.Reflection;
using Birch.Shadows;

namespace Birch.Components
{
    /// <summary>
    /// Base implementation of <see cref="IPrimitive"/> whereby all additional properties
    /// are stored in an <see cref="Attributes"/> instance.
    /// </summary>
    public abstract class BasePrimitive:IPrimitive,IEquatable<BasePrimitive>
    {
        public Attributes Attributes { get; set; } = new Attributes();

        public bool Equals(BasePrimitive other)
        {
            if (ReferenceEquals(null, other)) return false;

            return ReferenceEquals(this, other) || Equals(Attributes, other.Attributes);
        }

        public bool Equals(IPrimitive other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.GetType() == this.GetType() && Equals((BasePrimitive) other);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((BasePrimitive) obj);
        }

        public override int GetHashCode()
        {
            return Attributes?.GetHashCode()?? 0;
        }

        /// <summary>
        /// Get the hashcode for a specified <see cref="ComparisonMode"/>
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public int GetHashCode(ComparisonMode mode)
        {
            return mode == ComparisonMode.Deep ? Attributes.GetDeepHashCode() : Attributes.GetShallowHashCode();
        }

        public bool Equals(IPrimitive component, ComparisonMode mode)
        {
            if (component == null) throw new ArgumentException($"Null component",nameof(component));

            if (this.GetType() != component.GetType())
            {
                return false;
            }

            return mode == ComparisonMode.Deep ? Attributes.DeepEquals(component.Attributes) : Attributes.ShallowEquals(component.Attributes);
        }

        public override string ToString()
        {
            return $"{this.GetType().FriendlyName()} {Attributes}";
        }
    }


    /// <summary>
    /// Generic version of a primitive component, where the actual 'platform' type TItem is provided and reflection is utilized for
    /// attribute.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class BasePrimitive<TItem>:BasePrimitive,IReflectedPrimitive<TItem> where TItem : class
    {
    }

    public static class BasePrimitiveExtensions
    {
        /// <summary>
        /// Action to be invoked when the <see cref="IShadow"/> has been created.
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <typeparam name="TShadow"></typeparam>
        /// <param name="control"></param>
        /// <param name="created"></param>
        /// <returns></returns>
        /// <remarks>This is always as a consequence of transitioning from having no <see cref="IPrimitive"/> to having one.</remarks>
        public static TControl OnCreate<TControl, TShadow>(this TControl control, Action<TShadow> created) where TControl:IAttributes where TShadow:IShadow
        {
            control.Attributes.SetAttribute(StandardAttributes.CreatedAttribute, (b, s) => created((TShadow)s));
            return control;
        }

        /// <summary>
        /// Action to be invoked when the <see cref="IPrimitive"/> has been updated.
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <typeparam name="TShadow"></typeparam>
        /// <param name="control"></param>
        /// <param name="created"></param>
        /// <returns>
        /// It should be noted that this necessarily doesn't imply that either this <see cref="IPrimitive"/> component was directly updated
        /// or that it had a visual aspect to it.
        /// This is derived by looking at the transaction count changing when this <see cref="IPrimitive"/> was updated.</returns>
        public static TControl OnUpdate<TControl, TShadow>(this TControl control, Action<TShadow> created) where TControl:IAttributes where TShadow:IShadow
        {
            control.Attributes.SetAttribute(StandardAttributes.UpdatedAttribute, (b, s) => created((TShadow)s));
            return control;
        }

        /// <summary>
        /// Actual to be invoked when the <see cref="IShadow"/> has been removed/destroyed.
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <typeparam name="TShadow"></typeparam>
        /// <param name="control"></param>
        /// <param name="destroyed"></param>
        /// <returns></returns>
        /// <remarks>This is a consequence of transitioning from having a <see cref="IPrimitive"/> to not having one or there
        /// isn't a suitable match for the update to occur e.g. differing types of <see cref="IPrimitive"/>.
        /// </remarks>
        public static TControl OnDestroy<TControl, TShadow>(this TControl control, Action<TControl, TShadow> destroyed) where TControl : BasePrimitive where TShadow : IShadow
        {
            control.Attributes.SetAttribute(StandardAttributes.DestroyedAttribute, (b, s) => destroyed((TControl)b,(TShadow)s));
            return control;
        }
    }
}