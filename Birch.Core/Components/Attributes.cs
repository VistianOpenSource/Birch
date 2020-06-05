using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Birch.Components
{
    /// <summary>
    /// Represents a dictionary of <see cref="Attribute{TValue}"/> instances.
    /// </summary>
    public sealed class Attributes:IEnumerable<Attribute>,IEquatable<Attributes>
    {
        /// <summary>
        /// The dictionary of attribute values, indexed by the id
        /// </summary>
        private readonly Dictionary<int,object> _items = new Dictionary<int, object>();


        /// <summary>
        /// Set the value of an attribute
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Attribute<TValue> SetAttribute<TValue>(Attribute<TValue> attribute, TValue value)
        {
            _items[attribute.Id] = value;
            return attribute;
        }

        /// <summary>
        /// Perform a LITE clone of the attributes, creating a new instance.
        /// </summary>
        /// <returns>
        /// </returns>
        /// <remarks>The contents of each attribute isn't cloned but rather just the list which allows user uses to then update the attributes without affecting other references.
        /// </remarks>
        public Attributes Clone()
        {
            var newAttributes = new Attributes();

            foreach (var (key, value) in _items)
            {
                newAttributes._items[key] = value;
            }

            return new Attributes();
        }

        public bool TryGetEventAttribute<TValue>(EventAttribute<TValue> attribute, out Action<TValue> value)
        {
            if (_items.TryGetValue(attribute.Id, out var baseValue))
            {
                value = (Action<TValue>) (baseValue);
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        /// <summary>
        /// Generate a textual representation by joining a textual description of each attribute. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Join(",",_items.Select(i => $"[{i.Key}:{i.Value}]"));
        }

        /// <summary>
        /// Try and get the value for a particular attribute.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetAttribute(Attribute attribute, out object value)
        {
            if (_items.TryGetValue(attribute.Id, out value))
            {
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        /// <summary>
        /// Get the value of an attribute if one exists, otherwise its default value.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public TValue GetAttributeOrDefault<TValue>(Attribute<TValue> attribute)
        {
            return TryGetAttribute(attribute, out var value) ? value : default;
        }

        /// <summary>
        /// Try and get the value of an attribute.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetAttribute<TValue>(Attribute<TValue> attribute, out TValue value)
        {
            if (_items.TryGetValue(attribute.Id, out var baseValue))
            {
                value = (TValue) (baseValue);
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        /// <summary>
        /// Compare two <see cref="Attributes"/> 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <remarks>
        /// The two attributes are compared deeply to see if they match or not..</remarks>
        
        public bool Equals(Attributes other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            var sequenceEqual = _items.SequenceEqual(other._items,AttributeDeepEqualityComparer.Default);

            return sequenceEqual;
        }

        public bool ShallowEquals(Attributes other)
        {
            return CustomEquals(other, AttributeShallowEqualityComparer.Default);
        }

        public bool DeepEquals(Attributes other)
        {
            return CustomEquals(other, AttributeDeepEqualityComparer.Default);
        }

        private bool CustomEquals(Attributes other, IEqualityComparer<KeyValuePair<int, object>> comparer)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            // now just compare those attributes that don't have descendants
            var sequenceEqual = _items.SequenceEqual(other._items,comparer);

            return sequenceEqual;
        }


        public IEnumerator<Attribute> GetEnumerator()
        {
            foreach (var (key, value) in _items)
            {
                var attribute = AttributeStore.Default.GetAttributeForId(key);

                yield return attribute;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Attributes) obj);
        }

        public override int GetHashCode()
        {
            return GetDeepHashCode();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int GetShallowHashCode()
        {
            return GetHashCodes().Shallow;
        }

        public int GetDeepHashCode()
        {
            return GetHashCodes().Deep;
        }

        public static bool operator ==(Attributes left, Attributes right)
        {
            return object.Equals(left, right);
        }

        public static bool operator !=(Attributes left, Attributes right)
        {
            return !object.Equals(left, right);
        }

        private HashCodes? _hashCodes; 
        
        /// <summary>
        /// Generate the different hash codes.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// The two different types of hash code are generated.
        /// These hash codes are generated just once and cached.
        /// The shallow hash code doesn't generate a contribution
        /// for those attributes that contain descendants.
        /// </remarks>
        public HashCodes GetHashCodes()
        {
            unchecked
            {
                if (_hashCodes.HasValue)
                {
                    return _hashCodes.Value;
                }

                var shallow = 19;
                var deep = 19;

                foreach(var (key, value) in _items)
                {
                    var attribute = AttributeStore.Default.GetAttributeForId(key);

                    var kHash = key.GetHashCode();
                    var vHash = attribute.CalculateHashCode(value);

                    if (!attribute.ContainsDescendents)
                    {
                        shallow = shallow * 31 + kHash;
                        shallow = shallow * 31 + vHash;
                    }

                    deep = deep * 31 + kHash;
                    deep = deep * 31 + vHash;
                }

                _hashCodes = new HashCodes(shallow,deep);
                
                return _hashCodes.Value;
            }
        }

        /// <summary>
        /// Internal structure containing the varying hash codes.
        /// </summary>
        public readonly struct HashCodes
        {
            public int Shallow { get; }
            public int Deep { get; }

            public HashCodes(int shallow, int deep)
            {
                Shallow = shallow;
                Deep = deep;
            }
        }

        public void Clear()
        {
            _items.Clear();
        }
    }

}