using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMSIS.DL
{
    public class Contact
    {
        private string contactFn;
        private string contactLn;
        private string contactCoName;
        private string contactJobTitle;
        private string contactType;
        private string contactNote;
        private DateTime contactCreateDate;
        private DateTime clientLastActivity;

        public Contact()
        {
            //
        }

        public Contact(string contactFn, string contactLn, string contactCoName, string contactJobTitle, string contactType,
            string contactNote, string clientZip, string clientCo)
        {
            this.contactFn = contactFn;
            this.contactLn = contactLn;
            this.contactCoName = contactCoName;
            this.contactJobTitle = contactJobTitle;
            this.contactType = contactType;
            this.contactNote = contactNote;
            this.clientZip = clientZip;
            this.clientCo = clientCo;
        }
        public Contact(string contactFn, string contactLn)
        {
            this.contactFn = contactFn;
            this.contactLn = contactLn;
        }
        public Contact(string contactFn, string contactLn,string contactCoName, string contactJobTitle, string contactType, 
            string contactNote, string clientZip, string clientId, string clientCo, DateTime clientCreateDate, DateTime clientLastActivity)
        {
            this.contactFn = contactFn;
            this.contactLn = contactLn;
            this.contactCoName = contactCoName;
            this.contactJobTitle = contactJobTitle;
            this.contactType = contactType;
            this.contactNote = contactNote;
            this.clientZip = clientZip;
            this.clientId = clientId;
            this.clientCo = clientCo;
            this.clientCreateDate = clientCreateDate;
            this.clientLastActivity = clientLastActivity;
        }

        public string ContactFn
        {
            get
            {
                return contactFn;
            }
            set
            {
                contactFn = value;
            }
        }

        public string ContactLn
        {
            get
            {
                return contactLn;
            }
            set
            {
                contactLn = value;
            }
        }

        public string ContactCoName
        {
            get
            {
                return contactCoName;
            }
            set
            {
                contactCoName = value;
            }
        }
        public string ContactJobTitle
        {
            get
            {
                return contactJobTitle;
            }
            set
            {
                contactJobTitle = value;
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
        public string ClientZip
        {
            get
            {
                return clientZip;
            }
            set
            {
                clientZip = value;
            }
        }

        public string ClientId
        {
            get
            {
                return clientId;
            }
            set
            {
                clientId = value;
            }
        }

        public string ClientCo
        {
            get
            {
                return clientCo;
            }
            set
            {
                clientCo = value;
            }
        }


        public DateTime ClientCreateDate
        {
            get
            {
                return clientCreateDate;
            }
            set
            {
                clientCreateDate = value;
            }
        }
        public DateTime ClientLastActivity
        {
            get
            {
                return clientLastActivity;
            }
            set
            {
                clientLastActivity = value;
            }
        }

    }
}
