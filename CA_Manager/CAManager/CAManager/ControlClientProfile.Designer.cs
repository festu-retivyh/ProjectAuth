namespace CAManager
{
    partial class ControlClientProfile
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
            this.dgvClientProf = new System.Windows.Forms.DataGridView();
            this.userSrvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.programTableAdapter = new CAManager.myFWDataSetTableAdapters.ProgramTableAdapter();
            this.userSrvTableAdapter = new CAManager.myFWDataSetTableAdapters.UserSrvTableAdapter();
            this.getClientProfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClientProfilesTableAdapter = new CAManager.myFWDataSetTableAdapters.GetClientProfilesTableAdapter();
            this.SelSrv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSrvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientProfilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(93, 5);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(175, 20);
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
            this.panel1.Controls.Add(this.dgvClientProf);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 221);
            this.panel1.TabIndex = 2;
            // 
            // dgvClientProf
            // 
            this.dgvClientProf.AllowUserToAddRows = false;
            this.dgvClientProf.AllowUserToDeleteRows = false;
            this.dgvClientProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelSrv,
            this.Profile,
            this.profileId});
            this.dgvClientProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientProf.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvClientProf.Location = new System.Drawing.Point(0, 0);
            this.dgvClientProf.Name = "dgvClientProf";
            this.dgvClientProf.RowHeadersVisible = false;
            this.dgvClientProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientProf.Size = new System.Drawing.Size(262, 221);
            this.dgvClientProf.TabIndex = 2;
            this.dgvClientProf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserSrv_CellContentClick);
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
            this.btnSave.Location = new System.Drawing.Point(141, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить и закрыть";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Доступные профили";
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // userSrvTableAdapter
            // 
            this.userSrvTableAdapter.ClearBeforeFill = true;
            // 
            // getClientProfilesBindingSource
            // 
            this.getClientProfilesBindingSource.DataMember = "GetClientProfiles";
            this.getClientProfilesBindingSource.DataSource = this.myFWDataSet;
            // 
            // getClientProfilesTableAdapter
            // 
            this.getClientProfilesTableAdapter.ClearBeforeFill = true;
            // 
            // SelSrv
            // 
            this.SelSrv.HeaderText = "Выбран";
            this.SelSrv.Name = "SelSrv";
            this.SelSrv.Width = 30;
            // 
            // Profile
            // 
            this.Profile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profile.HeaderText = "Профиль";
            this.Profile.Name = "Profile";
            this.Profile.ReadOnly = true;
            // 
            // profileId
            // 
            this.profileId.HeaderText = "profileId";
            this.profileId.Name = "profileId";
            this.profileId.ReadOnly = true;
            this.profileId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Группа";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 7;
            // 
            // ControlClientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 342);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbxUser);
            this.Name = "ControlClientProfile";
            this.Text = "Разрешенные сервера";
            this.Load += new System.EventHandler(this.ControlUserSrv_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSrvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientProfilesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientProf;
        private myFWDataSet myFWDataSet;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn SelectSrv;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userSrvBindingSource;
        private myFWDataSetTableAdapters.UserSrvTableAdapter userSrvTableAdapter;
        private System.Windows.Forms.Button btnSave;
        
        private System.Windows.Forms.BindingSource programBindingSource;
        private myFWDataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource getClientProfilesBindingSource;
        private myFWDataSetTableAdapters.GetClientProfilesTableAdapter getClientProfilesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelSrv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}