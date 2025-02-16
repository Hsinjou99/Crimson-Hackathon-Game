using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Board Board = new Board();

            //for (int index = 0; index < 5; index++)
            {
                Card card = Board.Player.playable[0];
                if ( card != null)
                {
                    pictureBox1.BackColor = Color.Black;
                }
            }
            pictureBox1.BackColor = Color.Black;
            //game.RunGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
