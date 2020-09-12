namespace ContactManager
{
    partial class MainContactForm
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
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.pnlMiddleAndNote = new System.Windows.Forms.Panel();
            this.grbNotes = new System.Windows.Forms.GroupBox();
            this.txtDisplayNote = new System.Windows.Forms.TextBox();
            this.grbTakeNote = new System.Windows.Forms.GroupBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtTakeNote = new System.Windows.Forms.TextBox();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPhoneType = new System.Windows.Forms.TextBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmailType = new System.Windows.Forms.TextBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtAddressType = new System.Windows.Forms.TextBox();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.pnlMiddleAndNote.SuspendLayout();
            this.grbNotes.SuspendLayout();
            this.grbTakeNote.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.SuspendLayout();
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 16;
            this.lstContacts.Location = new System.Drawing.Point(12, 12);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(172, 516);
            this.lstContacts.Sorted = true;
            this.lstContacts.TabIndex = 0;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(12, 540);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(172, 34);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // pnlMiddleAndNote
            // 
            this.pnlMiddleAndNote.Controls.Add(this.grbNotes);
            this.pnlMiddleAndNote.Controls.Add(this.grbTakeNote);
            this.pnlMiddleAndNote.Controls.Add(this.grbPhone);
            this.pnlMiddleAndNote.Controls.Add(this.grbEmail);
            this.pnlMiddleAndNote.Controls.Add(this.grbAddress);
            this.pnlMiddleAndNote.Controls.Add(this.btnEditContact);
            this.pnlMiddleAndNote.Controls.Add(this.txtLname);
            this.pnlMiddleAndNote.Controls.Add(this.txtFname);
            this.pnlMiddleAndNote.Controls.Add(this.lblLname);
            this.pnlMiddleAndNote.Controls.Add(this.lblFname);
            this.pnlMiddleAndNote.Controls.Add(this.picContact);
            this.pnlMiddleAndNote.Enabled = false;
            this.pnlMiddleAndNote.Location = new System.Drawing.Point(190, 12);
            this.pnlMiddleAndNote.Name = "pnlMiddleAndNote";
            this.pnlMiddleAndNote.Size = new System.Drawing.Size(1032, 578);
            this.pnlMiddleAndNote.TabIndex = 2;
            // 
            // grbNotes
            // 
            this.grbNotes.Controls.Add(this.txtDisplayNote);
            this.grbNotes.Location = new System.Drawing.Point(536, 253);
            this.grbNotes.Name = "grbNotes";
            this.grbNotes.Size = new System.Drawing.Size(483, 309);
            this.grbNotes.TabIndex = 19;
            this.grbNotes.TabStop = false;
            this.grbNotes.Text = "Notes";
            // 
            // txtDisplayNote
            // 
            this.txtDisplayNote.Location = new System.Drawing.Point(19, 21);
            this.txtDisplayNote.Multiline = true;
            this.txtDisplayNote.Name = "txtDisplayNote";
            this.txtDisplayNote.ReadOnly = true;
            this.txtDisplayNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplayNote.Size = new System.Drawing.Size(443, 269);
            this.txtDisplayNote.TabIndex = 8;
            // 
            // grbTakeNote
            // 
            this.grbTakeNote.Controls.Add(this.btnAddNote);
            this.grbTakeNote.Controls.Add(this.txtTakeNote);
            this.grbTakeNote.Location = new System.Drawing.Point(536, 37);
            this.grbTakeNote.Name = "grbTakeNote";
            this.grbTakeNote.Size = new System.Drawing.Size(483, 208);
            this.grbTakeNote.TabIndex = 17;
            this.grbTakeNote.TabStop = false;
            this.grbTakeNote.Text = "Take a Note";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(329, 159);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(133, 34);
            this.btnAddNote.TabIndex = 18;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtTakeNote
            // 
            this.txtTakeNote.Location = new System.Drawing.Point(19, 21);
            this.txtTakeNote.Multiline = true;
            this.txtTakeNote.Name = "txtTakeNote";
            this.txtTakeNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTakeNote.Size = new System.Drawing.Size(443, 132);
            this.txtTakeNote.TabIndex = 8;
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.txtPhone);
            this.grbPhone.Controls.Add(this.txtPhoneType);
            this.grbPhone.Controls.Add(this.lblPhoneType);
            this.grbPhone.Location = new System.Drawing.Point(22, 467);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(483, 95);
            this.grbPhone.TabIndex = 7;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(21, 39);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(269, 22);
            this.txtPhone.TabIndex = 18;
            // 
            // txtPhoneType
            // 
            this.txtPhoneType.Location = new System.Drawing.Point(360, 39);
            this.txtPhoneType.Name = "txtPhoneType";
            this.txtPhoneType.ReadOnly = true;
            this.txtPhoneType.Size = new System.Drawing.Size(87, 22);
            this.txtPhoneType.TabIndex = 18;
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
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.txtEmailType);
            this.grbEmail.Controls.Add(this.lblEmailType);
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Location = new System.Drawing.Point(22, 366);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(483, 95);
            this.grbEmail.TabIndex = 6;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // txtEmailType
            // 
            this.txtEmailType.Location = new System.Drawing.Point(360, 45);
            this.txtEmailType.Name = "txtEmailType";
            this.txtEmailType.ReadOnly = true;
            this.txtEmailType.Size = new System.Drawing.Size(87, 22);
            this.txtEmailType.TabIndex = 17;
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
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(269, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.txtZip);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.txtProvince);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.txtAddressType);
            this.grbAddress.Controls.Add(this.lblAddressType);
            this.grbAddress.Location = new System.Drawing.Point(22, 196);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(483, 164);
            this.grbAddress.TabIndex = 5;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(390, 119);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(73, 22);
            this.txtZip.TabIndex = 16;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(352, 119);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(32, 17);
            this.lblZip.TabIndex = 15;
            this.lblZip.Text = "Zip:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(287, 119);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.Size = new System.Drawing.Size(42, 22);
            this.txtProvince.TabIndex = 14;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(214, 119);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(67, 17);
            this.lblProvince.TabIndex = 13;
            this.lblProvince.Text = "Province:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(81, 119);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
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
            this.txtStreet.ReadOnly = true;
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
            // txtAddressType
            // 
            this.txtAddressType.Location = new System.Drawing.Point(81, 32);
            this.txtAddressType.Name = "txtAddressType";
            this.txtAddressType.ReadOnly = true;
            this.txtAddressType.Size = new System.Drawing.Size(87, 22);
            this.txtAddressType.TabIndex = 8;
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
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(290, 146);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(172, 34);
            this.btnEditContact.TabIndex = 3;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(290, 88);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(178, 22);
            this.txtLname.TabIndex = 4;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(290, 47);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(178, 22);
            this.txtFname.TabIndex = 3;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(191, 93);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(80, 17);
            this.lblLname.TabIndex = 2;
            this.lblLname.Text = "Last Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(191, 47);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(80, 17);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "First Name:";
            // 
            // picContact
            // 
            this.picContact.Image = global::ContactManager.Properties.Resources.iconfinder_b_95_4230287;
            this.picContact.Location = new System.Drawing.Point(12, 16);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(163, 174);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContact.TabIndex = 0;
            this.picContact.TabStop = false;
            // 
            // MainContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 598);
            this.Controls.Add(this.pnlMiddleAndNote);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lstContacts);
            this.MaximizeBox = false;
            this.Name = "MainContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainContactForm_FormClosing);
            this.Load += new System.EventHandler(this.MainContactForm_Load);
            this.pnlMiddleAndNote.ResumeLayout(false);
            this.pnlMiddleAndNote.PerformLayout();
            this.grbNotes.ResumeLayout(false);
            this.grbNotes.PerformLayout();
            this.grbTakeNote.ResumeLayout(false);
            this.grbTakeNote.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Panel pnlMiddleAndNote;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtAddressType;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPhoneType;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.TextBox txtEmailType;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grbNotes;
        private System.Windows.Forms.TextBox txtDisplayNote;
        private System.Windows.Forms.GroupBox grbTakeNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.TextBox txtTakeNote;
    }
}

