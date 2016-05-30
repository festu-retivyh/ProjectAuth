namespace CAManager
{
    partial class sprListProfile
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
            this.dgvProfile = new System.Windows.Forms.DataGridView();
            this.Наименование = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Программа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сервер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mDel = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myProfileTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileTableAdapter = new CAManager.myFWDataSetTableAdapters.ProfileTableAdapter();
            this.myProfileTATableAdapter = new CAManager.myFWDataSetTableAdapters.myProfileTATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfileTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfile
            // 
            this.dgvProfile.AllowUserToAddRows = false;
            this.dgvProfile.AllowUserToDeleteRows = false;
            this.dgvProfile.AutoGenerateColumns = false;
            this.dgvProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Наименование,
            this.Программа,
            this.Сервер});
            this.dgvProfile.DataSource = this.myProfileTABindingSource;
            this.dgvProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfile.Location = new System.Drawing.Point(0, 24);
            this.dgvProfile.Name = "dgvProfile";
            this.dgvProfile.ReadOnly = true;
            this.dgvProfile.RowHeadersVisible = false;
            this.dgvProfile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfile.Size = new System.Drawing.Size(301, 253);
            this.dgvProfile.TabIndex = 0;
            // 
            // Наименование
            // 
            this.Наименование.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Наименование.DataPropertyName = "Наименование";
            this.Наименование.HeaderText = "Наименование";
            this.Наименование.Name = "Наименование";
            this.Наименование.ReadOnly = true;
            // 
            // Программа
            // 
            this.Программа.DataPropertyName = "Программа";
            this.Программа.HeaderText = "Программа";
            this.Программа.Name = "Программа";
            this.Программа.ReadOnly = true;
            // 
            // Сервер
            // 
            this.Сервер.DataPropertyName = "Сервер";
            this.Сервер.HeaderText = "Сервер";
            this.Сервер.Name = "Сервер";
            this.Сервер.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAdd,
            this.mSel,
            this.mDel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 24);
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // myProfileTABindingSource
            // 
            this.myProfileTABindingSource.DataMember = "myProfileTA";
            this.myProfileTABindingSource.DataSource = this.myFWDataSet;
            // 
            // myFWDataSet
            // 
            this.myFWDataSet.DataSetName = "myFWDataSet";
            this.myFWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataMember = "Profile";
            this.profileBindingSource.DataSource = this.myFWDataSet;
            // 
            // profileTableAdapter
            // 
            this.profileTableAdapter.ClearBeforeFill = true;
            // 
            // myProfileTATableAdapter
            // 
            this.myProfileTATableAdapter.ClearBeforeFill = true;
            // 
            // sprListProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 277);
            this.Controls.Add(this.dgvProfile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sprListProfile";
            this.Text = "Список профилей";
            this.Load += new System.EventHandler(this.sprListProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfileTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfile;
        private myFWDataSet myFWDataSet;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private myFWDataSetTableAdapters.ProfileTableAdapter profileTableAdapter;
        private System.Windows.Forms.BindingSource myProfileTABindingSource;
        private myFWDataSetTableAdapters.myProfileTATableAdapter myProfileTATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование;
        private System.Windows.Forms.DataGridViewTextBoxColumn Программа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сервер;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mAdd;
        private System.Windows.Forms.ToolStripMenuItem mSel;
        private System.Windows.Forms.ToolStripMenuItem mDel;
    }
}