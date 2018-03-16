using System;
using System.Messaging;

namespace EstudoMessageQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Receiver";
            string queueName = @".\private$\minhaQueue";
            MessageQueue queue = new MessageQueue(queueName);
            queue.Formatter = new XmlMessageFormatter(new[] { typeof(String) });

            while (true)
            {
                Message message = queue.Receive();
                Console.WriteLine("Recebido: {0}", message.Body);
            }
        }
    }
}
