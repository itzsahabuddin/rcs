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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(G_Class.constr);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            PName.Text = "Select-an-option";
            Qty.Clear();
            Rate.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select Product_Name from Add_Product ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "login");
            int index = 0;
            for (index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                PName.Items.Add(ds.Tables[0].Rows[index][0]);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (PName.Text == "Select-an-option")
                {
                    MessageBox.Show("Select Product Name", "Error");
                }
                else if (Qty.Text == "")
                {
                    MessageBox.Show("Enter Quantity","error");
                }
                else if(Rate.Text=="")
                {
                    MessageBox.Show("Enter Rate", "error");
                }
                else
                {
                    if (TextQ.Text.Trim() == "")
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Temp_Stock values('" + DateTime.Today.ToShortDateString() + "','" + PName.Text.Trim() + "','" + Qty.Text.Trim() + "','" + Rate.Text.Trim() + "','" + DateTime.Today.ToString("MMMM") + "','" + DateTime.Today.ToString("yyyy") + "');", con);
                        SqlCommand cmd1 = new SqlCommand("insert into Stock_Details values('" + PName.Text.Trim() + "','" + Qty.Text.Trim() + "','" + Rate.Text.Trim() + "','" + DateTime.Today.ToShortDateString() + "','" + DateTime.Now.ToShortTimeString() + "');", con);
                        int i = cmd.ExecuteNonQuery();
                        int i1 = cmd1.ExecuteNonQuery();
                        MessageBox.Show("Operation completed", "Thanks");
                        kryptonButton1.Enabled = false;
                        con.Close();
                    }
                    else
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Temp_Stock values('" + DateTime.Today.ToShortDateString() + "','" + PName.Text.Trim() + "','" + Qty.Text.Trim() + "','" + Rate.Text.Trim() + "','" + DateTime.Today.ToString("MMMM") + "','" + DateTime.Today.ToString("yyyy") + "');", con);
                        Qty.Text = Convert.ToString(Convert.ToInt32(Qty.Text) + Convert.ToInt32(TextQ.Text));
                        SqlCommand cmd1 = new SqlCommand("update Stock_Details set Qty='" + Qty.Text.Trim() + "',Rate='" + Rate.Text.Trim() + "',Date='" + DateTime.Today.ToShortDateString() + "',Time='" + DateTime.Now.ToShortTimeString() + "' where Product_Name='" + PName.Text.Trim() + "'", con);
                        int i2 = cmd.ExecuteNonQuery();
                        int i3 = cmd1.ExecuteNonQuery();
                        MessageBox.Show("Information is updated", "Thanks");
                        kryptonButton1.Enabled = false;

                        //kryptonButton2.Enabled = false;
                        con.Close();
                    }
                }
            }
            catch(Exception )
            {               
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Stock_Details values('" + PName.Text.Trim() + "','" + Qty.Text.Trim() + "','" + Rate.Text.Trim() + "','" + DateTime.Today.ToShortDateString() + "','" + DateTime.Now.ToShortTimeString() + "');", con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Operation completed", "Thanks");
                kryptonButton1.Enabled = false;
                con.Close();
            }
        }

        private void PName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
          
                SqlConnection con = new SqlConnection(G_Class.constr);
                con.Open();

                SqlDataAdapter adp = new SqlDataAdapter("select Qty, Rate from Stock_Details where Product_Name='" + PName.Text.Trim() + "'", con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                TextQ.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
                Rate.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
                //con.Close();
            }
            catch
            {
                TextQ.Clear();
                Rate.Clear();
            }
        }

        private void Rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            PName.Text = "Select-an-option";
            PName.Text = "";
            Qty.Text = "";
            TextQ.Text = "";
            Rate.Text = "";
            kryptonButton1.Enabled = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }
    }
}
