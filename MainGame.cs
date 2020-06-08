using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteGame
{
    public partial class MainGame : Form
    {
        //called revovler class here
        Revolver computerRevolver, userRevolver;
        // addeed sound here
        System.Media.SoundPlayer player;
        int remainingGame;
        bool userTurn;
        int computerIndex, userIndex, computerWin, userWin;

        public MainGame()
        {
            // mumber of games to be played in game specified here
            InitializeComponent();
            remainingGame = 5;
            UpdateLabelText();
            ChangeUserButtonStatus(false);

        }

        private void UpdateLabelText()
        {
            //labels
            lblRemainingGame.Text = remainingGame.ToString();
            lblComputerWin.Text = computerWin.ToString();
            lblUserWin.Text = userWin.ToString();            
        }


        private void MainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            // for exit button 
            ProcessTheResult();
            Dispose();
            Application.Exit();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            if (remainingGame > 0)
            {
                //game played will be minus and show u remaining game
                remainingGame--;
                userIndex = computerIndex = 0;
                lblUserMessage.Text = lblComputerMessage.Text = "";
                UpdateLabelText();
                computerRevolver = new Revolver();
                userRevolver = new Revolver();
                btnLoad.Enabled = true;
                // turn of user and computer
                lblTurn.Text = "User Turn";
                ChangePicture(ImageResource.UserRevolver);
                if (remainingGame != 0)
                {
                    btnGame.Enabled = false;
                }
            }
            else
            {
                ProcessTheResult();
                Dispose();
            }
        }

        private void ProcessTheResult()
        {
            string result = "";
            // result proceess how things work
            if( computerWin == userWin)
            {
                result = " Both Computer and User are Luckier";
            }
            else if( computerWin > userWin )
            {
                result = "Computer is more luckier than User. So Computer Wins!!!";
            }
            else
            {
                result = "User is more luckier than User. So User Wins!!!";
            }
            //message box will show you result
            MessageBox.Show(result);            
        }

        private void ChangeUserButtonStatus(bool status)
        {
            // button satuts will be changed once your turn is done 
            btnLoad.Enabled = btnSpin.Enabled = btnFire.Enabled = false;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            //load button oroperties
            btnLoad.Enabled = false;
            lblUserMessage.Text = "Loading...";
            await Task.Delay(1000);
            userRevolver.LoadTheBullet();
            lblUserMessage.Text = "Bullet is Loaded";
            btnSpin.Enabled = true;
        }

        private void MainGame_Load(object sender, EventArgs e)
        {

        }

        private async void btnSpin_Click(object sender, EventArgs e)
        {
            // spin button properties
            btnSpin.Enabled = false;
            lblUserMessage.Text = "Spinning...";
            await Task.Delay(1000);
            userRevolver.SpinChambers();
            lblUserMessage.Text = "Revolver is Ready...";
            btnFire.Enabled = true;
        }

        private async void btnFire_Click(object sender, EventArgs e)
        {
            // fire button properties
            //sound is added here
            player = new System.Media.SoundPlayer();
            if (userRevolver.Fire(userIndex))
            {
                player.Stream = Resource.GunShot;
                // sound will be played over here
                player.Play();
                await Task.Delay(1000);
                lblUserMessage.Text = "User Win!!!";
                userWin++;
                lblComputerMessage.Text = "Computer is Dead.";
                ChangeUserButtonStatus(false);
                btnGame.Enabled = true;
                if (remainingGame != 0)
                {
                    btnGame.Text = "Start Next Game";
                }
                else
                {
                    btnGame.Text = "End Game";
                }
                UpdateLabelText();
                return;
            }
            else
            {
                player.Stream = Resource.Empty;
                player.Play();
                await Task.Delay(1000);
                lblUserMessage.Text = "Better Luck Next Time..";
                lblComputerMessage.Text = "Computer Survived.";
            }
            userIndex++;
            ComputerTurn();
            btnFire.Enabled = false;
            UpdateLabelText();
        }

        private void ChangePicture(Bitmap image)
        {
            // guns picture will be changed when your turn is done
            pictureTurns.Image = image;
        }

        private async void ComputerTurn()
        {
            // computer turn propeerties, how computer will perform
            lblTurn.Text = "Computer Turn";
            ChangePicture(ImageResource.ComputerRevolver);
            if(computerIndex == 0 )
            {
                lblComputerMessage.Text = "Loading...";
                await Task.Delay(1000);
                computerRevolver.LoadTheBullet();
                lblComputerMessage.Text = "Bullet is Loaded";
                await Task.Delay(1000);
                lblComputerMessage.Text = "Spinning...";
                await Task.Delay(1000);
                computerRevolver.SpinChambers();
                lblComputerMessage.Text = "Revolver is Ready...";                
            }
            await Task.Delay(1000);
            lblComputerMessage.Text = "Computer Press The Trigger";
            player = new System.Media.SoundPlayer();
            await Task.Delay(500);
            if (computerRevolver.Fire(computerIndex))
            {
                player.Stream = Resource.GunShot;
                player.Play();
                await Task.Delay(1000);
                lblComputerMessage.Text = "Computer Win!!!";
                computerWin++;
                lblUserMessage.Text = "User is Dead.";
                ChangeUserButtonStatus(false);
                if (remainingGame != 0)
                {
                    btnGame.Text = "Start Next Game";
                }
                else
                {
                    btnGame.Text = "End Game";
                }
                btnGame.Enabled = true;
                UpdateLabelText();
                lblTurn.Text = "";
                ChangePicture(ImageResource.TwoRevolver);
                lblTurn.Text = "";
                ChangePicture(ImageResource.TwoRevolver);
                return;
            }
            else
            {
                player.Stream = Resource.Empty;
                player.Play();
                await Task.Delay(1000);
                lblComputerMessage.Text = "Better Luck Next Time..";
                lblUserMessage.Text = "User Survived.";
            }
            computerIndex++;
            lblTurn.Text = "User Turn";
            ChangePicture(ImageResource.UserRevolver);
            btnFire.Enabled = true;
            UpdateLabelText();
            if(computerIndex == 2 )
            {
                ChangeUserButtonStatus(false);
                if (remainingGame != 0)
                {
                    btnGame.Text = "Start Next Game";
                }
                else
                {
                    btnGame.Text = "End Game";
                }
                btnGame.Enabled = true;
                MessageBox.Show("Both Computer and User are out of Shots. Try With Next Game");
                lblTurn.Text = "";
                ChangePicture(ImageResource.TwoRevolver);
            }
        }
    }
}
