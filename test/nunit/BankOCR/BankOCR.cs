using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BankOCRKata
{
    public class BankOCR
    {

        #region Private
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
                if (entry[i] == '?')
                    return false;

                checksum += (9-i) * (entry[i] - '0');
            }

            return (checksum % 11) == 0;
        }

        int symbolsDifference(string chars1, string chars2)
        {
            int difference = 0;

            if (chars1.Length != 9 || chars2.Length != 9)
            {
                throw new System.ArgumentException();
            }

            for(int i = 0; i < 9; i++)
            {
                if (chars1[i] != chars2[i])
                    difference++;
            }

            return difference;
        }

        List<string> guessNumber(string entry, int start_from = 0)
        {
            // string number = parseEntry(entry);
            List<string> numbers = new List<string>();

            if (start_from >= 9)
                return numbers;
            
            foreach(Symbol sym in _digits)
            {
                string chars = entry.Substring(start_from * 3, 3) + entry.Substring(3 * (9 + start_from), 3) + entry.Substring(3 * (2 * 9 + start_from), 3);
                int difference = symbolsDifference(chars, sym.Chars);

                if (difference == 1)
                {
                    string new_entry = entry.Remove(start_from * 3, 3).Insert(start_from * 3, sym.Chars.Substring(0, 3)).
                        Remove(3 * (9 + start_from), 3).Insert(3 * (9 + start_from), sym.Chars.Substring(3, 3)).
                        Remove(3 * (2 * 9 + start_from), 3).Insert(3 * (2 * 9 + start_from), sym.Chars.Substring(6, 3));

                    string new_number = parseEntry(new_entry);

                    if (isChecksumCorrect(new_number))
                    {
                        numbers.Add(new_number);
                    } 
                }
                else if (difference == 0)
                {
                    numbers.AddRange(guessNumber(entry, start_from + 1));
                }
            }

            return numbers;
        }

        #endregion

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

                foreach(Symbol sym in _digits)
                {
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

        public enum FileParsingStrategy
        {
            PARSE_ONLY = 0,
            PARSE_AND_CHECK_SUM,
            PARSE_AND_GUESS_NUMBER
        };

        public string parseFile(string text, FileParsingStrategy strategy = FileParsingStrategy.PARSE_ONLY)
        {
            int index, last_index;
            string last_entry = "";

            if (String.IsNullOrEmpty(text))
                return "";

            last_index = index = text.Length - 1;

            for (int i = 0; i < 3; i++)
            {
                if(index < 0)
                {
                    throw new System.ArgumentException("Not all entries was read:" + last_entry + ":" + text);
                }

                if(text[index] != '\n')
                {
                    throw new System.ArgumentException("No new line at end of entry:" + last_entry + ":" + text);
                }

                index--;

                while(index >= 0)
                {
                    if(text[index] == '\n')
                    {
                        break;
                    } else
                    {
                        index--;
                    }
                }

                string entryline = text.Substring(index + 1, last_index - index - 1);

                if(entryline.Length != 3*9)
                {
                    throw new System.ArgumentException("Entry line should have size of 27 characters:"+entryline+":"+text);
                }

                last_entry = entryline + last_entry;

                last_index = index;
            }
            
            if (String.IsNullOrEmpty(last_entry))
                return parseFile(text.Substring(0, last_index+1), strategy);
            else
            {
                string entry_result = "";

                switch(strategy)
                {
                    case FileParsingStrategy.PARSE_ONLY:
                        entry_result = parseEntry(last_entry);
                        break;
                    case FileParsingStrategy.PARSE_AND_CHECK_SUM:
                        entry_result = parseEntryAndCalcChecksum(last_entry);
                        break;
                    case FileParsingStrategy.PARSE_AND_GUESS_NUMBER:
                        entry_result = parseEntryAndGuessNumber(last_entry);
                        break;
                }

                return parseFile(text.Substring(0, last_index + 1), strategy) + entry_result + "\n";
            }
        }

        public string parseEntryAndCalcChecksum(string entry)
        {
            string result = parseEntry(entry);

            if(result.Contains('?'))
            {
                result += " ILL";
            }
            else if(!isChecksumCorrect(result))
            {
                result += " ERR";
            }

            return result;
        }

        public string parseFileAndCalcChecksum(string text)
        {
            return parseFile(text, FileParsingStrategy.PARSE_AND_CHECK_SUM);
        }

        public string parseEntryAndGuessNumber(string entry)
        {
            string result = parseEntryAndCalcChecksum(entry);

            if(result.Length != 9)
            {
                List<string> results = guessNumber(entry);

                if (results.Count == 1)
                {
                    result = results[0];
                }
                else if (results.Count > 1)
                {
                    result = result.Substring(0, 9) + " AMB ['" + results[0] + "'";

                    for (int i = 1; i < results.Count; i++)
                        result += ", '" + results[i] + "'";

                    result += "]";
                }
            }

            return result;
        }

        public string parseFileAndGuessNumber(string text)
        {
            return parseFile(text, FileParsingStrategy.PARSE_AND_GUESS_NUMBER);
        }
    }
}
