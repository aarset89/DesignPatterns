using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Adapter
{
    public class EmailClient
    {
        private List<IEmailProvider> _providers = new List<IEmailProvider>();

        public void AddProvider(IEmailProvider emailProvider)=> _providers.Add(emailProvider);

        public void DownloadEmails()
        {
            foreach(var provider in _providers)
                provider.DownloadEmails();
        }
    }
}
