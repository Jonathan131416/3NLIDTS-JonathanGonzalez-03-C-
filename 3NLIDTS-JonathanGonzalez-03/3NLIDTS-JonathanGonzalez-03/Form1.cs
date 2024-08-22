using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_JonathanGonzalez_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFC_Click(object sender, EventArgs e)
        {
            float F=float.Parse(tbFa.Text);
            float c = (F - 32) * 5.0f / 9.0f;
            tbCe.Text = c.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float c=float.Parse(tbCe.Text);
            float F = (c * 9f / 5f) + 32;
            tbFa.Text = F.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCe.Text = "";
            tbFa.Text = "";
        }
    }
}
