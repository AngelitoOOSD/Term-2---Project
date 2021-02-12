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
    public partial class frmAddNewProductToPackage : Form
    {
        public frmAddNewProductToPackage()
        {
            InitializeComponent();
        }
        private void frmAddNewProductToPackage_Load(object sender, EventArgs e)
        {
            DisplayPackage(); //On load, display products
        }

        public List<Products> product; //current product coming from main form

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayPackage()
        {
            foreach(Products p in product) 
            lbxAvailableProducts.Items.Add(p.ProdName); //display products
        }
    }
}
