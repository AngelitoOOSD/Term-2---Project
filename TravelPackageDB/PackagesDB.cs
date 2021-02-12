using System;
using System.Collections.Generic;
using System.Data.SqlClient;//ADO.NET provider for SQL server
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPackageDB
{
    public class PackagesDB
    {
        public static List<Package> GetPackages()
        {
            List<Package> packages = new List<Package>();//Empty list
            //Package packages = new Package();

            using(SqlConnection connection = TravelExpertsDB.GetConnection())//Establish connection
            {
                //create SQL query
                string query = "SELECT PackageId, PkgName, " +
                    "PkgStartDate, PkgEndDate, PkgDesc, " +
                    "PkgBasePrice, PkgAgencyCommission " +
                    "FROM Packages";

                //create command object
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    //run the command 
                    using(SqlDataReader dr = cmd.ExecuteReader
                        (System.Data.CommandBehavior.CloseConnection)) //we can close connection as soon as done reading
                    {
                        while(dr.Read()) //while there is data to read....
                        {
                            //process the returned data
                            Package pkg = new Package();
                            pkg.PackageId = (int)dr["PackageId"];
                            pkg.PkgName = (string)dr["PkgName"];
                            pkg.PkgStartDate = (DateTime)dr["PkgStartDate"];
                            pkg.PkgEndDate = (DateTime)dr["PkgEndDate"];
                            pkg.PkgDesc = (string)dr["PkgDesc"];
                            pkg.PkgBasePrice = (decimal)dr["PkgBasePrice"];
                            pkg.PkgAgencyCommission = (decimal)dr["PkgAgencyCommission"];

                            packages.Add(pkg);
                        }
                    }
                }
            }
            return packages;
        }

        //get package by ID
        public static Package GetPackage(int pkgID)
        {
            Package package = new Package();//Empty class
            
            //establish connection
            using(SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT PackageId, PkgName, " +
                    "PkgStartDate, PkgEndDate, PkgDesc, " +
                    "PkgBasePrice, PkgAgencyCommission " +
                    "FROM Packages " +
                    "WHERE PackageId = @PackageId"; 
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", pkgID);

                    //run the command and process data
                    connection.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader
                        (System.Data.CommandBehavior.CloseConnection))
                    {
                        if(dr.Read())
                        {
                            package = new Package();
                            package.PackageId = (int)dr["PackageId"];
                            package.PkgName = dr["PkgName"].ToString();
                            package.PkgStartDate = (DateTime)dr["PkgStartDate"];
                            package.PkgEndDate = (DateTime)dr["PkgEndDate"];
                            package.PkgDesc = dr["PkgDesc"].ToString();
                            package.PkgBasePrice = (decimal)dr["PkgBasePrice"];
                            package.PkgAgencyCommission = (decimal)dr["PkgAgencyCommission"];
                        }
                    }
                }
            }
            return package;
        }
        

        //Save a new package to db
        public static int AddPackage(Package pkg)
        {
            int pkgID = 0;
            using(SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string insertStatement =
                    "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                    "OUTPUT INSERTED.PackageId " +
                    "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
                using(SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@PkgName", pkg.PkgName);
                    cmd.Parameters.AddWithValue("@PkgStartDate", pkg.PkgStartDate);
                    cmd.Parameters.AddWithValue("@PkgEndDate", pkg.PkgEndDate);
                    cmd.Parameters.AddWithValue("@PkgDesc", pkg.PkgDesc);
                    cmd.Parameters.AddWithValue("@PkgBasePrice", pkg.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@PkgAgencyCommission", pkg.PkgAgencyCommission);
                    connection.Open();
                    pkgID = (int)cmd.ExecuteScalar();//returns one value
                }
            }
            return pkgID;
        }

        //update package
        public static bool UpdatePackage(Package oldPkg, Package newPkg)//Takes two sets of Packages
        {
            bool result = true;
            using(SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string updateStatement = "UPDATE Packages SET " +
                    "PkgName = @NewPkgName, " +
                    "PkgStartDate = @NewPkgStartDate, " +
                    "PkgEndDate = @NewPkgEndDate, " +
                    "PkgDesc = @NewPkgDesc, " +
                    "PkgBasePrice = @NewPkgBasePrice, " +
                    "PkgAgencyCommission = @NewPkgCommission " +
                    "WHERE PackageId = @PackageId " +
                    "AND PkgName = @OldPkgName " +
                    "AND PkgStartDate = @OldPkgStartDate " +
                    "AND PkgEndDate = @OldPkgEndDate " +
                    "AND PkgDesc = @OldPkgDesc " +
                    "AND PkgBasePrice = @OldPkgBasePrice " +
                    "AND PkgAgencyCommission = @OldPkgAgencyCommission";
                using(SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@NewPkgName", newPkg.PkgName);
                    cmd.Parameters.AddWithValue("@NewPkgStartDate", newPkg.PkgStartDate);
                    cmd.Parameters.AddWithValue("@NewPkgEndDate", newPkg.PkgEndDate);
                    cmd.Parameters.AddWithValue("@NewPkgDesc", newPkg.PkgDesc);
                    cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPkg.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@NewPkgCommission", newPkg.PkgAgencyCommission);

                    cmd.Parameters.AddWithValue("@PackageId", oldPkg.PackageId);
                    cmd.Parameters.AddWithValue("@OldPkgName", oldPkg.PkgName);
                    cmd.Parameters.AddWithValue("@OldPkgStartDate", oldPkg.PkgStartDate);
                    cmd.Parameters.AddWithValue("@OldPkgEndDate", oldPkg.PkgEndDate);
                    cmd.Parameters.AddWithValue("@OldPkgDesc", oldPkg.PkgDesc);
                    cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPkg.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPkg.PkgAgencyCommission);

                    connection.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count == 0) //no rows updated
                        result = false;
                }
            }
            return result;
        }
    }
}
