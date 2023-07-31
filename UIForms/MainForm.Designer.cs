namespace UserLoginFramework
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.panel_logOut = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel_UserStatus = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_subForm = new System.Windows.Forms.Panel();
            this.menuItem_main = new UserLoginFramework.ToolStripRadioButtonMenuItem();
            this.menuItem_task = new UserLoginFramework.ToolStripRadioButtonMenuItem();
            this.menuItem_calibration = new UserLoginFramework.ToolStripRadioButtonMenuItem();
            this.menuItem_deviceMsg = new UserLoginFramework.ToolStripRadioButtonMenuItem();
            this.menuItem_paraSetting = new UserLoginFramework.ToolStripRadioButtonMenuItem();
            this.menuItem_log = new UserLoginFramework.ToolStripRadioButtonMenuItem();
            this.menuItem_network = new UserLoginFramework.ToolStripRadioButtonMenuItem();
            this.menuItem_dataManagement = new UserLoginFramework.ToolStripRadioButtonMenuItem();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_menu.SuspendLayout();
            this.panel_logOut.SuspendLayout();
            this.panel_UserStatus.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_menu.Controls.Add(this.labelProjectName);
            this.panel_menu.Controls.Add(this.panel_logOut);
            this.panel_menu.Controls.Add(this.Logo);
            this.panel_menu.Controls.Add(this.panel_UserStatus);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1072, 50);
            this.panel_menu.TabIndex = 6;
            // 
            // labelProjectName
            // 
            this.labelProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProjectName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProjectName.Location = new System.Drawing.Point(111, 0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(746, 50);
            this.labelProjectName.TabIndex = 2;
            this.labelProjectName.Text = "这是项目名称";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_logOut
            // 
            this.panel_logOut.Controls.Add(this.btnLogout);
            this.panel_logOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_logOut.Location = new System.Drawing.Point(857, 0);
            this.panel_logOut.Name = "panel_logOut";
            this.panel_logOut.Size = new System.Drawing.Size(112, 50);
            this.panel_logOut.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogout.Location = new System.Drawing.Point(7, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "人员登出";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel_UserStatus
            // 
            this.panel_UserStatus.AutoSize = true;
            this.panel_UserStatus.Controls.Add(this.statusStrip1);
            this.panel_UserStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_UserStatus.Location = new System.Drawing.Point(969, 0);
            this.panel_UserStatus.Name = "panel_UserStatus";
            this.panel_UserStatus.Size = new System.Drawing.Size(103, 50);
            this.panel_UserStatus.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelWelcome,
            this.tsslUserName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(103, 50);
            this.statusStrip1.TabIndex = 3;
            // 
            // tsslUserName
            // 
            this.tsslUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsslUserName.Name = "tsslUserName";
            this.tsslUserName.Size = new System.Drawing.Size(0, 45);
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_main,
            this.menuItem_task,
            this.menuItem_calibration,
            this.menuItem_deviceMsg,
            this.menuItem_paraSetting,
            this.menuItem_log,
            this.menuItem_network,
            this.menuItem_dataManagement});
            this.menuStrip.Location = new System.Drawing.Point(235, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(600, 57);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 449);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 57);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel_subForm
            // 
            this.panel_subForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_subForm.Location = new System.Drawing.Point(0, 50);
            this.panel_subForm.Name = "panel_subForm";
            this.panel_subForm.Size = new System.Drawing.Size(1072, 399);
            this.panel_subForm.TabIndex = 10;
            // 
            // menuItem_main
            // 
            this.menuItem_main.CheckOnClick = true;
            this.menuItem_main.Image = global::UserLoginFramework.Properties.Resources.MenuStrip1_HomePage;
            this.menuItem_main.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItem_main.Name = "menuItem_main";
            this.menuItem_main.Size = new System.Drawing.Size(44, 53);
            this.menuItem_main.Text = "主页";
            this.menuItem_main.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuItem_main.ToolTipText = "菜单项1";
            this.menuItem_main.Click += new System.EventHandler(this.menuItem_main_Click);
            // 
            // menuItem_task
            // 
            this.menuItem_task.CheckOnClick = true;
            this.menuItem_task.Image = global::UserLoginFramework.Properties.Resources.MenuStrip2_Task;
            this.menuItem_task.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItem_task.Name = "menuItem_task";
            this.menuItem_task.Size = new System.Drawing.Size(44, 53);
            this.menuItem_task.Text = "任务";
            this.menuItem_task.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuItem_task.ToolTipText = "菜单项2";
            this.menuItem_task.Click += new System.EventHandler(this.menuItem_task_Click);
            // 
            // menuItem_calibration
            // 
            this.menuItem_calibration.CheckOnClick = true;
            this.menuItem_calibration.Image = global::UserLoginFramework.Properties.Resources.MenuStrip3_Calibration;
            this.menuItem_calibration.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItem_calibration.Name = "menuItem_calibration";
            this.menuItem_calibration.Size = new System.Drawing.Size(68, 53);
            this.menuItem_calibration.Text = "系统标定";
            this.menuItem_calibration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuItem_calibration.ToolTipText = "菜单项3";
            this.menuItem_calibration.Click += new System.EventHandler(this.menuItem_calibration_Click);
            // 
            // menuItem_deviceMsg
            // 
            this.menuItem_deviceMsg.CheckOnClick = true;
            this.menuItem_deviceMsg.Image = global::UserLoginFramework.Properties.Resources.MenuStrip4_Device;
            this.menuItem_deviceMsg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItem_deviceMsg.Name = "menuItem_deviceMsg";
            this.menuItem_deviceMsg.Size = new System.Drawing.Size(68, 53);
            this.menuItem_deviceMsg.Text = "设备信息";
            this.menuItem_deviceMsg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuItem_deviceMsg.ToolTipText = "菜单项4";
            this.menuItem_deviceMsg.Click += new System.EventHandler(this.menuItem_deviceMsg_Click);
            // 
            // menuItem_paraSetting
            // 
            this.menuItem_paraSetting.CheckOnClick = true;
            this.menuItem_paraSetting.Image = global::UserLoginFramework.Properties.Resources.MenuStrip5_Para;
            this.menuItem_paraSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItem_paraSetting.Name = "menuItem_paraSetting";
            this.menuItem_paraSetting.Size = new System.Drawing.Size(68, 53);
            this.menuItem_paraSetting.Text = "参数设置";
            this.menuItem_paraSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuItem_paraSetting.ToolTipText = "菜单项5";
            this.menuItem_paraSetting.Click += new System.EventHandler(this.menuItem_paraSetting_Click);
            // 
            // menuItem_log
            // 
            this.menuItem_log.CheckOnClick = true;
            this.menuItem_log.Image = global::UserLoginFramework.Properties.Resources.MenuStrip6_Log;
            this.menuItem_log.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItem_log.Name = "menuItem_log";
            this.menuItem_log.Size = new System.Drawing.Size(68, 53);
            this.menuItem_log.Text = "日志管理";
            this.menuItem_log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuItem_log.ToolTipText = "菜单项6";
            this.menuItem_log.Click += new System.EventHandler(this.menuItem_log_Click);
            // 
            // menuItem_network
            // 
            this.menuItem_network.CheckOnClick = true;
            this.menuItem_network.Image = global::UserLoginFramework.Properties.Resources.MenuStrip7_Internet;
            this.menuItem_network.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItem_network.Name = "menuItem_network";
            this.menuItem_network.Size = new System.Drawing.Size(44, 53);
            this.menuItem_network.Text = "网络";
            this.menuItem_network.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuItem_network.ToolTipText = "菜单项7";
            this.menuItem_network.Click += new System.EventHandler(this.menuItem_network_Click);
            // 
            // menuItem_dataManagement
            // 
            this.menuItem_dataManagement.CheckOnClick = true;
            this.menuItem_dataManagement.Image = global::UserLoginFramework.Properties.Resources.MenuStrip8_Data;
            this.menuItem_dataManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItem_dataManagement.Name = "menuItem_dataManagement";
            this.menuItem_dataManagement.Size = new System.Drawing.Size(68, 53);
            this.menuItem_dataManagement.Text = "数据管理";
            this.menuItem_dataManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuItem_dataManagement.ToolTipText = "菜单项8";
            this.menuItem_dataManagement.Click += new System.EventHandler(this.menuItem_dataManagement_Click);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = global::UserLoginFramework.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(111, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWelcome.Image = global::UserLoginFramework.Properties.Resources.UserLogin32;
            this.labelWelcome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(86, 32);
            this.labelWelcome.Spring = true;
            this.labelWelcome.Text = "欢迎您,";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 506);
            this.Controls.Add(this.panel_subForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_logOut.ResumeLayout(false);
            this.panel_UserStatus.ResumeLayout(false);
            this.panel_UserStatus.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_UserStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelWelcome;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserName;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel_logOut;
        private System.Windows.Forms.MenuStrip menuStrip;
        private ToolStripRadioButtonMenuItem menuItem_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ToolStripRadioButtonMenuItem menuItem_task;
        private ToolStripRadioButtonMenuItem menuItem_calibration;
        private ToolStripRadioButtonMenuItem menuItem_deviceMsg;
        private ToolStripRadioButtonMenuItem menuItem_paraSetting;
        private ToolStripRadioButtonMenuItem menuItem_log;
        private ToolStripRadioButtonMenuItem menuItem_network;
        private ToolStripRadioButtonMenuItem menuItem_dataManagement;
        private System.Windows.Forms.Panel panel_subForm;
    }
}