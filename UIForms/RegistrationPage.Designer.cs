namespace UserLoginFramework
{
    partial class RegistrationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPage));
            this.label_NullUserNameWarning = new System.Windows.Forms.Label();
            this.label_NullPasswordWarning = new System.Windows.Forms.Label();
            this.label_attention = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label_PasswordRepeat = new System.Windows.Forms.Label();
            this.label_PasswordRegister = new System.Windows.Forms.Label();
            this.label_UserNameRegister = new System.Windows.Forms.Label();
            this.tbPasswordRepeat = new System.Windows.Forms.TextBox();
            this.tbPasswordRegister = new System.Windows.Forms.TextBox();
            this.tbUserNameRegister = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_NullUserNameWarning
            // 
            this.label_NullUserNameWarning.AutoSize = true;
            this.label_NullUserNameWarning.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NullUserNameWarning.ForeColor = System.Drawing.Color.Red;
            this.label_NullUserNameWarning.Location = new System.Drawing.Point(273, 26);
            this.label_NullUserNameWarning.Name = "label_NullUserNameWarning";
            this.label_NullUserNameWarning.Size = new System.Drawing.Size(99, 17);
            this.label_NullUserNameWarning.TabIndex = 19;
            this.label_NullUserNameWarning.Text = "❗用户名不能为空";
            this.label_NullUserNameWarning.Visible = false;
            // 
            // label_NullPasswordWarning
            // 
            this.label_NullPasswordWarning.AutoSize = true;
            this.label_NullPasswordWarning.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NullPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.label_NullPasswordWarning.Location = new System.Drawing.Point(273, 68);
            this.label_NullPasswordWarning.Name = "label_NullPasswordWarning";
            this.label_NullPasswordWarning.Size = new System.Drawing.Size(87, 17);
            this.label_NullPasswordWarning.TabIndex = 18;
            this.label_NullPasswordWarning.Text = "❗密码不能为空";
            this.label_NullPasswordWarning.Visible = false;
            // 
            // label_attention
            // 
            this.label_attention.AutoSize = true;
            this.label_attention.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_attention.Location = new System.Drawing.Point(273, 110);
            this.label_attention.Name = "label_attention";
            this.label_attention.Size = new System.Drawing.Size(144, 17);
            this.label_attention.TabIndex = 17;
            this.label_attention.Text = "🙁两次输入的密码不一致";
            this.label_attention.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(173, 153);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(70, 27);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "注  册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label_PasswordRepeat
            // 
            this.label_PasswordRepeat.AutoSize = true;
            this.label_PasswordRepeat.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PasswordRepeat.Location = new System.Drawing.Point(39, 107);
            this.label_PasswordRepeat.Name = "label_PasswordRepeat";
            this.label_PasswordRepeat.Size = new System.Drawing.Size(79, 20);
            this.label_PasswordRepeat.TabIndex = 15;
            this.label_PasswordRepeat.Text = "重复密码：";
            this.label_PasswordRepeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_PasswordRegister
            // 
            this.label_PasswordRegister.AutoSize = true;
            this.label_PasswordRegister.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PasswordRegister.Location = new System.Drawing.Point(67, 65);
            this.label_PasswordRegister.Name = "label_PasswordRegister";
            this.label_PasswordRegister.Size = new System.Drawing.Size(51, 20);
            this.label_PasswordRegister.TabIndex = 14;
            this.label_PasswordRegister.Text = "密码：";
            this.label_PasswordRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_UserNameRegister
            // 
            this.label_UserNameRegister.AutoSize = true;
            this.label_UserNameRegister.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_UserNameRegister.Location = new System.Drawing.Point(53, 23);
            this.label_UserNameRegister.Name = "label_UserNameRegister";
            this.label_UserNameRegister.Size = new System.Drawing.Size(65, 20);
            this.label_UserNameRegister.TabIndex = 13;
            this.label_UserNameRegister.Text = "用户名：";
            this.label_UserNameRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPasswordRepeat
            // 
            this.tbPasswordRepeat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPasswordRepeat.Location = new System.Drawing.Point(124, 107);
            this.tbPasswordRepeat.MaxLength = 20;
            this.tbPasswordRepeat.Name = "tbPasswordRepeat";
            this.tbPasswordRepeat.PasswordChar = '*';
            this.tbPasswordRepeat.Size = new System.Drawing.Size(143, 23);
            this.tbPasswordRepeat.TabIndex = 12;
            this.tbPasswordRepeat.TextChanged += new System.EventHandler(this.tbPasswordRepeat_TextChanged);
            // 
            // tbPasswordRegister
            // 
            this.tbPasswordRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPasswordRegister.Location = new System.Drawing.Point(124, 65);
            this.tbPasswordRegister.MaxLength = 20;
            this.tbPasswordRegister.Name = "tbPasswordRegister";
            this.tbPasswordRegister.PasswordChar = '*';
            this.tbPasswordRegister.Size = new System.Drawing.Size(143, 23);
            this.tbPasswordRegister.TabIndex = 11;
            this.tbPasswordRegister.TextChanged += new System.EventHandler(this.tbPasswordRegister_TextChanged);
            // 
            // tbUserNameRegister
            // 
            this.tbUserNameRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbUserNameRegister.Location = new System.Drawing.Point(124, 23);
            this.tbUserNameRegister.MaxLength = 10;
            this.tbUserNameRegister.Name = "tbUserNameRegister";
            this.tbUserNameRegister.Size = new System.Drawing.Size(143, 23);
            this.tbUserNameRegister.TabIndex = 10;
            this.tbUserNameRegister.TextChanged += new System.EventHandler(this.tbUserNameRegister_TextChanged);
            // 
            // RegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 200);
            this.Controls.Add(this.label_NullUserNameWarning);
            this.Controls.Add(this.label_NullPasswordWarning);
            this.Controls.Add(this.label_attention);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label_PasswordRepeat);
            this.Controls.Add(this.label_PasswordRegister);
            this.Controls.Add(this.label_UserNameRegister);
            this.Controls.Add(this.tbPasswordRepeat);
            this.Controls.Add(this.tbPasswordRegister);
            this.Controls.Add(this.tbUserNameRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistrationPage";
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NullUserNameWarning;
        private System.Windows.Forms.Label label_NullPasswordWarning;
        private System.Windows.Forms.Label label_attention;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label_PasswordRepeat;
        private System.Windows.Forms.Label label_PasswordRegister;
        private System.Windows.Forms.Label label_UserNameRegister;
        private System.Windows.Forms.TextBox tbPasswordRepeat;
        private System.Windows.Forms.TextBox tbPasswordRegister;
        private System.Windows.Forms.TextBox tbUserNameRegister;
    }
}