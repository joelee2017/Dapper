using Common.Models;
using DataAccess.DbContext;
using DataAccess.Interface.DbContext;
using Microsoft.Extensions.Configuration;
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
        private IMovieDbContext _movieDbContext;

        public MoviesService(IMovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public IEnumerable<string> GenreQuery()
        {
             return _movieDbContext.MovieDbOperation.GenreQuery();
        }

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
