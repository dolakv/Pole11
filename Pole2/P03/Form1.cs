using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
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
        int[] A;
        int[] B;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = rnd.Next(2, 11);
            }
            foreach (int s in A)
                listBox1.Items.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int m = Convert.ToInt32(textBox2.Text);
            B = new int[m];
            for (int i = 0; i < m; i++)
            {
                B[i] = rnd.Next(2, 11);
            }
            foreach (int s in B)
                listBox2.Items.Add(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] C =  A.Concat(B).ToArray();
            foreach (int s in C)
                listBox3.Items.Add(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] D = A.Union(B).ToArray();
            foreach (int s in D)
                listBox4.Items.Add(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] E = A.Intersect(B).ToArray();
            foreach (int s in E)
                listBox5.Items.Add(s);
        }
    }
}
