using System;
using BenchmarkDotNet.Running;

namespace DotnetPerf
{
    public class Program
    {
        //public static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SplitJoinAcrossFxBenchmarks>();
            Console.ReadLine();
        }
    }
}