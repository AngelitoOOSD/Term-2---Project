using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelPackageDB;


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
        private Package package; //current package
        private List<Products> product; //current product
        
        

        public frmTravelPackage()
        {
            InitializeComponent();
            
        }

        //Form load
        public void frmTravelPackage_Load(object sender, EventArgs e)
        {
            this.LoadPackageIDComboBox();//Load the combo box

            DisplayPackages();
        }

        //When user clicks the //EXIT// button, it closes the Application.
        private void btnExitApplication_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*When user clicks the "MODIFY PACKAGE" button on the Travel Package tab, it opens
         * the modify package form */
        private void btnModPackage_Click_1(object sender, EventArgs e)
        {
            frmModifyPackage modPackageForm = new frmModifyPackage();
            modPackageForm.package = package; //copy current customer to second form
            DialogResult result = modPackageForm.ShowDialog(); //Display second modal
            if (result == DialogResult.OK)
            {
                package = modPackageForm.package;//copy back current package
                this.DisplayPackages();//Display updated data
            }
            else if (result == DialogResult.Retry)
            {
                this.GetPackages(package.PackageId);
                if (package != null)
                    this.DisplayPackages();
                else
                    this.ClearControls();
            }
        }

        /* When user clicks the "ADD PACKAGE" button, it opens the add package Form */
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmAddPackage addPackageForm = new frmAddPackage();
            DialogResult result = addPackageForm.ShowDialog();//Show modify package form
            if(result == DialogResult.OK)
            {
                 package = addPackageForm.package; //set this package values the same as frmAddPackage's package
                try
                {
                    cboPackageId.SelectedIndex = package.PackageId;
                    this.DisplayPackages();
                }
                catch
                {
                }
            }
            
            //frmTravelPackage_Load(null, EventArgs.Empty);//Re-display the products
        }

        /* When user clicks the "ADD NEW PRODUCT" button, it adds a new
         * product to the database */
        private void btnNewProducts_Click_1(object sender, EventArgs e)
        {
            frmAddNewProductToPackage addProdForm = new frmAddNewProductToPackage();
            addProdForm.product = product;
            DialogResult result = addProdForm.ShowDialog();
        }

        //clear controls
        private void ClearControls()
        {
            cboPackageId.Text = "";
            txtPkgName.Text = "";
            txtPkgDesc.Text = "";
            txtPkgBasePrice.Text = "";
            txtPkgAgencyCommission.Text = "";
        }

        //selected index changed in combo box
        private void cboPackageId_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.ClearListBox();
            int PackageId = Convert.ToInt32(cboPackageId.SelectedIndex) + 1; //get combobox value in int + 1 for human count

            this.GetPackages(PackageId); //get package using packageId
            this.GetProducts(PackageId);//get products using packageId
            if (package == null)
            {
                MessageBox.Show("Cannot display details");
            }
            else
            {
                this.DisplayPackages();//Display packages based on passed packageId
                this.DisplayListProdName();//Display products based on passed packageId
            }
        }

        //get packages by passing PackageId
        private void GetPackages(int PackageId)
        {
            try
            {
                package = PackagesDB.GetPackage(PackageId);
            }
            catch
            {
                
            }
        } 
        
        //get products by passing packageID. Called when dropdown list changes value
        public void GetProducts(int PackageId)
        {
            product = ProductsDB.GetProdName(PackageId);
        }

        //display the packages in the text boxes
        private void DisplayPackages()
        {
            txtPkgName.Text = package.PkgName;
            pkgStartDateDateTimePicker.Value = package.PkgStartDate;
            pkgEndDateDateTimePicker.Value = package.PkgEndDate;
            txtPkgBasePrice.Text = "$" + package.PkgBasePrice;
            txtPkgDesc.Text = package.PkgDesc;
            txtPkgAgencyCommission.Text = "$" + package.PkgAgencyCommission;
        }

        //Display products to listbox
        private void DisplayListProdName()
        {
            foreach(Products p in product)
               lstCurrentProducts.Items.Add(p.ProdName);
        }

        //clear list box
        private void ClearListBox()
        {
            lstCurrentProducts.Items.Clear();
        }

       
        //Method to load the combo box
        private void LoadPackageIDComboBox() 
        {
            List<Package> packageId = new List<Package>();
            packageId = PackagesDB.GetPackages().ToList();
            cboPackageId.DataSource = packageId;
            cboPackageId.DisplayMember = "PackageId";
        }
    }
}
