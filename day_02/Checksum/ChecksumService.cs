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
    }
}
