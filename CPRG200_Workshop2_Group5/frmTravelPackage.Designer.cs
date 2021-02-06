namespace CPRG200_Workshop2_Group5
{
    partial class frmTravelPackage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label packageIdLabel1;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label supplierIdLabel1;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label productSupplierIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lbxAvailableSuppliers = new System.Windows.Forms.TabPage();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.btnModPackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnNewProducts = new System.Windows.Forms.Button();
            this.lstCurrentProducts = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPackageId = new System.Windows.Forms.ComboBox();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.cboSupplierId = new System.Windows.Forms.ComboBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.tabProductSupplier = new System.Windows.Forms.TabPage();
            this.btnDeleteProductSup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModProdSup = new System.Windows.Forms.Button();
            this.btnAddProdSup = new System.Windows.Forms.Button();
            this.supNameTextBox = new System.Windows.Forms.TextBox();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productSupplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            packageIdLabel1 = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            supplierIdLabel1 = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            productSupplierIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.lbxAvailableSuppliers.SuspendLayout();
            this.tabSupplier.SuspendLayout();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.tabProductSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // packageIdLabel1
            // 
            packageIdLabel1.AutoSize = true;
            packageIdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            packageIdLabel1.Location = new System.Drawing.Point(64, 63);
            packageIdLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            packageIdLabel1.Name = "packageIdLabel1";
            packageIdLabel1.Size = new System.Drawing.Size(116, 25);
            packageIdLabel1.TabIndex = 13;
            packageIdLabel1.Text = "Package Id:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(64, 346);
            pkgAgencyCommissionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(198, 25);
            pkgAgencyCommissionLabel.TabIndex = 2;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(64, 261);
            pkgBasePriceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(112, 25);
            pkgBasePriceLabel.TabIndex = 4;
            pkgBasePriceLabel.Text = "Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(64, 305);
            pkgDescLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(115, 25);
            pkgDescLabel.TabIndex = 6;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(64, 215);
            pkgEndDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(99, 25);
            pkgEndDateLabel.TabIndex = 8;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(64, 111);
            pkgNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(152, 25);
            pkgNameLabel.TabIndex = 10;
            pkgNameLabel.Text = "Package Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(64, 165);
            pkgStartDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(105, 25);
            pkgStartDateLabel.TabIndex = 12;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // supplierIdLabel1
            // 
            supplierIdLabel1.AutoSize = true;
            supplierIdLabel1.Location = new System.Drawing.Point(81, 180);
            supplierIdLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            supplierIdLabel1.Name = "supplierIdLabel1";
            supplierIdLabel1.Size = new System.Drawing.Size(0, 20);
            supplierIdLabel1.TabIndex = 4;
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(352, 117);
            supNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(0, 20);
            supNameLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(161, 289);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 24);
            label1.TabIndex = 22;
            label1.Text = "Supplier Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(161, 183);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 24);
            label2.TabIndex = 20;
            label2.Text = "Product Name:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productIdLabel.Location = new System.Drawing.Point(161, 139);
            productIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(100, 24);
            productIdLabel.TabIndex = 14;
            productIdLabel.Text = "Product Id:";
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productSupplierIdLabel.Location = new System.Drawing.Point(161, 85);
            productSupplierIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(175, 24);
            productSupplierIdLabel.TabIndex = 16;
            productSupplierIdLabel.Text = "Product Supplier Id:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierIdLabel.Location = new System.Drawing.Point(161, 234);
            supplierIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(105, 24);
            supplierIdLabel.TabIndex = 18;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lbxAvailableSuppliers);
            this.tabControl1.Controls.Add(this.tabSupplier);
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabProductSupplier);
            this.tabControl1.Location = new System.Drawing.Point(20, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 553);
            this.tabControl1.TabIndex = 1;
            // 
            // lbxAvailableSuppliers
            // 
            this.lbxAvailableSuppliers.AutoScroll = true;
            this.lbxAvailableSuppliers.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbxAvailableSuppliers.Controls.Add(this.btnExitApplication);
            this.lbxAvailableSuppliers.Controls.Add(this.btnModPackage);
            this.lbxAvailableSuppliers.Controls.Add(this.btnAddPackage);
            this.lbxAvailableSuppliers.Controls.Add(this.btnNewProducts);
            this.lbxAvailableSuppliers.Controls.Add(this.lstCurrentProducts);
            this.lbxAvailableSuppliers.Controls.Add(this.label3);
            this.lbxAvailableSuppliers.Controls.Add(packageIdLabel1);
            this.lbxAvailableSuppliers.Controls.Add(this.cboPackageId);
            this.lbxAvailableSuppliers.Controls.Add(pkgAgencyCommissionLabel);
            this.lbxAvailableSuppliers.Controls.Add(this.txtPkgAgencyCommission);
            this.lbxAvailableSuppliers.Controls.Add(pkgBasePriceLabel);
            this.lbxAvailableSuppliers.Controls.Add(this.txtPkgBasePrice);
            this.lbxAvailableSuppliers.Controls.Add(pkgDescLabel);
            this.lbxAvailableSuppliers.Controls.Add(this.txtPkgDesc);
            this.lbxAvailableSuppliers.Controls.Add(pkgEndDateLabel);
            this.lbxAvailableSuppliers.Controls.Add(this.pkgEndDateDateTimePicker);
            this.lbxAvailableSuppliers.Controls.Add(pkgNameLabel);
            this.lbxAvailableSuppliers.Controls.Add(this.txtPkgName);
            this.lbxAvailableSuppliers.Controls.Add(pkgStartDateLabel);
            this.lbxAvailableSuppliers.Controls.Add(this.pkgStartDateDateTimePicker);
            this.lbxAvailableSuppliers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbxAvailableSuppliers.Location = new System.Drawing.Point(4, 29);
            this.lbxAvailableSuppliers.Margin = new System.Windows.Forms.Padding(5);
            this.lbxAvailableSuppliers.Name = "lbxAvailableSuppliers";
            this.lbxAvailableSuppliers.Padding = new System.Windows.Forms.Padding(5);
            this.lbxAvailableSuppliers.Size = new System.Drawing.Size(1009, 520);
            this.lbxAvailableSuppliers.TabIndex = 0;
            this.lbxAvailableSuppliers.Text = "TravelPackage";
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApplication.Location = new System.Drawing.Point(745, 431);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(94, 44);
            this.btnExitApplication.TabIndex = 30;
            this.btnExitApplication.Text = "&Exit";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            // 
            // btnModPackage
            // 
            this.btnModPackage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModPackage.Location = new System.Drawing.Point(556, 431);
            this.btnModPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnModPackage.Name = "btnModPackage";
            this.btnModPackage.Size = new System.Drawing.Size(168, 44);
            this.btnModPackage.TabIndex = 29;
            this.btnModPackage.Text = "&Modify Package";
            this.btnModPackage.UseVisualStyleBackColor = false;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackage.Location = new System.Drawing.Point(163, 431);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(168, 44);
            this.btnAddPackage.TabIndex = 28;
            this.btnAddPackage.Text = "&Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = false;
            // 
            // btnNewProducts
            // 
            this.btnNewProducts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProducts.Location = new System.Drawing.Point(347, 431);
            this.btnNewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewProducts.Name = "btnNewProducts";
            this.btnNewProducts.Size = new System.Drawing.Size(179, 44);
            this.btnNewProducts.TabIndex = 27;
            this.btnNewProducts.Text = "Add New Product";
            this.btnNewProducts.UseVisualStyleBackColor = false;
            // 
            // lstCurrentProducts
            // 
            this.lstCurrentProducts.FormattingEnabled = true;
            this.lstCurrentProducts.ItemHeight = 20;
            this.lstCurrentProducts.Location = new System.Drawing.Point(693, 76);
            this.lstCurrentProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lstCurrentProducts.Name = "lstCurrentProducts";
            this.lstCurrentProducts.Size = new System.Drawing.Size(265, 324);
            this.lstCurrentProducts.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Current Package Products:";
            // 
            // cboPackageId
            // 
            this.cboPackageId.FormattingEnabled = true;
            this.cboPackageId.Location = new System.Drawing.Point(272, 62);
            this.cboPackageId.Margin = new System.Windows.Forms.Padding(5);
            this.cboPackageId.Name = "cboPackageId";
            this.cboPackageId.Size = new System.Drawing.Size(199, 28);
            this.cboPackageId.TabIndex = 14;
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(272, 344);
            this.txtPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(5);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(212, 27);
            this.txtPkgAgencyCommission.TabIndex = 3;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(272, 257);
            this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(212, 27);
            this.txtPkgBasePrice.TabIndex = 5;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(272, 302);
            this.txtPkgDesc.Margin = new System.Windows.Forms.Padding(5);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(373, 27);
            this.txtPkgDesc.TabIndex = 7;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(272, 210);
            this.pkgEndDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(212, 27);
            this.pkgEndDateDateTimePicker.TabIndex = 9;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(272, 107);
            this.txtPkgName.Margin = new System.Windows.Forms.Padding(5);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(330, 27);
            this.txtPkgName.TabIndex = 11;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(272, 160);
            this.pkgStartDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(212, 27);
            this.pkgStartDateDateTimePicker.TabIndex = 13;
            // 
            // tabSupplier
            // 
            this.tabSupplier.AccessibleName = "";
            this.tabSupplier.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabSupplier.Controls.Add(this.label5);
            this.tabSupplier.Controls.Add(this.label4);
            this.tabSupplier.Controls.Add(this.btnDeleteSupplier);
            this.tabSupplier.Controls.Add(this.btnAddSupplier);
            this.tabSupplier.Controls.Add(this.btnExit);
            this.tabSupplier.Controls.Add(this.btnEditSupplier);
            this.tabSupplier.Controls.Add(supplierIdLabel1);
            this.tabSupplier.Controls.Add(this.cboSupplierId);
            this.tabSupplier.Controls.Add(supNameLabel);
            this.tabSupplier.Controls.Add(this.txtSupName);
            this.tabSupplier.Location = new System.Drawing.Point(4, 29);
            this.tabSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Padding = new System.Windows.Forms.Padding(5);
            this.tabSupplier.Size = new System.Drawing.Size(1009, 520);
            this.tabSupplier.TabIndex = 1;
            this.tabSupplier.Tag = "";
            this.tabSupplier.Text = "Supplier Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Supplier Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Supplier Id:";
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.Location = new System.Drawing.Point(494, 362);
            this.btnDeleteSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(148, 51);
            this.btnDeleteSupplier.TabIndex = 9;
            this.btnDeleteSupplier.Text = "&Delete Supplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Location = new System.Drawing.Point(160, 362);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(137, 51);
            this.btnAddSupplier.TabIndex = 8;
            this.btnAddSupplier.Text = "&Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(661, 362);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 51);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.Location = new System.Drawing.Point(317, 362);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(157, 51);
            this.btnEditSupplier.TabIndex = 6;
            this.btnEditSupplier.Text = "&Modify Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            // 
            // cboSupplierId
            // 
            this.cboSupplierId.FormattingEnabled = true;
            this.cboSupplierId.Location = new System.Drawing.Point(298, 155);
            this.cboSupplierId.Margin = new System.Windows.Forms.Padding(5);
            this.cboSupplierId.Name = "cboSupplierId";
            this.cboSupplierId.Size = new System.Drawing.Size(105, 28);
            this.cboSupplierId.TabIndex = 5;
            // 
            // txtSupName
            // 
            this.txtSupName.Enabled = false;
            this.txtSupName.Location = new System.Drawing.Point(298, 210);
            this.txtSupName.Margin = new System.Windows.Forms.Padding(5);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(455, 27);
            this.txtSupName.TabIndex = 1;
            // 
            // tabProducts
            // 
            this.tabProducts.AutoScroll = true;
            this.tabProducts.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabProducts.Controls.Add(this.lblProducts);
            this.tabProducts.Controls.Add(this.btnExit2);
            this.tabProducts.Controls.Add(this.btnDelete);
            this.tabProducts.Controls.Add(this.btnModify);
            this.tabProducts.Controls.Add(this.btnAdd);
            this.tabProducts.Controls.Add(this.productDataGridView);
            this.tabProducts.Location = new System.Drawing.Point(4, 29);
            this.tabProducts.Margin = new System.Windows.Forms.Padding(5);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(5);
            this.tabProducts.Size = new System.Drawing.Size(1009, 520);
            this.tabProducts.TabIndex = 2;
            this.tabProducts.Text = "Products";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(110, 44);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(248, 25);
            this.lblProducts.TabIndex = 8;
            this.lblProducts.Text = "Select A Product to Edit:";
            // 
            // btnExit2
            // 
            this.btnExit2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2.Location = new System.Drawing.Point(779, 458);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(95, 49);
            this.btnExit2.TabIndex = 7;
            this.btnExit2.Text = "&Exit";
            this.btnExit2.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(558, 460);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 45);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Delete Products";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(335, 460);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(176, 45);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "&Modify Products";
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(140, 459);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 47);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add Products";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(115, 83);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(794, 344);
            this.productDataGridView.TabIndex = 0;
            // 
            // tabProductSupplier
            // 
            this.tabProductSupplier.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabProductSupplier.Controls.Add(this.btnDeleteProductSup);
            this.tabProductSupplier.Controls.Add(this.button1);
            this.tabProductSupplier.Controls.Add(this.btnModProdSup);
            this.tabProductSupplier.Controls.Add(this.btnAddProdSup);
            this.tabProductSupplier.Controls.Add(label1);
            this.tabProductSupplier.Controls.Add(this.supNameTextBox);
            this.tabProductSupplier.Controls.Add(label2);
            this.tabProductSupplier.Controls.Add(this.prodNameTextBox);
            this.tabProductSupplier.Controls.Add(productIdLabel);
            this.tabProductSupplier.Controls.Add(this.productIdTextBox);
            this.tabProductSupplier.Controls.Add(productSupplierIdLabel);
            this.tabProductSupplier.Controls.Add(this.productSupplierIdComboBox);
            this.tabProductSupplier.Controls.Add(supplierIdLabel);
            this.tabProductSupplier.Controls.Add(this.supplierIdTextBox);
            this.tabProductSupplier.Location = new System.Drawing.Point(4, 29);
            this.tabProductSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.tabProductSupplier.Name = "tabProductSupplier";
            this.tabProductSupplier.Size = new System.Drawing.Size(1009, 520);
            this.tabProductSupplier.TabIndex = 3;
            this.tabProductSupplier.Text = "Product Supplier";
            // 
            // btnDeleteProductSup
            // 
            this.btnDeleteProductSup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteProductSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProductSup.Location = new System.Drawing.Point(506, 376);
            this.btnDeleteProductSup.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDeleteProductSup.Name = "btnDeleteProductSup";
            this.btnDeleteProductSup.Size = new System.Drawing.Size(159, 49);
            this.btnDeleteProductSup.TabIndex = 27;
            this.btnDeleteProductSup.Text = "&Delete";
            this.btnDeleteProductSup.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 49);
            this.button1.TabIndex = 26;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnModProdSup
            // 
            this.btnModProdSup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModProdSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModProdSup.Location = new System.Drawing.Point(338, 376);
            this.btnModProdSup.Margin = new System.Windows.Forms.Padding(5);
            this.btnModProdSup.Name = "btnModProdSup";
            this.btnModProdSup.Size = new System.Drawing.Size(159, 49);
            this.btnModProdSup.TabIndex = 25;
            this.btnModProdSup.Text = "Modify";
            this.btnModProdSup.UseVisualStyleBackColor = false;
            // 
            // btnAddProdSup
            // 
            this.btnAddProdSup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProdSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProdSup.Location = new System.Drawing.Point(200, 376);
            this.btnAddProdSup.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddProdSup.Name = "btnAddProdSup";
            this.btnAddProdSup.Size = new System.Drawing.Size(119, 49);
            this.btnAddProdSup.TabIndex = 24;
            this.btnAddProdSup.Text = "Add";
            this.btnAddProdSup.UseVisualStyleBackColor = false;
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.Enabled = false;
            this.supNameTextBox.Location = new System.Drawing.Point(338, 286);
            this.supNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.supNameTextBox.Name = "supNameTextBox";
            this.supNameTextBox.ReadOnly = true;
            this.supNameTextBox.Size = new System.Drawing.Size(457, 27);
            this.supNameTextBox.TabIndex = 23;
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.Enabled = false;
            this.prodNameTextBox.Location = new System.Drawing.Point(338, 179);
            this.prodNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.ReadOnly = true;
            this.prodNameTextBox.Size = new System.Drawing.Size(457, 27);
            this.prodNameTextBox.TabIndex = 21;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Enabled = false;
            this.productIdTextBox.Location = new System.Drawing.Point(338, 142);
            this.productIdTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(240, 27);
            this.productIdTextBox.TabIndex = 15;
            // 
            // productSupplierIdComboBox
            // 
            this.productSupplierIdComboBox.FormattingEnabled = true;
            this.productSupplierIdComboBox.Location = new System.Drawing.Point(390, 85);
            this.productSupplierIdComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.productSupplierIdComboBox.Name = "productSupplierIdComboBox";
            this.productSupplierIdComboBox.Size = new System.Drawing.Size(188, 28);
            this.productSupplierIdComboBox.TabIndex = 17;
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.Enabled = false;
            this.supplierIdTextBox.Location = new System.Drawing.Point(338, 230);
            this.supplierIdTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.ReadOnly = true;
            this.supplierIdTextBox.Size = new System.Drawing.Size(240, 27);
            this.supplierIdTextBox.TabIndex = 19;
            // 
            // frmTravelPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 590);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTravelPackage";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.lbxAvailableSuppliers.ResumeLayout(false);
            this.lbxAvailableSuppliers.PerformLayout();
            this.tabSupplier.ResumeLayout(false);
            this.tabSupplier.PerformLayout();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.tabProductSupplier.ResumeLayout(false);
            this.tabProductSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lbxAvailableSuppliers;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Button btnModPackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnNewProducts;
        private System.Windows.Forms.ListBox lstCurrentProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPackageId;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.TabPage tabSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.ComboBox cboSupplierId;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.TabPage tabProductSupplier;
        private System.Windows.Forms.Button btnDeleteProductSup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModProdSup;
        private System.Windows.Forms.Button btnAddProdSup;
        private System.Windows.Forms.TextBox supNameTextBox;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.ComboBox productSupplierIdComboBox;
        private System.Windows.Forms.TextBox supplierIdTextBox;
    }
}

