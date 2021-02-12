
namespace CPRG200_Workshop2_Group5
{
    partial class frmModifyPackage
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.btnExit4 = new System.Windows.Forms.Button();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.btnSaveMod = new System.Windows.Forms.Button();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(41, 38);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 24);
            label1.TabIndex = 55;
            label1.Text = "Package Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(41, 290);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(189, 24);
            label2.TabIndex = 49;
            label2.Text = "Agency Commission:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(41, 203);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 24);
            label3.TabIndex = 50;
            label3.Text = "Base Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(41, 245);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(109, 24);
            label4.TabIndex = 51;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(41, 163);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 24);
            label5.TabIndex = 52;
            label5.Text = "End Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(41, 76);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(144, 24);
            label6.TabIndex = 53;
            label6.Text = "Package Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(41, 120);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 24);
            label7.TabIndex = 54;
            label7.Text = "Start Date:";
            // 
            // btnExit4
            // 
            this.btnExit4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit4.Location = new System.Drawing.Point(354, 343);
            this.btnExit4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExit4.Name = "btnExit4";
            this.btnExit4.Size = new System.Drawing.Size(271, 50);
            this.btnExit4.TabIndex = 48;
            this.btnExit4.Text = "&Cancel";
            this.btnExit4.UseVisualStyleBackColor = false;
            this.btnExit4.Click += new System.EventHandler(this.btnExit4_Click);
            // 
            // txtPackageId
            // 
            this.txtPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageId.Location = new System.Drawing.Point(241, 36);
            this.txtPackageId.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(195, 28);
            this.txtPackageId.TabIndex = 47;
            // 
            // btnSaveMod
            // 
            this.btnSaveMod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMod.Location = new System.Drawing.Point(64, 343);
            this.btnSaveMod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSaveMod.Name = "btnSaveMod";
            this.btnSaveMod.Size = new System.Drawing.Size(271, 50);
            this.btnSaveMod.TabIndex = 46;
            this.btnSaveMod.Text = "&Save";
            this.btnSaveMod.UseVisualStyleBackColor = false;
            this.btnSaveMod.Click += new System.EventHandler(this.btnSaveMod_Click);
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(244, 285);
            this.txtPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(192, 28);
            this.txtPkgAgencyCommission.TabIndex = 40;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgBasePrice.Location = new System.Drawing.Point(244, 201);
            this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(192, 28);
            this.txtPkgBasePrice.TabIndex = 41;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgDesc.Location = new System.Drawing.Point(241, 243);
            this.txtPkgDesc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(402, 28);
            this.txtPkgDesc.TabIndex = 42;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(244, 159);
            this.pkgEndDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(192, 28);
            this.pkgEndDateDateTimePicker.TabIndex = 43;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgName.Location = new System.Drawing.Point(241, 71);
            this.txtPkgName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(402, 28);
            this.txtPkgName.TabIndex = 44;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(244, 115);
            this.pkgStartDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(192, 28);
            this.pkgStartDateDateTimePicker.TabIndex = 45;
            // 
            // frmModifyPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 417);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Controls.Add(this.btnExit4);
            this.Controls.Add(this.txtPackageId);
            this.Controls.Add(this.btnSaveMod);
            this.Controls.Add(this.txtPkgAgencyCommission);
            this.Controls.Add(this.txtPkgBasePrice);
            this.Controls.Add(this.txtPkgDesc);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Name = "frmModifyPackage";
            this.Text = "frmModifyPackage";
            this.Load += new System.EventHandler(this.frmModifyPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit4;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Button btnSaveMod;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
    }
}