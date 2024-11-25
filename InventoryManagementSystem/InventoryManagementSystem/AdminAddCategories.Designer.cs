namespace InventoryManagementSystem
{
    partial class AdminAddCategories
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
            addCategories_clearBtn = new Button();
            addCategories_removeBtn = new Button();
            addCategories_updateBtn = new Button();
            addCategories_addBtn = new Button();
            addCategories_category = new TextBox();
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
            panel1.Controls.Add(addCategories_clearBtn);
            panel1.Controls.Add(addCategories_removeBtn);
            panel1.Controls.Add(addCategories_updateBtn);
            panel1.Controls.Add(addCategories_addBtn);
            panel1.Controls.Add(addCategories_category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 649);
            panel1.TabIndex = 4;
            // 
            // addCategories_clearBtn
            // 
            addCategories_clearBtn.BackColor = Color.FromArgb(255, 192, 192);
            addCategories_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addCategories_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addCategories_clearBtn.FlatStyle = FlatStyle.Flat;
            addCategories_clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCategories_clearBtn.Location = new Point(163, 198);
            addCategories_clearBtn.Name = "addCategories_clearBtn";
            addCategories_clearBtn.Size = new Size(110, 43);
            addCategories_clearBtn.TabIndex = 9;
            addCategories_clearBtn.Text = "Clear";
            addCategories_clearBtn.UseVisualStyleBackColor = false;
            addCategories_clearBtn.Click += addCategories_clearBtn_Click;
            // 
            // addCategories_removeBtn
            // 
            addCategories_removeBtn.BackColor = Color.FromArgb(255, 192, 192);
            addCategories_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addCategories_removeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addCategories_removeBtn.FlatStyle = FlatStyle.Flat;
            addCategories_removeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCategories_removeBtn.Location = new Point(20, 198);
            addCategories_removeBtn.Name = "addCategories_removeBtn";
            addCategories_removeBtn.Size = new Size(110, 43);
            addCategories_removeBtn.TabIndex = 8;
            addCategories_removeBtn.Text = "Remove";
            addCategories_removeBtn.UseVisualStyleBackColor = false;
            addCategories_removeBtn.Click += addCategories_removeBtn_Click;
            // 
            // addCategories_updateBtn
            // 
            addCategories_updateBtn.BackColor = Color.FromArgb(255, 192, 192);
            addCategories_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addCategories_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addCategories_updateBtn.FlatStyle = FlatStyle.Flat;
            addCategories_updateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCategories_updateBtn.Location = new Point(163, 129);
            addCategories_updateBtn.Name = "addCategories_updateBtn";
            addCategories_updateBtn.Size = new Size(110, 43);
            addCategories_updateBtn.TabIndex = 7;
            addCategories_updateBtn.Text = "Update";
            addCategories_updateBtn.UseVisualStyleBackColor = false;
            addCategories_updateBtn.Click += addCategories_updateBtn_Click;
            // 
            // addCategories_addBtn
            // 
            addCategories_addBtn.BackColor = Color.FromArgb(255, 192, 192);
            addCategories_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            addCategories_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addCategories_addBtn.FlatStyle = FlatStyle.Flat;
            addCategories_addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCategories_addBtn.Location = new Point(20, 129);
            addCategories_addBtn.Name = "addCategories_addBtn";
            addCategories_addBtn.Size = new Size(110, 43);
            addCategories_addBtn.TabIndex = 6;
            addCategories_addBtn.Text = "Add";
            addCategories_addBtn.UseVisualStyleBackColor = false;
            addCategories_addBtn.Click += addCategories_addBtn_Click;
            // 
            // addCategories_category
            // 
            addCategories_category.Location = new Point(18, 79);
            addCategories_category.Name = "addCategories_category";
            addCategories_category.Size = new Size(268, 23);
            addCategories_category.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 47);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(342, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 649);
            panel2.TabIndex = 5;
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
            dataGridView1.Location = new Point(17, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(601, 583);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 1;
            label4.Text = "All Categories";
            // 
            // AdminAddCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminAddCategories";
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
        private Button addCategories_clearBtn;
        private Button addCategories_removeBtn;
        private Button addCategories_updateBtn;
        private Button addCategories_addBtn;
        private TextBox addCategories_category;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
