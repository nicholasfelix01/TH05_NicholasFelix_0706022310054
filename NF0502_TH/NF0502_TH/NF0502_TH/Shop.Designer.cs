namespace NF0502_TH
{
    partial class Shop
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
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.dgv_cat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.cb_pro = new System.Windows.Forms.ComboBox();
            this.t_pro_name = new System.Windows.Forms.TextBox();
            this.t_pro_harga = new System.Windows.Forms.TextBox();
            this.t_pro_stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_cat_name = new System.Windows.Forms.TextBox();
            this.btn_pro_add = new System.Windows.Forms.Button();
            this.btn_pro_edit = new System.Windows.Forms.Button();
            this.btn_pro_rev = new System.Windows.Forms.Button();
            this.btn_cat_add = new System.Windows.Forms.Button();
            this.btn_cat_rev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(36, 76);
            this.dgv_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowHeadersWidth = 51;
            this.dgv_main.RowTemplate.Height = 21;
            this.dgv_main.Size = new System.Drawing.Size(559, 295);
            this.dgv_main.TabIndex = 0;
            this.dgv_main.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_main_CellMouseClick);
            // 
            // dgv_cat
            // 
            this.dgv_cat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cat.Location = new System.Drawing.Point(652, 76);
            this.dgv_cat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cat.Name = "dgv_cat";
            this.dgv_cat.RowHeadersWidth = 51;
            this.dgv_cat.RowTemplate.Height = 21;
            this.dgv_cat.Size = new System.Drawing.Size(332, 200);
            this.dgv_cat.TabIndex = 1;
            this.dgv_cat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cat_CellContentClick);
            this.dgv_cat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_cat_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(644, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(283, 37);
            this.btn_all.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(61, 31);
            this.btn_all.TabIndex = 5;
            this.btn_all.Text = "all";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(352, 37);
            this.btn_filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(61, 31);
            this.btn_filter.TabIndex = 6;
            this.btn_filter.Text = "filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // cb_filter
            // 
            this.cb_filter.Enabled = false;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(421, 37);
            this.cb_filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(128, 24);
            this.cb_filter.TabIndex = 7;
            this.cb_filter.SelectionChangeCommitted += new System.EventHandler(this.cb_filter_SelectionChangeCommitted);
            // 
            // cb_pro
            // 
            this.cb_pro.FormattingEnabled = true;
            this.cb_pro.Location = new System.Drawing.Point(149, 483);
            this.cb_pro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_pro.Name = "cb_pro";
            this.cb_pro.Size = new System.Drawing.Size(132, 24);
            this.cb_pro.TabIndex = 8;
            // 
            // t_pro_name
            // 
            this.t_pro_name.Location = new System.Drawing.Point(149, 448);
            this.t_pro_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_pro_name.Name = "t_pro_name";
            this.t_pro_name.Size = new System.Drawing.Size(444, 22);
            this.t_pro_name.TabIndex = 9;
            // 
            // t_pro_harga
            // 
            this.t_pro_harga.Location = new System.Drawing.Point(149, 520);
            this.t_pro_harga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_pro_harga.Name = "t_pro_harga";
            this.t_pro_harga.Size = new System.Drawing.Size(132, 22);
            this.t_pro_harga.TabIndex = 10;
            this.t_pro_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_pro_harga_KeyPress);
            // 
            // t_pro_stock
            // 
            this.t_pro_stock.Location = new System.Drawing.Point(149, 557);
            this.t_pro_stock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_pro_stock.Name = "t_pro_stock";
            this.t_pro_stock.Size = new System.Drawing.Size(132, 22);
            this.t_pro_stock.TabIndex = 11;
            this.t_pro_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_pro_stock_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 441);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 473);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "Category :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 511);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "Harga :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 548);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stock :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(645, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 35);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nama :";
            // 
            // t_cat_name
            // 
            this.t_cat_name.Location = new System.Drawing.Point(747, 304);
            this.t_cat_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_cat_name.Name = "t_cat_name";
            this.t_cat_name.Size = new System.Drawing.Size(236, 22);
            this.t_cat_name.TabIndex = 17;
            // 
            // btn_pro_add
            // 
            this.btn_pro_add.Location = new System.Drawing.Point(331, 517);
            this.btn_pro_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pro_add.Name = "btn_pro_add";
            this.btn_pro_add.Size = new System.Drawing.Size(83, 65);
            this.btn_pro_add.TabIndex = 18;
            this.btn_pro_add.Text = "Add Product";
            this.btn_pro_add.UseVisualStyleBackColor = true;
            this.btn_pro_add.Click += new System.EventHandler(this.btn_pro_add_Click);
            // 
            // btn_pro_edit
            // 
            this.btn_pro_edit.Location = new System.Drawing.Point(421, 517);
            this.btn_pro_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pro_edit.Name = "btn_pro_edit";
            this.btn_pro_edit.Size = new System.Drawing.Size(83, 65);
            this.btn_pro_edit.TabIndex = 19;
            this.btn_pro_edit.Text = "Edit Product";
            this.btn_pro_edit.UseVisualStyleBackColor = true;
            this.btn_pro_edit.Click += new System.EventHandler(this.btn_pro_edit_Click);
            // 
            // btn_pro_rev
            // 
            this.btn_pro_rev.Location = new System.Drawing.Point(512, 517);
            this.btn_pro_rev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pro_rev.Name = "btn_pro_rev";
            this.btn_pro_rev.Size = new System.Drawing.Size(83, 65);
            this.btn_pro_rev.TabIndex = 20;
            this.btn_pro_rev.Text = "Remove Product";
            this.btn_pro_rev.UseVisualStyleBackColor = true;
            this.btn_pro_rev.Click += new System.EventHandler(this.btn_pro_rev_Click);
            // 
            // btn_cat_add
            // 
            this.btn_cat_add.Location = new System.Drawing.Point(811, 337);
            this.btn_cat_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cat_add.Name = "btn_cat_add";
            this.btn_cat_add.Size = new System.Drawing.Size(83, 65);
            this.btn_cat_add.TabIndex = 21;
            this.btn_cat_add.Text = "Add Category";
            this.btn_cat_add.UseVisualStyleBackColor = true;
            this.btn_cat_add.Click += new System.EventHandler(this.btn_cat_add_Click);
            // 
            // btn_cat_rev
            // 
            this.btn_cat_rev.Location = new System.Drawing.Point(901, 337);
            this.btn_cat_rev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cat_rev.Name = "btn_cat_rev";
            this.btn_cat_rev.Size = new System.Drawing.Size(83, 65);
            this.btn_cat_rev.TabIndex = 22;
            this.btn_cat_rev.Text = "Remove Category";
            this.btn_cat_rev.UseVisualStyleBackColor = true;
            this.btn_cat_rev.Click += new System.EventHandler(this.btn_cat_rev_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 600);
            this.Controls.Add(this.btn_cat_rev);
            this.Controls.Add(this.btn_cat_add);
            this.Controls.Add(this.btn_pro_rev);
            this.Controls.Add(this.btn_pro_edit);
            this.Controls.Add(this.btn_pro_add);
            this.Controls.Add(this.t_cat_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_pro_stock);
            this.Controls.Add(this.t_pro_harga);
            this.Controls.Add(this.t_pro_name);
            this.Controls.Add(this.cb_pro);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_cat);
            this.Controls.Add(this.dgv_main);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.DataGridView dgv_cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.ComboBox cb_pro;
        private System.Windows.Forms.TextBox t_pro_name;
        private System.Windows.Forms.TextBox t_pro_harga;
        private System.Windows.Forms.TextBox t_pro_stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_cat_name;
        private System.Windows.Forms.Button btn_pro_add;
        private System.Windows.Forms.Button btn_pro_edit;
        private System.Windows.Forms.Button btn_pro_rev;
        private System.Windows.Forms.Button btn_cat_add;
        private System.Windows.Forms.Button btn_cat_rev;
    }
}