using System.Collections.Generic;

namespace Katas.BinaryGap
{
    public class BinaryGap
    {
        public int GetGap(int N)
        {
            Stack<int> binar = new Stack<int>();
            int temp = N;
            int counter = 0;
            Stack<int> counterStack = new Stack<int>();

            //N to binary & counting "0"
            while (temp != 0)
            {
                binar.Push(temp % 2);
                temp = temp / 2;
                if (binar.Peek() == 0)
                {
                    counter++;
                }
                if (binar.Peek() == 1)
                {
                    counterStack.Push(counter);
                    counter = 0;
                    if (counterStack.Peek() == 0)
                        counterStack.Pop();
                }
            }

            if (counterStack.Count == 0)
                return 0;

            //searching for biggest counter of "0"
            temp = counterStack.Pop();
            while (counterStack.Count != 0)
            {
                if (temp > counterStack.Peek())
                    counterStack.Pop();
                else
                    if (temp < counterStack.Peek())
                        temp = counterStack.Pop();
            }

            return temp;
        }
    }
}
