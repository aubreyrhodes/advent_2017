using System;

namespace Checksum.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllText(@"input.txt");
            var runner = new ChecksumService();
            var sum = runner.GetSum(input);
            Console.WriteLine(sum);
            var sum2 = runner.GetSumV2(input);
            Console.WriteLine(sum2);
        }
    }
}
