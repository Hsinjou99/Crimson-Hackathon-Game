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
            RunGame();
        }

        public void RunGame()
        {
            DisplayPlayerHand();
            DisplayComputerHand();
            DisplayActiveCards();
            DisplayHP();


            bool End = false;
            string winner = "";


            //One side attacks
            AttackSequence(Game.turn);
            DisplayHP();

            //Player turn
            if (Game.turn == 1)
            {
                button1.Visible = true;
                button2.Enabled = true;
                Game.Player.draw_card();

            }

            //Computer turn
            else if (Game.turn == 2)
            {
                //Computer makes move
                Game.turn = 1;
                Game.Computer.draw_card();
                Game.Computer.play_card(0);
                RunGame();
            }

            //Check win condition
            //if either hp falls below 1, other wins
            if (Game.Player.hp < 1)
            {
                End = true;
                winner = "Opponent Wins ....";
            }
            if (Game.Computer.hp < 1)
            {
                End = true;
                winner = "Player Wins !!!!";
            }

            if (End)
            {
                DisplayWinner(winner);
                Close();
            }
        }

        private void DisplayWinner(string winner)
        {
            MessageBox.Show(winner);
            return;
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
            if (Game.Computer.playable.Count >= 1)
            {
                pictureBox16.BackColor = Color.Black;
            }
            if (Game.Computer.playable.Count >= 2)
            {
                pictureBox15.BackColor = Color.Black;
            }
            if (Game.Computer.playable.Count >= 3)
            {
                pictureBox14.BackColor = Color.Black;
            }
            if (Game.Computer.playable.Count >= 4)
            {
                pictureBox13.BackColor = Color.Black;
            }
            if (Game.Computer.playable.Count == 5)
            {
                pictureBox12.BackColor = Color.Black;
            }
        }

        public void DisplayActiveCards()
        {
            //Display active computer cards
            if (Game.Computer.played.Count >= 1)
            {
                pictureBox11.BackColor = Game.Computer.played[0].CardColor;
            }
            if (Game.Computer.played.Count >= 2)
            {
                pictureBox10.BackColor = Game.Computer.played[1].CardColor;
            }
            if (Game.Computer.played.Count == 3)
            {
                pictureBox9.BackColor = Game.Computer.played[2].CardColor;
            }

            //Display active player cards
            if (Game.Player.played.Count >= 1)
            {
                pictureBox6.BackColor = Game.Player.played[0].CardColor;
            }
            if (Game.Player.played.Count >= 2)
            {
                pictureBox7.BackColor = Game.Player.played[1].CardColor;
            }
            if (Game.Player.played.Count == 3)
            {
                pictureBox8.BackColor = Game.Player.played[2].CardColor;
            }
        }

        public void DisplayHP()
        {
            textBox1.Text = "Computer HP: " + Game.Computer.hp;
            textBox2.Text = "Player HP: " + Game.Player.hp;
        }

        public void AttackSequence(int turn)
        {
            List<Card> cards;
            if (turn == 1)
            {
                cards = Game.Player.played;
            }
            else if (turn == 2)
            {
                cards = Game.Computer.played;
            }
            else return;

            int total_dmg = 0;

            foreach (Card card in cards)
            {
                if (card.Name == "Attack") { 
                    total_dmg += card.CardValue;
                }
            }

            if (turn == 1)
            {
                if (!Game.Computer.protection)
                {
                    Game.Computer.hp -= total_dmg;
                }
                if (Game.Computer.hp < 0) { Game.Computer.hp = 0; }
            }
            else if (turn == 2)
            {
                if (!Game.Player.protection)
                {
                    Game.Player.hp -= total_dmg;
                }
                if (Game.Player.hp < 0) { Game.Player.hp = 0; }
            }
            else return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.turn = 2;
            button1.Visible = false;
            button2.Enabled = false;
            RunGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Game.Player.playable.Count >= 1)
            {
                textBox3.Text = Game.Player.playable[0].Name + " Card\r\n\r\n" + Game.Player.playable[0].Description + "\r\n\r\nUse this card?";
                textBox3.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button2.Tag = "0";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Game.Player.playable.Count >= 2)
            {
                textBox3.Text = Game.Player.playable[1].Name + " Card\r\n\r\n" + Game.Player.playable[1].Description + "\r\n\r\nUse this card?";
                textBox3.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button2.Tag = "1";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Game.Player.playable.Count >= 3)
            {
                textBox3.Text = Game.Player.playable[2].Name + " Card\r\n\r\n" + Game.Player.playable[2].Description + "\r\n\r\nUse this card?";
                textBox3.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button2.Tag = "2";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Game.Player.playable.Count >= 4)
            {
                textBox3.Text = Game.Player.playable[3].Name + " Card\r\n\r\n" + Game.Player.playable[3].Description + "\r\n\r\nUse this card?";
                textBox3.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button2.Tag = "3";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Game.Player.playable.Count >= 5)
            {
                textBox3.Text = Game.Player.playable[4].Name + " Card\r\n\r\n" + Game.Player.playable[4].Description + "\r\n\r\nUse this card?";
                textBox3.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button2.Tag = "4";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.Player.play_card(int.Parse(button2.Tag.ToString()));
            textBox3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            DisplayPlayerHand();
            DisplayActiveCards();
        }
    }
}
