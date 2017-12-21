using System;

namespace RunSum.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new RunSumService();
            var text = System.IO.File.ReadAllText(@"input.txt");
            text = text.Replace("\n", "");
            var sum = service.GetSum(text);
            Console.WriteLine(sum);
            var sumV2 = service.GetSumV2(text);
            Console.WriteLine(sumV2);
        }
    }
}
