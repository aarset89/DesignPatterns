using DesignPatterns.Exercises.Adapter.Gmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Adapter
{
    public class GmailAdapter : IEmailProvider
    {
        private GmailClient _gmailClient;

        public GmailAdapter()
        {
            _gmailClient = new GmailClient();
        }
        public GmailAdapter(GmailClient gmailClient)
        {
            _gmailClient = gmailClient;
        }
        public void DownloadEmails()
        {
            _gmailClient.Connect();
            _gmailClient.GetEmails();
            _gmailClient.Disconnect();
        }
    }
}
