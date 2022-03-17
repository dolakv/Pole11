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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
            int pozicemin2 = 0;
            int pozicemax2 = 0;
            int max2;
            int min2;
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 11);
            }
            foreach (int s in pole)
                listBox1.Items.Add(s);
            Array.Sort(pole);
            int max = pole[n - 1];
            int min = pole[0];
            pozicemax2 = (Array.IndexOf(pole, max)) - 1;
            pozicemin2 = (Array.LastIndexOf(pole, min)) + 1;
            min2 = pole[pozicemin2];
            max2 = pole[pozicemax2];
            if (radioButton2.Checked == true)
            {
                Array.Reverse(pole);
            }
            foreach (int s in pole)
                listBox2.Items.Add(s);
            MessageBox.Show("druhy nejvetsi cislo je " + max2);
            MessageBox.Show("druhy nejmensi cislo je " + min2);
        }

    }
}