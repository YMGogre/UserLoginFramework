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
        /// 数据访问层用户登陆方法，该方法生成T-SQL命令并使用命令调用查询方法
        /// </summary>
        /// <param name="name">用户名字符串</param>
        /// <param name="psw">密码字符串</param>
        /// <returns>匹配查询的结果数</returns>
        public int UserLogin(string name, string psw)
        {
            string strsql = "select count(*) from UserAccount where Username = '" + name + "'and Password = '" + psw + "'";
            return db.ReturnQueryResult(strsql);
        }

        /// <summary>
        /// 数据访问层用户注册方法，该方法生成T-SQL命令并使用命令调用注册方法
        /// </summary>
        /// <param name="name">用户名字符串</param>
        /// <param name="psw">密码字符串</param>
        /// <returns>执行行插入后表中受影响的行数</returns>
        public int UserRegistration(string name, string psw)
        {
            string strsql = "insert UserAccount(Username, Password) values('" + name + "','" + psw + "')";
            return db.ReturnRegisterResult(strsql);
        }
    }
}
