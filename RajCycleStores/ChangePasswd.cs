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
    public partial class ChangePasswd : Form
    {
        SqlConnection con = new SqlConnection(G_Class.constr);
        public ChangePasswd()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Log_In", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            Boolean b = false;

            if (NTextBox.Text != RNTextBox.Text)
            {
                MessageBox.Show("Password does not same..", "Error");
            }
            else if ((OldTextBox.Text).Equals((dt.Rows[0][0]).ToString()))
                {
                    SqlCommand cmd = new SqlCommand("update Log_In set PassWd = '" + RNTextBox.Text.Trim() + "',secret_code='" + STextBox.Text.Trim() + "'", con);
                    int i1 = cmd.ExecuteNonQuery();
                    MessageBox.Show("Password has been changed..", "Thanks");
                    b = true;
                }
            
            
            else if (!b)
            {
                MessageBox.Show("Invalid Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                OldTextBox.Text = "";
            }
            
                con.Close();
        }
    }
}
