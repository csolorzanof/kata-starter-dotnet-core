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

            var delimeters = new[] {",", "\n"};
            if (s.StartsWith("//"))
            {
                var components = s.Split("\n");
                delimeters = new[] {components[0].Replace("//", "")};
                s = components[1];
            }

            var numbers = s.Split(delimeters, StringSplitOptions.None)
                .Select(int.Parse)
                .Where(x => x < 1001)
                .ToArray();

            var negatives = numbers
                .Where(x => x < 0)
                .ToArray();
            if (negatives.Any()) throw new Exception($"negatives not allowed: {string.Join(", ", negatives)}");

            return numbers.Sum();
        }
    }
}