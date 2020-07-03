using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void playerClick(object sender, EventArgs e)
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
            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x"
                || button4.Text == "x" && button5.Text == "x" && button6.Text == "x"
                || button7.Text == "x" && button8.Text == "x" && button9.Text == "x"
                || button1.Text == "x" && button5.Text == "x" && button9.Text == "x"
                || button1.Text == "x" && button4.Text == "x" && button7.Text == "x")
            {
                AImoves.Stop();
                MessageBox.Show("Player Wins");
                playerWins++;
                label1.Text = "Player Wins - " + playerWins;

                resetGame();
            }
            else if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o"
                || button4.Text == "o" && button5.Text == "o" && button6.Text == "o"
                || button7.Text == "o" && button8.Text == "o" && button9.Text == "o"
                || button1.Text == "o" && button5.Text == "o" && button9.Text == "o"
                || button1.Text == "o" && button4.Text == "o" && button7.Text == "o")
            {
                AImoves.Stop();
                MessageBox.Show("Computer Wins");
                cpuWins++;
                label2.Text = "CPU Wins - " + cpuWins;

                resetGame();
            }
                
        }

    }
}
