using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginFramework
{
    public partial class MainForm : Form
    {
        private MainPage _mainPage = new MainPage();
        private Task _task = new Task();
        private Calibration _calibration = new Calibration();
        private DeviceMessage _deviceMessage = new DeviceMessage();
        private Parameter _parameter = new Parameter();
        private Log _log = new Log();
        private Network _network = new Network();
        private DataManagement _dataManagement = new DataManagement();

        public MainForm(string UserName)
        {
            InitializeComponent();
            #region 初始化加载一次所有子页面，以创建子页面的窗口句柄
            LoadForm(_dataManagement);
            LoadForm(_network);
            LoadForm(_log);
            LoadForm(_parameter);
            LoadForm(_deviceMessage);
            LoadForm(_calibration);
            LoadForm(_task);
            #endregion
            //默认加载主页面
            LoadForm(_mainPage);
            menuItem_main.Checked = true;
            tsslUserName.Text = UserName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// 在主窗口中加载子页面方法
        /// </summary>
        /// <param name="subForm">子页面对象</param>
        protected void LoadForm(object subForm)
        {
            panel_subForm.Controls.Clear();
            Form form = subForm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel_subForm.Controls.Add(form);
            this.panel_subForm.Tag = form;
            /**
             * 窗口句柄是 Windows 操作系统用来标识和跟踪窗口的一种方式。
             * 在 Winform 中，实例化对象（例如 Form form = new Form();）时并不会立刻
             * 创建窗口句柄，窗口句柄的创建通常会在窗体或控件第一次需要被显示时发生。
             * 例如，当你调用 form.show() 方法时，就会创建窗体及其所有控件的窗口句柄。
             * 你可以通过 form.Handle 属性访问窗口句柄（如果你在窗口句柄创建之前就访问 
             * Handle 属性，那么窗口句柄将会被提前创建；通常不推荐这样做），窗口句柄一旦
             * 被创建就会一直存在，直至窗体被销毁。而在之后再次调用 form.show() 方法，就
             * 会显示窗体，但不会重新创建窗口句柄
             */
            form.Show();
        }

        private void menuItem_main_Click(object sender, EventArgs e)
        {
            LoadForm(_mainPage);
        }

        private void menuItem_task_Click(object sender, EventArgs e)
        {
            LoadForm(_task);
        }

        private void menuItem_calibration_Click(object sender, EventArgs e)
        {
            LoadForm(_calibration);
        }

        private void menuItem_deviceMsg_Click(object sender, EventArgs e)
        {
            LoadForm(_deviceMessage);
        }

        private void menuItem_paraSetting_Click(object sender, EventArgs e)
        {
            LoadForm(_parameter);
        }

        private void menuItem_log_Click(object sender, EventArgs e)
        {
            LoadForm(_log);
        }

        private void menuItem_network_Click(object sender, EventArgs e)
        {
            LoadForm(_network);
        }

        private void menuItem_dataManagement_Click(object sender, EventArgs e)
        {
            LoadForm(_dataManagement);
        }
    }
}
