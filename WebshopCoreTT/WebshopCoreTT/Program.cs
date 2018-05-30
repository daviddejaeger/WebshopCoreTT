using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebshopCoreTT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
        //Responsible for setup configuration and logging
        //Kestrel, IIS integration, configuration, ... is all handled by the CreateDefaultBuilder, 
        //read more at https://andrewlock.net/exploring-program-and-startup-in-asp-net-core-2-preview1-2/
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
