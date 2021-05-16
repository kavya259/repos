using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.CustomExceptionLayer
    {
   public class NoRowsPresentException:Exception
        {
        public NoRowsPresentException() : base()
            {
            }
        public NoRowsPresentException(string message) : base(message)
            {
            }
        }
    }
