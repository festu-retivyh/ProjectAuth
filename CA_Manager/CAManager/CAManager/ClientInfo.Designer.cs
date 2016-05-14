namespace CAManager
{
    partial class ClientInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private sCLIENT_INFO_FULL sClientInfo;

        public ClientInfo(sCLIENT_INFO_FULL sClientInfo)
        {
            this.sClientInfo = sClientInfo;
        }

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
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.lFname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(12, 23);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(100, 20);
            this.tbxFName.TabIndex = 0;
            // 
            // lFname
            // 
            this.lFname.AutoSize = true;
            this.lFname.Location = new System.Drawing.Point(12, 8);
            this.lFname.Name = "lFname";
            this.lFname.Size = new System.Drawing.Size(56, 13);
            this.lFname.TabIndex = 1;
            this.lFname.Text = "Фамилия";
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 316);
            this.Controls.Add(this.lFname);
            this.Controls.Add(this.tbxFName);
            this.Name = "ClientInfo";
            this.Text = "ClientInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label lFname;
    }
}