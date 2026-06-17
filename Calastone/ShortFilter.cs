using System;
using System.Collections.Generic;
using System.Text;

namespace Calastone
{
    public class ShortFilter : IFilter
    {
        public ShortFilter() { }

        public string Filter(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            return input.Length < 3 ? "" : input;

        }
    }
}
