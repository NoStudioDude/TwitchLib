﻿using TwitchLib.Controllers;
using TwitchLib.Util;

namespace TwitchLib.Models
{
    public class Twitch
    {
        public Twitch(string channel, string apiToken = "")
        {
            Configuration = new Configuration
            {
                Channel = channel,
                ApiToken = apiToken
            };
            Logger = new Logger();
            TwitchController = new TwitchController();
        }

        public Twitch(TwitchController p)
        {
            TwitchController = p;
        }

        public Twitch(Configuration c)
        {
            Configuration = c;
        }

        public Twitch(Logger l)
        {
            Logger = l;
        }

        // TwitchLib.Util
        public Configuration Configuration { get; set; }
        public Logger Logger { get; set; }
        public TwitchController TwitchController { get; set; }
        // TwitchLib.Model
        public Channel Channel { get; set; }
        public Chat Chat { get; set; }
        public ChatBadges ChatBadges { get; set; }
        public ChatEmoticons ChatEmoticons { get; set; }
        public GamesTop GamesTop { get; set; }
        public IngestServer IngestServer { get; set; }
        public StreamLive StreamLive { get; set; }
        public User User { get; set; }
        public UserVideos UserVideos { get; set; }
    }
}