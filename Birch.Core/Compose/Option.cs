using System;

namespace Birch.Compose
{
    /// <summary>
    /// A rather pathetic attempt to emulate something that F# does for free!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks>
    /// We either have a value or we don't. This structure provides
    /// that mechanism and a simple way to determine whether we do have a value or not.</remarks>
    public readonly struct Option<T>
    {
        /// <summary>
        /// The backing value, if specified.
        /// </summary>
        private readonly T _value;

        /// <summary>
        /// Do we have a value?
        /// </summary>
        public bool IsSome { get; }

        /// <summary>
        /// Do we have nothing?
        /// </summary>
        public bool IsNone => !IsSome;

        /// <summary>
        /// Get the actual value
        /// </summary>
        public T Value
        {
            get
            {
                if (!IsSome) throw new NullReferenceException();
                return _value;
            }
        }

        public static Option<T> None => new Option<T>();

        public static Option<T> Some(T value) => new Option<T>(value);

        private Option(T value)
        {
            this._value = value;
            IsSome = true;
        }


        public override bool Equals(object obj)
        {
            if (obj is Option<T> opt)
            {
                return IsSome ? opt.IsSome && opt.Value.Equals(_value) : opt.IsNone;
            }
            return false;
        }

        public override int GetHashCode() => IsSome ? _value.GetHashCode() : 0;
    }
}