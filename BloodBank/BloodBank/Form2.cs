using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BloodBank
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dell\\Documents\\TESTFILE.MDF;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a valid name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a valid id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(string.IsNullOrWhiteSpace(textBox4.Text)))
            {
                int checkNum;
                if (!int.TryParse(textBox4.Text, out checkNum))
                {
                    MessageBox.Show("Please enter a valid Phone number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter a blood group", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            int checkWID;
            if (!int.TryParse(textBox7.Text, out checkWID))
            {
                MessageBox.Show("Please enter a valid quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            con.Open();
            SqlCommand sc = new SqlCommand("insert into Donor values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "');",con);
            object o = sc.ExecuteNonQuery();
            MessageBox.Show(o +":Record was inserted");
            con.Close();
        }
    }
}
