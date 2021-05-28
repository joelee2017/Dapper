using Dapper;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public abstract class DbOperation<T> where T : new()
    {
        private readonly DbConnection _connection;

        public DbOperation(DbConnection connection)
        {
            _connection = connection;
        }

        /// <summary>
        /// 取得第一筆資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual T Get(string sqlString, object param)
        {
            return _connection.QueryFirstOrDefault<T>(sqlString, param);
        }

        /// <summary>
        /// 非同步取得第一筆資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual Task<T> GetAsync(string sqlString, object param)
        {
            return _connection.QueryFirstOrDefaultAsync<T>(sqlString, param);
        }

        /// <summary>
        /// 取得篩選後資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual IEnumerable<T> GetList(string sqlString, object param)
        {
            return _connection.Query<T>(sqlString, param);
        }

        /// <summary>
        /// 非同步取得篩選後資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual Task<IEnumerable<T>> GetListAsync(string sqlString, object param)
        {
            return _connection.QueryAsync<T>(sqlString, param);
        }

        /// <summary>
        /// 取得Table全部資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <returns></returns>
        protected virtual IEnumerable<T> GetAll(string sqlString)
        {
            return _connection.Query<T>(sqlString);
        }

        /// <summary>
        /// 非同步取得Table全部資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <returns></returns>
        protected virtual Task<IEnumerable<T>> GetAllAsync(string sqlString)
        {
            return _connection.QueryAsync<T>(sqlString);
        }

        /// <summary>
        /// 取得第一列第一欄資料
        /// </summary>
        /// <typeparam name="TResult">回傳型別</typeparam>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual TResult ExecuteScalar<TResult>(string sqlString, object param)
        {
            return _connection.ExecuteScalar<TResult>(sqlString, param);
        }

        /// <summary>
        /// 非同步取得第一列第一欄資料
        /// </summary>
        /// <typeparam name="TResult">回傳型別</typeparam>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual Task<TResult> ExecuteScalarAsync<TResult>(string sqlString, object param)
        {
            return _connection.ExecuteScalarAsync<TResult>(sqlString, param);
        }

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual int Create(string sqlString, object param)
        {
            return _connection.Execute(sqlString, param);
        }

        /// <summary>
        /// 非同步新增資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual Task<int> CreateAsync(string sqlString, object param)
        {
            return _connection.ExecuteAsync(sqlString, param);
        }

        /// <summary>
        /// 修改資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual int Update(string sqlString, object param)
        {
            return _connection.Execute(sqlString, param);
        }

        /// <summary>
        /// 非同步修改資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual Task<int> UpdateAsync(string sqlString, object param)
        {
            return _connection.ExecuteAsync(sqlString, param);
        }

        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual int Delete(string sqlString, object param)
        {
            return _connection.Execute(sqlString, param);
        }

        /// <summary>
        /// 非同步刪除資料
        /// </summary>
        /// <param name="sqlString">Sql字串</param>
        /// <param name="param">Sql字串中parameter參數</param>
        /// <returns></returns>
        protected virtual Task<int> DeleteAsync(string sqlString, object param)
        {
            return _connection.ExecuteAsync(sqlString, param);
        }
    }
}
