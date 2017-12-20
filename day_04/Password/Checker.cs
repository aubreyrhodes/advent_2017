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
    }
}
