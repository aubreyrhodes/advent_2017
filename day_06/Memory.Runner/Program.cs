using System;
using System.Linq;

namespace Memory.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllText(@"input.txt");
            var a = input.Split('\t').Where(x => x != "").Select(x => Int32.Parse(x)).ToArray();
            var service = new Allocator();
            var rounds = service.RoundsToBalance(a);
            Console.WriteLine(rounds);
            var loop = service.RoundsInLoop(a);
            Console.WriteLine(loop);
        }
    }
}
