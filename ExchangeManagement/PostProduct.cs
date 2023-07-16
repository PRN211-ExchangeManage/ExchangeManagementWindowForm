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
using BusinessObjects;

namespace ExchangeManagement
{
    public partial class PostProduct : Form
    {
        private int accountId;
        public void SetAccountId(int id)
        {
            accountId = id;
        }
       
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
            string caption = txt_caption.Text; // Caption từ textbox tương ứng

            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=ExchangeManagement; Uid=sa; Pwd=12345";

            // Tạo câu truy vấn SQL cho bảng "Products"
            string productInsertQuery = "INSERT INTO [dbo].[Products] ([Name], [Image], [Description], [Price], [PostId]) VALUES (@Name, @Image, @Description, @Price, @PostId)";

            // Tạo câu truy vấn SQL cho bảng "Posts"
            string postInsertQuery = "INSERT INTO [dbo].[Posts] ([Caption], [UserId], [Status],[CreateAt]) VALUES (@Caption, @UserId, @Status, @CreateAt)";
            string postID = "SELECT TOP 1 Id FROM [dbo].[Posts] ORDER BY Id DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Thêm caption vào bảng "Posts" và lấy ID của bản ghi vừa được thêm
                   
                    using (SqlCommand postCommand = new SqlCommand(postInsertQuery, connection, transaction))
                    {
                        postCommand.Parameters.AddWithValue("@Caption", caption);
                        postCommand.Parameters.AddWithValue("@UserId", accountId);
                        postCommand.Parameters.AddWithValue("@CreateAt", DateTime.Now); // Thêm giá trị ngày giờ hiện tại
                        postCommand.Parameters.AddWithValue("@Status", true);

                        // Thực hiện INSERT vào bảng "Posts" và lấy ID của bản ghi vừa thêm
                        postCommand.ExecuteNonQuery();

                    }

                    // Thêm sản phẩm vào bảng "Products" kèm theo PostId
                    

                    // Hoàn tất giao dịch nếu không có lỗi
                    transaction.Commit();
                    
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, rollback giao dịch để không thực hiện gì cả
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Thêm caption vào bảng "Posts" và lấy ID của bản ghi vừa được thêm
                    int postId;
                    using (SqlCommand postCommand = new SqlCommand(postID, connection, transaction))
                    {
                        postId = Convert.ToInt32(postCommand.ExecuteScalar());

                        // Thực hiện INSERT vào bảng "Posts" và lấy ID của bản ghi vừa 
                    }


                    // Thêm sản phẩm vào bảng "Products" kèm theo PostId
                    using (SqlCommand productCommand = new SqlCommand(productInsertQuery, connection, transaction))
                    {
                        productCommand.Parameters.AddWithValue("@Name", productName);
                        productCommand.Parameters.AddWithValue("@Image", imagePath);
                        productCommand.Parameters.AddWithValue("@Description", description);
                        productCommand.Parameters.AddWithValue("@Price", price);
                        productCommand.Parameters.AddWithValue("@PostId", postId); // Thêm ID của Post vào cột PostId

                        productCommand.ExecuteNonQuery(); // Thực hiện INSERT vào bảng "Products"
                    }

                    // Hoàn tất giao dịch nếu không có lỗi
                    transaction.Commit();
                    MessageBox.Show("Thêm sản phẩm và caption thành công vào cơ sở dữ liệu.");
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, rollback giao dịch để không thực hiện gì cả
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                }
            }
        }

    }
}
