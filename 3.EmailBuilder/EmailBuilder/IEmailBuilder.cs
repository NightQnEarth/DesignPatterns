namespace EmailBuilder
{
    public interface IEmailBuilder
    {
        IAdvancedEmailBuilder BuildBaseEmail(IRecipient recipient, string body);
    }
}