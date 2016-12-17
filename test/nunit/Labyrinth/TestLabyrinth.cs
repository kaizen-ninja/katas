using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Labyrinth
{
    [TestFixture]
    [Category("LabyrinthKata")]
    public class TestLabyrinth
    {
        Dictionary<char[,], string> testsTable;
        Labyrinth labyrinth = new Labyrinth(new char[1,1]);

        [SetUp]
        public void InitializeTestTable()
        {
            char[,] c = new char[,]
            {
                { '*', '*', '*', '*', '*', '*'},
                { '_', '*', '_', '_', '_', '*'},
                { '*', 's', '_', '*', '_', '*'},
                { '*', '*', '*', '*', '_', '*'},
                { '_', '_', 'e', '_', '_', '*'},
                { '_', '*', '*', '*', '_', '*'},
            };

            char[,] c1 = new char[,]
            {
                { '*', '_', '_', '_', '_', '_'},
                { 's', '_', '*', '*', '_', '*'},
                { '_', '*', '*', '*', '_', '*'},
                { '_', '_', '_', '_', '*', '*'},
                { '*', '_', '*', '_', '*', '_'},
                { '_', '_', '*', '_', 'e', '_'},
            };

            testsTable = new Dictionary<char[,], string>
            {
                {c,     "R U R R D D D L L " },
                {c1,    "D D R R R D D R " }
            };
        }

        [Test]
        public void TestnotnullLabyrinth()
        {
            labyrinth = new Labyrinth(new char[1,1]);
            Assert.NotNull(labyrinth);
        }

        [Test]
        public void TestFindPath()
        {
            foreach (var test in testsTable)
            {
                labyrinth = new Labyrinth(test.Key);
                if (!labyrinth.FindPath())
                    Assert.Fail();
                Assert.AreEqual(test.Value, labyrinth.path);
            }
        }
    }
}
