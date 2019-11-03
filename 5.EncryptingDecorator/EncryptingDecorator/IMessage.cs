namespace EncryptingDecorator
{
    public interface IMessage
    {
        string Author { get; set; }
        string Recipient { get; set; }
        string Text { get; set; }
    }
}