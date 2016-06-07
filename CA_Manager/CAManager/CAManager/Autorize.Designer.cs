namespace CAManager
{
    partial class Autorize
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
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxSrv = new System.Windows.Forms.TextBox();
            this.lSrv = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(71, 53);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(136, 20);
            this.tbxLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите идентификационные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(71, 81);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(136, 20);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxSrv
            // 
            this.tbxSrv.Location = new System.Drawing.Point(71, 27);
            this.tbxSrv.Name = "tbxSrv";
            this.tbxSrv.Size = new System.Drawing.Size(136, 20);
            this.tbxSrv.TabIndex = 0;
            // 
            // lSrv
            // 
            this.lSrv.AutoSize = true;
            this.lSrv.Location = new System.Drawing.Point(9, 30);
            this.lSrv.Name = "lSrv";
            this.lSrv.Size = new System.Drawing.Size(44, 13);
            this.lSrv.TabIndex = 2;
            this.lSrv.Text = "Сервер";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(118, 111);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(94, 25);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "ОК";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbnClose
            // 
            this.tbnClose.Location = new System.Drawing.Point(12, 111);
            this.tbnClose.Name = "tbnClose";
            this.tbnClose.Size = new System.Drawing.Size(93, 25);
            this.tbnClose.TabIndex = 6;
            this.tbnClose.Text = "Отмена";
            this.tbnClose.UseVisualStyleBackColor = true;
            // 
            // Autorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 138);
            this.Controls.Add(this.tbnClose);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lSrv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSrv);
            this.Controls.Add(this.tbxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Autorize";
            this.Text = "ВХОД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxSrv;
        private System.Windows.Forms.Label lSrv;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button tbnClose;
    }
}