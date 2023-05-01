namespace Univercity1
{
    partial class ManageSubjects
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
            this.textBox_Searchs = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_IDS = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Term = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Ubdate = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_DepartmentID = new System.Windows.Forms.TextBox();
            this.label_DepartmentID = new System.Windows.Forms.Label();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.textBox_MinimumDegree = new System.Windows.Forms.TextBox();
            this.label_MinimumDegree = new System.Windows.Forms.Label();
            this.textBox_Term = new System.Windows.Forms.TextBox();
            this.dataGridView_Subjects = new System.Windows.Forms.DataGridView();
            this.label_Year = new System.Windows.Forms.Label();
            this.button_Adds = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Subjects)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Searchs
            // 
            this.textBox_Searchs.Location = new System.Drawing.Point(460, 385);
            this.textBox_Searchs.Name = "textBox_Searchs";
            this.textBox_Searchs.Size = new System.Drawing.Size(201, 20);
            this.textBox_Searchs.TabIndex = 84;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Location = new System.Drawing.Point(667, 374);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(93, 40);
            this.button_Search.TabIndex = 83;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Red;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Location = new System.Drawing.Point(667, 325);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(93, 40);
            this.button_Clear.TabIndex = 82;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(351, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Manage Sublects";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.BackColor = System.Drawing.Color.Black;
            this.label_ID.ForeColor = System.Drawing.Color.Yellow;
            this.label_ID.Location = new System.Drawing.Point(65, 233);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 80;
            this.label_ID.Text = "ID";
            // 
            // textBox_IDS
            // 
            this.textBox_IDS.Location = new System.Drawing.Point(131, 230);
            this.textBox_IDS.Name = "textBox_IDS";
            this.textBox_IDS.Size = new System.Drawing.Size(126, 20);
            this.textBox_IDS.TabIndex = 79;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.Black;
            this.label_Name.ForeColor = System.Drawing.Color.Yellow;
            this.label_Name.Location = new System.Drawing.Point(45, 286);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(44, 13);
            this.label_Name.TabIndex = 78;
            this.label_Name.Text = " Name :";
            // 
            // label_Term
            // 
            this.label_Term.AutoSize = true;
            this.label_Term.BackColor = System.Drawing.Color.Black;
            this.label_Term.ForeColor = System.Drawing.Color.Yellow;
            this.label_Term.Location = new System.Drawing.Point(45, 346);
            this.label_Term.Name = "label_Term";
            this.label_Term.Size = new System.Drawing.Size(38, 13);
            this.label_Term.TabIndex = 77;
            this.label_Term.Text = "Term :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 28);
            this.panel1.TabIndex = 75;
            // 
            // button_Ubdate
            // 
            this.button_Ubdate.BackColor = System.Drawing.Color.Teal;
            this.button_Ubdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ubdate.ForeColor = System.Drawing.Color.Aqua;
            this.button_Ubdate.Location = new System.Drawing.Point(667, 273);
            this.button_Ubdate.Name = "button_Ubdate";
            this.button_Ubdate.Size = new System.Drawing.Size(93, 40);
            this.button_Ubdate.TabIndex = 74;
            this.button_Ubdate.Text = "Update";
            this.button_Ubdate.UseVisualStyleBackColor = false;
            this.button_Ubdate.Click += new System.EventHandler(this.button_Ubdate_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(131, 283);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(126, 20);
            this.textBox_Name.TabIndex = 73;
            // 
            // textBox_DepartmentID
            // 
            this.textBox_DepartmentID.Location = new System.Drawing.Point(393, 230);
            this.textBox_DepartmentID.Name = "textBox_DepartmentID";
            this.textBox_DepartmentID.Size = new System.Drawing.Size(126, 20);
            this.textBox_DepartmentID.TabIndex = 72;
            // 
            // label_DepartmentID
            // 
            this.label_DepartmentID.AutoSize = true;
            this.label_DepartmentID.BackColor = System.Drawing.Color.Black;
            this.label_DepartmentID.ForeColor = System.Drawing.Color.Yellow;
            this.label_DepartmentID.Location = new System.Drawing.Point(302, 233);
            this.label_DepartmentID.Name = "label_DepartmentID";
            this.label_DepartmentID.Size = new System.Drawing.Size(85, 13);
            this.label_DepartmentID.TabIndex = 71;
            this.label_DepartmentID.Text = "Department ID :";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(393, 336);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(126, 20);
            this.textBox_Year.TabIndex = 70;
            // 
            // textBox_MinimumDegree
            // 
            this.textBox_MinimumDegree.Location = new System.Drawing.Point(393, 280);
            this.textBox_MinimumDegree.Name = "textBox_MinimumDegree";
            this.textBox_MinimumDegree.Size = new System.Drawing.Size(126, 20);
            this.textBox_MinimumDegree.TabIndex = 68;
            // 
            // label_MinimumDegree
            // 
            this.label_MinimumDegree.AutoSize = true;
            this.label_MinimumDegree.BackColor = System.Drawing.Color.Black;
            this.label_MinimumDegree.ForeColor = System.Drawing.Color.Yellow;
            this.label_MinimumDegree.Location = new System.Drawing.Point(298, 287);
            this.label_MinimumDegree.Name = "label_MinimumDegree";
            this.label_MinimumDegree.Size = new System.Drawing.Size(89, 13);
            this.label_MinimumDegree.TabIndex = 67;
            this.label_MinimumDegree.Text = "MinimumDegree :";
            // 
            // textBox_Term
            // 
            this.textBox_Term.Location = new System.Drawing.Point(131, 343);
            this.textBox_Term.Name = "textBox_Term";
            this.textBox_Term.Size = new System.Drawing.Size(126, 20);
            this.textBox_Term.TabIndex = 66;
            // 
            // dataGridView_Subjects
            // 
            this.dataGridView_Subjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_Subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Subjects.Location = new System.Drawing.Point(-146, 12);
            this.dataGridView_Subjects.Name = "dataGridView_Subjects";
            this.dataGridView_Subjects.Size = new System.Drawing.Size(941, 212);
            this.dataGridView_Subjects.TabIndex = 65;
            this.dataGridView_Subjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Subjects_CellContentClick);
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.BackColor = System.Drawing.Color.Black;
            this.label_Year.ForeColor = System.Drawing.Color.Yellow;
            this.label_Year.Location = new System.Drawing.Point(341, 339);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(36, 13);
            this.label_Year.TabIndex = 69;
            this.label_Year.Text = "Year :";
            // 
            // button_Adds
            // 
            this.button_Adds.BackColor = System.Drawing.Color.Aqua;
            this.button_Adds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Adds.Location = new System.Drawing.Point(667, 227);
            this.button_Adds.Name = "button_Adds";
            this.button_Adds.Size = new System.Drawing.Size(93, 40);
            this.button_Adds.TabIndex = 85;
            this.button_Adds.Text = "Add";
            this.button_Adds.UseVisualStyleBackColor = false;
            this.button_Adds.Click += new System.EventHandler(this.button_Adds_Click);
            // 
            // ManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(797, 422);
            this.Controls.Add(this.button_Adds);
            this.Controls.Add(this.textBox_Searchs);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_IDS);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Term);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Ubdate);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_DepartmentID);
            this.Controls.Add(this.label_DepartmentID);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.textBox_MinimumDegree);
            this.Controls.Add(this.label_MinimumDegree);
            this.Controls.Add(this.textBox_Term);
            this.Controls.Add(this.dataGridView_Subjects);
            this.Controls.Add(this.label_Year);
            this.Name = "ManageSubjects";
            this.Text = "ManageSubjects";
            this.Load += new System.EventHandler(this.ManageSubjects_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Subjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Searchs;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_IDS;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Term;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Ubdate;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_DepartmentID;
        private System.Windows.Forms.Label label_DepartmentID;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.TextBox textBox_MinimumDegree;
        private System.Windows.Forms.Label label_MinimumDegree;
        private System.Windows.Forms.TextBox textBox_Term;
        private System.Windows.Forms.DataGridView dataGridView_Subjects;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.Button button_Adds;
    }
}