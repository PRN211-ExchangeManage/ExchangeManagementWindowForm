namespace ExchangeManagement
{
    partial class Register
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            lable = new System.Windows.Forms.Label();
            lable2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txt_newusername = new System.Windows.Forms.TextBox();
            txt_newpassword = new System.Windows.Forms.TextBox();
            btn_register = new System.Windows.Forms.Button();
            btn_reset = new System.Windows.Forms.Button();
            lbl_role = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(175, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 28);
            label1.TabIndex = 0;
            label1.Text = " New Login";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new System.Drawing.Point(74, 91);
            lable.Name = "lable";
            lable.Size = new System.Drawing.Size(87, 15);
            lable.TabIndex = 1;
            lable.Text = "New Username";
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Location = new System.Drawing.Point(77, 136);
            lable2.Name = "lable2";
            lable2.Size = new System.Drawing.Size(84, 15);
            lable2.TabIndex = 2;
            lable2.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(77, 180);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Role";
            // 
            // txt_newusername
            // 
            txt_newusername.Location = new System.Drawing.Point(190, 88);
            txt_newusername.Name = "txt_newusername";
            txt_newusername.Size = new System.Drawing.Size(166, 23);
            txt_newusername.TabIndex = 4;
            // 
            // txt_newpassword
            // 
            txt_newpassword.Location = new System.Drawing.Point(190, 136);
            txt_newpassword.Name = "txt_newpassword";
            txt_newpassword.Size = new System.Drawing.Size(166, 23);
            txt_newpassword.TabIndex = 5;
            // 
            // btn_register
            // 
            btn_register.Location = new System.Drawing.Point(175, 225);
            btn_register.Name = "btn_register";
            btn_register.Size = new System.Drawing.Size(75, 23);
            btn_register.TabIndex = 7;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new System.Drawing.Point(281, 225);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new System.Drawing.Size(75, 23);
            btn_reset.TabIndex = 8;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Location = new System.Drawing.Point(190, 180);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new System.Drawing.Size(48, 15);
            lbl_role.TabIndex = 9;
            lbl_role.Text = "Student";
            // 
            // Register
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(572, 328);
            Controls.Add(lbl_role);
            Controls.Add(btn_reset);
            Controls.Add(btn_register);
            Controls.Add(txt_newpassword);
            Controls.Add(txt_newusername);
            Controls.Add(label4);
            Controls.Add(lable2);
            Controls.Add(lable);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_newusername;
        private System.Windows.Forms.TextBox txt_newpassword;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_role;
    }
}