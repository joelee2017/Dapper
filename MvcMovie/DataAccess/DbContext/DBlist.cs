using Microsoft.Extensions.Configuration;
using System.IO;

namespace DataAccess.DbContext
{

    public class DBlist
    {
        private static IConfiguration _configuration;

        public DBlist()
        {
            var builder = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json");

            _configuration = builder.Build();
        }

        public static readonly string MvcMovieContext = _configuration.GetConnectionString("MvcMovieContext");

    }
}
