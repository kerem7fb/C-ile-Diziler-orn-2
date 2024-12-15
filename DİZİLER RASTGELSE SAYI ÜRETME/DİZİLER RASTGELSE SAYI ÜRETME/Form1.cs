using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DİZİLER_RASTGELSE_SAYI_ÜRETME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] günler = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < günler.Length; i++)
            {
                listBox1.Items.Add(günler[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = günler[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = günler[1];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = günler[2];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = günler[4];
        }
    }
}
