using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BankOCRKata
{
    class BankOCR
    {
        const string _digit_0 = " _ " +
                                "| |" +
                                "|_|";

        const string _digit_1 = "   " +
                                "  |" +
                                "  |";

        const string _digit_2 = " _ " +
                                " _|" +
                                "|_ ";

        const string _digit_3 = " _ " +
                                " _|" +
                                " _|";

        const string _digit_4 = "   " +
                                "|_|" +
                                "  |";

        const string _digit_5 = " _ " +
                                "|_ " +
                                " _|";

        const string _digit_6 = " _ " +
                                "|_ " +
                                "|_|";

        const string _digit_7 = " _ " +
                                "  |" +
                                "  |";

        const string _digit_8 = " _ " +
                                "|_|" +
                                "|_|";

        const string _digit_9 = " _ " +
                                "|_|" +
                                " _|";

        struct Symbol
        {
            public string Chars;
            public string Val;

            public Symbol(string chars, string val)
            {
                Chars = chars;
                Val = val;
            }
        }

        Symbol[] _digits = { new Symbol(_digit_0, "0"), new Symbol(_digit_1, "1"), new Symbol(_digit_2, "2"), new Symbol(_digit_3, "3"),
            new Symbol(_digit_4, "4"), new Symbol(_digit_5, "5"), new Symbol(_digit_6, "6"), new Symbol(_digit_7, "7"),
            new Symbol(_digit_8, "8"), new Symbol(_digit_9, "9")};

        bool isChecksumCorrect(string entry)
        {
            int checksum = 0;

            if(entry.Length != 9)
            {
                throw new System.ArgumentException();
            }

            for(int i = 0; i < 9; i++)
            {
                checksum += (9-i) * (entry[i] - '0');
            }

            return (checksum % 11) == 0;
        }

        public string parseEntry(string entry)
        {
            string line1, line2, line3;
            string result = "";

            if(entry.Length != 3*3*9)
            {
                throw new System.ArgumentException();
            }

            line1 = entry.Substring(0, 3 * 9);
            line2 = entry.Substring(3 * 9, 3 * 9);
            line3 = entry.Substring(2 * 3 * 9, 3 * 9);

            for(int i = 0; i < 9; i++)
            {
                string digit = line1.Substring(i * 3, 3)+ line2.Substring(i * 3, 3)+ line3.Substring(i * 3, 3);
                bool char_founded = false;

                foreach(Symbol sym in _digits) {
                    if(sym.Chars.Equals(digit))
                    {
                        result += sym.Val;
                        char_founded = true;
                        break;
                    }
                }

                if (!char_founded)
                    result += "?";
            }

            return result;
        }

        public string parseEntryAndCalcChecksum(string entry)
        {
            string result = parseEntry(entry);

            if(result.Contains('?'))
            {
                result += " ILL";
            } else if(!isChecksumCorrect(result))
            {
                result += " ERR";
            }

            return result;
        }

        public string parseEntryAndGuessNumber(string entry)
        {
            return parseEntryAndCalcChecksum(entry);
        }
    }
}
