using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginFramework
{
    public partial class LoginPage : Form
    {
        private bool IsVisible; //密码栏中密码是否可见标志，为true时可见
        RegistrationPage register = new RegistrationPage();

        //实例化Model层中UserInfo类用于传递数据
        Model.UserInfo m_userInfo = new Model.UserInfo();
        //实例化BLL层中 UserAccess类用于衔接用户输入与数据库匹配
        BLL.UserAccess b_userAccess = new BLL.UserAccess();

        /// <summary>
        /// 提供给外部访问用户名
        /// </summary>
        public string Uname
        {
            get { return m_userInfo.username; }
        }

        public LoginPage()
        {
            InitializeComponent();
            IsVisible = false;
        }

        #region 绘制圆角矩形
        /// <summary>
        /// 获取由控件的矩形轮廓转换而来的圆角矩形轮廓路径
        /// </summary>
        /// <param name="rect">控件矩形</param>
        /// <param name="radius">圆角半径</param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int SideLength = radius;    //定义圆弧方形容器边长为圆的半径
            Rectangle arcRect = new Rectangle(rect.Location, new Size(SideLength, SideLength));
            GraphicsPath path = new GraphicsPath();

            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - SideLength;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - SideLength;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }
        #endregion

        #region 重绘无边框圆角窗口
        /// <summary>
        /// 设置窗口区域
        /// </summary>
        /// <param name="e"></param>
        public void SetWindowRegion(PaintEventArgs e)
        {
            GraphicsPath FormPath = GetRoundedRectPath(this.ClientRectangle, 10);
            this.Region = new Region(FormPath);            

            #region 绘制界面轮廓。这段代码在MSDN中关于 GraphicsPath.Widen 方法 的使用有详细介绍(https://learn.microsoft.com/zh-cn/dotnet/api/system.drawing.drawing2d.graphicspath.widen?redirectedfrom=MSDN&view=dotnet-plat-ext-6.0)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(Pens.LightGray, FormPath);

            Pen widenPen = new Pen(Color.LightGray, 1);     
            Matrix widenMatrix = new Matrix();
            widenMatrix.Translate(-1, -1);
            FormPath.Widen(widenPen, widenMatrix, 1.0f);                   //绘制界面轮廓
            e.Graphics.FillPath(new SolidBrush(Color.LightGray), FormPath);
            #endregion
        }

        private void LoginPage_Paint(object sender, PaintEventArgs e)
        {
            SetWindowRegion(e);
        }
        #endregion

        #region 无边框窗口绘制四周阴影效果（网上找的代码，绘制矩形窗口四周阴影效果还可以，但是绘制圆角矩形窗口四周阴影就不太行了[感兴趣的取消注释直接运行程序可以看下效果]。笔者不打算深入研究了便注释掉了该段代码，有需求的大佬可以拿来修改后使用）
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,      // x-coordinate of upper-left corner
        //    int nTopRect,       // y-coordinate of upper-left corner
        //    int nRightRect,     // x-coordinate of lower-right corner
        //    int nBottomRect,    // y-coordinate of lower-right corner
        //    int nWidthEllipse,  // height of ellipse
        //    int nHeightEllipse  // width of ellipse
        // );

        //[DllImport("dwmapi.dll")]
        //public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        //[DllImport("dwmapi.dll")]
        //public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        //[DllImport("dwmapi.dll")]
        //public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        //private bool m_aeroEnabled;                     // variables for box shadow
        //private const int CS_DROPSHADOW = 0x00020000;
        //private const int WM_NCPAINT = 0x0085;
        //private const int WM_ACTIVATEAPP = 0x001C;

        //public struct MARGINS                           // struct for box shadow
        //{
        //    public int leftWidth;
        //    public int rightWidth;
        //    public int topHeight;
        //    public int bottomHeight;
        //}

        //private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        //private const int HTCLIENT = 0x1;
        ////private const int HTCAPTION = 0x2;

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        m_aeroEnabled = CheckAeroEnabled();

        //        CreateParams cp = base.CreateParams;
        //        if (!m_aeroEnabled)
        //            cp.ClassStyle |= CS_DROPSHADOW;

        //        return cp;
        //    }
        //}

        //private bool CheckAeroEnabled()
        //{
        //    if (Environment.OSVersion.Version.Major >= 6)
        //    {
        //        int enabled = 0;
        //        DwmIsCompositionEnabled(ref enabled);
        //        return (enabled == 1) ? true : false;
        //    }
        //    return false;
        //}

        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCPAINT:                        // box shadow
        //            if (m_aeroEnabled)
        //            {
        //                var v = 2;
        //                DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
        //                MARGINS margins = new MARGINS()
        //                {
        //                    bottomHeight = 1,
        //                    leftWidth = 1,
        //                    rightWidth = 1,
        //                    topHeight = 1
        //                };
        //                DwmExtendFrameIntoClientArea(this.Handle, ref margins);

        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //    base.WndProc(ref m);

        //    if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
        //        m.Result = (IntPtr)HTCAPTION;
        //}
        #endregion

        #region 窗体拖动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        #endregion

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“userDatabaseDataSet.UserAccount”中。您可以根据需要移动或移除它。
            this.userAccountTableAdapter.Fill(this.userDatabaseDataSet.UserAccount);
            #region 设置最小化和关闭按钮的背景色跟随父容器（即设置为透明）
            btnMin.Parent = this;
            btnMin.BackColor = Color.Transparent;
            btnClose.Parent = this;
            btnClose.BackColor = Color.Transparent;
            #endregion
        }

        private void Minimization_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// "登录"按钮点击事件处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //将用户输入的账号密码 赋值给UserInfo类 username、password属性
            m_userInfo.username = UserName.Text.Trim();
            m_userInfo.password = Password.Text.Trim();

            try
            {
                //如果BLL层中 UserLogin查询返回结果大于0，则账号密码正确
                if (b_userAccess.UserLogin(m_userInfo) > 0)
                {
                    MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                btnClose.BackColor = Color.OrangeRed;
            }));
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                btnClose.BackColor = Color.Transparent;
            }));
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                btnMin.BackColor = Color.DodgerBlue;
            }));
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                btnMin.BackColor = Color.Transparent;
            }));
        }

        /// <summary>
        /// 设置密码栏是否可见
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctBox_Visible_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                if (!IsVisible)
                {
                    IsVisible = true;
                    pctBox_Visible.Image = Properties.Resources.Visible32;
                    Password.PasswordChar = (char)0;
                }
                else
                {
                    IsVisible = false;
                    pctBox_Visible.Image = Properties.Resources.Invisible32;
                    Password.PasswordChar = '*';
                }
            }));
        }

        private void btnLogin_CursorChanged(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                if (btnLogin.Cursor == Cursors.Hand)
                {
                    btnLogin.BackColor = Color.RoyalBlue;   //鼠标进入"登录"按钮可见范围内时更改按钮的背景颜色
                }
            }));
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //可查询C# KeyChar键值对照表，十进制的"13"代表键盘上的"enter"键.在密码栏按"enter"键时调用"登录"事件处理程序
            if (e.KeyChar == 13)
                btnLogin_Click(sender, e);
        }

        /// <summary>
        /// 当焦点在用户名栏时按下"⬇"键或"Enter"键，焦点重新定位在密码栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                Password.Focus();
                Password.SelectionStart = Password.TextLength;          //光标定位在最后一个字符处
            }
        }

        /// <summary>
        /// 当焦点在密码栏时按下"⬆"键，焦点重新定位在用户名栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                UserName.Focus();
                UserName.SelectionStart = UserName.Text.Length;         //光标定位在最后一个字符处
            }
        }

        /// <summary>
        /// 用户名/密码栏为空处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if (UserName.Text == "" || Password.Text == "")
            {
                btnLogin.Enabled = false;
                btnLogin.BackColor = Color.LightGray;
            }
            else
            {
                btnLogin.Enabled = true;
                btnLogin.BackColor = Color.CornflowerBlue;
            }
        }

        /// <summary>
        /// 用户名/密码栏为空处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (UserName.Text == "" || Password.Text == "")
            {
                btnLogin.Enabled = false;
                btnLogin.BackColor = Color.LightGray;
            }
            else
            {
                btnLogin.Enabled = true;
                btnLogin.BackColor = Color.CornflowerBlue;
            }
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register.StartPosition = FormStartPosition.CenterParent;
            if (register.ShowDialog() == DialogResult.OK)
                this.userAccountTableAdapter.Fill(this.userDatabaseDataSet.UserAccount);
        }
    }
}
