using System.Collections.Generic;

namespace Birch.Shadows
{
    /// <summary>
    /// A dictionary of objects, indexed by key
    /// </summary>
    /// <remarks>
    /// Operations can optionally specify a textual key, which is appended to the name of the type which
    /// has been specified for the operation.</remarks>
    public class ContainerBag
    {
        private readonly Dictionary<string,object> _stateBag = new Dictionary<string, object>();

        public void Set<TValue>(TValue value)
        {
            Set(string.Empty,value);
        }

        public void Set<TValue>(string key, TValue value)
        {
            _stateBag[Key<TValue>(key)] = value;
        }

        public TValue Get<TValue>()
        {
            return Get<TValue>(string.Empty);
        }

        private string Key<TValue>(string key) => typeof(TValue).FullName + ":" + key;

        public TValue Get<TValue>(string key)
        {
            return TryGetValue<TValue>(key, out var value) ? value : default(TValue);
        }

        public bool TryGetValue<TValue>(out TValue value)
        {
            return TryGetValue(string.Empty,out value);
        }

        public bool TryGetValue<TValue>(string key, out TValue value)
        {
            if (_stateBag.TryGetValue(Key<TValue>(key), out var rawValue))
            {
                value = (TValue) rawValue;
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        public void Clear()
        {
            _stateBag.Clear();
        }

        public void Delete<TValue>()
        {
            Delete<TValue>(string.Empty);
            
        }

        public void Delete<TValue>(string key)
        {
            _stateBag.Remove(Key<TValue>(key));
        }
    }
}