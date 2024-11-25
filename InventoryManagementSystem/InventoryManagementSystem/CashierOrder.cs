using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CashierOrder : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Christian\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public CashierOrder()
        {
            InitializeComponent();
            displayAllAvailableProducts();
            displayAllCategories();
            displayOrders();
            displayTotalPrice();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAllAvailableProducts();
            displayAllCategories();
            displayOrders();
            displayTotalPrice();
        }

        public void displayAllAvailableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.allAvailableProducts();
            dataGridView1.DataSource = listData;
        }

        public void displayOrders()
        {
            OrdersData oData = new OrdersData();
            List<OrdersData> listData = oData.allOrdersData();
            dataGridView2.DataSource = listData;
        }

        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        public void displayAllCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cashierOrder_category.Items.Clear();
                            while (reader.Read())
                            {
                                string item = reader.GetString(1); // Ensure this index matches your schema
                                cashierOrder_category.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrder_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodID.Items.Clear();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";

            string selectedValue = cashierOrder_category.SelectedItem as string;
            if (selectedValue != null && checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT prod_id FROM products WHERE category = @category AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedValue);
                        cmd.Parameters.AddWithValue("@status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string value = reader["prod_id"].ToString();
                                cashierOrder_prodID.Items.Add(value);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrder_prodID.SelectedItem as string;
            if (checkConnection() && selectedValue != null)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT prod_name, price FROM products WHERE prod_id = @prodID AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@prodID", selectedValue);
                        cmd.Parameters.AddWithValue("@status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cashierOrder_prodName.Text = reader["prod_name"].ToString();
                                cashierOrder_price.Text = Convert.ToSingle(reader["price"]).ToString("0.00");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private float totalPrice = 0;

        public void displayTotalPrice()
        {
            IDGenerator();
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT SUM(total_price) FROM orders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", idGen);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);
                            cashierOrder_totalprice.Text = totalPrice.ToString("0.00");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();
            if (cashierOrder_category.SelectedIndex == -1 || cashierOrder_prodID.SelectedIndex == -1
                || string.IsNullOrEmpty(cashierOrder_prodName.Text) || string.IsNullOrEmpty(cashierOrder_price.Text) || cashierOrder_qty.Value == 0)
            {
                MessageBox.Show("Please select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkConnection())
            {
                try
                {
                    connect.Open();
                    float getPrice = 0;
                    string selectOrder = "SELECT price, stock FROM products WHERE prod_id = @prodID";

                    using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                    {
                        getOrder.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);
                        using (SqlDataReader reader = getOrder.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["price"] != DBNull.Value)
                                {
                                    getPrice = Convert.ToSingle(reader["price"]);
                                }
                        
                            }
                        }
                    }

                    string insertData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date) " +
                                        "VALUES(@cID, @prodID, @prodName, @cat, @qty, @origPrice, @totalPrice, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", idGen);
                        cmd.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);
                        cmd.Parameters.AddWithValue("@prodName", cashierOrder_prodName.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", cashierOrder_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@qty", cashierOrder_qty.Value);
                        cmd.Parameters.AddWithValue("@origPrice", getPrice);

                        float totalP = getPrice * (int)cashierOrder_qty.Value;
                        cmd.Parameters.AddWithValue("@totalPrice", totalP);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
                displayOrders();
                displayTotalPrice();
            }
        }

        private int idGen;

        public void IDGenerator()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Christian\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string selectData = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    idGen = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
                }
            }
        }

        private void cashierOrder_removeBtn_Click(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Please select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show($"Are you sure you want to Remove ID: {prodID}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string deleteData = "DELETE FROM orders WHERE order_id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", prodID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Removed Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

            displayOrders();
            displayTotalPrice();
        }

        private int prodID = 0;

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells[0].Value); // Ensure this index is correct
            }
        }

        public void clearFields()
        {
            cashierOrder_category.SelectedIndex = -1;
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;
        }

        private void cashierOrder_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void cashierOrder_payOrders_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (string.IsNullOrEmpty(cashierOrder_amount.Text) || dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Something went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure to pay all orders?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        // Loop through each product in the order
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            if (row.Cells["PID"].Value != null && row.Cells["qty"].Value != null)
                            {
                                string prodID = row.Cells["PID"].Value.ToString();
                                int orderQty = Convert.ToInt32(row.Cells["qty"].Value);

                                // Check stock for the current product
                                string checkStockQuery = "SELECT stock FROM products WHERE prod_id = @prodID";
                                using (SqlCommand checkStockCmd = new SqlCommand(checkStockQuery, connect))
                                {
                                    checkStockCmd.Parameters.AddWithValue("@prodID", prodID);
                                    using (SqlDataReader reader = checkStockCmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            int stock = reader["stock"] != DBNull.Value ? Convert.ToInt32(reader["stock"]) : 0;

                                            // Validate stock
                                            if (stock < orderQty)
                                            {
                                                MessageBox.Show($"Not enough stock available for product ID: {prodID}.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                reader.Close();
                                                return;
                                            }

                                            // Update stock
                                            stock -= orderQty;
                                            reader.Close(); // Close the reader before executing another command
                                            string updateStockQuery = "UPDATE products SET stock = @stock WHERE prod_id = @prodID";
                                            using (SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, connect))
                                            {
                                                updateStockCmd.Parameters.AddWithValue("@stock", stock);
                                                updateStockCmd.Parameters.AddWithValue("@prodID", prodID);
                                                updateStockCmd.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show($"Product ID: {prodID} not found.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                }
                            }
                        }

                        // Insert payment details into the customers table
                        string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, order_date) " +
                                            "VALUES(@cID, @totalPrice, @amount, @change, @date)";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cID", idGen);
                            cmd.Parameters.AddWithValue("@totalPrice", cashierOrder_totalprice.Text);
                            cmd.Parameters.AddWithValue("@amount", cashierOrder_amount.Text);
                            cmd.Parameters.AddWithValue("@change", cashierOrder_change.Text);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);
                            cmd.ExecuteNonQuery();

                            clearFields();
                            MessageBox.Show("Paid Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

            displayTotalPrice();
            cashierOrder_amount.Text = "";
            cashierOrder_change.Text = "";
        }


        private void cashierOrder_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(cashierOrder_amount.Text);
                    float getChange = getAmount - totalPrice;

                    if (getChange < 0)
                    {
                        cashierOrder_amount.Text = "";
                        cashierOrder_change.Text = "";
                    }
                    else
                    {
                        cashierOrder_change.Text = getChange.ToString("0.00");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrder_amount.Text = "";
                    cashierOrder_change.Text = "";
                }
            }
        }

        private void cashierOrder_receipt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cashierOrder_amount.Text) || dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Please order first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            displayTotalPrice();
            float y = 0;
            int count = 0;
            int colWidth = 99;
            int headerMargin = 5;
            int tableMargin = 50;

            Font font = new Font("Tahoma", 12);
            Font bold = new Font("tahoma", 12, FontStyle.Bold);
            Font headerFont = new Font("Tahoma", 16, FontStyle.Bold);
            Font labelFont = new Font("Tahoma", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;
            StringFormat alignCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            string headerText = "Guys and Gal's Salon";
            y = (margin + count + headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView2.Columns.Count / 2) * colWidth, y, alignCenter);
            count++;

            y += tableMargin;

            string[] header = { "ID", "CID", "PID", "PName", "Category", "OrigPrice", "QTY", "TotalPrice" };
            for (int q = 0; q < header.Length; q++)
            {
                y = margin + count + bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;
            while (rowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];
                for (int q = 0; q < dataGridView2.Columns.Count; q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelmargin = (int)Math.Min(rSpace, 250);
            DateTime today = DateTime.Now;
            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Total Price: \tP" + totalPrice + "\nAmount: \tP" + cashierOrder_amount.Text.Trim()
                 + "\n\t\t-----------------\nChange: \tP" + cashierOrder_change.Text.Trim(), labelFont, Brushes.Black, labelX, y);

            labelmargin = (int)Math.Min(rSpace, -40);
            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right
                - e.Graphics.MeasureString("-----------------", labelFont).Width, y);
        }

        private int rowIndex = 0;
   







private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
