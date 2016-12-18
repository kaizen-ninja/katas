using System.Collections.Generic;
using System.IO;

namespace Katas.BankOCR
{
    public class BankOCR
    {
        public int[,] arr;
        StreamReader r;
        List<string> text;
        int lenth;
        public BankOCR(string path, int lines)
        {
            lenth = lines;
            r = new StreamReader(path);
            text = new List<string>();
            Read(lines);
        }

        /// <summary>
        /// Only translate from digits with pipes and underscores
        /// to normal digits.
        /// There is no recognising "ill" digits and errors. 
        /// </summary>
        /// <returns></returns>
        public void Translate()
        {
            List<List<int>> nums = new List<List<int>>();
            
            string[] first = new string[3];
            for (int k = 0; k < lenth * 4; k += 4)
            {
                List<int> numLine = new List<int>();
                for (int i = 0; i < 27; i = i + 3)
                {
                    int l = 0;
                    for (int j = k; j < k + 3; j++)
                    {
                        first[l] = text[j][i].ToString() + text[j][i + 1].ToString() + text[j][i + 2].ToString();
                        l++;
                    }
                    if (first[0] == " _ " && first[1] == "| |" && first[2] == "|_|")
                        numLine.Add(0);
                    if (first[0] == "   " && first[1] == "  |" && first[2] == "  |")
                        numLine.Add(1);
                    if (first[0] == " _ " && first[1] == " _|" && first[2] == "|_ ")
                        numLine.Add(2);
                    if (first[0] == " _ " && first[1] == " _|" && first[2] == " _|")
                        numLine.Add(3);
                    if (first[0] == "   " && first[1] == "|_|" && first[2] == "  |")
                        numLine.Add(4);
                    if (first[0] == " _ " && first[1] == "|_ " && first[2] == " _|")
                        numLine.Add(5);
                    if (first[0] == " _ " && first[1] == "|_ " && first[2] == "|_|")
                        numLine.Add(6);
                    if (first[0] == " _ " && first[1] == "  |" && first[2] == "  |")
                        numLine.Add(7);
                    if (first[0] == " _ " && first[1] == "|_|" && first[2] == "|_|")
                        numLine.Add(8);
                    if (first[0] == " _ " && first[1] == "|_|" && first[2] == " _|")
                        numLine.Add(9);

                    first = new string[3];
                }
                nums.Add(numLine);
            }
            int[,] m = new int[lenth, 9];
            arr = new int[lenth, 9];
            arr = ToInt(lenth, 9, nums);
            //return m;
        }

        int[,] ToInt(int a, int b, List<List<int>> l)
        {
            int[,] nmbr = new int[a, b];
            for(int j = 0; j< a; j++)
            for (int i = 0; i < b; i++)
                nmbr[j, i] = l[j][i];
            return nmbr;
        }

        void Read(int n)
        {
            for(int j = 0; j< n; j++)
                for (int i = 0; i < 4; i++)
                    text.Add(r.ReadLine());
        }
    }
}
