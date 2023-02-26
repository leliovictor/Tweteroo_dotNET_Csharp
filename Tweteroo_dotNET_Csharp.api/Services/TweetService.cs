using Tweteroo_dotNET_Csharp.Models;

namespace Tweteroo_dotNET_Csharp.Service
{
    public static class TweetService
    {
        public static List<Tweet> ReverseTweets(List<Tweet> twts)
        {
            List<Tweet> cloneTwts = new List<Tweet>(twts);
            cloneTwts.Reverse();
            return cloneTwts;
        }
    }
}
