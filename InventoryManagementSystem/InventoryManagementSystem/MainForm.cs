﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayUsername();


        }

        public void displayUsername()
        {
            if (!string.IsNullOrEmpty(Form1.username))
            {
                string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1);
                user_username.Text = username;
            }
            else
            {
                MessageBox.Show("Username is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if(adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void addUsers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;

            AdminAddUser aauForm = adminAddUser1 as AdminAddUser;

            if (aauForm != null)
            {
                aauForm.refreshData();
            }

        }

        private void addCategories_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;

            AdminAddCategories aacForm = adminAddCategories1 as AdminAddCategories;

            if (aacForm != null)
            {
                aacForm.refreshData();
            }

        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomersForm1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = true;

            CashierCustomersForm ccfForm = cashierCustomersForm1 as CashierCustomersForm;

            if (ccfForm != null)
            {
                ccfForm.refreshData();
            }
        }

        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }

   
    }
}