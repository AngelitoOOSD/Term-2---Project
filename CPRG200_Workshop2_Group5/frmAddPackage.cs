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
    public partial class frmAddPackage : Form
    {
        public frmAddPackage()
        {
            InitializeComponent();
        }
        
        public Package package;//current package 

        //form loads
        private void frmAddPackage_Load(object sender, EventArgs e)
        {
           this.Text = "Add Package";
        }

        //SAVE BUTTON is clicked
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            //validation checks
           
           package = new Package();
           this.PutPackageData(package);
            try
            {
                package.PackageId = PackagesDB.AddPackage(package);
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        
        //Called when ADD button is clicked and is passed the current package values
        private void PutPackageData(Package package)
        {   
            package.PkgName = txtName.Text;
            package.PkgStartDate = pkgStartDateDateTimePicker.Value;
            package.PkgEndDate = pkgEndDateDateTimePicker.Value;
            package.PkgDesc = txtDescription.Text;
            package.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
        }

        private void btnExit5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
