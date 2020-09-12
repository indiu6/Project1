namespace ContactManager
{
    partial class SecondaryContactForm
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
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.cboEmailType = new System.Windows.Forms.ComboBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.cboPhoneType = new System.Windows.Forms.ComboBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.mskZip = new System.Windows.Forms.MaskedTextBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.cboAddressType = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.grbEmail.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.grbAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(194, 142);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(172, 34);
            this.btnAddPhoto.TabIndex = 8;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(290, 84);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(178, 22);
            this.txtLname.TabIndex = 10;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(290, 43);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(178, 22);
            this.txtFname.TabIndex = 9;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(191, 89);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(80, 17);
            this.lblLname.TabIndex = 7;
            this.lblLname.Text = "Last Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(191, 43);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(80, 17);
            this.lblFname.TabIndex = 6;
            this.lblFname.Text = "First Name:";
            // 
            // picContact
            // 
            this.picContact.Image = global::ContactManager.Properties.Resources.iconfinder_b_95_4230287;
            this.picContact.Location = new System.Drawing.Point(12, 12);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(163, 174);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContact.TabIndex = 5;
            this.picContact.TabStop = false;
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.cboEmailType);
            this.grbEmail.Controls.Add(this.lblEmailType);
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Location = new System.Drawing.Point(12, 362);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(483, 95);
            this.grbEmail.TabIndex = 12;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // cboEmailType
            // 
            this.cboEmailType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboEmailType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEmailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmailType.FormattingEnabled = true;
            this.cboEmailType.Items.AddRange(new object[] {
            "Home",
            "Business"});
            this.cboEmailType.Location = new System.Drawing.Point(356, 45);
            this.cboEmailType.Name = "cboEmailType";
            this.cboEmailType.Size = new System.Drawing.Size(121, 24);
            this.cboEmailType.TabIndex = 17;
            // 
            // lblEmailType
            // 
            this.lblEmailType.AutoSize = true;
            this.lblEmailType.Location = new System.Drawing.Point(310, 45);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(44, 17);
            this.lblEmailType.TabIndex = 17;
            this.lblEmailType.Text = "Type:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.mskPhone);
            this.grbPhone.Controls.Add(this.cboPhoneType);
            this.grbPhone.Controls.Add(this.lblPhoneType);
            this.grbPhone.Location = new System.Drawing.Point(12, 463);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(483, 95);
            this.grbPhone.TabIndex = 13;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(21, 41);
            this.mskPhone.Mask = "(000) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(269, 22);
            this.mskPhone.TabIndex = 20;
            // 
            // cboPhoneType
            // 
            this.cboPhoneType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboPhoneType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPhoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhoneType.FormattingEnabled = true;
            this.cboPhoneType.Items.AddRange(new object[] {
            "Home",
            "Business"});
            this.cboPhoneType.Location = new System.Drawing.Point(355, 39);
            this.cboPhoneType.Name = "cboPhoneType";
            this.cboPhoneType.Size = new System.Drawing.Size(121, 24);
            this.cboPhoneType.TabIndex = 18;
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Location = new System.Drawing.Point(310, 39);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(44, 17);
            this.lblPhoneType.TabIndex = 19;
            this.lblPhoneType.Text = "Type:";
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.mskZip);
            this.grbAddress.Controls.Add(this.cboProvince);
            this.grbAddress.Controls.Add(this.cboAddressType);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblAddressType);
            this.grbAddress.Location = new System.Drawing.Point(12, 192);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(483, 164);
            this.grbAddress.TabIndex = 20;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // mskZip
            // 
            this.mskZip.Location = new System.Drawing.Point(390, 121);
            this.mskZip.Mask = ">L0L 0L0|";
            this.mskZip.Name = "mskZip";
            this.mskZip.Size = new System.Drawing.Size(87, 22);
            this.mskZip.TabIndex = 19;
            // 
            // cboProvince
            // 
            this.cboProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NT",
            "NS",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.cboProvince.Location = new System.Drawing.Point(265, 119);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(57, 24);
            this.cboProvince.TabIndex = 18;
            // 
            // cboAddressType
            // 
            this.cboAddressType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboAddressType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAddressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddressType.FormattingEnabled = true;
            this.cboAddressType.Items.AddRange(new object[] {
            "Home",
            "Business"});
            this.cboAddressType.Location = new System.Drawing.Point(81, 32);
            this.cboAddressType.Name = "cboAddressType";
            this.cboAddressType.Size = new System.Drawing.Size(121, 24);
            this.cboAddressType.TabIndex = 16;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(352, 122);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(32, 17);
            this.lblZip.TabIndex = 15;
            this.lblZip.Text = "Zip:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(192, 119);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(67, 17);
            this.lblProvince.TabIndex = 13;
            this.lblProvince.Text = "Province:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(81, 119);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(87, 22);
            this.txtCity.TabIndex = 12;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(18, 119);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(81, 74);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(396, 22);
            this.txtStreet.TabIndex = 10;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(18, 79);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(50, 17);
            this.lblStreet.TabIndex = 9;
            this.lblStreet.Text = "Street:";
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Location = new System.Drawing.Point(18, 32);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(44, 17);
            this.lblAddressType.TabIndex = 8;
            this.lblAddressType.Text = "Type:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(367, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 34);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // SecondaryContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 616);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbEmail);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.picContact);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecondaryContactForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SecondaryContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        internal System.Windows.Forms.TextBox txtFname;
        internal System.Windows.Forms.TextBox txtLname;
        internal System.Windows.Forms.PictureBox picContact;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtStreet;
        internal System.Windows.Forms.ComboBox cboAddressType;
        internal System.Windows.Forms.ComboBox cboEmailType;
        internal System.Windows.Forms.ComboBox cboPhoneType;
        internal System.Windows.Forms.ComboBox cboProvince;
        internal System.Windows.Forms.MaskedTextBox mskZip;
        internal System.Windows.Forms.MaskedTextBox mskPhone;
    }
}