using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Builder
{
    public interface IEmailBuilder
    {
        IEmailBuilder SetSender(string sender);
        IEmailBuilder SetRecipient(string recipient);
        IEmailBuilder SetSubject(string subject);
        IEmailBuilder SetBody(string body);
        Email Build();
    }

}
