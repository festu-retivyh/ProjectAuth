namespace CAManager
{
    partial class sprListProgram
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
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.dgvProg = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programTableAdapter = new CAManager.myFWDataSetTableAdapters.ProgramTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mDel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myFWDataSet
            // 
            this.myFWDataSet.DataSetName = "myFWDataSet";
            this.myFWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvProg
            // 
            this.dgvProg.AllowUserToAddRows = false;
            this.dgvProg.AllowUserToDeleteRows = false;
            this.dgvProg.AutoGenerateColumns = false;
            this.dgvProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.portDataGridViewTextBoxColumn,
            this.protocolDataGridViewTextBoxColumn});
            this.dgvProg.DataSource = this.programBindingSource;
            this.dgvProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProg.Location = new System.Drawing.Point(0, 24);
            this.dgvProg.Name = "dgvProg";
            this.dgvProg.ReadOnly = true;
            this.dgvProg.RowHeadersVisible = false;
            this.dgvProg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProg.Size = new System.Drawing.Size(350, 290);
            this.dgvProg.TabIndex = 0;
            this.dgvProg.DoubleClick += new System.EventHandler(this.dgvProg_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "port";
            this.portDataGridViewTextBoxColumn.HeaderText = "Порты";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            this.portDataGridViewTextBoxColumn.ReadOnly = true;
            this.portDataGridViewTextBoxColumn.Width = 110;
            // 
            // protocolDataGridViewTextBoxColumn
            // 
            this.protocolDataGridViewTextBoxColumn.DataPropertyName = "protocol";
            this.protocolDataGridViewTextBoxColumn.HeaderText = "Протокол";
            this.protocolDataGridViewTextBoxColumn.Name = "protocolDataGridViewTextBoxColumn";
            this.protocolDataGridViewTextBoxColumn.ReadOnly = true;
            this.protocolDataGridViewTextBoxColumn.Width = 57;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "Program";
            this.programBindingSource.DataSource = this.myFWDataSet;
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAdd,
            this.mSel,
            this.mDel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mAdd
            // 
            this.mAdd.Name = "mAdd";
            this.mAdd.Size = new System.Drawing.Size(71, 20);
            this.mAdd.Text = "Добавить";
            this.mAdd.Click += new System.EventHandler(this.mAdd_Click);
            // 
            // mSel
            // 
            this.mSel.Name = "mSel";
            this.mSel.Size = new System.Drawing.Size(73, 20);
            this.mSel.Text = "Изменить";
            this.mSel.Click += new System.EventHandler(this.mSel_Click);
            // 
            // mDel
            // 
            this.mDel.Name = "mDel";
            this.mDel.Size = new System.Drawing.Size(63, 20);
            this.mDel.Text = "Удалить";
            this.mDel.Click += new System.EventHandler(this.mDel_Click);
            // 
            // sprListProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 314);
            this.Controls.Add(this.dgvProg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sprListProgram";
            this.Text = "Программы";
            this.Load += new System.EventHandler(this.sprListProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private myFWDataSet myFWDataSet;
        private System.Windows.Forms.DataGridView dgvProg;
        private System.Windows.Forms.BindingSource programBindingSource;
        private myFWDataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mAdd;
        private System.Windows.Forms.ToolStripMenuItem mSel;
        private System.Windows.Forms.ToolStripMenuItem mDel;
    }
}