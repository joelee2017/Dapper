using Business.Interface;
using Domain.Models;
using DataAccess.Interface.DbContext;
using System.Collections.Generic;

namespace Business.Service
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

        public bool Remove(int id)
        {
             return _movieDbContext.MovieDbOperation.Delete(id);
        }

        public Movie Details(int id)
        {
            return _movieDbContext.MovieDbOperation.Get(id);
        }

        public bool Exists(int id)
        {
            return _movieDbContext.MovieDbOperation.Get(id) != null;
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

        public bool Update(Movie movie)
        {
            return _movieDbContext.MovieDbOperation.Update(movie);
        }
    }
}
