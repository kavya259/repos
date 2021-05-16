using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeExceptions
{
    public class NoDataFoundException:Exception
    {

        public NoDataFoundException() : base()

            {
            }
        public NoDataFoundException(string message) : base(message)
            {
            }
        }
}
