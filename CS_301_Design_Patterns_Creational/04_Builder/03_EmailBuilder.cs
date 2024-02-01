using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Builder
{
    public class EmailBuilder : IEmailBuilder
    {
        private Email email = new Email();

        public IEmailBuilder SetSender(string sender)
        {
            email.Sender = sender;
            return this;
        }

        public IEmailBuilder SetRecipient(string recipient)
        {
            email.Recipient = recipient;
            return this;
        }

        public IEmailBuilder SetSubject(string subject)
        {
            email.Subject = subject;
            return this;
        }

        public IEmailBuilder SetBody(string body)
        {
            email.Body = body;
            return this;
        }

        public Email Build()
        {
            return email;
        }
    }

}
