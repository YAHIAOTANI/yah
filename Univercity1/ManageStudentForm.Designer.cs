namespace Univercity1
{
    partial class ManageStudentForm
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
            this.Register_Date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Ubdate = new System.Windows.Forms.Button();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Depart = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // Register_Date
            // 
            this.Register_Date.Location = new System.Drawing.Point(145, 380);
            this.Register_Date.Name = "Register_Date";
            this.Register_Date.Size = new System.Drawing.Size(114, 20);
            this.Register_Date.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(55, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "ID";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(133, 236);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(126, 20);
            this.textBox_ID.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(21, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "First Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(35, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(35, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Register Date :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 28);
            this.panel1.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(351, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Manage Student";
            // 
            // button_Ubdate
            // 
            this.button_Ubdate.BackColor = System.Drawing.Color.Aqua;
            this.button_Ubdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ubdate.Location = new System.Drawing.Point(669, 232);
            this.button_Ubdate.Name = "button_Ubdate";
            this.button_Ubdate.Size = new System.Drawing.Size(93, 40);
            this.button_Ubdate.TabIndex = 53;
            this.button_Ubdate.Text = "Update";
            this.button_Ubdate.UseVisualStyleBackColor = false;
            this.button_Ubdate.Click += new System.EventHandler(this.button_Ubdate_Click);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(133, 289);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(126, 20);
            this.textBox_FirstName.TabIndex = 51;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(462, 236);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(126, 20);
            this.textBox_LastName.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(369, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Last Name :";
            // 
            // textBox_Depart
            // 
            this.textBox_Depart.Location = new System.Drawing.Point(462, 349);
            this.textBox_Depart.Name = "textBox_Depart";
            this.textBox_Depart.Size = new System.Drawing.Size(126, 20);
            this.textBox_Depart.TabIndex = 47;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(462, 289);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(126, 20);
            this.textBox_Phone.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(386, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Phone :";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(133, 338);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(126, 20);
            this.textBox_Email.TabIndex = 43;
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(-144, 18);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.Size = new System.Drawing.Size(941, 212);
            this.dataGridView_Student.TabIndex = 41;
            this.dataGridView_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Student_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(386, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Depart :";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Red;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Location = new System.Drawing.Point(669, 305);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(93, 40);
            this.button_Clear.TabIndex = 62;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Location = new System.Drawing.Point(669, 380);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(93, 40);
            this.button_Search.TabIndex = 63;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(462, 391);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(201, 20);
            this.textBox_Search.TabIndex = 64;
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(797, 422);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.Register_Date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Ubdate);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Depart);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.label3);
            this.Name = "ManageStudentForm";
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Register_Date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Ubdate;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Depart;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
    }
}