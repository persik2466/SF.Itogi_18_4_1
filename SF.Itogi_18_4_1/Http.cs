using System;
using System.Net;
using System.Net.Http;

namespace SF.Itogi_18_4_1
{
    internal static class Http
    {
        private static readonly Lazy<HttpClient> HttpClientLazy = new(() =>
        {
            var handler = new HttpClientHandler
            {
                // https://github.com/Tyrrrz/YoutubeExplode/issues/530
                UseCookies = false
            };

            if (handler.SupportsAutomaticDecompression)
                handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            return new HttpClient(handler, true);
        });

        public static HttpClient Client => HttpClientLazy.Value;

        public static Lazy<HttpClient> HttpClientLazy1 => HttpClientLazy;
    }
}
