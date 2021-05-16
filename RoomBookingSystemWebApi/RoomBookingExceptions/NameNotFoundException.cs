using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBookingExceptions
    {
   public class NameNotFoundException:Exception
        {
        public NameNotFoundException() : base()
            {
            }
        public NameNotFoundException(string message) : base(message)
            {
            }
        }
    }
