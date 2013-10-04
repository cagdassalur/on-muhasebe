﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// TODO: 
// ######### Bütün formlara type kontrolü koy
// *** enter tuşunu formlara bağla
// XXXXXX Gider objesinden index değerini kaldır
// ** gider listesine tarih filtresi ve sütunu ekle
// *** satış ekranında isim tb içinde çıkan listeyi tek tık yap
// ######### k.adı şifre paneli koy
// ######### profil desteği ekle
// XXXXXX User ayarlar.txt dosyasına diger gider tipini ekle
// *************** yeni kullanıcı yaratınca username exists uyarısı
// ***** Kullanıcı sildir



namespace Muhasebe
{
    public partial class Form1 : Form
    {

        double totalPara = 5000;
        string version = "v0.04";
        List<Urun> dBArray = new List<Urun>();
        List<Gider> GiderArray = new List<Gider>();
        List<CKart> KartArray = new List<CKart>();
        public List<Urun_s> SatisArray = new List<Urun_s>();
        DirectoryInfo dir;
        customComplete AutoCompleteObject;
        User user;
        
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\muhasebe");

            user = oku(login(getKadi().ToArray()));

            AutoCompleteObject = new customComplete(dBArray);
            updateLabelFiyat();

            lvDbUpdate();
            lvGiderUpdate();
            lvSatisUpdate();
            updateLabelToplamFiyat();
            GiderKaydir(false);
        }


        private string login(String[] KAdiList)
        {
            SifrePanel sifrepanel = new SifrePanel(KAdiList.ToArray(),dir);
            sifrepanel.ShowDialog();
            return sifrepanel.returnKadi;
        }

        private List<string> getKadi()
        {
            List<string> kAdiTemp = new List<string>();
            foreach (DirectoryInfo st in dir.GetDirectories())
            {
                string sifre = "";
                using (StreamReader sr = new StreamReader(st.FullName + "\\ayarlar.txt"))
                {
                    sifre = sr.ReadToEnd().Split('\n')[2];
                }
                kAdiTemp.Add(st.FullName.Split('\\').Last()+";"+sifre.Replace("\r",""));
            }
            return kAdiTemp;
        }

        private User oku(string username)
        {
            dir = new DirectoryInfo(dir.FullName + "\\" + username);
           
            foreach (string line in System.IO.File.ReadAllLines(dir.FullName + "\\urunler.txt"))
            {
                String[] data = line.Split(';');
                if (data.Length < 3) continue;
                dBArray.Add(new Urun(Convert.ToInt32(data[0]),data[1],Convert.ToInt32(data[2])));
            }

            foreach (string line in System.IO.File.ReadAllLines(dir.FullName + "\\giderler.txt"))
            {
                String[] data = line.Split(';');
                if (data.Length < 4) continue;
                GiderArray.Add(new Gider(data[0], Convert.ToInt32(data[1]), Convert.ToDouble(data[2]), Convert.ToInt32(data[3])));
            }

            String[] ayarlarArray = System.IO.File.ReadAllText(dir.FullName + "\\ayarlar.txt").Split('\n');
            ayarlarArray[3] = ayarlarArray[3].Replace("\n", "").Replace("\r","");
            List<String> giders = new List<string>();
            foreach (string s in ayarlarArray[3].Split(';'))
            {
                if (s != "") giders.Add(s);
            }
            return new User(username, ayarlarArray[1], giders.ToArray(), this);
        }

        private void yaz()
        {
            int count = dBArray.Count;
            string[] lines = new string[count+1];
            lines[0] = version;
            for (int i=0; i<count; i++)
            {
                Urun urun = dBArray[i];
                lines[i+1] = urun.id + ";" + urun.name + ";" + urun.amount.ToString();
            }
            System.IO.File.WriteAllLines(dir.FullName + "\\urunler.txt", lines);

            int count2 = GiderArray.Count;
            String[] lines2 = new string[count2+1];
            lines2[0] = version;
            for (int i = 0; i < count2; i++)
            {
                Gider gider = GiderArray[i];
                lines2[i+1] = gider.tur + ";" + gider.miktar.ToString() + ";" + gider.fiyat.ToString() + ";" + gider.index.ToString();
            }
            System.IO.File.WriteAllLines(dir.FullName + "\\giderler.txt", lines2);

        }

        #region Database Tab
        private void dBAddColumns()
        {
            lvDb.Clear();
            foreach (var header in new Dictionary<string, int> {
                {"Ürün Kodu",90},
                {"Ürün Adı",100},
                {"Stok Miktarı", 100}})
            {
                ColumnHeader tmp_header = new ColumnHeader();
                tmp_header.Text = header.Key;
                tmp_header.Width = header.Value;
                lvDb.Columns.Add(tmp_header);
            }
        }

        private void lvDbUpdate()
        {
            lvDb.SelectedIndices.Clear();
            dBAddColumns();
            foreach (Urun urun in dBArray)
            {
                String[] row = { urun.id.ToString(), urun.name, urun.amount.ToString() };
                var item = new ListViewItem(row);
                if (urun.amount < 1) item.SubItems[2].ForeColor = Color.IndianRed;
                else if (urun.amount < 5) item.SubItems[2].ForeColor = Color.DarkOrange;
                item.UseItemStyleForSubItems = false;
                lvDb.Items.Add(item);
            }

            tbSatis.AutoCompleteCustomSource = AutoCompleteObject.update(dBArray);
        }

        private void btUrunEkle_Click(object sender, EventArgs e)
        {
            if (!DbCheck()) return;

            dBArray.Add(new Urun(lvDb.Items.Count + 914, tbUrunAdi.Text, (int)nudStok.Value));

            lvDbUpdate();
        }

        private void lvDb_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                btDbSil.Enabled = true;
                btKaydet.Enabled = true;
                Urun seciliUrun = dBArray[e.ItemIndex];
                tbUrunAdi.Text = seciliUrun.name;
                nudStok.Value = seciliUrun.amount;
            }
            else
            {
                btDbSil.Enabled = false;
                btKaydet.Enabled = false;
                tbUrunAdi.Text = "";
                nudStok.Value = 0;
            }
        }

        private void btDbSil_Click(object sender, EventArgs e)
        {
            dBArray.RemoveAt(lvDb.SelectedIndices[0]);
            lvDb.SelectedIndices.Clear();
            lvDbUpdate();
        }

        private void btKaydet_Click(object sender, EventArgs e)
        {
            if (!DbCheck()) return;

            dBArray[lvDb.SelectedIndices[0]] = new Urun(dBArray[lvDb.SelectedIndices[0]].id, tbUrunAdi.Text, (int)nudStok.Value);
            lvDbUpdate();
        }

        private bool DbFieldCheck()
        {
            if (tbUrunAdi.Text != "" && nudStok.Value != 0) return true;
            else return false;
        }

        private bool DbCheck()
        {
            if (!DbFieldCheck()) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else return true;

            return false;
        }

        public class Urun
        {
            public int id;
            public string name;
            public int amount;

            public Urun() { }
            public Urun(int _id, string _name, int _amount)
            {
                this.id = _id;
                this.name = _name;
                this.amount = _amount;
            }

            public void stokDus(int n)
            {
                amount -= n;
            }
        }
        #endregion

        #region Gider Tab
        private void lvGiderAddColumns()
        {
            lvGider.Clear();
            foreach (var header in new Dictionary<string, int> {
                {"Tür",90},
                {"Miktar",100},
                {"Fiyat",60},
                {"Maliyet", 90}})
            {
                ColumnHeader tmp_header = new ColumnHeader();
                tmp_header.Text = header.Key;
                tmp_header.Width = header.Value;
                lvGider.Columns.Add(tmp_header);
            }
        }

        private void lvGiderUpdate()
        {
            totalPara = 5000;
            lvGider.SelectedIndices.Clear();
            lvGiderAddColumns();
            foreach (Gider gider in GiderArray)
            {
                String[] row = { gider.tur, gider.miktar.ToString(), "₤" + gider.fiyat.ToString("N2"), "₤" + gider.masraf.ToString("N2") };
                var item = new ListViewItem(row);
                lvGider.Items.Add(item);
                totalPara -= gider.masraf;
            }
            //slPara.Text = "Toplam Para: " + totalPara.ToString();
        }

        private void btGiderEkle_Click(object sender, EventArgs e)
        {
            if (!GiderCheck()) return;

            string tur;
            int index;

            if (tbGiderDiger.Visible)
            {
                tur = tbGiderDiger.Text;
                index = -2;
            }
            else 
            {
                tur = cbGider.SelectedItem.ToString();
                index = cbGider.SelectedIndex;
            }

            GiderArray.Add(new Gider(tur, (int)nudGiderMiktar.Value, Convert.ToDouble(tbFiyat.Text), index));
            lvGiderUpdate();
        }

        private void lvGider_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                btGiderSil.Enabled = true;
                btGiderKaydet.Enabled = true;

                Gider seciliGider = GiderArray[e.ItemIndex];

                if (seciliGider.index == -2)
                {
                    cbGider.SelectedIndex = cbGider.Items.Count - 1;
                    tbGiderDiger.Text = seciliGider.tur;
                }
                else cbGider.SelectedIndex = seciliGider.index;

                tbFiyat.Text = seciliGider.fiyat.ToString();
                nudGiderMiktar.Value = seciliGider.miktar;
            }
            else
            {
                btGiderSil.Enabled = false;
                btGiderKaydet.Enabled = false;
                cbGider.SelectedIndex = -1;
                tbFiyat.Text = "";
                nudGiderMiktar.Value = 0;
            }
        }

        private void btGiderSil_Click(object sender, EventArgs e)
        {
            GiderArray.RemoveAt(lvGider.SelectedIndices[0]);
            lvGider.SelectedIndices.Clear();
            lvGiderUpdate();
        }

        private void btGiderKaydet_Click(object sender, EventArgs e)
        {
            if (!GiderCheck()) return;

            string tur;
            int index;

            if (tbGiderDiger.Visible)
            {
                tur = tbGiderDiger.Text;
                index = -2;
            }
            else
            {
                tur = cbGider.SelectedItem.ToString();
                index = cbGider.SelectedIndex;
            }

            GiderArray[lvGider.SelectedIndices[0]] = new Gider(tur, (int)nudGiderMiktar.Value, Convert.ToDouble(tbFiyat.Text), index);
            lvGiderUpdate();
        }

        private void GiderKaydir(Boolean check)
        {
            if (check)
            {
                tbGiderDiger.Text = "";
                labelDiger.Visible = true;
                tbGiderDiger.Visible = true;
            }
            else
            {
                labelDiger.Visible = false;
                tbGiderDiger.Visible = false;
            }
            
        }

        private void cbGider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGider.SelectedIndex != -1 && cbGider.SelectedItem.ToString() == "Diğer") GiderKaydir(true);
            else GiderKaydir(false);
        }

        private bool GiderFieldCheck()
        {
            bool diger;

            if (tbGiderDiger.Visible) diger = tbGiderDiger.Text != "";
            else diger = cbGider.SelectedIndex != -1;

            if (diger && tbFiyat.Text != "" && nudGiderMiktar.Value != 0) return true;
            else return false;
        }

        private bool GiderTypeCheck()
        {
            long number1 = 0;
            return long.TryParse(tbFiyat.Text, out number1);
        }

        private bool GiderCheck()
        {
            if (!GiderFieldCheck()) MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!GiderTypeCheck()) MessageBox.Show("\"Fiyat\" alanına bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else return true;

            return false;
        }

        public class Gider
        {
            public string tur;
            public int miktar;
            public double masraf;
            public double fiyat;
            public int index;

            public Gider() { }
            public Gider(string _tur, int _miktar, double _fiyat, int _index)
            {
                this.tur = _tur;
                this.fiyat = _fiyat;
                this.miktar = _miktar;
                this.masraf = this.miktar * this.fiyat;
                this.index = _index;
            }
        }
        #endregion

        #region Satış Tab

        private void updateLabelFiyat()
        {
            double fiyat;
            if (double.TryParse(tbSatisFiyat.Text, out fiyat)) labelFiyat.Text = (fiyat * (int)nudSatisAdet.Value).ToString("N2") + "TL";
            else labelFiyat.Text = "ERROR";
        }

        private void updateLabelToplamFiyat() 
        {
            double toplam = 0;

            foreach (Urun_s urun in SatisArray)
            {
                toplam += urun.masraf;
            }

            labelToplamFiyat.Text = toplam.ToString("N2") + " TL";
        }

        private void lvSatisAddColumns()
        {
            lvSatis.Clear();
            foreach (var header in new Dictionary<string, int> {
                {"ID",50},
                {"Urun",141},
                {"Fiyat",60},
                {"Adet", 60},
                {"Maliyet", 90}})
            {
                ColumnHeader tmp_header = new ColumnHeader();
                tmp_header.Text = header.Key;
                tmp_header.Width = header.Value;
                lvSatis.Columns.Add(tmp_header);
            }
        }

        private void lvSatisUpdate()
        {
            lvSatis.SelectedIndices.Clear();
            lvSatisAddColumns();
            foreach (Urun_s satis in SatisArray)
            {
                String[] row = { satis.id.ToString(), satis.name, "₤" + satis.fiyat.ToString("N"), satis.miktar.ToString(), "₤" + satis.masraf.ToString("N")};
                var item = new ListViewItem(row);
                lvSatis.Items.Add(item);
            }
        }

        private void lvSatis_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                btSatisSil.Enabled = true;
                btSatisKaydet.Enabled = true;

                Urun_s urun = SatisArray[e.ItemIndex];

                tbSatis.Text = urun.name;
                nudSatisAdet.Value = urun.miktar;
                tbSatisFiyat.Text = urun.fiyat.ToString();
            }
            else
            {
                btSatisSil.Enabled = false;
                btSatisKaydet.Enabled = false;
                tbSatis.Text = "";
                nudSatisAdet.Value = 0;
                tbSatisFiyat.Text = "0";
            }

            updateLabelFiyat();
        }

        private bool SatisCheck()
        {
            double n;

            if (tbSatis.Text == "") MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (nudSatisAdet.Value == 0) MessageBox.Show("Adet 0 olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Double.TryParse(tbFiyat.Text, out n))  MessageBox.Show("Fiyat geçerli değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else return true;

            return false;
        }

        private void btSatisEkle_Click(object sender, EventArgs e)
        {
            if (!SatisCheck()) return;

            string id = tbSatis.Text.Split('-')[0];
            id = id.Remove(id.Length - 1);
            double n;

            if (Double.TryParse(id, out n)) SatisArray.Add(new Urun_s((int)n, (int)nudSatisAdet.Value, Double.Parse(tbSatisFiyat.Text), this));
            else SatisArray.Add(new Urun_s(tbSatis.Text, (int)nudSatisAdet.Value, Double.Parse(tbSatisFiyat.Text), this));

            if (SatisArray.Last().tam) { lvSatisUpdate(); updateLabelToplamFiyat(); return; }

            MessageBox.Show("Ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SatisArray.Remove(SatisArray.Last());
            lvSatisUpdate();
        }

        private void btSatisSil_Click(object sender, EventArgs e)
        {
            SatisArray.RemoveAt(lvSatis.SelectedIndices[0]);
            lvSatis.SelectedIndices.Clear();
            lvSatisUpdate();
            updateLabelToplamFiyat();
        }

        private void btSatisKaydet_Click(object sender, EventArgs e)
        {
            if (!SatisCheck()) return;

            string id = tbSatis.Text.Split('-')[0];
            id = id.Remove(id.Length - 1);
            double n;

            if (Double.TryParse(id, out n)) SatisArray[lvSatis.SelectedIndices[0]] = new Urun_s((int)n, (int)nudSatisAdet.Value, Double.Parse(tbSatisFiyat.Text), this);
            else SatisArray[lvSatis.SelectedIndices[0]] = new Urun_s(tbSatis.Text, (int)nudSatisAdet.Value, Double.Parse(tbSatisFiyat.Text), this);

            lvSatisUpdate();
            updateLabelFiyat();
            updateLabelToplamFiyat();
        }

        private void btSat_Click(object sender, EventArgs e)
        {
            foreach (Urun_s urun_s in SatisArray)
            {
                for (int i = 0; i < dBArray.Count(); i++)
                {
                    if (dBArray[i].id == urun_s.id) dBArray[i].stokDus(urun_s.miktar);
                }
            }

            SatisArray.Clear();
            lvSatisUpdate();
            totalPara += double.Parse(labelToplamFiyat.Text.Split(' ')[0].Replace(",", ""));
            updateLabelToplamFiyat();
            lvDbUpdate();
        }

        private void nudSatisAdet_ValueChanged(object sender, EventArgs e)
        {
            updateLabelFiyat();
        }

        private void tbSatisFiyat_TextChanged(object sender, EventArgs e)
        {
            updateLabelFiyat();
        }

        public class customComplete
        {
            public List<Urun> urunler;
            public AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            public customComplete() { }
            public customComplete(List<Urun> _urunler)
            {
                this.urunler = _urunler;
                this.update(urunler);
            }

            public AutoCompleteStringCollection update(List<Urun> _urunler)
            {
                this.urunler = _urunler;
                List<string> st = new List<string>();
                foreach (Urun urun in urunler)
                {
                    st.Add(urun.name);
                    st.Add(urun.id + " - " + urun.name);
                }
                source = new AutoCompleteStringCollection();
                source.AddRange(st.ToArray());
                return source;
            }
        }

        public class Urun_s
        {
            public int id;
            public string name;
            public int miktar;
            public double masraf;
            public double fiyat;
            private Form1 v;
            public bool tam = false;

            public Urun_s() { }
            public Urun_s(int _id, int _miktar, double _fiyat, Form1 _v)
            {
                this.id = _id;
                this.fiyat = _fiyat;
                this.miktar = _miktar;
                this.masraf = this.miktar * this.fiyat;
                this.v = _v;

                foreach (Urun urun in v.dBArray)
                {
                    if (urun.id == this.id)
                    {
                        this.name = urun.name;
                        tam = true;
                        break;
                    }
                }
            }

            public Urun_s(string _name, int _miktar, double _fiyat, Form1 _v)
            {
                this.name = _name;
                this.fiyat = _fiyat;
                this.miktar = _miktar;
                this.masraf = this.miktar * this.fiyat;
                this.v = _v;

                foreach (Urun urun in v.dBArray)
                {
                    if (urun.name == this.name)
                    {
                        this.id = urun.id;
                        tam = true;
                        break;
                    }
                }
            }


        }
        #endregion

        #region Cariye

        private void btCariEkle_Click(object sender, EventArgs e)
        {
            CariEkle cariEkle = new CariEkle();
            cariEkle.ShowDialog();
        }

        public class CKart
        {
            public string name;
            public string adres;
            public string telefon;
            public string mail;
            public string no;
            public string no2;
            public string no3;

            public CKart(string _name, string _adres, string _telefon, string _mail,
                string _no, string _no2, string _no3)
            {
                name = _name;
                adres = _adres;
                telefon = _telefon;
                mail = _mail;
                no = _no;
                no2 = _no2;
                no3 = _no3;
            }
        }

        #endregion

        public class User
        {
            public string title;
            public string username;
            public string[] giderler;
            private Form1 v;

            public User() { }
            public User(string _username, string _title, string[] _giderler, Form1 _v)
            {
                this.username = _username;
                this.giderler = _giderler;
                this.title = _title.Replace("\n","").Replace("\r","").Trim();
                this.v = _v;
                v.stlabelIsım.Text = title;
                v.labelSirket.Text = title;
                v.labelSirket.Update();
                v.cbGider.Items.Clear();
                foreach (string gider in giderler) v.cbGider.Items.Add(gider);
                v.cbGider.Items.Add("Diğer");
                v.cbGider.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yaz();
            MessageBox.Show("oldu");
        }






    }
}
