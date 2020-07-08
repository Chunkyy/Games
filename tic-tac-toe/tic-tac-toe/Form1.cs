using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;






namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            //Control the player and AI symbols
            x, o
        }

        Player currentplayer;
        List<Button> buttons;
        Random rand = new Random();
        int playerWins = 0;
        int cpuWins = 0;
        int draw = 0;

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void playerClick(object sender, EventArgs e)
        {
            if (AImoves.Enabled)
            {
                MessageBox.Show("It is not your turn");
            }
            else
            {
                var button = (Button)sender;
                currentplayer = Player.x;
                button.Text = currentplayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.Cyan;
                buttons.Remove(button);
                Check();
                AImoves.Start();
            }                      
        }

        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentplayer = Player.o;
                buttons[index].Text = currentplayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index);
                Check();
                AImoves.Stop();
            }
        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void loadbuttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, };
        }

        private void resetGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag == "play")
                {
                    ((Button)x).Enabled = true;
                    ((Button)x).Text = "?";
                    ((Button)x).BackColor = default(Color);
                }
            }

            loadbuttons();
        }

        private void Check()
        {
            if (button1.Text == currentplayer.ToString() && button2.Text == currentplayer.ToString() && button3.Text == currentplayer.ToString()
                || button4.Text == currentplayer.ToString() && button5.Text == currentplayer.ToString() && button6.Text == currentplayer.ToString()
                || button7.Text == currentplayer.ToString() && button8.Text == currentplayer.ToString() && button9.Text == currentplayer.ToString()
                || button1.Text == currentplayer.ToString() && button5.Text == currentplayer.ToString() && button9.Text == currentplayer.ToString()
                || button1.Text == currentplayer.ToString() && button4.Text == currentplayer.ToString() && button7.Text == currentplayer.ToString()
                || button2.Text == currentplayer.ToString() && button5.Text == currentplayer.ToString() && button8.Text == currentplayer.ToString()
                || button3.Text == currentplayer.ToString() && button5.Text == currentplayer.ToString() && button7.Text == currentplayer.ToString()
                || button3.Text == currentplayer.ToString() && button6.Text == currentplayer.ToString() && button9.Text == currentplayer.ToString())
            {
                AImoves.Stop();

                if (currentplayer.ToString() == "x")
                {
                    MessageBox.Show("Player Wins");
                    playerWins++;
                    label1.Text = "Player Wins - " + playerWins;
                }
                else if (currentplayer.ToString() == "o")
                {
                    MessageBox.Show("Computer Wins");
                    cpuWins++;
                    label2.Text = "CPU Wins - " + cpuWins;
                }
                resetGame();                
            }
            else if (buttons.Count == 0)
            {
                AImoves.Stop();
                MessageBox.Show("Draw");
                draw++;
                label3.Text = "Draw - " + draw;

                resetGame();
            }

        }

        private void closeTicTacToe_Click(object sender, EventArgs e)
        {
            Close();
        }
    }                
}
