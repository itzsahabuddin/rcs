using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RajCycleStores
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Form4 r = new Form4();
            r.Show();
            this.Hide();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            r.Show();
            this.Hide();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Form2 r = new Form2();
            r.Show();
            this.Hide();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Form3 r = new Form3();
            r.Show();
            this.Hide();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            Form5 r = new Form5();
            r.Show();
            this.Hide();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Form7 r = new Form7();
            r.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            Login r = new Login();
            r.Show();
            this.Hide();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            ChangePasswd r = new ChangePasswd();
            r.Show();
        }
    }
}
