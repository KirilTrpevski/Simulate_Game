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
            btn1.Name = "btn1";
            btn1.Height = 180;
            btn1.Width = 180;
            btn1.BackColor = Color.RoyalBlue;
            btn2.Location = new Point(450, 50);
            btn2.Name = "btn2";
            btn2.Height = 180;
            btn2.Width = 180;
            btn2.BackColor = Color.RoyalBlue;
            btn3.Location = new Point(450, 250);
            btn3.Name = "btn3";
            btn3.Height = 180;
            btn3.Width = 180;
            btn3.BackColor = Color.RoyalBlue;
            btn4.Location = new Point(250, 250);
            btn4.Name = "btn4";
            btn4.Height = 180;
            btn4.Width = 180;
            btn4.BackColor = Color.RoyalBlue;
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

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void shuffleButtons()
        {
            Random random = new Random();
            var randomNumbers = Enumerable.Range(0, 4).OrderBy(x => random.Next()).Take(4).ToList();
            int[] n = new int[4];
            List<int> a = new List<int>();
            foreach (int item in randomNumbers)
            {
                a.Add(item);
            }
            for (int i = 0; i < btns.Count; i++)
            {
                n[i] = a[i];
                btns[i] = btns[n[i]];
            }
            foreach(var j in a)
            {
                MessageBox.Show(j.ToString());
            }
        }

        private async void startTimer_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            shuffleButtons();
          foreach(Button b in btns)
            {
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
