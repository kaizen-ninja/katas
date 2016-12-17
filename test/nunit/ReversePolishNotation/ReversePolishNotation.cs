using System;
using System.Collections.Generic;

namespace Katas.ReversePolishNotation
{
    class ReversePolishNotation
    {
        string input;       //  Выражение   
        double result = 0;  //  Результат выражения

        //  Конструктор класса
        public ReversePolishNotation(string input)
        {
            this.input = input;
        }

        //  Метод вычисляющий результат постфиксной записи выражения
        public double Calculate()
        {
            Stack<double> stack = new Stack<double>();                          //Временный стек для решения
            try
            {
                for (int i = 0; i < input.Length; i++)                          //Для каждого символа в строке
                {
                    //Если символ - цифра, то читаем все число и записываем на вершину стека
                    if (Char.IsDigit(input[i]) /*|| output[i] == '-' && i+1 < output.Length && Char.IsDigit(output[i+1])*/)
                    {
                        string a = string.Empty;

                        while (!IsDelimeter(input[i]))  //Пока не разделитель
                        {
                            a += input[i];
                            i++;
                            if (i == input.Length) break;
                        }
                        stack.Push(double.Parse(a));
                        i--;
                    }
                    else if (IsOperator(input[i]))                              //Если символ - оператор
                    {
                        //Берем два последних значения из стека
                        double a = stack.Pop();
                        double b = stack.Pop();

                        switch (input[i]) //И производим над ними действие, согласно оператору
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
                        stack.Push(result); //Результат вычисления записываем обратно в стек
                    }
                }
                return stack.Peek(); //Забираем результат всех вычислений из стека и возвращаем его
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка: введены не вычислительные переменные!");
                return 0;
            }
        }

        //  Метод возвращает true, если проверяемый символ - разделитель
        bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }

        //  Метод возвращает true, если проверяемый символ - оператор
        bool IsOperator(char с)
        {
            if (("+-/*^()".IndexOf(с) != -1))
                return true;
            return false;
        }

    }
}
