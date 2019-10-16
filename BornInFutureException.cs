using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class BornInFutureException : Exception
    {
        public BornInFutureException(string message) : base(message)
        {
        }

        
    }
}
