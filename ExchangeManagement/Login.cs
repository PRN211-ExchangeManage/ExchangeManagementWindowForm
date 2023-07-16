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
using Microsoft.Data.SqlClient;

namespace ExchangeManagement
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            try
            {
                string connectionString = "Server=MSI\\SQLEXPRESS; Database=ExchangeManagement; Uid=sa; Pwd=12345";
                string query = "SELECT * FROM [dbo].[Accounts] WHERE Username = @Username AND Password = @Password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Đăng nhập thành công
                        MessageBox.Show("Đăng nhập thành công!");
                        PostProduct form2 = new PostProduct();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Sai tên đăng nhập hoặc mật khẩu
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                        txt_username.Clear();
                        txt_password.Clear();

                        txt_username.Focus();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
