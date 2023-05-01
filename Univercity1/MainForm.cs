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
    public partial class MainForm : Form
    {
        StudentClass student = new StudentClass();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Display the Values
            countStudent();
        }
        private void countStudent()
        {
            label_TotalStudent.Text = "Total Students : " + student.totalStudent();
        }
        // To Show Register form in mainform
        private Form activeForm = null;
        private void openCildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        private void customizDesign()
        {
            panel_Class.Visible = false;
            panel_ScoreuMe.Visible = false;
            panel_Student.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_Class.Visible == true)
                panel_Class.Visible = false;
            if (panel_ScoreuMe.Visible == true)
                panel_ScoreuMe.Visible = false;
            if (panel_Student.Visible == true)
                panel_Student.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_Student_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Student);
        }

        private void button_Subjects_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Class);
        }

        private void button_Score_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_ScoreuMe);
        }

        private void button_Reistration_Click(object sender, EventArgs e)
        {
            openCildForm(new Form1());
            hideSubmenu();
        }

        private void button_ManageStudent_Click(object sender, EventArgs e)
        {
            openCildForm(new ManageStudentForm());
            hideSubmenu();
        }

        private void Status_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void BClick(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_NewScore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_ManageScore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void dataGridView_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // dataGridView_Student.DataSource - new 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_DashBord_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel1.Controls.Add(panel3);
            countStudent();
        }

        private void button_ManageSubject_Click(object sender, EventArgs e)
        {
            openCildForm(new ManageSubjects());
            hideSubmenu();
        }
    }
}
