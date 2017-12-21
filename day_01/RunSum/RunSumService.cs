using System;

namespace RunSum
{
    public class RunSumService
    {
        public int GetSum(string run)
        {
            var sum = 0;
            for (var i = 0; i < run.Length - 1; i++)
            {
                if (run[i] == run[i + 1])
                {
                    var digit = Int32.Parse(run[i].ToString());
                    sum += digit;
                }
            }
            if (run[run.Length - 1] == run[0])
            {
                var digit = Int32.Parse(run[0].ToString());
                sum += digit;
            }
            return sum;
        }

        public int GetSumV2(string run)
        {
            var offset = run.Length / 2;
            var sum = 0;
            for (var i = 0; i < run.Length; i++)
            {
                if (run[i] == run[Wrap(i + offset, run.Length)])
                {
                    var digit = Int32.Parse(run[i].ToString());
                    sum += digit;
                }
            }
            return sum;
        }

        private int Wrap(int i, int total)
        {
            if (i >= total)
            {
                return i - total;
            }

            return i;
        }
    }
}