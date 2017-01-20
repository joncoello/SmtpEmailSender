using SmtpEmailSender.DomainModel.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SmtpEmailSender.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            var smtpClient = new SmtpEmailProvider();
            smtpClient.Send(password);

        }
    }
}
