using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s="")
        {
            if(string.IsNullOrEmpty(s))
                return 0;

            string[] delimeters = new[] {",", "\n"};
            if (s.StartsWith("//"))
            {
                string[] components = s.Split("\n");
                delimeters = new[] {components[0].Replace("//", "")};
                s = components[1];
            }
            
            var numbers = s.Split(delimeters, StringSplitOptions.None).Select(int.Parse).ToArray();

            return numbers.Sum();
        }
    }
}