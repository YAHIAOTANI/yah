using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Univercity1
{ 
    class SubjectsClass
    {
        ClassConected connect = new ClassConected();
        public DataTable getSubjectList()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM 'Subjects'", connect.getconnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            //adapter.Fill(table);
            return table;
        }
        public bool insertSubject(int depid, string name, int minidegree, int term, int Year)
        {
            SqlCommand command = new SqlCommand("INSERT INTO 'Subjects' ('Departmented' , 'Name' , 'MinimumDegree', 'Term','Year') values (@db , @nm , @mindg , @term , @year)", connect.getconnection);
            command.Parameters.Add("@db", SqlDbType.Int).Value = depid;
            command.Parameters.Add("@nm", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@mindg", SqlDbType.Int).Value = minidegree;
            command.Parameters.Add("@term", SqlDbType.Int).Value = term;
            command.Parameters.Add("@year", SqlDbType.VarChar).Value = Year;
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
        public bool updatetSubject(int id , int depid, string name, int minidegree, int term, int Year)
        {
            SqlCommand command = new SqlCommand("UPDATE 'Subjects' SET ('ID' , 'Departmented' , 'Name' , 'MinimumDegree', 'Term','Year') values (@id , @db , @nm , @mindg , @term , @year)", connect.getconnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@db", SqlDbType.Int).Value = depid;
            command.Parameters.Add("@nm", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@mindg", SqlDbType.Int).Value = minidegree;
            command.Parameters.Add("@term", SqlDbType.Int).Value = term;
            command.Parameters.Add("@year", SqlDbType.VarChar).Value = Year;
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
             public DataTable searchStudent(string search)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM 'Subjects' EHERE CONCAT('ID' , 'Name') LIKE '@" + search + "@'", connect.getconnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            //adapter.Fill(table);
            return table;

        }
    }
}
