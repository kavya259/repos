using System;
using System.Collections.Generic;
using System.Text;

namespace assmgt2ContactInfo
{
    class ContactInfo: ContactInfoManager
    {
        private string address;
        private string city;
        private string state;
        private string country;
        private string phoneNo;
        private string emailId;
        private string mobileNo;

        public ContactInfo()
        { }


        public ContactInfo(string address, string city, string state, string country, string phoneNo, string emailId, string mobileNo)
        {
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.PhoneNo = phoneNo;
            this.EmailId = emailId;
            this.MobileNo = mobileNo;
        }

        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string EmailId { get => emailId; set => emailId = value; }
        public string MobileNo { get => mobileNo; set => mobileNo = value; }
    }
}
