using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    [Serializable]
    public class Dog : Animal
    {
        decimal dogPrice;
        /// <summary>
        /// The date of the last walk of the dog. Contains null if unknown.
        /// </summary>
        public SimpleDate LastWalkDate { get; set; }

       
        /// <summary>
        /// The price of the dog, dependent on its registration number
        /// </summary>
        public override decimal Price
        {
            get
            {
                
                if (ChipRegistrationNumber < 500000)
                {
                    dogPrice = 200;
                    return dogPrice;
                }
                else 
                {
                    
                    dogPrice = 350;
                    return dogPrice;
                }
            }

        }

        /// <summary>
        /// Creates a dog.
        /// </summary>
        /// <param name="chipRegistrationNumber">The chipnumber of the animal. 
        ///                                      Must be unique. Must be zero or greater than zero.</param>
        /// <param name="dateOfBirth">The date of birth of the animal.</param>
        /// <param name="name">The name of the animal.</param>
        /// <param name="lastWalkDate">The date of the last walk with the dog or null if unknown.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, SimpleDate lastWalkDate, string photo) : base (chipRegistrationNumber,dateOfBirth,name, photo)
        {
            // TODO: Modify the constructor. Make sure it initializes all properties of the class.
            LastWalkDate = lastWalkDate;
            if ( dateOfBirth == null || name == null || lastWalkDate == null ||
                Photo == null)
            {
                throw new NullReferenceException("please fill in all arguments");
            }
            //Photo = photo;
        }

        /// <summary>
        /// Retrieve information about this dog
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "Dog: <ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>, <LastWalkDate>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise.
        ///                 LastWalkDate will be "unknown" if unknown or the date of the last doggywalk otherwise.
        /// </returns>
        public override string ToString()
        {
            // TODO: Put your own code here to make the method return the string specified in the
            // method description.
            return "Dog: " +  base.ToString() + ", " + LastWalkDate;
        }


    }
}
