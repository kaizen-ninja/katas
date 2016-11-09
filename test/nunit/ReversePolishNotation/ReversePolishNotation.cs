using System;
using System.Collections.Generic;

namespace Katas.ReversePolishNotation
{
    class ReversePolishNotationSession
    {
        string expression;

        int caret = 0;

        char currentChar { get { return expression[caret]; } }
        bool eof { get { return caret >= expression.Length; } }

        Dictionary<char, Func<double, double, double>> operationsTable;

        Stack<double> numbers;
        Stack<Func<double, double, double>> operations;

        public ReversePolishNotationSession(string expression)
        {
            this.expression = expression;
            numbers = new Stack<double>();
            operations = new Stack<Func<double, double, double>>();

            operationsTable = new Dictionary<char, Func<double, double, double>>
            {
                { '+', (a, b) => a + b },
                { '-', (a, b) => a - b },
                { '*', (a, b) => a * b },
                { '/', (a, b) => a / b }
            };
        }

        public double Evaluate()
        {
            caret = 0;

            while(!eof)
            {
                SkipWhitespaces();
                if (eof) break;

                if (char.IsDigit(currentChar))
                {
                    ProceedStack();
                    numbers.Push(ResolveNumber());
                }
                else
                {
                    var op = ResolveOperation();
                    ProceedStack();
                    operations.Push(op);
                    ProceedStack();
                }
            }
            ProceedStack();

            return numbers.Pop();
        }
        void ProceedStack()
        {
            while (operations.Count > 0)
            {
                numbers.Push(operations.Pop()(numbers.Pop(), numbers.Pop()));
            }
        }

        double ResolveNumber()
        {
            int started = caret;
            do
            {
                caret++;
            } while (!eof && char.IsDigit(currentChar));

            return double.Parse(expression.Substring(started, caret - started));
        }

        void SkipWhitespaces()
        {
            while (!eof && char.IsWhiteSpace(currentChar))
                caret++;
        }

        Func<double, double, double> ResolveOperation()
        {
            Func<double, double, double> op;
            if (!operationsTable.TryGetValue(currentChar, out op))
                throw new Exception("Can't resolve expression, invalid symbol " + currentChar);
            caret++;
            return op;
        }
    }
}
