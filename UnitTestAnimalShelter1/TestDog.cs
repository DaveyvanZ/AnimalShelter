using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestAnimalShelter1
{
    [TestClass]
    public class TestDog

    {
        [TestMethod]
        public void CreateDogTest()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            SimpleDate walked = new SimpleDate(15, 2, 2001);
            Dog dog = new Dog(1, birthday, "Kevin", walked, "");
            Assert.AreEqual(dog.Name, "Kevin");
            Assert.AreEqual(dog.DateOfBirth, birthday);
            Assert.AreEqual(dog.LastWalkDate, walked);
            Assert.AreEqual(dog.Price, 200);
            Assert.AreEqual(dog.ChipRegistrationNumber, 1);

        }

        [TestMethod]
        public void ToStringTestDog()
        {

            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            SimpleDate walked = new SimpleDate(15, 2, 2001);
            Dog dog = new Dog(1, birthday, "Kevin", walked, "");
            string testString = dog.ToString();
            Assert.AreEqual(testString, "Dog: 1, 13-02-2001, Kevin, not reserved, 200, 15-02-2001");

        }

        [TestMethod]

        public void TestDogPrice50002()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            SimpleDate walked = new SimpleDate(15, 2, 2001);
            Dog dog = new Dog(500002, birthday, "Kevin", walked, "");
            Assert.AreEqual(dog.Price, 350);
        }

        [TestMethod]
        public void TestDogPrice500000()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            SimpleDate walked = new SimpleDate(15, 2, 2001);
            Dog dog = new Dog(500000, birthday, "Kevin", walked, "");
            Assert.AreEqual(dog.Price, 350);
        }

        [TestMethod]
        public void TestDogPrice20002()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            SimpleDate walked = new SimpleDate(15, 2, 2001);
            Dog dog = new Dog(200002, birthday, "Kevin", walked, "");
            Assert.AreEqual(dog.Price, 200);
        }

        /// <summary>
        /// Tests if the given parameter actually gets implemented in dog
        /// </summary>
        [TestMethod]
        public void TestLastDayWalked()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            SimpleDate walked = new SimpleDate(15, 2, 2001);
            Dog dog = new Dog(1, birthday, "Kevin", walked, "");
            Assert.AreEqual(dog.LastWalkDate, walked);
        }

        [TestMethod]
        [ExpectedException(typeof(WalkBeforeBornException))]
        public void TestAddDogWhitchIsWalkedBeforeItsBorn()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            SimpleDate walked = new SimpleDate(10, 2, 2000);
            Administration a = new Administration();
            Dog dog = new Dog(1, birthday, "Kevin", walked, "");

            a.Add(dog);
            Assert.AreEqual(a.Animals.Count, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CreateCatwithaNullParameter()
        {
            SimpleDate walked = new SimpleDate(15, 2, 2001);
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
           Dog dog = new Dog(1, birthday, null, walked, "");

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateCatwithaNullBirthday()
        {
            SimpleDate walked = new SimpleDate(15, 2, 2001);
            SimpleDate birthday = new SimpleDate(13, 2, 0000);
            Dog dog = new Dog(1, birthday, "Kevin", walked, "");

        }
    }
}
