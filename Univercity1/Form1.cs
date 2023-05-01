using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Univercity1
{
    public partial class Form1 : Form
    {
        StudentClass student = new StudentClass();
        public Form1()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if ((textBox_FirstName.Text == "") || (textBox_LastName.Text == "") || (textBox_Phone.Text == "")||(textBox_Depart.Text==""))
            {
                return false;
            }
            else
                return true;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            /*  SqlConnection con = new SqlConnection("Data Source=PHANTOM;Initial Catalog=Univercity;Integrated Security=True");
              con.Open();
              SqlCommand cmd = new SqlCommand("insert into Students value (@ID , @FirstName , @LastName , @Email , @Phone , @RegisterDate , @DepartmentId)", con);
              cmd.Parameters.AddWithValue("@ID", int.Parse(textBox_ID.Text));
              cmd.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text);
              cmd.Parameters.AddWithValue("@LastName",textBox_LastName.Text);
              cmd.Parameters.AddWithValue("@Email", textBox_Email.Text);
              cmd.Parameters.AddWithValue("@Phone", textBox_Phone.Text);
              cmd.Parameters.AddWithValue("@RegisterDate", Register_Date.Text);
              cmd.Parameters.AddWithValue("@DepartmentId", int.Parse(textBox_Depart.Text));
              cmd.ExecuteNonQuery();
              con.Close();
              MessageBox.Show("The iserted is successfuly");*/
           
            int debart = int.Parse(textBox_ID.Text);
            string fname = textBox_FirstName.Text;
            string lname = textBox_LastName.Text;
            DateTime bdate = Register_Date.Value;
            string phone = textBox_Phone.Text;
            string email = textBox_Email.Text;

            if (verify())
            {
                if (student.insertStudent( debart , fname, lname, bdate, email, phone))
                {
                    showTable();
                    MessageBox.Show("New Student Added ", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error - Student Dont Add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTable();
        }
        // To show Student list in Datagidview
        public void showTable()
        {
            dataGridView_Student.DataSource = student.getStudenttList();
           /* DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();
            imagecolumn = (DataGridViewImageColumn)dataGridView_Student.Columns[8];
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
        }

        private void button_Delet_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection("Data Source=PHANTOM;Initial Catalog=Univercity;Integrated Security=True");
             con.Open();
             SqlCommand cmd = new SqlCommand("Delete Students where ID=@Id", con);
             cmd.Parameters.AddWithValue("@ID", int.Parse(textBox_ID.Text));
             cmd.ExecuteNonQuery();
             MessageBox.Show("Successfully Delete");*/
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_Phone.Clear();
            textBox_Email.Clear();
            textBox_ID.Clear();
            textBox_Depart.Clear();
        }
    }
}
