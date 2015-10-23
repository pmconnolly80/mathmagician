using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//step 1 per test file.
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class NaturalNumbersTests
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            //create a new instance of a class
            NaturalNumbers nats = new NaturalNumbers();
            //make sure instance is properly created
            Assert.IsNotNull(nats);
            //Right click on Mathagician add Class.  Create new file named the class.  i.e.  NaturalNumbers.cs
        }

        //type - testm.. TAB.. TAB creates [TestMethod] template

        [TestMethod]
        public void ShouldPrintFirstNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int expected = 1;
            int actual = nats.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        /*
        //write a test to throw an error
        [TestMethod]
        [ExpectedException(typeof(AccessViolationException))]
        public void NooneCanAccessPrivateDataMember()
        {
            NaturalNumbers nats = new NaturalNumbers();
            //Whoops Won't Even Compile
            //nats.first;
        }
        */

        [TestMethod]
        public void ShouldPrintNextNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 1;
            int expected = 2;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintNextNumberInput3()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 3;
            int expected = 4;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = nats.GetSequence();
            //compares the arrays for us
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShouldPrintAVariableSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = nats.GetSequence(input);
            //compares the arrays for us
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShouldProvideSameSequences()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 10;
            int[] sequencewithlength = nats.GetSequence(input);
            int[] sequencenolength = nats.GetSequence();
            CollectionAssert.AreEqual(sequencenolength, sequencewithlength);
        }

        [TestMethod]
        public void PrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int length = 7;
            string expected = "1 2 3 4 5 6 7";
            string actual = nats.ToString(nats.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

    }
}
