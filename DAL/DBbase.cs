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
        /// 查询方法，该方法返回查询匹配结果数
        /// </summary>
        /// <param name="strSQL">T-SQL命令文本字符串</param>
        /// <returns>匹配查询的结果数</returns>
        public int ReturnQueryResult(string strSQL)
        {
            chkConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                int CodeNum = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return CodeNum;
            }
            catch
            {
                con.Close();
                return 0;
            }
        }

        /// <summary>
        /// 行插入方法，该方法返回受影响的行数
        /// </summary>
        /// <param name="strSQL">T-SQL命令文本字符串</param>
        /// <returns>受影响的行数</returns>
        public int ReturnRegisterResult(string strSQL)
        {
            chkConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                int CodeNum = cmd.ExecuteNonQuery();
                con.Close();
                return CodeNum;
            }
            catch
            {
                con.Close();
                return 0;
            }
        }
    }
}
