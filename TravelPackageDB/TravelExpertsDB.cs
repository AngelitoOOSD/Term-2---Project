using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPackageDB
{
    public class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            string conString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog = TravelExperts; Integrated Security = True";
            return new SqlConnection(conString);
        }
    }
}
