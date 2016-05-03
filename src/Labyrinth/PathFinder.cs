using System;
using System.Collections.Generic;
using System.Linq;

namespace Labyrinth
{
    public class PathFinder
    {
        public const char Border = '*';

        public static MovingPath<Cell> FindExit(char[,] labyrinth)
        {
            MovingPath<Cell> path = null;

            Queue<Cell> visitedCells = new Queue<Cell>();
            var initialCell = FindStartingCell(labyrinth);
            
            visitedCells.Enqueue(initialCell);
            CellVisitor visitor = new CellVisitor(labyrinth.GetLength(0), labyrinth.GetLength(1), initialCell);

            var steps = CellVisitor.Steps;

            // Perform Breath-First-Search (BFS)
            while (visitedCells.Count > 0)
            {
                Cell currentCell = visitedCells.Dequeue();

                int row = currentCell.Row;
                int col = currentCell.Col;
                int distance = currentCell.Distance;

                if (labyrinth[row, col] == 'e')
                {
                    path = visitor.GetShortestPath(new Cell(row, col, distance));
                    break;
                }
                steps.ForEach(step =>
                {
                    int x = row + step.Item1, y = col + step.Item2;
                    if (!visitor.InRange(x, y) || visitor.IsVisited(x, y) || labyrinth[x, y] == Border) return;
                    // The cell is free -> visit it
                    var cell = new Cell(x, y, distance + 1);
                    visitedCells.Enqueue(cell);
                    visitor[x, y] = cell;
                });
            }
            return path;
        }

        static Cell FindStartingCell(char[,] labyrinth)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == 's')
                    {
                        return new Cell(i, j, 0);
                    }
                }
            }
            throw new Exception("Start cell is missing -> no path...\n");
        }
    }
}