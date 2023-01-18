using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOrbit.Greetings.EmailComponent.EmailComponent
{
    public static class GetRandomMessageAndPhoto
    {
        public static EmailMessage PickRandom<EmailMessage>(this IEnumerable<EmailMessage> emailMessage)
        {
            return emailMessage.PickRandom(1).Single();
        }

        public static IEnumerable<EmailMessage> PickRandom<EmailMessage>(this IEnumerable<EmailMessage> emailMessage, int count)
        {
            return emailMessage.Shuffle().Take(count);
        }

        public static IEnumerable<EmailMessage> Shuffle<EmailMessage>(this IEnumerable<EmailMessage> emailMessage)
        {
            return emailMessage.OrderBy(x => Guid.NewGuid());
        }
    }
}

