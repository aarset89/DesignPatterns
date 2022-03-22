using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class NotificationServer
    {
        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken("AuthToken");
        }

        public void Send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine("Sending " + message.Content);
        }

        public void Disconnect()
        {

        }
    }
}
