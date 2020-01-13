using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuplesTLAS.Objects;

namespace TuplesTLASTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSize()
        {
            var tuple = new TupleAPI();
            tuple.Add(1, 2);
            tuple.Add(3, 4);
            tuple.Add(3, 4);
            Assert.AreEqual(tuple.Tuples.Count, 3);
        }

        [TestMethod]
        public void TestSum()
        {
            var tuple = new TupleAPI();
            tuple.Add(1, 2);
            tuple.Add(3, 4);
            tuple.Add(5, 5);
            Assert.AreEqual(tuple.Sum(), 20);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Max capacity")]
        public void TestMaxCapacitiy()
        {
            var tuple = new TupleAPI();
            tuple.Add(1, 2);
            tuple.Add(1, 2);
            tuple.Add(1, 2);
            tuple.Add(1, 2);
            tuple.Add(1, 2);
            tuple.Add(1, 2);
            tuple.Add(1, 2);
            tuple.Add(1, 2);
            tuple.Add(1, 2);
            tuple.Add(1, 2);
            tuple.Add(1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Tuple members are not positives")]
        public void TestPositive()
        {
            var tuple = new TupleAPI();
            tuple.Add(-1, 2);
            tuple.Add(-1, -2);
            tuple.Add(1, -2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Max capacity of the tuple")]
        public void TestMaxCapacityTuple()
        {
            var tuple = new TupleAPI();
            tuple.Add(5, 6);
            tuple.Add(6, 5);
            tuple.Add(5, 5);
        }
    }
}
