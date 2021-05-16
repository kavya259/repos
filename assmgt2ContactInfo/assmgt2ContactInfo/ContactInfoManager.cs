using System;
using System.Collections.Generic;
using System.Text;

namespace assmgt2ContactInfo
{
    class ContactInfoManager
    {
        public ContactInfo createContact(ContactInfo contactInfo)
        {
            Console.WriteLine("Enter your contact details ");
            Console.WriteLine("Enter your address  ");
            string addr = Console.ReadLine();
            Console.WriteLine("Enter your city  ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your state  ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your country  ");
            string country = Console.ReadLine();
            Console.WriteLine("Enter your phoneno  ");
            string pno = Console.ReadLine();
            Console.WriteLine("Enter your mobileno  ");
            string mobno = Console.ReadLine();
            Console.WriteLine("Enter your emailId  ");
            string email = Console.ReadLine();


            ContactInfo contact = new ContactInfo(addr, city, state, country, pno, email,mobno);


            return contact;


        }
        public void displayContactDetails(ContactInfo contactInfo)
        {
            Console.WriteLine(" Your contact details ");
            Console.WriteLine("Address    : "+ contactInfo.Address);
            Console.WriteLine("City       : "+ contactInfo.City);
            Console.WriteLine("State      : "+ contactInfo.State);
            Console.WriteLine("Country    : "+ contactInfo.Country);
            Console.WriteLine("Phoneno    : "+ contactInfo.PhoneNo);
            Console.WriteLine("Mobileno   : "+ contactInfo.MobileNo);
            Console.WriteLine("EmailId    : "+ contactInfo.EmailId);
        }





    }
}
