using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            var array = s.Split(",").Select(int.Parse).ToArray();
            if (array.Length == 1)
                return array.First();

            return array.First() + array.Last();
        }
    }
}