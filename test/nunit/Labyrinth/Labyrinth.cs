namespace Katas.Labyrinth
{
    public class Labyrinth
    {
        public char[,] labyrinth;   //  Лабиринт
        public string path;         //  Путь через лабиринт
        int I, J;                   //  Текущее местонахождение
        public int n;               //  Размер лабиринта

        //  Конструктор класса
        public Labyrinth(char[,] labyrinth)
        {
            this.labyrinth = labyrinth;
            n = labyrinth.GetLength(0);
        }

        //  Ищет путь через лабиринт
        public bool FindPath()
        {
            I = J = 0;

            char[,] labyrinth1 = new char[n + 2, n + 2]; //  Первый лабиринт, окружённый стенами

            for (int i = 0; i < n + 2; i++)
            {
                for (int j = 0; j < n + 2; j++)
                {
                    //  Окружаем лабиринт стенами
                    if (i == 0 || j == 0 || i == n + 1 || j == n + 1)
                    {
                        labyrinth1[i, j] = '*';
                        continue;
                    }

                    //  Помещаем исходный лабиринт внутрь нового
                    labyrinth1[i, j] = labyrinth[i - 1, j - 1];
                }
            }
            labyrinth = labyrinth1;
            n = labyrinth.GetLength(0);

            //  Удаляем тупики из лабиринта
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    RemoveDeadEnds(i, j);
                }
            }

            //  Встаём на стартовую точку
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (labyrinth[i, j] == 's')
                    {
                        I = i;
                        J = j;
                        break;
                    }
                }
                if (labyrinth[I, J] == 's')
                    break;
            }

            //  Идём к конечной точке
            return Step();
        }

        //  Удаление тупиков в лабиринте
        void RemoveDeadEnds(int i, int j)
        {
            int k = 0;  //  Количество стен вокруг точки
            bool s, e;  //  Начало и конец
            s = e = false;

            if (labyrinth[i, j] == '_')
            {
                //  Проверка на начало лабиринта
                if (labyrinth[i - 1, j] == 's')
                    s = true;
                if (labyrinth[i + 1, j] == 's')
                    s = true;
                if (labyrinth[i, j - 1] == 's')
                    s = true;
                if (labyrinth[i, j + 1] == 's')
                    s = true;

                //  Проверка на конец лабиринта
                if (labyrinth[i - 1, j] == 'e')
                    e = true;
                if (labyrinth[i + 1, j] == 'e')
                    e = true;
                if (labyrinth[i, j - 1] == 'e')
                    e = true;
                if (labyrinth[i, j + 1] == 'e')
                    e = true;

                //  Счёт количества стен вокруг точки
                if (labyrinth[i - 1, j] == '*')
                    k++;
                if (labyrinth[i + 1, j] == '*')
                    k++;
                if (labyrinth[i, j - 1] == '*')
                    k++;
                if (labyrinth[i, j + 1] == '*')
                    k++;

                //  Полость в лабиринте
                if (k == 4)
                    labyrinth[i, j] = '*';

                //  Тупик
                if (k == 3 && (s == true || e == true))
                {
                    labyrinth[i, j] = '*';
                }
                //  Тупик
                else if (k == 3)
                {
                    labyrinth[i, j] = '*';
                    if (labyrinth[i - 1, j] == '_')
                        RemoveDeadEnds(i - 1, j);
                    if (labyrinth[i + 1, j] == '_')
                        RemoveDeadEnds(i + 1, j);
                    if (labyrinth[i, j - 1] == '_')
                        RemoveDeadEnds(i, j - 1);
                    if (labyrinth[i, j + 1] == '_')
                        RemoveDeadEnds(i, j + 1);
                }
            }
        }

        //  Шаг к выходу
        bool Step()
        {
            if (labyrinth[I - 1, J] == '_' || labyrinth[I - 1, J] == 'e') // Шаг вверх
            {
                labyrinth[I, J] = '*';
                I = I - 1;
                path += "U ";
            }
            else if (labyrinth[I + 1, J] == '_' || labyrinth[I + 1, J] == 'e')    // Шаг вниз
            {
                labyrinth[I, J] = '*';
                I = I + 1;
                path += "D ";
            }
            else if (labyrinth[I, J - 1] == '_' || labyrinth[I, J - 1] == 'e')    // Шаг влево
            {
                labyrinth[I, J] = '*';
                J = J - 1;
                path += "L ";
            }
            else if (labyrinth[I, J + 1] == '_' || labyrinth[I, J + 1] == 'e')    // Шаг вправо
            {
                labyrinth[I, J] = '*';
                J = J + 1;
                path += "R ";
            }
            else
                return false;   //  Пути нет

            if (labyrinth[I, J] == 'e')
                return true;
            else
                Step();

            if (labyrinth[I, J] == 'e')
                return true;
            else
                return false;
        }
    }
}
