
  
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Squidex.ClientLibrary;

namespace IO.Swagger.Model
{
    public static class SquidexParser
    {
        public static QueryContext DefaultContext(string lang)
        {
            var result = QueryContext.Default
                .Flatten()
                .WithLanguages(lang)
                .Unpublished(false);
            return result;
        }

        public static SquidexOptions ToSquidexOptions(this IConfiguration configuration)
        {
            var squidexOptions = new SquidexOptions
            {
                AppName = configuration["Squidex:AppName"],
                ClientId = configuration["Squidex:ClientId"],
                ClientSecret = configuration["Squidex:ClientSecret"],
                Url = configuration["Squidex:Url"]
            };
            return squidexOptions;
        }
    }
}