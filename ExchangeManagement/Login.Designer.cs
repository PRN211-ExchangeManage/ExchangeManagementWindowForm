namespace ExchangeManagement
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txt_username = new System.Windows.Forms.TextBox();
            txt_password = new System.Windows.Forms.TextBox();
            btn_login = new System.Windows.Forms.Button();
            btn_clear = new System.Windows.Forms.Button();
            btn_exit = new System.Windows.Forms.Button();
            btn_register = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(221, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 24);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(99, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(99, 133);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Location = new System.Drawing.Point(191, 88);
            txt_username.Name = "txt_username";
            txt_username.Size = new System.Drawing.Size(179, 23);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new System.Drawing.Point(191, 130);
            txt_password.Name = "txt_password";
            txt_password.Size = new System.Drawing.Size(179, 23);
            txt_password.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Location = new System.Drawing.Point(191, 182);
            btn_login.Name = "btn_login";
            btn_login.Size = new System.Drawing.Size(75, 23);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new System.Drawing.Point(295, 182);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new System.Drawing.Size(75, 23);
            btn_clear.TabIndex = 6;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new System.Drawing.Point(99, 246);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(75, 23);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new System.Drawing.Point(345, 246);
            btn_register.Name = "btn_register";
            btn_register.Size = new System.Drawing.Size(75, 23);
            btn_register.TabIndex = 8;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(523, 310);
            Controls.Add(btn_register);
            Controls.Add(btn_exit);
            Controls.Add(btn_clear);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_register;
    }
}
