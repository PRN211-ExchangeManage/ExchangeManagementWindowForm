using BusinessObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeManagement
{
    public partial class Menu : Form
    {
        private int accountId;

        public void SetAccountId(int id)
        {
            accountId = id;
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                imageListProducts = new ImageList();
                imageListProducts.ColorDepth = ColorDepth.Depth32Bit;
                imageListProducts.ImageSize = new Size(100, 100);
                string connectionString = "Server=MSI\\SQLEXPRESS; Database=ExchangeManagement; Uid=sa; Pwd=12345";
                string query = "SELECT p.[Name], p.[Description], p.[Price], po.[Caption], p.[Id], p.[Image], p.[Id] FROM [dbo].[Products] p JOIN [dbo].[Posts] po ON p.PostId = po.Id;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string productName = (string)reader["Name"];

                        decimal price = Convert.ToDecimal(reader["Price"]);
                        string caption = (string)reader["Caption"];
                        string description = (string)reader["Description"];
                        int productID = (int)reader["Id"];
                        string imagePath = (string)reader["Image"];

                        Image image = Image.FromFile(imagePath);
                        imageListProducts.Images.Add(image);

                        ListViewItem item = new ListViewItem(caption);
                        item.SubItems.Add(productName);
                        item.SubItems.Add(description);
                        item.SubItems.Add(price.ToString());
                        item.SubItems.Add(productID.ToString());
                        item.ImageIndex = imageListProducts.Images.Count - 1; // Lấy index của hình ảnh vừa thêm vào ImageList
                        listViewProducts.Items.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }

            // Thêm sự kiện SelectedIndexChanged cho ListViewProducts
            listViewProducts.SelectedIndexChanged += ListViewProducts_SelectedIndexChanged;

        }

        private void btn_Post_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=ExchangeManagement; Uid=sa; Pwd=12345";

            PostProduct postProductForm = new PostProduct();
            postProductForm.SetAccountId(accountId); // Truyền id của tài khoản từ form Menu qua form PostProduct
            postProductForm.Show();
        }

        private void ListViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                int selectedImageIndex = listViewProducts.SelectedItems[0].ImageIndex;
                if (selectedImageIndex >= 0 && selectedImageIndex < imageListProducts.Images.Count)
                {
                    pictureBoxProduct.Image = imageListProducts.Images[selectedImageIndex];
                }
            }
        }

    }
}


