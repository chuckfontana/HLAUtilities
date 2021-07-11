using System;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Xpo;
using DevExpress.XtraEditors.DXErrorProvider;

namespace HLAUtilities.Core.Models.Domain
{
    [Persistent("Users")]
    public class User : XPObject, IDataErrorInfo
    {
        public User(Session session) : base(session)
        {
        }

        string lastName;
        [Size(30)]
        public string LastName
        {
            get { return this.lastName; }
            set { SetPropertyValue(nameof(LastName), ref this.lastName, value); }
        }

        string firstName;
        [Size(30)]
        public string FirstName
        {
            get { return this.firstName; }
            set { SetPropertyValue(nameof(FirstName), ref this.firstName, value); }
        }

        string networkId;
        [Size(20)]
        public string NetworkId
        {
            get { return this.networkId; }
            set { SetPropertyValue(nameof(NetworkId), ref this.networkId, value); }
        }


        DateTime addDate;
        public DateTime AddDate
        {
            get { return this.addDate; }
            set { SetPropertyValue(nameof(AddDate), ref this.addDate, value); }
        }

        DateTime editDate;
        public DateTime EditDate
        {
            get { return this.editDate; }
            set { SetPropertyValue(nameof(EditDate), ref this.editDate, value); }
        }

        protected override void OnSaving()
        {
            base.OnSaving();

            if (this.Session.IsNewObject(this)) this.AddDate = DateTime.Now;

            this.EditDate = DateTime.Now;
        }

        private string lastError = "";

        public string Error
        {
            get { return lastError; }
        }

        public string this[string columnName]
        {
            get
            {
                this.lastError = "";

                switch (columnName)
                {
                    case "LastName":
                        if (String.IsNullOrEmpty(LastName)) this.lastError = "Please enter Last Name!";
                            break;
                    case "FirstName":
                        if (String.IsNullOrEmpty(FirstName)) this.lastError = "Please enter First Name!";
                            break;
                    case "NetworkId":
                     if (String.IsNullOrEmpty(NetworkId)) this.lastError = "Please enter Network Id!";
                            break;

                    default:
                        this.lastError = "";
                        break;

                }
                return this.Error;
            }
        }
      
    }
}
