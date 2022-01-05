namespace Hospital_Project
{
    partial class FrmPatientSignUp
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.msktxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.msktxtTelNum = new System.Windows.Forms.MaskedTextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(214, 231);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(137, 31);
            this.txtPassword.TabIndex = 5;
            // 
            // msktxtTC
            // 
            this.msktxtTC.Location = new System.Drawing.Point(214, 149);
            this.msktxtTC.Margin = new System.Windows.Forms.Padding(5);
            this.msktxtTC.Mask = "00000000000";
            this.msktxtTC.Name = "msktxtTC";
            this.msktxtTC.Size = new System.Drawing.Size(137, 31);
            this.msktxtTC.TabIndex = 3;
            this.msktxtTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik Numarasi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon Numarasi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cinsiyet:";
            // 
            // msktxtTelNum
            // 
            this.msktxtTelNum.Location = new System.Drawing.Point(214, 190);
            this.msktxtTelNum.Margin = new System.Windows.Forms.Padding(5);
            this.msktxtTelNum.Mask = "(999) 000-0000";
            this.msktxtTelNum.Name = "msktxtTelNum";
            this.msktxtTelNum.Size = new System.Drawing.Size(137, 31);
            this.msktxtTelNum.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(214, 108);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(137, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 67);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 31);
            this.txtName.TabIndex = 1;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbGender.Location = new System.Drawing.Point(214, 270);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(137, 31);
            this.cbGender.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(342, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hasta Kayit Ekrani";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(214, 307);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(137, 46);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Kayit Ol";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // FrmPatientSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(389, 362);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.msktxtTelNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.msktxtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPatientSignUp";
            this.Text = "Hasta Kayit Ekrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox msktxtTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktxtTelNum;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSignUp;
    }
}