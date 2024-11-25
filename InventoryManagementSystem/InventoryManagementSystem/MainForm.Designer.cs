namespace InventoryManagementSystem
{
    partial class MainForm
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
            pictureBox1 = new PictureBox();
            button6 = new Button();
            customers_btn = new Button();
            addProducts_btn = new Button();
            addCategories_btn = new Button();
            addUsers_btn = new Button();
            dashboard_btn = new Button();
            user_username = new Label();
            label2 = new Label();
            panel3 = new Panel();
            adminDashboard1 = new AdminDashboard();
            adminAddUser1 = new AdminAddUser();
            adminAddCategories1 = new AdminAddCategories();
            adminAddProducts1 = new AdminAddProducts();
            cashierCustomersForm1 = new CashierCustomersForm();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(313, 19);
            label1.TabIndex = 1;
            label1.Text = "Salon Inventory Management System";
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
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(addProducts_btn);
            panel2.Controls.Add(addCategories_btn);
            panel2.Controls.Add(addUsers_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(user_username);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 682);
            panel2.TabIndex = 1;
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
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 224, 192);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(12, 632);
            button6.Name = "button6";
            button6.Size = new Size(199, 38);
            button6.TabIndex = 7;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // customers_btn
            // 
            customers_btn.BackColor = Color.FromArgb(255, 192, 192);
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            customers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_btn.Location = new Point(12, 479);
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
            addProducts_btn.Location = new Point(12, 414);
            addProducts_btn.Name = "addProducts_btn";
            addProducts_btn.Size = new Size(199, 38);
            addProducts_btn.TabIndex = 5;
            addProducts_btn.Text = "Add Products";
            addProducts_btn.UseVisualStyleBackColor = false;
            addProducts_btn.Click += addProducts_btn_Click;
            // 
            // addCategories_btn
            // 
            addCategories_btn.BackColor = Color.FromArgb(255, 192, 192);
            addCategories_btn.FlatAppearance.BorderSize = 0;
            addCategories_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addCategories_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addCategories_btn.FlatStyle = FlatStyle.Flat;
            addCategories_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCategories_btn.Location = new Point(12, 345);
            addCategories_btn.Name = "addCategories_btn";
            addCategories_btn.Size = new Size(199, 38);
            addCategories_btn.TabIndex = 4;
            addCategories_btn.Text = "Add Categories";
            addCategories_btn.UseVisualStyleBackColor = false;
            addCategories_btn.Click += addCategories_btn_Click;
            // 
            // addUsers_btn
            // 
            addUsers_btn.BackColor = Color.FromArgb(255, 192, 192);
            addUsers_btn.FlatAppearance.BorderSize = 0;
            addUsers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addUsers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addUsers_btn.FlatStyle = FlatStyle.Flat;
            addUsers_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUsers_btn.Location = new Point(12, 284);
            addUsers_btn.Name = "addUsers_btn";
            addUsers_btn.Size = new Size(199, 38);
            addUsers_btn.TabIndex = 3;
            addUsers_btn.Text = "Add Users";
            addUsers_btn.UseVisualStyleBackColor = false;
            addUsers_btn.Click += addUsers_btn_Click;
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
            dashboard_btn.Click += button1_Click;
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
            panel3.Controls.Add(adminAddUser1);
            panel3.Controls.Add(adminAddCategories1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierCustomersForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(225, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(994, 682);
            panel3.TabIndex = 2;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(-3, 0);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(994, 682);
            adminDashboard1.TabIndex = 4;
            // 
            // adminAddUser1
            // 
            adminAddUser1.Location = new Point(0, 0);
            adminAddUser1.Name = "adminAddUser1";
            adminAddUser1.Size = new Size(994, 682);
            adminAddUser1.TabIndex = 3;
            // 
            // adminAddCategories1
            // 
            adminAddCategories1.Location = new Point(0, 0);
            adminAddCategories1.Name = "adminAddCategories1";
            adminAddCategories1.Size = new Size(994, 682);
            adminAddCategories1.TabIndex = 2;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(994, 682);
            adminAddProducts1.TabIndex = 1;
            // 
            // cashierCustomersForm1
            // 
            cashierCustomersForm1.Location = new Point(0, 0);
            cashierCustomersForm1.Name = "cashierCustomersForm1";
            cashierCustomersForm1.Size = new Size(994, 682);
            cashierCustomersForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 732);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
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
        private Button close;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button dashboard_btn;
        private Label user_username;
        private Button addProducts_btn;
        private Button addCategories_btn;
        private Button addUsers_btn;
        private Button button6;
        private Button customers_btn;
        private Panel panel3;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AdminDashboard adminDashboard1;
        private AdminAddUser adminAddUser1;
        private AdminAddCategories adminAddCategories1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomersForm cashierCustomersForm1;
    }
}