using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPRG200.TravelExperts.Data;

namespace CPRG200_Workshop2_Group5
{
    public partial class frmAddNewProductToPackage : Form
    {
        public frmAddNewProductToPackage()
        {
            InitializeComponent();
        }

        private void frmAddNewProductToPackage_Load_1(object sender, EventArgs e)
        {
            DisplayPackage(); //On load, display products
        }

        public List<Product> product; //current product coming from main form

        private void DisplayPackage()
        {
            foreach (Product p in product)
                lbxAvailableProducts.Items.Add(p.ProdName); //display products
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
