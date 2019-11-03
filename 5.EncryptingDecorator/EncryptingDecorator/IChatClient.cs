namespace EncryptingDecorator
{
    public interface IChatClient
    {
        string SendMessage(IMessage message);
        IMessage ReceiveMessage(string message);
    }
}