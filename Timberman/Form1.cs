using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Timberman
{
    public partial class Form1 : Form
    {
        static int money = 0;
        static int branchesAmount = 500;
        //int[] branches = new int[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
            //spawnBranches();

        }

        void GameOver()
        {
            MessageBox.Show("Score: " + score);
            if (score > highscore)
                highscore = score;
            highscoreLbl.Text = highscore.ToString();
            money = money + score;
            StartGame();
        }
        int highscore = 0;
        int score = 0;
        void UpdateGame()
        {
            scoreLbl.Text = score.ToString();
            foreach(var branch in branches)
            {
               
                if (branch!= null)
                {
                    branch.Location = new Point(branch.Location.X, branch.Location.Y + 100);
                    if (playerBox.Location.X == 284 && branch.Location.X == 256 && branch.Location.Y == 568)
                    {
                        GameOver();
                    }
                    if (playerBox.Location.X == 536 && branch.Location.X == 512 && branch.Location.Y == 568)
                    {
                        GameOver();
                    }
                    if(branch.Location.Y > 600)
                    {
                        Controls.Remove(branch);
                    }
                    //Controls.Add(branch);
                }//284; 570

            }
            moneyLbl.Text = money.ToString();
            score++;
        }

        void newUpdateGame()
        {
            scoreLbl.Text = score.ToString();
            foreach (var branch in newBranches)
            {

                if (branch != null)
                {
                    branch.Location = new Point(branch.Location.X, branch.Location.Y + 100);
                    if (playerBox.Location.X == 284 && branch.Location.X == 256 && branch.Location.Y == 568)
                    {
                        GameOver();
                    }
                    if (playerBox.Location.X == 536 && branch.Location.X == 512 && branch.Location.Y == 568)
                    {
                        GameOver();
                    }
                    if (branch.Location.Y > 600)
                    {
                        Random rng = new Random();
                        int rnd = rng.Next(0, 2);
                        if(rnd == 0)
                        {
                            branch.Location = new Point(256, 68);
                        }
                        else
                        {
                            branch.Location = new Point(512, 68);
                        }
                        
                    }
                    //Controls.Add(branch);
                }//284; 570

            }
            moneyLbl.Text = money.ToString();
            score++;
        }

        void StartGame()
        {
            scoreLbl.Text = score.ToString();
            foreach (var branch in newBranches)
            {
                Controls.Remove(branch);
            }
            Array.Clear(newBranches, 0, newBranches.Length);
            score = 0;
            //spawnBranches();
            newSpawn();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyCode == Keys.L)
            //{
            //    //Do here
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                //location = 0;
                playerBox.Location = new Point(284, 570);
                //spawnBranches();
                newUpdateGame();
                
                

            }
            if (e.KeyCode == Keys.D)
            {
                //location = 1;
                playerBox.Location = new Point(536,570);
                newUpdateGame();
            }

            //536; 570
        }
        PictureBox[] branches = new PictureBox[branchesAmount];
        PictureBox[] newBranches = new PictureBox[6];

        void newSpawn()
        {
            Random rng = new Random();
            for (int i = 0; i < 6; i++)
            {
                int rnd = rng.Next(0, 2);
                if (rnd == 0)
                {
                    var picture = new PictureBox
                    {//lewa
                        Name = ("pictureBox" + i),
                        Size = new Size(145, 40),
                        Location = new Point(256, 468 - (i * 100)),
                        BackColor = Color.FromArgb(128, 64, 0),
                    };
                    this.Controls.Add(picture);
                    newBranches[i] = picture;
                }
                else if (rnd == 1)
                {//prawa
                    var picture = new PictureBox
                    {
                        Name = ("pictureBox" + i),
                        Size = new Size(145, 40),
                        Location = new Point(512, 468 - (i * 100)),
                        BackColor = Color.FromArgb(128, 64, 0),
                    };
                    this.Controls.Add(picture);
                    newBranches[i] = picture;
                }
            }
        }
        void spawnBranches()
        {
            Random rng = new Random();
            for (int i = 0; i< branchesAmount; i++)
            {
                //PictureBox box = new PictureBox();
                
                //box.Size = new Size(144, 50);
                int rnd = rng.Next(0, 2);
                if (rnd == 0)
                {
                    var picture = new PictureBox
                    {//lewa
                        Name = ("pictureBox" + i),
                        Size = new Size(145, 40),
                        Location = new Point(256, 468 - (i * 100)),
                        BackColor = Color.FromArgb(128, 64, 0),
                        
                        //Image = Image.FromFile("hello.jpg"),

                    };
                    this.Controls.Add(picture);
                    branches[i] = picture;
                }
                else if (rnd == 1)
                {//prawa
                    var picture = new PictureBox
                    {
                        Name = ("pictureBox" + i),
                        Size = new Size(145, 40),
                        Location = new Point(512, 468 - (i * 100)),
                        BackColor = Color.FromArgb(128, 64, 0),
                        //Image = Image.FromFile("hello.jpg"),

                    };
                    this.Controls.Add(picture);
                    branches[i] = picture;
                    //box.Size = new Size(144, 50);

                }
            }
        }

        private void branchBox_Click(object sender, EventArgs e)
        {

        }
    }
}
