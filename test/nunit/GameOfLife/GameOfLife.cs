using System;

namespace Katas.TheGameOfLifeKata
{
    public class GameOfLife
    {
        Random rnd = new Random();
        public bool[,] board { get; private set; }  // Сетка
        int n;          // Размер сетки i
        int n1;         // Размер сетки j
        int numberCell; // Количество клеток

        #region Конструкторы

        public GameOfLife() : this(20, 40)
        { }

        public GameOfLife(bool[,] board)
        {
            n = board.GetLength(0);
            n1 = board.GetLength(1);
            this.board = board;
        }

        public GameOfLife(int n, int numberCell)
        {
            n1 = this.n = n;
            this.numberCell = numberCell;
            board = new bool[n, n1];
            RandomBoard();
        }

        public GameOfLife(int n, int n1, int numberCell)
        {
            this.n = n;
            this.n1 = n1;
            this.numberCell = numberCell;
            board = new bool[n, n1];
            RandomBoard();
        }

        #endregion

        bool random()   // Случайное значение bool
        {
            int n = rnd.Next(100);

            if (n < 50)
                return false;
            else
                return true;
        }

        void RandomBoard()  // Случайное заполнение сетки  
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    if (numberCell > 0 && board[i, j] == false)
                    {
                        board[i, j] = random();

                        if (board[i, j] == true) // Если в ячейке есть клетка
                            numberCell--;
                    }
                }
                if (numberCell == 0)
                    break;
            }
            if (numberCell > 0)
                RandomBoard();

        }

        public bool[,] Step()
        {
            bool[,] board1 = new bool[n, n1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    int k = numberlife(i, j);

                    if (board[i, j] == true && (k < 2 || k > 3))
                        board1[i, j] = false;
                    else if (board[i, j] == true)
                        board1[i, j] = true;
                    else if (board[i, j] == false && k == 3)
                        board1[i, j] = true;
                }
            }
            board = board1;

            return board;
        }

        public int numberlife(int i, int j)    //  Количество живых клеток рядом с данной
        {
            int k = 0;

            if (i == 0 && j == 0)   //  Верхний левый угол
            {
                if (board[i, j + 1] == true)
                    k++;
                if (board[i + 1, j + 1] == true)
                    k++;
                if (board[i + 1, j] == true)
                    k++;
            }
            else if (i == n - 1 && j == 0)  //  Нижний левый угол
            {
                if (board[i - 1, j] == true)
                    k++;
                if (board[i - 1, j + 1] == true)
                    k++;
                if (board[i, j + 1] == true)
                    k++;
            }
            else if (i == 0 && j == n1 - 1)  // Верхний правый угол
            {
                if (board[i + 1, j - 1] == true)
                    k++;
                if (board[i, j - 1] == true)
                    k++;
                if (board[i + 1, j] == true)
                    k++;
            }
            else if (i == n - 1 && j == n1 - 1)   //  Нижний правый угол
            {
                if (board[i, j - 1] == true)
                    k++;
                if (board[i - 1, j - 1] == true)
                    k++;
                if (board[i - 1, j] == true)
                    k++;
            }
            else if (i == 0)     //  Верхняя граница
            {
                if (board[i + 1, j - 1] == true)
                    k++;
                if (board[i, j - 1] == true)
                    k++;
                if (board[i, j + 1] == true)
                    k++;
                if (board[i + 1, j + 1] == true)
                    k++;
                if (board[i + 1, j] == true)
                    k++;
            }
            else if (i == n - 1)     //  Нижняя граница
            {
                if (board[i, j - 1] == true)
                    k++;
                if (board[i - 1, j - 1] == true)
                    k++;
                if (board[i - 1, j] == true)
                    k++;
                if (board[i - 1, j + 1] == true)
                    k++;
                if (board[i, j + 1] == true)
                    k++;
            }
            else if (j == 0)     // Левая граница
            {
                if (board[i - 1, j] == true)
                    k++;
                if (board[i - 1, j + 1] == true)
                    k++;
                if (board[i, j + 1] == true)
                    k++;
                if (board[i + 1, j + 1] == true)
                    k++;
                if (board[i + 1, j] == true)
                    k++;
            }
            else if (j == n1 - 1)     //  Правая граница
            {
                if (board[i + 1, j - 1] == true)
                    k++;
                if (board[i, j - 1] == true)
                    k++;
                if (board[i - 1, j - 1] == true)
                    k++;
                if (board[i - 1, j] == true)
                    k++;
                if (board[i + 1, j] == true)
                    k++;
            }
            else    //  Не у границы
            {
                if (board[i + 1, j - 1] == true)
                    k++;
                if (board[i, j - 1] == true)
                    k++;
                if (board[i - 1, j - 1] == true)
                    k++;
                if (board[i - 1, j] == true)
                    k++;
                if (board[i - 1, j + 1] == true)
                    k++;
                if (board[i, j + 1] == true)
                    k++;
                if (board[i + 1, j + 1] == true)
                    k++;
                if (board[i + 1, j] == true)
                    k++;
            }

            return k;
        }
    }
}