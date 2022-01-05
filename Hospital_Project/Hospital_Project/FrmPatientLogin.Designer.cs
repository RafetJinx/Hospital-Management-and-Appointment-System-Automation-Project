namespace Hospital_Project
{
    partial class FrmPatientLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktxtTC = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.llblSignUp = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giris Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik Numarasi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre:";
            // 
            // msktxtTC
            // 
            this.msktxtTC.Location = new System.Drawing.Point(215, 94);
            this.msktxtTC.Mask = "00000000000";
            this.msktxtTC.Name = "msktxtTC";
            this.msktxtTC.Size = new System.Drawing.Size(110, 31);
            this.msktxtTC.TabIndex = 1;
            this.msktxtTC.ValidatingType = typeof(int);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(215, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(110, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // llblSignUp
            // 
            this.llblSignUp.AutoSize = true;
            this.llblSignUp.Location = new System.Drawing.Point(117, 213);
            this.llblSignUp.Name = "llblSignUp";
            this.llblSignUp.Size = new System.Drawing.Size(62, 23);
            this.llblSignUp.TabIndex = 4;
            this.llblSignUp.TabStop = true;
            this.llblSignUp.Text = "Uye Ol";
            this.llblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignUp_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(215, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giris Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmPatientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(351, 271);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.llblSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.msktxtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPatientLogin";
            this.Text = "FrmPatientLogin";
            this.Load += new System.EventHandler(this.FrmPatientLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktxtTC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel llblSignUp;
        private System.Windows.Forms.Button btnLogin;
    }
}