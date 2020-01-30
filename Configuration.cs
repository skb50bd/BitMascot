using System.Xml.Linq;

namespace BitMascot
{
    public static class Configuration {
        public const string LocalFilePath = @"d:\a.rss";
        public const string RemoteFilePath = @"http://rss.cnn.com/rss/edition.rss";
        public const int FetchInterval = 15 * 1000;
        public const int PrintInterval = 20 * 1000;
        public static XNamespace MediaNS = @"http://search.yahoo.com/mrss/";
    } 
}
