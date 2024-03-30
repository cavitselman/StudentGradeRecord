using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeRecord
{
    public class SqlConnect
    {
        public SqlConnection connect()
        {
            SqlConnection connec = new SqlConnection(@"Data Source=\SQLEXPRESS;Initial Catalog=StudentGradeRecord;Integrated Security=True");
            connec.Open();
            return connec;
        }
    }
}
