using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBookingExceptions
    {
    public class DuplicateEmailException: Exception
        {
        public DuplicateEmailException(): base()
            {}
        public DuplicateEmailException(string message) : base(message)
            {
            }
        }
    }
