using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void twoClubsPictureBox_Click(object sender, EventArgs e)
        {
            cardLabel.Visible = true;
            cardLabel.Text = "Two of Clubs";
        }

        private void eightDiamondsPictureBox_Click(object sender, EventArgs e)
        {
            cardLabel.Visible = true;
            cardLabel.Text = "Eight of Diamonds";
        }

        private void aceSpadesPictureBox_Click(object sender, EventArgs e)
        {
            cardLabel.Visible = true;
            cardLabel.Text = "Ace of Spades";
        }

        private void jokerPictureBox_Click(object sender, EventArgs e)
        {
            cardLabel.Visible = true;
            cardLabel.Text = "THE JOKER";
        }

        private void kingSpadesPictureBox_Click(object sender, EventArgs e)
        {
            cardLabel.Visible = true;
            cardLabel.Text = "King of Spades";
        }
    }
}
