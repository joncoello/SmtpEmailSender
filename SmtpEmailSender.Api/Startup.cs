﻿using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SmtpEmailSender.Api
{
    public class Startup
    {

        public void Configuration(IAppBuilder app) {

            var config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);

        }

    }
}