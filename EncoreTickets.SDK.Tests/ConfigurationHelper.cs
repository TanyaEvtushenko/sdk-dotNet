﻿using System.IO;
using Microsoft.Extensions.Configuration;

namespace EncoreTickets.SDK.Tests
{
    static class ConfigurationHelper
    {
        private static readonly object Lock = new object();
        private static IConfiguration Configuration;

        public static IConfiguration GetConfiguration()
        {
            lock (Lock)
            {
                return Configuration ?? (Configuration = BuildConfiguration());
            }
        }

        private static IConfiguration BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.test.json")
                .AddJsonFile("appsettings.test.real.json", optional: true);
            return builder.Build();
        }
    }
}