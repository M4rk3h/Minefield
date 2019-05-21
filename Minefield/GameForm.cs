using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minefield
{
    public partial class GameForm : Form
    {
        //Global variable for X
        int atX = 10;
        //Global variable for Y
        int atY = 20;
        //A Boolean array that indicated where tank can be.
        bool[,] bombs = new bool[21, 21];
        //Load the form called Form1
        public GameForm()
        {
            InitializeComponent();
            //Place the sprite at the start-up location
            //Which is declared above.
            drawsprite(atX, atY);
            //place the mines (bombs)
            placeBombs(50);
            //Check for bombs!
            chkbomb(atX, atY);
        }

        //Place the sprite at the start-up location
        //Which is declared above.
        public void drawsprite(int x, int y)
        {
            //Get the label number by looking at the position of the sprite
            Label lbl = getLabel(atX, atY);
            //Change the selected labels background to White 'Color.White;'
            lbl.BackColor = Color.White;
            //Change the label to the sprite image named 'sprite;'
            //I have several images which are rotated
            //for up, down, left, right.
            lbl.Image = Properties.Resources.tankUp;
            lbl.Image = Properties.Resources.tankDown;
            lbl.Image = Properties.Resources.tankLeft;
            lbl.Image = Properties.Resources.tankRight;
        }
        //Function to undraw the sprite at location. (x,y)
        public void wipesprite(int x, int y)
        {
            //Get the label which is set at x and at y
            Label lbl = getLabel(atX, atY);
            //Now change the image to be null
            lbl.Image = null;
        }
        //Place Boms around the form.
        public void placeBombs(int target)
        {
            //Use a random number generator
            Random rng = new Random();
            //Set up variables
            int x;
            int y;
            int k = target;
            //Clear the current mines list
            Array.Clear(bombs, 0, bombs.Length);
            //With the random number generator, get a number from 1 - 20.
            do
            {
                x = rng.Next(1, 20); //Generate number for X
                y = rng.Next(1, 20); //Generate number for Y
                if (!bombs[x, y])
                {
                    bombs[x, y] = true;  // Loop until bombs = placeBombs number
                    k--;
                }
                //Reteat this until k > 0
            } while (k > 0);
        }
        //Counts the bombs around the sprite.
        public void countBombs(int X, int Y)
        {
            int count = 0;
            int newx;
            int newy;
            //Check for bomb left of sprite
            newx = X - 1;
            if (newx > -1)
            {
                if (bombs[newx, Y])
                    count++;
            }
            //Check for bomb right of sprite
            newx = X + 1;
            if (newx < 21)
            {
                if (bombs[newx, Y])
                    count++;
            }
            //Check for bomb below sprite
            newy = Y - 1;
            if (newy > -1)
            {
                if (bombs[X, newy])
                    count++;
            }
            //Check for bomb above sprite
            newy = Y + 1;
            if (newy < 21)
            {
                if (bombs[X, newy])
                    count++;
            }
            //Put the number of bombs inside the textbox called bombChk.
            bombChk.Text = count.ToString();
        }

        //Check for bombs at current location.
        public void chkbomb(int X, int Y)
        {
            if (bombs[X, Y])
            {
                //Turn background Red.
                this.BackColor = Color.Red;

                //End of Game
                //Control buttons no longer work
                btnDown.Enabled = false;
                btnUp.Enabled = false;
                btnLeft.Enabled = false;
                btnRight.Enabled = false;

                //Disable the EZ Mode button.
                btnEZ.Enabled = false;
                //Show all the bombs.
                showBombs();

            }
            else
            {
                //Count bombs around current locations
                countBombs(X, Y);
            }
        }

        //Show the bombs.
        public void showBombs()
        {
            Label lbl;
            for (int y = 1; y < 21; y++)
            {
                for (int x = 1; x < 21; x++)
                {
                    lbl = getLabel(x, y);
                    if (bombs[x, y])
                    {
                        /*Changed the 'bombs' from a yellow
                        box to a picture of a bomb*/
                        lbl.Image = Properties.Resources.mine;
                    }
                    else
                    {
                        //Change the form to be Dark Olive Green.
                        lbl.BackColor = Color.DarkOliveGreen;
                    }
                    //Put text inside the textbox after hitting a bomb.
                    //This will display text in the text box after you hit a 'bomb'.
                    textBoxDisplay.Text = "Nice try, start again?";
                }
            }
        }

        /*Show bombs via EZ Mode Button, 
        but doesn't leave trail on first block, 
        after pressing EZ Mode.*/
        public void easyMode()
        {
            Label lbl;

            for (int y = 1; y < 21; y++)
            {
                for (int x = 1; x < 21; x++)
                {
                    lbl = getLabel(x, y);
                    if (bombs[x, y])
                    {
                        /*Changed the 'bombs' from a yellow
                        box to a picture of a bomb*/
                        lbl.Image = Properties.Resources.mine;
                    }
                    else
                    {
                        //Change the form to be Dark Olive Green.
                        lbl.BackColor = Color.DarkOliveGreen;

                    }
                    /*Put text inside the textbox 
                      after hitting 'EZ MODE' button*/
                    textBoxDisplay.Text = "Welcome to easy mode!";

                }
            }
        }
        //Load the object called Form1.
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        //Get the label.
        public Label getLabel(int x, int y)
        {
            //Do some maths and figure out the label number.
            int k = (y - 1) * 20 + x;
            //Convert the label to a string
            string s = "label" + k.ToString();

            foreach (Control c in panel1.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.Label))
                {
                    if (c.Name == s)
                    {
                        return (Label)c;
                    }
                }
            }
            return null;
        }

        //Use WASD Keys to move the sprite
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Press 'W' to move up.
            if (keyData == Keys.W)
            {
                //If allowed, update location
                if (atY > 1)
                {
                    //Delete sprite at current location
                    wipesprite(atX, atY);
                    //Move up one column
                    atY--;
                    //Draw sprite at current location
                    drawsprite(atX, atY);
                    //Check for bombs!
                    chkbomb(atX, atY);
                    /* Get the label number by 
                    looking at the position of the sprite*/
                    Label lbl = getLabel(atX, atY);
                    /*Change the selected labels background
                    to White 'Color.White;'*/
                    lbl.BackColor = Color.White;
                    /*Change the label to the sprite
                    image named 'sprite;'*/
                    lbl.Image = Properties.Resources.tankUp;
                }
            }

            //Press 'S' to move down.
            if (keyData == Keys.S)
            {
                //If allowed, update location
                if (atY < 20)
                {
                    //Delete sprite at current location
                    wipesprite(atX, atY);
                    //Move down one column
                    atY--;
                    //Draw sprite at current location
                    drawsprite(atX, atY);
                    //Check for bombs!
                    chkbomb(atX, atY);


                    /* Get the label number by 
                    looking at the position of the sprite*/
                    Label lbl = getLabel(atX, atY);
                    /*Change the selected labels background
                    to White 'Color.White;'*/
                    lbl.BackColor = Color.White;
                    /*Change the label to the sprite
                    image named 'sprite;'*/
                    lbl.Image = Properties.Resources.tankUp;
                }
            }

            //Press 'A' to move left.
            if (keyData == Keys.A)
            {
                //If allowed, update location
                if (atX > 1)
                {
                    //Delete sprite at current location
                    wipesprite(atX, atY);
                    //Move left one row
                    atY--;
                    //Draw sprite at current location
                    drawsprite(atX, atY);
                    //Check for bombs!
                    chkbomb(atX, atY);


                    /* Get the label number by 
                    looking at the position of the sprite*/
                    Label lbl = getLabel(atX, atY);
                    /*Change the selected labels background
                    to White 'Color.White;'*/
                    lbl.BackColor = Color.White;
                    /*Change the label to the sprite
                    image named 'sprite;'*/
                    lbl.Image = Properties.Resources.tankUp;
                }
            }

            //Press 'D' to move right.
            if (keyData == Keys.D)
            {
                //If allowed, update location
                if (atX < 20)
                {
                    //Delete sprite at current location
                    wipesprite(atX, atY);
                    //Move right one row
                    atY--;
                    //Draw sprite at current location
                    drawsprite(atX, atY);
                    //Check for bombs!
                    chkbomb(atX, atY);


                    /* Get the label number by 
                    looking at the position of the sprite*/
                    Label lbl = getLabel(atX, atY);
                    /*Change the selected labels background
                    to White 'Color.White;'*/
                    lbl.BackColor = Color.White;
                    /*Change the label to the sprite
                    image named 'sprite;'*/
                    lbl.Image = Properties.Resources.tankUp;
                }
            }
        }
        // These are for the buttoms on the form.
        //Easy Mode
        private void BtnEZ_Click(object sender, EventArgs e)
        {
            easyMode();
            showBombs();
        }

        //Restart
        private void BtnTry_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Back?");
            }
        }

        //Quit
        private void BtnGive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Back?");
            }
        }
    }
}
