using System;
using System.Collections.Generic;
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
            return Ok();
        }

    }
}
