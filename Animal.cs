using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter 
{
    /// <summary>
    /// Class representing an animal in the shelter.
    /// </summary>
   [Serializable]
    public abstract class Animal : ISellable, IComparable<Animal>
    {
        /// <summary>
        /// The chipnumber of the animal. Must be unique. Must be zero or greater than zero.
        /// </summary>
        public int ChipRegistrationNumber { get;  set; }

        /// <summary>
        /// The price of the animal.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Date of birth of the animal.
        /// </summary>
        public SimpleDate DateOfBirth { get; private set; }

        /// <summary>
        /// picture of the animal
        /// </summary>
        public string Photo
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the animal.
        /// </summary>
        public  string Name { get; private set; }

        /// <summary>
        /// Is the animal reserved by a future owner yes or no.
        /// </summary>
        public bool IsReserved { get; set; }

        

        /// <summary>
        /// Creates an animal.
        /// </summary>
        /// <param name="chipRegistrationNumber">The chipnumber of the animal. 
        ///                                      Must be unique. Must be zero or greater than zero.</param>
        /// <param name="dateOfBirth">The date of birth of the animal.</param>
        /// <param name="name">The name of the animal.</param>
        public Animal(int chipRegistrationNumber, SimpleDate dateOfBirth, string name, string photo)
        {
            if (name == null|| dateOfBirth == null )
            {
               throw new NullReferenceException("please fill in all parameters");
            }
                
            ChipRegistrationNumber = chipRegistrationNumber;
            DateOfBirth = dateOfBirth;
            Name = name;
            IsReserved = false;
            Photo = photo;
            
           


        }


        /// <summary>
        /// Retrieve information about this animal
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "<ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise. 
        /// </returns>
        public override string ToString()
        {
            string IsReservedString;
            if (IsReserved)
            {
                IsReservedString = "reserved";
            }
            else
            {
                IsReservedString = "not reserved";
            }

            string info = ChipRegistrationNumber
                          + ", " + DateOfBirth
                          + ", " + Name
                          + ", " + IsReservedString
                          + ", " + Price;
            return info;
        }
        /// <summary>
        /// compare's whitch number is the lowest
        /// </summary>
        /// <param name="animals"></param>
        /// <returns></returns>
        public int CompareTo(Animal animals)
        {
            if (!(animals is Animal))
            {
                throw new ArgumentException("please fill in an animal");
            }
            if (animals == null)
            {
                throw new ArgumentNullException("please fill in an animal");
            }
            
            if(this.ChipRegistrationNumber > animals.ChipRegistrationNumber)
            {
                return 1;
            }
            if(this.ChipRegistrationNumber == animals.ChipRegistrationNumber)
            {
                return 0;
            }
            return -1;
        }

    }
}
