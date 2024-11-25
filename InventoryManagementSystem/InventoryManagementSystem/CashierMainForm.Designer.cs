namespace InventoryManagementSystem
{
    partial class CashierMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            close = new Button();
            panel2 = new Panel();
            order_btn = new Button();
            pictureBox1 = new PictureBox();
            logout_btn = new Button();
            customers_btn = new Button();
            addProducts_btn = new Button();
            dashboard_btn = new Button();
            user_username = new Label();
            label2 = new Label();
            panel3 = new Panel();
            adminDashboard1 = new AdminDashboard();
            adminAddProducts1 = new AdminAddProducts();
            cashierCustomersForm1 = new CashierCustomersForm();
            cashierOrder1 = new CashierOrder();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 50);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(461, 19);
            label1.TabIndex = 1;
            label1.Text = "Salon Inventory Management System | Cashier's Portal";
            // 
            // close
            // 
            close.BackColor = Color.Red;
            close.FlatStyle = FlatStyle.Flat;
            close.ForeColor = Color.White;
            close.Location = new Point(1165, 12);
            close.Name = "close";
            close.Size = new Size(42, 22);
            close.TabIndex = 2;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(order_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(addProducts_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(user_username);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 684);
            panel2.TabIndex = 2;
            // 
            // order_btn
            // 
            order_btn.BackColor = Color.FromArgb(255, 192, 192);
            order_btn.FlatAppearance.BorderSize = 0;
            order_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            order_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            order_btn.FlatStyle = FlatStyle.Flat;
            order_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order_btn.Location = new Point(12, 395);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(199, 38);
            order_btn.TabIndex = 11;
            order_btn.Text = "Order";
            order_btn.UseVisualStyleBackColor = false;
            order_btn.Click += order_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo__1_;
            pictureBox1.Location = new Point(65, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(255, 224, 192);
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            logout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.Location = new Point(12, 632);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(199, 38);
            logout_btn.TabIndex = 7;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // customers_btn
            // 
            customers_btn.BackColor = Color.FromArgb(255, 192, 192);
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            customers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_btn.Location = new Point(12, 339);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(199, 38);
            customers_btn.TabIndex = 6;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = false;
            customers_btn.Click += customers_btn_Click;
            // 
            // addProducts_btn
            // 
            addProducts_btn.BackColor = Color.FromArgb(255, 192, 192);
            addProducts_btn.FlatAppearance.BorderSize = 0;
            addProducts_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addProducts_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addProducts_btn.FlatStyle = FlatStyle.Flat;
            addProducts_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProducts_btn.Location = new Point(12, 274);
            addProducts_btn.Name = "addProducts_btn";
            addProducts_btn.Size = new Size(199, 38);
            addProducts_btn.TabIndex = 5;
            addProducts_btn.Text = "Add Products";
            addProducts_btn.UseVisualStyleBackColor = false;
            addProducts_btn.Click += addProducts_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(255, 192, 192);
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_btn.Location = new Point(12, 215);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(199, 38);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // user_username
            // 
            user_username.AutoSize = true;
            user_username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_username.Location = new Point(81, 154);
            user_username.Name = "user_username";
            user_username.Size = new Size(53, 20);
            user_username.TabIndex = 1;
            user_username.Text = "Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 154);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 0;
            label2.Text = "Welcome, ";
            // 
            // panel3
            // 
            panel3.Controls.Add(adminDashboard1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierCustomersForm1);
            panel3.Controls.Add(cashierOrder1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(225, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(994, 684);
            panel3.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(0, 0);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(994, 682);
            adminDashboard1.TabIndex = 3;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(994, 682);
            adminAddProducts1.TabIndex = 2;
            // 
            // cashierCustomersForm1
            // 
            cashierCustomersForm1.Location = new Point(0, 0);
            cashierCustomersForm1.Name = "cashierCustomersForm1";
            cashierCustomersForm1.Size = new Size(994, 682);
            cashierCustomersForm1.TabIndex = 1;
            // 
            // cashierOrder1
            // 
            cashierOrder1.Location = new Point(0, 0);
            cashierOrder1.Name = "cashierOrder1";
            cashierOrder1.Size = new Size(994, 682);
            cashierOrder1.TabIndex = 0;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 734);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button close;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button logout_btn;
        private Button customers_btn;
        private Button addProducts_btn;
        private Button dashboard_btn;
        private Label user_username;
        private Label label2;
        private Button order_btn;
        private Panel panel3;
        private AdminDashboard adminDashboard1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomersForm cashierCustomersForm1;
        private CashierOrder cashierOrder1;
    }
}