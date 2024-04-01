namespace StudentGradeRecord
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            groupBox1 = new System.Windows.Forms.GroupBox();
            BtnTeacherLogin = new System.Windows.Forms.Button();
            TxtTeacherPassword = new System.Windows.Forms.TextBox();
            MskTeacherNumber = new System.Windows.Forms.MaskedTextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            BtnStudentLogin = new System.Windows.Forms.Button();
            TxtStudentPassword = new System.Windows.Forms.TextBox();
            MskStudentNumber = new System.Windows.Forms.MaskedTextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnTeacherLogin);
            groupBox1.Controls.Add(TxtTeacherPassword);
            groupBox1.Controls.Add(MskTeacherNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(429, 172);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teacher";
            // 
            // BtnTeacherLogin
            // 
            BtnTeacherLogin.Location = new System.Drawing.Point(264, 107);
            BtnTeacherLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnTeacherLogin.Name = "BtnTeacherLogin";
            BtnTeacherLogin.Size = new System.Drawing.Size(139, 37);
            BtnTeacherLogin.TabIndex = 5;
            BtnTeacherLogin.Text = "Login";
            BtnTeacherLogin.UseVisualStyleBackColor = true;
            BtnTeacherLogin.Click += BtnTeacherLogin_Click;
            // 
            // TxtTeacherPassword
            // 
            TxtTeacherPassword.Location = new System.Drawing.Point(264, 73);
            TxtTeacherPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtTeacherPassword.Name = "TxtTeacherPassword";
            TxtTeacherPassword.Size = new System.Drawing.Size(138, 23);
            TxtTeacherPassword.TabIndex = 4;
            TxtTeacherPassword.UseSystemPasswordChar = true;
            // 
            // MskTeacherNumber
            // 
            MskTeacherNumber.Location = new System.Drawing.Point(264, 33);
            MskTeacherNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MskTeacherNumber.Mask = "0000";
            MskTeacherNumber.Name = "MskTeacherNumber";
            MskTeacherNumber.Size = new System.Drawing.Size(138, 23);
            MskTeacherNumber.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(196, 76);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(205, 37);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Number:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(7, 33);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(167, 99);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnStudentLogin);
            groupBox2.Controls.Add(TxtStudentPassword);
            groupBox2.Controls.Add(MskStudentNumber);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new System.Drawing.Point(14, 193);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(429, 172);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student";
            // 
            // BtnStudentLogin
            // 
            BtnStudentLogin.Location = new System.Drawing.Point(264, 107);
            BtnStudentLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnStudentLogin.Name = "BtnStudentLogin";
            BtnStudentLogin.Size = new System.Drawing.Size(139, 37);
            BtnStudentLogin.TabIndex = 5;
            BtnStudentLogin.Text = "Login";
            BtnStudentLogin.UseVisualStyleBackColor = true;
            BtnStudentLogin.Click += BtnStudentLogin_Click;
            // 
            // TxtStudentPassword
            // 
            TxtStudentPassword.Location = new System.Drawing.Point(264, 73);
            TxtStudentPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtStudentPassword.Name = "TxtStudentPassword";
            TxtStudentPassword.Size = new System.Drawing.Size(138, 23);
            TxtStudentPassword.TabIndex = 4;
            TxtStudentPassword.UseSystemPasswordChar = true;
            // 
            // MskStudentNumber
            // 
            MskStudentNumber.Location = new System.Drawing.Point(264, 33);
            MskStudentNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MskStudentNumber.Mask = "0000";
            MskStudentNumber.Name = "MskStudentNumber";
            MskStudentNumber.Size = new System.Drawing.Size(138, 23);
            MskStudentNumber.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(195, 76);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(204, 37);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "Number:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(7, 33);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(167, 99);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(461, 376);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormLogin";
            Text = "Student Grading System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnTeacherLogin;
        private System.Windows.Forms.TextBox TxtTeacherPassword;
        private System.Windows.Forms.MaskedTextBox MskTeacherNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnStudentLogin;
        private System.Windows.Forms.TextBox TxtStudentPassword;
        private System.Windows.Forms.MaskedTextBox MskStudentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

