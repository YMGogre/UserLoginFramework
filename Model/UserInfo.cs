using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 实体层提供其他三层数据传输的载体
    /// </summary>
    public class UserInfo
    {
        private string _username;
        private string _password;

        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
    }
}
