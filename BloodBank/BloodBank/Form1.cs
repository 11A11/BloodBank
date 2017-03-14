using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
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
            Form2 insert = new Form2();
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 insert = new Form3();
            insert.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form4 insert = new Form4();
            insert.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 insert = new Form5();
            insert.Show();

        }
        public static void main(string[] args)
        { Application.Run(new Form1()); }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 insert = new Form6();
            insert.Show();

        }
    }
}
