namespace InventoryManagementSystem
{
    partial class RegisterForm
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
            register_showPass = new CheckBox();
            label3 = new Label();
            register_cPassword = new TextBox();
            label5 = new Label();
            label4 = new Label();
            login_label = new Label();
            label2 = new Label();
            signup_btn = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            label1 = new Label();
            close = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(register_showPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(register_cPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(login_label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(signup_btn);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(167, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 419);
            panel1.TabIndex = 2;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Location = new Point(272, 264);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(108, 19);
            register_showPass.TabIndex = 10;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 243);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 9;
            label3.Text = "Confirm Password";
            // 
            // register_cPassword
            // 
            register_cPassword.Location = new Point(135, 235);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(245, 23);
            register_cPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 201);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 151);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Username";
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Cursor = Cursors.Hand;
            login_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_label.ForeColor = Color.FromArgb(0, 192, 192);
            login_label.Location = new Point(241, 373);
            login_label.Name = "login_label";
            login_label.Size = new Size(40, 17);
            login_label.TabIndex = 5;
            login_label.Text = "Login";
            login_label.Click += login_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 373);
            label2.Name = "label2";
            label2.Size = new Size(156, 17);
            label2.TabIndex = 4;
            label2.Text = "Already have an account?";
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(255, 192, 192);
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.Location = new Point(152, 299);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(214, 51);
            signup_btn.TabIndex = 3;
            signup_btn.Text = "Sign up";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // register_password
            // 
            register_password.Location = new Point(135, 193);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(245, 23);
            register_password.TabIndex = 2;
            // 
            // register_username
            // 
            register_username.Location = new Point(135, 148);
            register_username.Name = "register_username";
            register_username.Size = new Size(245, 23);
            register_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 110);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 0;
            label1.Text = "Register Account";
            // 
            // close
            // 
            close.BackColor = Color.Red;
            close.FlatStyle = FlatStyle.Flat;
            close.ForeColor = Color.White;
            close.Location = new Point(754, 7);
            close.Name = "close";
            close.Size = new Size(42, 22);
            close.TabIndex = 3;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo__1_;
            pictureBox1.Location = new Point(201, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(804, 489);
            Controls.Add(panel1);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label login_label;
        private Label label2;
        private Button signup_btn;
        private TextBox register_password;
        private TextBox register_username;
        private Label label1;
        private Button close;
        private Label label3;
        private TextBox register_cPassword;
        private CheckBox register_showPass;
        private PictureBox pictureBox1;
    }
}