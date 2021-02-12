using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPackageDB
{

    public class ProductsDB
    {
        //Get products from db using packageId from Packages
        public static List<Products> GetProdName(int pkgID)
        {
            List<Products> product = new List<Products>();//Empty class

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "select ProdName from Packages " +
                    "left join Packages_Products_Suppliers as PPS on Packages.PackageId = PPS.PackageId " +
                    "left join Products_Suppliers as PS on PPS.ProductSupplierId = PS.ProductSupplierId " +
                    "left join Products on PS.ProductId = Products.ProductId " +
                    "where Packages.PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", pkgID);

                    //run the command and process data
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader
                        (System.Data.CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                        {
                            var prod = new Products();
                            prod.ProdName = (string)dr["ProdName"].ToString();

                            product.Add(prod);
                        }
                    }
                }
            }
            return product;
        }
    }
}
