using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DifferenceBenchmarkConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<AppendBenchmark>();
            //var summary = BenchmarkRunner.Run<InsertBenchmark>();
            var summary = BenchmarkRunner.Run<RemoveBenchmark>();


            Console.WriteLine(summary);
            Console.ReadLine();
        }
    }

    [MemoryDiagnoser]
    public class InsertBenchmark
    {
        private TestClass[] _source;
        private TestClass[] _destn;

        public InsertBenchmark()
        {
            _source = Enumerable.Range(1, 10000).Select(i => new TestClass() {Text = $"Hello World {i}"}).ToArray();
            _destn = Enumerable.Range(0,  10000).Select(i => new TestClass() {Text = $"Hello World {i}"}).ToArray();

        }

        [Benchmark()]
        public void Heck()
        {
            var t = Birch.Collections.Comparers.Heckel.Implementation.OrderedDiff(_source, _destn, EqualityComparer<TestClass>.Default).ToList();
        }


        [Benchmark()]
        public void Simple()
        {
            var t = Birch.Collections.Comparers.Simple.Implementation.Diff(_source, _destn, EqualityComparer<TestClass>.Default).ToList();
        }

        [Benchmark]
        public void Myers()
        {
            var x = Birch.Collections.Comparers.Myers.Implementation.Diff(_source, _destn,
                EqualityComparer<TestClass>.Default);
        }
    }

    [MemoryDiagnoser]
    public class RemoveBenchmark
    {
        private TestClass[] _source;
        private TestClass[] _destn;

        public RemoveBenchmark()
        {
            _source = Enumerable.Range(0, 10000).Select(i => new TestClass() {Text = $"Hello World {i}"}).ToArray();
            _destn = Enumerable.Range(1,  10000).Select(i => new TestClass() {Text = $"Hello World {i}"}).ToArray();

        }

        [Benchmark()]
        public void Heck()
        {
            var t = Birch.Collections.Comparers.Heckel.Implementation.OrderedDiff(_source, _destn, EqualityComparer<TestClass>.Default).ToList();
        }


        [Benchmark()]
        public void Simple()
        {
            var t = Birch.Collections.Comparers.Simple.Implementation.Diff(_source, _destn, EqualityComparer<TestClass>.Default).ToList();
        }

        [Benchmark]
        public void Myers()
        {
            var x = Birch.Collections.Comparers.Myers.Implementation.Diff(_source, _destn,
                EqualityComparer<TestClass>.Default);
        }
    }


    [MemoryDiagnoser]
    public class AppendBenchmark
    {
        private TestClass[] _source;
        private TestClass[] _destn;

        public AppendBenchmark()
        {
            _source = Enumerable.Range(0, 10000).Select(i => new TestClass() {Text = $"Hello World {i}"}).ToArray();
            _destn = Enumerable.Range(0,  10001).Select(i => new TestClass() {Text = $"Hello World {i}"}).ToArray();

        }

        [Benchmark()]
        public void Heck()
        {
            var t = Birch.Collections.Comparers.Heckel.Implementation.OrderedDiff(_source, _destn, EqualityComparer<TestClass>.Default).ToList();
        }


        [Benchmark()]
        public void Simple()
        {
            var t = Birch.Collections.Comparers.Simple.Implementation.Diff(_source, _destn, EqualityComparer<TestClass>.Default).ToList();
        }

        [Benchmark]
        public void Myers()
        {
            var x = Birch.Collections.Comparers.Myers.Implementation.Diff(_source, _destn,
                EqualityComparer<TestClass>.Default);
        }
    }
}
