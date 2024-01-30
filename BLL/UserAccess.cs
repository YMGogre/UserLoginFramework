using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 用户访问的业务逻辑层，该层对于显示层(UI)给的用户名和密码数据不做任何处理直接传递给数据访问层
    /// 因为UI层通过限制点击操作保证了输入栏中的用户名和密码是符合规范的，所以该层不再做处理。
    /// 当然，有需要的话可以在该层添加一些处理逻辑。
    /// </summary>  
    public class UserAccess
    {
        DAL.UserAccess d_userAccess = new DAL.UserAccess();

        /// <summary>
        /// 用户登录方法，获取显示层 <see cref="Model.UserInfo"/> 类的对象并使用该对象的数据去调用数据访问层 <see cref="DAL.UserAccess"/> 类的对象的用户登陆方法
        /// </summary>
        /// <param name="m_userInfo"><see cref="Model.UserInfo"/> 类的对象</param>
        /// <returns>数据库中已有数据与输入的账号密码相匹配的结果数</returns>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="OverflowException"></exception>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        public int UserLogin(Model.UserInfo m_userInfo)
        {
            //return d_userAccess.UserLogin(m_userInfo.username, m_userInfo.password);
            // 参数化查询登录
            return d_userAccess.ParameterizedQueryUserLogin(m_userInfo);
        }

        /// <summary>
        /// 用户注册方法，获取显示层 <see cref="Model.UserInfo"/> 类的对象并使用该对象的数据去调用数据访问层 <see cref="DAL.UserAccess"/> 类的对象的用户注册方法
        /// </summary>
        /// <param name="m_userInfo"><see cref="Model.UserInfo"/> 类的对象</param>
        /// <returns>注册新用户会向表中插入新行，该方法返回执行行插入后表中受影响的行数</returns>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        public int UserRegistration(Model.UserInfo m_userInfo)
        {
            //return d_userAccess.UserRegistration(m_userInfo.username, m_userInfo.password);
            // 参数化查询注册
            return d_userAccess.ParameterizedQueryUserRegistration(m_userInfo.username, m_userInfo.password);
        }
    }
}
