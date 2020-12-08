using System;
using System.Collections.Generic;

namespace Exception_Handling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access Youtube web service
                // Read the data
                // create a list of Video objects
                throw new Exception("Oops some low level YouTube error");
            }
            catch (Exception ex)
            {
                // Log

                throw new YoutubeException("Could not fetch the videos from Youtube.", ex);
            }

            return new List<Video>();
        }
    }
}
