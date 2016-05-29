namespace CAManager
{
    partial class sprListGroup
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mDel = new System.Windows.Forms.ToolStripMenuItem();
            this.mSel = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Наименование = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.groupTableAdapter = new CAManager.myFWDataSetTableAdapters.GroupTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAdd,
            this.mDel,
            this.mSel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mAdd
            // 
            this.mAdd.Name = "mAdd";
            this.mAdd.Size = new System.Drawing.Size(71, 20);
            this.mAdd.Text = "Добавить";
            this.mAdd.Click += new System.EventHandler(this.mAdd_Click);
            // 
            // mDel
            // 
            this.mDel.Name = "mDel";
            this.mDel.Size = new System.Drawing.Size(63, 20);
            this.mDel.Text = "Удалить";
            this.mDel.Click += new System.EventHandler(this.mDel_Click);
            // 
            // mSel
            // 
            this.mSel.Name = "mSel";
            this.mSel.Size = new System.Drawing.Size(73, 20);
            this.mSel.Text = "Изменить";
            this.mSel.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AutoGenerateColumns = false;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Наименование});
            this.dgvGroups.DataSource = this.groupBindingSource;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.Location = new System.Drawing.Point(0, 24);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(284, 237);
            this.dgvGroups.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // Наименование
            // 
            this.Наименование.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Наименование.DataPropertyName = "name";
            this.Наименование.HeaderText = "name";
            this.Наименование.Name = "Наименование";
            this.Наименование.ReadOnly = true;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.myFWDataSet;
            // 
            // myFWDataSet
            // 
            this.myFWDataSet.DataSetName = "myFWDataSet";
            this.myFWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // sprListGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sprListGroup";
            this.Text = "sprListGroup";
            this.Load += new System.EventHandler(this.sprListGroup_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvGroups;
        private myFWDataSet myFWDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private myFWDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem mAdd;
        private System.Windows.Forms.ToolStripMenuItem mDel;
        private System.Windows.Forms.ToolStripMenuItem mSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование;
    }
}