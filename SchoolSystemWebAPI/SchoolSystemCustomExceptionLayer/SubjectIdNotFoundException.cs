using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystemCustomExceptionLayer
    {
   public class SubjectIdNotFoundException:Exception
        {
        public SubjectIdNotFoundException() : base()
            {
            }
        public SubjectIdNotFoundException(string message) : base(message)
            {
            }

        }
    }
