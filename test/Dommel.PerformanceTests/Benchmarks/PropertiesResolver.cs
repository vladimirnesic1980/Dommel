using System;
using BenchmarkDotNet.Attributes;
using static Dommel.DommelMapper;

namespace Dommel.PerformanceTests
{
    public class PropertiesResolver
    {

        [Benchmark(Baseline = true)]
        public void NonCached()
        {
            _ = new DefaultPropertyResolver().ResolveProperties(typeof(Foo));
        }

        [Benchmark]
        public void Cached()
        {
            _ =  Resolvers.Properties(typeof(Foo));
        }
    }
}
