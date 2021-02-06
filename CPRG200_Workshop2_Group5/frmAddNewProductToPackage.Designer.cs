
namespace CPRG200_Workshop2_Group5
{
    partial class frmAddNewProductToPackage
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label packageIdLabel1;
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtProdSupID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbxAvailableSupplier = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxAvailableProducts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            packageIdLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPackageId
            // 
            this.txtPackageId.Enabled = false;
            this.txtPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageId.Location = new System.Drawing.Point(35, 56);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.ReadOnly = true;
            this.txtPackageId.Size = new System.Drawing.Size(250, 28);
            this.txtPackageId.TabIndex = 45;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(322, 363);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(232, 42);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(318, 26);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(175, 24);
            label1.TabIndex = 43;
            label1.Text = "Product Supplier Id:";
            // 
            // txtProdSupID
            // 
            this.txtProdSupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSupID.Location = new System.Drawing.Point(322, 56);
            this.txtProdSupID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdSupID.Name = "txtProdSupID";
            this.txtProdSupID.ReadOnly = true;
            this.txtProdSupID.Size = new System.Drawing.Size(296, 28);
            this.txtProdSupID.TabIndex = 42;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(78, 363);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(232, 42);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // packageIdLabel1
            // 
            packageIdLabel1.AutoSize = true;
            packageIdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            packageIdLabel1.Location = new System.Drawing.Point(31, 26);
            packageIdLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            packageIdLabel1.Name = "packageIdLabel1";
            packageIdLabel1.Size = new System.Drawing.Size(108, 24);
            packageIdLabel1.TabIndex = 40;
            packageIdLabel1.Text = "Package Id:";
            // 
            // lbxAvailableSupplier
            // 
            this.lbxAvailableSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAvailableSupplier.FormattingEnabled = true;
            this.lbxAvailableSupplier.ItemHeight = 22;
            this.lbxAvailableSupplier.Location = new System.Drawing.Point(322, 139);
            this.lbxAvailableSupplier.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbxAvailableSupplier.Name = "lbxAvailableSupplier";
            this.lbxAvailableSupplier.Size = new System.Drawing.Size(296, 202);
            this.lbxAvailableSupplier.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Available Suppliers:";
            // 
            // lbxAvailableProducts
            // 
            this.lbxAvailableProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAvailableProducts.FormattingEnabled = true;
            this.lbxAvailableProducts.ItemHeight = 22;
            this.lbxAvailableProducts.Location = new System.Drawing.Point(34, 139);
            this.lbxAvailableProducts.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbxAvailableProducts.Name = "lbxAvailableProducts";
            this.lbxAvailableProducts.Size = new System.Drawing.Size(250, 202);
            this.lbxAvailableProducts.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Available Products:";
            // 
            // frmAddNewProductToPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 422);
            this.Controls.Add(this.txtPackageId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtProdSupID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(packageIdLabel1);
            this.Controls.Add(this.lbxAvailableSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxAvailableProducts);
            this.Controls.Add(this.label4);
            this.Name = "frmAddNewProductToPackage";
            this.Text = "frmAddNewProductToPackage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtProdSupID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbxAvailableSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxAvailableProducts;
        private System.Windows.Forms.Label label4;
    }
}