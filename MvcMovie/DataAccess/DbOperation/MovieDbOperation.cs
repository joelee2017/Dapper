using Common.Models;
using DataAccess.Interface;
using DataAccess.Interface.DbOperation;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace DataAccess.DbOperation
{
    public class MovieDbOperation : DbOperation<Movie>, IMovieDbOperation
    { 

        public MovieDbOperation(DbConnection connection) : base(connection)
        {

        }

        public bool Create(Movie movie)
        {
            string sql = @"insert into Movie (Title, ReleaseDate, Genre, Price, Rating)
                            values (@Title, @ReleaseDate, @Genre, @Price, @Rating)";

            return base.Create(sql, 
                new {   Title = movie.Title, 
                        ReleaseDate = movie.ReleaseDate, 
                        Genre = movie.Genre, 
                        Price = movie.Price, 
                        Rating = movie.Rating }) > 0;
        }

        public bool Delete(int id)
        {
            string sql = @"delete from Movie where Id = @Id";

            return base.Delete(sql, new { Id = id }) > 0;
        }

        public Movie Details(int id)
        {
            string sql = @"select * from Movie where Id = @Id";

            var result = base.Get(sql, new { Id = id });

            return result;
        }

        public bool Edit(Movie movie)
        {
            string sql = @"update Movie 
                            set Title = @Title, ReleaseDate = @ReleaseDate, Genre = @Genre, Price = @Price, Rating = @Rating 
                            where Id = @Id";

            return base.Update(sql,
                new
                {
                    Title = movie.Title,
                    ReleaseDate = movie.ReleaseDate,
                    Genre = movie.Genre,
                    Price = movie.Price,
                    Rating = movie.Rating,
                    Id = movie.Id
                }) > 0;
        }

        public IEnumerable<string> GenreQuery()
        {
            string sql = @"select distinct Genre from Movie order by Genre";

            return base.GetAll(sql).Select(s => s.Genre);
        }

        public IEnumerable<Movie> GetAll()
        {
            string sql = @"select * from Movie";

            return base.GetAll(sql);
        }

        public IEnumerable<Movie> Gets(string searchString)
        {
            string sql = @"select * from Movie where Tile LIKE '%@Tile%'";

            var result = base.GetList(sql, new { Title = searchString });

            return result;
        }
    }
}
