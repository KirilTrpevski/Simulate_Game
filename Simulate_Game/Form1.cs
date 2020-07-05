using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulate_Game
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        List<string> btns = new List<string> { "btnOrange1", "btnBlue2", "btnRed3", "btnGreen4" };
        List<string> clicked = new List<string>(); 
        List<string> seq = new List<string>();
        int test;

        int counter = 60;

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (string s in btns)
            //{
            //    listBox1.Items.Add(s);
            //}
            for (int i = 0; i <= 2; i++)
            {
                btnBlue2.PerformClick();
            }
            var seq = new List<string>();
            
            
      

        }
        
        

        //Random rand = new Random();

        private void btnOrange1_Click(object sender, EventArgs e)
        {
            btnBlue2.PerformClick();
            //listBox1.Items.Add(btns[0]);
            //seq.Add(btns[0]);
            foreach (string i in clicked)
            {
                MessageBox.Show(i);
            }

        }

        private void btnBlue2_Click(object sender, EventArgs e)
        {
            btnBlue2.BackColor = Color.Red;
            MessageBox.Show(btns[test]);
        }

        private void startTimer_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if(btnOrange1.BackColor == Color.DarkOrange)
            {
                btnOrange1.BackColor = Color.Transparent;
            }
            else
            {
                btnOrange1.BackColor = Color.DarkOrange;
                timer1.Stop();
                clicked.Add(btnOrange1.Name);
            }

        }

        private void btnRed3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int k = 0; k < 1; k++)
            {
                test = random.Next(btns.Count);
                seq.Add(btns[test]);
                
            }
            foreach(string i in seq)
            {
                listBox1.Items.Add(i);
            }
            
        }
    }

}
