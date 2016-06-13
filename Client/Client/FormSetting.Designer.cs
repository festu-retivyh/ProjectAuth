namespace Client
{
    partial class FormSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOldPin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNewPin1 = new System.Windows.Forms.TextBox();
            this.tbxNewPin2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для смены пин-кода, введите действующий пин-код:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxOldPin
            // 
            this.tbxOldPin.Location = new System.Drawing.Point(60, 41);
            this.tbxOldPin.Name = "tbxOldPin";
            this.tbxOldPin.Size = new System.Drawing.Size(100, 20);
            this.tbxOldPin.TabIndex = 1;
            this.tbxOldPin.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дважды введите новый пин-код";
            // 
            // tbxNewPin1
            // 
            this.tbxNewPin1.Location = new System.Drawing.Point(60, 89);
            this.tbxNewPin1.Name = "tbxNewPin1";
            this.tbxNewPin1.Size = new System.Drawing.Size(100, 20);
            this.tbxNewPin1.TabIndex = 1;
            this.tbxNewPin1.UseSystemPasswordChar = true;
            // 
            // tbxNewPin2
            // 
            this.tbxNewPin2.Location = new System.Drawing.Point(60, 115);
            this.tbxNewPin2.Name = "tbxNewPin2";
            this.tbxNewPin2.Size = new System.Drawing.Size(100, 20);
            this.tbxNewPin2.TabIndex = 1;
            this.tbxNewPin2.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxClose
            // 
            this.tbxClose.Location = new System.Drawing.Point(27, 141);
            this.tbxClose.Name = "tbxClose";
            this.tbxClose.Size = new System.Drawing.Size(83, 27);
            this.tbxClose.TabIndex = 3;
            this.tbxClose.Text = "Отменить";
            this.tbxClose.UseVisualStyleBackColor = true;
            this.tbxClose.Click += new System.EventHandler(this.tbxClose_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 174);
            this.Controls.Add(this.tbxClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNewPin2);
            this.Controls.Add(this.tbxNewPin1);
            this.Controls.Add(this.tbxOldPin);
            this.Controls.Add(this.label1);
            this.Name = "FormSetting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOldPin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNewPin1;
        private System.Windows.Forms.TextBox tbxNewPin2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button tbxClose;
    }
}