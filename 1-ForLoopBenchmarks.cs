using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DotnetPerf
{
    // [SimpleJob(runtimeMoniker: RuntimeMoniker.Net461, baseline: true)]
    // [SimpleJob(runtimeMoniker: RuntimeMoniker.CoreRt30, baseline: false)]
    public class ForLoopBenchmarks
    {
        [Params(1000, 100000, 10000000)]
        public int N;

        private IList<int> data;

        [GlobalSetup]
        public void GlobalSetup()
        {
            data = Enumerable.Repeat(0, N).ToList();
        }

        [Benchmark(Baseline = true)]
        public int ForLoop()
        {
            int res = 0;
            for (int i = 0; i < N; i++)
                res += data[i];
            return res;
        }

        [Benchmark]
        public int ForEachLoop()
        {
            int res = 0;
            foreach (var i in data)
                res += i;
            return res;
        }

        [GlobalCleanup]
        public void GlobalCleanup()
        {
            // Disposing logic
        }
    }
}
