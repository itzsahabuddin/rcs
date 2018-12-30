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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(G_Class.constr);
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PartyName.Text = "Select-an-option";
          
            SqlDataAdapter da = new SqlDataAdapter("select Party_Name from Add_Party ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "login");
            int index = 0;
            for (index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                PartyName.Items.Add(ds.Tables[0].Rows[index][0]);
            }
        }

        private void PartyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(G_Class.constr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select Amount from Party_Details where Party_Name='" + PartyName.Text.Trim() + "'", con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                PAmnt.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
                //Rate.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
            }
            catch 
            {
                
            }
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(PartyName.Text =="Select-an-option")
                {
                    MessageBox.Show("Select Party Name","Error");
                }
                else if (PDetails.Text == "")
                {
                    MessageBox.Show("Enter Detalis","Error");
                }
                else if (Amnt.Text == "")
                {
                    MessageBox.Show("Enter Amount","Error");
                }
                else
                {
                    if (PAmnt.Text.Trim() == "")
                    {

                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("insert into Temp_Party values('" + DateTime.Today.ToShortDateString() + "','" + PartyName.Text.Trim() + "','" + PDetails.Text.Trim() + "','" + Amnt.Text.Trim() + "','" + DateTime.Today.ToString("MMMM") + "','" + DateTime.Today.ToString("yyyy") + "');", con);
                        SqlCommand cmd = new SqlCommand("insert into Party_Details values('" + PartyName.Text.Trim() + "','" + Amnt.Text.Trim() + "','" + DateTime.Today.ToShortDateString() + "');", con);
                        int i1 = cmd1.ExecuteNonQuery();
                        int i = cmd.ExecuteNonQuery();
                        MessageBox.Show("Operation completed", "Thanks");
                        kryptonButton1.Enabled = false;
                        con.Close();
                    }
                    else
                    {

                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("insert into Temp_Party values('" + DateTime.Today.ToShortDateString() + "','" + PartyName.Text.Trim() + "','" + PDetails.Text.Trim() + "','" + Amnt.Text.Trim() + "','" + DateTime.Today.ToString("MMMM") + "','" + DateTime.Today.ToString("yyyy") + "');", con);
                        TmpAmnt.Text = Convert.ToString(Convert.ToInt32(PAmnt.Text) + Convert.ToInt32(Amnt.Text));
                        SqlCommand cmd = new SqlCommand("update Party_Details set Amount='" + TmpAmnt.Text.Trim() + "',Date='" + DateTime.Today.ToShortDateString() + "'where Party_Name='" + PartyName.Text.Trim() + "'", con);
                        int i2 = cmd1.ExecuteNonQuery();
                        int i3 = cmd.ExecuteNonQuery();
                        MessageBox.Show("Information is updated", "Thanks");
                        kryptonButton1.Enabled = false;

                        //kryptonButton2.Enabled = false;
                        con.Close();
                    }
                }
            }
            catch(Exception )
            {

                    /*con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Party_Details values('" + PartyName.Text.Trim() + "','" + PDetails.Text.Trim() + "','" + Amnt.Text.Trim() + "','" + DateTime.Today.ToShortDateString() + "');", con);
                    int i = cmd.ExecuteNonQuery();
                    MessageBox.Show("Operation completed", "Thanks");
                    kryptonButton1.Enabled = false;
                    con.Close();*/
            }
        
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            PartyName.Text = "Select-an-option";
            PDetails.Text = "";
            PAmnt.Text = "";
            Amnt.Text = "";
            kryptonButton1.Enabled = true;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }
    }
}
