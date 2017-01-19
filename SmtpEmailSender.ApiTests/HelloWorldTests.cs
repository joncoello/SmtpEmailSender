using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SmtpEmailSender.ApiTests
{
    public class HelloWorldTests
    {
        [Fact]
        public async Task HelloWorld_Get()
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8099");

            var response = await client.GetAsync("/api/hello");

            response.EnsureSuccessStatusCode();
            
        }
    }
}
