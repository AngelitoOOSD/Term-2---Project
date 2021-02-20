
namespace CPRG200_Workshop2_Group5
{
    partial class frmAddModifyPackage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateTextBox = new System.Windows.Forms.TextBox();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateTextBox = new System.Windows.Forms.TextBox();
            this.btnSavePkg = new System.Windows.Forms.Button();
            this.btnClosePkg = new System.Windows.Forms.Button();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(24, 25);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(84, 17);
            packageIdLabel.TabIndex = 1;
            packageIdLabel.Text = "Package ID:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(24, 193);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(138, 17);
            pkgAgencyCommissionLabel.TabIndex = 3;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(24, 165);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(80, 17);
            pkgBasePriceLabel.TabIndex = 5;
            pkgBasePriceLabel.Text = "Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(24, 137);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(83, 17);
            pkgDescLabel.TabIndex = 7;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(24, 109);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(71, 17);
            pkgEndDateLabel.TabIndex = 9;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(24, 53);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(49, 17);
            pkgNameLabel.TabIndex = 11;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(24, 81);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(76, 17);
            pkgStartDateLabel.TabIndex = 13;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.packageIdTextBox.Enabled = false;
            this.packageIdTextBox.Location = new System.Drawing.Point(196, 22);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.packageIdTextBox.TabIndex = 2;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(CPRG200.TravelExperts.Data.Package);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(196, 190);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(100, 22);
            this.pkgAgencyCommissionTextBox.TabIndex = 4;
            this.pkgAgencyCommissionTextBox.Tag = "Agency Commission";
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(196, 162);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.pkgBasePriceTextBox.TabIndex = 6;
            this.pkgBasePriceTextBox.Tag = "Base Price";
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(196, 134);
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(100, 22);
            this.pkgDescTextBox.TabIndex = 8;
            this.pkgDescTextBox.Tag = "Description";
            // 
            // pkgEndDateTextBox
            // 
            this.pkgEndDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateTextBox.Location = new System.Drawing.Point(196, 106);
            this.pkgEndDateTextBox.Name = "pkgEndDateTextBox";
            this.pkgEndDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.pkgEndDateTextBox.TabIndex = 10;
            this.pkgEndDateTextBox.Tag = "End Date";
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(196, 50);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.pkgNameTextBox.TabIndex = 12;
            this.pkgNameTextBox.Tag = "Name";
            // 
            // pkgStartDateTextBox
            // 
            this.pkgStartDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateTextBox.Location = new System.Drawing.Point(196, 78);
            this.pkgStartDateTextBox.Name = "pkgStartDateTextBox";
            this.pkgStartDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.pkgStartDateTextBox.TabIndex = 14;
            this.pkgStartDateTextBox.Tag = "Start Date";
            // 
            // btnSavePkg
            // 
            this.btnSavePkg.Location = new System.Drawing.Point(27, 238);
            this.btnSavePkg.Name = "btnSavePkg";
            this.btnSavePkg.Size = new System.Drawing.Size(75, 23);
            this.btnSavePkg.TabIndex = 15;
            this.btnSavePkg.Text = "&Save";
            this.btnSavePkg.UseVisualStyleBackColor = true;
            // 
            // btnClosePkg
            // 
            this.btnClosePkg.Location = new System.Drawing.Point(221, 238);
            this.btnClosePkg.Name = "btnClosePkg";
            this.btnClosePkg.Size = new System.Drawing.Size(75, 23);
            this.btnClosePkg.TabIndex = 16;
            this.btnClosePkg.Text = "Close";
            this.btnClosePkg.UseVisualStyleBackColor = true;
            this.btnClosePkg.Click += new System.EventHandler(this.btnClosePkg_Click);
            // 
            // frmModifyPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 289);
            this.Controls.Add(this.btnClosePkg);
            this.Controls.Add(this.btnSavePkg);
            this.Controls.Add(packageIdLabel);
            this.Controls.Add(this.packageIdTextBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateTextBox);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateTextBox);
            this.Name = "frmModifyPackage";
            this.Text = "frmModifyPackage";
            this.Load += new System.EventHandler(this.frmModifyPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.TextBox pkgEndDateTextBox;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.TextBox pkgStartDateTextBox;
        private System.Windows.Forms.Button btnSavePkg;
        private System.Windows.Forms.Button btnClosePkg;
    }
}