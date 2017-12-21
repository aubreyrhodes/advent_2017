using System;
using System.Text.RegularExpressions;

namespace Checksum
{
    public class ChecksumService
    {
        public int GetSum(string input)
        {
            var sum = 0;
            // split input into rows
            var rows = input.Split('\n');

            // find min and max for row
            foreach (var row in rows)
            {
                if (row == "")
                {
                    continue;
                }

                var min = Int32.MaxValue;
                var max = -1;

                var items = Regex.Split(row, "[ \t]+");
                foreach (var string_num in items)
                {
                    var num = Int32.Parse(string_num);
                    if (num > max)
                    {
                        max = num;
                    }

                    if (num < min)
                    {
                        min = num;
                    }
                }

                sum += (max - min);
            }
            return sum;
        }

        public int GetSumV2(String input)
        {
            var sum = 0;
            // split input into rows
            var rows = input.Split('\n');

            // find min and max for row
            foreach (var row in rows)
            {
                if (row == "")
                {
                    continue;
                }

                var items = Regex.Split(row, "[ \t]+");
                for (int i = 0; i < items.Length; i++)
                {
                    var firstInt = Int32.Parse(items[i]);
                    for (int j = 0; j < items.Length; j++)
                    {
                        var secondInt = Int32.Parse(items[j]);
                        if (firstInt % secondInt == 0 && i != j)
                        {
                            sum += firstInt / secondInt;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
