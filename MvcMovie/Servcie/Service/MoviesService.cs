using Common.Models;
using DataAccess.DbContext;
using Servcie.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servcie.Service
{
    public class MoviesService : IMoviesService
    {
        private MovieDbContext _movieDbContext;

        public IEnumerable<Movie> GetAll()
        {
            return _movieDbContext.MovieDbOperation.GetAll();
        }

        public IEnumerable<Movie> Gets(string searchString)
        {
            return _movieDbContext.MovieDbOperation.Gets(searchString);
        }
    }
}
