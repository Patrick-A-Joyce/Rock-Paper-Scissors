using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace ROCK_PAPER_SCISSORS_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(2000);

            InitializeComponent();

            t.Abort();

        }

        private void playwin()
        {
            String tune = @"c:\Users\Patrick\Desktop\tadawin.wav";
            var sound = new System.Media.SoundPlayer(tune);
            sound.Play();
        }

        private void playloss()
        {
            String tune = @"c:\Users\Patrick\Desktop\FFB.wav";
            var sound = new System.Media.SoundPlayer(tune);
            sound.Play();
        }

        public void SplashScreen()
        {
            Application.Run(new Form2());
        }

        int l = 0;
        int w = 0;
        int d = 0;

        int cl = 0;
        int cw = 0;
        int cd = 0;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            ComPicRock.Visible = false;
            ComPicPaper.Visible = false;
            ComPicScissors.Visible = false;
            PlayPicRock.Visible = false;
            PlayPicPaper.Visible = false;
            PlayPicScissors.Visible = false;

            Random comchoice = new Random();
            int x = comchoice.Next(0, 3);

          
            
        }


        private void button1_Click(object sender, EventArgs e)
        
        {
            ComPicRock.Visible = false;
            ComPicPaper.Visible = false;
            ComPicScissors.Visible = false;
            PlayPicRock.Visible = true;
            PlayPicPaper.Visible = false;
            PlayPicScissors.Visible = false;

            Random comchoice = new Random();
            int x = comchoice.Next(0, 3);
          
        
            if (x == 0)
            {
                ComPicRock.Visible = true;
                lblDisplayMessage.Text = "This Round you Drew";

                cd = cd + 1;
                d = d + 1;

                lblComDisDraws.Text = Convert.ToString(cd);
                lblPlaDisDraws.Text = Convert.ToString(d);
            }


            

            if (x == 1)
            {
                ComPicPaper.Visible = true;
                lblDisplayMessage.Text = "This Round you Lost";
                cw = cw + 1;
                l = l + 1;

                lblComDisWins.Text = Convert.ToString(cw);
                lblPlaDisLosses.Text = Convert.ToString(l);
            }
            

            if (x == 2)
            {
                ComPicScissors.Visible = true;
                lblDisplayMessage.Text = "This Round you Win";
                cl = cl + 1;
                w = w + 1;

                lblPlaDisWins.Text = Convert.ToString(w);
                lblComDisLosses.Text = Convert.ToString(cl);
            }
            
            if (w >= 3)
            {
                playwin();
                DialogResult result = MessageBox.Show("You Won the Game, Play again ? ", "Congratulations", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    lblPlaDisWins.Text = Convert.ToString(" ");
                    lblComDisLosses.Text = Convert.ToString(" ");
                    lblComDisDraws.Text = Convert.ToString(" ");
                    lblPlaDisDraws.Text = Convert.ToString(" ");
                    lblComDisWins.Text = Convert.ToString(" ");
                    lblPlaDisLosses.Text = Convert.ToString(" ");
                    if (w >= 3 || cw >= 3)
                    {
                        w = w * 0;
                        l = l * 0;
                        d = d * 0;

                        cl = cl * 0;
                        cw = cw * 0;
                        cd = cd * 0;
                    }





                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Come back soon", "THANKS FOR PLAYING");
                    this.Close();
                }

            }
            if (cw >= 3)
            {
                playloss();
                DialogResult result = MessageBox.Show("Sorry You Lost, Play again ? ", "Commiserations", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    lblPlaDisWins.Text = Convert.ToString(" ");
                    lblComDisLosses.Text = Convert.ToString(" ");
                    lblComDisDraws.Text = Convert.ToString(" ");
                    lblPlaDisDraws.Text = Convert.ToString(" ");
                    lblComDisWins.Text = Convert.ToString(" ");
                    lblPlaDisLosses.Text = Convert.ToString(" ");
                    if (w >= 3 || cw >= 3)
                    {
                        w = w * 0;
                        l = l * 0;
                        d = d * 0;

                        cl = cl * 0;
                        cw = cw * 0;
                        cd = cd * 0;

                    }





                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Better Luck Next Time", "THANKS FOR PLAYING");
                    this.Close();
                }

            }
            


        }





        private void btnPaper_Click(object sender, EventArgs e)

        {
            ComPicRock.Visible = false;
            ComPicPaper.Visible = false;
            ComPicScissors.Visible = false;
            PlayPicRock.Visible = false;
            PlayPicPaper.Visible = true;
            PlayPicScissors.Visible = false;

            Random comchoice = new Random();
            int x = comchoice.Next(0, 3);
        
            if (x == 0)
            {
                ComPicRock.Visible = true;
                lblDisplayMessage.Text = "This Round you Win";

                cl = cl + 1;
                w = w + 1;

                lblPlaDisWins.Text = Convert.ToString(w);
                lblComDisLosses.Text = Convert.ToString(cl);
            }
            

            if (x == 1)
            {
                ComPicPaper.Visible = true;
                lblDisplayMessage.Text = "This Round you Drew";
                
                d = d + 1;
                cd= cd + 1;

                lblComDisDraws.Text = Convert.ToString(cd);
                lblPlaDisDraws.Text = Convert.ToString(d);
            }
            

            if (x == 2)
            {
                ComPicScissors.Visible = true;
                lblDisplayMessage.Text = "This Round you Lost";
                
                l = l + 1;
                cw = cw + 1;

                lblComDisWins.Text = Convert.ToString(cw);
                lblPlaDisLosses.Text = Convert.ToString(l);
            }
            
            if (w >= 3)
            {
                playwin();
                DialogResult result = MessageBox.Show("You Won the Game, Play again ? ", "Congratulations", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    lblPlaDisWins.Text = Convert.ToString(" ");
                    lblComDisLosses.Text = Convert.ToString(" ");
                    lblComDisDraws.Text = Convert.ToString(" ");
                    lblPlaDisDraws.Text = Convert.ToString(" ");
                    lblComDisWins.Text = Convert.ToString(" ");
                    lblPlaDisLosses.Text = Convert.ToString(" ");
                    if (w >= 3 || cw >= 3)
                    {
                        w = w * 0;
                        l = l * 0;
                        d = d * 0;

                        cl = cl * 0;
                        cw = cw * 0;
                        cd = cd * 0;
                    }





                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Come back soon", "THANKS FOR PLAYING");
                    this.Close();
                }

            }
            if (cw >= 3)
            {
                playloss();
                DialogResult result = MessageBox.Show("Sorry You Lost, Play again ? ", "Commiserations", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    lblPlaDisWins.Text = Convert.ToString(" ");
                    lblComDisLosses.Text = Convert.ToString(" ");
                    lblComDisDraws.Text = Convert.ToString(" ");
                    lblPlaDisDraws.Text = Convert.ToString(" ");
                    lblComDisWins.Text = Convert.ToString(" ");
                    lblPlaDisLosses.Text = Convert.ToString(" ");
                    if (w >= 3 || cw >= 3)
                    {
                        w = w * 0;
                        l = l * 0;
                        d = d * 0;

                        cl = cl * 0;
                        cw = cw * 0;
                        cd = cd * 0;

                    }





                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Better Luck Next Time", "THANKS FOR PLAYING");
                    this.Close();
                }

            }
            
        }




        private void btnScissors_Click(object sender, EventArgs e)

        {
            ComPicRock.Visible = false;
            ComPicPaper.Visible = false;
            ComPicScissors.Visible = false;
            PlayPicRock.Visible = false;
            PlayPicPaper.Visible = false;
            PlayPicScissors.Visible = true;

            Random comchoice = new Random();
            int x = comchoice.Next(0, 3);
          
            if (x == 0)
            {
                ComPicRock.Visible = true;
                lblDisplayMessage.Text = "This Round you Lost";
                
                cw = cw + 1;
                l = l + 1;

                lblComDisWins.Text = Convert.ToString(cw);
                lblPlaDisLosses.Text = Convert.ToString(l);
            }
            
           
            if (x == 1)
            {
                ComPicPaper.Visible = true;
                lblDisplayMessage.Text = "This Round you Win";
                
                w = w + 1;
                cl = cl + 1;

                lblPlaDisWins.Text = Convert.ToString(w);
                lblComDisLosses.Text = Convert.ToString(cl);
            }
            

            if (x == 2)
            {
                ComPicScissors.Visible = true;
                lblDisplayMessage.Text = "This Round you Drew";
                
                cd = cd + 1;
                d = d + 1;

                lblComDisDraws.Text = Convert.ToString(cd);
                lblPlaDisDraws.Text = Convert.ToString(d);
                
           }
            if (w >= 3)
            {
                playwin();
                DialogResult result = MessageBox.Show("You Won the Game, Play again ? ", "Congratulations", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    lblPlaDisWins.Text = Convert.ToString(" ");
                    lblComDisLosses.Text = Convert.ToString(" ");
                    lblComDisDraws.Text = Convert.ToString(" ");
                    lblPlaDisDraws.Text = Convert.ToString(" ");
                    lblComDisWins.Text = Convert.ToString(" ");
                    lblPlaDisLosses.Text = Convert.ToString(" ");
                    if (w >= 3 || cw >= 3)
                    {
                        w = w * 0;
                        l = l * 0;
                        d = d * 0;

                        cl = cl * 0;
                        cw = cw * 0;
                        cd = cd * 0;
                        
                    }
		
			                   
                                        
                   
                    
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Come back soon","THANKS FOR PLAYING");
                    this.Close();
                }
                
            }
            if (cw >= 3)
            {
                playloss();
                DialogResult result = MessageBox.Show("Sorry You Lost, Play again ? ", "Commiserations", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    lblPlaDisWins.Text = Convert.ToString(" ");
                    lblComDisLosses.Text = Convert.ToString(" ");
                    lblComDisDraws.Text = Convert.ToString(" ");
                    lblPlaDisDraws.Text = Convert.ToString(" ");
                    lblComDisWins.Text = Convert.ToString(" ");
                    lblPlaDisLosses.Text = Convert.ToString(" ");
                    if (w >= 3 || cw >= 3)
                    {
                        w = w * 0;
                        l = l * 0;
                        d = d * 0;

                        cl = cl * 0;
                        cw = cw * 0;
                        cd = cd * 0;

                    }





                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Better Luck Next Time", "THANKS FOR PLAYING");
                    this.Close();
                }

            }
            
        }




        private void button4_Click(object sender, EventArgs e)

        {
            this.Close();
        }
    }
}
