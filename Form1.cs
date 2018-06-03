using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void New_Game_Button_Click(object sender, EventArgs e)
        {
            Board_Form form1 = new Board_Form();
            form1.Owner = this;
            form1.Activate();
            form1.Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
