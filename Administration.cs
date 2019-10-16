using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public class Administration
    {
        //fields
        public List<Animal> Animals { get; set; }

        public List<string> lines;

        SimpleDate now = new SimpleDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        BinaryFormatter bFormatter = new BinaryFormatter();


        //constructor
        public Administration()
        {
            Animals = new List<Animal>();
        }

        /// <summary>
        /// addds an animal to the list
        /// </summary>
        /// <param name="animal"></param>
        /// <returns> true, when animal is added, false when it's not</returns>


        public Boolean Add(Animal animal)
        {
            if (!(animal is Animal))
            {
                throw new ArgumentException("please fill in a Animal as parameter");
            }

            if (animal == null)
            {
                throw new NullReferenceException();
            }
            foreach (Animal input in Animals)
            {
                if (input.ChipRegistrationNumber == animal.ChipRegistrationNumber)
                {
                    return false;
                }
            }
            if (animal.ChipRegistrationNumber <= 0)
            {
                throw new IndexOutOfRangeException("chipregistrationnumber is not valid");
            }
            if (animal.DateOfBirth.DaysDifference(now) < 0)
            {
                throw new BornInFutureException("your animal can not be born in the future");
            }
            if (animal is Dog)
            {
                Dog tempDog = animal as Dog;

                if (tempDog.DateOfBirth.DaysDifference(tempDog.LastWalkDate) < 0 || tempDog.LastWalkDate.DaysDifference(now) < 0)
                {
                    throw new WalkBeforeBornException("your dog can not walk before it's born");
                }
            }

            Animals.Add(animal);
            return true;
        }



        /// <summary>
        /// removes an animal from the list
        /// </summary>
        /// <param name="chipRegistrationNumber"></param>
        /// <returns> true when the animal is deleted, false when it's not</returns>
        public Boolean RemoveAnimal(int chipRegistrationNumber)
        {
        
            Animal testAnimal = FindAnimal(chipRegistrationNumber);
            Animals.Remove(testAnimal);
            return true;
        }

        /// <summary>
        /// finds the animal in the list by his number
        /// </summary>
        /// <param name="chipRegistrationNumber"></param>
        /// <returns> the animal who is found</returns>
        public Animal FindAnimal(int chipRegistrationNumber)
        {

            Animal testAnimal = null;
            foreach (Animal input in Animals)
            {
                if (input.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    testAnimal = input;

                }
            }
            return testAnimal;
        }

        /// <summary>
        /// Saves all animals to a file with the given file name using serialisation.
        /// </summary>
        /// <param name="fileName">The file to write to.</param>
        public void Save(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("please fill in a filename");
            }
            if (!(fileName is string) || fileName == "")
            {
                throw new ArgumentException("please fill in a string as parameter");
            }
            if (fileName.Length > 260)
            {
                throw new PathTooLongException("your path is too long");
            }


            Stream stream = new FileStream(fileName, FileMode.Create);
            try
            {
                bFormatter.Serialize(stream, Animals);
            }

            finally
            {
                stream.Close();
            }
           

        }

        /// <summary>
        /// Loads all animals from a file with the given file name using deserialisation.
        /// All animals currently in the administration are removed.
        /// </summary>
        /// <param name="fileName">The file to read from.</param>
        public bool Load(string fileName)
        {
           
            if (fileName == null )
            {
                throw new ArgumentNullException("please fill in a filename");
              
            }
            if (!(fileName is string) || fileName == "")
            {
                throw new ArgumentException("please fill in a string as parameter");
               
            }
            if (fileName.Length > 260)
            {
                throw new PathTooLongException("your path is too long");
               
            }
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("the file cannot be found");
            }
            Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            
                Animals = (List<Animal>)bFormatter.Deserialize(stream);  //cast Animals back to a list, because that's the object I'm reading
                stream.Close();
                return true;
        }



        /// <summary>
        /// Exports the info of all animals to a text file with the given file name.
        /// 
        /// Each line of the file contains the info about exactly one animal.
        /// Each line starts with the type of animal and a colon (e.g. 'Cat:' or 'Dog:')
        /// followed by the properties of the animal seperated by comma's.
        /// </summary>
        /// <param name="fileName">The text file to write to.</param>
        public void Export(string fileName)
        {
            if (fileName == null )
            {
                throw new ArgumentNullException("please fill in a filename");
            }
            if (!(fileName is string) || fileName == "")
            {
                throw new ArgumentException("please fill in a string as parameter");
            }

            if (fileName.Length > 260)
            {
                throw new PathTooLongException("your path is too long");
            }

            

            StreamWriter writer = new StreamWriter(fileName, true);
            if (writer.BaseStream == null)
            {
                throw new ObjectDisposedException("the writer is closed");
            }
            else
            {
                foreach (Animal tempanimal in Animals)
                {
                    writer.WriteLine(tempanimal.ToString());
                }
                writer.Close();
            }

        }








    }
}


