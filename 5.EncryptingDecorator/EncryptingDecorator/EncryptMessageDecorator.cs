using System.Text.RegularExpressions;

namespace EncryptingDecorator
{
    public class EncryptMessageDecorator : ChatClientDecorator
    {
        public EncryptMessageDecorator(IChatClient chatClient) : base(chatClient) { }

        public override string SendMessage(IMessage message)
        {
            message.Author = $"<encryptedMessage>{message.Author}</encryptedMessage>";
            message.Recipient = $"<encryptedMessage>{message.Recipient}</encryptedMessage>";
            message.Text = $"<encryptedMessage>{message.Text}</encryptedMessage>";

            return base.SendMessage(message);
        }

        public override IMessage ReceiveMessage(string message)
        {
            var encryptedMessage = base.ReceiveMessage(message);

            return new Message
            {
                Author = ContentDecode(encryptedMessage.Author),
                Recipient = ContentDecode(encryptedMessage.Recipient),
                Text = ContentDecode(encryptedMessage.Text)
            };

            static string ContentDecode(string content)
            {
                var contentDecoder = new Regex(@"<encryptedMessage>(?<content>.*)</encryptedMessage>");
                return contentDecoder.Match(content).Groups["content"].Value;
            }
        }
    }
}