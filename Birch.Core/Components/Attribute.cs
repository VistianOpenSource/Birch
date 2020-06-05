using System;
using System.Collections.Generic;
using System.Threading;
using Birch.Reflection;

namespace Birch.Components
{
    /// <summary>
    /// Represents a property of a <see cref="IPrimitive"/> element.
    /// </summary>
    public abstract partial class Attribute
    {
        /// <summary>
        /// Incrementing value to give each attribute a unique identifier
        /// </summary>
        protected static int IdVal;

        /// <summary>
        /// The id of this attribute
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Whether this attribute contains descendents or not.
        /// </summary>
        public bool ContainsDescendents { get; }

        protected Attribute(int id,bool containsDescendents=false)
        {
            ContainsDescendents = containsDescendents;
            Id = id;
        }

        /// <summary>
        /// Utility function to get the name of a class member.
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="member"></param>
        /// <returns></returns>
        public static string Name<TClass>(string member)
        {
            return Name(typeof(TClass), member);
        }

        /// <summary>
        /// Utility function to get the name of an attribute which a type and a member name.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="member"></param>
        /// <returns></returns>
        public static string Name(Type type,string member)
        {
            return $"{type.Name}.{member}";
        }


        public abstract bool CompareValues(object x, object y);

        public abstract int CalculateHashCode(object instance);
    }


    public partial class Attribute
    {
        /// <summary>
        /// Registers an attribute within the attribute store.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="name"></param>
        /// <param name="containsDescendents"></param>
        /// <param name="equalityComparer"></param>
        /// <returns></returns>
        /// <remarks>Each attribute is allocated a unique id, this is used to tie the values held within each <see cref="IPrimitive"/> to the actual
        /// attribute details in the <see cref="AttributeStore"/></remarks>
        public static Attribute<TValue> Register<TValue>(string name,bool containsDescendents=false,IEqualityComparer<TValue> equalityComparer=default)
        {
            // check it doesn't already exist
            var attribute = AttributeStore.Default.GetAttribute<TValue>(name);

            if (attribute != null)
            {
                return attribute;
            }

            // get a new unique id
            var id = Interlocked.Increment(ref IdVal);
            // create the instance
            attribute = new Attribute<TValue>(id,containsDescendents,equalityComparer);

            // and register
            AttributeStore.Default.Register(name,attribute);

            return attribute;
        }

        /// <summary>
        /// Register an attribute within the attribute site.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attributeType"></param>
        /// <param name="containsDescendents"></param>
        /// <returns></returns>

        public static Attribute Register(string name, Type attributeType,bool containsDescendents = false)
        {
            // first check that we don't have it already
            var attribute = AttributeStore.Default.GetAttribute(name);

            if (attribute != null)
            {
                return attribute;
            }

            // get a new id
            var id = Interlocked.Increment(ref IdVal);

            // construct the type to be activated for the attribute
            var baseType = typeof(Attribute<>);
            var genType = baseType.MakeGenericType(attributeType);

            // create the instance
            attribute = (Attribute)Activator.CreateInstance(genType, id, containsDescendents,null);

            // and register
            AttributeStore.Default.Register(name,attribute);

            return attribute;
        }

        /// <summary>
        /// Register a <see cref="EventAttribute{TValue}"/> with a specified name and type
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        public static Attribute RegisterEvent(string name, Type attributeType)
        {
            var attribute = AttributeStore.Default.GetAttribute(name);

            if (attribute != null)
            {
                return attribute;
            }

            var id = Interlocked.Increment(ref IdVal);

            var baseType = typeof(EventAttribute<>);
            var actualType = baseType.MakeGenericType(attributeType);

            var equalityComparerType = attributeType.IsGenericType ? typeof(ActionEqualityComparer<>).MakeGenericType(attributeType.GenericTypeArguments[0]) : typeof(ActionEqualityComparer);

            var equalityComparer = Activator.CreateInstance(equalityComparerType);

            attribute = (Attribute)Activator.CreateInstance(actualType, id,equalityComparer);

            AttributeStore.Default.Register(name,attribute);

            return attribute;
        }

        /// <summary>
        /// Register a <see cref="EventAttribute{TValue}"/> with a specified name and type
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attributeType"></param>
        /// <param name="equalityComparer"></param>
        /// <returns></returns>
        public static Attribute RegisterEvent<TAction>(string name, Type attributeType,IEqualityComparer<TAction> equalityComparer=default)
        {
            var attribute = AttributeStore.Default.GetAttribute(name);

            if (attribute != null)
            {
                return attribute;
            }

            var id = Interlocked.Increment(ref IdVal);

            var baseType = typeof(EventAttribute<>);
            var actualType = baseType.MakeGenericType(attributeType);

            //var equalityComparerType = typeof(ActionEqualityComparer<>).MakeGenericType(attributeType);

            //var equalityComparer = Activator.CreateInstance(equalityComparerType);

            attribute = (Attribute)Activator.CreateInstance(actualType, id,equalityComparer);

            AttributeStore.Default.Register(name,attribute);

            return attribute;
        }



        /// <summary>
        /// Register an event with a specified name, and type
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public static EventAttribute<Action<TValue>> RegisterEvent<TValue>(string name)
        {
            var attribute = AttributeStore.Default.GetAttribute(name);

            if (attribute != null)
            {
                return (EventAttribute<Action<TValue>>)attribute;
            }

            var id = Interlocked.Increment(ref IdVal);
            attribute = new EventAttribute<Action<TValue>>(id);

            AttributeStore.Default.Register(name,attribute);

            return (EventAttribute<Action<TValue>>)attribute;
        }

    }


    /// <summary>
    /// Generic implementation of an attribute.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    [Preserve(AllMembers = true)]
    public class Attribute<TValue>:Attribute
    {
        private readonly IEqualityComparer<TValue> _equalityComparer;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="containsDescendents"></param>
        /// <param name="equalityComparer"></param>
        public Attribute(int id, bool containsDescendents=false, IEqualityComparer<TValue> equalityComparer=default):base(id,containsDescendents)
        {
            _equalityComparer = equalityComparer??EqualityComparer<TValue>.Default;
        }

        public override bool CompareValues(object x, object y)
        {
            return CompareValue((TValue) x, (TValue) y);
        }

        public override int CalculateHashCode(object instance)
        {
            return instance == null ? 0 : _equalityComparer.GetHashCode((TValue) instance);
        }

        private bool CompareValue(TValue x, TValue y)
        {
            return _equalityComparer.Equals(x,y);
        }
    }
}