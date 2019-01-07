using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAndSourceControl
{
    static class CustomerDB
    {
        public static List<string> GetAllNames()
        {
            SqlConnection con =
                new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            using (con)
            {
                con.Open();

            }
        }
    }
}
