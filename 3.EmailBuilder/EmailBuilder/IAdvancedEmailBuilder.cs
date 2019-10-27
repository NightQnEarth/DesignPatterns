namespace EmailBuilder
{
    public interface IAdvancedEmailBuilder
    {
        IEmail GetBuiltEmail { get; }
        IAdvancedEmailBuilder AddRecipient(IRecipient recipient);
        IAdvancedEmailBuilder AddTopic(string topic);
    }
}