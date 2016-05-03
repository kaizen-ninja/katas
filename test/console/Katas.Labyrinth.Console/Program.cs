using System;
using System.Linq;
using Labyrinth;

namespace Katas.Labyrinth.ConsoleApp
{
    class Program
    {
        private static readonly char[,] problem1 =
        {
            {'*', '*', '*', '*', '*', '*'},
            {' ', '*', ' ', ' ', ' ', '*'},
            {'*', 's', ' ', '*', ' ', '*'},
            {'*', '*', '*', '*', ' ', '*'},
            {' ', ' ', 'e', ' ', ' ', '*'},
            {' ', '*', '*', '*', ' ', '*'}
        };

        private static readonly char[,] problem2 =
        {
            {' ', 's', ' ', '*', ' ', ' ', ' '},
            {' ', '*', '*', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', '*', ' '},
            {' ', ' ', '*', '*', ' ', '*', ' '},
            {'*', ' ', ' ', ' ', ' ', '*', 'e'},
        };

        // problem with no path to exit
        private static readonly char[,] problem3 =
        {
            {' ', 's', ' ', '*', ' ', ' ', ' '},
            {' ', '*', '*', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', '*', ' '},
            {' ', ' ', '*', '*', ' ', '*', '*'},
            {'*', ' ', ' ', ' ', ' ', '*', 'e'},
        };

        static void Main(string[] args)
        {
            // if (!PrintExit(problem1))
            if (!PrintExit(problem1))
            // if (!PrintExit(problem3))
            {
                Console.WriteLine("No way to exit labyrinth...");
            }
        }

        static bool PrintExit(char[,] labyrinth)
        {
            PrintLabyrinth(labyrinth);

            var path = PathFinder.FindExit(labyrinth);
            if (path == null) return false;
            Console.WriteLine($"Path found: {string.Join(" ", path.GetDirections().Select(DirectionLetter))}");
            return true;
        }

        public static void PrintLabyrinth(char[,] labyrinth)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    var c = labyrinth[i, j];
                    if (c == ' ') c = '_';
                    Console.Write($"{c,3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static string DirectionLetter(MoveDirection d)
        {
            switch (d)
            {
                case MoveDirection.Start:
                    return "S";
                case MoveDirection.Left:
                    return "L";
                case MoveDirection.Up:
                    return "U";
                case MoveDirection.Down:
                    return "D";
                case MoveDirection.Right:
                    return "R";
            }
            return "E";
        }
    }
}
