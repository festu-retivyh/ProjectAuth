namespace CAManager
{
    partial class ControlUserSrv
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
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUserSrv = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.have = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userSrvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvProgram = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.programTableAdapter = new CAManager.myFWDataSetTableAdapters.ProgramTableAdapter();
            this.userSrvTableAdapter = new CAManager.myFWDataSetTableAdapters.UserSrvTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSrvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(93, 5);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(179, 20);
            this.tbxUser.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(5, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Пользователь";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUserSrv);
            this.panel1.Location = new System.Drawing.Point(9, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 221);
            this.panel1.TabIndex = 2;
            // 
            // dgvUserSrv
            // 
            this.dgvUserSrv.AutoGenerateColumns = false;
            this.dgvUserSrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserSrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.have});
            this.dgvUserSrv.DataSource = this.userSrvBindingSource;
            this.dgvUserSrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserSrv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvUserSrv.Location = new System.Drawing.Point(0, 0);
            this.dgvUserSrv.Name = "dgvUserSrv";
            this.dgvUserSrv.RowHeadersVisible = false;
            this.dgvUserSrv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserSrv.Size = new System.Drawing.Size(262, 221);
            this.dgvUserSrv.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя сервера";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // have
            // 
            this.have.DataPropertyName = "have";
            this.have.HeaderText = "have";
            this.have.Name = "have";
            this.have.ReadOnly = true;
            // 
            // userSrvBindingSource
            // 
            this.userSrvBindingSource.AllowNew = false;
            this.userSrvBindingSource.DataMember = "UserSrv";
            this.userSrvBindingSource.DataSource = this.myFWDataSet;
            this.userSrvBindingSource.Filter = "";
            this.userSrvBindingSource.Sort = "name";
            // 
            // myFWDataSet
            // 
            this.myFWDataSet.DataSetName = "myFWDataSet1";
            this.myFWDataSet.EnforceConstraints = false;
            this.myFWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(384, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить и закрыть";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvProgram
            // 
            this.dgvProgram.AllowUserToAddRows = false;
            this.dgvProgram.AllowUserToDeleteRows = false;
            this.dgvProgram.AutoGenerateColumns = false;
            this.dgvProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.nameDataGridViewTextBoxColumn1,
            this.portDataGridViewTextBoxColumn});
            this.dgvProgram.DataSource = this.programBindingSource;
            this.dgvProgram.Location = new System.Drawing.Point(276, 45);
            this.dgvProgram.Name = "dgvProgram";
            this.dgvProgram.RowHeadersVisible = false;
            this.dgvProgram.Size = new System.Drawing.Size(123, 221);
            this.dgvProgram.TabIndex = 4;
            // 
            // select
            // 
            this.select.DataPropertyName = "select";
            this.select.HeaderText = "Выбран";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Программа";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "port";
            this.portDataGridViewTextBoxColumn.HeaderText = "port";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            this.portDataGridViewTextBoxColumn.ReadOnly = true;
            this.portDataGridViewTextBoxColumn.Visible = false;
            // 
            // programBindingSource
            // 
            this.programBindingSource.AllowNew = false;
            this.programBindingSource.DataMember = "Program";
            this.programBindingSource.DataSource = this.myFWDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Доступные серверы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Доступные программы";
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // userSrvTableAdapter
            // 
            this.userSrvTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.idDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn,
            this.haveDataGridViewTextBoxColumn,
            this.sel});
            this.dataGridView1.DataSource = this.userSrvBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(411, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(123, 223);
            this.dataGridView1.TabIndex = 6;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // haveDataGridViewTextBoxColumn
            // 
            this.haveDataGridViewTextBoxColumn.DataPropertyName = "have";
            this.haveDataGridViewTextBoxColumn.HeaderText = "have";
            this.haveDataGridViewTextBoxColumn.Name = "haveDataGridViewTextBoxColumn";
            this.haveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sel
            // 
            this.sel.HeaderText = "sel";
            this.sel.Name = "sel";
            // 
            // ControlUserSrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 319);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProgram);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbxUser);
            this.Name = "ControlUserSrv";
            this.Text = "Разрешенные сервера";
            this.Load += new System.EventHandler(this.ControlUserSrv_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSrvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUserSrv;
        private myFWDataSet myFWDataSet;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn SelectSrv;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userSrvBindingSource;
        private myFWDataSetTableAdapters.UserSrvTableAdapter userSrvTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvProgram;
        
        private System.Windows.Forms.BindingSource programBindingSource;
        private myFWDataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn have;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
    }
}