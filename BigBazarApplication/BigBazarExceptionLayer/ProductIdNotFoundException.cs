using System;
using System.Collections.Generic;
using System.Text;

namespace BigBazarExceptionLayer
    {
   public class ProductIdNotFoundException:Exception
        {
        public ProductIdNotFoundException() : base()
            {
            }
        public ProductIdNotFoundException(string message) : base(message)
            {
            }
        }
    }
