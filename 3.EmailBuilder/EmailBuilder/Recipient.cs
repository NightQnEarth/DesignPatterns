namespace EmailBuilder
{
    public class Recipient : IRecipient
    {
        public Recipient(string name) => Name = name;

        public string Name { get; }
    }
}