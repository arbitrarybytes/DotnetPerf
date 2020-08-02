using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetPerf
{

    //TODO: Uncomment on Windows
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net461, baseline: true)]
    //TODO: Comment below 2.1
    [SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp21, baseline: true)]
    [SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp30)]
    public class SplitJoinAcrossFxBenchmarks
    {

        [Benchmark]
        public int SplitJoin() => string.Join(",", new string[1000]).Split(',').Length;
        
    }

}
