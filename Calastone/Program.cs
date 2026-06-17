using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;

namespace Calastone
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<IFilter, VowelFilter>();
            services.AddTransient<IFilter, ShortFilter>();
            services.AddTransient<IFilter, TFilter>();

            var serviceProvider = services.BuildServiceProvider();

            var vowel = new VowelFilter();
            var shortFilter = new ShortFilter();
            var tFilter = new TFilter();

            //services.AddTransient<PipelineRunner>();

            //var serviceProvider = services.BuildServiceProvider();

            // Read all text from the file
            try
            {
                string fileContent = File.ReadAllText(args[0]);

                // Split by space and automatically remove extra empty spaces
                string[] words = fileContent.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    string result = vowel.Filter(word);
                    result = shortFilter.Filter(result);
                    result = tFilter.Filter(result);

                    Console.Write(result + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
 