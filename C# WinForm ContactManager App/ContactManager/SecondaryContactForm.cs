using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class SecondaryContactForm : Form
    {
        // internal makes fields in 2ndFrom usable in any place at same project
        internal string firstName;
        internal string lastName;
        internal string addressType;
        internal string street;
        internal string city;
        internal string province;
        internal string zip;
        internal string email;
        internal string emailType;
        internal string phone;
        internal string phoneType;
        internal string imagePathContact;

        public SecondaryContactForm()
        {
            InitializeComponent();
        }                

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(txtFname.Text == "" || txtLname.Text == "")
            {
                MessageBox.Show("First name or Last name should not be empty", "Error", MessageBoxButtons.OK);
                DialogResult = DialogResult.None;
            }
            else
            {
                firstName = txtFname.Text;
                lastName = txtLname.Text;                
                addressType = cboAddressType.Text;
                street = txtStreet.Text;
                city = txtCity.Text;
                province = cboProvince.Text;
                zip = mskZip.Text;
                email = txtEmail.Text;
                emailType = cboEmailType.Text;
                phone = mskPhone.Text;
                phoneType = cboPhoneType.Text;
            }
            
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {           
            openFileDialog.Filter = "Image files (*.jpg;*.jpeg;)|*.jpg;*.jpeg";
            // openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePathContact = openFileDialog.FileName;
                picContact.ImageLocation = imagePathContact;
                
            }
        }
    }
}
