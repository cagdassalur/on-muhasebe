using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Muhasebe
{
    public partial class CariEkle : Form
    {
        public Boolean created = false;
        public Boolean sil = false;
        public Form1.CKart output;
        public CariEkle()
        {
            InitializeComponent();
        }

        public CariEkle(Form1.CKart _kart)
        {
            InitializeComponent();
            btSil.Enabled = true;
            output = _kart;
            tbAd.Text = output.name;
            tbTel.Text = output.telefon;
            tbAdres.Text = output.adres;
            tbMail.Text = output.mail;
            tbNo.Text = output.no;
            tbNo2.Text = output.no2;
            tbNo3.Text = output.no3;
            tbBakiye.Text = output.bakiyeToplam.ToString();
        }

        private void btIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btKaydet_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            created = true;
            Form1.CKart outKart = new Form1.CKart(tbAd.Text, tbAdres.Text, tbTel.Text, tbMail.Text, tbNo.Text, tbNo2.Text, tbNo3.Text, double.Parse(tbBakiye.Text));
            if (output != null)
            {
                outKart.odemeList = output.odemeList;
                outKart.faturaList = output.faturaList;
                outKart.faturaToplam = output.faturaToplam;
                outKart.odemeToplam = output.odemeToplam;
                outKart.cariToplam = output.cariToplam - double.Parse(tbBakiye.Text);
            }

            output = outKart;
            this.Hide();
        }

        private bool check()
        {
            double number1 = 0;
            if (!double.TryParse(tbBakiye.Text, out number1))
            {
                MessageBox.Show("Bakiye değeri sadece sayı olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (tbAd.Text == "")
            {
                MessageBox.Show("Lütfen firma adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btSil_Click(object sender, EventArgs e)
        {
            sil = true;
            this.Hide();
        }
    }
}
