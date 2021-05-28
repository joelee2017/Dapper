using Common.Helper;
using DataAccess.DbOperation;
using DataAccess.Interface.DbContext;
using DataAccess.Interface.DbOperation;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbContext
{
    public class MovieDbContext : IMovieDbContext
    {
        private readonly Lazy<IMovieDbOperation> _movieDbOperation;
        public MovieDbContext() : this(ConnectionHpler.GetConnection(DBlist.MvcMovieContext))
        {

        }

        public MovieDbContext(DbConnection connection)
        {
            _movieDbOperation = new Lazy<IMovieDbOperation>(() => new MovieDbOperation(connection));
        }
    }
}
