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

            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("joncoello@gmail.com", password);

            try
            {
                // Create instance of message
                MailMessage message = new MailMessage();

                // Add receiver
                message.To.Add("jon.coello@wolterskluwer.com");

                // Set sender
                // In this case the same as the username
                message.From = new MailAddress("joncoello@gmail.com");

                // Set subject
                message.Subject = "Test";

                // Set body of message
                message.Body = "En test besked";

                // Send the message
                client.Send(message);

                // Clean up
                message = null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not send e-mail. Exception caught: " + e);
            }

        }
    }
}
