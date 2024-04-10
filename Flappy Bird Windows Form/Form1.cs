using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{

    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            picFlappyBird.Top += gravity; //this will push the bird down inside the timer
                                          //BUT it will push it back up when you press the space bar

            picPipeBottom.Left -= pipeSpeed; //these will pull the pipes from one end of the screen
            picPIpeTop.Left -= pipeSpeed; //to the to other 

            txtScore.Text = "Score:" + score;  //turns score integer to a string

            if (picPipeBottom.Left < -150)
            {
                picPipeBottom.Left = 800; //these if statements generate new pipes
                score ++; //gets score as integer
            }

            if(picPIpeTop.Left < -180)
            {
                picPIpeTop.Left = 950;
                score++;
            }

            if (picFlappyBird.Bounds.IntersectsWith(picPipeBottom.Bounds) || //if the bird touches the pipes,
                                                                             //then the bird will be intersecting with the pipes 
                picFlappyBird.Bounds.IntersectsWith(picPIpeTop.Bounds) ||
                picFlappyBird.Bounds.IntersectsWith(picGround.Bounds) || picFlappyBird.Top < -25) //the bounds are the boarders 
                {

               EndGame();

             }

            if (score > 5)
            {               
                pipeSpeed = 15; //the game speeds up if ur sco re is greater than 5
            }

        }

        private void gamekeysdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space) //if keyspace is pressed, the gravity will go down to 5
            {
                gravity = -5;
            }

        }

        private void gamekeysup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //if keyspace is released, the gravity will go up to 5
            {
                gravity = 5;
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            txtScore.Text += " Game Over"; //"game over" will find the end of the score text and add itself there

        }

    }
}
