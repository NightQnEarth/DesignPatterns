using System.Collections.Generic;

namespace EmailBuilder
{
    public interface IEmail
    {
        List<IRecipient> Recipients { get; }
        string Topic { get; }
        string Body { get; }
    }
}