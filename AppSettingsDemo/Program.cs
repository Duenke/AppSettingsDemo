using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AppSettingsDemo
{
    public class Program
    {
        public static string env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(config =>
                {
                    // Baseline for .NetCore
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); // Adds these config variable values

                    // The file appsettings.Developement.json is applied by default when Debugging
                    config.AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true); // Adds environment specific config variable values on top of ^^

                    // Specifying another file after the above suerceeds all of them
                    config.AddJsonFile($"appsettings.AppSettingsDemo.json", optional: true, reloadOnChange: true); // Adds these config variable values on top of ^^

                    // This is only required if you specify any of the above
                    config.AddEnvironmentVariables(); // Adds Hosting service (aka: Azure Web App) config variable values on top of ^^

                    // ------------------------------------------------------------------------------------ //
                    // None of the above is necessary if you only need one Development set of config values //
                    // ------------------------------------------------------------------------------------ //
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

// ---------------------------------------------------------------------------------- //
// Example: Azure Web App > Configuration > Application Settings > Advanced Edit JSON //
// ---------------------------------------------------------------------------------- //

/*
[
  {
    "name": "GetSection",
    "value": "FAULTY",
    "slotSetting": false
  },
  {
    "name": "GetSection--GetSection-One",
    "value": "FAULTY",
    "slotSetting": false
  },
  {
    "name": "GetSection:GetSection-Nested:GetSection-Nested-One",
    "value": "GetSection-Nested-One from the portal configuration!",
    "slotSetting": false
  },
  {
    "name": "GetSection:GetSection-Nested:GetSection-Nested-Two",
    "value": "GetSection-Nested-Two from the portal configuration!",
    "slotSetting": false
  },
  {
    "name": "GetSection:GetSection-One",
    "value": "GetSection-One from the portal configuration!",
    "slotSetting": false
  },
  {
    "name": "GetSection:GetSection-Two",
    "value": "GetSection-Two from the portal configuration!",
    "slotSetting": false
  },
  {
    "name": "GetSection[GetSection-One]",
    "value": "FAULTY",
    "slotSetting": false
  },
  {
    "name": "GetValue",
    "value": "FAULTY",
    "slotSetting": false
  },
  {
    "name": "GetValue-Nested:GetValue-Nested-One",
    "value": "GetValue-Nested-One from the portal configuration!",
    "slotSetting": false
  },
  {
    "name": "GetValue-Nested:GetValue-Nested-Two",
    "value": "GetValue-Nested-Two from the portal configuration!",
    "slotSetting": false
  },
  {
    "name": "GetValue-One",
    "value": "GetValue-One from the portal configuration!",
    "slotSetting": false
  },
  {
    "name": "GetValue-Two",
    "value": "GetValue-Two from the portal configuration!",
    "slotSetting": false
  },
  {
    "name": "WEBSITE_NODE_DEFAULT_VERSION",
    "value": "6.9.1",
    "slotSetting": false
  }
]
*/
