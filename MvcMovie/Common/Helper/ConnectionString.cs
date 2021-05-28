using Microsoft.Extensions.Configuration;
using System.IO;

namespace Common.Helper
{
    public static class ConnectionString
    {
        private static IConfiguration _configuration;      

        public static string Get(string name = "MvcMovieContext")
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json");

            _configuration = builder.Build();

            string con = _configuration.GetConnectionString(name);
            return con;
        }
    }
}
