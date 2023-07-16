namespace ExchangeManagement
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            listViewProducts = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            imageListProducts = new System.Windows.Forms.ImageList(components);
            btn_Post = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewProducts.Dock = System.Windows.Forms.DockStyle.Left;
            listViewProducts.HideSelection = false;
            listViewProducts.Location = new System.Drawing.Point(0, 0);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new System.Drawing.Size(588, 450);
            listViewProducts.TabIndex = 0;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Description";
            columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Quantity";
            // 
            // imageListProducts
            // 
            imageListProducts.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageListProducts.ImageSize = new System.Drawing.Size(16, 16);
            imageListProducts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_Post
            // 
            btn_Post.Location = new System.Drawing.Point(594, 12);
            btn_Post.Name = "btn_Post";
            btn_Post.Size = new System.Drawing.Size(75, 23);
            btn_Post.TabIndex = 1;
            btn_Post.Text = "Post";
            btn_Post.UseVisualStyleBackColor = true;
            btn_Post.Click += btn_Post_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1348, 450);
            Controls.Add(btn_Post);
            Controls.Add(listViewProducts);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList imageListProducts;
        private System.Windows.Forms.Button btn_Post;
    }
}