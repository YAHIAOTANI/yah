using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Univercity1
{
    class StudentClass
    {
        ClassConected connect = new ClassConected();
        // to add student
        public bool insertStudent( int DepartmentId , string fname , string lname , DateTime bdate , string email , string phone)
        {
            SqlCommand command = new SqlCommand("INSERT INTO 'Student' ('ID' , 'DepartmentId' , 'FirstName', 'LastName','RegiisterDate','Email', 'phone') values (@id , @db , @fn , @ln , @bd , @em , @ph)" , connect.getconnection);
            //@fn , @ln , @bd , @em , @ph)
           // command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@db", SqlDbType.Int).Value = DepartmentId;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", SqlDbType.VarChar).Value = bdate;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            } 
        }
        // to get student table
        public DataTable getStudenttList()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM 'Student'", connect.getconnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            //adapter.Fill(table);
            return table;
        }
        // To execute the count query(Total)
        public string exeCount(string query)
        {
            SqlCommand command = new SqlCommand();
            connect.openConnect();
            string count = command.ExecuteNonQuery().ToString();
            connect.closeConnect();
            return count;
        }
        // To get the total student
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM Student");
        }
        public DataTable searchStudent(string search)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM 'Student' EHERE CONCAT('FirstName' , 'LastName' , 'ID') LIKE '@"+search+"@'", connect.getconnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            //adapter.Fill(table);
            return table;
        }
        //To update student
        public bool updatetStudent(int id, int DepartmentId, string fname, string lname, DateTime bdate, string email, string phone)
        {
            SqlCommand command = new SqlCommand("UPDATE 'Student' SET ('ID' , 'DepartmentId' , 'FirstName', 'LastName','RegiisterDate','Email', 'phone') values (@id , @db , @fn , @ln , @bd , @em , @ph)", connect.getconnection);
            //@fn , @ln , @bd , @em , @ph)
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@db", SqlDbType.Int).Value = DepartmentId;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", SqlDbType.VarChar).Value = bdate;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
    }
}
