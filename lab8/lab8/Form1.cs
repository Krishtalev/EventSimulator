using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double a = rnd.NextDouble();
            if (a<0.5)
            {
                label1.Text = "Yes";
            }
            else
            {
                label1.Text = "No";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ans_pool = {"Yes", "No", "Most likely", "Ask again later", "Without a doubt", "As I see it, yes", "Reply hazy, try again", "Don’t count on it"};
            int S = ans_pool.Length;
            double p = 1.0/S;

            Random rnd = new Random();
            double A = rnd.NextDouble();
            int ans_id = -1;
            Console.WriteLine(A);
            Console.WriteLine(S);

            do
            {
                Console.WriteLine(A);
                A -= p;
                ans_id++;
            } while (A > 0);

            label1.Text = ans_pool[ans_id];
        }
    }
}
