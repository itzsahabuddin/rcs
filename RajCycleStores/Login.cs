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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(G_Class.constr);
        public Login()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void kryptonTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void kryptonTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Log_In", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            Boolean b = false;
            if ((TxtPwd.Text).Equals((dt.Rows[0][0]).ToString()))
            {
                Form6 r = new Form6();
                r.Show();
                this.Hide();
                b = true;
            }
            else if (!b)
            {
                MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtPwd.Text = "";

            }
            con.Close();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            ForgotPwd r = new ForgotPwd();
            r.Show();
            
        }
    }
}
