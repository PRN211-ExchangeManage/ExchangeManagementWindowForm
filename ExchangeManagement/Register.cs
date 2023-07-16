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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_newusername.Text;
            string password = txt_newpassword.Text;
            int role = 3; // Giá trị mặc định cho vai trò

            try
            {
                string connectionString = "Server=MSI\\SQLEXPRESS; Database=ExchangeManagement; Uid=sa; Pwd=12345";
                string query = "INSERT INTO [dbo].[Accounts] ([Username], [Password], [Role]) VALUES (@Username, @Password, @Role)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Tài khoản đã được tạo thành công
                      

                        // Hiển thị vai trò trên Windows Form
                        lbl_role.Text = role.ToString("Student"); // lbl_role là tên của Label hoặc TextBox
                        DialogResult res;
                        res = MessageBox.Show("Tạo tài khoản thành công! Quay về trang đăng nhập", "Thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            LoginPage login = new LoginPage();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            this.Show();
                        }
                    }
                    else
                    {
                        // Lỗi khi tạo tài khoản
                        MessageBox.Show("Lỗi khi tạo tài khoản!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}
