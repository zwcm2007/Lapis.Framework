﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.EntityFrameworkCore.Shared
{
    /// <summary>
    /// SqlExecuter
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    public class SqlExecuter<TDbContext> : ISqlExecuter<TDbContext>, ITransientDependency
        where TDbContext : IEfCoreDbContext
    {
        private readonly IDbContextProvider<TDbContext> _dbContextProvider;

        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return _dbContextProvider.GetDbContext().Database.GetDbConnection().ConnectionString;
            }
        }

        /// <summary>
        /// 当前上下文
        /// </summary>
        public TDbContext CurrentDbContext => _dbContextProvider.GetDbContext();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbContextProvider"></param>
        public SqlExecuter(IDbContextProvider<TDbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        /// <summary>
        /// 执行给定的命令
        /// </summary>
        /// <param name="sql">命令字符串</param>
        /// <param name="parameters">要应用于命令字符串的参数</param>
        /// <returns>执行命令后由数据库返回的结果</returns>
        public int ExecuteSqlCommand(string sql, params object[] parameters)
        {
            return _dbContextProvider.GetDbContext().Database.ExecuteSqlRaw(sql, parameters);
        }

        /// <summary>
        /// 执行给定的命令
        /// </summary>
        /// <param name="sql">命令字符串</param>
        /// <param name="parameters">要应用于命令字符串的参数</param>
        /// <returns>执行命令后由数据库返回的结果</returns>
        public Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters)
        {
            return _dbContextProvider.GetDbContext().Database.ExecuteSqlRawAsync(sql, parameters);
        }

        /// <summary>
        /// 创建一个原始 SQL 查询，该查询将返回给定泛型类型的元素。
        /// </summary>
        /// <typeparam name="TEntity">查询所返回对象的类型</typeparam>
        /// <param name="sql">SQL 查询字符串</param>
        /// <param name="parameters">要应用于 SQL 查询字符串的参数</param>
        /// <returns></returns>
        public IQueryable<TEntity> Query<TEntity>(string sql, params object[] parameters) where TEntity : class
        {
            return _dbContextProvider.GetDbContext().Set<TEntity>().FromSqlRaw(sql, parameters);
        }

        /// <summary>
        /// 创建一个原始 SQL 查询，该查询将返回给定泛型类型的元素。
        /// </summary>
        /// <typeparam name="T">查询所返回对象的类型</typeparam>
        /// <param name="sql">SQL 查询字符串</param>
        /// <param name="parameters">要应用于 SQL 查询字符串的参数</param>
        /// <returns></returns>
        public List<T> QueryList<T>(string sql, params object[] parameters) where T : class, new()
        {
            return _dbContextProvider.GetDbContext().Database.SqlQuery<T>(sql, parameters);
        }

        /// <summary>
        /// 创建一个原始 SQL 查询，该查询将返回给定泛型类型的元素。
        /// </summary>
        /// <typeparam name="T">查询所返回对象的类型</typeparam>
        /// <param name="sql">SQL 查询字符串</param>
        /// <param name="parameters">要应用于 SQL 查询字符串的参数</param>
        /// <returns></returns>
        public Task<List<T>> QueryListAsync<T>(string sql, params object[] parameters) where T : class, new()
        {
            return _dbContextProvider.GetDbContext().Database.SqlQueryAsync<T>(sql, parameters);
        }

        /// <summary>
        /// 执行sql获取数据集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public DataTable QueryDataTable(string sql, params object[] parameters)
        {
            return _dbContextProvider.GetDbContext().Database.SqlQuery(sql, parameters);
        }

        /// <summary>
        /// 执行sql获取数据集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public Task<DataTable> QueryDataTableAsync(string sql, params object[] parameters)
        {
            return _dbContextProvider.GetDbContext().Database.SqlQueryAsync(sql, parameters);
        }

        //public object ExecuteProc(string procName, params DbParameter[] dbParameter)
        //{
        //    var cmd = _dbContextProvider.GetDbContext().Database.Connection.CreateCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = procName;
        //    if (dbParameter.Length > 0)
        //    {
        //        cmd.Parameters.AddRange(dbParameter);
        //    }
        //    //cmd.Connection.Open();

        //    int retCode = cmd.ExecuteNonQuery();

        //    var oParam = dbParameter[dbParameter.Length - 1];

        //    //cmd.Connection.Close();

        //    return oParam.Value;   //最后一个参数为输出参数
        //}
    }
}