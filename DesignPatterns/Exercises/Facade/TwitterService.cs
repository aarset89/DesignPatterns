using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Facade
{
    public class TwitterService
    {
        public void Gettweets(string user)
        {
            var accessToken =  GetAccessToken();
            var twitterClient = new TwitterClient();
            twitterClient.GetTweets(accessToken);
        }

        private string GetAccessToken()
        {
            var oAuth = new OAuth();
            var token = oAuth.RequestToken("", "");
            var accessToken = oAuth.GetAccessToken(token);

            return accessToken;

        }
    }
}
