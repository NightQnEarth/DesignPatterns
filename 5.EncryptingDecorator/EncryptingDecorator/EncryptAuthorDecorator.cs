namespace EncryptingDecorator
{
    public class EncryptAuthorDecorator : ChatClientDecorator
    {
        public EncryptAuthorDecorator(IChatClient chatClient) : base(chatClient) { }

        public override string SendMessage(IMessage message)
        {
            message.Author = $"<encryptedAuthor>{message.Author}</encryptedAuthor>";
            return base.SendMessage(message);
        }
    }
}