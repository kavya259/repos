using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBookingExceptions
    {
     public class DuplicateNameException:Exception
        {
        public DuplicateNameException() : base()
            {
            }
        public DuplicateNameException(string message) : base(message)
            {
            }
        }
    }
