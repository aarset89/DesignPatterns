using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Facade
{
    public class OAuth
    {
        public string RequestToken(string appKey, string appSecret)
        {
            Console.WriteLine("Get a requested token");
            return "requestToken";
        }

        public string GetAccessToken ( string requestToken)
        {
            Console.WriteLine("Get an access token");
            return "AccessToken";
        }
    }
}
