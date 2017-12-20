using System;

namespace Password.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllText(@"input.txt");
            var sum = 0;
            var v2Sum = 0;
            var passwords = input.Split('\n');
            var checker = new Checker();

            foreach (var password in passwords)
            {
                if(checker.IsValid(password) && password != "") {
                    sum++;
                }

                if(checker.IsValidV2(password) && password != ""){
                    v2Sum++;
                }
            }

            Console.WriteLine(sum);
            Console.WriteLine(v2Sum);
        }
    }
}
