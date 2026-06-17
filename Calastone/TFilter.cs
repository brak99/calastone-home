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

            var lower = input.ToLower();

            return lower.Contains("t") ? "" : input;

        }
    }
}
