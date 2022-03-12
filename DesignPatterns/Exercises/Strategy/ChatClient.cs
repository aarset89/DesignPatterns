using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Strategy
{
    public class ChatClient
    {
        private IEncryptionAlgorithm _encryptionAlgorithm;

        public ChatClient(IEncryptionAlgorithm encryptionAlgorithm)
        {
            _encryptionAlgorithm = encryptionAlgorithm;
        }

        public void send(string message)
        {
            _encryptionAlgorithm.Encript(message);
        }
    }
}
