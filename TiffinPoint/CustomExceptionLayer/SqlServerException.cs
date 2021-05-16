using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionLayer
{
    public class SqlServerException:Exception
    {
        public SqlServerException() : base()
            {
            }
        public SqlServerException(string message) : base(message)
            {
            }

        }
    }
