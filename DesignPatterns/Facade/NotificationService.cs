using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("IP");
            var auth = server.Authenticate("AppId", "key");
            //var message = new Message("New message");
            server.Send(auth, new Message(message), target);
            connection.Disconnect();
        }
    }
}
