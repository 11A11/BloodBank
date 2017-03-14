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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dell\\Documents\\TESTFILE.MDF;Integrated Security=True;Connect Timeout=30");
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp();
        }
        public void disp()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BloodBank";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disp();
        }
    }
}
