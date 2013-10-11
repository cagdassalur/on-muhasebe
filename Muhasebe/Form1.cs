using System;
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
using System.Web.Script.Serialization;

// TODO: 
// ** bazı form tb kontrollerinde yıldız olacak onları koy
// ** Kullanıcı sildir / user already exsists uyarısı
// * yeni kart ekranına giderler açıklaması koy http://stackoverflow.com/questions/14544135/how-to-gray-out-default-text-in-textbox
// 3.
// ** Urun objesine birim ekle 
// *** Ekran kaplanacak
// ***** User objesi için ayar ekranı koy
// 2.
// *** satış ekranında isim tb içinde çıkan listeyi tek tık yap
// 1.
// ** MenuStrip koyulacak





namespace Muhasebe
{
    public partial class Form1 : Form
    {      
        string version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
        List<Urun> dBArray = new List<Urun>();
        List<Gider> GiderArray = new List<Gider>();
        List<CKart> KartArray = new List<CKart>();
        List<Satis> TSatisArray = new List<Satis>();
        public List<Urun_s> SatisArray = new List<Urun_s>();
        DirectoryInfo dir;
        customComplete AutoCompleteObject;
        User user;

        Double raporGelirTop;
        Double raporGiderTop;
        
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            
            dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\muhasebe");

            user = oku(login(getKadi().ToArray()));
            foreach (string gider in user.giderler) cbGider.Items.Add(gider);
            cbGider.Items.Add("Diğer");
            cbGider.SelectedIndex = 1;

            AutoCompleteObject = new customComplete(dBArray);
            updateLabelFiyat();

            dtpInit();
            lvDbUpdate();
            lvGiderUpdate();
            lvSatisUpdate();
            lvKartlarUpdate();
            updateLabelToplamFiyat();
            GiderKaydir(false);
            this.AcceptButton = btSatisEkle;
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
            foreach (FileInfo st in dir.GetFiles("*.json"))
            {
                string json = System.IO.File.ReadAllText(st.FullName);
                SaveData savedata = new JavaScriptSerializer().Deserialize<SaveData>(json);
                
                kAdiTemp.Add(savedata.user.username+";"+savedata.user.password);
            }
            return kAdiTemp;
        }

        private User oku(string username)
        {
            string json = System.IO.File.ReadAllText(dir.FullName + "\\" + username + ".json");
            SaveData savedata = new JavaScriptSerializer().Deserialize<SaveData>(json);
            dBArray = savedata.Uruns;
            GiderArray = savedata.Giders;
            KartArray = savedata.CKarts;
            TSatisArray = savedata.TSatislar;
            labelSirket.Text = savedata.user.title;
            stlabelIsım.Text = savedata.user.title;
            return savedata.user;
        }

        private void yaz()
        {
            SaveData savedata = new SaveData(dBArray, GiderArray, KartArray, TSatisArray, user);
            var json = new JavaScriptSerializer().Serialize(savedata);
            System.IO.File.WriteAllText(dir.FullName + "\\" + user.username + ".json" , json);
        }

        private void dtpInit() 
        {
            dtpGelB.Value = DateTime.Today.AddDays((-1 * DateTime.Today.Day)+1);
            dtpGidB.Value = DateTime.Today.AddDays((-1 * DateTime.Today.Day)+1);
            dtpGelS.Value = DateTime.Today;
            dtpGidS.Value = DateTime.Today;
            dtpGider.Value = DateTime.Today;
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
            lvGider.SelectedIndices.Clear();
            lvGiderAddColumns();
            foreach (Gider gider in GiderArray)
            {
                String[] row = { gider.tur, gider.miktar.ToString(), "₤" + gider.fiyat.ToString("N2"), "₤" + gider.masraf.ToString("N2") };
                var item = new ListViewItem(row);
                lvGider.Items.Add(item);
            }
        }

        private void btGiderEkle_Click(object sender, EventArgs e)
        {
            if (!GiderCheck()) return;

            string tur;

            if (tbGiderDiger.Visible) tur = tbGiderDiger.Text;
            else tur = cbGider.SelectedItem.ToString();

            GiderArray.Add(new Gider(tur, (int)nudGiderMiktar.Value, Convert.ToDouble(tbFiyat.Text), dtpGider.Value));
            lvGiderUpdate();
        }

        private void lvGider_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                btGiderSil.Enabled = true;
                btGiderKaydet.Enabled = true;

                Gider seciliGider = GiderArray[e.ItemIndex];

                bool found = false;
                foreach (String tur in user.giderler) found = seciliGider.tur == tur;

                if (found)
                {
                    cbGider.SelectedIndex = cbGider.Items.Count - 1;
                    tbGiderDiger.Text = seciliGider.tur;
                }
                else cbGider.SelectedItem = seciliGider.tur;

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

            if (tbGiderDiger.Visible)tur = tbGiderDiger.Text;
            else tur = cbGider.SelectedItem.ToString();

            GiderArray[lvGider.SelectedIndices[0]] = new Gider(tur, (int)nudGiderMiktar.Value, Convert.ToDouble(tbFiyat.Text), dtpGider.Value);
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
            public DateTime tarih;
            public int miktar;
            public double masraf;
            public double fiyat;

            public Gider() { }
            public Gider(string _tur, int _miktar, double _fiyat, DateTime _tarih)
            {
                this.tur = _tur;
                this.fiyat = _fiyat;
                this.miktar = _miktar;
                this.masraf = this.miktar * this.fiyat;
                this.tarih = _tarih;
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

            TSatisArray.Add(new Satis(SatisArray));
            SatisArray.Clear();
            lvSatisUpdate();
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

        public class Satis 
        {
            public List<Urun_s> SatisArray;
            public DateTime tarih;
            public Double fiyat = 0;
            public Satis() { }
            public Satis(List<Urun_s> _SatisArray) 
            {
                SatisArray = _SatisArray;
                tarih = DateTime.Today;
                foreach (Urun_s urun in SatisArray)
                {
                    fiyat += urun.masraf;
                }
            }
        }
        #endregion

        #region Cariye

        private void lvKartlarAddColumns() 
        {
            lvKartlar.Clear();
            foreach (var header in new Dictionary<string, int> {
                {"Firma Adı",133},
                {"Faturalar Toplamı",103},
                {"Yapılan Ödemeler",107},
                {"Kalan Borç Miktarı", 111}})
            {
                ColumnHeader tmp_header = new ColumnHeader();
                tmp_header.Text = header.Key;
                tmp_header.Width = header.Value;
                lvKartlar.Columns.Add(tmp_header);
            }
        }

        private void lvKartlarUpdate()
        {
            lvKartlar.SelectedIndices.Clear();
            lvKartlarAddColumns();
            foreach (CKart kart in KartArray)
            {
                String[] row = { kart.name, kart.faturaToplam.ToString(),
                                   kart.odemeToplam.ToString(),
                                   kart.cariToplam.ToString() };
                var item = new ListViewItem(row);
                lvKartlar.Items.Add(item);
            }
        }

        private void lvKartlar_DoubleClick(object sender, EventArgs e)
        {
            KartView kartView = new KartView(KartArray[lvKartlar.SelectedIndices[0]]);
            kartView.ShowDialog();
            if (kartView.okay)
            {
                KartArray[lvKartlar.SelectedIndices[0]] = kartView.kart;
                lvKartlarUpdate();
            }
        }

        private void cmsEkle_Click(object sender, EventArgs e)
        {
            CariEkle cariEkle = new CariEkle();
            cariEkle.ShowDialog();
            if (cariEkle.created)
            {
                KartArray.Add(cariEkle.output);
                lvKartlarUpdate();
            }
        }

        private void tsmiDuzenle_Click(object sender, EventArgs e)
        {
            CariEkle cariEkle = new CariEkle(KartArray[lvKartlar.SelectedIndices[0]]);
            cariEkle.ShowDialog();
            if (cariEkle.created)
            {
                KartArray[lvKartlar.SelectedIndices[0]] = cariEkle.output;
                lvKartlarUpdate();
            }
            else if (cariEkle.sil)
            {
                KartArray.RemoveAt(lvKartlar.SelectedIndices[0]);
                lvKartlarUpdate();
            }
        }

        private void cmsKart_Opened(object sender, EventArgs e)
        {
            if (lvKartlar.SelectedIndices.Count < 1) tsmiDuzenle.Enabled = false;
            else tsmiDuzenle.Enabled = true;
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

            public List<Odeme> odemeList;
            public List<Fatura> faturaList;

            public double faturaToplam;
            public double bakiyeToplam;
            public double odemeToplam;

            public double borcToplam = 0;
            public double cariToplam = 0;

            public CKart() { }
            public CKart(string _name, string _adres, string _telefon, string _mail,
                string _no, string _no2, string _no3, double _bakiye)
            {
                name = _name;
                adres = _adres;
                telefon = _telefon;
                mail = _mail;
                no = _no;
                no2 = _no2;
                no3 = _no3;
                bakiyeToplam = _bakiye;

                odemeList = new List<Odeme>();
                faturaList = new List<Fatura>();
            }
        }

        public class Fatura
        {
            public DateTime tarih; /// TYPE DATETIME OLACAK
            public string no;
            public string irsaliyeNo;
            public double tutar;

            public Fatura() { }
            public Fatura(DateTime _tarih, string _no, string _irsaliyeNo,double _tutar)
            {
                tarih = _tarih;
                no = _no;
                irsaliyeNo = _irsaliyeNo;
                tutar = _tutar;
            }
        }

        public class Odeme 
        {
            public DateTime tarih; /// TYPE DATETIME OLACAK
            public string odemeSekli;
            public double tutar;
            public string aciklama;

            public Odeme() { }
            public Odeme(DateTime _tarih, string _odemeSekli,
                double _tutar, string _aciklama)
            {
                tarih = _tarih;
                odemeSekli = _odemeSekli;
                tutar = _tutar;
                aciklama = _aciklama;
            }
        }

        #endregion

        #region Rapor Tab

        private void lvRGelirAddColumns()
        {
            lvRGelir.Clear();
            foreach (var header in new Dictionary<string, int> {
                {"Tür",96},
                {"Tarih",95},
                {"Tutar",87}})
            {
                ColumnHeader tmp_header = new ColumnHeader();
                tmp_header.Text = header.Key;
                tmp_header.Width = header.Value;
                lvRGelir.Columns.Add(tmp_header);
            }
        }

        private void lvRGiderAddColumns()
        {
            lvRGider.Clear();
            foreach (var header in new Dictionary<string, int> {
                {"Tür",96},
                {"Tarih",95},
                {"Tutar",87}})
            {
                ColumnHeader tmp_header = new ColumnHeader();
                tmp_header.Text = header.Key;
                tmp_header.Width = header.Value;
                lvRGider.Columns.Add(tmp_header);
            }
        }

        private void lvRGelirUpdate()
        {
            raporGelirTop = 0;
            lvRGelir.SelectedIndices.Clear();
            lvRGelirAddColumns();
            foreach (Satis gelir in TSatisArray)
            {
                if (gelir.tarih.CompareTo(dtpGelB.Value) < 0 || gelir.tarih.CompareTo(dtpGelS.Value) > 0) continue;
                String[] row = { "Satış", gelir.tarih.ToShortDateString(), "₤" + gelir.fiyat.ToString("N") };
                var item = new ListViewItem(row);
                lvRGelir.Items.Add(item);
                raporGelirTop += gelir.fiyat;
            }
            labelRapor.Text = (raporGelirTop - raporGiderTop).ToString("N") + " TL";
        }

        private void lvRGiderUpdate()
        {
            raporGiderTop = 0;
            lvRGider.SelectedIndices.Clear();
            lvRGiderAddColumns();
            foreach (CKart kart in KartArray)
            {
                foreach (Odeme odeme in kart.odemeList)
                {
                    if (odeme.tarih.CompareTo(dtpGidB.Value) < 0 || odeme.tarih.CompareTo(dtpGidS.Value) > 0) continue;
                    String[] row = { kart.name, odeme.tarih.ToShortDateString(), "₤" + odeme.tutar.ToString("N2") };
                    var item = new ListViewItem(row);
                    lvRGider.Items.Add(item);
                    raporGiderTop += odeme.tutar;
                }
                labelRapor.Text = (raporGelirTop - raporGiderTop).ToString("N") + " TL";
            }

            foreach (Gider gider in GiderArray)
            {
                if (gider.tarih.CompareTo(dtpGidB.Value) < 0 || gider.tarih.CompareTo(dtpGidS.Value) > 0) continue;
                String[] row = {gider.tur, gider.tarih.ToShortDateString(), "₤" + gider.masraf.ToString("N2")};
                var item = new ListViewItem(row);
                lvRGider.Items.Add(item);
            }
        }

        private void dtpGelB_ValueChanged(object sender, EventArgs e)
        {
            lvRGelirUpdate();
        }

        private void dtpGelS_ValueChanged(object sender, EventArgs e)
        {
            lvRGelirUpdate();
        }

        private void dtpGidB_ValueChanged(object sender, EventArgs e)
        {
            lvRGiderUpdate();
        }

        private void dtpGidS_ValueChanged(object sender, EventArgs e)
        {
            lvRGiderUpdate();
        }

        #endregion

        public class User
        {
            public string title { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string[] giderler { get; set; }
            private Form1 v;

            public User() { }
            public User(string _username, string _title, string[] _giderler, string _pass, Form1 _v)
            {
                this.username = _username;
                this.giderler = _giderler;
                this.title = _title;
                this.password = _pass;
                this.v = _v;
                v.stlabelIsım.Text = title;
                v.labelSirket.Text = title;
                v.labelSirket.Update();
                v.cbGider.Items.Clear();
                foreach (string gider in giderler) v.cbGider.Items.Add(gider);
                v.cbGider.Items.Add("Diğer");
                v.cbGider.SelectedIndex = 0;
            }
            public User(string _username, string _title, string[] _giderler, string _pass)
            {
                this.username = _username;
                this.giderler = _giderler;
                this.title = _title;
                this.password = _pass;
            }
        }

        public class SaveData 
        {
            public List<Urun> Uruns { get; set; }
            public List<Gider> Giders { get; set; }
            public List<CKart> CKarts { get; set; }
            public List<Satis> TSatislar { get; set; }
            public User user { get; set; }

            public SaveData() { }
            public SaveData(List<Urun> _Uruns, List<Gider> _Giders, List<CKart> _CKarts, List<Satis> _TSatislar, User _user) 
            {
                Uruns = _Uruns;
                Giders = _Giders;
                CKarts = _CKarts;
                user = _user;
                TSatislar = _TSatislar;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    this.AcceptButton = btSatisEkle;
                    break;
                case 1:
                    this.AcceptButton = btGiderEkle;
                    break;
                case 3:
                    this.AcceptButton = btUrunEkle;
                    break;
                case 4:
                    lvRGelirUpdate();
                    lvRGiderUpdate();
                    break;
                default:
                    break;
            }
        }

        private void tsmiKaydet_Click(object sender, EventArgs e)
        {
            yaz();
            MessageBox.Show("Başarıyla kaydedildi","Kaydet",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void hesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void stokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }



    }
}
