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
    public partial class ManageSubjects : Form
    {
        SubjectsClass subject = new SubjectsClass();
        public ManageSubjects()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if ((textBox_Name.Text == "") || (textBox_DepartmentID.Text == "") || (textBox_MinimumDegree.Text == "") || (textBox_Term.Text == "") || (textBox_Year.Text=="") )
            {
                return false;
            }
            else
                return true;
        }
        public void showTable()
        {
            dataGridView_Subjects.DataSource = subject.getSubjectList();
            /* DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();
             imagecolumn = (DataGridViewImageColumn)dataGridView_Student.Columns[8];
             imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
        }

        private void ManageSubjects_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void button_Ubdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_IDS.Text);
            int debart = int.Parse(textBox_DepartmentID.Text);
            string name = textBox_Name.Text;
            int mininume =int.Parse(textBox_MinimumDegree.Text);
            int term = int.Parse(textBox_Term.Text);
            int year = int.Parse(textBox_Year.Text);

            if (verify())
            {
                if (subject.updatetSubject(id, debart, name, mininume, term, year))
                {
                    showTable();
                    MessageBox.Show("New Subject updated ", "update Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error - Subject Dont update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Empty Field", "update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_DepartmentID.Clear();
            textBox_IDS.Clear();
            textBox_Term.Clear();
            textBox_Year.Clear();
            textBox_MinimumDegree.Clear();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Subjects.DataSource = subject.searchStudent(textBox_Searchs.Text);
            /* DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();
             imagecolumn = (DataGridViewImageColumn)dataGridView_Student.Columns[8];
             imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
        }

        private void button_Adds_Click(object sender, EventArgs e)
        {
            int debart = int.Parse(textBox_DepartmentID.Text);
            string name = textBox_Name.Text;
            int minidnum =int.Parse( textBox_MinimumDegree.Text);
            int term =int.Parse( textBox_Term.Text);
            int year =int.Parse( textBox_Year.Text);

            if (verify())
            {
                if (subject.insertSubject(debart, name, minidnum, term, year))
                {
                    showTable();
                    MessageBox.Show("New Subject Added ", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error - Subject Dont Add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Empty Field", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView_Subjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_IDS.Text = (dataGridView_Subjects.CurrentRow.Cells[1].Value.ToString());
            textBox_DepartmentID.Text = dataGridView_Subjects.CurrentRow.Cells[2].Value.ToString();
            textBox_Name.Text = dataGridView_Subjects.CurrentRow.Cells[3].Value.ToString();
            textBox_MinimumDegree.Text = dataGridView_Subjects.CurrentRow.Cells[4].ToString();
            textBox_Term.Text = dataGridView_Subjects.CurrentRow.Cells[5].Value.ToString();
            textBox_Year.Text = dataGridView_Subjects.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
