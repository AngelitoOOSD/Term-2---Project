using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelPackageDB;

namespace CPRG200_Workshop2_Group5
{
    public partial class frmModifyPackage : Form
    {
        public frmModifyPackage()
        {
            InitializeComponent();
        }
       
        public Package package;//current package

        private void frmModifyPackage_Load(object sender, EventArgs e)
        {
            this.Text = "Modify Package";
            this.DisplayPackage();
        }

        private void DisplayPackage()
        {
            txtPackageId.Text = package.PackageId.ToString();
            txtPkgName.Text = package.PkgName;
            pkgStartDateDateTimePicker.Value = package.PkgStartDate;
            pkgEndDateDateTimePicker.Value = package.PkgEndDate;
            txtPkgBasePrice.Text = package.PkgBasePrice.ToString();
            txtPkgDesc.Text = package.PkgDesc;
            txtPkgAgencyCommission.Text = package.PkgAgencyCommission.ToString();
        }

        //SAVE UPDATE
        private void btnSaveMod_Click(object sender, EventArgs e)
        {
            //VALIDATE
            //if(IsValidData())
            Package newPackage = new Package();
            newPackage.PackageId = package.PackageId;
            this.PutPackageData(newPackage);
            try
            {
                if (!PackagesDB.UpdatePackage(package, newPackage)) //returned false
                {
                    MessageBox.Show("Another user has updated or " +
                                "deleted that package.", "Database Error");
                    this.DialogResult = DialogResult.Retry;
                }
                else //successful update
                {
                    package = newPackage;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void PutPackageData(Package package)
        {
            package.PkgName = txtPkgName.Text;
            package.PkgStartDate = pkgStartDateDateTimePicker.Value;
            package.PkgEndDate = pkgEndDateDateTimePicker.Value;
            package.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);//will throw format error if display method has "c" for currency
            package.PkgDesc = txtPkgDesc.Text;
            package.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyCommission.Text);
        }

        private void btnExit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
