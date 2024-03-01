using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create an int guess variable to track what part of the pattern the user is at
        int randnum;
        bool playerturn = false;
        bool guess = false;
        int delay = 1000;
        int delay2 = 500;

        Random random = new Random();

        SoundPlayer green = new SoundPlayer(Properties.Resources.green);
        SoundPlayer yellow = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer red = new SoundPlayer(Properties.Resources.red);
        SoundPlayer blue = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer gameover = new SoundPlayer(Properties.Resources.mistake);
        public GameScreen()
        {
            InitializeComponent();
        }
        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1
            //TODO: refresh
            //TODO: pause for a bit
            //TODO: run ComputerTurn()
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(1000);
            ComputerTurn();
        }
        private void ComputerTurn()
        {
            playerturn = false;
            Form1.pattern.Add(random.Next(0, 9));
            //randnum = Form1.pattern[Form1.pattern.Count - 1];
            //label1.Text = $"{randnum}";
            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                randnum = Form1.pattern[i];
                if (randnum == 0)
                {
                    button1.BackColor = Color.Blue;
                    green.Play();
                    Refresh();
                    Thread.Sleep(delay);
                    button1.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delay2);
                }
                else if (randnum == 1)
                {
                    button2.BackColor = Color.Blue;
                    red.Play();
                    Refresh();
                    Thread.Sleep(delay);
                    button2.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delay2);
                }
                else if (randnum == 2)
                {
                    button3.BackColor = Color.Blue;
                    yellow.Play();
                    Refresh();
                    Thread.Sleep(delay);
                    button3.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delay2);
                }
                else if (randnum == 3)
                {
                    button4.BackColor = Color.Blue;
                    blue.Play();
                    Refresh();
                    Thread.Sleep(delay);
                    button4.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delay2);
                }
                else if (randnum == 4)
                {
                    button5.BackColor = Color.Blue;
                    blue.Play();
                    Refresh();
                    Thread.Sleep(delay);
                    button5.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delay2);
                }
                else if (randnum == 5)
                {
                    button6.BackColor = Color.Blue;
                    blue.Play();
                    Refresh();
                    Thread.Sleep(delay);
                    button6.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delay2);
                }
                else if (randnum == 6)
                {
                    button7.BackColor = Color.Blue;
                    blue.Play();
                    Refresh();
                    Thread.Sleep(delay);
                    button7.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delay2);
                }
                else if (randnum == 7)
                {
                    button8.BackColor = Color.Blue;
                    blue.Play();
                    Refresh();
                    Thread.Sleep(delay);
                    button8.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delay2);
                }
                else if (randnum == 8)
                {
                    button9.BackColor = Color.Blue;
                    blue.Play();
                    Refresh();
                    Thread.Sleep(delay);
                    button9.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delay2);
                }
            }
            Form1.player.Clear();
            playerturn = true;
            Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.player.Add(0);
            compare(Form1.pattern, Form1.player);
            if (playerturn == true && guess == true)
            {
                button1.BackColor = Color.Blue;
                green.Play();
                Refresh();
                Thread.Sleep(delay2);
                button1.BackColor = Color.White;
            }
            else
            {
                GameOver();
            }
            if (Form1.player.Count == Form1.pattern.Count)
            {
                Refresh();
                Thread.Sleep(delay);
                ComputerTurn();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1.player.Add(1);
            compare(Form1.pattern, Form1.player);
            if (playerturn == true && guess == true)
            {
                button2.BackColor = Color.Blue;
                red.Play();
                Refresh();
                Thread.Sleep(delay2);
                button2.BackColor = Color.White;
            }
            else
            {
                GameOver();
            }
            if (Form1.player.Count == Form1.pattern.Count)
            {
                Refresh();
                Thread.Sleep(delay);
                ComputerTurn();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1.player.Add(2);
            compare(Form1.pattern, Form1.player);
            if (playerturn == true && guess == true)
            {
                button3.BackColor = Color.Blue;
                yellow.Play();
                Refresh();
                Thread.Sleep(delay2);
                button3.BackColor = Color.White;
            }
            else
            {
                GameOver();
            }
            if (Form1.player.Count == Form1.pattern.Count)
            {
                Refresh();
                Thread.Sleep(delay);
                ComputerTurn();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form1.player.Add(3);
            compare(Form1.pattern, Form1.player);
            if (playerturn == true && guess == true)
            {
                button4.BackColor = Color.Blue;
                blue.Play();
                Refresh();
                Thread.Sleep(delay2);
                button4.BackColor = Color.White;
            }
            else
            {
                GameOver();
            }
            if (Form1.player.Count == Form1.pattern.Count)
            {
                Refresh();
                Thread.Sleep(delay);
                ComputerTurn();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form1.player.Add(4);
            compare(Form1.pattern, Form1.player);
            if (playerturn == true && guess == true)
            {
                button5.BackColor = Color.Blue;
                blue.Play();
                Refresh();
                Thread.Sleep(delay2);
                button5.BackColor = Color.White;
            }
            else
            {
                GameOver();
            }
            if (Form1.player.Count == Form1.pattern.Count)
            {
                Refresh();
                Thread.Sleep(delay);
                ComputerTurn();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form1.player.Add(5);
            compare(Form1.pattern, Form1.player);
            if (playerturn == true && guess == true)
            {
                button6.BackColor = Color.Blue;
                blue.Play();
                Refresh();
                Thread.Sleep(delay2);
                button6.BackColor = Color.White;
            }
            else
            {
                GameOver();
            }
            if (Form1.player.Count == Form1.pattern.Count)
            {
                Refresh();
                Thread.Sleep(delay);
                ComputerTurn();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form1.player.Add(6);
            compare(Form1.pattern, Form1.player);
            if (playerturn == true && guess == true)
            {
                button7.BackColor = Color.Blue;
                blue.Play();
                Refresh();
                Thread.Sleep(delay2);
                button7.BackColor = Color.White;
            }
            else
            {
                GameOver();
            }
            if (Form1.player.Count == Form1.pattern.Count)
            {
                Refresh();
                Thread.Sleep(delay);
                ComputerTurn();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Form1.player.Add(7);
            compare(Form1.pattern, Form1.player);
            if (playerturn == true && guess == true)
            {
                button8.BackColor = Color.Blue;
                blue.Play();
                Refresh();
                Thread.Sleep(delay2);
                button8.BackColor = Color.White;
            }
            else
            {
                GameOver();
            }
            if (Form1.player.Count == Form1.pattern.Count)
            {
                Refresh();
                Thread.Sleep(delay);
                ComputerTurn();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form1.player.Add(8);
            compare(Form1.pattern, Form1.player);
            if (playerturn == true && guess == true)
            {
                button9.BackColor = Color.Blue;
                blue.Play();
                Refresh();
                Thread.Sleep(delay2);
                button9.BackColor = Color.White;
            }
            else
            {
                GameOver();
            }
            if (Form1.player.Count == Form1.pattern.Count)
            {
                Refresh();
                Thread.Sleep(delay);
                ComputerTurn();
            }
        }
        public void GameOver()
        {
            //TODO: Play a game over sound
            gameover.Play();
            //TODO: close this screen and open the GameOverScreen
            Form f = FindForm();
            f.Controls.Remove(this);
            GameOverScreen gameoverscreen = new GameOverScreen();
            f.Controls.Add(gameoverscreen);
        }
        public void compare(List<int> comlist, List<int> playlist)
        {
            try
            {
                if (comlist[playlist.Count - 1] == playlist[playlist.Count - 1])
                {
                    guess = true;
                }
                else
                {
                    guess = false;

                }
            }
            catch
            {
                GameOver();
            }
        }
    }
}
