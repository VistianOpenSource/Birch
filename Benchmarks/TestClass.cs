using System;
using System.Collections.Generic;
using System.Text;

namespace DifferenceBenchmarkConsole
{
    public class TestClass:IEquatable<TestClass>
    {
        public string Text { get; set; }

        public bool Equals(TestClass other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Text == other.Text;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TestClass) obj);
        }

        private int? _hashCode;
        public override int GetHashCode()
        {
            if (_hashCode.HasValue)
            {
                return _hashCode.Value;
            }

            _hashCode = Text.GetHashCode();
            return _hashCode.Value;

        }

        public static bool operator ==(TestClass left, TestClass right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TestClass left, TestClass right)
        {
            return !Equals(left, right);
        }
    }
}
