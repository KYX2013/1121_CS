using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StartOffset { get; }
        public abstract int ID { get; }

        private int rotate;
        public Position offset;
        public Block()
        {
            offset = new Position(StartOffset.Row, StartOffset.Col);
        }
        public IEnumerable<Position> TilePositions()
        {
            foreach(Position p in Tiles[rotate])
            {
                yield return new Position(p.Row+offset.Row,p.Col+offset.Col);
            }
        }
        public void RotateClockWise()
        {
            rotate += 1;
            if(rotate >= Tiles.Length) { rotate -= Tiles.Length; }
        }
        public void RotateCounterClockWise()
        {
            rotate -= 1;
            if(rotate < 0) { rotate += Tiles.Length; }
        }
        public void Move(int r,int c)
        {
            offset.Row += r;
            offset.Col += c;
        }
        public void Reset()
        {
            rotate = 0;
            offset.Row = StartOffset.Row;
            offset.Col = StartOffset.Col;
        }

        public Block Copy()
        {
            Block nu = new IBlock();
            switch (this.ID)
            {
                case 1:
                    nu = new IBlock();
                    break;
                case 2:
                    nu = new JBlock();
                    break;
                case 3:
                    nu = new LBlock();
                    break;
                case 4:
                    nu = new OBlock();
                    break;
                case 5:
                    nu = new SBlock();
                    break;
                case 6:
                    nu = new TBlock();
                    break;
                case 7:
                    nu = new ZBlock();
                    break;
            }
            nu.offset = this.offset.Copy();
            nu.rotate = this.rotate;

            return nu;
        }
    }

    public class IBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]{ new Position(1,0), new Position(1,1), new Position(1,2), new Position(1,3)},
            new Position[]{ new Position(0,2), new Position(1,2), new Position(2,2), new Position(3,2)},
            new Position[]{ new Position(2,0), new Position(2,1), new Position(2,2), new Position(2,3)},
            new Position[]{ new Position(0,1), new Position(1,1), new Position(2,1), new Position(3,1)}
        };
        public override int ID => 1;
        protected override Position StartOffset => new Position(-1, 3);
        protected override Position[][] Tiles => tiles;
    }

    public class JBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]{ new Position(0,0), new Position(1,0), new Position(1,1), new Position(1,2)},
            new Position[]{ new Position(0,1), new Position(0,2), new Position(1,1), new Position(2,1)},
            new Position[]{ new Position(1,0), new Position(1,1), new Position(1,2), new Position(2,2)},
            new Position[]{ new Position(0,1), new Position(1,1), new Position(2,0), new Position(2,1)}
        };
        public override int ID => 2;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }

    public class LBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]{ new Position(0,2), new Position(1,0), new Position(1,1), new Position(1,2)},
            new Position[]{ new Position(0,1), new Position(1,1), new Position(2,1), new Position(2,2)},
            new Position[]{ new Position(1,0), new Position(1,1), new Position(1,2), new Position(2,0)},
            new Position[]{ new Position(0,0), new Position(0,1), new Position(1,1), new Position(2,1)}
        };
        public override int ID => 3;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }

    public class OBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]{ new Position(0,0), new Position(0,1), new Position(1,0), new Position(1,1)}
        };
        public override int ID => 4;
        protected override Position StartOffset => new Position(0,4);
        protected override Position[][] Tiles => tiles;
    }

    public class SBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]{ new Position(0,1), new Position(0,2), new Position(1,0), new Position(1,1)},
            new Position[]{ new Position(0,1), new Position(1,1), new Position(1,2), new Position(2,2)},
            new Position[]{ new Position(1,1), new Position(1,2), new Position(2,0), new Position(2,1)},
            new Position[]{ new Position(0,0), new Position(1,0), new Position(1,1), new Position(2,1)}
        };
        public override int ID => 5;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }

    public class TBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]{ new Position(0,1), new Position(1,0), new Position(1,1), new Position(1,2)},
            new Position[]{ new Position(0,1), new Position(1,1), new Position(1,2), new Position(2,1)},
            new Position[]{ new Position(1,0), new Position(1,1), new Position(1,2), new Position(2,1)},
            new Position[]{ new Position(0,1), new Position(1,0), new Position(1,1), new Position(2,1)}
        };
        public override int ID => 6;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }

    public class ZBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]{ new Position(0,0), new Position(0,1), new Position(1,1), new Position(1,2)},
            new Position[]{ new Position(0,2), new Position(1,1), new Position(1,2), new Position(2,1)},
            new Position[]{ new Position(1,0), new Position(1,1), new Position(2,1), new Position(2,2)},
            new Position[]{ new Position(0,1), new Position(1,0), new Position(1,1), new Position(2,0)}
        };
        public override int ID => 7;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }
}
