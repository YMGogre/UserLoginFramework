namespace UserLoginFramework
{
    partial class LoginPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.UserName = new System.Windows.Forms.ComboBox();
            this.Password = new WindowsFormsControlLibraryMadeByXJY.WatermarkTextBox();
            this.pctBox_Visible = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLabel_Register = new System.Windows.Forms.LinkLabel();
            this.label_tip = new System.Windows.Forms.Label();
            this.userDatabaseDataSet = new UserLoginFramework.UserDatabaseDataSet();
            this.userDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAccountTableAdapter = new UserLoginFramework.UserDatabaseDataSetTableAdapters.UserAccountTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Visible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::UserLoginFramework.Properties.Resources.Close_Black16;
            this.btnClose.Location = new System.Drawing.Point(244, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnMin
            // 
            this.btnMin.Image = global::UserLoginFramework.Properties.Resources.Minimization_Black16;
            this.btnMin.Location = new System.Drawing.Point(214, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.Minimization_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // UserName
            // 
            this.UserName.DataSource = this.userAccountBindingSource;
            this.UserName.DisplayMember = "UserName";
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.FormattingEnabled = true;
            this.UserName.Location = new System.Drawing.Point(33, 88);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(208, 33);
            this.UserName.TabIndex = 2;
            this.UserName.ValueMember = "UserName";
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            this.UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserName_KeyDown);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.Location = new System.Drawing.Point(33, 145);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(208, 33);
            this.Password.TabIndex = 3;
            this.Password.WaterMarkFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.WaterMarkLocation = new System.Drawing.Point(2, 9);
            this.Password.WaterText = "请输入密码";
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // pctBox_Visible
            // 
            this.pctBox_Visible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBox_Visible.Image = global::UserLoginFramework.Properties.Resources.Invisible32;
            this.pctBox_Visible.Location = new System.Drawing.Point(209, 146);
            this.pctBox_Visible.Name = "pctBox_Visible";
            this.pctBox_Visible.Size = new System.Drawing.Size(31, 31);
            this.pctBox_Visible.TabIndex = 4;
            this.pctBox_Visible.TabStop = false;
            this.pctBox_Visible.Click += new System.EventHandler(this.pctBox_Visible_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(32, 234);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(208, 33);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.CursorChanged += new System.EventHandler(this.btnLogin_CursorChanged);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_Register.Location = new System.Drawing.Point(166, 285);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(32, 17);
            this.linkLabel_Register.TabIndex = 8;
            this.linkLabel_Register.TabStop = true;
            this.linkLabel_Register.Text = "注册";
            this.linkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tip.Location = new System.Drawing.Point(79, 285);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(92, 17);
            this.label_tip.TabIndex = 9;
            this.label_tip.Text = "还没有账户？请";
            // 
            // userDatabaseDataSet
            // 
            this.userDatabaseDataSet.DataSetName = "UserDatabaseDataSet";
            this.userDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDatabaseDataSetBindingSource
            // 
            this.userDatabaseDataSetBindingSource.DataSource = this.userDatabaseDataSet;
            this.userDatabaseDataSetBindingSource.Position = 0;
            // 
            // userAccountBindingSource
            // 
            this.userAccountBindingSource.DataMember = "UserAccount";
            this.userAccountBindingSource.DataSource = this.userDatabaseDataSetBindingSource;
            // 
            // userAccountTableAdapter
            // 
            this.userAccountTableAdapter.ClearBeforeFill = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(274, 340);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.label_tip);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pctBox_Visible);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPage_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Visible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.ComboBox UserName;
        private WindowsFormsControlLibraryMadeByXJY.WatermarkTextBox Password;
        private System.Windows.Forms.PictureBox pctBox_Visible;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLabel_Register;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.BindingSource userDatabaseDataSetBindingSource;
        private UserDatabaseDataSet userDatabaseDataSet;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private UserDatabaseDataSetTableAdapters.UserAccountTableAdapter userAccountTableAdapter;
    }
}

