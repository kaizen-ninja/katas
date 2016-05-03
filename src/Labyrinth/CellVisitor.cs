using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Cell
    {
        public Cell(int row, int col, int distance)
        {
            this.Row = row;
            this.Col = col;
            this.Distance = distance;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public int Distance { get; set; }

        public override string ToString()
        {
            return $"(x:{Row},y:{Col})";
        }
    }

    public class CellVisitor
    {
        // possible movement and two-way direction (direct & reverse)
        public static readonly List<Tuple<int, int, MoveDirection, MoveDirection>> Steps =
            new List<Tuple<int, int, MoveDirection, MoveDirection>>()
            {
                Tuple.Create(0, 1, MoveDirection.Right, MoveDirection.Left),
                Tuple.Create(0, -1, MoveDirection.Left, MoveDirection.Right),
                Tuple.Create(1, 0, MoveDirection.Down, MoveDirection.Up),
                Tuple.Create(-1, 0, MoveDirection.Up, MoveDirection.Down)
            };

        public CellVisitor(int rows, int cols, Cell start)
        {
            _cells = new Cell[rows, cols];
            _cells[start.Row, start.Col] = start;
        }

        private readonly Cell[,] _cells;

        public int RowCount => _cells.GetLength(0);

        public int ColCount => _cells.GetLength(1);

        public bool InRange(int row, int col)
        {
            return row >= 0 && row < RowCount && col >= 0 && col < ColCount;
        }

        public bool IsVisited(int row, int col)
        {
            return _cells[row, col] != null;
        }

        public Cell this[int row, int col]
        {
            get { return _cells[row, col]; }
            set { _cells[row, col] = value; }
        }

        public MovingPath<Cell> GetShortestPath(Cell dest)
        {
            var path = new MovingPath<Cell>(dest, MoveDirection.End);

            Cell cell = dest;
            Cell prev = null;
            MoveDirection direction = MoveDirection.Start;

            do
            {
                foreach (var step in Steps)
                {
                    int x = cell.Row + step.Item1, y = cell.Col + step.Item2;
                    if (!InRange(x, y) || !IsVisited(x, y)) continue;

                    if (_cells[x, y].Distance == 0)
                    {
                        prev = _cells[x, y];
                        path = path.AddStep(prev, step.Item4);

                        direction = MoveDirection.Start;
                        break;
                    }
                    if (prev != null)
                    {
                        if (_cells[x, y].Distance >= prev.Distance) continue;
                        prev = _cells[x, y];
                        direction = step.Item4;
                    }
                    else
                    {
                        prev = _cells[x, y];
                        direction = step.Item4;
                    }
                }
                path = path.AddStep(prev, direction);
                cell = prev;
            } while (cell != null && direction != MoveDirection.Start);

            return path;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    var c = IsVisited(i, j) ? _cells[i, j].Distance.ToString() : "x";
                    sb.Append($"{c,3}");
                }
                sb.Append(Environment.NewLine);
            }
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }
    }
}
