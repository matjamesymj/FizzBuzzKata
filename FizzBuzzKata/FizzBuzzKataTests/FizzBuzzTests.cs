using FizzBuzzKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKataTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void ThreeIsDivisableByThreeTest()
        {
            FizzBuzz fb = new FizzBuzz();
            bool isDivisable = fb.IsDivisableByThree(3);
            Assert.IsTrue(isDivisable);
        }

        [TestMethod]
        public void ThreeIsDivisableByFiveTest()
        {
            FizzBuzz fb = new FizzBuzz();
            bool isDivisable = fb.IsDivisibleByFive(5);
            Assert.IsTrue(isDivisable);
        }

        [TestMethod]
        public void GetTextForNumberReturnsFizzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string returnText = fb.GetTextForNumber(3);
            Assert.AreEqual("Fizz", returnText);
        }

        [TestMethod]
        public void GetTextForNumberReturnsBuzzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string returnText = fb.GetTextForNumber(5);
            Assert.AreEqual("Buzz", returnText);
        }

        [TestMethod]
        public void GetTextForNumberReturnsFizzBuzzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string returnText = fb.GetTextForNumber(15);
            Assert.AreEqual("FizzBuzz", returnText);

        }

        [TestMethod]
        public void IsNotDivisbleByThreeOrFiveTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string returnText = fb.GetTextForNumber(4);
            Assert.AreEqual("4", returnText);

        }

        [TestMethod]
        public void DoAllFizzBuzzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string returnText = fb.DoAllFizzBuzz(30);
            Assert.AreEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29", returnText);

        }

    }
}
