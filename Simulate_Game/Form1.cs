using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulate_Game
{
    public partial class timerLabel : Form
    {

        public timerLabel()
        {
            InitializeComponent();
            btn1.Location = new Point(250, 50);
            btn1.Name = "btn0";
            btn1.Height = 180;
            btn1.Width = 180;
            btn1.BackColor = Color.Orange;
            btn1.Click += new EventHandler(btn1_Click);
            btn2.Location = new Point(450, 50);
            btn2.Name = "btn1";
            btn2.Height = 180;
            btn2.Width = 180;
            btn2.BackColor = Color.RoyalBlue;
            btn2.Click += new EventHandler(btn2_Click);
            btn3.Location = new Point(250, 250);
            btn3.Name = "btn2";
            btn3.Height = 180;
            btn3.Width = 180;
            btn3.BackColor = Color.Red;
            btn3.Click += new EventHandler(btn3_Click);
            btn4.Location = new Point(450, 250);
            btn4.Name = "btn3";
            btn4.Height = 180;
            btn4.Width = 180;
            btn4.BackColor = Color.Green;
            btn4.Click += new EventHandler(btn4_Click);

            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;

            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);

            btns.Add(btn1);
            btns.Add(btn2);
            btns.Add(btn3);
            btns.Add(btn4);
        }

        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();

        int level = 4;
        int counter = 1;
        int score = 0;
        int time = 12;

        List<Button> btns = new List<Button> { };
        List<Button> pom = new List<Button>() { };

        List<string> checkSeq = new List<string>();
        List<string> realSeq = new List<string>();
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btn1_Click(object sender, EventArgs e)
        {
            if (counter < level)
            {
                checkSeq.Add("btn1");
            }
            else if (counter == level)
            {
                for (int i = 1; i < level; i++)
                {
                    if (checkSeq[i] == realSeq[i])
                    {
                        timer1.Stop();
                        score += 5;
                        Poeni.Text = String.Format("Поени: {0}", score);
                        DialogResult result = MessageBox.Show("Дали сакате да продолжите кон следното ниво? Освоивте" + Poeni.Text + " Доколку се откажете сега ќе треба да играте од почеток.",
                            "Нивото заврши", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            level += 1;
                            time += 4;
                        }
                        if (result == DialogResult.No)
                        {
                            level = 4;
                            score = 0;
                            //Poeni.Text = String.Format("Поени: 0");
                        }
                        break;
                    }
                    else
                    {
                        timer1.Stop();
                        time = 12;
                        level = 4;
                        MessageBox.Show("Game over");
                        break;
                    }
                }
            }
            counter++;
        }
        public void btn2_Click(object sender, EventArgs e)
        {
            if (counter < level)
            {
                checkSeq.Add("btn1");
            }
            else if (counter == level)
            {
                for (int i = 1; i < level; i++)
                {
                    if (checkSeq[i] == realSeq[i])
                    {
                        timer1.Stop();
                        score += 5;
                        Poeni.Text = String.Format("Поени: {0}", score);
                        DialogResult result = MessageBox.Show("Дали сакате да продолжите кон следното ниво? Освоивте" + Poeni.Text + " Доколку се откажете сега ќе треба да играте од почеток.",
                            "Нивото заврши", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            level += 1;
                            time += 4;
                        }
                        if (result == DialogResult.No)
                        {
                            level = 4;
                            score = 0;
                            //Poeni.Text = String.Format("Поени: 0");
                        }
                        break;
                    }
                    else
                    {
                        timer1.Stop();
                        time = 12;
                        level = 4;
                        MessageBox.Show("Game over");
                        break;
                    }
                }
            }
            counter++;
        }
        public void btn3_Click(object sender, EventArgs e)
        {
            if (counter < level)
            {
                checkSeq.Add("btn2");
            }
            else if (counter == level)
            {
                for (int i = 1; i < level; i++)
                {
                    if (checkSeq[i] == realSeq[i])
                    {
                        timer1.Stop();
                        score += 5;
                        Poeni.Text = String.Format("Поени: {0}", score);
                        DialogResult result = MessageBox.Show("Дали сакате да продолжите кон следното ниво? Освоивте" + Poeni.Text + " Доколку се откажете сега ќе треба да играте од почеток.",
                            "Нивото заврши", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            level += 1;
                            time += 4;
                            startTimer.PerformClick();
                        }
                        if (result == DialogResult.No)
                        {
                            level = 4;
                            score = 0;
                        }
                        break;
                    }
                    else
                    {
                        timer1.Stop();
                        time = 12;
                        level = 4;
                        MessageBox.Show("Game over");
                        break;
                    }
                }
            }
            counter++;
        }
        public void btn4_Click(object sender, EventArgs e)
        {
            if (counter < level)
            {
                checkSeq.Add("btn3");
            }
            else if (counter == level)
            {
                for (int i = 1; i < level; i++)
                {
                    if (checkSeq[i] == realSeq[i])
                    {
                        timer1.Stop();
                        score += 5;
                        Poeni.Text = String.Format("Поени: {0}", score);
                        DialogResult result = MessageBox.Show("Дали сакате да продолжите кон следното ниво? Освоивте" + Poeni.Text + " Доколку се откажете сега ќе треба да играте од почеток.",
                            "Нивото заврши", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            level += 1;
                            time += 4;
                        }
                        if (result == DialogResult.No)
                        {
                            level = 4;
                            score = 0;
                            Poeni.Text = String.Format("Поени: 0");
                        }
                        break;
                    }
                    else
                    {
                        timer1.Stop();
                        time = 12;
                        level = 4;
                        DialogResult result = MessageBox.Show("Game over", "Играта заврши", MessageBoxButtons.OK);
                        break;
                    }
                }

            }
            counter++;
        }
        private void shuffleButtons()
        {

            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < level; i++)
            {
                randomNumbers.Add(random.Next(0, 4));
            }
            List<Button> a = new List<Button>();
            foreach (int item in randomNumbers)
            {
                a.Add(btns[item]);
            }
            pom = btns;
            btns = a;
        }

        private async void startTimer_Click(object sender, EventArgs e)
        {
            realSeq.Clear();
            checkSeq.Clear();
            counter = 1;
            shuffleButtons();
            Color c;
            foreach (Button b in btns)
            {
                c = b.BackColor;
                //b.BackColor = Color.RoyalBlue;
                await Task.Delay(400);
                b.BackColor = Color.Transparent;
                await Task.Delay(1000);
                b.BackColor = c;

                realSeq.Add(b.Name);
            }
            btns = pom;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            if (time <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Game over");
            }
            if (time <= 5)
            {
                timeElapsed.ForeColor = Color.Red;
            }
            if (time > 5)
            {
                timeElapsed.ForeColor = Color.Black;
            }
            timeElapsed.Text = time.ToString();
            time--;
        }


    }
}