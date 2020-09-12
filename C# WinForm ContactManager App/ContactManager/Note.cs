using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    /// <summary>
    /// public class Note for being used in forms to save note text
    /// </summary>
    public class Note
    {
        private string textNote;
        public string TextNote
        {
            get => textNote;
            set => textNote = value;
        }

        private DateTime dateTime;
        /// <summary>
        /// creation time of note text
        /// </summary>
        public DateTime DateTime
        {
            get => dateTime;
            set => dateTime = value;
        }

        /// <summary>
        /// explicitly show default constructor for practice, good habit
        /// </summary>
        public Note()
        {

        }

        /// <summary>
        /// save notes including time stamp
        /// </summary>
        /// <param name="textNote"></param>
        public Note(string textNote)
        {
            this.dateTime = DateTime.Now;
            this.textNote = textNote;            
        }
    }
}
