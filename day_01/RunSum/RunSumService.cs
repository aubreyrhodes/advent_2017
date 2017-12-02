using System;

namespace RunSum
{
    public class RunSumService
    {
        public int GetSum(string run)
        {
            var sum = 0;
            for(var i = 0; i < run.Length - 1; i++) {
               if (run[i] == run[i+1])  {
                   var digit = Int32.Parse(run[i].ToString());
                   sum += digit;
               }
            }
            if(run[run.Length - 1] == run[0]){
                var digit = Int32.Parse(run[0].ToString());
                sum += digit;
            }
            return sum;
        }
    }
}