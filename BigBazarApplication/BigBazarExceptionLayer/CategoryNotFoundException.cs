using System;
using System.Collections.Generic;
using System.Text;

namespace BigBazarExceptionLayer
    {
   public  class CategoryNotFoundException:Exception
        {
        public CategoryNotFoundException() : base()
            {
            }
        public CategoryNotFoundException(string message) : base(message)
            {
            }

        }
    }
