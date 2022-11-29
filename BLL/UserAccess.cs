using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserAccess
    {
        DAL.UserAccess d_userAccess = new DAL.UserAccess();

        /// <summary>
        /// 用户登录方法，获取显示层UserInfo类的对象并使用该对象的数据去调用数据访问层DAL.UserAccess类的对象的用户登陆方法
        /// </summary>
        /// <param name="m_userInfo">Model.UserInfo类的对象</param>
        /// <returns>数据库中已有数据与输入的账号密码相匹配的结果数</returns>
        public int UserLogin(Model.UserInfo m_userInfo)
        {
            return d_userAccess.UserLogin(m_userInfo.username, m_userInfo.password);
        }

        /// <summary>
        /// 用户注册方法，获取显示层UserInfo类的对象并使用该对象的数据去调用数据访问层DAL.UserAccess类的对象的用户注册方法
        /// </summary>
        /// <param name="m_userInfo">Model.UserInfo类的对象</param>
        /// <returns>注册新用户会向表中插入新行，该方法返回执行行插入后表中受影响的行数</returns>
        public int UserRegistration(Model.UserInfo m_userInfo)
        {
            return d_userAccess.UserRegistration(m_userInfo.username, m_userInfo.password);
        }
    }
}
