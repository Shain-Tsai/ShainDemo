using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using CloudServicePlatform.Api.Context;

[assembly: FunctionsStartup(typeof(CloudServicePlatform.Api.Startup))]
namespace CloudServicePlatform.Api
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string SqlConnection = Environment.GetEnvironmentVariable("SqlConnectionString");
            builder.Services.AddDbContext<CSPV2Context>(options => options.UseSqlServer(SqlConnection));
        }
    }
}