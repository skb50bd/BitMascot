using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Xml.Linq;
using System.Collections.Generic;

namespace BitMascot
{
    public class JpegFinder {
        public async Task Start() {
            while(true) {
                Print();
                await Task.Delay(Configuration.PrintInterval);
            }
        }
        private IList<string> Find() {
            if(!File.Exists(Configuration.LocalFilePath)) {
                return null;
            }

            var doc = XDocument.Load(Configuration.LocalFilePath);

            var urls = doc.Root.Descendants(Configuration.MediaNS + "content")
                               .Where(m => m.Attribute("medium").Value == "image" && m.Attribute("type").Value == "image/jpeg")
                               .Select(m => m.Attribute("url").Value);

            return urls.ToList();
        }

        private void Print() {
            var urls = Find();

            var time = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            var path = Configuration.LocalFilePath;
            var count = urls?.Count() ?? 0;
            var message = $"Found {count} JPEG images in {path} [{time}]";
            Console.WriteLine(message);

            for(var i = 0; i < urls.Count(); i++) {
                var url = urls[i];
                Console.WriteLine($"{i + 1} - {url}");
            }
            Console.WriteLine("\n");
        }
        
    }
}
