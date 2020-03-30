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
            string ContactNote, string ContactCity, string ContactStreet, string ContactState)
        {
            contactFirstName = ContactFirstName;
            contactLastName = ContactLastName;
            contactType = ContactType;
            contactNote = ContactNote;
            contactStreet = ContactStreet;
            contactState = ContactState;
            contactCity = ContactCity;
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
        public string ContactCity
        {
            get
            {
                return contactCity;
            }
            set
            {
                contactCity = value;
            }
        }
        public string ContactState
        {
            get
            {
                return contactState;
            }
            set
            {
                contactState = value;
            }
        }
        public string ContactStreet
        {
            get
            {
                return contactStreet;
            }
            set
            {
                contactStreet = value;
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
        private string contactStreet;
        private string contactState;
        private string contactCity;
        private DateTime contactCreateDate;
        private DateTime contactLastActivity;
        private Guid contactId;
    }
}
