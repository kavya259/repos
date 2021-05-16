using System;
using System.Collections.Generic;
using System.Text;

namespace BigBazarExceptionLayer
    {
   public class ReceiptGenerationFailedException:Exception
        {
        public ReceiptGenerationFailedException() : base()
            {
            }
        public ReceiptGenerationFailedException(string message) : base(message)
            {
            }

        }
    }
