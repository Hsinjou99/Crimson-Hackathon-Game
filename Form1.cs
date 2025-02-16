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
            DisplayPlayerHand();
            DisplayComputerHand();
            DisplayActiveCards();
            //RunGame();
        }

        public void RunGame()
        {
            bool End = false;
            DisplayPlayerHand();
            DisplayComputerHand();
            DisplayActiveCards();
            DisplayHP();

            //while (!End)
            {
                //One side attacks
                AttackSequence(Game.turn);

                //Player turn
                if (Game.turn == 1)
                {
                    button1.Visible = true;
                    
                }

                //Computer turn
                else if (Game.turn == 2)
                {
                    //Computer makes move
                    Game.turn = 1;
                }
            }


            //Check win condition
            //if either hp falls below 1, other wins
        }

        private void DisplayPlayerHand()
        {
            //Display player hand
            if (Game.Player.playable.Count >= 1)
            {
                pictureBox1.BackColor = Game.Player.playable[0].CardColor;
            }
            if (Game.Player.playable.Count >= 2)
            {
                pictureBox2.BackColor = Game.Player.playable[1].CardColor;
            }
            if (Game.Player.playable.Count >= 3)
            {
                pictureBox3.BackColor = Game.Player.playable[2].CardColor;
            }
            if (Game.Player.playable.Count >= 4)
            {
                pictureBox4.BackColor = Game.Player.playable[3].CardColor;
            }
            if (Game.Player.playable.Count == 5)
            {
                pictureBox5.BackColor = Game.Player.playable[4].CardColor;
            }
        }

        public void DisplayComputerHand()
        {
            //Display computer hand
            if (Game.computer.playable.Count >= 1)
            {
                pictureBox16.BackColor = Color.Black;
            }
            if (Game.computer.playable.Count >= 2)
            {
                pictureBox15.BackColor = Color.Black;
            }
            if (Game.computer.playable.Count >= 3)
            {
                pictureBox14.BackColor = Color.Black;
            }
            if (Game.computer.playable.Count >= 4)
            {
                pictureBox13.BackColor = Color.Black;
            }
            if (Game.computer.playable.Count == 5)
            {
                pictureBox12.BackColor = Color.Black;
            }
        }

        public void DisplayActiveCards()
        {
            
        }

        public void DisplayHP()
        {
            //textBox1.Text = "Computer HP: " + Game.computer.Hp;
            //textBox2.Text = "Player HP: " + Game.Player.Hp;
        }
        public void AttackSequence(int turn)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.turn = 2;
            button1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Game.turn == 1 && Game.Player.playable.Count >= 1)
            {
                textBox3.Text = Game.Player.playable[0].Name + " Card\r\n\r\n" + Game.Player.playable[0].Description + "\r\n\r\nUse this card?";
                textBox3.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
