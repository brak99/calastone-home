using Microsoft.Extensions.DependencyInjection;

namespace Calastone
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var vowel = new VowelFilter();
            var shortFilter = new ShortFilter();
            var tFilter = new TFilter();

            try
            {
                string fileContent = File.ReadAllText(args[0]);

                string[] words = fileContent.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    var clean = new string(word.Where(c => !char.IsPunctuation(c)).ToArray());

                    string result = vowel.Filter(clean);
                    result = shortFilter.Filter(result);
                    result = tFilter.Filter(result);

                    if (!string.IsNullOrWhiteSpace(result))
                    {
                        Console.Write(result + " ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
 