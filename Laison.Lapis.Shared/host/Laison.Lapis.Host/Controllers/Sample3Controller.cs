using Laison.Lapis.HttpApi.Shared;
using Laison.Lapis.Shared.DB;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.OleDb;

namespace Laison.Lapis.Host
{
    [Route("api/sample3")]
    [ApiExplorerSettings(GroupName = "User")]
    public class Sample3Controller : LapisController
    {
        //public string connStr = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=d:\FileScanData.mdb;Provider=SQLOLEDB";

        public string connStr = @"Provider =Microsoft.ACE.OLEDB.12.0;Data Source = d:\FileScanData.mdb";

        public Sample3Controller()
        {
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        [HttpGet("")]
        public void BatchInsertAsync()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                for (int i = 0; i < 100; i++)
                {
                    int n = AccessHelper.ExecuteNonQuery(conn, "insert into dajg_base(lsh,dhdm) values('222','333')");
                }
            }
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        [HttpGet("Trans")]
        public void BatchInsertAsync2()
        {
            var conn = new OleDbConnection(connStr);
            conn.Open();
            var trans = conn.BeginTransaction();
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    int n = AccessHelper.ExecuteNonQuery(trans, "insert into dajg_base(lsh,dhdm) values('222','333')");
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        [HttpGet("Trans2")]
        public void BatchInsertAsync3()
        {
            AccessHelper.ExecuteTransaction(connStr, (cmd) =>
            {
                for (int i = 0; i < 100; i++)
                {
                    cmd.CommandText = "insert into dajg_base(lsh,dhdm) values('222','333')";
                    cmd.ExecuteNonQuery();
                    throw new Exception("fdfaf");
                }
            });
        }
    }
}