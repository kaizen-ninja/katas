using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.ReversePolishNotation
{
    class ReversePolishNotation
    {
        //  Метод возвращает true, если проверяемый символ - разделитель
        private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }

        //  Метод возвращает true, если проверяемый символ - оператор
        private bool IsOperator(char с)
        {
            if (("+-/*^()".IndexOf(с) != -1))
                return true;
            return false;
        }

        //  Метод возвращает приоритет оператора
        private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 6;
            }
        }

        //  Входной метод класса
        public double Calculate(string input)
        {
            string output = GetExpression(input);
            double result = Counting(output);
            return result;
        }

        //  Mетод, которому основной метод Calculate будет передавать выражение, и получать его уже в постфиксной записи.
        private string GetExpression(string input)
        {
            string output = string.Empty;
            Stack<char> Stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (IsDelimeter(input[i]))
                {
                    continue;
                }

                if (Char.IsDigit(input[i]))
                {
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length)
                        {
                            break;
                        }
                    }
                    output += " ";
                    i--;
                }

                if (IsOperator(input[i]))
                {
                    if (input[i] == '(')
                    {
                        Stack.Push(input[i]);
                    }
                    else if (input[i] == ')')
                    {
                        char s = Stack.Pop();
                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = Stack.Pop();
                        }
                    }
                    else
                    {
                        if (Stack.Count > 0)
                        {
                            if (GetPriority(input[i]) <= GetPriority(Stack.Peek()))
                            {
                                output += Stack.Pop().ToString() + " ";
                            }
                        }
                        Stack.Push(char.Parse(input[i].ToString()));
                    }
                }
            }
            while (Stack.Count > 0)
            {
                output += Stack.Pop() + " ";
            }
            return output;
        }

        //  Метод, вычисляющий значение выражения, уже преобразованного в постфиксную запись
        private double Counting(string input)
        {
            double result = 0;
            Stack<double> stack = new Stack<double>();
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsDigit(input[i]))
                    {
                        string a = string.Empty;

                        while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                        {
                            a += input[i];
                            i++;
                            if (i == input.Length) break;
                        }
                        stack.Push(double.Parse(a));
                        i--;
                    }
                    else if (IsOperator(input[i]))
                    {
                        double a = stack.Pop();
                        double b = stack.Pop();

                        switch (input[i])
                        {
                            case '+':
                                result = b + a;
                                break;
                            case '-':
                                result = b - a;
                                break;
                            case '*':
                                result = b * a;
                                break;
                            case '/':
                                result = b / a;
                                break;
                            case '^':
                                result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString());
                                break;
                        }
                        stack.Push(result);
                    }
                }
                return stack.Peek();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка: введены не вычислительные переменные!");
                return 0;
            }

        }
    }
}
