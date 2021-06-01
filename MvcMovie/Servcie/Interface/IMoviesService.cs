using Domain.Models;
using System.Collections.Generic;

namespace Business.Interface
{
    public interface IMoviesService
    {
        /// <summary>
        /// 取得資料
        /// </summary>
        /// <param name="searchString">搜尋件條</param>   
        public IEnumerable<Movie> Gets(string searchString);

        /// <summary>
        /// 取得全部資料
        /// </summary>
        public IEnumerable<Movie> GetAll();

        /// <summary>
        /// 取得全部資料類型
        /// </summary>
        public IEnumerable<string> GenreQuery();

        /// <summary>
        /// 詳細資料
        /// </summary>
        /// <param name="id"></param>
        public Movie Details(int id);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="movie">資料</param>
        public bool Create(Movie movie);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="movie">資料</param>
        bool Update(Movie movie);

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="id"></param>
        bool Exists(int id);

        /// <summary>
        /// 刪除
        /// </summary>
        bool Remove(int id);
    }
}
