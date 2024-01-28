using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tetris
{
    public class GameGrid
    {
        private readonly int[,] grid;
        public int rows { get; }
        public int cols { get; }
        public int this[int r,int c]
        {
            get => grid[r,c];
            set => grid[r,c] = value;
        }

        public GameGrid(int r, int c, bool map)
        {
            rows = r; cols = c;
            grid = new int[r,c];


            if (map)
            {
                switch (frmMain.mapID) {
                    case 0:
                        //Generate Random Map
                        Random rd = new Random();
                        for (int i = r - 1; i > r / 2; i--)
                        {
                            for (int j = 0; j < c; j++)
                            {
                                this[i, j] = rd.Next(8);
                            }
                        }
                        ClearFullRows();
                        break;
                    case 1:
                        for (int i = 0; i < r; i++)
                        {
                            for (int j = 0; j < c; j++)
                            {
                                this[i, j] = Map.smiley[i, j];
                            }
                        }
                        ClearFullRows();
                        break;
                    case 2:
                        for (int i = 0; i < r; i++)
                        {
                            for (int j = 0; j < c; j++)
                            {
                                this[i, j] = Map.digging[i, j];
                            }
                        }
                        ClearFullRows();
                        break;
                    case 3:
                        for (int i = 0; i < r; i++)
                        {
                            for (int j = 0; j < c; j++)
                            {
                                this[i, j] = Map.combo_king[i, j];
                            }
                        }
                        ClearFullRows();
                        break;
                    case 4:
                        for (int i = 0; i < r; i++)
                        {
                            for (int j = 0; j < c; j++)
                            {
                                this[i, j] = Map.tortoise[i, j];
                            }
                        }
                        ClearFullRows();
                        break;
                    case 5:
                        for (int i = 0; i < r; i++)
                        {
                            for (int j = 0; j < c; j++)
                            {
                                this[i, j] = Map.monster[i, j];
                            }
                        }
                        ClearFullRows();
                        break;
                    default:
                        break;
                }
            }
        }

        public bool IsInside(int r,int c)
        {
            return ((r>=0) && (r<rows) && (c>=0) && (c<cols));
        }
        public bool IsEmpty(int r, int c)
        {
            return IsInside(r,c)&&grid[r,c]==0;
        }

        public bool IsRowEmpty(int r)
        {
            for(int c = 0; c < cols; c++)
            {
                if (grid[r,c] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsRowFull(int r)
        {
            for(int c = 0; c < cols; c++)
            {
                if (grid[r,c]==0)
                    return false;
            }
            return true;
        }

        private void ClearRow(int r)
        {
            for(int c=0; c<cols; c++)
            {
                grid[r,c] = 0;
            }
            Playing.score += 100;
            Playing.Refresh_ScoreTxt();
        }

        private void MoveRowDown(int r, int num)
        {
            for(int c = 0; c < cols;c++)
            {
                grid[r+num,c] = grid[r,c];
                grid[r,c] = 0;
            }
        }

        public int ClearFullRows()
        {
            int cleared = 0;
            for (int r=rows-1; r>=0; r--)
            {
                if (IsRowFull(r))
                {
                    ClearRow(r);
                    cleared++;
                }
                else if (cleared > 0)
                {
                    MoveRowDown(r, cleared);
                }
            }

            return cleared;
        }
    }
}
