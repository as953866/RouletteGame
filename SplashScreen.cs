using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteGame
{
    public partial class SplashScreen : Form
    {
        // main game page
        Timer tmr;
        string message = "Welcome to Russian Roulette";
        int index;
        System.Media.SoundPlayer player;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "";
            
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            // timer and sound added here linked from resources
            tmr = new Timer();
            tmr.Interval = 250;
            player = new System.Media.SoundPlayer();
            player.Stream = Resource.TypeWriter;
            player.PlayLooping();
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        private void tmr_Tick(object sender, EventArgs e)
        { 
            if(index < message.Length)
            {
                lblWelcome.Text += message[index] + "";
                index++;
            }
            else
            {
                tmr.Stop();
                MainGame mf = new MainGame();
                mf.Show();
                this.Hide();
                player.Stop();
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
