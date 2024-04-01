namespace StudentGradeRecord
{
    partial class FormMessages
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            BtnSend = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            RchMessage = new System.Windows.Forms.RichTextBox();
            TxtSubject = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            MskReceiver = new System.Windows.Forms.MaskedTextBox();
            label2 = new System.Windows.Forms.Label();
            MskSender = new System.Windows.Forms.MaskedTextBox();
            label1 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(5, 2);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(832, 277);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(824, 249);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inbox";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(4, 3);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(816, 243);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Size = new System.Drawing.Size(824, 249);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Outbox";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView2.Location = new System.Drawing.Point(4, 3);
            dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new System.Drawing.Size(816, 243);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSend);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(RchMessage);
            groupBox1.Controls.Add(TxtSubject);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(MskReceiver);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MskSender);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(4, 286);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(832, 130);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // BtnSend
            // 
            BtnSend.Location = new System.Drawing.Point(702, 32);
            BtnSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new System.Drawing.Size(106, 73);
            BtnSend.TabIndex = 8;
            BtnSend.Text = "Send";
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(312, 27);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Message:";
            // 
            // RchMessage
            // 
            RchMessage.Location = new System.Drawing.Point(369, 20);
            RchMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RchMessage.Name = "RchMessage";
            RchMessage.Size = new System.Drawing.Size(326, 93);
            RchMessage.TabIndex = 6;
            RchMessage.Text = "";
            // 
            // TxtSubject
            // 
            TxtSubject.Location = new System.Drawing.Point(94, 92);
            TxtSubject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtSubject.Name = "TxtSubject";
            TxtSubject.Size = new System.Drawing.Size(156, 23);
            TxtSubject.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(43, 96);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Subject:";
            // 
            // MskReceiver
            // 
            MskReceiver.Location = new System.Drawing.Point(94, 54);
            MskReceiver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MskReceiver.Mask = "0000";
            MskReceiver.Name = "MskReceiver";
            MskReceiver.Size = new System.Drawing.Size(156, 23);
            MskReceiver.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 58);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Receiver:";
            // 
            // MskSender
            // 
            MskSender.Location = new System.Drawing.Point(94, 20);
            MskSender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MskSender.Mask = "0000";
            MskSender.Name = "MskSender";
            MskSender.Size = new System.Drawing.Size(156, 23);
            MskSender.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Sender:";
            // 
            // FormMessages
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(840, 421);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormMessages";
            Text = "Messages";
            Load += FormMessages_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RchMessage;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskReceiver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskSender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}