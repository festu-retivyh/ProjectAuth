namespace CAManager
{
    partial class sprListCert
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddServer = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mChangeState = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDateChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDateChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certificateTableAdapter = new CAManager.myFWDataSetTableAdapters.CertificateTableAdapter();
            this.myCertificateTableAdapter = new CAManager.myFWDataSetTableAdapters.myCertificateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCertificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.DateCreate,
            this.dateStart,
            this.dateStop,
            this.Status,
            this.LastDateChange,
            this.TypeCert,
            this.idDataGridViewTextBoxColumn,
            this.dateCreateDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateStopDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.lastDateChangeDataGridViewTextBoxColumn,
            this.typeCertDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.myCertificateBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(284, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.mSel,
            this.mChangeState});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAddServer,
            this.mAddClient});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // mAddServer
            // 
            this.mAddServer.Name = "mAddServer";
            this.mAddServer.Size = new System.Drawing.Size(169, 22);
            this.mAddServer.Text = "Добавить Сервер";
            this.mAddServer.Click += new System.EventHandler(this.mAddServer_Click);
            // 
            // mAddClient
            // 
            this.mAddClient.Name = "mAddClient";
            this.mAddClient.Size = new System.Drawing.Size(169, 22);
            this.mAddClient.Text = "Добавить Клиент";
            this.mAddClient.Click += new System.EventHandler(this.mAddClient_Click);
            // 
            // mSel
            // 
            this.mSel.Name = "mSel";
            this.mSel.Size = new System.Drawing.Size(73, 20);
            this.mSel.Text = "Изменить";
            this.mSel.Click += new System.EventHandler(this.mSel_Click);
            // 
            // mChangeState
            // 
            this.mChangeState.Name = "mChangeState";
            this.mChangeState.Size = new System.Drawing.Size(103, 20);
            this.mChangeState.Text = "Заблокировать";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // DateCreate
            // 
            this.DateCreate.DataPropertyName = "DateCreate";
            this.DateCreate.HeaderText = "Дата создания";
            this.DateCreate.Name = "DateCreate";
            // 
            // dateStart
            // 
            this.dateStart.DataPropertyName = "dateStart";
            this.dateStart.HeaderText = "Начало действия";
            this.dateStart.Name = "dateStart";
            // 
            // dateStop
            // 
            this.dateStop.DataPropertyName = "dateStop";
            this.dateStop.HeaderText = "Окончание действия";
            this.dateStop.Name = "dateStop";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // LastDateChange
            // 
            this.LastDateChange.DataPropertyName = "LastDateChange";
            this.LastDateChange.HeaderText = "Изменение статуса";
            this.LastDateChange.Name = "LastDateChange";
            // 
            // TypeCert
            // 
            this.TypeCert.DataPropertyName = "TypeCert";
            this.TypeCert.HeaderText = "Тип сертификата";
            this.TypeCert.Name = "TypeCert";
            // 
            // myCertificateBindingSource
            // 
            this.myCertificateBindingSource.DataMember = "myCertificate";
            this.myCertificateBindingSource.DataSource = this.myFWDataSet;
            // 
            // myFWDataSet
            // 
            this.myFWDataSet.DataSetName = "myFWDataSet";
            this.myFWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreateDataGridViewTextBoxColumn
            // 
            this.dateCreateDataGridViewTextBoxColumn.DataPropertyName = "DateCreate";
            this.dateCreateDataGridViewTextBoxColumn.HeaderText = "DateCreate";
            this.dateCreateDataGridViewTextBoxColumn.Name = "dateCreateDataGridViewTextBoxColumn";
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "dateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "dateStart";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            // 
            // dateStopDataGridViewTextBoxColumn
            // 
            this.dateStopDataGridViewTextBoxColumn.DataPropertyName = "dateStop";
            this.dateStopDataGridViewTextBoxColumn.HeaderText = "dateStop";
            this.dateStopDataGridViewTextBoxColumn.Name = "dateStopDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // lastDateChangeDataGridViewTextBoxColumn
            // 
            this.lastDateChangeDataGridViewTextBoxColumn.DataPropertyName = "LastDateChange";
            this.lastDateChangeDataGridViewTextBoxColumn.HeaderText = "LastDateChange";
            this.lastDateChangeDataGridViewTextBoxColumn.Name = "lastDateChangeDataGridViewTextBoxColumn";
            // 
            // typeCertDataGridViewTextBoxColumn
            // 
            this.typeCertDataGridViewTextBoxColumn.DataPropertyName = "TypeCert";
            this.typeCertDataGridViewTextBoxColumn.HeaderText = "TypeCert";
            this.typeCertDataGridViewTextBoxColumn.Name = "typeCertDataGridViewTextBoxColumn";
            // 
            // certificateBindingSource
            // 
            this.certificateBindingSource.DataMember = "Certificate";
            this.certificateBindingSource.DataSource = this.myFWDataSet;
            // 
            // certificateTableAdapter
            // 
            this.certificateTableAdapter.ClearBeforeFill = true;
            // 
            // myCertificateTableAdapter
            // 
            this.myCertificateTableAdapter.ClearBeforeFill = true;
            // 
            // sprListCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sprListCert";
            this.Text = "Список сертификатов";
            this.Load += new System.EventHandler(this.sprListCert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCertificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAddServer;
        private System.Windows.Forms.ToolStripMenuItem mAddClient;
        private System.Windows.Forms.ToolStripMenuItem mSel;
        private System.Windows.Forms.ToolStripMenuItem mChangeState;
        private myFWDataSet myFWDataSet;
        private System.Windows.Forms.BindingSource certificateBindingSource;
        private myFWDataSetTableAdapters.CertificateTableAdapter certificateTableAdapter;
        private System.Windows.Forms.BindingSource myCertificateBindingSource;
        private myFWDataSetTableAdapters.myCertificateTableAdapter myCertificateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDateChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDateChangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCertDataGridViewTextBoxColumn;
    }
}