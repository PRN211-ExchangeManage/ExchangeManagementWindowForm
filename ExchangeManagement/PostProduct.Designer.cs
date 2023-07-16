namespace ExchangeManagement
{
    partial class PostProduct
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txt_sanpham = new System.Windows.Forms.TextBox();
            txt_des = new System.Windows.Forms.TextBox();
            txt_price = new System.Windows.Forms.TextBox();
            btn_create = new System.Windows.Forms.Button();
            btn_image = new System.Windows.Forms.Button();
            lable = new System.Windows.Forms.Label();
            txt_image = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(53, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(565, 547);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(793, 93);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(809, 147);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "Descriptiom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(840, 187);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // txt_sanpham
            // 
            txt_sanpham.Location = new System.Drawing.Point(901, 90);
            txt_sanpham.Name = "txt_sanpham";
            txt_sanpham.Size = new System.Drawing.Size(202, 23);
            txt_sanpham.TabIndex = 5;
            // 
            // txt_des
            // 
            txt_des.Location = new System.Drawing.Point(901, 139);
            txt_des.Name = "txt_des";
            txt_des.Size = new System.Drawing.Size(202, 23);
            txt_des.TabIndex = 6;
            // 
            // txt_price
            // 
            txt_price.Location = new System.Drawing.Point(901, 179);
            txt_price.Name = "txt_price";
            txt_price.Size = new System.Drawing.Size(202, 23);
            txt_price.TabIndex = 7;
            // 
            // btn_create
            // 
            btn_create.Location = new System.Drawing.Point(944, 299);
            btn_create.Name = "btn_create";
            btn_create.Size = new System.Drawing.Size(75, 23);
            btn_create.TabIndex = 8;
            btn_create.Text = "Thêm";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // btn_image
            // 
            btn_image.Location = new System.Drawing.Point(1109, 227);
            btn_image.Name = "btn_image";
            btn_image.Size = new System.Drawing.Size(75, 23);
            btn_image.TabIndex = 9;
            btn_image.Text = "chọn tệp";
            btn_image.UseVisualStyleBackColor = true;
            btn_image.Click += btn_image_Click;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new System.Drawing.Point(840, 235);
            lable.Name = "lable";
            lable.Size = new System.Drawing.Size(40, 15);
            lable.TabIndex = 10;
            lable.Text = "Image";
            // 
            // txt_image
            // 
            txt_image.Location = new System.Drawing.Point(901, 227);
            txt_image.Name = "txt_image";
            txt_image.Size = new System.Drawing.Size(202, 23);
            txt_image.TabIndex = 11;
            // 
            // PostProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1210, 653);
            Controls.Add(txt_image);
            Controls.Add(lable);
            Controls.Add(btn_image);
            Controls.Add(btn_create);
            Controls.Add(txt_price);
            Controls.Add(txt_des);
            Controls.Add(txt_sanpham);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PostProduct";
            Text = "PostProduct";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sanpham;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox txt_image;
    }
}