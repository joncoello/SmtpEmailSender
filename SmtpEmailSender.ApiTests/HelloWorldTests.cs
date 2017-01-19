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
            
            using (var serverAndClient = new HttpServerAndClient<Startup>())
            {
                
                var response = await serverAndClient.Client.GetAsync("/api/hello");

                response.EnsureSuccessStatusCode();

            }

        }


    }
}
