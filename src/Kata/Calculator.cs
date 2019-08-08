using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            
            var separator = new []{",", "\n"};
            if (s.StartsWith("//"))
            {
                separator = new[] {s.Split("\n")[0].Replace("//", "")};
                s = s.Split("\n")[1];
            }
                        
            var array = s.Split(separator, StringSplitOptions.None).Select(int.Parse).ToArray();
            if (array.Length == 1)
                return array.First();

            var negatives = array.Where(x => x < 0).ToArray();
            if (negatives.Any())
                throw new Exception($"negatives not allowed: {string.Join(", ",negatives)}");

            return array.Sum();
        }
    }
}