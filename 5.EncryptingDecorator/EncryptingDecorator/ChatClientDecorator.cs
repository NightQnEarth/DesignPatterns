namespace EncryptingDecorator
{
    public class ChatClientDecorator : IChatClient
    {
        private readonly IChatClient chatClient;

        protected ChatClientDecorator(IChatClient chatClient) => this.chatClient = chatClient;

        public virtual string SendMessage(IMessage message) => chatClient.SendMessage(message);

        public virtual IMessage ReceiveMessage(string message) => chatClient.ReceiveMessage(message);
    }
}