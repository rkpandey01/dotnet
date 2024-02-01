using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Builder
{
    public class Email
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        // Additional properties can be added as needed.

        public override string ToString()
        {
            return $"From: {Sender}, To: {Recipient}, Subject: {Subject}, Body: {Body}";
        }
    }

}
