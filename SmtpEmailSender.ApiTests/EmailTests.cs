using SmtpEmailSender.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SmtpEmailSender.ApiTests
{
    public class EmailTests
    {
        [Fact]
        public async Task Email_Post() {

            using (var serverAndClient = new HttpServerAndClient<Startup>())
            {

                var response = await serverAndClient.Client.PostAsJsonAsync("/api/email", new { });

                response.EnsureSuccessStatusCode();

            }

        }
    }
}
