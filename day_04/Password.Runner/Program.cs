using System;

namespace Password.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllText(@"input.txt");
            var sum = 0;
            var passwords = input.Split('\n');
            var checker = new Checker();

            foreach (var password in passwords)
            {
                if(checker.IsValid(password) && password != "") {
                    sum++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
