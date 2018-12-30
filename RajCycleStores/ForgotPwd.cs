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
    public partial class ForgotPwd : Form
    {
        SqlConnection con = new SqlConnection(G_Class.constr);
        public ForgotPwd()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt1.Text.Trim() =="")
                {
                    MessageBox.Show ("Enter Secret Code","Advice");
                }
                else
                {
                    SqlDataAdapter adp = new SqlDataAdapter("select * from Log_In where  secret_code='" + txt1.Text.Trim() + "'", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "cust_details");
                    MessageBox.Show(ds.Tables[0].Rows[0]["PassWd"].ToString(), "Your Password is        ");
                }
            }
            catch
            {
                MessageBox.Show("Enter correct Secret Code...." ,"Error");
            }
        }
    }
}
