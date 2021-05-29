using Common.Models;
using DataAccess.Interface.DbContext;
using Servcie.Interface;
using System.Collections.Generic;

namespace Servcie.Service
{
    public class MoviesService : IMoviesService
    {
        private IMovieDbContext _movieDbContext;

        public MoviesService(IMovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public bool Create(Movie movie)
        {
            return _movieDbContext.MovieDbOperation.Create(movie);
        }

        public Movie Details(int id)
        {
           return _movieDbContext.MovieDbOperation.Details(id);
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
