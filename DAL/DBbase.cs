using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBbase
    {
        //读取配置文件 连接数据库语句(已弃用)
        //public static string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["ControlProgram.Properties.Settings.UserDatabaseConnectionString"].ConnectionString;

        //连接字符串
        public static string strCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DAL\\DataBase\\UserDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        //实例化连接对象 con
        SqlConnection con = new SqlConnection(strCon);

        /// <summary>
        /// 检测连接是否打开，如果没打开则打开连接
        /// </summary>
        public void chkConnection()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        /// <summary>
        /// 执行查询，并返回由查询返回的结果集中的第一行的第一列对象转换得到的 <see langword="int"/> 类型对象。
        /// </summary>
        /// <param name="strSQL">T-SQL 命令文本字符串</param>
        /// <returns>由查询返回的结果集中的第一行的第一列对象转换得到的 <see langword="int"/> 类型对象。如果结果集为 <see langword="null"/>，则为零</returns>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="OverflowException"></exception>
        /// <exception cref="SqlException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        public int ReturnQueryResult(string strSQL)
        {
            chkConnection();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //参考：<https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.executescalar?view=dotnet-plat-ext-8.0>
            int CodeNum = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return CodeNum;
        }

        /// <summary>
        /// 对连接执行 Transact-SQL 语句并返回受影响的行数
        /// </summary>
        /// <param name="strSQL">T-SQL命令文本字符串</param>
        /// <returns>受影响的行数</returns>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="SqlException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        public int ReturnExecuteResult(string strSQL)
        {
            chkConnection();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //参考：<https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.executenonquery?view=dotnet-plat-ext-8.0>
            int CodeNum = cmd.ExecuteNonQuery();
            con.Close();
            return CodeNum;
        }
    }
}
