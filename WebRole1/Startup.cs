﻿using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;

[assembly: OwinStartup(typeof(WebRole1.Startup))]

namespace WebRole1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
