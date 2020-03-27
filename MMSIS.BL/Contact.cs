using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMSIS.DL
{
    public class Contact
    {
        public Contact()
        {
            contactCreateDate = DateTime.Now;
            contactLastActivity = DateTime.Now;
        }

        public Contact(string ContactFirstName, string ContactLastName,  string ContactType,
            string ContactNote)
        {
            contactFirstName = ContactFirstName;
            contactLastName = ContactLastName;
            contactType = ContactType;
            contactNote = ContactNote;
        }
        public Contact(string ContactFirstName, string ContactLastName)
        {
            contactFirstName = ContactFirstName;
            contactLastName = ContactLastName;
        }
        public string ContactFirstName
        {
            get
            {
                return contactFirstName;
            }
            set
            {
                contactFirstName = value;
            }
        }

        public string ContactLastName
        {
            get
            {
                return contactLastName;
            }
            set
            {
                contactLastName = value;
            }
        }

        public string ContactType
        {
            get
            {
                return contactType;
            }
            set
            {
                contactType = value;
            }
        }
        public string ContactNote
        {
            get
            {
                return contactNote;
            }
            set
            {
                contactNote = value;
            }
        }
        public DateTime ContactCreateDate
        {
            get
            {
                return contactCreateDate;
            }
            set
            {
                contactCreateDate = value;
            }
        }
        public DateTime ContactLastActivity
        {
            get
            {
                return contactLastActivity;
            }
            set
            {
                contactLastActivity = value;
            }
        }

        public Guid ContactId
        {
            get
            {
                return contactId;
            }
            set
            {
                contactId = value;
            }

        }

        private string contactFirstName;
        private string contactLastName;
        private string contactType;
        private string contactNote;
        private DateTime contactCreateDate;
        private DateTime contactLastActivity;
        private Guid contactId;
    }
}
