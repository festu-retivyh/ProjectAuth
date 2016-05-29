namespace CAManager
{
    partial class sprGroup
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
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mSaveExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mClose = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSel = new System.Windows.Forms.Button();
            this.dgvProfile = new System.Windows.Forms.DataGridView();
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileTableAdapter = new CAManager.myFWDataSetTableAdapters.ProfileTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.programIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanel.AutoSize = true;
            this.LayoutPanel.ColumnCount = 1;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.LayoutPanel.Controls.Add(this.panel2, 0, 1);
            this.LayoutPanel.Controls.Add(this.dgvProfile, 0, 2);
            this.LayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 3;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.00926F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.99074F));
            this.LayoutPanel.Size = new System.Drawing.Size(254, 304);
            this.LayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblName);
            this.flowLayoutPanel1.Controls.Add(this.tbxName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 24);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblName.Size = new System.Drawing.Size(83, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxName.Location = new System.Drawing.Point(92, 3);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(147, 20);
            this.tbxName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 307);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSaveExit,
            this.mClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(257, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mSaveExit
            // 
            this.mSaveExit.Name = "mSaveExit";
            this.mSaveExit.Size = new System.Drawing.Size(134, 20);
            this.mSaveExit.Text = "Сохранить и закрыть";
            this.mSaveExit.Click += new System.EventHandler(this.mSaveExit_Click);
            // 
            // mClose
            // 
            this.mClose.Name = "mClose";
            this.mClose.Size = new System.Drawing.Size(65, 20);
            this.mClose.Text = "Закрыть";
            this.mClose.Click += new System.EventHandler(this.mClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSel);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 24);
            this.panel2.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(86, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnSel
            // 
            this.btnSel.Location = new System.Drawing.Point(167, 2);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(75, 23);
            this.btnSel.TabIndex = 0;
            this.btnSel.Text = "Изменить";
            this.btnSel.UseVisualStyleBackColor = true;
            // 
            // dgvProfile
            // 
            this.dgvProfile.AllowUserToAddRows = false;
            this.dgvProfile.AllowUserToDeleteRows = false;
            this.dgvProfile.AutoGenerateColumns = false;
            this.dgvProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Sel,
            this.programIdDataGridViewTextBoxColumn,
            this.serverIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvProfile.DataSource = this.profileBindingSource;
            this.dgvProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfile.Location = new System.Drawing.Point(3, 63);
            this.dgvProfile.Name = "dgvProfile";
            this.dgvProfile.RowHeadersVisible = false;
            this.dgvProfile.Size = new System.Drawing.Size(248, 238);
            this.dgvProfile.TabIndex = 3;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // Sel
            // 
            this.Sel.HeaderText = "Выбран";
            this.Sel.Name = "Sel";
            this.Sel.Width = 30;
            // 
            // programIdDataGridViewTextBoxColumn
            // 
            this.programIdDataGridViewTextBoxColumn.DataPropertyName = "programId";
            this.programIdDataGridViewTextBoxColumn.HeaderText = "programId";
            this.programIdDataGridViewTextBoxColumn.Name = "programIdDataGridViewTextBoxColumn";
            this.programIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // serverIdDataGridViewTextBoxColumn
            // 
            this.serverIdDataGridViewTextBoxColumn.DataPropertyName = "serverId";
            this.serverIdDataGridViewTextBoxColumn.HeaderText = "serverId";
            this.serverIdDataGridViewTextBoxColumn.Name = "serverIdDataGridViewTextBoxColumn";
            this.serverIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sprGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sprGroup";
            this.Text = "Спр. Группа";
            this.Load += new System.EventHandler(this.sprGroup_Load);
            this.LayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mSaveExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem mClose;
        private System.Windows.Forms.DataGridView dgvProfile;
        private myFWDataSet myFWDataSet;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private myFWDataSetTableAdapters.ProfileTableAdapter profileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn programIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}