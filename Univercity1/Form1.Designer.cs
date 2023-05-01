namespace Univercity1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Delet = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Depart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Register_Date = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 28);
            this.panel1.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(351, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Register";
            // 
            // button_Delet
            // 
            this.button_Delet.BackColor = System.Drawing.Color.Yellow;
            this.button_Delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delet.Location = new System.Drawing.Point(678, 323);
            this.button_Delet.Name = "button_Delet";
            this.button_Delet.Size = new System.Drawing.Size(93, 40);
            this.button_Delet.TabIndex = 32;
            this.button_Delet.Text = "Delet";
            this.button_Delet.UseVisualStyleBackColor = false;
            this.button_Delet.Click += new System.EventHandler(this.button_Delet_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Aqua;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(678, 247);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(93, 40);
            this.button_Add.TabIndex = 31;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(-132, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Register Date :";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(156, 274);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(126, 20);
            this.textBox_FirstName.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(-117, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "First Name :";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(485, 215);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(126, 20);
            this.textBox_LastName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(392, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Last Name :";
            // 
            // textBox_Depart
            // 
            this.textBox_Depart.Location = new System.Drawing.Point(485, 339);
            this.textBox_Depart.Name = "textBox_Depart";
            this.textBox_Depart.Size = new System.Drawing.Size(126, 20);
            this.textBox_Depart.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(409, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Depart :";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(485, 271);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(126, 20);
            this.textBox_Phone.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(409, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Phone :";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(156, 323);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(126, 20);
            this.textBox_Email.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(-108, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email :";
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(-144, -15);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.Size = new System.Drawing.Size(941, 212);
            this.dataGridView_Student.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(58, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Register Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(58, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Email :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(44, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "First Name :";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(156, 215);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(126, 20);
            this.textBox_ID.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(78, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "ID";
            // 
            // Register_Date
            // 
            this.Register_Date.Location = new System.Drawing.Point(156, 371);
            this.Register_Date.Name = "Register_Date";
            this.Register_Date.Size = new System.Drawing.Size(114, 20);
            this.Register_Date.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(797, 422);
            this.Controls.Add(this.Register_Date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Delet);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Depart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Student);
            this.Name = "Form1";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Delet;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Depart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Register_Date;
    }
}

