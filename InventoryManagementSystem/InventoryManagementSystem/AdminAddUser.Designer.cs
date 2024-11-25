namespace InventoryManagementSystem
{
    partial class AdminAddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            addUsers_status = new ComboBox();
            label5 = new Label();
            addUsers_clearBtn = new Button();
            addUsers_removeBtn = new Button();
            addUsers_updateBtn = new Button();
            addUsers_addBtn = new Button();
            addUsers_role = new ComboBox();
            label3 = new Label();
            addUsers_password = new TextBox();
            label2 = new Label();
            addUsers_username = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addUsers_status);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(addUsers_clearBtn);
            panel1.Controls.Add(addUsers_removeBtn);
            panel1.Controls.Add(addUsers_updateBtn);
            panel1.Controls.Add(addUsers_addBtn);
            panel1.Controls.Add(addUsers_role);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUsers_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addUsers_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 649);
            panel1.TabIndex = 2;
            // 
            // addUsers_status
            // 
            addUsers_status.FormattingEnabled = true;
            addUsers_status.Items.AddRange(new object[] { "Active", "Inactive", "Approval" });
            addUsers_status.Location = new Point(18, 286);
            addUsers_status.Name = "addUsers_status";
            addUsers_status.Size = new Size(268, 23);
            addUsers_status.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 263);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "Status";
            // 
            // addUsers_clearBtn
            // 
            addUsers_clearBtn.BackColor = Color.FromArgb(255, 192, 192);
            addUsers_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addUsers_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addUsers_clearBtn.FlatStyle = FlatStyle.Flat;
            addUsers_clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUsers_clearBtn.Location = new Point(163, 399);
            addUsers_clearBtn.Name = "addUsers_clearBtn";
            addUsers_clearBtn.Size = new Size(110, 43);
            addUsers_clearBtn.TabIndex = 9;
            addUsers_clearBtn.Text = "Clear";
            addUsers_clearBtn.UseVisualStyleBackColor = false;
            addUsers_clearBtn.Click += addUsers_clearBtn_Click;
            // 
            // addUsers_removeBtn
            // 
            addUsers_removeBtn.BackColor = Color.FromArgb(255, 192, 192);
            addUsers_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addUsers_removeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addUsers_removeBtn.FlatStyle = FlatStyle.Flat;
            addUsers_removeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUsers_removeBtn.Location = new Point(20, 399);
            addUsers_removeBtn.Name = "addUsers_removeBtn";
            addUsers_removeBtn.Size = new Size(110, 43);
            addUsers_removeBtn.TabIndex = 8;
            addUsers_removeBtn.Text = "Remove";
            addUsers_removeBtn.UseVisualStyleBackColor = false;
            addUsers_removeBtn.Click += addUsers_removeBtn_Click;
            // 
            // addUsers_updateBtn
            // 
            addUsers_updateBtn.BackColor = Color.FromArgb(255, 192, 192);
            addUsers_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addUsers_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addUsers_updateBtn.FlatStyle = FlatStyle.Flat;
            addUsers_updateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUsers_updateBtn.Location = new Point(163, 330);
            addUsers_updateBtn.Name = "addUsers_updateBtn";
            addUsers_updateBtn.Size = new Size(110, 43);
            addUsers_updateBtn.TabIndex = 7;
            addUsers_updateBtn.Text = "Update";
            addUsers_updateBtn.UseVisualStyleBackColor = false;
            addUsers_updateBtn.Click += addUsers_updateBtn_Click;
            // 
            // addUsers_addBtn
            // 
            addUsers_addBtn.BackColor = Color.FromArgb(255, 192, 192);
            addUsers_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addUsers_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addUsers_addBtn.FlatStyle = FlatStyle.Flat;
            addUsers_addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUsers_addBtn.Location = new Point(20, 330);
            addUsers_addBtn.Name = "addUsers_addBtn";
            addUsers_addBtn.Size = new Size(110, 43);
            addUsers_addBtn.TabIndex = 6;
            addUsers_addBtn.Text = "Add";
            addUsers_addBtn.UseVisualStyleBackColor = false;
            addUsers_addBtn.Click += addUsers_addBtn_Click;
            // 
            // addUsers_role
            // 
            addUsers_role.FormattingEnabled = true;
            addUsers_role.Items.AddRange(new object[] { "Admin", "Cashier" });
            addUsers_role.Location = new Point(18, 218);
            addUsers_role.Name = "addUsers_role";
            addUsers_role.Size = new Size(268, 23);
            addUsers_role.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 195);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // addUsers_password
            // 
            addUsers_password.Location = new Point(18, 155);
            addUsers_password.Name = "addUsers_password";
            addUsers_password.Size = new Size(268, 23);
            addUsers_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 123);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // addUsers_username
            // 
            addUsers_username.Location = new Point(18, 79);
            addUsers_username.Name = "addUsers_username";
            addUsers_username.Size = new Size(268, 23);
            addUsers_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 47);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(342, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 649);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(601, 583);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 1;
            label4.Text = "All User's Data";
            // 
            // AdminAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminAddUser";
            Size = new Size(994, 682);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox addUsers_status;
        private Label label5;
        private Button addUsers_clearBtn;
        private Button addUsers_removeBtn;
        private Button addUsers_updateBtn;
        private Button addUsers_addBtn;
        private ComboBox addUsers_role;
        private Label label3;
        private TextBox addUsers_password;
        private Label label2;
        private TextBox addUsers_username;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label4;
    }
}
