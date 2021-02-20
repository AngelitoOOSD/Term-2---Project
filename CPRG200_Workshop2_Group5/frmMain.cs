using CPRG200.TravelExperts.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200_Workshop2_Group5
{
    public partial class frmMain : Form
    {
        Package currentPkg = null; // current package
        List<Package> packageIds = null; // all package ids
        List<PackageProductSupplier> currentPkgProdSup = null; // current pkg prod sup

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Katrina: Loads combobox list of package ids on-load
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadPkgComboBox();
        }

        /// <summary>
        /// Katrina: Loads combobox list of package ids
        /// </summary>
        private void LoadPkgComboBox()
        {
            packageIds = PackageDB.GetPackageIds();
            if (packageIds.Count > 0) // if there are packages
            {
                packageIdComboBox.DataSource = packageIds;
                packageIdComboBox.SelectedIndex = 0; // triggers selectedindexchanged
            }
            else // no packages
            {
                MessageBox.Show("There are no packages. Add a package in the database and restart the application ", "Empty Load");
                Application.Exit();
            }
        }

        /// <summary>
        /// Katrina: Package selection changes
        /// </summary>
        private void packageIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(packageIdComboBox.SelectedValue);
            try
            {
                currentPkg = PackageDB.GetPackage(selectedId);
                DisplayCurrentPkgData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving package with selected ID: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Katrina: Displays the current selected package
        /// </summary>
        private void DisplayCurrentPkgData()
        {
            if (currentPkg != null)
            {
                pkgNameTextBox.Text = currentPkg.PkgName;
                pkgBasePriceTextBox.Text = currentPkg.PkgBasePrice.ToString("c");
                // if start date is null -Katrina
                if (currentPkg.PkgStartDate == null)
                    pkgStartDateTextBox.Text = "";
                else
                {
                    DateTime startDate = (DateTime)currentPkg.PkgStartDate;
                    pkgStartDateTextBox.Text = startDate.ToShortDateString();
                }
                // if end date is null -Katrina
                if (currentPkg.PkgEndDate == null)
                    pkgEndDateTextBox.Text = "";
                else
                {
                    DateTime endDate = (DateTime)currentPkg.PkgEndDate;
                    pkgEndDateTextBox.Text = endDate.ToShortDateString();
                }
                // if description is null -Katrina
                if (currentPkg.PkgDesc == null)
                    pkgDescTextBox.Text = "";
                else
                {
                    string desc = (string)currentPkg.PkgDesc;
                    pkgDescTextBox.Text = desc;
                }
                // if agency commission is null -Katrina
                if (currentPkg.PkgAgencyCommission == null)
                    pkgAgencyCommissionTextBox.Text = "";
                else
                {
                    decimal commission = (decimal)currentPkg.PkgAgencyCommission;
                    pkgAgencyCommissionTextBox.Text = commission.ToString("c");
                }
                // get current package product supplier details -Katrina
                currentPkgProdSup = PackageProductSupplierDB.GetProductsSuppliersByPackageId(currentPkg.PackageId);
                packageProductSupplierDataGridView.DataSource = currentPkgProdSup;
            }
            else
                MessageBox.Show("This package does not exist. Please try again.");
                LoadPkgComboBox();
        }
        /// <summary>
        /// Katrina: Opens form for modifying package info
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmModifyPackage updateForm = new frmModifyPackage();
            updateForm.currentPkg = currentPkg; // set current package on update form -Katrina
            DialogResult result = updateForm.ShowDialog(); // display second form modal -Katrina
            if (result == DialogResult.OK)
            {
                currentPkg = updateForm.currentPkg; // receive current pkg from update form -Katrina     
            }
            else if (result == DialogResult.Retry)
            {
                currentPkg = PackageDB.GetPackage(currentPkg.PackageId);
            }
            DisplayCurrentPkgData();
        }

        /// <summary>
        /// Katrina Spencer: Opens form for adding new package
        /// </summary>
        private void btnAddPkg_Click(object sender, EventArgs e)
        {

        }

        // terminates application from pkg tab -Katrina
        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    } //class
} // namespace
