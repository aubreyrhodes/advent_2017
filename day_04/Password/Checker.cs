using System;
using System.Linq;

namespace Password
{
    public class Checker
    {
        public bool IsValid(string password)
        {
            var words = password.Split(' ');
            return words.Length == words.Distinct().Count();
        }

        public bool IsValidV2(string password)
        {
            var words = password.Split(' ');
            var sortedWords = words.Select(w => String.Concat(w.OrderBy(c => c)));
            return sortedWords.Count() == sortedWords.Distinct().Count();
        }
    }
}
