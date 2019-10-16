using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;
using System.Runtime.Serialization;
using System.IO;

namespace UnitTestAnimalShelter1
{
    [TestClass]
    public class TestAdministration
    {
  
        [TestMethod]
        public void TestFindAnimal()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            Cat cat = new Cat(1, birthday, "Kevin", "sick", "");
            Cat cat2 = new Cat(2, birthday, "henk", "", "");
            
            Administration a = new Administration();
            a.Add(cat);
            a.Add(cat2);
            Animal result = a.FindAnimal(1);
            Assert.IsTrue(result.Name == cat.Name);
        }
        [TestMethod]
        public void TestRemoveAnimal()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            Cat cat = new Cat(1, birthday, "Kevin", "sick", "");
            Cat cat2 = new Cat(2, birthday, "henk", "", "");

            Administration a = new Administration();
            a.Add(cat);
            a.Add(cat2);
           
            a.RemoveAnimal(1);
            Assert.IsTrue(a.Animals[0] == cat2);
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AddAnimalThatNotExist()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            Cat cat = new Cat(1, birthday, "Kevin", "sick", "");
            Cat cat2 = null;

            Administration a = new Administration();
            a.Add(cat);
            a.Add(cat2);
            ;
        }

        /// <summary>
        /// Tests if there is a list in administration
        /// </summary>
        [TestMethod]
        public void CreateAdministrationTest()
        {
            Administration administration = new Administration();
            Assert.IsNotNull(administration.Animals);
          
        }


        [TestMethod]
        public void TestAddAnimalWhitchIsAlreadyAdded()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            SimpleDate walked = new SimpleDate(15, 2, 2000);
            Administration a = new Administration();
            Cat cat = new Cat(1, birthday, "smokey", "none", "");
           Dog dog = new Dog(1, walked, "Kevin", birthday, "");
            a.Add(dog);
            Assert.IsTrue(a.Animals.Count == 1);
            a.Add(dog);
            Assert.IsTrue(a.Animals.Count == 1);
        }
        [TestMethod]
      
       [ ExpectedException(typeof(System.ArgumentException))]

        public void TestAddNull()
        {
            Administration a = new Administration();
            a.Add(null);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void AddAnimalWithNegativeChipnumber()
        {
              SimpleDate birthday = new SimpleDate(13, 2, 2001);
              Administration a = new Administration();
            Cat cat = new Cat(-1, birthday, "smokey", "none", "");
            a.Add(cat);
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void SaveNull()
        {
            Administration a = new Administration();
            a.Save(null);
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void SaveEmptyString()
        {
            Administration a = new Administration();
            a.Save("");
        }
        [TestMethod]
        [ExpectedException(typeof(System.IO.PathTooLongException))]
        public void SaveWhenPathIsLongerThan260Characters()
        {
            Administration a = new Administration();
            a.Save("123456789101112131415161718192021222324252627282930313233343536373839404142434445464748495051525354555657585960616263646566676869707172737475767778798081828384858687888990919293949596979899100101102103104105106107");
        }
        [TestMethod]
        public void SaveSomething()
        {
           Administration a = new Administration();
           Assert.IsTrue(File.Exists("\\\\psf\\iCloud\\files\\unitsavetest3") == false); //this test can only run once, because when you run the test, the file does exist
           a.Save("\\\\psf\\iCloud\\files\\unitsavetest3");
           Assert.IsTrue(new FileInfo("\\\\psf\\iCloud\\files\\unitsavetest3").Length != 0);
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void LoadNullFilename()
        {
            Administration a = new Administration();
            a.Load(null);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void LoadEmptyString()
        {
            Administration a = new Administration();
            a.Load("");
        }
        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void LoadFileThatNotExists()
        {
            Administration a = new Administration();
            a.Load("\\\\K\\Home\\Documents\\unitsavetest");
        }

        [TestMethod]
        public void LoadSomething()
        {
             Administration a = new Administration();
             bool complete = a.Load("\\\\psf\\iCloud\\files\\binarySave");//this is a written file, with the save method
             Assert.IsTrue(complete == true);
        }
        [TestMethod]
        [ExpectedException(typeof(SerializationException))]
        public void LoadAnASCIIFile()
        {
            Administration a = new Administration();
            a.Load("\\\\psf\\iCloud\\files\\TxtExport");//this is a written file, with the save method      
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.PathTooLongException))]
        public void LoadWhenPathIsLongerThan260Characters()
        {
         Administration a = new Administration();
         a.Load("\\\\psf\\iCloud\\files\\DirectoryUnitText2501234567891011121314151617181920\\BinExport1234567891011121314151617181920212223242526272829303132333435363738340414243444546474849505152535455565758596061626364656667686970717273747576777879808182838485868788899091929394959697989910012121212345678910111213141");

        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void ExportNullFilename()
        {
            Administration a = new Administration();
            a.Export(null);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void ExportEmptyString()
        {
            Administration a = new Administration();
            a.Export("");
        }
     
        [TestMethod]
        [ExpectedException(typeof(System.IO.PathTooLongException))]
        public void ExportWhenPathIsLongerThan260Characters()
        {
            Administration a = new Administration();
            a.Export("\\\\psf\\iCloud\\files\\TxtExport123456789101112131415161718192021222324252627282930313233343536373834041424344454647484950515253545556575859606162636465666768697071727374757677787980818283848586878889909192939495969798991001212121234567891011121314151617181920212223242526272829303132333435363738340");

        }
        [TestMethod]
        public void ExportSomething()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
           Administration a = new Administration();
              Cat cat = new Cat(1, birthday, "Kevin", "sick", "");
              a.Add(cat);
          Assert.IsTrue(File.Exists("\\\\psf\\Home\\Documents\\unit3") == false); //this test can only run once, because when you run the test, the file does exist
          a.Export("\\\\psf\\Home\\Documents\\unit3");
          Assert.IsTrue(new FileInfo("\\\\psf\\Home\\Documents\\unit3").Length != 0);
        
        }


        

    

      
       
    }
}
