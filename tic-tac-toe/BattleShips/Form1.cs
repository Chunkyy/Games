using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace BattleShips
{
    public partial class Form1 : Form
    {
        List<Button> playerPosition;
        List<Button> enemyPosition;
        Random rand = new Random();
        int totalShips = 3;
        int totalEnemy = 3;
        int rounds = 10;
        int playerTotalScore = 0;
        int enemyTotalScore = 0;

        public Form1()
        {
            InitializeComponent();
            loadbuttons();
            attackButton.Enabled = false;
            enemyLocationList = null;
        }

        private void playerPicksPosition(object sender, EventArgs e)
        {

        }

        private void attackEnemyPosition(object sender, EventArgs e)
        {

        }

        private void enemyAttackPlayer(object sender, EventArgs e)
        {

        }

        private void enemyPicksPositions(object sender, EventArgs e)
        {

        }

        private void loadbuttons()
        {
            playerPosition = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4 };
            enemyPosition = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            for (int i = 0; i < enemyPosition.Count; i++)
            {
                enemyPosition[i].Tag = null;
                enemyLocationList.Items.Add(enemyPosition[i].Text);
            }
        }
    }
}
