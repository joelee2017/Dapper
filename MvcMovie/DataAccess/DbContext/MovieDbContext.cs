using DataAccess.DbOperation;
using DataAccess.Helper;
using DataAccess.Interface.DbContext;
using DataAccess.Interface.DbOperation;
using System;
using System.Data.Common;

namespace DataAccess.DbContext
{
    public class MovieDbContext : IMovieDbContext
    {
        private readonly Lazy<IMovieDbOperation> _movieDbOperation;
        public MovieDbContext() : this(ConnectionHpler.GetConnection(ConnectionString.Get()))
        {

        }

        public MovieDbContext(DbConnection connection)
        {
            _movieDbOperation = new Lazy<IMovieDbOperation>(() => new MovieDbOperation(connection));
        }

        public IMovieDbOperation MovieDbOperation => _movieDbOperation.Value;
    }
}
