using System;

namespace EmailBuilder
{
    static class Program
    {
        private static void Main()
        {
            var emailBuilder = new ClassicEmailBuilder();
            var email = BuildEmail(emailBuilder);

            Console.WriteLine(email);
        }

        private static IEmail BuildEmail(IEmailBuilder anyEmailBuilder) =>
            anyEmailBuilder.BuildBaseEmail(new Recipient("Andrei"), "body content")
                           .AddTopic("Example email")
                           .AddRecipient(new Recipient("Evgeniy"))
                           .GetBuiltEmail;
    }
}