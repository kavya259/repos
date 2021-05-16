using System;

namespace RoomBookingExceptions
    {
    public class DuplicatePhoneNumberException:Exception
        {
        public DuplicatePhoneNumberException() : base()
            {
            }
        public DuplicatePhoneNumberException(string message) : base(message)
            {
            }
        }
    }
    
