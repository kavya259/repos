using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystemCustomExceptionLayer
    {
    public class SchoolIdNotFoundException:Exception
        {
          
        public SchoolIdNotFoundException() : base()
            {
            }
        public SchoolIdNotFoundException(string message) : base(message)
            {
            }
        }
    }
    
