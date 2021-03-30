using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.EntityFrameworkCore.Shared
{
    /// <summary>
    /// ISqlExecuter
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    public interface ISqlExecuter<out TDbContext> where TDbContext : IEfCoreDbContext
    {
        /// <summary>
        /// 当前上下文
        /// </summary>
        TDbContext CurrentDbContext { get; }

        /// <summary>
        /// 执行给定的命令
        /// </summary>
        /// <param name="sql">命令字符串</param>
        /// <param name="parameters">要应用于命令字符串的参数</param>
        /// <returns>执行命令后由数据库返回的结果</returns>
        int ExecuteSqlCommand(string sql, params object[] parameters);

        /// <summary>
        /// 执行给定的命令
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters);

        /// <summary>
        /// 创建一个原始 SQL 查询，该查询将返回给定泛型类型的元素。
        /// </summary>
        /// <typeparam name="T">查询所返回对象的类型</typeparam>
        /// <param name="sql">SQL 查询字符串</param>
        /// <param name="parameters">要应用于 SQL 查询字符串的参数</param>
        /// <returns></returns>
        List<T> QueryList<T>(string sql, params object[] parameters) where T : class, new();

        /// <summary>
        /// 创建一个原始 SQL 查询，该查询将返回给定泛型类型的元素。
        /// </summary>
        /// <typeparam name="T">查询所返回对象的类型</typeparam>
        /// <param name="sql">SQL 查询字符串</param>
        /// <param name="parameters">要应用于 SQL 查询字符串的参数</param>
        /// <returns></returns>
        Task<List<T>> QueryListAsync<T>(string sql, params object[] parameters) where T : class, new();

        /// <summary>
        /// 创建一个原始 SQL 查询，该查询将返回给定泛型类型的元素。
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IQueryable<TEntity> Query<TEntity>(string sql, params object[] parameters) where TEntity : class;


        /// <summary>
        /// 创建一个返回DataTable类型的数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        DataTable QueryDataTable(string sql, params object[] parameters);


        /// <summary>
        /// 创建一个返回DataTable类型的数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        Task<DataTable> QueryDataTableAsync(string sql, params object[] parameters);

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="dbParameter"></param>
        /// <returns></returns>
        //object ExecuteProc(string procName, params DbParameter[] dbParameter);


    }
}