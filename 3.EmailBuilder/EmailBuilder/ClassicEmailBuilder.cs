using System;
using System.Collections.Generic;
using System.Linq;

namespace EmailBuilder
{
    public class ClassicEmailBuilder : IEmailBuilder
    {
        public IAdvancedEmailBuilder BuildBaseEmail(IRecipient recipient, string body) =>
            new AdvancedClassicEmailBuilder(new Email
            {
                Recipients = new List<IRecipient> { recipient },
                Body = body
            });

        private class AdvancedClassicEmailBuilder : IAdvancedEmailBuilder
        {
            private readonly Email builtEmail;

            public AdvancedClassicEmailBuilder(Email baseEmail) => builtEmail = baseEmail;

            public IEmail GetBuiltEmail => builtEmail;

            public IAdvancedEmailBuilder AddRecipient(IRecipient recipient)
            {
                builtEmail.Recipients.Add(recipient);
                return new AdvancedClassicEmailBuilder(builtEmail);
            }

            public IAdvancedEmailBuilder AddTopic(string topic)
            {
                builtEmail.Topic = topic;
                return new AdvancedClassicEmailBuilder(builtEmail);
            }
        }

        private class Email : IEmail
        {
            public List<IRecipient> Recipients { get; set; }
            public string Topic { get; set; }
            public string Body { get; set; }

            public override string ToString() => string.Join(
                Environment.NewLine,
                $"Recipients: {string.Join(' ', Recipients.Select(recipient => recipient.Name))}",
                Topic,
                Body);
        }
    }
}