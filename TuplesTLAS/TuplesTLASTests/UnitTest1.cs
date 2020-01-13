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
            tuple.Add(8, -6);
            Assert.Equals(tuple.Tuples.Count, 3);
        }
    }
}
