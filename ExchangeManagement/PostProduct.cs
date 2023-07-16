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
using System.Data.SqlClient;

namespace ExchangeManagement
{
    public partial class PostProduct : Form
    {
        public PostProduct()
        {
            InitializeComponent();
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = openFileDialog.Filter = "JPG file (*.jpg)|*.jbg|All files (*.*) | *.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                txt_image.Text = openFileDialog.FileName;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string productName = txt_sanpham.Text;
            string imagePath = txt_image.Text; // Đường dẫn hình ảnh (nếu có)
            string description = txt_des.Text;
            decimal price = decimal.Parse(txt_price.Text);

            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=ExchangeManagement; Uid=sa; Pwd=12345";

            // Tạo câu truy vấn SQL
            string query = "INSERT INTO [dbo].[Products] ([Name],[Image],[Description],[Price]) VALUES (@Name, @Image, @Description, @Price)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn để tránh tình trạng SQL injection
                    command.Parameters.AddWithValue("@Name", productName);
                    command.Parameters.AddWithValue("@Image", imagePath);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Price", price);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm sản phẩm thành công vào cơ sở dữ liệu.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm sản phẩm vào cơ sở dữ liệu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
    }
}
