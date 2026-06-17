using System;
using System.Collections.Generic;
using System.Text;

namespace Calastone
{
    public class TFilter : IFilter
    {
        public TFilter() { }

        public string Filter(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            return input.ToLower().Contains("t") ? "" : input;

        }
    }
}
