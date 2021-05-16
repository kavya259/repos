using System;
using System.Collections.Generic;
using System.Text;

namespace FoodPointExceptionLayer
    {
    public class IncorrectFormatException:Exception
        {
        public IncorrectFormatException() : base()
            {
            }
        public IncorrectFormatException(string message,Exception ex) : base(message)
            {
            }
        }
    }
