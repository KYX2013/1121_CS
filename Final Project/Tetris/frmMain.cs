using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tetris
{
    public partial class frmMain : Form
    {
        public static string ThemePath = Directory.GetCurrentDirectory()+"\\theme";
        public static Image[] tileImages = new Image[8];
        public static Image[] blockImages = new Image[8];
        public static Image bgImg;
        public static Image scoreImg;
        public static Image timeImg;
        public static int themeID = 1;
        public static int mapID = 1;
        private static bool WithMap = false;
        private static frmMain tmp;
        private static List<Control> ctrls = new List<Control>();
        public frmMain()
        {
            InitializeComponent();
            loadTheme();
            tmp = this;
            foreach (Control c in this.Controls)
            {
                ctrls.Add(c);
            }
        }
        private static void loadTheme()
        {
            for (int id = 0; id <= 7; id++)
            {
                tileImages[id] = Image.FromFile(ThemePath + $"\\theme_{themeID}\\Tile_{id}.png");
                if(id>0)
                    blockImages[id] = Image.FromFile(ThemePath + $"\\theme_{themeID}\\Block_{id}.png");
            }
            bgImg = Image.FromFile(ThemePath + $"\\theme_{themeID}\\Background.png");
            scoreImg = Image.FromFile(ThemePath + $"\\theme_{themeID}\\Score.png");
            timeImg = Image.FromFile(ThemePath + $"\\theme_{themeID}\\Time.png");
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Playing playing = new Playing(WithMap);
            playing.ShowDialog();
            WithMap = false;
        }

        private void Map_Click(object sender, EventArgs e)
        {
            WithMap = true;
            Map_Menu menu = new Map_Menu();
            menu.ShowDialog();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            Theme_menu menu = new Theme_menu();
            menu.ShowDialog();
            loadTheme();
        }
    }
}
