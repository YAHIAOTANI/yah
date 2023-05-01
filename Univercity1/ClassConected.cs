using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data.SqlClient;

namespace Univercity1
{
    class ClassConected
    {
        SqlConnection connect = new SqlConnection("Data Source=PHANTOM;Initial Catalog=Univercity;Integrated Security=True");
        public SqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
