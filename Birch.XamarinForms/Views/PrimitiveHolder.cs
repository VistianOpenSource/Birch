using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Birch.Annotations;
using Birch.Components;

namespace Birch.Views
{
    /// <summary>
    /// Container for <see cref="IPrimitive"/> raising a <see cref="PropertyChangedEventHandler"/> when the value changes.
    /// </summary>
    public class PrimitiveHolder:INotifyPropertyChanged,IEquatable<PrimitiveHolder>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IPrimitive _primitive;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Get or set the associated <see cref="IPrimitive"/>
        /// </summary>
        public IPrimitive Primitive
        {
            get => _primitive;
            set
            {
                if (!ReferenceEquals(_primitive, value))
                {
                    _primitive = value;
                    OnPropertyChanged(nameof(Primitive));
                }
            }
        }

        public bool Equals(PrimitiveHolder other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(_primitive, other._primitive);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PrimitiveHolder) obj);
        }

        public override int GetHashCode() => (_primitive != null ? _primitive.GetHashCode() : 0);

        public static bool operator ==(PrimitiveHolder left, PrimitiveHolder right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PrimitiveHolder left, PrimitiveHolder right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return _primitive?.ToString();
        }
    }
}