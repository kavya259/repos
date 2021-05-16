using System;

namespace FoodPointExceptionLayer
    {
    public class DuplicateFoodItemNameException:Exception
        {
        public DuplicateFoodItemNameException() : base()
            {
            }
        public DuplicateFoodItemNameException(string message) : base(message)
            {
            }
        }
    }
