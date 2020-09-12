using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    /// <summary>
    /// public class Contact for being used in main form
    /// </summary>
    public class Contact
    {
        private string firstName;
        /// <summary>
        /// first name
        /// </summary>
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        private string lastName;
        /// <summary>
        /// last name
        /// </summary>
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        private string addressType;
        /// <summary>
        /// home or business
        /// </summary>
        public string AddressType
        {
            get => addressType;
            set => addressType = value;
        }

        private string street;
        public string Street
        {
            get => street;
            set => street = value;
        }

        private string city;
        public string City
        {
            get => city;
            set => city = value;
        }

        private string province;
        public string Province
        {
            get => province;
            set => province = value;
        }

        private string zip;
        /// <summary>
        /// postal code in Canada
        /// </summary>
        public string Zip
        {
            get => zip;
            set => zip = value;
        }

        private string email;
        public string Email
        {
            get => email;
            set => email = value;
        }

        private string emailType;
        /// <summary>
        /// home or business
        /// </summary>
        public string EmailType
        {
            get => emailType;
            set => emailType = value;
        }

        private string phone;
        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        private string phoneType;
        /// <summary>
        /// home or business
        /// </summary>
        public string PhoneType
        {
            get => phoneType;
            set => phoneType = value;
        }

        private List<Note> noteList;
        public List<Note> NoteList
        {
            get => noteList;
            set => noteList = value;
        }

        private Note note;
        public Note Note
        {
            get => note;
            set => note = value;
        }

        private string imagePathContact;
            /// <summary>
            /// image path of contact
            /// </summary>
        public string ImagePathContact
        {
            get => imagePathContact;
            set => imagePathContact = value;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Contact()
        {
            noteList = new List<Note>();
        }

        /// <summary>
        /// to show only last, first name in listbox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{lastName}, {firstName}";
        }
    }
}
