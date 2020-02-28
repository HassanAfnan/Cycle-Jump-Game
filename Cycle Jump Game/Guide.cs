using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Cycle_Jump_Game
{
    public partial class Guide : Form
    {
        public Guide()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "***************************************************************** GUIDE ****************************************************************\n1- You have to keep away your player from pink ,blue, red and yellow pipes.\n2- You can touch the gray pipes.\n3- Press space bar to jump.\n4- Use arrow keys to move up, down, left and right.";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SpeakAsync("Welcome to Cycle jump game guidance area here we will guide you about our game so instruction number 1 is You have to keep away your player from pink blue red and yellow pipes instruction number 2 is You can touch the gray pipes instruction number 3 is Press space bar to jump and instruction number 4 is Use arrow keys to move up down left and right thank you for playing our game we hope you like our game");
        }
    }
}
