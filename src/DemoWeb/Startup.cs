﻿using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace DemoWeb
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			
        }

        public void Configure(IApplicationBuilder app)
        {
			//app.Run(async ctx =>
			//{
			//	ctx.Response.ContentType = "text/plain";
			//	await ctx.Response.WriteAsync(
			//	   "Pozdrav MSNetwork. Sada smo: " +
			//	   DateTime.Now);
			//});
			app.UseWelcomePage();
		}
    }
}
