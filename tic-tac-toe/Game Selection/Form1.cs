using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe;

namespace Game_Selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        tic_tac_toe.Form1 ttt = new tic_tac_toe.Form1();
        private void tictactoe_Click(object sender, EventArgs e)
        {
            
            if (ttt.Visible == true)
            {
                ttt.BringToFront();
            }
            else
            {
                ttt.Show();
            }
        }
    }
}
