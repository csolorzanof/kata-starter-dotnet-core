using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if(string.IsNullOrEmpty(s))
                return 0;

            if (!s.StartsWith("//")) return SumAllValidNumbers(s, new[] {",", "\n"});
            
            var parts = s.Split("\n");
            var input = parts[1];
                
            var separator = parts[0].Replace("//", "")
                .Replace("[","")
                .Split("]");
                
            return SumAllValidNumbers(input, separator);
        }

        static int SumAllValidNumbers(string input, string[] separator)
        {
            var numbers = input.Split(separator, StringSplitOptions.None).Select(int.Parse).Where(x => x <= 1000).ToArray();

            ValidateNumbers(numbers);

            return numbers.Sum();
        }

        static void ValidateNumbers(int[] numbers)
        {
            var negatives = numbers.Where(x => x < 0).ToArray();
            if (negatives.Any())
            {
                throw new Exception($"negatives not allowed: {string.Join(", ", negatives)}");
            }
        }
    }
}