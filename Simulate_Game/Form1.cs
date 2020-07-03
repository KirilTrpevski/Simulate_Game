using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        String[] btns = { "btnOrange1", "btnBlue2", "btnRed3", "btnGreen4" };
        List<string> seq = new List<string>();

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
            listBox1.Items.Add(btns[0]);
            seq.Add(btns[0]);
            foreach (string i in seq)
            {
                MessageBox.Show(i);
            }

        }

        private void btnBlue2_Click(object sender, EventArgs e)
        {
            btnBlue2.BackColor = Color.Red;
        }


    }

}
