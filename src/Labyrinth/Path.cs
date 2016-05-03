using System;
using System.Collections;
using System.Collections.Generic;

namespace Labyrinth
{
    public enum MoveDirection
    {
        Start,
        Left,
        Up,
        Down,
        Right,
        End
    }

    public interface IPath<out TSteps, out TNode, out TDirection> : IEnumerable<TNode>
        where TSteps : IEnumerable<TNode>
    {
        TDirection LastDirection { get; }

        TNode LastStep { get; }

        TSteps PreviousSteps { get; }
    }

    public class MovingPath<TNode> : IPath<MovingPath<TNode>, TNode, MoveDirection>
    {
        public MoveDirection LastDirection { get; }

        public TNode LastStep { get; }

        public MovingPath<TNode> PreviousSteps { get; private set; }

        protected MovingPath(TNode lastStep, MoveDirection direction, MovingPath<TNode> previousSteps)
        {
            LastStep = lastStep;
            LastDirection = direction;
            PreviousSteps = previousSteps;
        }

        public MovingPath(TNode start, MoveDirection direction) : this(start, direction, null) { }

        public MovingPath<TNode> AddStep(TNode step, MoveDirection direction)
        {
            return new MovingPath<TNode>(step, direction, this);
        }

        public IEnumerator<TNode> GetEnumerator()
        {
            for (MovingPath<TNode> p = this; p != null; p = p.PreviousSteps)
                yield return p.LastStep;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerable<Tuple<TNode, MoveDirection>> GetMovements()
        {
            for (MovingPath<TNode> p = this; p != null; p = p.PreviousSteps)
            {
                yield return Tuple.Create(p.LastStep, p.LastDirection);
            }
        }

        public IEnumerable<MoveDirection> GetDirections()
        {
            for (MovingPath<TNode> p = this; p != null; p = p.PreviousSteps)
            {
                if (p.LastDirection != MoveDirection.End)
                {
                    yield return p.LastDirection;
                }
            }
        }
    }
}