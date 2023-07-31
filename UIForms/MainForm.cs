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
