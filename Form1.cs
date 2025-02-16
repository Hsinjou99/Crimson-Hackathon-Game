using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Game
{
    public partial class Form1 : Form
    {
        Board Game = new Board();
        public Form1()
        {
            InitializeComponent();
            //RunGame();
        }

        public void RunGame()
        {
            bool End = false;
            DisplayPlayerHand();
            DisplayComputerHand();
            DisplayActiveCards();

            while (!End)
            {

            }


            //Check win condition
            //if either hp falls below 1, other wins
        }

        private void DisplayPlayerHand()
        {
            //Display player hand
            if (Game.Player.playable.Count >= 1)
            {
                pictureBox1.BackColor = Game.Player.playable[0].Color;
            }
            if (Game.Player.playable.Count >= 2)
            {
                pictureBox2.BackColor = Game.Player.playable[1].Color;
            }
            if (Game.Player.playable.Count >= 3)
            {
                pictureBox3.BackColor = Game.Player.playable[2].Color;
            }
            if (Game.Player.playable.Count >= 4)
            {
                pictureBox4.BackColor = Game.Player.playable[3].Color;
            }
            if (Game.Player.playable.Count == 5)
            {
                pictureBox5.BackColor = Game.Player.playable[4].Color;
            }

            //

        }

        public void DisplayComputerHand()
        {
            
        }
        public void DisplayActiveCards()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
