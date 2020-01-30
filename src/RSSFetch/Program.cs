using System.Threading.Tasks;

namespace BitMascot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var fetcher = new RssFetcher();
            var jpegFinder = new JpegFinder();

            var fetchTask = fetcher.Start();
            var printTask = jpegFinder.Start();

            await fetchTask;
            await printTask;
        }
    }
}
