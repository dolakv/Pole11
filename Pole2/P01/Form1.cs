using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
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
            int min = 1000;
            int max = 0;
            int q = 0;
            int pozicemax = 0;
            int pozicemin = 0;
            double soucet = 0;
            int pocet = 0;
            
            int n = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 1000);
                soucet += pole[i];
             
                if (pole[i] < min)
                {
                    min = pole[i];
                    pozicemin = i;
                }
                if (pole[i] > max)
                {
                    max = pole[i];
                    pozicemax = i;
                }
            }
            foreach (int s in pole)
                listBox1.Items.Add(s);
            pole[pozicemin] = max;
            pole[pozicemax] = min;
            if(pocet > 0)
            {
                double prumer = (soucet - min - max) / (pocet - 2);
                MessageBox.Show("prumer cisel v poli bez minima a maxima je " + prumer);
            }
            foreach (int s in pole)
                listBox2.Items.Add(s);
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random rnd = new Random();
            int min = 1000;
            int max = 0;
            int q = 0;
            double soucet = 0;
            int pocet = 0;

            int n = Convert.ToInt32(textBox1.Text);
            int[] pole = new int[n];
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 1000);
            }
            soucet = pole.Sum();
            min = pole.Min();
            max = pole.Max();
            foreach (int s in pole)
                listBox1.Items.Add(s);
            int pozicemin = Array.IndexOf(pole, min);
            int pozicemax = Array.IndexOf(pole, max);
            pole[pozicemin] = max;
            pole[pozicemax] = min;
            if (pocet > 0)
            {
                double prumer = (soucet - min - max) / (n  - 2);
                MessageBox.Show("prumer cisel v poli bez minima a maxima je " + prumer);
            }
            foreach (int s in pole)
                listBox2.Items.Add(s);
        }
    }
}
