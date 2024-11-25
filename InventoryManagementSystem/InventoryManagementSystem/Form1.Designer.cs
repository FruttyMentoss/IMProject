namespace InventoryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            login_showPass = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            register_label = new Label();
            label2 = new Label();
            login_btn = new Button();
            login_password = new TextBox();
            login_username = new TextBox();
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
            panel1.Controls.Add(login_showPass);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(register_label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(159, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 392);
            panel1.TabIndex = 0;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(272, 244);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(108, 19);
            login_showPass.TabIndex = 8;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 208);
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
            label4.Click += label4_Click;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.Cursor = Cursors.Hand;
            register_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_label.ForeColor = Color.FromArgb(0, 192, 192);
            register_label.Location = new Point(228, 358);
            register_label.Name = "register_label";
            register_label.Size = new Size(86, 17);
            register_label.TabIndex = 5;
            register_label.Text = "Register here";
            register_label.Click += register_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 358);
            label2.Name = "label2";
            label2.Size = new Size(143, 17);
            label2.TabIndex = 4;
            label2.Text = "Don't have an account?";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(255, 192, 192);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(135, 286);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(214, 51);
            login_btn.TabIndex = 3;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(135, 200);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(245, 23);
            login_password.TabIndex = 2;
            // 
            // login_username
            // 
            login_username.Location = new Point(135, 148);
            login_username.Name = "login_username";
            login_username.Size = new Size(245, 23);
            login_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 104);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 0;
            label1.Text = "Login Account";
            // 
            // close
            // 
            close.BackColor = Color.Red;
            close.FlatStyle = FlatStyle.Flat;
            close.ForeColor = Color.White;
            close.Location = new Point(750, 12);
            close.Name = "close";
            close.Size = new Size(42, 22);
            close.TabIndex = 1;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo__1_;
            pictureBox1.Location = new Point(197, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(804, 489);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button close;
        private Button login_btn;
        private TextBox login_password;
        private TextBox login_username;
        private Label register_label;
        private Label label2;
        private Label label5;
        private Label label4;
        private CheckBox login_showPass;
        private PictureBox pictureBox1;
    }
}
