namespace CAManager
{
    partial class sprClient
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
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.lFIO = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSaveExit = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSName = new System.Windows.Forms.TextBox();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.tbxDomain = new System.Windows.Forms.TextBox();
            this.ldomain = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выдатьНовыйСертификатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(52, 53);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(130, 20);
            this.tbxFName.TabIndex = 0;
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Location = new System.Drawing.Point(12, 56);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(34, 13);
            this.lFIO.TabIndex = 1;
            this.lFIO.Text = "ФИО";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveExit,
            this.закрытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выдатьНовыйСертификатToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(134, 20);
            this.btnSaveExit.Text = "Сохранить и закрыть";
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(188, 53);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(110, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxSName
            // 
            this.tbxSName.Location = new System.Drawing.Point(304, 53);
            this.tbxSName.Name = "tbxSName";
            this.tbxSName.Size = new System.Drawing.Size(120, 20);
            this.tbxSName.TabIndex = 0;
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(52, 27);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(130, 20);
            this.tbxLogin.TabIndex = 0;
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(12, 30);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(38, 13);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Логин";
            // 
            // tbxDomain
            // 
            this.tbxDomain.Location = new System.Drawing.Point(241, 27);
            this.tbxDomain.Name = "tbxDomain";
            this.tbxDomain.Size = new System.Drawing.Size(183, 20);
            this.tbxDomain.TabIndex = 0;
            // 
            // ldomain
            // 
            this.ldomain.AutoSize = true;
            this.ldomain.Location = new System.Drawing.Point(193, 30);
            this.ldomain.Name = "ldomain";
            this.ldomain.Size = new System.Drawing.Size(42, 13);
            this.ldomain.TabIndex = 1;
            this.ldomain.Text = "Домен";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // выдатьНовыйСертификатToolStripMenuItem
            // 
            this.выдатьНовыйСертификатToolStripMenuItem.Name = "выдатьНовыйСертификатToolStripMenuItem";
            this.выдатьНовыйСертификатToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.выдатьНовыйСертификатToolStripMenuItem.Text = "Выдать новый сертификат";
            this.выдатьНовыйСертификатToolStripMenuItem.Click += new System.EventHandler(this.выдатьНовыйСертификатToolStripMenuItem_Click);
            // 
            // sprClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 86);
            this.Controls.Add(this.tbxSName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.ldomain);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.lFIO);
            this.Controls.Add(this.tbxDomain);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.tbxFName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sprClient";
            this.Text = "Спрвочник клиент";
            this.Load += new System.EventHandler(this.sprClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSaveExit;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxSName;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.TextBox tbxDomain;
        private System.Windows.Forms.Label ldomain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выдатьНовыйСертификатToolStripMenuItem;
    }
}