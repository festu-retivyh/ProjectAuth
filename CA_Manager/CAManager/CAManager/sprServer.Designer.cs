namespace CAManager
{
    partial class sprServer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvProtocols = new System.Windows.Forms.DataGridView();
            this.lblDateCert = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblDateStop = new System.Windows.Forms.Label();
            this.сохранитьИЗакрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocols)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИЗакрытьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Наименование";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(101, 35);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(151, 20);
            this.tbxName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(277, 38);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Адрес";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(321, 35);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(154, 20);
            this.tbxAddress.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(172, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Состояние сертификата: открыт";
            // 
            // dgvProtocols
            // 
            this.dgvProtocols.AllowUserToAddRows = false;
            this.dgvProtocols.AllowUserToDeleteRows = false;
            this.dgvProtocols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtocols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel,
            this.protocol});
            this.dgvProtocols.Location = new System.Drawing.Point(12, 61);
            this.dgvProtocols.Name = "dgvProtocols";
            this.dgvProtocols.RowHeadersVisible = false;
            this.dgvProtocols.Size = new System.Drawing.Size(195, 201);
            this.dgvProtocols.TabIndex = 7;
            // 
            // lblDateCert
            // 
            this.lblDateCert.AutoSize = true;
            this.lblDateCert.Location = new System.Drawing.Point(6, 43);
            this.lblDateCert.Name = "lblDateCert";
            this.lblDateCert.Size = new System.Drawing.Size(102, 13);
            this.lblDateCert.TabIndex = 8;
            this.lblDateCert.Text = "Дата сертификата";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(6, 67);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(100, 13);
            this.lblDateStart.TabIndex = 9;
            this.lblDateStart.Text = "Начало действия: ";
            // 
            // lblDateStop
            // 
            this.lblDateStop.AutoSize = true;
            this.lblDateStop.Location = new System.Drawing.Point(6, 89);
            this.lblDateStop.Name = "lblDateStop";
            this.lblDateStop.Size = new System.Drawing.Size(115, 13);
            this.lblDateStop.TabIndex = 9;
            this.lblDateStop.Text = "Окончание действия:";
            // 
            // сохранитьИЗакрытьToolStripMenuItem
            // 
            this.сохранитьИЗакрытьToolStripMenuItem.Name = "сохранитьИЗакрытьToolStripMenuItem";
            this.сохранитьИЗакрытьToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.сохранитьИЗакрытьToolStripMenuItem.Text = "Сохранить и закрыть";
            this.сохранитьИЗакрытьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИЗакрытьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // Sel
            // 
            this.Sel.HeaderText = "Выбран";
            this.Sel.Name = "Sel";
            this.Sel.Width = 50;
            // 
            // protocol
            // 
            this.protocol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.protocol.HeaderText = "Протокол";
            this.protocol.Name = "protocol";
            this.protocol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblDateStop);
            this.groupBox1.Controls.Add(this.lblDateCert);
            this.groupBox1.Controls.Add(this.lblDateStart);
            this.groupBox1.Location = new System.Drawing.Point(213, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о сертификате";
            // 
            // sprServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 274);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProtocols);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sprServer";
            this.Text = "Сервер";
            this.Load += new System.EventHandler(this.sprServer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocols)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИЗакрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvProtocols;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocol;
        private System.Windows.Forms.Label lblDateCert;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDateStop;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}