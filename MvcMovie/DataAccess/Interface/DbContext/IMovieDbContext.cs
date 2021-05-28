using DataAccess.Interface.DbOperation;

namespace DataAccess.Interface.DbContext
{
    public interface IMovieDbContext
    {
        public IMovieDbOperation MovieDbOperation { get; }
    }
}
