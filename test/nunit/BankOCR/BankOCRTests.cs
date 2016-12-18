using System;
using NUnit.Framework;


namespace Katas.BankOCR
{
    [TestFixture]
    public class BankOCRTests
    {
        [Test]
        public void Translate_file_with5lines()
        {
            bool e = true;
            bool a = true;
            int[,] expected = new int[2, 9];
            expected[0, 0] = 1;
            expected[0, 1] = 2;
            expected[0, 2] = 3;
            expected[0, 3] = 4;
            expected[0, 4] = 5;
            expected[0, 5] = 6;
            expected[0, 6] = 7;
            expected[0, 7] = 8;
            expected[0, 8] = 9;
            expected[1, 0] = 1;
            expected[1, 1] = 1;
            expected[1, 2] = 1;
            expected[1, 3] = 1;
            expected[1, 4] = 1;
            expected[1, 5] = 1;
            expected[1, 6] = 1;
            expected[1, 7] = 1;
            expected[1, 8] = 1;

            BankOCR b = new BankOCR("test_input1.txt", 2);
            int[,] actual = new int[2, 9];
            b.Translate();
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 9; j++)
                    actual[i, j] = b.arr[i, j];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 9; j++)
                    if (actual[i, j] != expected[i, j])
                        a = false;

            Assert.AreEqual(e, a);
        }
    }
}
