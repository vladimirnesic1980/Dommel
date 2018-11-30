using System;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using static Dommel.DommelMapper;

namespace Dommel.PerformanceTests
{
    public class ColumnNameResolver
    {
        private static Type _fooType = typeof(Foo);
        private static PropertyInfo _barProperty = typeof(Foo).GetProperty(nameof(Foo.Bar));

        [Benchmark(Baseline = true)]
        public string NonCached()
        {
            return new DefaultColumnNameResolver().ResolveColumnName(_barProperty);
        }

        [Benchmark]
        public string Cached()
        {
            return Resolvers.Column(_barProperty, DummySqlBuilder.Instance);
        }
    }
}
