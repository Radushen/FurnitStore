using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitSotre
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            s.Show();
            this.Hide();
        }
    }
}
