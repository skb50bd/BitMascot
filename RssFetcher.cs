using System.IO;
using System.Net.Http;
using System;
using System.Threading.Tasks;

namespace BitMascot
{
    public class RssFetcher
    {
           private readonly HttpClient _client;

        public RssFetcher()
        {
            _client = new HttpClient();
        }

        public async Task Start() {
            while(true) {
                await Fetch();
                await Task.Delay(Configuration.FetchInterval);
            }
        }

        private async Task Fetch()
        {
            var content = await _client.GetStringAsync(Configuration.RemoteFilePath);
            await File.WriteAllTextAsync(Configuration.LocalFilePath, content);
            Console.WriteLine($"Updated a.rss [{DateTime.Now:dd/MM/yyyy HH:mm:ss}]");
        }
    }
}
