using Common.Models;
using DataAccess.Interface;
using DataAccess.Interface.DbOperation;
using System.Collections.Generic;
using System.Data.Common;

namespace DataAccess.DbOperation
{
    public class MovieDbOperation : DbOperation<Movie>, IMovieDbOperation
    { 
        public MovieDbOperation(DbConnection connection) : base(connection)
        {

        }

        public IEnumerable<Movie> Gets(string searchString)
        {
            throw new System.NotImplementedException();
        }
    }
}
