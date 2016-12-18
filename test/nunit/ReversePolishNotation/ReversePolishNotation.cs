using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.ReversePolishNotation
{
    public class ReversePolishNotation
    {
        public string RPN(string expression)
        {
                Stack<char> texas;
                string strOut = "";
                string strIn1 = "";
                expression += " ";
                texas = new Stack<char>();
                for (int i = 0; i < expression.Length; i++)
                {
                    if (Char.IsLetter(expression[i]))
                        strIn1 = "letter";
                    if (Char.IsNumber(expression[i]) || expression[i] == '.' || expression[i] == ',')
                        strIn1 = "num";
                    if (expression[i] == '+' || expression[i] == '-')
                        strIn1 = "second";
                    if (expression[i] == '/' || expression[i] == '*' || expression[i] == '^')
                        strIn1 = "first";
                    if (expression[i] == '(')
                        strIn1 = "open_break";
                    if (expression[i] == ')')
                        strIn1 = "close_break";
                    if (expression[i] == ' ')
                        strIn1 = "empty";

                    switch (strIn1)
                    {
                        case "num":
                        case "letter":
                            strOut = strOut + expression[i];
                            break;

                        case "second":
                            if (texas.Count == 0)
                            {
                                texas.Push(expression[i]);
                                break;
                            }
                            else
                                while (texas.Peek() == '/' || texas.Peek() == '*' || texas.Peek() == '^')
                                {
                                    strOut = strOut + texas.Pop();

                                    if (texas.Count == 0)
                                        break;
                                    if (texas.Peek() == '-' || texas.Peek() == '+')
                                        strOut = strOut + texas.Pop();
                                    if (texas.Count == 0)
                                        break;
                                }
                            texas.Push(expression[i]);

                            if (texas.Count != 0 && texas.Peek() == '(')
                                texas.Push(expression[i]);
                            break;
                        case "first":
                            texas.Push(expression[i]);
                            break;

                        case "open_break":
                            texas.Push(expression[i]);
                            break;

                        case "close_break":
                            while (texas.Peek() != '(')
                                strOut = strOut + texas.Pop();
                            texas.Pop();
                            break;
                        case "empty":
                            while (texas.Count != 0)
                            {
                                strOut = strOut + texas.Pop();
                            }
                            break;
                    }
                }
                return strOut;
            }
        }
}
