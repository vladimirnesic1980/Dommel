using BenchmarkDotNet.Running;

namespace Dommel.PerformanceTests
{
    //
    // Run jobs with:
    // dotnet run -c Release -- --job short --filter *TestClassName*
    //

    public class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
