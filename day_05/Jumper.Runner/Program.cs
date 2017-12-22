using System;
using System.Linq;

namespace Jumper.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllText(@"input.txt");
            var lines = input.Split("\n");
            var instructions = lines.Where(l => l != "").Select(l => Int32.Parse(l)).ToArray();
            var list = new List(instructions, 0);
            var result = list.GetMovesToJumpOut();
            Console.WriteLine(result);
            var weirdList = new WeirdList(instructions, 0);
            var weirdResult = weirdList.GetMovesToJumpOut();
            Console.WriteLine(weirdResult);
        }
    }
}
