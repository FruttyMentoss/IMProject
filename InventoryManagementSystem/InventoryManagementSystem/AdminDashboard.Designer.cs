namespace InventoryManagementSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel5 = new Panel();
            label8 = new Label();
            dashboard_totalincome = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label6 = new Label();
            dashboard_TI = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            dashboard_AC = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            dashboard_AU = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            DataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(21, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 183);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 192);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(dashboard_totalincome);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(721, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 149);
            panel5.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(99, 87);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 11;
            label8.Text = "Total Income";
            // 
            // dashboard_totalincome
            // 
            dashboard_totalincome.AutoSize = true;
            dashboard_totalincome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_totalincome.Location = new Point(99, 33);
            dashboard_totalincome.Name = "dashboard_totalincome";
            dashboard_totalincome.Size = new Size(49, 20);
            dashboard_totalincome.TabIndex = 10;
            dashboard_totalincome.Text = "P0.00";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 37);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 192);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(dashboard_TI);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(490, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(213, 149);
            panel4.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(88, 87);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 8;
            label6.Text = "Today's Income";
            // 
            // dashboard_TI
            // 
            dashboard_TI.AutoSize = true;
            dashboard_TI.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_TI.Location = new Point(88, 33);
            dashboard_TI.Name = "dashboard_TI";
            dashboard_TI.Size = new Size(49, 20);
            dashboard_TI.TabIndex = 7;
            dashboard_TI.Text = "P0.00";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 33);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dashboard_AC);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(252, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 149);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 87);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 5;
            label4.Text = "All Customers";
            // 
            // dashboard_AC
            // 
            dashboard_AC.AutoSize = true;
            dashboard_AC.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_AC.Location = new Point(99, 33);
            dashboard_AC.Name = "dashboard_AC";
            dashboard_AC.Size = new Size(18, 20);
            dashboard_AC.TabIndex = 4;
            dashboard_AC.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dashboard_AU);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(19, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 149);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 87);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 2;
            label3.Text = "All Users";
            // 
            // dashboard_AU
            // 
            dashboard_AU.AutoSize = true;
            dashboard_AU.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_AU.Location = new Point(110, 33);
            dashboard_AU.Name = "dashboard_AU";
            dashboard_AU.Size = new Size(18, 20);
            dashboard_AU.TabIndex = 1;
            dashboard_AU.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(DataGridView1);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(20, 250);
            panel6.Name = "panel6";
            panel6.Size = new Size(954, 412);
            panel6.TabIndex = 1;
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(23, 70);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.Size = new Size(915, 324);
            DataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 1;
            label1.Text = "All Customers Today";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Size = new Size(994, 682);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel6;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label dashboard_AC;
        private PictureBox pictureBox2;
        private Label label3;
        private Label dashboard_AU;
        private Label label8;
        private Label dashboard_totalincome;
        private PictureBox pictureBox4;
        private Label label6;
        private Label dashboard_TI;
        private PictureBox pictureBox3;
        private DataGridView DataGridView1;
    }
}
