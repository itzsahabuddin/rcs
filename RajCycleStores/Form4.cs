using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RajCycleStores
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(G_Class.constr);
        public Form4()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Add_Product values('" +Txt_PName.Text.Trim()+ "','" + Txt_AddBy.Text.Trim() + "','" + DateTime.Today.ToShortDateString() + "','" + DateTime.Now.ToShortTimeString() + "');", con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("Your registration process is completed", "Thanks");
            kryptonButton1.Enabled = false;
            con.Close();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Add_Party values('" + TxtName.Text.Trim() + "','" + TxtAdd.Text.Trim() + "','"+TxtMob.Text.Trim()+"','" + DateTime.Today.ToShortDateString() + "','" + DateTime.Now.ToShortTimeString() + "');", con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("Your registration process is completed", "Thanks");
            kryptonButton3.Enabled = false;
            con.Close();
        }

        private void TxtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Txt_AddBy.Text = "Mohidul Islam ";
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            Txt_PName.Text = "";
            kryptonButton1.Enabled = true;
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtAdd.Text  = "";
            TxtMob.Text = "";
            kryptonButton3.Enabled = true;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }

    }
}
