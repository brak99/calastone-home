using System;
using System.Collections.Generic;
using System.Text;

namespace Calastone
{
    public class VowelFilter : IFilter
    {
        private static readonly HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        public VowelFilter() { }

        public string Filter(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            int middleIndex = input.Length / 2;
            var filtered = "";

            if (input.Length % 2 == 1)
            {
                // Keep word if middle character is NOT a vowel
                if (!vowels.Contains(input[middleIndex]))
                {
                    filtered = input;
                }
            }
            else
            {
                if (!vowels.Contains(input[middleIndex]) || !vowels.Contains(input[middleIndex]))
                {
                    filtered = input;
                }
            }

            return filtered;

        }
    }
}
