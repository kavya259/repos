using System;
using System.Collections.Generic;
using System.Text;

namespace BigBazarExceptionLayer
    {
    public class UserAlreadyExistsException:Exception
        {
        public UserAlreadyExistsException() : base()
            {
            }
        public UserAlreadyExistsException(string message) : base(message)
            {
            }
        }
    }
