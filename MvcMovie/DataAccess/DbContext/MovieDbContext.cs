using Common.Helper;
using DataAccess.DbOperation;
using DataAccess.Interface.DbContext;
using DataAccess.Interface.DbOperation;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.Common;

namespace DataAccess.DbContext
{
    public class MovieDbContext : IMovieDbContext
    {
        private readonly Lazy<IMovieDbOperation> _movieDbOperation;
        public MovieDbContext(IConfiguration configuration) :
            this(ConnectionHpler.GetConnection(configuration.GetConnectionString("MvcMovieContext")))
        {

        }

        public MovieDbContext(DbConnection connection)
        {
            _movieDbOperation = new Lazy<IMovieDbOperation>(() => new MovieDbOperation(connection));
        }

        public IMovieDbOperation MovieDbOperation => _movieDbOperation.Value;
    }
}
