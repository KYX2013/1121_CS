using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class GameStatus
    {
        private Block _current;
        public Block CurrentBlock
        {
            get => _current;
            set
            {
                _current = value;
            }
        }
        public Block Shadow;

        public GameGrid GameGrid { get; }
        public Queue Queue { get; }
        public bool GameOver {  get; private set; }

        public GameStatus(int r, int c, bool map)
        {
            GameGrid = new GameGrid(r,c,map);
            Queue = new Queue();
            CurrentBlock = Queue.Update();
            _current.Reset();
            Shadow = CurrentBlock.Copy();
            ShadowUpdate();
        }

        private bool BlockFits()
        {
            foreach(Position p in CurrentBlock.TilePositions())
            {
                if(!GameGrid.IsEmpty(p.Row,p.Col))
                {
                    return false;
                }
            }
            return true;
        }

        public void RotateBlockClockWise()
        {
            CurrentBlock.RotateClockWise();
            if(!BlockFits())
            {
                CurrentBlock.RotateCounterClockWise();
            }
        }
        public void RotateBlockCounterClockWise()
        {
            CurrentBlock.RotateCounterClockWise();
            if (!BlockFits())
            {
                CurrentBlock.RotateClockWise();
            }
        }
        public void MoveBlockLeft()
        {
            CurrentBlock.Move(0, -1);
            if (!BlockFits())
            {
                CurrentBlock.Move(0, 1);
            }
        }
        public void MoveBlockRight()
        {
            CurrentBlock.Move(0, 1);
            if (!BlockFits())
            {
                CurrentBlock.Move(0, -1);
            }
        }

        private bool IsGameOver()
        {
            return !(GameGrid.IsRowEmpty(0) && GameGrid.IsRowEmpty(1));
        }

        private void PlaceBlock()
        {
            foreach(Position p in CurrentBlock.TilePositions())
            {
                GameGrid[p.Row, p.Col] = CurrentBlock.ID;
            }
            GameGrid.ClearFullRows();
            if(IsGameOver())
            {
                GameOver = true;
            }
            else
            {
                CurrentBlock = Queue.Update();
                _current.Reset();
            }
            ShadowUpdate();
        }

        public void MoveBlockDown()
        {
            CurrentBlock.Move(1, 0);
            if (!BlockFits())
            {
                CurrentBlock.Move(-1, 0);
                PlaceBlock();
            }
        }

        public void MoveBlockStraightDown() 
        {
            while (BlockFits())
            {
                CurrentBlock.Move(1, 0);
            }
            CurrentBlock.Move(-1, 0);
            PlaceBlock();
        }

        //ShadowFunc
        private bool ShadowFits()
        {
            foreach (Position p in Shadow.TilePositions())
            {
                if (!GameGrid.IsEmpty(p.Row, p.Col))
                {
                    return false;
                }
            }
            return true;
        }
        public void ShadowUpdate()
        {
            Shadow = CurrentBlock.Copy();
            while (ShadowFits())
            {
                Shadow.Move(1, 0);
            }
            Shadow.Move(-1, 0);
        }
    }
}
