using Domain.Models;
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

        /// <summary>
        /// 取得全部資料
        /// </summary>
        IEnumerable<Movie> GetAll();

        /// <summary>
        /// 取得全部類型
        /// </summary>        
        IEnumerable<string> GenreQuery();

        /// <summary>
        /// 取得單筆資料
        /// </summary>   
        Movie Get(int id);

        /// <summary>
        /// 新增
        /// </summary>
        bool Create(Movie movie);

        /// <summary>
        /// 更新
        /// </summary>
        bool Update(Movie movie);

        /// <summary>
        /// 刪除
        /// </summary>
        bool Delete(int id);
    }
}
