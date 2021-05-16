using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCourseManagementExceptions
    {
   public class SqlServerException:Exception
        {
        public SqlServerException() : base()
            {
            }
        public SqlServerException(string message,Exception ex) : base(message)
            {
            }
        }
    }
