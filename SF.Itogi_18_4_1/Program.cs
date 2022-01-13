using System;
using System.Threading.Tasks;
using YoutubeExplode;


namespace SF.Itogi_18_4_1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var youtube = new YoutubeClient();

            // You can specify both video ID or URL
            var video = await youtube.Videos.GetAsync("https://youtube.com/watch?v=u_yIGGhubZs");
            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Продолжительность: {video.Duration}");
            Console.WriteLine($"Автор: {video.Author}");

        }
    }
}
