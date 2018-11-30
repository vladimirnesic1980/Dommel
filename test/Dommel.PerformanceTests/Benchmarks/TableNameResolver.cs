using System;
using BenchmarkDotNet.Attributes;
using static Dommel.DommelMapper;

namespace Dommel.PerformanceTests
{
    public class TableNameResolver
    {
        [Benchmark(Baseline = true)]
        public string NonCached()
        {
            return new DefaultTableNameResolver().ResolveTableName(typeof(Foo));
        }

        [Benchmark]
        public string Cached()
        {
            return Resolvers.Table(typeof(Foo), DummySqlBuilder.Instance);
        }
    }
}
