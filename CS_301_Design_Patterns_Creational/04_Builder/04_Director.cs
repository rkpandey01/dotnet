using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Builder
{
    public class EmailDirector
    {
        public Email ConstructEmail(IEmailBuilder builder, string sender, string recipient, string subject, string body)
        {
            return builder.SetSender(sender)
                          .SetRecipient(recipient)
                          .SetSubject(subject)
                          .SetBody(body)
                          .Build();
        }
    }

}
