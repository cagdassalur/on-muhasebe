using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Muhasebe
{
    public partial class SifrePanel : Form
    {
        List<string> kAdi;
        List<string> sifre;
        DirectoryInfo dir;
        public string returnKadi;
        public bool closed = false;

        public SifrePanel(String[] kAdiList, DirectoryInfo _dir)
        {
            InitializeComponent();
            kAdi = new List<string>();
            sifre = new List<string>();
            dir = _dir;

            foreach (string st in kAdiList)
            {
                String[] data = st.Split(';');
                kAdi.Add(data[0]);
                sifre.Add(data[1]);
            }

            if (kAdi.Count < 1) cbKAdi.Text = "( Kullanıcı Yok )";
            else foreach (string kAdi1 in kAdi) cbKAdi.Items.Add(kAdi1);
            if(cbKAdi.Items.Count > 0) cbKAdi.SelectedIndex = 0;

            //tbSifre.Text = "1234"; // TEST!
        }

        private void SifrePanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) closed = true;
        }

        private void tbSifre_TextChanged(object sender, EventArgs e)
        {
            if (tbSifre.Text != "" && cbKAdi.Text != "( Kullanıcı Yok )") btGiris.Enabled = true;
            else btGiris.Enabled = false;
        }

        private void chbSifre_CheckedChanged(object sender, EventArgs e)
        {
            tbSifre.UseSystemPasswordChar = !tbSifre.UseSystemPasswordChar; 
        }

        private void btGiris_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kAdi.Count; i++ )
            {
                if (kAdi[i] == cbKAdi.SelectedItem.ToString()) 
                {
                    if (sifre[i] == tbSifre.Text) { returnKadi = kAdi[i]; this.Hide(); return; }
                    else MessageBox.Show("Hatalı Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btYeni_Click(object sender, EventArgs e)
        {
            YeniKayit yeniKayit = new YeniKayit(dir);
            yeniKayit.ShowDialog();
            kAdi.Add(yeniKayit.output[0]);
            cbKAdi.Items.Add(yeniKayit.output[0]);
            sifre.Add(yeniKayit.output[1]);
            cbKAdi.SelectedIndex = 0;
        }

        private void SifrePanel_Load(object sender, EventArgs e)
        {
        }


    }
}
