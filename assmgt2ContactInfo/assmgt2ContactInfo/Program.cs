using System;

namespace assmgt2ContactInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactInfo info = new ContactInfo();
            info = info.createContact(info);
            info.displayContactDetails(info);
        }
    }
}
