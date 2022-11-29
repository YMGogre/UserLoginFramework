using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAccess
    {
        //实例化DBbase 对象
        DBbase db = new DBbase();

        /// <summary>
        /// 数据访问层用户登陆方法，该方法生成 T-SQL 命令并使用命令调用查询方法
        /// </summary>
        /// <param name="name">用户名字符串</param>
        /// <param name="psw">密码字符串</param>
        /// <returns>匹配查询的结果数</returns>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="OverflowException"></exception>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        public int UserLogin(string name, string psw)
        {
            /**
             * T-SQL 查询语句：
             * SELECT <列名>
             * FROM <表名>
             * WHERE <查询限定条件>
             */
            string strsql = "select count(*) from UserAccount where Username = '" + name + "'and Password = '" + psw + "'";
            return db.ReturnQueryResult(strsql);
        }

        /// <summary>
        /// 数据访问层用户注册方法，该方法生成 T-SQL 命令并使用命令调用行插入方法
        /// </summary>
        /// <param name="name">用户名字符串</param>
        /// <param name="psw">密码字符串</param>
        /// <returns>执行行插入后表中受影响的行数</returns>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        public int UserRegistration(string name, string psw)
        {
            /**
             * T-SQL 插入语句：
             * INSERT <表名>(<列名1>,<列名2>,...)
             * VALUES(<值1>,<值2>,...)
             */
            string strsql = "insert UserAccount(Username, Password) values('" + name + "','" + psw + "')";
            return db.ReturnExecuteResult(strsql);
        }
    }
}
