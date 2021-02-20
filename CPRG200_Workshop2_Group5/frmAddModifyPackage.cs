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
    public partial class frmAddModifyPackage : Form
    {
        public frmAddModifyPackage()
        {
            InitializeComponent();
        }

        public bool addPackage; // true if Add, and false if Modify -Katrina
        public Package currentPkg; // frmMain sets current package -Katrina

        /// <summary>
        /// Katrina: Displays current package data when form loads
        /// </summary>
        private void frmModifyPackage_Load(object sender, EventArgs e)
        {
            if (addPackage) // if this is Add
            {
                this.Text = "Add Package";
            }
            else // Modify
            {
                this.Text = "Modify Package";
                DisplayCurrentPkg();
            }
            
        }
        /// <summary>
        /// Katrina: Displays current package if modify
        /// </summary>
        private void DisplayCurrentPkg()
        {
            packageIdTextBox.Text = currentPkg.PackageId.ToString();
            pkgNameTextBox.Text = currentPkg.PkgName.ToString();
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
        }

        /// <summary>
        /// Katrina: Saves changes to add or modify
        /// Katrina: Uses validation to check for valid dates, present strings, and number values
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // check if valid before accepting changes
            if (IsValidDates() && IsValidPkgData())
            {
                if (addPackage) // if this is Add
                {
                    currentPkg = new Package();
                    this.PutPackageData(currentPkg);
                    try
                    {
                        currentPkg.PackageId = PackageDB.AddPackage(currentPkg);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else // this is Modify
                {
                    // build Package object with the new data
                    Package newPkg = new Package();
                    newPkg.PackageId = currentPkg.PackageId;
                    this.PutPackageData(newPkg);
                    //// can't enter empty string for name
                    //newPkg.PkgName = currentPkg.PkgName;
                    //// can't enter empty string for description
                    //newPkg.PkgDesc = currentPkg.PkgDesc;
                    //// can't enter empty string for base price
                    //newPkg.PkgBasePrice = currentPkg.PkgBasePrice;

                    //// if start date is null
                    //if (pkgStartDateTextBox.Text == "")
                    //    newPkg.PkgStartDate = null;
                    //else
                    //    newPkg.PkgStartDate = Convert.ToDateTime(pkgStartDateTextBox.Text);
                    //// if end date is null
                    //if (pkgEndDateTextBox.Text == "")
                    //    newPkg.PkgEndDate = null;
                    //else
                    //    newPkg.PkgEndDate = Convert.ToDateTime(pkgEndDateTextBox.Text);
                    //// if agency commission is null
                    //if (pkgAgencyCommissionTextBox.Text == "")
                    //    newPkg.PkgAgencyCommission = null;
                    //else
                    //    newPkg.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);

                    try // try to update
                    {
                        if (!PackageDB.UpdatePackage(currentPkg, newPkg)) //failed
                        {
                            MessageBox.Show("Another user has updated or deleted current package", "Concurrency Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            currentPkg = newPkg;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while updating: " + ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }
        private void PutPackageData(Package package)
        {
            // can't enter empty string for name
            package.PkgName = currentPkg.PkgName;
            // can't enter empty string for description
            package.PkgDesc = currentPkg.PkgDesc;
            // can't enter empty string for base price
            package.PkgBasePrice = currentPkg.PkgBasePrice;

            // if start date is null
            if (pkgStartDateTextBox.Text == "")
                package.PkgStartDate = null;
            else
                package.PkgStartDate = Convert.ToDateTime(pkgStartDateTextBox.Text);
            // if end date is null
            if (pkgEndDateTextBox.Text == "")
                package.PkgEndDate = null;
            else
                package.PkgEndDate = Convert.ToDateTime(pkgEndDateTextBox.Text);
            // if agency commission is null
            if (pkgAgencyCommissionTextBox.Text == "")
                package.PkgAgencyCommission = null;
            else
                package.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);

        }

        /// <summary>
        /// Katrina: Checks if any date values are null before verifying if end date is later than start date and if in correct format
        /// </summary>
        /// <returns>if valid or not</returns>
        private bool IsValidDates()
        {
            bool valid = true; // empty is valid
            DateTime startDate;
            DateTime endDate;

            if (pkgStartDateTextBox.Text != "" && pkgEndDateTextBox.Text != "") // if dates not empty
            {
                // for Start Date input
                if (DateTime.TryParse(pkgStartDateTextBox.Text, out startDate)) // if valid date
                {
                    endDate = Convert.ToDateTime(pkgEndDateTextBox.Text);
                    // if start date is greater than end date
                    if (endDate <= startDate)
                    {
                        valid = false;
                        MessageBox.Show("Start Date must be earlier than End Date", "Data Error");
                        pkgStartDateTextBox.SelectAll();
                        pkgStartDateTextBox.Focus();
                    }
                }
                else // if invalid date
                {
                    valid = false;
                    MessageBox.Show("Please enter Start Date in format MM/DD/YYYY", "Data Error");
                    pkgStartDateTextBox.SelectAll();
                    pkgStartDateTextBox.Focus();
                }
                // for End Date input
                if (DateTime.TryParse(pkgEndDateTextBox.Text, out endDate)) // if valid date
                {
                    startDate = Convert.ToDateTime(pkgStartDateTextBox.Text);
                    // if start date is greater than end date
                    if (startDate >= endDate)
                    {
                        valid = false;
                        MessageBox.Show("End Date must be later than Start Date", "Data Error");
                        pkgEndDateTextBox.SelectAll();
                        pkgEndDateTextBox.Focus();
                    }
                }
                else // if invalid date
                {
                    valid = false;
                    MessageBox.Show("Please enter End Date in format MM/DD/YYYY", "Data Error");
                    pkgStartDateTextBox.SelectAll();
                    pkgStartDateTextBox.Focus();
                }
            }
            return valid;
        }
        /// <summary>
        /// Katrina: Validity of pkg input data
        /// </summary>
        private bool IsValidPkgData()
        {
            return
                Validator.IsPresent(pkgNameTextBox) &&
                Validator.IsPresent(pkgDescTextBox) &&
                Validator.IsPresent(pkgBasePriceTextBox) &&
                Validator.IsDecimal(pkgBasePriceTextBox) &&
                Validator.IsDecimal(pkgAgencyCommissionTextBox);
        }

        /// <summary>
        /// Katrina: Closes modfy form
        /// </summary>
        private void btnClosePkg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // class
} // namespace
