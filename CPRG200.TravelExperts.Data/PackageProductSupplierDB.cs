using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG200.TravelExperts.Data
{
    /*
     * Purpose: Data access class for Packages_Products_Suppliers
     * Authors: Group 5
     * Date Created: 02/2021
     */
    public static class PackageProductSupplierDB
    {
        /// <summary>
        /// Katrina Spencer: Retrieves list of products-suppliers with given packageid
        /// </summary>
        /// <param name="pkgId">id of package to get</param>
        /// <returns>products-suppliers of a package</returns>
        public static List<PackageProductSupplier> GetProductsSuppliersByPackageId(int pkgId)
        {
            List<PackageProductSupplier> ppsList = new List<PackageProductSupplier>(); // empty
            PackageProductSupplier pps;
            // connection
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT pps.ProductSupplierID, " +
                               "ProdName + ', ' + SupName AS ProductSupplierName " +
                               "FROM Packages_Products_Suppliers AS pps " +
                               "JOIN Products_Suppliers AS ps " +
                               "ON pps.ProductSupplierId = ps.ProductSupplierId " +
                               "JOIN Products AS p " +
                               "ON ps.ProductId = p.ProductId " +
                               "JOIN Suppliers AS s " +
                               "ON ps.SupplierId = s.SupplierId " +
                               "WHERE PackageId = @PackageId " +
                               "ORDER BY ProductSupplierId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", pkgId);
                    // run command and process data
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (dr.Read()) // while there is data
                        {
                            pps = new PackageProductSupplier();
                            pps.ProductSupplierId = (int)dr["ProductSupplierId"];
                            pps.ProductSupplierName = (string)dr["ProductSupplierName"];
                            ppsList.Add(pps);
                        }
                    }
                }
            }
            return ppsList;
        }
    }
}
