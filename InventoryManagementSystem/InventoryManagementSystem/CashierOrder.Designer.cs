namespace InventoryManagementSystem
{
    partial class CashierOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            cashierOrder_clearBtn = new Button();
            cashierOrder_removeBtn = new Button();
            cashierOrder_addBtn = new Button();
            cashierOrder_qty = new NumericUpDown();
            label8 = new Label();
            cashierOrder_price = new Label();
            label7 = new Label();
            cashierOrder_prodName = new Label();
            label3 = new Label();
            cashierOrder_prodID = new ComboBox();
            label2 = new Label();
            cashierOrder_category = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            cashierOrder_receipt = new Button();
            cashierOrder_payOrders = new Button();
            cashierOrder_change = new Label();
            label13 = new Label();
            cashierOrder_amount = new TextBox();
            label10 = new Label();
            cashierOrder_totalprice = new Label();
            label12 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(18, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 318);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(582, 257);
            dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 16);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 2;
            label4.Text = "Available Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cashierOrder_clearBtn);
            panel2.Controls.Add(cashierOrder_removeBtn);
            panel2.Controls.Add(cashierOrder_addBtn);
            panel2.Controls.Add(cashierOrder_qty);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cashierOrder_price);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cashierOrder_prodName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cashierOrder_prodID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cashierOrder_category);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(18, 351);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 318);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 21);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 18;
            label5.Text = "Select Orders";
            // 
            // cashierOrder_clearBtn
            // 
            cashierOrder_clearBtn.BackColor = Color.FromArgb(255, 192, 192);
            cashierOrder_clearBtn.FlatAppearance.BorderSize = 0;
            cashierOrder_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_clearBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_clearBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cashierOrder_clearBtn.Location = new Point(424, 248);
            cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            cashierOrder_clearBtn.Size = new Size(110, 42);
            cashierOrder_clearBtn.TabIndex = 17;
            cashierOrder_clearBtn.Text = "Clear";
            cashierOrder_clearBtn.UseVisualStyleBackColor = false;
            cashierOrder_clearBtn.Click += cashierOrder_clearBtn_Click;
            // 
            // cashierOrder_removeBtn
            // 
            cashierOrder_removeBtn.BackColor = Color.FromArgb(255, 192, 192);
            cashierOrder_removeBtn.FlatAppearance.BorderSize = 0;
            cashierOrder_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_removeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_removeBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_removeBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cashierOrder_removeBtn.Location = new Point(252, 248);
            cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            cashierOrder_removeBtn.Size = new Size(110, 42);
            cashierOrder_removeBtn.TabIndex = 16;
            cashierOrder_removeBtn.Text = "Remove";
            cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            cashierOrder_removeBtn.Click += cashierOrder_removeBtn_Click;
            // 
            // cashierOrder_addBtn
            // 
            cashierOrder_addBtn.BackColor = Color.FromArgb(255, 192, 192);
            cashierOrder_addBtn.FlatAppearance.BorderSize = 0;
            cashierOrder_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_addBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_addBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cashierOrder_addBtn.Location = new Point(79, 248);
            cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            cashierOrder_addBtn.Size = new Size(110, 42);
            cashierOrder_addBtn.TabIndex = 15;
            cashierOrder_addBtn.Text = "Add";
            cashierOrder_addBtn.UseVisualStyleBackColor = false;
            cashierOrder_addBtn.Click += cashierOrder_addBtn_Click;
            // 
            // cashierOrder_qty
            // 
            cashierOrder_qty.Location = new Point(424, 139);
            cashierOrder_qty.Name = "cashierOrder_qty";
            cashierOrder_qty.Size = new Size(148, 23);
            cashierOrder_qty.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(344, 142);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 11;
            label8.Text = "Quantity:";
            // 
            // cashierOrder_price
            // 
            cashierOrder_price.AutoSize = true;
            cashierOrder_price.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_price.Location = new Point(149, 181);
            cashierOrder_price.Name = "cashierOrder_price";
            cashierOrder_price.Size = new Size(77, 20);
            cashierOrder_price.TabIndex = 10;
            cashierOrder_price.Text = "Category:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(96, 181);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 9;
            label7.Text = "Price:";
            // 
            // cashierOrder_prodName
            // 
            cashierOrder_prodName.AutoSize = true;
            cashierOrder_prodName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_prodName.Location = new Point(149, 142);
            cashierOrder_prodName.Name = "cashierOrder_prodName";
            cashierOrder_prodName.Size = new Size(77, 20);
            cashierOrder_prodName.TabIndex = 8;
            cashierOrder_prodName.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 142);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 7;
            label3.Text = "Product Name: ";
            // 
            // cashierOrder_prodID
            // 
            cashierOrder_prodID.FormattingEnabled = true;
            cashierOrder_prodID.Location = new Point(424, 90);
            cashierOrder_prodID.Name = "cashierOrder_prodID";
            cashierOrder_prodID.Size = new Size(148, 23);
            cashierOrder_prodID.TabIndex = 6;
            cashierOrder_prodID.SelectedIndexChanged += cashierOrder_prodID_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 93);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "Product ID:";
            // 
            // cashierOrder_category
            // 
            cashierOrder_category.FormattingEnabled = true;
            cashierOrder_category.Location = new Point(114, 90);
            cashierOrder_category.Name = "cashierOrder_category";
            cashierOrder_category.Size = new Size(148, 23);
            cashierOrder_category.TabIndex = 4;
            cashierOrder_category.SelectedIndexChanged += cashierOrder_category_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 93);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "Category:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(cashierOrder_receipt);
            panel3.Controls.Add(cashierOrder_payOrders);
            panel3.Controls.Add(cashierOrder_change);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cashierOrder_amount);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(cashierOrder_totalprice);
            panel3.Controls.Add(label12);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(641, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 651);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(18, 16);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 19;
            label14.Text = "All Orders";
            // 
            // cashierOrder_receipt
            // 
            cashierOrder_receipt.BackColor = Color.FromArgb(255, 192, 192);
            cashierOrder_receipt.FlatAppearance.BorderSize = 0;
            cashierOrder_receipt.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_receipt.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_receipt.FlatStyle = FlatStyle.Flat;
            cashierOrder_receipt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cashierOrder_receipt.Location = new Point(18, 581);
            cashierOrder_receipt.Name = "cashierOrder_receipt";
            cashierOrder_receipt.Size = new Size(302, 47);
            cashierOrder_receipt.TabIndex = 18;
            cashierOrder_receipt.Text = "Receipt";
            cashierOrder_receipt.UseVisualStyleBackColor = false;
            cashierOrder_receipt.Click += cashierOrder_receipt_Click;
            // 
            // cashierOrder_payOrders
            // 
            cashierOrder_payOrders.BackColor = Color.FromArgb(255, 192, 192);
            cashierOrder_payOrders.FlatAppearance.BorderSize = 0;
            cashierOrder_payOrders.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_payOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            cashierOrder_payOrders.FlatStyle = FlatStyle.Flat;
            cashierOrder_payOrders.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cashierOrder_payOrders.Location = new Point(18, 506);
            cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            cashierOrder_payOrders.Size = new Size(302, 48);
            cashierOrder_payOrders.TabIndex = 17;
            cashierOrder_payOrders.Text = "Pay Orders";
            cashierOrder_payOrders.UseVisualStyleBackColor = false;
            cashierOrder_payOrders.Click += cashierOrder_payOrders_Click;
            // 
            // cashierOrder_change
            // 
            cashierOrder_change.AutoSize = true;
            cashierOrder_change.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_change.Location = new Point(169, 437);
            cashierOrder_change.Name = "cashierOrder_change";
            cashierOrder_change.Size = new Size(40, 20);
            cashierOrder_change.TabIndex = 16;
            cashierOrder_change.Text = "0.00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(98, 437);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 15;
            label13.Text = "Change:";
            // 
            // cashierOrder_amount
            // 
            cashierOrder_amount.Location = new Point(169, 390);
            cashierOrder_amount.Name = "cashierOrder_amount";
            cashierOrder_amount.Size = new Size(151, 23);
            cashierOrder_amount.TabIndex = 14;
            cashierOrder_amount.KeyDown += cashierOrder_amount_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(92, 393);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 13;
            label10.Text = "Amount:";
            // 
            // cashierOrder_totalprice
            // 
            cashierOrder_totalprice.AutoSize = true;
            cashierOrder_totalprice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_totalprice.Location = new Point(169, 354);
            cashierOrder_totalprice.Name = "cashierOrder_totalprice";
            cashierOrder_totalprice.Size = new Size(40, 20);
            cashierOrder_totalprice.TabIndex = 12;
            cashierOrder_totalprice.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(77, 354);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 11;
            label12.Text = "Total Price:";
            label12.Click += label12_Click;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(659, 67);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(302, 257);
            dataGridView2.TabIndex = 20;
            dataGridView2.CellClick += dataGridView2_CellClick_1;
            // 
            // CashierOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CashierOrder";
            Size = new Size(994, 682);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private ComboBox cashierOrder_category;
        private Label label1;
        private NumericUpDown cashierOrder_qty;
        private Label label8;
        private Label cashierOrder_price;
        private Label label7;
        private Label cashierOrder_prodName;
        private Label label3;
        private ComboBox cashierOrder_prodID;
        private Label label2;
        private Button cashierOrder_clearBtn;
        private Button cashierOrder_removeBtn;
        private Button cashierOrder_addBtn;
        private Label label10;
        private Label cashierOrder_totalprice;
        private Label label12;
        private TextBox cashierOrder_amount;
        private Label label14;
        private Button cashierOrder_receipt;
        private Button cashierOrder_payOrders;
        private Label cashierOrder_change;
        private Label label13;
        private Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}
