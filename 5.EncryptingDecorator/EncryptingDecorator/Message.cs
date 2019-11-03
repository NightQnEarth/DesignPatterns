using System;

namespace EncryptingDecorator
{
    public class Message : IMessage
    {
        public string Author { get; set; }
        public string Recipient { get; set; }
        public string Text { get; set; }

        public override string ToString() => string.Join(Environment.NewLine, Author, Recipient, Text);
    }
}