﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystemCustomExceptionLayer
    {
  public  class SqlException:Exception
        {
        public SqlException() : base()
            {
            }
        public SqlException(string message,Exception ex) : base(message)
            {
            }
        }
    }
