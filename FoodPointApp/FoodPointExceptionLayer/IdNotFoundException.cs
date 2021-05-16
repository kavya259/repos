using System;
using System.Collections.Generic;
using System.Text;

namespace FoodPointExceptionLayer
    {
   public class IdNotFoundException:Exception
        {
        public IdNotFoundException() : base()
            {
            }
        public IdNotFoundException(string message) : base(message)
            {
            }
        }
    }
