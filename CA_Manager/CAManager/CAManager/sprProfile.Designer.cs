namespace CAManager
{
    partial class sprProfile
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
            this.cbxServer = new System.Windows.Forms.ComboBox();
            this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.cbxProgram = new System.Windows.Forms.ComboBox();
            this.program1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mSaveExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.serverTableAdapter = new CAManager.myFWDataSetTableAdapters.ServerTableAdapter();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programTableAdapter = new CAManager.myFWDataSetTableAdapters.ProgramTableAdapter();
            this.program1TableAdapter = new CAManager.myFWDataSetTableAdapters.Program1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxServer
            // 
            this.cbxServer.DataSource = this.serverBindingSource;
            this.cbxServer.DisplayMember = "name";
            this.cbxServer.FormattingEnabled = true;
            this.cbxServer.Location = new System.Drawing.Point(107, 53);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Size = new System.Drawing.Size(129, 21);
            this.cbxServer.TabIndex = 0;
            this.cbxServer.ValueMember = "id";
            // 
            // serverBindingSource
            // 
            this.serverBindingSource.DataMember = "Server";
            this.serverBindingSource.DataSource = this.myFWDataSet;
            // 
            // myFWDataSet
            // 
            this.myFWDataSet.DataSetName = "myFWDataSet";
            this.myFWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxProgram
            // 
            this.cbxProgram.DataSource = this.program1BindingSource;
            this.cbxProgram.DisplayMember = "name";
            this.cbxProgram.FormattingEnabled = true;
            this.cbxProgram.Location = new System.Drawing.Point(107, 80);
            this.cbxProgram.Name = "cbxProgram";
            this.cbxProgram.Size = new System.Drawing.Size(129, 21);
            this.cbxProgram.TabIndex = 1;
            this.cbxProgram.ValueMember = "id";
            // 
            // program1BindingSource
            // 
            this.program1BindingSource.DataMember = "Program1";
            this.program1BindingSource.DataSource = this.myFWDataSet;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(107, 27);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(128, 20);
            this.tbxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сервер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Программа";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSaveExit,
            this.mCopy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(248, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mSaveExit
            // 
            this.mSaveExit.Name = "mSaveExit";
            this.mSaveExit.Size = new System.Drawing.Size(134, 20);
            this.mSaveExit.Text = "Сохранить и закрыть";
            this.mSaveExit.Click += new System.EventHandler(this.mSaveExit_Click);
            // 
            // mCopy
            // 
            this.mCopy.Name = "mCopy";
            this.mCopy.Size = new System.Drawing.Size(84, 20);
            this.mCopy.Text = "Копировать";
            this.mCopy.Click += new System.EventHandler(this.mCopy_Click);
            // 
            // serverTableAdapter
            // 
            this.serverTableAdapter.ClearBeforeFill = true;
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
            // program1TableAdapter
            // 
            this.program1TableAdapter.ClearBeforeFill = true;
            // 
            // sprProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 109);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.cbxProgram);
            this.Controls.Add(this.cbxServer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sprProfile";
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.sprProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxServer;
        private System.Windows.Forms.ComboBox cbxProgram;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mSaveExit;
        private System.Windows.Forms.ToolStripMenuItem mCopy;
        private myFWDataSet myFWDataSet;
        private System.Windows.Forms.BindingSource serverBindingSource;
        private myFWDataSetTableAdapters.ServerTableAdapter serverTableAdapter;
        private System.Windows.Forms.BindingSource programBindingSource;
        private myFWDataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.BindingSource program1BindingSource;
        private myFWDataSetTableAdapters.Program1TableAdapter program1TableAdapter;
        private int value;

        
    }
}