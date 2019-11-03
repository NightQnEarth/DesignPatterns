using System;

namespace EncryptingDecorator
{
    static class Program
    {
        private static void Main()
        {
            var message = new Message
            {
                Author = "Denis",
                Recipient = "Andrei",
                Text = "Hello, world!"
            };

            var chatClient = new ChatClient();
            var chatClientWithEncryptedMessage = new EncryptMessageDecorator(chatClient);
            var chatClientWithEncryptedMessageAndAuthor = new EncryptAuthorDecorator(chatClientWithEncryptedMessage);

            var sentMessage = chatClientWithEncryptedMessageAndAuthor.SendMessage(message);
            var receivedMessage = chatClientWithEncryptedMessageAndAuthor.ReceiveMessage(sentMessage);

            Console.WriteLine(sentMessage);
            Console.WriteLine();
            Console.WriteLine(receivedMessage);

            /* Output:
             <encryptedMessage><encryptedAuthor>Denis</encryptedAuthor></encryptedMessage>
             <encryptedMessage>Andrei</encryptedMessage>
             <encryptedMessage>Hello, world!</encryptedMessage>

             <encryptedAuthor>Denis</encryptedAuthor>
             Andrei
             Hello, world!
            */
        }
    }
}