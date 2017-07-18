using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.BankOCRKata
{
    [TestFixture]
    [Category("BinaryGapKata")]
    class TestBankOCR
    {
        #region Test Use Case 1

        [Test]
        public void TestUseCase1()
        {
            BankOCR bank_ocr = new BankOCR();

            Assert.That(bank_ocr.parseEntry(
                " _  _  _  _  _  _  _  _  _ " +
                "| || || || || || || || || |" +
                "|_||_||_||_||_||_||_||_||_|"
                ), Is.EqualTo("000000000"));

            Assert.That(bank_ocr.parseEntry(
                "                           " +
                "  |  |  |  |  |  |  |  |  |" +
                "  |  |  |  |  |  |  |  |  |"
                ), Is.EqualTo("111111111"));

            Assert.That(bank_ocr.parseEntry(
                " _  _  _  _  _  _  _  _  _ " +
                " _| _| _| _| _| _| _| _| _|" +
                "|_ |_ |_ |_ |_ |_ |_ |_ |_ "
                ), Is.EqualTo("222222222"));

            Assert.That(bank_ocr.parseEntry(
                " _  _  _  _  _  _  _  _  _ " +
                " _| _| _| _| _| _| _| _| _|" +
                " _| _| _| _| _| _| _| _| _|"
                ), Is.EqualTo("333333333"));

            Assert.That(bank_ocr.parseEntry(
                "                           " +
                "|_||_||_||_||_||_||_||_||_|" +
                "  |  |  |  |  |  |  |  |  |"
                ), Is.EqualTo("444444444"));

            Assert.That(bank_ocr.parseEntry(
                " _  _  _  _  _  _  _  _  _ " +
                "|_ |_ |_ |_ |_ |_ |_ |_ |_ " +
                " _| _| _| _| _| _| _| _| _|"
                ), Is.EqualTo("555555555"));

            Assert.That(bank_ocr.parseEntry(
                " _  _  _  _  _  _  _  _  _ " +
                "|_ |_ |_ |_ |_ |_ |_ |_ |_ " +
                "|_||_||_||_||_||_||_||_||_|"
                ), Is.EqualTo("666666666"));

            Assert.That(bank_ocr.parseEntry(
                " _  _  _  _  _  _  _  _  _ " +
                "  |  |  |  |  |  |  |  |  |" +
                "  |  |  |  |  |  |  |  |  |"
                ), Is.EqualTo("777777777"));

            Assert.That(bank_ocr.parseEntry(
                " _  _  _  _  _  _  _  _  _ " +
                "|_||_||_||_||_||_||_||_||_|" +
                "|_||_||_||_||_||_||_||_||_|"
                ), Is.EqualTo("888888888"));

            Assert.That(bank_ocr.parseEntry(
                " _  _  _  _  _  _  _  _  _ " +
                "|_||_||_||_||_||_||_||_||_|" +
                " _| _| _| _| _| _| _| _| _|"
                ), Is.EqualTo("999999999"));

            Assert.That(bank_ocr.parseEntry(
                "    _  _     _  _  _  _  _ " +
                "  | _| _||_||_ |_   ||_||_|" +
                "  ||_  _|  | _||_|  ||_| _|"
                ), Is.EqualTo("123456789"));
        }

        #endregion

        #region Test Use Case 3

        [Test]
        public void TestUseCase3()
        {
            BankOCR bank_ocr = new BankOCR();

            Assert.That(bank_ocr.parseEntryAndCalcChecksum(
                " _  _  _  _  _  _  _  _    " +
                "| || || || || || || ||_   |" +
                "|_||_||_||_||_||_||_| _|  |"
                ), Is.EqualTo("000000051"));

            Assert.That(bank_ocr.parseEntryAndCalcChecksum(
                "    _  _  _  _  _  _     _ " +
                "|_||_|| || ||_   |  |  | _ " +
                "  | _||_||_||_|  |  |  | _|"
                ), Is.EqualTo("49006771? ILL"));

            Assert.That(bank_ocr.parseEntryAndCalcChecksum(
                "    _  _     _  _  _  _  _ " +
                "  | _| _||_| _ |_   ||_||_|" +
                "  ||_  _|  | _||_|  ||_| _"
                ), Is.EqualTo("1234?678? ILL"));
        }

        #endregion

        #region Test Use Case 4

        [Test]
        public void TestUseCase4()
        {
            BankOCR bank_ocr = new BankOCR();

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                "                           " +
                "  |  |  |  |  |  |  |  |  |" +
                "  |  |  |  |  |  |  |  |  |"
                ), Is.EqualTo("711111111"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                " _  _  _  _  _  _  _  _  _ " +
                "  |  |  |  |  |  |  |  |  |" +
                "  |  |  |  |  |  |  |  |  |"
                ), Is.EqualTo("777777177"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                " _  _  _  _  _  _  _  _  _ " +
                " _|| || || || || || || || |" +
                "|_ |_||_||_||_||_||_||_||_|"
                ), Is.EqualTo("200800000"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                " _  _  _  _  _  _  _  _  _ " +
                " _| _| _| _| _| _| _| _| _|" +
                " _| _| _| _| _| _| _| _| _|"
                ), Is.EqualTo("333393333"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                " _  _  _  _  _  _  _  _  _ " +
                "|_||_||_||_||_||_||_||_||_|" +
                "|_||_||_||_||_||_||_||_||_|"
                ), Is.EqualTo("888888888 AMB ['888886888', '888888880', '888888988']"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                " _  _  _  _  _  _  _  _  _ " +
                "|_ |_ |_ |_ |_ |_ |_ |_ |_ " +
                " _| _| _| _| _| _| _| _| _|"
                ), Is.EqualTo("555555555 AMB ['555655555', '559555555']"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                " _  _  _  _  _  _  _  _  _ " +
                "|_ |_ |_ |_ |_ |_ |_ |_ |_ " +
                "|_||_||_||_||_||_||_||_||_|"
                ), Is.EqualTo("666666666 AMB ['666566666', '686666666']"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                " _  _  _  _  _  _  _  _  _ " +
                "|_||_||_||_||_||_||_||_||_|" +
                " _| _| _| _| _| _| _| _| _|"
                ), Is.EqualTo("999999999 AMB ['899999999', '993999999', '999959999']"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                "    _  _  _  _  _  _     _ " +
                "|_||_|| || ||_   |  |  ||_ " +
                "  | _||_||_||_|  |  |  | _|"
                ), Is.EqualTo("490067715 AMB ['490067115', '490067719', '490867715']"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                "    _  _     _  _  _  _  _ " +
                " _| _| _||_||_ |_   ||_||_|" +
                "  ||_  _|  | _||_|  ||_| _|"
                ), Is.EqualTo("123456789"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                " _     _  _  _  _  _  _    " +
                "| || || || || || || ||_   |" +
                "|_||_||_||_||_||_||_| _|  |"
                ), Is.EqualTo("000000051"));

            Assert.That(bank_ocr.parseEntryAndGuessNumber(
                "    _  _  _  _  _  _     _ " +
                "|_||_|| ||_||_   |  |  | _ " +
                "  | _||_||_||_|  |  |  | _|"
                ), Is.EqualTo("490867715"));
        }

        #endregion
    }
}
