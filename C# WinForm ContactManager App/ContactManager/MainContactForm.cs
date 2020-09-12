using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class MainContactForm : Form
    {
        BindingList<Contact> contactList = new BindingList<Contact>();
        Contact contact;
        Contact selectedContact;
        SecondaryContactForm secondaryContactForm = new SecondaryContactForm();
        


        public MainContactForm()
        {
            InitializeComponent(); 
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {            
            if(secondaryContactForm.ShowDialog(this) == DialogResult.OK)
            {          
                pnlMiddleAndNote.Enabled = true;

                contact = new Contact();
                contact.FirstName = secondaryContactForm.firstName;
                contact.LastName = secondaryContactForm.lastName;
                contact.AddressType = secondaryContactForm.addressType;
                contact.Street = secondaryContactForm.street;
                contact.City = secondaryContactForm.city;
                contact.Province = secondaryContactForm.province;
                contact.Zip = secondaryContactForm.zip;
                contact.Email = secondaryContactForm.email;
                contact.EmailType = secondaryContactForm.emailType;
                contact.Phone = secondaryContactForm.phone;
                contact.PhoneType = secondaryContactForm.phoneType;
                contact.ImagePathContact = secondaryContactForm.imagePathContact;

                contactList.Add(contact);
                contact.NoteList = new List<Note>();

                ShowSelectedContact();
            }
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex != -1)
            {
                secondaryContactForm.txtFname.Text = selectedContact.FirstName;
                secondaryContactForm.txtLname.Text = selectedContact.LastName;
                secondaryContactForm.txtStreet.Text = selectedContact.Street;
                secondaryContactForm.txtCity.Text = selectedContact.City;
                secondaryContactForm.cboProvince.Text = selectedContact.Province;
                secondaryContactForm.mskZip.Text = selectedContact.Zip;
                secondaryContactForm.txtEmail.Text = selectedContact.Email;
                secondaryContactForm.cboEmailType.Text = selectedContact.EmailType;
                secondaryContactForm.mskPhone.Text = selectedContact.Phone;
                secondaryContactForm.cboPhoneType.Text = selectedContact.PhoneType;
                secondaryContactForm.picContact.ImageLocation = selectedContact.ImagePathContact;

                if (secondaryContactForm.ShowDialog(this) == DialogResult.OK)
                {
                    pnlMiddleAndNote.Enabled = true;

                    selectedContact.LastName = secondaryContactForm.lastName;
                    selectedContact.AddressType = secondaryContactForm.addressType;
                    selectedContact.Street = secondaryContactForm.street;
                    selectedContact.City = secondaryContactForm.city;
                    selectedContact.Province = secondaryContactForm.province;
                    selectedContact.Zip = secondaryContactForm.zip;
                    selectedContact.Email = secondaryContactForm.email;
                    selectedContact.EmailType = secondaryContactForm.emailType;
                    selectedContact.Phone = secondaryContactForm.phone;
                    selectedContact.PhoneType = secondaryContactForm.phoneType;
                    selectedContact.ImagePathContact = secondaryContactForm.imagePathContact;
                    
                    ShowSelectedContact();
                }
            }
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedContact();
        }

        private void ShowSelectedContact()
        {
            if (lstContacts.SelectedIndex != -1)
            {
                pnlMiddleAndNote.Enabled = true;

                selectedContact = (Contact)lstContacts.SelectedItem;
                txtFname.Text = selectedContact.FirstName;
                txtLname.Text = selectedContact.LastName;
                txtAddressType.Text = selectedContact.AddressType;
                txtStreet.Text = selectedContact.Street;
                txtCity.Text = selectedContact.City;
                txtProvince.Text = selectedContact.Province;
                txtZip.Text = selectedContact.Zip;
                txtEmail.Text = selectedContact.Email;
                txtEmailType.Text = selectedContact.EmailType;
                txtPhone.Text = selectedContact.Phone;
                txtPhoneType.Text = selectedContact.PhoneType;
                picContact.ImageLocation = selectedContact.ImagePathContact;

                txtDisplayNote.Clear();
                // show reversed list to sort
                ReverseNote();
            }
        }

        // show reversed list to sort
        private void ReverseNote()
        {
            selectedContact.NoteList.Reverse();
            foreach (Note note in selectedContact.NoteList)
            {
                txtDisplayNote.Text += $"{note.DateTime}{Environment.NewLine}";
                txtDisplayNote.Text += $"{note.TextNote}{Environment.NewLine}{Environment.NewLine}";
            }
            selectedContact.NoteList.Reverse();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {            
            string takeNote = txtTakeNote.Text;
            selectedContact.Note = new Note(takeNote);
            selectedContact.NoteList.Add(selectedContact.Note);

            txtDisplayNote.Clear();

            ReverseNote();

            txtTakeNote.Clear();
        }

        private void MainContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closing = MessageBox.Show("Do you want to save the contacts before closing?", "Closing",
                MessageBoxButtons.YesNoCancel);

            if (closing == DialogResult.Yes)
            {
                // When exiting the application, make sure you save all contacts you have in your application. 
                // This includes all the notes you created for each contact. It’s OK to create multiple files for this purpose.
                // code 7.a
                if(contactList.Count != 0)
                {
                    // This will create contact files.
                    for (int i = 0; i < contactList.Count; i++)
                    {
                        string file = $"{i}.txt";
                        using (StreamWriter writer = new StreamWriter(file))
                        {
                            writer.WriteLine($"{contactList.ElementAt(i).FirstName}");                            
                            writer.WriteLine($"{contactList.ElementAt(i).LastName}");
                            writer.WriteLine($"{contactList.ElementAt(i).ImagePathContact}");
                            writer.WriteLine($"{contactList.ElementAt(i).AddressType}");
                            writer.WriteLine($"{contactList.ElementAt(i).Street}");
                            writer.WriteLine($"{contactList.ElementAt(i).City}");
                            writer.WriteLine($"{contactList.ElementAt(i).Province}");
                            writer.WriteLine($"{contactList.ElementAt(i).Zip}");
                            writer.WriteLine($"{contactList.ElementAt(i).Email}");
                            writer.WriteLine($"{contactList.ElementAt(i).EmailType}");
                            writer.WriteLine($"{contactList.ElementAt(i).Phone}");
                            writer.WriteLine($"{contactList.ElementAt(i).PhoneType}");
                            

                            // This will create note files
                            string noteFile = $"{i}Note.txt";
                            using (StreamWriter noteFileWriter = new StreamWriter(noteFile))
                            {
                                for (int j = 0; j < contactList.ElementAt(i).NoteList.Count; j++)
                                {
                                    noteFileWriter.WriteLine($"{contactList.ElementAt(i).NoteList.ElementAt(j).DateTime.ToString()}" +
                                        $"|{contactList.ElementAt(i).NoteList.ElementAt(j).TextNote}");
                                }
                            }
                        }
                    }
                }
            }
            else if (closing == DialogResult.No)
            {

            }
            else if (closing == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        /// <summary>
        /// When this form loads, if there is contact files and note files exist,
        /// it will read the file text, generate contact list, and display information. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainContactForm_Load(object sender, EventArgs e)
        {
            //if there is any contact file created before, the first contact file name must be "0.txt".
            if (File.Exists($"0.txt"))
            {
                contactList = new BindingList<Contact>();
                int i = 0;
                string file = $"{i}.txt";

                //it will read contact file, generate contact class information, 
                //and save the object into the contactBindingList.
                //If there is more than one contact file existed, the file name will be "0.txt", "1.txt", ...ect.
                while (File.Exists(file) == true)
                {
                    string[] fileContent = File.ReadAllLines(file);
                    contact = new Contact();
                    contact.FirstName = fileContent[0];
                    contact.LastName = fileContent[1];
                    contact.ImagePathContact = fileContent[2];
                    contact.AddressType = fileContent[3];
                    contact.Street = fileContent[4];
                    contact.City = fileContent[5];
                    contact.Province = fileContent[6];
                    contact.Zip = fileContent[7];
                    contact.Email = fileContent[8];
                    contact.EmailType = fileContent[9];
                    contact.Phone = fileContent[10];
                    contact.PhoneType = fileContent[11];
                    contactList.Add(contact);                    

                    //If there is note contents existed for the contact file, 
                    //the name of content file will be "{number}Note.txt".
                    //It will search the Note file, generate note class,
                    //and save the object into contactList's notelist.
                    if (File.Exists($"{i}Note.txt"))
                    {
                        string[] noteContent = File.ReadAllLines($"{i}Note.txt");
                        for (int j = 0; j < noteContent.Length; j++)
                        {
                            string[] detailNoteInformation = noteContent[j].Split('|');
                            Note note = new Note();
                            note.DateTime = Convert.ToDateTime(detailNoteInformation[0]);
                            note.TextNote = detailNoteInformation[1];
                            contactList.ElementAt(i).NoteList.Add(note);
                        }
                    }

                    //It will increase {i} to search another contact file. 
                    file = $"{++i}.txt";
                }

                lstContacts.DataSource = contactList;
                lstContacts.SelectedIndex = -1;

                pnlMiddleAndNote.Enabled = false;
            }
        }
    }
}
