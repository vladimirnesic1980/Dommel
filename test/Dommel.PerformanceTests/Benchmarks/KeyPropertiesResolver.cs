using System;
using BenchmarkDotNet.Attributes;
using static Dommel.DommelMapper;

namespace Dommel.PerformanceTests
{
    public class KeyPropertiesResolver
    {

        [Benchmark(Baseline = true)]
        public void NonCached()
        {
            _ = new DefaultKeyPropertyResolver().ResolveKeyProperties(typeof(Foo));
        }

        [Benchmark]
        public void Cached()
        {
            _ =  Resolvers.KeyProperties(typeof(Foo));
        }
    }
}
