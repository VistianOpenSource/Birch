using System;
using System.Collections.Generic;
using Attribute = Birch.Components.Attribute;

namespace Birch.Components
{
    /// <summary>
    /// The main storage for all attributes.
    /// </summary>
    /// <remarks>
    /// To reduce the amount of storage of actual <see cref="Attribute{TValue}"/> instances, these are held indexed by the attribute id
    /// and not the key that each attribute has.
    /// </remarks>
    public class AttributeStore
    {
        public static AttributeStore Default { get; } = new AttributeStore();

        /// <summary>
        /// Maps between the key name of an attribute and its actual instance.
        /// </summary>
        private readonly Dictionary<string,Attribute> _attributesMap = new Dictionary<string, Attribute>();

        /// <summary>
        /// Maps between the assigned id of an attribute and its actual instance.
        /// </summary>
        private readonly Dictionary<int,Attribute> _attributesIdMap = new Dictionary<int, Attribute>();

        /// <summary>
        /// Register an attribute with a specified name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attribute"></param>
        /// <exception cref="ArgumentException">When the attribute name already exists</exception>
        public void Register(string name, Attribute attribute)
        {
            InternalRegister(name,attribute);
        }

        /// <summary>
        /// Register an attribute with a specified name.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="name"></param>
        /// <param name="attribute"></param>
        public void Register<TValue>(string name,Attribute<TValue> attribute)
        {
            InternalRegister(name,attribute);
        }

        /// <summary>
        /// Internal utility to register the attribute.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attribute"></param>
        private void InternalRegister(string name, Attribute attribute)
        {
            if (_attributesMap.ContainsKey(name))
            {
                throw new ArgumentException($"Duplicate name {name}",nameof(name));
            }
            _attributesMap[name] = attribute;
            _attributesIdMap[attribute.Id] = attribute;
        }

        /// <summary>
        /// Get the attribute with an associated identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Attribute GetAttributeForId(int id)
        {
            return _attributesIdMap[id];
        }

        /// <summary>
        /// Get the typed attribute for a specified name
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public Attribute<TValue> GetAttribute<TValue>(string name)
        {
            return (Attribute<TValue>)(GetAttribute(name));
        }

        /// <summary>
        /// Get the attribute for a specified name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Attribute GetAttribute(string name)
        {
            return _attributesMap.GetValueOrDefault(name);
        }

    }
}