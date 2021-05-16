using System;
using System.Collections.Generic;
using System.Text;

namespace BigBazarExceptionLayer
    {
   public class CustomerIdNotFoundException:Exception
        {
        public CustomerIdNotFoundException() : base()
            {
            }
        public CustomerIdNotFoundException(string message) : base(message)
            {
            }
        }
    }
