using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Chess_Game
{
    public partial class Board_Form : Form
    {
        private const int _WIDTH = 8;
        private const int _HEIGHT = 8;

        private bool selected = false;

        public Board_Form()
        {
            InitializeComponent();
        }
        

        private void Board_Form_Resize(object sender, EventArgs e)
        {
        }

        private void create_grid ()
        {
        }

        private void Board_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null) this.Owner.Show();
        }

        private void H8_Click(object sender, EventArgs e)
        {
            PictureBox item = (PictureBox)sender;
            string position = item.Name;
            int x = position[0] - 'A';
            int y = position[1] - '0' - 1;
            square p = Board.Grid[position[0] - 'A', position[1] - '0' - 1];

            if (selected) return;

            switch(p)
            {
                case square.Pawn_Black:
                    if (y - 1 > 0) Highlight(x, y - 1);
                    if (y - 2 > 0) Highlight(x, y - 2);

                    break;
                case square.Pawn_White:
                    if (y + 1 < _HEIGHT) Highlight(x, y + 1);
                    if (y + 2 < _HEIGHT) Highlight(x, y + 2);
                    break;
                case square.Tower_Black:


                    break;
            }
            
            
        }

        private void Highlight (int x, int y)
        {
            char[] val = new char[2];
            val[0] = (char)(x + 'A');
            val[1] = (char)(y + '0' + 1);
            string name = new string(val);
            
            foreach(Control item in Controls)
            {
                if(item is PictureBox)
                {
                    PictureBox box = (PictureBox)item;
                    if (box.Name == name)
                    {
                        box.BackgroundImage = null;
                        box.BackColor = Color.Yellow;
                                                
                    }
                    
                }
                
            }
            

        }


        private void Board_Form_Load(object sender, EventArgs e)
        {
            Board.Init_Board();

        }
    }
}
