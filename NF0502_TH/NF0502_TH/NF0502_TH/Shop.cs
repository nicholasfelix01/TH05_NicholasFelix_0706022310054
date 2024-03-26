using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NF0502_TH
{
    
    public partial class Shop : Form
    {
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        public string selectedproduct = "";
        public string selectedcategory = "";

        public Shop()
        {
            InitializeComponent();
            generatedata();
        }
        public void generatedata()
        {
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");

            dtProdukSimpan.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtProdukSimpan.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtProdukSimpan.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtProdukSimpan.Rows.Add("R001", "Rok mini", "82000", "26", "C3");
            dtProdukSimpan.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtProdukSimpan.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtProdukSimpan.Rows.Add("C002", "Cawat Blink-blink", "1000000", "1", "C5");
            dtProdukSimpan.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");

            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");

            dgv_main.ReadOnly = true;
            dgv_cat.ReadOnly = true;

            dgv_main.DataSource = dtProdukTampil;
            dgv_cat.DataSource = dtCategory;
            dgv_main.AllowUserToAddRows = false;
            dgv_cat.AllowUserToAddRows = false;

            dgv_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_main.MultiSelect = false;
            dgv_main.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);

            dgv_cat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_cat.MultiSelect = false;
            dgv_cat.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);


            resetmaindgv();

            resetcombobox();
        }
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }
        private void resetcombobox()
        {
            cb_filter.Items.Clear();
            cb_pro.Items.Clear();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                cb_filter.Items.Add(dtCategory.Rows[i][1].ToString());
                cb_pro.Items.Add(dtCategory.Rows[i][1].ToString());
            }
        }

        private void resettext()
        {
            t_pro_harga.Text = "";
            t_pro_name.Text = "";
            t_pro_stock.Text = "";
            cb_pro.SelectedIndex = -1;
        }

        private void resetmaindgv()
        {
            dtProdukTampil.Rows.Clear();
            for (int j = 0; j < dtProdukSimpan.Rows.Count; j++)
            {
                string id = dtProdukSimpan.Rows[j][0].ToString();
                string nama = dtProdukSimpan.Rows[j][1].ToString();
                string category = dtProdukSimpan.Rows[j][4].ToString();
                string harga = dtProdukSimpan.Rows[j][2].ToString();
                string stock = dtProdukSimpan.Rows[j][3].ToString();
                dtProdukTampil.Rows.Add(id, nama, harga, stock, category);
            }
        }

        private void msg(string value)
        {
            MessageBox.Show(value.ToString());
        }

        private void dgv_main_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedproduct = dgv_main.Rows[dgv_main.CurrentCell.RowIndex].Cells[0].Value.ToString();
            for(int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if (selectedproduct == dtProdukSimpan.Rows[i][0].ToString())
                {
                    t_pro_name.Text = dtProdukSimpan.Rows[i][1].ToString();
                    t_pro_harga.Text = dtProdukSimpan.Rows[i][2].ToString();
                    t_pro_stock.Text = dtProdukSimpan.Rows[i][3].ToString();
                    string idcat = dtProdukSimpan.Rows[i][4].ToString();
                    for (int j = 0; j < dtCategory.Rows.Count; j++)
                    {
                        if (idcat == dtCategory.Rows[j][0].ToString())
                        {
                            cb_pro.SelectedIndex = j;
                        }
                    }
                }
            }
        }

        private void dgv_cat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedcategory = dgv_cat.Rows[dgv_cat.CurrentCell.RowIndex].Cells[0].Value.ToString();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][0].ToString() == selectedcategory)
                {
                    t_cat_name.Text =  dtCategory.Rows[i][1].ToString();
                }
            }
            resettext();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            cb_filter.Enabled = true;
        }

        private void cb_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            resetmaindgv();

            int filter_index = cb_filter.SelectedIndex;
            string filter_id = dtCategory.Rows[filter_index][0].ToString();

            for (int i = 0; i < dtProdukTampil.Rows.Count; i++)
            {
                if (dtProdukTampil.Rows[i][4].ToString() != filter_id)
                {
                    dtProdukTampil.Rows[i].Delete();
                    i = -1;
                }
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            cb_filter.SelectedIndex = -1;
            cb_filter.Enabled = false;
            resetmaindgv();
        }

        private void btn_pro_add_Click(object sender, EventArgs e)
        {
            if (t_pro_harga.Text != "" && t_pro_name.Text != "" && t_pro_stock.Text != "" && cb_pro.SelectedIndex != -1)
            {
                string id = t_pro_name.Text.ToUpper().Substring(0,1);
                int idc = 0;
                for(int i = 0;i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][0].ToString().Contains(id))
                    {
                        string idn = dtProdukSimpan.Rows[i][0].ToString();
                        idc = int.Parse(idn.Substring(1,idn.Length-1));
                    }
                }
                idc++;
                if (idc < 10)
                {
                    id = id + "00"+ idc.ToString();
                }
                else if (idc < 100)
                {
                    id = id + "0" + idc.ToString();
                }
                else if (idc < 1000)
                {
                    id = id + idc.ToString();
                }
                string a = t_pro_name.Text;
                string b = dtCategory.Rows[cb_pro.SelectedIndex][0].ToString();
                string c = t_pro_harga.Text;
                string d = t_pro_stock.Text;
                dtProdukSimpan.Rows.Add(id,a,c,d,b);
                resetmaindgv();
                resettext();
                selectedproduct = "";
            }
            else
            {
                msg("Please fill everything first");
            }
        }

        private void btn_pro_edit_Click(object sender, EventArgs e)
        {
            if (t_pro_harga.Text != "" && t_pro_name.Text != "" && t_pro_stock.Text != "" && cb_pro.SelectedIndex != -1 && selectedproduct != "")
            {
                string a = t_pro_name.Text;
                string b = dtCategory.Rows[cb_pro.SelectedIndex][0].ToString();
                string c = t_pro_harga.Text;
                string d = t_pro_stock.Text;
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][0].ToString() == selectedproduct)
                    {
                        dtProdukSimpan.Rows[i][1] = a;
                        dtProdukSimpan.Rows[i][2] = c;
                        dtProdukSimpan.Rows[i][3] = d;
                        dtProdukSimpan.Rows[i][4] = b;
                    }
                }
                resettext();
                resetmaindgv();
                selectedproduct = "";

            }
            else
            {
                msg("Please select an item first");
            }
        }

        private void btn_pro_rev_Click(object sender, EventArgs e)
        {
            if (t_pro_harga.Text != "" && t_pro_name.Text != "" && t_pro_stock.Text != "" && cb_pro.SelectedIndex != -1 && selectedproduct != "")
            {
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][0].ToString() == selectedproduct)
                    {
                        dtProdukSimpan.Rows[i].Delete();
                    }
                }
                resettext();
                resetmaindgv();
                selectedproduct = "";
            }
            else
            {
                msg("Please select an item first");
            }
        }

        private void btn_cat_add_Click(object sender, EventArgs e)
        {
            if (t_cat_name.Text != "")
            {
                int count_check = 0;
                for(int i = 0;i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i][1].ToString() == t_cat_name.Text)
                    {
                        count_check++;
                        break;
                    }
                }
                if (count_check == 0)
                {
                    string id = dtCategory.Rows[dtCategory.Rows.Count - 1][0].ToString();
                    id = id.Substring(1, id.Length - 1);
                    dtCategory.Rows.Add("C"+(int.Parse(id)+1).ToString(),t_cat_name.Text);
                    resetcombobox();
                    resetmaindgv();
                    t_cat_name.Text = "";
                    selectedcategory = "";
                }
                else
                {
                    msg("Category has already been added to the list");
                }
            }
            else
            {
                msg("Please fill the name first");
            }
        }

        private void btn_cat_rev_Click(object sender, EventArgs e)
        {
            if (selectedcategory != "")
            {
                for(int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][4].ToString() == selectedcategory)
                    {
                        dtProdukSimpan.Rows[i].Delete();
                        i = -1;
                    }
                }
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i][0].ToString() == selectedcategory)
                    {
                        dtCategory.Rows[i].Delete();
                        break;
                    }
                }
                resetcombobox();
                resetmaindgv();
                selectedcategory = "";
            }
            else
            {
                msg("Please select an item first");
            }
        }

        private void t_pro_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void t_pro_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgv_cat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
