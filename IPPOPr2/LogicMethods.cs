using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace IPPOPr2
{
    internal class LogicMethods
    {
        public static async Task SendEmailAsync(MailMessage message, SmtpClient client)
        {
            await client.SendMailAsync(message);
            MessageBox.Show("Sent");
        }
    }
}
