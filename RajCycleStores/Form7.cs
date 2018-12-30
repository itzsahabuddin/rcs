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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection(G_Class.constr);
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
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
            PNameLabel.Visible = false;
            PartyName.Visible = false;

            //MonthLabel.Visible = false;                        
            //CombMonth.Visible = false;

            InvoiceLabel.Visible = false;
            InvoiceBox.Visible = false;
            CustButtonP.Visible = false;
            CustButtonS.Visible = false;
            
            PaymentButtonS.Visible = false;
            PurchaseButtonS.Visible = false;
            
            PrintPartyB.Visible = false;
            PrintPurchaseB.Visible = false;
            
            kryptonDataGridView1.Visible = false;
            kryptonDataGridView2.Visible =false ;
            kryptonDataGridView3.Visible = false;

            PaymentLabel1.Visible = false;
            CustLabel2.Visible = false;
            PurchasingLabel1.Visible = false;

            YearLabel.Enabled = false;
            TextBoxYear.Enabled = false;
            MonthLabel.Enabled = false;
            CombMonth.Enabled = false;

            FDateLabel.Enabled = false;
            FDate.Enabled = false;
            TDateLabel.Enabled = false;
            TDate.Enabled = false;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            
            try
             {
                 if (CheckBoxM.Checked  == true)
                 {
                     if (TextBoxYear.Text.Trim() == "")
                     {
                         MessageBox.Show("Fill Party Name , Year and Month", "Error");
                     }
                     else
                     {
                         SqlDataAdapter da = new SqlDataAdapter("select Date,Party_Name,PrevAmount,PayAmount,DueAmount from Payment_Details where Party_Name='" + PartyName.Text.Trim() + "' and Months='" + CombMonth.Text.Trim() + "'and Year='" + TextBoxYear.Text.Trim() + "'", con);
                         DataSet ds = new DataSet();
                         da.Fill(ds, "login");
                         kryptonDataGridView1.DataSource = ds;
                         kryptonDataGridView1.DataMember = "login";

                         con.Open();
                         SqlCommand cmd2 = new SqlCommand("delete from Print_PaymentDetails", con);
                         SqlCommand cmd1 = new SqlCommand("insert into Print_PaymentDetails select * from Payment_Details where Payment_Details.Party_Name ='" + PartyName.Text.Trim() + "' and Payment_Details.Months='" + CombMonth.Text.Trim() + "' and Payment_Details.Year='" + TextBoxYear.Text.Trim() + "'", con);

                         int i1 = cmd2.ExecuteNonQuery();
                         int i2 = cmd1.ExecuteNonQuery(); ;
                         con.Close();
                         PrintPartyB.Enabled = true;
                     }
                 }

                 else if(CheckBoxD.Checked==true )
                 {
                     SqlDataAdapter da = new SqlDataAdapter("select Date,Party_Name,PrevAmount,PayAmount,DueAmount from Payment_Details where Party_Name='" + PartyName.Text.Trim() + "' and Payment_Details.Date  between '"+ DateTime.Parse(FDate.Value.ToString()) +"' and '" + DateTime.Parse(TDate.Value.ToString()) + "'", con);
                         DataSet ds = new DataSet();
                         da.Fill(ds, "login");
                         kryptonDataGridView1.DataSource = ds;
                         kryptonDataGridView1.DataMember = "login";

                         con.Open();
                         SqlCommand cmd2 = new SqlCommand("delete from Print_PaymentDetails", con);
                         SqlCommand cmd1 = new SqlCommand("insert into Print_PaymentDetails select * from Payment_Details where Payment_Details.Party_Name ='" + PartyName.Text.Trim() + "' and Payment_Details.Date  between '" + DateTime.Parse(FDate.Value.ToString()) + "' and '" + DateTime.Parse(TDate.Value.ToString()) + "'", con);

                         int i1 = cmd2.ExecuteNonQuery();
                         int i2 = cmd1.ExecuteNonQuery(); ;
                         con.Close();
                         PrintPartyB.Enabled = true;
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            PNameLabel.Visible = true;            
            PartyName.Visible = true;
            
            PaymentButtonS.Visible = true;
            PrintPartyB.Visible = true;
            kryptonDataGridView1.Visible = true;
            

            PurchaseButtonS.Visible = false;
            PrintPurchaseB.Visible = false;
            kryptonDataGridView2.Visible = false;

            InvoiceLabel.Visible = false;
            InvoiceBox.Visible = false;
            CustButtonP.Visible = false;
            CustButtonS.Visible = false;
            kryptonDataGridView3.Visible = false;

            PaymentLabel1.Visible = true ;
            CustLabel2.Visible = false;
            PurchasingLabel1.Visible = false;
            PrintPartyB.Enabled = false;
            
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            PNameLabel.Visible = true;
            PartyName.Visible = true;

            kryptonDataGridView2.Visible = true;
            PrintPurchaseB.Visible = true;
            PurchaseButtonS.Visible = true;

            PaymentButtonS.Visible = false ;
            PrintPartyB.Visible = false;
            kryptonDataGridView1.Visible = false ;

            InvoiceLabel.Visible = false;
            InvoiceBox.Visible = false;
            CustButtonP.Visible = false;
            CustButtonS.Visible = false;
            kryptonDataGridView3.Visible = false;

            PaymentLabel1.Visible = false;
            CustLabel2.Visible = false;
            PurchasingLabel1.Visible = true ;

            PrintPurchaseB.Enabled = false;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }

        private void PurchaseButtonS_Click(object sender, EventArgs e)
        {           
            try
            {
                if (CheckBoxM.Checked == true)
                {
                    if (TextBoxYear.Text.Trim() == "")
                    {
                        MessageBox.Show("Fill Party Name , Year and Month", "Error");
                    }
                    else
                    {
                        SqlDataAdapter da = new SqlDataAdapter("select Date,Party_Name,Purchasing_Details,Amount from Temp_Party where Party_Name='" + PartyName.Text.Trim() + "' and Month='" + CombMonth.Text.Trim() + "'and Year='" + TextBoxYear.Text.Trim() + "'", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "login");
                        kryptonDataGridView2.DataSource = ds;
                        kryptonDataGridView2.DataMember = "login";

                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("delete from Print_PurchaseDetails", con);
                        SqlCommand cmd1 = new SqlCommand("insert into Print_PurchaseDetails select * from Temp_Party where Party_Name ='" + PartyName.Text.Trim() + "' and Month='" + CombMonth.Text.Trim() + "' and Year='" + TextBoxYear.Text.Trim() + "'", con);

                        int i1 = cmd2.ExecuteNonQuery();
                        int i2 = cmd1.ExecuteNonQuery(); ;
                        con.Close();
                        PrintPurchaseB.Enabled = true;
                    }
                }

                else if (CheckBoxD.Checked == true)
                {
                    SqlDataAdapter da = new SqlDataAdapter("select Date,Party_Name,Purchasing_Details,Amount from Temp_Party where Party_Name='" + PartyName.Text.Trim() + "' and Date  between '" + DateTime.Parse(FDate.Value.ToString()) + "' and '" + DateTime.Parse(TDate.Value.ToString()) + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "login");
                    kryptonDataGridView2.DataSource = ds;
                    kryptonDataGridView2.DataMember = "login";

                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("delete from Print_PurchaseDetails", con);
                    SqlCommand cmd1 = new SqlCommand("insert into Print_PurchaseDetails select * from Temp_Party where Party_Name ='" + PartyName.Text.Trim() + "' and Date  between '" + DateTime.Parse(FDate.Value.ToString()) + "' and '" + DateTime.Parse(TDate.Value.ToString()) + "'", con);

                    int i1 = cmd2.ExecuteNonQuery();
                    int i2 = cmd1.ExecuteNonQuery(); ;
                    con.Close();
                    PrintPurchaseB.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            InvoiceLabel.Visible = true ;
            InvoiceBox.Visible =true ;
            CustButtonP.Visible =true ;
            CustButtonS.Visible = true ;
            kryptonDataGridView3.Visible = true;


            PaymentButtonS.Visible = false;
            PrintPartyB.Visible = false;
            kryptonDataGridView1.Visible = false;


            PurchaseButtonS.Visible = false;
            PrintPurchaseB.Visible = false;
            kryptonDataGridView2.Visible = false;


            PNameLabel.Visible = false;
            PartyName.Visible = false;

            PaymentLabel1.Visible = false;
            CustLabel2.Visible = true ;
            PurchasingLabel1.Visible = false;

            CustButtonP.Enabled = false;
        }

        private void CustButtonS_Click(object sender, EventArgs e)
        {            
            try
            {
               if (CheckBoxM.Checked == true)
                {                    
                        SqlDataAdapter da = new SqlDataAdapter("select Date,Invoice_No,Cust_Name,Cust_Add,Product_Name,Product_Desc,Frame_No,Price from Sales_Details where Invoice_No='" + InvoiceBox.Text.Trim() + "' or Month='" + CombMonth.Text.Trim() + "'and Year='" + TextBoxYear.Text.Trim() + "'", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "login");
                        kryptonDataGridView3.DataSource = ds;
                        kryptonDataGridView3.DataMember = "login";

                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("delete from Print_SalesDetails", con);
                        SqlCommand cmd1 = new SqlCommand("insert into Print_SalesDetails(Invoice_No,Cust_Name,Cust_Add,Product_Name,Product_Desc,Qty,Frame_No,Price,Total) select Invoice_No,Cust_Name,Cust_Add,Product_Name,Product_Desc,Qty,Frame_No,Price,Price from Sales_Details where Invoice_No='" + InvoiceBox.Text.Trim() + "' ", con);

                        int i1 = cmd2.ExecuteNonQuery();
                        int i2 = cmd1.ExecuteNonQuery(); ;
                        con.Close();
                        CheckBoxM.Checked = false;
                        CustButtonP.Enabled = true;
                }

                else if (CheckBoxD.Checked == true)
                {
                    SqlDataAdapter da = new SqlDataAdapter("select Date,Invoice_No,Cust_Name,Cust_Add,Product_Name,Product_Desc,Frame_No,Price from Sales_Details where Invoice_No='" + InvoiceBox.Text.Trim() + "' or Date  between '" + DateTime.Parse(FDate.Value.ToString()).ToString("dd-MM-yy") + "' and '" + DateTime.Parse(TDate.Value.ToString()).ToString("dd-MM-yy") + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "login");
                    kryptonDataGridView3.DataSource = ds;
                    kryptonDataGridView3.DataMember = "login";

                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("delete from Print_SalesDetails", con);
                    SqlCommand cmd1 = new SqlCommand("insert into Print_SalesDetails(Invoice_No,Cust_Name,Cust_Add,Product_Name,Product_Desc,Qty,Frame_No,Price,Total) select Invoice_No,Cust_Name,Cust_Add,Product_Name,Product_Desc,Qty,Frame_No,Price,Price from Sales_Details where Invoice_No='" + InvoiceBox.Text.Trim() + "' ", con);

                    int i1 = cmd2.ExecuteNonQuery();
                    int i2 = cmd1.ExecuteNonQuery(); ;
                    con.Close();
                    CheckBoxM.Checked = false;
                    CustButtonP.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MonthLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBoxD_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxD.Checked == true)
            {
                YearLabel.Enabled = false;
                TextBoxYear.Enabled = false;
                MonthLabel.Enabled = false;
                CombMonth.Enabled = false;

                CheckBoxM.Checked = false;

                FDateLabel.Enabled = true;
                FDate.Enabled = true;
                TDateLabel.Enabled = true;
                TDate.Enabled = true;
            }
            else
            {
                FDateLabel.Enabled = false ;
                FDate.Enabled =false ;
                TDateLabel.Enabled = false ;
                TDate.Enabled = false ;
            }
        }

        private void CheckBoxM_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxM.Checked == true)
            {
                YearLabel.Enabled = true;
                TextBoxYear.Enabled = true;
                MonthLabel.Enabled = true;
                CombMonth.Enabled = true;

                CheckBoxD.Checked = false;

                FDateLabel.Enabled = false;
                FDate.Enabled = false;
                TDateLabel.Enabled = false;
                TDate.Enabled = false;
            }
            else
            {
                YearLabel.Enabled = false ;
                TextBoxYear.Enabled =false ;
                MonthLabel.Enabled = false ;
                CombMonth.Enabled = false ;

                TextBoxYear.Text = "";
            }
        }

        private void CustButtonP_Click(object sender, EventArgs e)
        {
            SalesReport r = new SalesReport();
            r.Show();
        }

        private void PrintPartyB_Click(object sender, EventArgs e)
        {
            Payment_Report r = new Payment_Report();
            r.Show();
        }

        private void PrintPurchaseB_Click(object sender, EventArgs e)
        {
            Purchasing_Report r = new Purchasing_Report();
            r.Show();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form6 r = new Form6();
            r.Show();
            this.Hide();
        }

        
    }
}
