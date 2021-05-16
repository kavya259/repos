using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBookingExceptions
    {
    public class DateNotValidException:Exception
        {
        public DateNotValidException() : base()
            {
            }
        public DateNotValidException(string message) : base(message)
            {
            }
        }
    }
    
