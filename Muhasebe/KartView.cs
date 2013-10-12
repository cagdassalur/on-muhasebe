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
    public partial class KartView : Form
    {
        public Form1.CKart kart;
        public Boolean okay = false;
        public KartView(Form1.CKart _kart)
        {
            InitializeComponent();
            kart = _kart;
            labelSirket.Text = kart.name;
            lvFaturaUpdate();
            lvOdemeUpdate();
        }

        #region Odeme
        private void lvOdemeAddColumns()
        {
            lvOdeme.Clear();
            foreach (var header in new Dictionary<string, int> {
                {"No",30},
                {"Ödeme Tarihi",80},
                {"Ödeme Şekli",129},
                {"Tutar",70}})
            {
                ColumnHeader tmp_header = new ColumnHeader();
                tmp_header.Text = header.Key;
                tmp_header.Width = header.Value;
                lvOdeme.Columns.Add(tmp_header);
            }
        }

        private void lvOdemeUpdate()
        {
            lvOdeme.SelectedIndices.Clear();
            lvOdemeAddColumns();
            int i = 0;
            foreach (Form1.Odeme odeme in kart.odemeList)
            {
                String[] row = { (i+1).ToString(), odeme.tarih.ToShortDateString(), odeme.odemeSekli,
                                   "₤" + odeme.tutar.ToString("N2") };
                var item = new ListViewItem(row);
                lvOdeme.Items.Add(item);
                i++;
            }
            kartInfoUpdate();
        }

        private void tsmiEkle_Click(object sender, EventArgs e)
        {
            OdemeGiris odemeGiris = new OdemeGiris();
            odemeGiris.ShowDialog();
            if (odemeGiris.okay)
            {
                kart.odemeList.Add(odemeGiris.odeme);
                lvOdemeUpdate();
                okay = true;
            }
        }

        private void lvOdeme_DoubleClick(object sender, EventArgs e)
        {
            OdemeGiris odemeGiris = new OdemeGiris(kart.odemeList[lvOdeme.SelectedIndices[0]]);
            odemeGiris.ShowDialog();
            if (odemeGiris.okay)
            {
                kart.odemeList[lvOdeme.SelectedIndices[0]] = odemeGiris.odeme;
                lvFaturaUpdate();
            }
            else if (odemeGiris.sil)
            {
                kart.odemeList.RemoveAt(lvOdeme.SelectedIndices[0]);
                lvOdemeUpdate();
            }
        }
        #endregion

        #region Fatura
        private void lvFaturaAddColumns()
        {
            lvFatura.Clear();
            foreach (var header in new Dictionary<string, int> {
                {"No",30},
                {"Fatura Tarihi",80},
                {"Fatura No",70},
                {"İrsaliye No", 70},
                {"Tutar",60}})
            {
                ColumnHeader tmp_header = new ColumnHeader();
                tmp_header.Text = header.Key;
                tmp_header.Width = header.Value;
                lvFatura.Columns.Add(tmp_header);
            }
        }

        private void lvFaturaUpdate()
        {
            lvFatura.SelectedIndices.Clear();
            lvFaturaAddColumns();
            int i = 0;
            foreach (Form1.Fatura fatura in kart.faturaList)
            {
                String[] row = { (i+1).ToString(), fatura.tarih.ToShortDateString(), fatura.no,
                                   fatura.irsaliyeNo, "₤" + fatura.tutar.ToString("N2") };
                var item = new ListViewItem(row);
                lvFatura.Items.Add(item);
                i++;
            }
            kartInfoUpdate();
        }

        private void cmsmiFatEkle_Click(object sender, EventArgs e)
        {
            FaturaGiris faturaGiris = new FaturaGiris();
            faturaGiris.ShowDialog();
            if (faturaGiris.okay)
            {
                kart.faturaList.Add(faturaGiris.fatura);
                lvFaturaUpdate();
                okay = true;
            }
        }

        private void lvFatura_DoubleClick(object sender, EventArgs e)
        {
            FaturaGiris faturaGiris = new FaturaGiris(kart.faturaList[lvFatura.SelectedIndices[0]]);
            faturaGiris.ShowDialog();
            if (faturaGiris.okay)
            {
                kart.faturaList[lvFatura.SelectedIndices[0]] = faturaGiris.fatura;
                lvFaturaUpdate();
            }
            else if (faturaGiris.sil)
            {
                kart.faturaList.RemoveAt(lvFatura.SelectedIndices[0]);
                lvFaturaUpdate();
            }
        }
        #endregion

        private void kartInfoUpdate()
        {
            kart.odemeToplam = 0;
            kart.faturaToplam = 0;
            foreach (Form1.Odeme odeme in kart.odemeList) kart.odemeToplam += odeme.tutar;
            foreach (Form1.Fatura fatura in kart.faturaList) kart.faturaToplam += fatura.tutar;

            kart.borcToplam = kart.faturaToplam + kart.bakiyeToplam;
            kart.cariToplam = kart.borcToplam - kart.odemeToplam;

            labelToplam.Text = kart.faturaToplam.ToString();
            labelEski.Text = kart.bakiyeToplam.ToString();
            labelBorc.Text = kart.borcToplam.ToString();
            labelOdeme.Text = kart.odemeToplam.ToString();
            labelCari.Text = kart.cariToplam.ToString();
        }
    }
}
