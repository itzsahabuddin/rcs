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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(G_Class.constr);
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonLabel1_Resize(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kryptonButton2.Enabled = false;
            kryptonButton4.Enabled = false;
            PName.Text = "Select Product Name";
            SqlDataAdapter da = new SqlDataAdapter("select Product_Name from Add_Product ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "login");
            int index = 0;
            for (index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                PName.Items.Add(ds.Tables[0].Rows[index][0]);
            }
            try
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select Invoice_No from Sales_Details", con);
                DataSet ds1 = new DataSet();
                adp.Fill(ds1);
                TxtId.Text = Convert.ToString(ds1.Tables[0].Rows.Count + 1);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (CustName.Text == "")
            {
                MessageBox.Show("Enter Customer name", "Error");
            }
            else if (CustAdd.Text == "")
            {
                MessageBox.Show("Enter Customer Adress", "Error");
            }
            else if (Qty.Text  == "")
            {
                MessageBox.Show("Enter Quantity", "Error");
            }
            else if (FNo.Text == "")
            {
                MessageBox.Show("Enter Frame No", "Error");
            }
            else if (Price.Text == "")
            {
                MessageBox.Show("Eenter Price", "Error");
            }
            else
            {
                con.Open();
                SqlCommand cmd3 = new SqlCommand("delete from Print_SalesDetails", con);
                SqlCommand cmd = new SqlCommand("insert into Sales_Details values('" + TxtId.Text.Trim() + "','" + CustName.Text.Trim() + "','" + CustAdd.Text.Trim() + "','" + PName.Text.Trim() + "','" + TxtDesc.Text.Trim() + "','" + Qty.Text.Trim() + "','" + FNo.Text.Trim() + "','" + Price.Text.Trim() + "','" + DateTime.Today.ToShortDateString() + "','" + DateTime.Today.ToString("MMMM") + "','" + DateTime.Today.ToString("yyyy") + "');", con);
                SqlCommand cmd2 = new SqlCommand("insert into Print_SalesDetails values('" + TxtId.Text.Trim() + "','" + CustName.Text.Trim() + "','" + CustAdd.Text.Trim() + "','" + PName.Text.Trim() + "','" + TxtDesc.Text.Trim() + "','" + Qty.Text.Trim() + "','" + FNo.Text.Trim() + "','" + Price.Text.Trim() + "','" + Price.Text.Trim() + "');", con);
                Qty.Text = Convert.ToString(Convert.ToInt32(TextQ.Text) - Convert.ToInt32(Qty.Text));
                SqlCommand cmd1 = new SqlCommand("update Stock_Details set Qty='" + Qty.Text.Trim() + "',Rate='" + Rate.Text.Trim() + "',Date='" + DateTime.Today.ToShortDateString() + "',Time='" + DateTime.Now.ToShortTimeString() + "' where Product_Name='" + PName.Text.Trim() + "'", con);
                int i3 = cmd3.ExecuteNonQuery();
                int i = cmd.ExecuteNonQuery();
                int i1 = cmd1.ExecuteNonQuery();
                int i2 = cmd2.ExecuteNonQuery();

                MessageBox.Show("Operation completed", "Thanks");
                kryptonButton1.Enabled = false;
                con.Close();
                kryptonButton2.Enabled = true;
                kryptonButton4.Enabled = true;
            }            
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            SalesReport r = new SalesReport();
            r.Show();
            
            /*con.Open();
            SqlCommand cmd3 = new SqlCommand("delete from Print_SalesDetails", con);
            int i3 = cmd3.ExecuteNonQuery();
            con.Close();*/
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            PName.Text = "Select Product Name";
            CustName.Text = "";
            CustAdd.Text = "";
            Qty.Text = "";
            FNo.Text = "";
            Price.Text = "";
            TxtDesc.Text = "";
            TextQ.Text = "";
            Rate.Text = "";
            kryptonButton1.Enabled = true;
            kryptonButton4.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }
    }
}
