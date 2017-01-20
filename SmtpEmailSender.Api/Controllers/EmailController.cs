using SmtpEmailSender.DomainModel.Providers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SmtpEmailSender.Api.Controllers
{
    [RoutePrefix("api/email")]
    public class EmailController : ApiController
    {

        [Route("")]
        public async Task<IHttpActionResult> Post() {

            try
            {
                var password = ConfigurationManager.ConnectionStrings["SmtpPassword"].ConnectionString;
                var smtpClient = new SmtpEmailProvider();
                await smtpClient.Send(password);
                
                return Ok();
            }
            catch (Exception ex)
            {
                // logging
                return InternalServerError(ex);
            }
            
        }

    }
}
