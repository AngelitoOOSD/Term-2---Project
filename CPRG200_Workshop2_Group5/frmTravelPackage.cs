using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* CPRG 200 Workshop 2 - Group 5
 * Build an application that uses the travel experts database.
 * The agents need to add/edit travel packages.  This function must allow the user to enter data for the package, and select from a product list to add products to the package.
 
The application will also require simple add/edit access for maintaining the product, suppliers, and product_suppliers data.

The tables that will be used by this part of the project are:
1.	Packages
2.	Products
3.	Products_suppliers
4.	Suppliers
5.	Packages_products_suppliers

Make sure that you validate the data before creating the package.
a)	the Agency Commission cannot be greater than the Base Price
b)	the Package End Date must be later than Package Start Date
c)	Package Name and Package Description cannot be null


 * Group Members: Jorge Perez
 *                Katrina Spencer
 *                Angelito Tuguinay
 *                Jetlyn Jhoy Sarmiento
 * Date: Feb 05, 2021.
 * 
 * Each group member should add the applicable code here for their repective form(s).
 */


namespace CPRG200_Workshop2_Group5
{
    public partial class frmTravelPackage : Form
    {
        public frmTravelPackage()
        {
            InitializeComponent();
        }

        //When user clicks the Exit button, it closes the Application.
        private void btnExitApplication_Click(object sender, EventArgs e)
        {

        }


        /*When user clicks the "Modify Package" button on the Travel Package tab, it opens
         * the modify package form */
        private void btnModPackage_Click(object sender, EventArgs e)
        {

        }

        /* When user clicks the "Add Package" button, it opens the add package Form */
        private void btnAddPackage_Click(object sender, EventArgs e)
        {

        }

        /* When user clicks the "Add New Product" button, it adds a new
         * product to the database */
        private void btnNewProducts_Click(object sender, EventArgs e)
        {

        }

        //Loads the packages form fields when the selected PackageID is changed.
        private void cboPackageId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
