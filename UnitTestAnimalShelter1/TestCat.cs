using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;


namespace UnitTestAnimalShelter1
{
    [TestClass]
    public class TestCat
    {
        [TestMethod]

        public void CreateCatTest()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            Cat cat = new Cat(1, birthday, "smokey", "none", "");
            Assert.AreEqual(cat.Name, "smokey");
            Assert.AreEqual(cat.Price, 56);
            Assert.AreEqual(cat.DateOfBirth, birthday);
            Assert.AreEqual(cat.BadHabits, "none");
            Assert.AreEqual(cat.ChipRegistrationNumber, 1);
        }

        [TestMethod]
        public void ToStringTestcat()
        {

            SimpleDate birthday = new SimpleDate(13, 2, 2001);

            Cat cat = new Cat(1, birthday, "Kevin", "sick", "");
            string testString = cat.ToString();
            Assert.AreEqual(testString, "Cat: 1, 13-02-2001, Kevin, not reserved, 56, sick");
        }

        [TestMethod]

        public void TestCatPrice60()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);

            Cat cat = new Cat(1, birthday, "Kevin", "", "");
            Assert.AreEqual(cat.Price, 60);
        }

        [TestMethod]

        public void TestCatPriceLess60()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);

            Cat cat = new Cat(1, birthday, "Kevin", "sick", "");
            Assert.AreEqual(cat.Price, 56);
        }
        [TestMethod]

        public void TestCatPriceLess20()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);

            Cat cat = new Cat(1, birthday, "Kevin", "heisabitsickandheisabittiredheisabitsickandheisabittiredheisabitsickandheisabittired", "");
            Assert.AreEqual(cat.Price, 20);
        }

        /// <summary>
        /// Tests if the given parameter actually gets implemented in cat
        /// </summary>
        [TestMethod]
        public void TestBadHabits()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            Cat cat = new Cat(1, birthday, "smokey", "none", "");
            Assert.AreEqual(cat.BadHabits, "none");
        }
        [TestMethod]
        public void AddCatWhitchIsbornToday()
        {
            SimpleDate now = new SimpleDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            SimpleDate birthday = new SimpleDate(13, 2, 3022);
            Cat cat = new Cat(1, now, "Kevin", "sick", "");

            Administration a = new Administration();
            a.Add(cat);
            Assert.IsTrue(a.Animals.Count == 1);

        }

        [TestMethod]
        [ExpectedException(typeof(BornInFutureException))]
        public void AddCatWhitchIsNotBornToday()
        {
            SimpleDate now = new SimpleDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            SimpleDate birthday = new SimpleDate(13, 2, 9000);
            Cat cat = new Cat(1, birthday, "Kevin", "sick", "");

            Administration a = new Administration();
            a.Add(cat);
            Assert.IsTrue(a.Animals.Count == 0);

        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CreateCatwithaNullParameter()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 2001);
            Cat cat = new Cat(3, birthday, null, "none", "");
  
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateCatwithaNullBirthday()
        {
            SimpleDate birthday = new SimpleDate(13, 2, 0000);
            Cat cat = new Cat(3, birthday, "kim", "none", "");

        }



    }
}
