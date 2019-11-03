using System;

namespace EncryptingDecorator
{
    public class ChatClient : IChatClient
    {
        public string SendMessage(IMessage message) => message.ToString();

        public IMessage ReceiveMessage(string messages)
        {
            var messageParts = messages.Split(Environment.NewLine);

            return new Message
            {
                Author = messageParts[0],
                Recipient = messageParts[1],
                Text = messageParts[2]
            };
        }
    }
}