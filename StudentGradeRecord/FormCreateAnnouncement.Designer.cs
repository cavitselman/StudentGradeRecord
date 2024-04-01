namespace StudentGradeRecord
{
    partial class FormCreateAnnouncement
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            BtnEdit = new System.Windows.Forms.Button();
            BtnDelete = new System.Windows.Forms.Button();
            BtnAdd = new System.Windows.Forms.Button();
            RchAnnouncement = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.announcement;
            pictureBox1.Location = new System.Drawing.Point(449, 7);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(204, 172);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(6, 186);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(648, 173);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new System.Drawing.Point(320, 142);
            BtnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new System.Drawing.Size(105, 37);
            BtnEdit.TabIndex = 10;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new System.Drawing.Point(169, 142);
            BtnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new System.Drawing.Size(105, 37);
            BtnDelete.TabIndex = 9;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new System.Drawing.Point(6, 142);
            BtnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(105, 37);
            BtnAdd.TabIndex = 8;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // RchAnnouncement
            // 
            RchAnnouncement.Location = new System.Drawing.Point(6, 7);
            RchAnnouncement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RchAnnouncement.Name = "RchAnnouncement";
            RchAnnouncement.Size = new System.Drawing.Size(418, 124);
            RchAnnouncement.TabIndex = 7;
            RchAnnouncement.Text = "";
            // 
            // FormCreateAnnouncement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(658, 363);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(BtnEdit);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Controls.Add(RchAnnouncement);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormCreateAnnouncement";
            Text = "Create Announcement";
            Load += FormCreateAnnouncement_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.RichTextBox RchAnnouncement;
    }
}