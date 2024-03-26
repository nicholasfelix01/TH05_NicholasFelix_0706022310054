namespace NF0502_TH
{
    partial class EnterName
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
            this.components = new System.ComponentModel.Container();
            this.t_bling = new System.Windows.Forms.Timer(this.components);
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_entername = new System.Windows.Forms.Label();
            this.lbl_pressenter = new System.Windows.Forms.Label();
            this.tb_enternama = new System.Windows.Forms.TextBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.btn_SN = new System.Windows.Forms.Button();
            this.btn_skip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_bling
            // 
            this.t_bling.Enabled = true;
            this.t_bling.Interval = 700;
            this.t_bling.Tick += new System.EventHandler(this.t_bling_Tick);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(45, 77);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 40);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_entername
            // 
            this.lbl_entername.AutoSize = true;
            this.lbl_entername.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entername.Location = new System.Drawing.Point(165, 116);
            this.lbl_entername.Name = "lbl_entername";
            this.lbl_entername.Size = new System.Drawing.Size(174, 23);
            this.lbl_entername.TabIndex = 1;
            this.lbl_entername.Text = "Please Enter Your Name";
            this.lbl_entername.Click += new System.EventHandler(this.lbl_entername_Click);
            // 
            // lbl_pressenter
            // 
            this.lbl_pressenter.AutoSize = true;
            this.lbl_pressenter.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pressenter.Location = new System.Drawing.Point(202, 167);
            this.lbl_pressenter.Name = "lbl_pressenter";
            this.lbl_pressenter.Size = new System.Drawing.Size(98, 23);
            this.lbl_pressenter.TabIndex = 2;
            this.lbl_pressenter.Text = "(Press Enter)";
            this.lbl_pressenter.Click += new System.EventHandler(this.lbl_pressenter_Click);
            // 
            // tb_enternama
            // 
            this.tb_enternama.Location = new System.Drawing.Point(152, 142);
            this.tb_enternama.Name = "tb_enternama";
            this.tb_enternama.Size = new System.Drawing.Size(196, 22);
            this.tb_enternama.TabIndex = 3;
            this.tb_enternama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(199, 124);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(0, 40);
            this.lbl_nama.TabIndex = 4;
            this.lbl_nama.Visible = false;
            // 
            // btn_SN
            // 
            this.btn_SN.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_SN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse;
            this.btn_SN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SN.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SN.Location = new System.Drawing.Point(206, 170);
            this.btn_SN.Name = "btn_SN";
            this.btn_SN.Size = new System.Drawing.Size(94, 37);
            this.btn_SN.TabIndex = 5;
            this.btn_SN.Text = "Shop Now!";
            this.btn_SN.UseVisualStyleBackColor = false;
            this.btn_SN.Visible = false;
            this.btn_SN.Click += new System.EventHandler(this.btn_SN_Click);
            // 
            // btn_skip
            // 
            this.btn_skip.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_skip.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_skip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse;
            this.btn_skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_skip.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_skip.Location = new System.Drawing.Point(418, 12);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(71, 35);
            this.btn_skip.TabIndex = 6;
            this.btn_skip.Text = "Skip";
            this.btn_skip.UseVisualStyleBackColor = false;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // EnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 263);
            this.Controls.Add(this.btn_skip);
            this.Controls.Add(this.btn_SN);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.tb_enternama);
            this.Controls.Add(this.lbl_pressenter);
            this.Controls.Add(this.lbl_entername);
            this.Controls.Add(this.lbl_title);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.KeyPreview = true;
            this.Name = "EnterName";
            this.Text = "Welcome";
            this.UseWaitCursor = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterName_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer t_bling;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_entername;
        private System.Windows.Forms.Label lbl_pressenter;
        private System.Windows.Forms.TextBox tb_enternama;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Button btn_SN;
        private System.Windows.Forms.Button btn_skip;
    }
}

