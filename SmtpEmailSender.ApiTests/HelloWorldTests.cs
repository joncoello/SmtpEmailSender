using Microsoft.Owin.Hosting;
using SmtpEmailSender.Api;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using Xunit;

namespace SmtpEmailSender.ApiTests
{
    public class HelloWorldTests
    {
        [Fact]
        public async Task HelloWorld_Get()
        {

            var l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            
            string address = "http://localhost:" + port.ToString();

            using (var server = WebApp.Start<Startup>(address))
            {
                
                var client = new HttpClient();
                client.BaseAddress = new Uri(address);

                var response = await client.GetAsync("/api/hello");

                response.EnsureSuccessStatusCode();

            }

        }
    }
}
