﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Muhasebe
{
    public partial class FaturaGiris : Form
    {
        public Form1.Fatura fatura;
        public Boolean okay = false;
        public Boolean sil = false;

        public FaturaGiris()
        {
            InitializeComponent();
        }

        public FaturaGiris(Form1.Fatura _fatura)
        {
            InitializeComponent();
            fatura = _fatura;
            btSil.Enabled = true;
            tbTarih.Text = fatura.tarih;
            tbNo.Text = fatura.no;
            tbTarih.Text = fatura.irsaliyeNo;
            tbTutar.Text = fatura.tutar.ToString();
        }

        private void btEkle_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                okay = true;
                fatura = new Form1.Fatura(tbTarih.Text, tbNo.Text, tbIrNo.Text, double.Parse(tbTutar.Text));
                this.Hide();
            }
            else MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Check()
        {
            long number1 = 0;
            if (long.TryParse(tbTutar.Text, out number1) && tbTarih.Text != "" && tbIrNo.Text != "") return true;
            else return false;
        }

        private void btIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btSil_Click(object sender, EventArgs e)
        {
            sil = true;
            this.Hide();
        }
    }
}
