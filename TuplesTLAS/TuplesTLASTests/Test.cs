using NUnit.Framework;
using System;
using TuplesTLAS.Objects;
using TuplesTLAS.GameManager;

namespace TuplesTLASTests
{


    [TestFixture()]
    public class UnitTest1
    {
        [Test()]
        public void TestSize1()
        {
            var tuple = new TupleAPI();
            tuple.Add(1, 2);
            tuple.Add(3, 4);
            tuple.Add(3, 4);
            Assert.AreEqual(tuple.Tuples.Count, 3);
        }

        [Test()]
        public void TestSizeEmpty()
        {
            var tuple = new TupleAPI();
            Assert.AreEqual(tuple.Tuples.Count, 0);
        }

        [Test()]
        public void TestSum()
        {
            var tuple = new TupleAPI();
            tuple.Add(1, 2);
            tuple.Add(3, 4);
            tuple.Add(5, 5);
            Assert.AreEqual(tuple.Sum(), 20);
        }

        [Test()]
        public void TestSumCoupleEqual10()
        {
            var tuple = new TupleAPI();
            tuple.Add(1, 2);
            tuple.Add(3, 4);
            tuple.Add(5, 5);
            tuple.Add(6, 1);
            Assert.AreEqual(tuple.Sum(), 33);
        }

        [Test()]
        public void TestSumFirstMemberCoupleEqual10()
        {
            var tuple = new TupleAPI();
            tuple.Add(10, 0);
            tuple.Add(6, 1);
            Assert.AreEqual(tuple.Sum(), 24);
        }

        [Test()]
        public void TestSumTwoCoupleEqual10()
        {
            var tuple = new TupleAPI();
            tuple.Add(5, 5);
            tuple.Add(6, 1);
            tuple.Add(5, 5);
            tuple.Add(6, 1);
            Assert.AreEqual(tuple.Sum(), 46);
        }

        [Test()]
        public void TestSecondMemberFirstCoupleEqual10()
        {
            var tuple = new TupleAPI();
            tuple.Add(0, 10);
            tuple.Add(6, 1);
            Assert.AreEqual(tuple.Sum(), 23);
        }

        [Test()]
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
            var ex = Assert.Throws<ArgumentException>(() => tuple.Add(1, 2));
            Assert.AreEqual("Max capacity", ex.Message);
        }
    

        [Test()]
        public void TestPositive1()
        {
            var tuple = new TupleAPI();
            var ex = Assert.Throws<ArgumentException>(() => tuple.Add(-1, -2));
            Assert.AreEqual("Tuple members are not positives", ex.Message);
        }

        [Test()]
        public void TestPositive2()
        {
            var tuple = new TupleAPI();
            var ex = Assert.Throws<ArgumentException>(() => tuple.Add(1, -2));
            Assert.AreEqual("Tuple members are not positives", ex.Message);
        }

        [Test()]
        public void TestPositive3()
        {
            var tuple = new TupleAPI();
            var ex = Assert.Throws<ArgumentException>(() => tuple.Add(-1, 2));
            Assert.AreEqual("Tuple members are not positives", ex.Message);
        }

        [Test()]
        public void TestMaxCapacityTuple1()
        {
            var tuple = new TupleAPI();
            var ex = Assert.Throws<ArgumentException>(() => tuple.Add(5, 6));
            Assert.AreEqual("Max capacity of the tuple", ex.Message);
        }

        [Test()]
        public void TestMaxCapacityTuple2()
        {
            var tuple = new TupleAPI();
            var ex = Assert.Throws<ArgumentException>(() => tuple.Add(30, 0));
            Assert.AreEqual("Max capacity of the tuple", ex.Message);
        }

        [Test()]
        public void TestMaxCapacityTuple3()
        {
            var tuple = new TupleAPI();
            var ex = Assert.Throws<ArgumentException>(() => tuple.Add(0, 30));
            Assert.AreEqual("Max capacity of the tuple", ex.Message);
        }
        
        [Test()]
        public void TestMainNoBonus()
        {
            var game = new Game();
            var tuple = new TupleAPI();
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(5, 1);

            var score = game.LaunchGame(tuple);
            Assert.AreEqual(182, score);
        }

        [Test()]
        public void TestMainSpareLast()
        {
            var game = new Game();
            var tuple = new TupleAPI();
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(2, 8);

            var score = game.LaunchGame(tupleApi:tuple, valueBonus1:6);
            Assert.AreEqual(196, score);
        }

        [Test()]
        public void TestMainStrikeLast()
        {
            var game = new Game();
            var tuple = new TupleAPI();
            tuple.Add(10, 0);   // 10
            tuple.Add(10, 0);   // 30
            tuple.Add(10, 0);   // 50
            tuple.Add(10, 0);   // 70
            tuple.Add(10, 0);   // 90
            tuple.Add(10, 0);   // 110
            tuple.Add(10, 0);   // 130
            tuple.Add(10, 0);   // 150
            tuple.Add(10, 0);   // 170
            tuple.Add(10, 0);   // 190
                                // 197

            var score = game.LaunchGame(tupleApi:tuple, 6, 1);
            Assert.AreEqual(197, score);
        }
    }
}
