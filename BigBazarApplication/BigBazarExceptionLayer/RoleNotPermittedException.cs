using System;
using System.Collections.Generic;
using System.Text;

namespace BigBazarExceptionLayer
    {
    public class RoleNotPermittedException:Exception
        {
        public RoleNotPermittedException() : base()
            {
            }
        public RoleNotPermittedException(string message) : base(message)
            {
            }
        }
    }
