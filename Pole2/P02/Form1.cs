using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 11);

            }
            foreach (int s in pole)
                listBox1.Items.Add(s);
            Array.Sort(pole);
            if (radioButton2.Checked == true)
            {
                Array.Reverse(pole);
            }
            foreach (int s in pole)
                listBox2.Items.Add(s);
        }

    }
}