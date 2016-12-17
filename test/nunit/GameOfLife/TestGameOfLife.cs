using NUnit.Framework;
using System.Collections.Generic;

namespace Katas.TheGameOfLifeKata
{
    [TestFixture]
    [Category("GameOfLifeKata")]
    public class TestGameOfLife
    {
        GameOfLife life = new GameOfLife();
        Dictionary<bool[,], bool[,]> testsTable;
        bool[,] board, board1, board2, board3;

        [SetUp]
        public void Setup()
        {
            //  Пример 1
            board = new bool[,]
            {
                { false, true },
                { true, true }
            };
            board1 = new bool[,]
            {
                { true, true },
                { true, true }
            };

            //  Пример 2
            board2 = new bool[,]
            {
                { true, true, false, false },
                { false, false, true, true },
                { false, false, false, true },
                { true, true, true, true }
            };
            board3 = new bool[,]
            {
                { false, true, true, false },
                { false, true, true, true },
                { false, false, false, false },
                { false, true, true, true }
            };

            testsTable = new Dictionary<bool[,], bool[,]>
            {
                { board, board1 },
                { board2, board3 }
            };

        }

        [Test]
        public void TestnotnullLife()
        {
            life = new GameOfLife();
            Assert.IsNotNull(life);
        }

        [Test]
        public void TestStep()
        {
            foreach(var tests in testsTable)
            {
                life = new GameOfLife(tests.Key);
                Assert.AreEqual(life.Step(), tests.Value);
            }
        }

        [Test]
        public void TestNumberLife()
        {
            life = new GameOfLife(board2);

            if (life.numberlife(0, 0) == 1 &&
                life.numberlife(0, board2.GetLength(1) - 1) == 2 &&
                life.numberlife(2, 1) == 4)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}