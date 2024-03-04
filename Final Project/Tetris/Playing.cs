using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Playing : Form
    {
        private static int INIT_FREQ = 1600;
        private static bool mapMode = false;
        private static bool playerMode = false;
        private static bool closed = false;
        private static int row = 20;
        private static int column = 10;
        private static int freq = INIT_FREQ;
        public static int score = 0;
        public static int time = 300;
        private static Panel panel;
        private static GameStatus status;
        private static PictureBox picNext1, picNext2, picNext3, picHold;
        private static Label scoreTxt, timeTxt;
        private static Block hold;
        public Playing(bool Mmode, bool Pmode)
        {
            mapMode = Mmode;
            playerMode = Pmode;
            InitializeComponent();
            scoreTxt = Score;timeTxt = Time;
            status = new GameStatus(row, column, mapMode);


            this.Load += GameLoad;
            this.KeyDown += keyDown;
            this.FormClosed += Clear_all;


            BackgroundImage = frmMain.bgImg;
            ScoreImg.Image = frmMain.scoreImg;
            TimeImg.Image = frmMain.timeImg;
            panel = panel1;
            picNext1 = next;
            picNext2 = next_1;
            picNext3 = next_2;
            picHold = holding;


            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    int picA = panel.Size.Width/column;
                    PictureBox pic = new PictureBox();
                    pic.Size = new Size(picA, picA);
                    pic.Location = new Point(j * picA, i * picA);
                    pic.BackColor = Color.FromArgb(104,118,153);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    panel.Controls.Add(pic);
                }
            }
        }
        public static void Refresh_ScoreTxt()
        {
            freq = INIT_FREQ / (int)Math.Pow(2,score/1000);
            scoreTxt.Text = score.ToString("D5");
        }
        public static void Refresh_TimeTxt()
        {
            timeTxt.Text = (time / 60).ToString("D2") + ":" + (time % 60).ToString("D2");
        }
        public async void GameLoad(object sender, EventArgs e)
        {
            closed = false;
            GameStart();
            Refresh_ScoreTxt();
            Refresh_TimeTxt();
            InitializeTimer();
            await GameLoop();
        }
        private static void GameStart()
        {
            time = 300;
            score = 0;
            freq = INIT_FREQ;
            hold = null;
        }
        private static void Draw()
        {
            if (status.GameOver)
            {
                MessageBox.Show("GAME OVER!");
                status = new GameStatus(row, column, mapMode);
                status.ShadowUpdate();
                GameStart();
                Refresh_ScoreTxt();
                Refresh_TimeTxt();
            }
            for(int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    //pictureboxes
                    ((PictureBox)panel.Controls[r*column + c]).Image = frmMain.tileImages[status.GameGrid[r, c]];
                }
            }
            foreach (Position p in status.Shadow.TilePositions())
            {
                PictureBox target = (PictureBox)panel.Controls[p.Row * column + p.Col];
                target.Image = frmMain.ShadowImg;
            }

            foreach(Position p in status.CurrentBlock.TilePositions())
            {
                PictureBox target = (PictureBox)panel.Controls[p.Row * column + p.Col];
                target.Image = frmMain.tileImages[status.CurrentBlock.ID];
            }
            picNext1.Image = frmMain.blockImages[status.Queue.Next_1.ID];
            picNext2.Image = frmMain.blockImages[status.Queue.Next_2.ID];
            picNext3.Image = frmMain.blockImages[status.Queue.Next_3.ID];
            if(hold!=null)
                picHold.Image = frmMain.blockImages[hold.ID];
            else
                picHold.Image=null;
        }

        public static void keyDown(object sender, KeyEventArgs e)
        {
            if (status.GameOver)
                return;
            switch (e.KeyCode)
            {
                case Keys.Z:
                    status.RotateBlockCounterClockWise();
                    status.ShadowUpdate();
                    break;
                case Keys.Up:
                    status.RotateBlockClockWise();
                    status.ShadowUpdate();
                    break;
                case Keys.Down:
                    status.MoveBlockDown();
                    break;
                case Keys.Left:
                    status.MoveBlockLeft();
                    status.ShadowUpdate();
                    break;
                case Keys.Right:
                    status.MoveBlockRight();
                    status.ShadowUpdate();
                    break;
                case Keys.Space:
                    status.MoveBlockStraightDown();
                    status.ShadowUpdate();
                    break;
                case Keys.ShiftKey:
                    if (hold == null)
                    {
                        hold = status.CurrentBlock;
                        status.CurrentBlock = status.Queue.Update();
                        status.CurrentBlock.Reset();
                        status.ShadowUpdate();
                    }
                    else
                    {
                        Block tmp = hold;
                        Position now = status.CurrentBlock.offset;
                        hold = status.CurrentBlock;
                        tmp.offset = now;
                        status.CurrentBlock = tmp;
                        status.ShadowUpdate();
                        Draw();
                    }
                    break;
                default:
                    break;
            }

            Draw();
        }

        private async Task GameLoop()
        {
            Draw();
            while (!status.GameOver && time>0)
            {
                await Task.Delay(freq);
                status.MoveBlockDown();
                if (closed)
                    break;
                Draw();
            }
            if(playerMode) return;

            if (!status.GameOver && time==0)
            {
                MessageBox.Show($"遊戲結束，\n得分:{score}");
                status = new GameStatus(row,column, mapMode);
                GameStart();
                Refresh_ScoreTxt();
                Refresh_TimeTxt();
            }
            else if(!status.GameOver && time > 0)
            {
                MessageBox.Show("視窗關閉，\n遊戲結束");
                status = new GameStatus(row, column, mapMode);
                GameStart();
                Refresh_ScoreTxt();
                Refresh_TimeTxt();
            }
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                Refresh_TimeTxt();
            }
            else
            {
                countdownTimer.Stop();
            }
        }

        private void Clear_all(object sender, FormClosedEventArgs e)
        {
            closed = true;
            countdownTimer.Stop();

            // Remove and dispose of controls
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
        }
    }
}
