namespace InventoryManagementSystem
{
    partial class AdminAddProducts
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            addProducts_clearBtn = new Button();
            addProducts_removeBtn = new Button();
            addProducts_updateBtn = new Button();
            addProducts_addBtn = new Button();
            addProducts_importBtn = new Button();
            panel3 = new Panel();
            addProducts_imageView = new PictureBox();
            addProducts_status = new ComboBox();
            label7 = new Label();
            addProducts_stock = new TextBox();
            label6 = new Label();
            addProducts_price = new TextBox();
            label5 = new Label();
            addProducts_category = new ComboBox();
            label4 = new Label();
            addProducts_prodName = new TextBox();
            label3 = new Label();
            addProducts_prodID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addProducts_imageView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 364);
            panel1.TabIndex = 0;
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
            dataGridView1.Location = new Point(20, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(928, 295);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 1;
            label1.Text = "All Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(addProducts_clearBtn);
            panel2.Controls.Add(addProducts_removeBtn);
            panel2.Controls.Add(addProducts_updateBtn);
            panel2.Controls.Add(addProducts_addBtn);
            panel2.Controls.Add(addProducts_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(addProducts_status);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(addProducts_stock);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addProducts_price);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addProducts_category);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addProducts_prodName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addProducts_prodID);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 272);
            panel2.TabIndex = 1;
            // 
            // addProducts_clearBtn
            // 
            addProducts_clearBtn.BackColor = Color.FromArgb(255, 192, 192);
            addProducts_clearBtn.FlatAppearance.BorderSize = 0;
            addProducts_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addProducts_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addProducts_clearBtn.FlatStyle = FlatStyle.Flat;
            addProducts_clearBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            addProducts_clearBtn.Location = new Point(516, 187);
            addProducts_clearBtn.Name = "addProducts_clearBtn";
            addProducts_clearBtn.Size = new Size(110, 42);
            addProducts_clearBtn.TabIndex = 17;
            addProducts_clearBtn.Text = "Clear";
            addProducts_clearBtn.UseVisualStyleBackColor = false;
            addProducts_clearBtn.Click += addProducts_clearBtn_Click;
            // 
            // addProducts_removeBtn
            // 
            addProducts_removeBtn.BackColor = Color.FromArgb(255, 192, 192);
            addProducts_removeBtn.FlatAppearance.BorderSize = 0;
            addProducts_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addProducts_removeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addProducts_removeBtn.FlatStyle = FlatStyle.Flat;
            addProducts_removeBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            addProducts_removeBtn.Location = new Point(369, 187);
            addProducts_removeBtn.Name = "addProducts_removeBtn";
            addProducts_removeBtn.Size = new Size(110, 42);
            addProducts_removeBtn.TabIndex = 16;
            addProducts_removeBtn.Text = "Remove";
            addProducts_removeBtn.UseVisualStyleBackColor = false;
            addProducts_removeBtn.Click += addProducts_removeBtn_Click;
            // 
            // addProducts_updateBtn
            // 
            addProducts_updateBtn.BackColor = Color.FromArgb(255, 192, 192);
            addProducts_updateBtn.FlatAppearance.BorderSize = 0;
            addProducts_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addProducts_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addProducts_updateBtn.FlatStyle = FlatStyle.Flat;
            addProducts_updateBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            addProducts_updateBtn.Location = new Point(215, 187);
            addProducts_updateBtn.Name = "addProducts_updateBtn";
            addProducts_updateBtn.Size = new Size(110, 42);
            addProducts_updateBtn.TabIndex = 15;
            addProducts_updateBtn.Text = "Update";
            addProducts_updateBtn.UseVisualStyleBackColor = false;
            addProducts_updateBtn.Click += addProducts_updateBtn_Click;
            // 
            // addProducts_addBtn
            // 
            addProducts_addBtn.BackColor = Color.FromArgb(255, 192, 192);
            addProducts_addBtn.FlatAppearance.BorderSize = 0;
            addProducts_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addProducts_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addProducts_addBtn.FlatStyle = FlatStyle.Flat;
            addProducts_addBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            addProducts_addBtn.Location = new Point(68, 187);
            addProducts_addBtn.Name = "addProducts_addBtn";
            addProducts_addBtn.Size = new Size(110, 42);
            addProducts_addBtn.TabIndex = 14;
            addProducts_addBtn.Text = "Add";
            addProducts_addBtn.UseVisualStyleBackColor = false;
            addProducts_addBtn.Click += addProducts_addBtn_Click;
            // 
            // addProducts_importBtn
            // 
            addProducts_importBtn.BackColor = Color.FromArgb(255, 192, 192);
            addProducts_importBtn.FlatAppearance.BorderSize = 0;
            addProducts_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addProducts_importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addProducts_importBtn.FlatStyle = FlatStyle.Flat;
            addProducts_importBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_importBtn.Location = new Point(848, 145);
            addProducts_importBtn.Name = "addProducts_importBtn";
            addProducts_importBtn.Size = new Size(89, 25);
            addProducts_importBtn.TabIndex = 13;
            addProducts_importBtn.Text = "Import";
            addProducts_importBtn.UseVisualStyleBackColor = false;
            addProducts_importBtn.Click += addProducts_importBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(addProducts_imageView);
            panel3.Location = new Point(848, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(89, 114);
            panel3.TabIndex = 12;
            // 
            // addProducts_imageView
            // 
            addProducts_imageView.Location = new Point(0, 0);
            addProducts_imageView.Name = "addProducts_imageView";
            addProducts_imageView.Size = new Size(89, 114);
            addProducts_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            addProducts_imageView.TabIndex = 0;
            addProducts_imageView.TabStop = false;
            // 
            // addProducts_status
            // 
            addProducts_status.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_status.FormattingEnabled = true;
            addProducts_status.Items.AddRange(new object[] { "Available", "Not Available" });
            addProducts_status.Location = new Point(485, 111);
            addProducts_status.Name = "addProducts_status";
            addProducts_status.Size = new Size(175, 28);
            addProducts_status.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(424, 118);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 10;
            label7.Text = "Status:";
            label7.Click += label7_Click;
            // 
            // addProducts_stock
            // 
            addProducts_stock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_stock.Location = new Point(485, 67);
            addProducts_stock.Name = "addProducts_stock";
            addProducts_stock.Size = new Size(175, 27);
            addProducts_stock.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(429, 73);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 8;
            label6.Text = "Stock:";
            // 
            // addProducts_price
            // 
            addProducts_price.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_price.Location = new Point(485, 25);
            addProducts_price.Name = "addProducts_price";
            addProducts_price.Size = new Size(175, 27);
            addProducts_price.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(405, 31);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 6;
            label5.Text = " Price (P):";
            // 
            // addProducts_category
            // 
            addProducts_category.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_category.FormattingEnabled = true;
            addProducts_category.Location = new Point(150, 111);
            addProducts_category.Name = "addProducts_category";
            addProducts_category.Size = new Size(175, 28);
            addProducts_category.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 118);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 4;
            label4.Text = "Category:";
            label4.Click += label4_Click;
            // 
            // addProducts_prodName
            // 
            addProducts_prodName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_prodName.Location = new Point(150, 67);
            addProducts_prodName.Name = "addProducts_prodName";
            addProducts_prodName.Size = new Size(175, 27);
            addProducts_prodName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 73);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // addProducts_prodID
            // 
            addProducts_prodID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_prodID.Location = new Point(150, 25);
            addProducts_prodID.Name = "addProducts_prodID";
            addProducts_prodID.Size = new Size(114, 27);
            addProducts_prodID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 31);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 0;
            label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(994, 682);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addProducts_imageView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox addProducts_prodID;
        private Label label2;
        private Label label4;
        private TextBox addProducts_prodName;
        private Label label3;
        private ComboBox addProducts_category;
        private TextBox addProducts_price;
        private Label label5;
        private ComboBox addProducts_status;
        private Label label7;
        private TextBox addProducts_stock;
        private Label label6;
        private Button addProducts_importBtn;
        private Panel panel3;
        private PictureBox addProducts_imageView;
        private Button addProducts_clearBtn;
        private Button addProducts_removeBtn;
        private Button addProducts_updateBtn;
        private Button addProducts_addBtn;
        private DataGridView dataGridView1;
    }
}
