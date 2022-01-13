using System.Net.Http;
using YoutubeExplode.Channels;
using YoutubeExplode.Playlists;
using YoutubeExplode.Search;
using YoutubeExplode.Utils;
using YoutubeExplode.Videos;
using static System.Net.WebRequestMethods;

namespace SF.Itogi_18_4_1
{
    public class YoutubeClient
    {
        public VideoClient Videos { get; }
        public PlaylistClient Playlists { get; }

        /// <summary>
        /// Operations related to YouTube channels.
        /// </summary>
        public ChannelClient Channels { get; }

        /// <summary>
        /// Operations related to YouTube search.
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// Initializes an instance of <see cref="YoutubeClient"/>.
        /// </summary>
        public YoutubeClient(HttpClient http)
        {
            Videos = new VideoClient(http);
            Playlists = new PlaylistClient(http);
            Channels = new ChannelClient(http);
            Search = new SearchClient(http);
        }
        public YoutubeClient() : this(Http.Client)
        {
        }

    }
}
    

