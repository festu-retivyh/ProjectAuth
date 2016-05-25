namespace CAManager
{
    partial class MasterCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxDomain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFIO = new System.Windows.Forms.TextBox();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateStop = new System.Windows.Forms.DateTimePicker();
            this.cbxDisks = new System.Windows.Forms.ComboBox();
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new CAManager.myFWDataSetTableAdapters.GroupTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные пользователя, держателя сертификата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин Windows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ф.И.О.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата окончания действия";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbxDomain);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbGroup);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxFIO);
            this.panel1.Controls.Add(this.tbxLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 143);
            this.panel1.TabIndex = 4;
            // 
            // tbxDomain
            // 
            this.tbxDomain.Location = new System.Drawing.Point(118, 58);
            this.tbxDomain.Name = "tbxDomain";
            this.tbxDomain.Size = new System.Drawing.Size(206, 20);
            this.tbxDomain.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Имя домена";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DataSource = this.groupBindingSource;
            this.cmbGroup.DisplayMember = "name";
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(118, 110);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(206, 21);
            this.cmbGroup.TabIndex = 7;
            this.cmbGroup.ValueMember = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Группа доступа";
            // 
            // tbxFIO
            // 
            this.tbxFIO.Location = new System.Drawing.Point(118, 84);
            this.tbxFIO.Name = "tbxFIO";
            this.tbxFIO.Size = new System.Drawing.Size(206, 20);
            this.tbxFIO.TabIndex = 3;
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(118, 32);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(206, 20);
            this.tbxLogin.TabIndex = 3;
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(193, 187);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(103, 20);
            this.tbxPath.TabIndex = 5;
            this.tbxPath.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "USB-носитель";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(302, 186);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Обзор";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(215, 240);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(146, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Сформировать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Дата начала действия";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(193, 161);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(168, 20);
            this.dateStart.TabIndex = 11;
            // 
            // dateStop
            // 
            this.dateStop.Location = new System.Drawing.Point(193, 187);
            this.dateStop.Name = "dateStop";
            this.dateStop.Size = new System.Drawing.Size(168, 20);
            this.dateStop.TabIndex = 11;
            // 
            // cbxDisks
            // 
            this.cbxDisks.FormattingEnabled = true;
            this.cbxDisks.Location = new System.Drawing.Point(193, 212);
            this.cbxDisks.Name = "cbxDisks";
            this.cbxDisks.Size = new System.Drawing.Size(168, 21);
            this.cbxDisks.TabIndex = 12;
            this.cbxDisks.SelectedIndexChanged += new System.EventHandler(this.cbxDisks_SelectedIndexChanged);
            this.cbxDisks.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // myFWDataSet
            // 
            this.myFWDataSet.DataSetName = "myFWDataSet";
            this.myFWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.myFWDataSet;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // MasterCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 273);
            this.Controls.Add(this.cbxDisks);
            this.Controls.Add(this.dateStop);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "MasterCreate";
            this.Load += new System.EventHandler(this.MasterCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxFIO;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateStop;
        private System.Windows.Forms.ComboBox cbxDisks;
        private System.Windows.Forms.TextBox tbxDomain;
        private System.Windows.Forms.Label label8;
        private myFWDataSet myFWDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private myFWDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
    }
}