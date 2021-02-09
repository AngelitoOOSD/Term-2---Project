using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG200.TravelExperts.Data
{
    /*
     * Purpose: Data access class for Packages
     * Authors: Group 5
     * Date Created: 02/2021
     */
    public static class PackageDB
    {
        /// <summary>
        /// Katrina Spencer: Retrieves package info with given id
        /// </summary>
        /// <param name="pkgId">id of package to get</param>
        /// <returns>package object</returns>
        public static Package GetPackage(int pkgId)
        {
            Package pkg = null;
            // connection
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                               "FROM Packages" +
                               "WHERE PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", pkgId);
                    // run command and process data
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        if (dr.Read()) // if data
                        {
                            pkg = new Package();
                            pkg.PackageId = (int)dr["PackageId"];
                            pkg.PkgName = (string)dr["PkgName"];
                            pkg.PkgBasePrice = Convert.ToDecimal(dr["PkgBasePrice"]);

                            // need to determine if it is DBNull and set
                            int colSD = dr.GetOrdinal("PkgStartDate"); // column number of PkgStartDate
                            if (dr.IsDBNull(colSD)) // if reader contains DBNull in this column
                                pkg.PkgStartDate = null; // make null in the object
                            else // if not null
                                pkg.PkgStartDate = (DateTime)dr["PkgStartDate"];

                            int colED = dr.GetOrdinal("PkgEndDate"); // column number of PkgEndDate
                            if (dr.IsDBNull(colED)) // if reader contains DBNull in this column
                                pkg.PkgEndDate = null; // make null in the object
                            else // if not null
                                pkg.PkgEndDate = (DateTime)dr["PkgEndDate"];

                            int colDesc = dr.GetOrdinal("PkgDesc"); // column number of PkgDesc
                            if (dr.IsDBNull(colDesc)) // if reader contains DBNull in this column
                                pkg.PkgDesc = null; // make null in the object
                            else // if not null
                                pkg.PkgDesc = (string)dr["PkgDesc"];

                            int colAC = dr.GetOrdinal("PkgAgencyCommission"); // column number of PkgAgencyCommission
                            if (dr.IsDBNull(colAC)) // if reader contains DBNull in this column
                                pkg.PkgAgencyCommission = null; // make null in the object
                            else // if not null
                                pkg.PkgAgencyCommission = Convert.ToDecimal(dr["PkgAgencyCommission"]);
                        }
                    }
                }
            }
            return pkg;
        }
    }
}
