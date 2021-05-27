using Common.Models;
using System.Collections.Generic;

namespace DataAccess.Interface.DbOperation
{
    public interface IMovieDbOperation
    {
        /// <summary>
        /// 取得資料
        /// </summary>
        /// <param name="searchString">搜尋件條</param>        
        IEnumerable<Movie> Gets(string searchString);
    }
}
