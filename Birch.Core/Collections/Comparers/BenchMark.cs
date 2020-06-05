using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Birch.Collections.Comparers
{
    public class ComparerBenchmarks
    {
        private TestClass[] _source;
        private TestClass[] _destn;

        public ComparerBenchmarks()
        {
            TestClass a = new TestClass();


            var final = a.Add().Sub();
            _source = Enumerable.Range(0, 100).Select(i => new TestClass() {Text = $"Hello World {i}"}).ToArray();
            _destn = Enumerable.Range(1, 100).Select(i => new TestClass() {Text = $"Hello World {i}"}).ToArray();

        }

        public void Heck()
        {
            var t = Birch.Collections.Comparers.Heckel.Implementation
                .OrderedDiff(_source, _destn, EqualityComparer<TestClass>.Default).ToList();
        }


        public void Simple()
        {
            var t = Birch.Collections.Comparers.Simple.Implementation
                .Diff(_source, _destn, EqualityComparer<TestClass>.Default).ToList();
        }

        public void Myers()
        {
            var x = Birch.Collections.Comparers.Myers.Implementation.Diff(_source, _destn,
                EqualityComparer<TestClass>.Default);
        }
    }

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

    public static class ext
    {
        public static TestClass Add(this TestClass a)
        {
            a.Text = a.Text + "-";
            return a;
        }

        public static TestClass Sub(this TestClass a)
        {
            a.Text = a.Text + "+";
            return a;
        }

    }

}
