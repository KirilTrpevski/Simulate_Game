using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            btn1.Location = new Point(250, 50);
            btn1.Name = "btn0";
            btn1.Height = 180;
            btn1.Width = 180;
            btn1.BackColor = Color.RoyalBlue;
            btn1.Text = "kopce0";
            btn2.Location = new Point(450, 50);
            btn2.Name = "btn1";
            btn2.Height = 180;
            btn2.Width = 180;
            btn2.BackColor = Color.RoyalBlue;
            btn2.Text = "kopce1";
            btn3.Location = new Point(250, 250);
            btn3.Name = "btn2";
            btn3.Height = 180;
            btn3.Width = 180;
            btn3.BackColor = Color.RoyalBlue;
            btn3.Text = "kopce2";
            btn4.Location = new Point(450, 250);
            btn4.Name = "btn3";
            btn4.Height = 180;
            btn4.Width = 180;
            btn4.BackColor = Color.RoyalBlue;
            btn4.Text = "kopce3";
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);

            btns.Add(btn1);
            btns.Add(btn2);
            btns.Add(btn3);
            btns.Add(btn4);
        }
        List<Button> btns = new List<Button> {  };
     

        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();

        int level = 4;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void shuffleButtons()
        {
            Random random = new Random();
            List<int> randomNumbers = new List<int>();

            for(int i = 0; i<level; i++)
            {
                randomNumbers.Add(random.Next(0, 4));
            }
            List<Button> a = new List<Button>();
            foreach (int item in randomNumbers)
            {
                a.Add(btns[item]);
            }
            btns = a;
        }

        private async void startTimer_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            shuffleButtons();
            foreach (Button b in btns)
            {
                //MessageBox.Show(b.Name);
                b.BackColor = Color.RoyalBlue;
                await Task.Delay(400);
                b.BackColor = Color.Transparent;
                await Task.Delay(1000);
                b.BackColor = Color.RoyalBlue;

                listBox1.Items.Add(b.Name);
            }
        }
    }
       

}
