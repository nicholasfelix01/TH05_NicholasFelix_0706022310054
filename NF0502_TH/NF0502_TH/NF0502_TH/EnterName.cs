using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NF0502_TH
{
    public partial class EnterName : Form
    {

        private CancellationTokenSource entered = new CancellationTokenSource();
        string judul = "Welcome To Mental Illness Shop";
        bool bling = false;
        bool sudah = false;
        string nama;
        public EnterName()
        {
            InitializeComponent();
            judulspesial();
        }

        private async void judulspesial()
        {
            entered.Cancel();
            entered = new CancellationTokenSource();
            CancellationToken ct = entered.Token;
            lbl_title.Text = "";
            foreach (char c in judul)
            {
                if (ct.IsCancellationRequested)
                {
                    return;
                }
                lbl_title.Text += c;
                await Task.Delay(100);
                if (ct.IsCancellationRequested)
                {
                    return;
                }
            }
            if (nama  != null)
            {
                foreach (char c in nama)
                {
                    lbl_nama.Text += c;
                    await Task.Delay(100);
                }
                btn_SN.Visible = true;
            }
        }

        private void t_bling_Tick(object sender, EventArgs e)
        {
            if (bling)
            {
                lbl_pressenter.Text = "(Press Enter)";
                bling = false;
            }
            else
            {
                lbl_pressenter.Text = "";
                bling = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pressenter_Click(object sender, EventArgs e)
        {

        }

        private void lbl_entername_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btn_SN.Visible == true)
                {
                    btn_SN_Click(sender, e);
                }
                if (sudah == true)
                {
                    btn_skip_Click(sender, e);
                }
                nama = string.IsNullOrEmpty(tb_enternama.Text) ? (". . .") : tb_enternama.Text.ToString();
                lbl_entername.Visible = false;
                lbl_pressenter.Visible = false;
                tb_enternama.Visible = false;
                lbl_nama.Visible = true;
                sudah = true;
                judulspesial();
            }
        }

        private void btn_SN_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            this.Hide();
            shop.ShowDialog();
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            this.Hide();
            shop.ShowDialog();
        }
    }
}
