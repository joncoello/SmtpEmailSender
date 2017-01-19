﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmtpEmailSender.Api.Controllers
{
    [RoutePrefix("api/hello")]
    public class HelloController : ApiController
    {
        [Route("")]
        public string Get() {
            return "Hello World";
        }

    }
}
