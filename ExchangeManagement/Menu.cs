using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeManagement
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=MSI\\SQLEXPRESS; Database=ExchangeManagement; Uid=sa; Pwd=12345";
                string query = "SELECT Name, Description, Price, Quantity, Image FROM [dbo].[Products]";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string productName = (string)reader["Name"];
                        string description = (string)reader["Description"];
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        int quantity = (int)reader["Quantity"];
                        string imagePath = (string)reader["Image"];

                        ListViewItem item = new ListViewItem(productName);
                        item.SubItems.Add(description);
                        item.SubItems.Add(price.ToString("C2"));
                        item.SubItems.Add(quantity.ToString());
                        item.SubItems.Add(imagePath); // Thêm đường dẫn hình ảnh vào SubItems

                        listViewProducts.Items.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

    }
}
