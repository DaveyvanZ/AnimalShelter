using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
   public class WalkBeforeBornException : Exception
    {
        public WalkBeforeBornException(string message) : base(message) { }
    }
}
