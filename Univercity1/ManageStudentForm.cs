using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Univercity1
{
    public partial class ManageStudentForm : Form
    {
        StudentClass student = new StudentClass();
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if ((textBox_FirstName.Text == "") || (textBox_LastName.Text == "") || (textBox_Phone.Text == "") || (textBox_Depart.Text == ""))
            {
                return false;
            }
            else
                return true;
        }
        public void showTable()
        {
            dataGridView_Student.DataSource = student.getStudenttList();
            /* DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();
             imagecolumn = (DataGridViewImageColumn)dataGridView_Student.Columns[8];
             imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        //display student data from student to textbox
        private void dataGridView_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = (dataGridView_Student.CurrentRow.Cells[1].Value.ToString());
            textBox_FirstName.Text= dataGridView_Student.CurrentRow.Cells[3].Value.ToString();
            textBox_LastName.Text = dataGridView_Student.CurrentRow.Cells[4].Value.ToString();
            Register_Date.Value = (DateTime)dataGridView_Student.CurrentRow.Cells[7].Value;
            textBox_Phone.Text= dataGridView_Student.CurrentRow.Cells[6].Value.ToString();
            textBox_Email.Text= dataGridView_Student.CurrentRow.Cells[5].Value.ToString();
            textBox_Depart.Text= dataGridView_Student.CurrentRow.Cells[8].Value.ToString();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_Phone.Clear();
            textBox_Email.Clear();
            textBox_ID.Clear();
            textBox_Depart.Clear();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Student.DataSource = student.searchStudent(textBox_Search.Text);
            /* DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();
             imagecolumn = (DataGridViewImageColumn)dataGridView_Student.Columns[8];
             imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
        }
        //update student
        private void button_Ubdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_ID.Text);
            int debart = int.Parse(textBox_ID.Text);
            string fname = textBox_FirstName.Text;
            string lname = textBox_LastName.Text;
            DateTime bdate = Register_Date.Value;
            string phone = textBox_Phone.Text;
            string email = textBox_Email.Text;

            if (verify())
            {
                if (student.updatetStudent(id, debart, fname, lname, bdate, email, phone))
                {
                    showTable();
                    MessageBox.Show("New Student updated ", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error - Student Dont update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Empty Field", "Add update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    
}
