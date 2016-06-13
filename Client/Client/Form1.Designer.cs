namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CloseApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbxState = new System.Windows.Forms.ToolStripTextBox();
            this.btnSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxPinCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Клиент";
            this.notifyIcon1.ContextMenuStrip = this.CloseApp;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // CloseApp
            // 
            this.CloseApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbxState,
            this.btnSetting,
            this.btnClose});
            this.CloseApp.Name = "contextMenuStrip1";
            this.CloseApp.Size = new System.Drawing.Size(221, 95);
            this.CloseApp.Text = "Выйти из приложения";
            this.CloseApp.Opening += new System.ComponentModel.CancelEventHandler(this.CloseApp_Opening);
            // 
            // tbxState
            // 
            this.tbxState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxState.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.tbxState.Name = "tbxState";
            this.tbxState.ReadOnly = true;
            this.tbxState.Size = new System.Drawing.Size(160, 23);
            this.tbxState.Text = "Состояние: Отключен";
            // 
            // btnSetting
            // 
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ShortcutKeyDisplayString = "[Ctrl+S]";
            this.btnSetting.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSetting.Size = new System.Drawing.Size(220, 22);
            this.btnSetting.Text = "Настройки";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(220, 22);
            this.btnClose.Text = "Закрыть приложение";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxPinCode
            // 
            this.tbxPinCode.Location = new System.Drawing.Point(12, 21);
            this.tbxPinCode.Name = "tbxPinCode";
            this.tbxPinCode.Size = new System.Drawing.Size(100, 20);
            this.tbxPinCode.TabIndex = 0;
            this.tbxPinCode.UseSystemPasswordChar = true;
            this.tbxPinCode.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ожидание USB";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 92);
            this.ContextMenuStrip = this.CloseApp;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxPinCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод Pin-кода";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.CloseApp.ResumeLayout(false);
            this.CloseApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox tbxPinCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip CloseApp;
        private System.Windows.Forms.ToolStripMenuItem btnSetting;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripTextBox tbxState;
    }
}

