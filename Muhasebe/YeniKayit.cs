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
    public partial class YeniKayit : Form
    {
        string version = "0.04";
        public string[] output = {"",""};
        DirectoryInfo dir;
        public YeniKayit(DirectoryInfo _dir)
        {
            InitializeComponent();
            dir = _dir;
        }

        private void chbSifre_CheckedChanged(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = !tbPass.UseSystemPasswordChar; 
        }

        private void btKaydet_Click(object sender, EventArgs e)
        {
            dir.CreateSubdirectory(tbUserName.Text);
            dir = new DirectoryInfo(dir.FullName + "\\" + tbUserName.Text);

            System.IO.File.WriteAllText(dir.FullName + "\\urunler.txt", version);

            System.IO.File.WriteAllText(dir.FullName + "\\giderler.txt", version);

            string[] st = new string[4];
            st[0] = version;
            st[1] = tbFirma.Text;
            st[2] = tbPass.Text;
            st[3] = "";
            foreach (string gider in tbGider.Text.Split('\n'))
            {
                if(gider != "") st[3] += gider + ";";
            }
            st[3] = st[3].TrimEnd(';');

            System.IO.File.WriteAllLines(dir.FullName + "\\ayarlar.txt", st);
            output[0] = tbUserName.Text;
            output[1] = tbPass.Text;
            this.Hide();
        }

        private void btSil_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
