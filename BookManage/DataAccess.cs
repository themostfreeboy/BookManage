using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
//using System.Windows.Forms;

namespace BookManage
{
    class DataAccess
    {
        private static string ConnectString = "server=JXL-PC\\SQLEXPRESS;database=BookManage;Trusted_Connection=Yes";//数据库连接字符串
        /// <summary>
        /// 根据表名获取数据集的表
        /// </summary>
        /// <param name="table">表名</param>
        /// <returns> DataTable </returns>
        public static DataTable GetDataSetByTableName(string table)
        {
            using(SqlConnection con = new SqlConnection(ConnectString))//创建数据库连接对象
            {
                string sql = "select * from " + table + "";//查询sql语句
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);//创建适配器对象
                    DataSet ds = new DataSet();//创建数据集对象
                    adapter.Fill(ds, "table");//填充数据集
                    return ds.Tables[0];//返回数据表
                }
                catch (SqlException ex)//异常处理
                {
                    //MessageBox.Show(ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// 根据sql语句获取数据集对象
        /// </summary>
        /// <param name="sql">sql</param>
        /// <returns> DataSet </returns>
        public static DataSet GetDataSetBySql(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))//创建数据库连接对象
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);//创建适配器对象
                DataSet ds = new DataSet();//创建数据集对象
                try
                {                    
                    adapter.Fill(ds);//填充数据集
                    return ds;//返回数据表
                }
                catch (SqlException ex)//异常处理
                {
                    //MessageBox.Show(ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// 根据id值获取DataReader对象
        /// </summary>
        /// <param name="id">id</param>
        /// <returns> SqlDataReader </returns>
        public static SqlDataReader GetSqlDataReaderByID(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))//创建数据库连接对象
            {
                string sql = "select * from bookinfo where BookID=" + id;//sql语句
                try
                {
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    con.Open();//打开连接
                    SqlDataReader reader = comm.ExecuteReader();//创建DataReader对象
                    reader.Read();//读取数据
                    return reader;//返回DataReader
                }
                catch (SqlException ex)//异常处理
                {
                    //MessageBox.Show(ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sql">sql</param>
        /// <returns> bool </returns>
        public static bool UpdateDataTable(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))//创建数据库连接对象
            {
                try
                {
                    con.Open();//打开连接
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    if (comm.ExecuteNonQuery() > 0)//执行更新
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException ex)//异常处理
                {
                    //MessageBox.Show(ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// 根据数据集和sql语句更新数据库
        /// </summary>
        /// <param name="ds","sql">ds,sql</param>
        /// <returns></returns>
        public static void UpdateDataSet(DataSet ds, string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))//创建数据库连接对象
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);//创建适配器对象
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//根据适配器自动生成表单
                    adapter.Update(ds, "table");//更新数据库
                }
                catch (SqlException ex)//异常处理
                {
                    //MessageBox.Show(ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
