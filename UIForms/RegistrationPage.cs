using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginFramework
{
    public partial class RegistrationPage : Form
    {
        //实例化Model层中UserInfo类用于传递数据
        Model.UserInfo m_userInfo = new Model.UserInfo();
        //实例化BLL层中 UserAccess类用于衔接用户输入与数据库匹配
        BLL.UserAccess b_userAccess = new BLL.UserAccess();

        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //将用户输入的账号密码 赋值给UserInfo类 username、password属性
            m_userInfo.username = tbUserNameRegister.Text.Trim();
            m_userInfo.password = tbPasswordRegister.Text.Trim();

            try
            {
                //如果BLL层中 useRegistration调用返回记录条数 大于1 则注册成功
                if (b_userAccess.UserRegistration(m_userInfo) > 0)
                {
                    if(MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("注册失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlex)
            {
                //参考：<https://learn.microsoft.com/zh-cn/sql/relational-databases/errors-events/database-engine-events-and-errors?view=sql-server-ver15>
                if (sqlex.Number == 2627)
                    MessageBox.Show("该用户名已存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// "用户名"栏文本改变时发生调用
        /// "注册"按钮设计的核心是：“什么时候用户能点"注册"按钮？”当且仅当用户名栏有内容、两个密码栏有内容且匹配时才可以。
        /// 所以这三个文本框中任意一个文本发生改变时都会做这两个条件判断，只有满足时才激活"注册"按钮，其余情况都不激活。
        /// 当然还有另外一种设计核心是："注册"按钮长期处于激活状态，每当用户点击按钮时做以上两点的检查。那样设计的话代码还可以更简化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbUserNameRegister_TextChanged(object sender, EventArgs e)
        {
            if (tbUserNameRegister.Text.Any())                //当用户栏有内容时
            {
                label_NullUserNameWarning.Visible = false;
                if (tbPasswordRegister.Text.Any() && tbPasswordRegister.Text == tbPasswordRepeat.Text)   //且密码栏有内容还匹配时 
                {
                    btnRegister.Enabled = true;                 //激活"注册"按钮
                }
            }
            else
            {
                label_NullUserNameWarning.Visible = true;
                btnRegister.Enabled = false;
            }
        }

        /// <summary>
        /// "密码"栏文本改变时发生调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPasswordRegister_TextChanged(object sender, EventArgs e)
        {
            if (tbPasswordRegister.Text.Any())                  //注册页面密码栏有内容时，不显示空密码警告并进行匹配检查
            {
                label_NullPasswordWarning.Visible = false;
                if (tbPasswordRepeat.Text.Any() && tbPasswordRegister.Text != tbPasswordRepeat.Text)                //若"重复密码"栏有内容但两次密码不匹配
                {
                    label_attention.Visible = true;             //提示两次密码不匹配信息
                    btnRegister.Enabled = false;                //失效"注册"按钮
                }
                else if (tbPasswordRegister.Text == tbPasswordRepeat.Text)                                          //若两次密码匹配
                {
                    label_attention.Visible = false;
                    if (tbUserNameRegister.Text.Any())          //当且仅当密码栏有内容，两次输入的密码匹配，且用户名栏有内容时
                    {
                        btnRegister.Enabled = true;             //激活"注册"按钮
                    }
                }
                else                                                                                                //若"重复密码"栏没有内容
                {
                    label_attention.Visible = false;
                    btnRegister.Enabled = false;
                }
            }
            else                                                //注册页面密码栏没有内容时
            {
                label_NullPasswordWarning.Visible = true;       //弹出空密码警告
                btnRegister.Enabled = false;                    //失效"注册"按钮
            }
        }

        /// <summary>
        /// "重复密码"栏文本改变时发生调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            if (tbPasswordRepeat.Text.Any())                                      //当注册界面"重复密码"栏有内容时
            {
                if (tbPasswordRegister.Text != tbPasswordRepeat.Text)
                {       //若两次输入的密码不一致，显示label_attention("两次输入的密码不一致"提示语)且失效"注册"按钮
                    label_attention.Visible = true;
                    btnRegister.Enabled = false;
                }
                else                                                                        //若两次输入的密码一致
                {
                    label_attention.Visible = false;                                        //则隐藏label_attention           
                    if (tbUserNameRegister.Text.Any())                                      //若此时用户名栏也有内容
                    {
                        btnRegister.Enabled = true;                                         //那还要激活"注册"按钮
                    }
                }
            }
            else                                                                            //当注册页面"重复密码"栏没有内容时
            {
                btnRegister.Enabled = false;                                                //失效"注册"按钮
            }
        }
    }
}
