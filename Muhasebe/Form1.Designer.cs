namespace Muhasebe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSatis = new System.Windows.Forms.TabPage();
            this.btSat = new System.Windows.Forms.Button();
            this.labelToplamFiyat = new System.Windows.Forms.Label();
            this.btSatisKaydet = new System.Windows.Forms.Button();
            this.btSatisSil = new System.Windows.Forms.Button();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbSatisFiyat = new System.Windows.Forms.TextBox();
            this.btSatisEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSatisAdet = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvSatis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSirket = new System.Windows.Forms.Label();
            this.tbSatis = new System.Windows.Forms.TextBox();
            this.tabGider = new System.Windows.Forms.TabPage();
            this.btGiderKaydet = new System.Windows.Forms.Button();
            this.btGiderSil = new System.Windows.Forms.Button();
            this.lvGider = new System.Windows.Forms.ListView();
            this.chGiderTür = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGiderMiktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGiderFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chToplamMasraf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btGiderEkle = new System.Windows.Forms.Button();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudGiderMiktar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGiderDiger = new System.Windows.Forms.TextBox();
            this.labelDiger = new System.Windows.Forms.Label();
            this.labelGiderTip = new System.Windows.Forms.Label();
            this.cbGider = new System.Windows.Forms.ComboBox();
            this.tabHesap = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabDb = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btKaydet = new System.Windows.Forms.Button();
            this.btDbSil = new System.Windows.Forms.Button();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btUrunEkle = new System.Windows.Forms.Button();
            this.lvDb = new System.Windows.Forms.ListView();
            this.chUrunKodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlabelIsım = new System.Windows.Forms.ToolStripStatusLabel();
            this.btCariEkle = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabSatis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatisAdet)).BeginInit();
            this.tabGider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiderMiktar)).BeginInit();
            this.tabHesap.SuspendLayout();
            this.tabDb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSatis);
            this.tabControl.Controls.Add(this.tabGider);
            this.tabControl.Controls.Add(this.tabHesap);
            this.tabControl.Controls.Add(this.tabDb);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(473, 406);
            this.tabControl.TabIndex = 0;
            // 
            // tabSatis
            // 
            this.tabSatis.Controls.Add(this.btSat);
            this.tabSatis.Controls.Add(this.labelToplamFiyat);
            this.tabSatis.Controls.Add(this.btSatisKaydet);
            this.tabSatis.Controls.Add(this.btSatisSil);
            this.tabSatis.Controls.Add(this.labelFiyat);
            this.tabSatis.Controls.Add(this.comboBox1);
            this.tabSatis.Controls.Add(this.tbSatisFiyat);
            this.tabSatis.Controls.Add(this.btSatisEkle);
            this.tabSatis.Controls.Add(this.label7);
            this.tabSatis.Controls.Add(this.nudSatisAdet);
            this.tabSatis.Controls.Add(this.label6);
            this.tabSatis.Controls.Add(this.label3);
            this.tabSatis.Controls.Add(this.lvSatis);
            this.tabSatis.Controls.Add(this.labelSirket);
            this.tabSatis.Controls.Add(this.tbSatis);
            this.tabSatis.Location = new System.Drawing.Point(4, 22);
            this.tabSatis.Name = "tabSatis";
            this.tabSatis.Padding = new System.Windows.Forms.Padding(3);
            this.tabSatis.Size = new System.Drawing.Size(465, 380);
            this.tabSatis.TabIndex = 0;
            this.tabSatis.Text = "Satış";
            this.tabSatis.UseVisualStyleBackColor = true;
            // 
            // btSat
            // 
            this.btSat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSat.Location = new System.Drawing.Point(358, 297);
            this.btSat.Name = "btSat";
            this.btSat.Size = new System.Drawing.Size(99, 62);
            this.btSat.TabIndex = 26;
            this.btSat.Text = "Sat";
            this.btSat.UseVisualStyleBackColor = true;
            this.btSat.Click += new System.EventHandler(this.btSat_Click);
            // 
            // labelToplamFiyat
            // 
            this.labelToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToplamFiyat.Location = new System.Drawing.Point(148, 293);
            this.labelToplamFiyat.Name = "labelToplamFiyat";
            this.labelToplamFiyat.Size = new System.Drawing.Size(204, 68);
            this.labelToplamFiyat.TabIndex = 25;
            this.labelToplamFiyat.Text = "278 TL";
            this.labelToplamFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btSatisKaydet
            // 
            this.btSatisKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSatisKaydet.Enabled = false;
            this.btSatisKaydet.Location = new System.Drawing.Point(87, 87);
            this.btSatisKaydet.Name = "btSatisKaydet";
            this.btSatisKaydet.Size = new System.Drawing.Size(75, 23);
            this.btSatisKaydet.TabIndex = 24;
            this.btSatisKaydet.Text = "Kaydet";
            this.btSatisKaydet.UseVisualStyleBackColor = true;
            this.btSatisKaydet.Click += new System.EventHandler(this.btSatisKaydet_Click);
            // 
            // btSatisSil
            // 
            this.btSatisSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSatisSil.Enabled = false;
            this.btSatisSil.Location = new System.Drawing.Point(6, 87);
            this.btSatisSil.Name = "btSatisSil";
            this.btSatisSil.Size = new System.Drawing.Size(75, 23);
            this.btSatisSil.TabIndex = 23;
            this.btSatisSil.Text = "Sil";
            this.btSatisSil.UseVisualStyleBackColor = true;
            this.btSatisSil.Click += new System.EventHandler(this.btSatisSil_Click);
            // 
            // labelFiyat
            // 
            this.labelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiyat.Location = new System.Drawing.Point(249, 86);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(131, 23);
            this.labelFiyat.TabIndex = 22;
            this.labelFiyat.Text = "278 TL";
            this.labelFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TL",
            "USD",
            "EUR"});
            this.comboBox1.Location = new System.Drawing.Point(408, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "TL";
            // 
            // tbSatisFiyat
            // 
            this.tbSatisFiyat.Location = new System.Drawing.Point(333, 59);
            this.tbSatisFiyat.Name = "tbSatisFiyat";
            this.tbSatisFiyat.Size = new System.Drawing.Size(72, 20);
            this.tbSatisFiyat.TabIndex = 20;
            this.tbSatisFiyat.Text = "0";
            this.tbSatisFiyat.TextChanged += new System.EventHandler(this.tbSatisFiyat_TextChanged);
            // 
            // btSatisEkle
            // 
            this.btSatisEkle.Location = new System.Drawing.Point(382, 86);
            this.btSatisEkle.Name = "btSatisEkle";
            this.btSatisEkle.Size = new System.Drawing.Size(75, 23);
            this.btSatisEkle.TabIndex = 19;
            this.btSatisEkle.Text = "EKLE";
            this.btSatisEkle.UseVisualStyleBackColor = true;
            this.btSatisEkle.Click += new System.EventHandler(this.btSatisEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fiyat :";
            // 
            // nudSatisAdet
            // 
            this.nudSatisAdet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudSatisAdet.Location = new System.Drawing.Point(245, 60);
            this.nudSatisAdet.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSatisAdet.Name = "nudSatisAdet";
            this.nudSatisAdet.Size = new System.Drawing.Size(47, 20);
            this.nudSatisAdet.TabIndex = 16;
            this.nudSatisAdet.ValueChanged += new System.EventHandler(this.nudSatisAdet_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ürün :";
            // 
            // lvSatis
            // 
            this.lvSatis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSatis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSatis.FullRowSelect = true;
            this.lvSatis.HideSelection = false;
            this.lvSatis.Location = new System.Drawing.Point(6, 116);
            this.lvSatis.MultiSelect = false;
            this.lvSatis.Name = "lvSatis";
            this.lvSatis.Size = new System.Drawing.Size(451, 175);
            this.lvSatis.TabIndex = 13;
            this.lvSatis.UseCompatibleStateImageBehavior = false;
            this.lvSatis.View = System.Windows.Forms.View.Details;
            this.lvSatis.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSatis_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 3;
            this.columnHeader5.Text = "Adet";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Fiyat";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Maliyet";
            this.columnHeader4.Width = 90;
            // 
            // labelSirket
            // 
            this.labelSirket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSirket.BackColor = System.Drawing.Color.Wheat;
            this.labelSirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSirket.Location = new System.Drawing.Point(0, 3);
            this.labelSirket.Name = "labelSirket";
            this.labelSirket.Size = new System.Drawing.Size(462, 45);
            this.labelSirket.TabIndex = 1;
            this.labelSirket.Text = "Gültekin Plastik";
            this.labelSirket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSirket.UseMnemonic = false;
            // 
            // tbSatis
            // 
            this.tbSatis.AutoCompleteCustomSource.AddRange(new string[] {
            "eldiven",
            "bina",
            "arabalar",
            "çarşıkarşı",
            "ebebebe",
            "atadam"});
            this.tbSatis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSatis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSatis.Location = new System.Drawing.Point(51, 59);
            this.tbSatis.Name = "tbSatis";
            this.tbSatis.Size = new System.Drawing.Size(154, 20);
            this.tbSatis.TabIndex = 0;
            // 
            // tabGider
            // 
            this.tabGider.Controls.Add(this.btGiderKaydet);
            this.tabGider.Controls.Add(this.btGiderSil);
            this.tabGider.Controls.Add(this.lvGider);
            this.tabGider.Controls.Add(this.btGiderEkle);
            this.tabGider.Controls.Add(this.cbCurrency);
            this.tabGider.Controls.Add(this.tbFiyat);
            this.tabGider.Controls.Add(this.label5);
            this.tabGider.Controls.Add(this.nudGiderMiktar);
            this.tabGider.Controls.Add(this.label4);
            this.tabGider.Controls.Add(this.tbGiderDiger);
            this.tabGider.Controls.Add(this.labelDiger);
            this.tabGider.Controls.Add(this.labelGiderTip);
            this.tabGider.Controls.Add(this.cbGider);
            this.tabGider.Location = new System.Drawing.Point(4, 22);
            this.tabGider.Name = "tabGider";
            this.tabGider.Padding = new System.Windows.Forms.Padding(3);
            this.tabGider.Size = new System.Drawing.Size(465, 380);
            this.tabGider.TabIndex = 1;
            this.tabGider.Text = "Giderler";
            this.tabGider.UseVisualStyleBackColor = true;
            // 
            // btGiderKaydet
            // 
            this.btGiderKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btGiderKaydet.Enabled = false;
            this.btGiderKaydet.Location = new System.Drawing.Point(301, 336);
            this.btGiderKaydet.Name = "btGiderKaydet";
            this.btGiderKaydet.Size = new System.Drawing.Size(75, 23);
            this.btGiderKaydet.TabIndex = 14;
            this.btGiderKaydet.Text = "Kaydet";
            this.btGiderKaydet.UseVisualStyleBackColor = true;
            this.btGiderKaydet.Click += new System.EventHandler(this.btGiderKaydet_Click);
            // 
            // btGiderSil
            // 
            this.btGiderSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btGiderSil.Enabled = false;
            this.btGiderSil.Location = new System.Drawing.Point(220, 336);
            this.btGiderSil.Name = "btGiderSil";
            this.btGiderSil.Size = new System.Drawing.Size(75, 23);
            this.btGiderSil.TabIndex = 13;
            this.btGiderSil.Text = "Sil";
            this.btGiderSil.UseVisualStyleBackColor = true;
            this.btGiderSil.Click += new System.EventHandler(this.btGiderSil_Click);
            // 
            // lvGider
            // 
            this.lvGider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGiderTür,
            this.chGiderMiktar,
            this.chGiderFiyat,
            this.chToplamMasraf});
            this.lvGider.FullRowSelect = true;
            this.lvGider.HideSelection = false;
            this.lvGider.Location = new System.Drawing.Point(8, 3);
            this.lvGider.MultiSelect = false;
            this.lvGider.Name = "lvGider";
            this.lvGider.Size = new System.Drawing.Size(451, 272);
            this.lvGider.TabIndex = 12;
            this.lvGider.UseCompatibleStateImageBehavior = false;
            this.lvGider.View = System.Windows.Forms.View.Details;
            this.lvGider.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvGider_ItemSelectionChanged);
            // 
            // chGiderTür
            // 
            this.chGiderTür.Text = "Tür";
            this.chGiderTür.Width = 90;
            // 
            // chGiderMiktar
            // 
            this.chGiderMiktar.Text = "Miktar";
            this.chGiderMiktar.Width = 100;
            // 
            // chGiderFiyat
            // 
            this.chGiderFiyat.Text = "Fiyat";
            // 
            // chToplamMasraf
            // 
            this.chToplamMasraf.Text = "Maliyet";
            this.chToplamMasraf.Width = 90;
            // 
            // btGiderEkle
            // 
            this.btGiderEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btGiderEkle.Location = new System.Drawing.Point(382, 336);
            this.btGiderEkle.Name = "btGiderEkle";
            this.btGiderEkle.Size = new System.Drawing.Size(75, 23);
            this.btGiderEkle.TabIndex = 11;
            this.btGiderEkle.Text = "Ekle";
            this.btGiderEkle.UseVisualStyleBackColor = true;
            this.btGiderEkle.Click += new System.EventHandler(this.btGiderEkle_Click);
            // 
            // cbCurrency
            // 
            this.cbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Items.AddRange(new object[] {
            "TL",
            "USD",
            "EUR"});
            this.cbCurrency.Location = new System.Drawing.Point(405, 281);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(49, 21);
            this.cbCurrency.TabIndex = 10;
            this.cbCurrency.Text = "TL";
            // 
            // tbFiyat
            // 
            this.tbFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFiyat.Location = new System.Drawing.Point(272, 281);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(127, 20);
            this.tbFiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat    :";
            // 
            // nudGiderMiktar
            // 
            this.nudGiderMiktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudGiderMiktar.Location = new System.Drawing.Point(272, 308);
            this.nudGiderMiktar.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudGiderMiktar.Name = "nudGiderMiktar";
            this.nudGiderMiktar.Size = new System.Drawing.Size(38, 20);
            this.nudGiderMiktar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Miktar  :";
            // 
            // tbGiderDiger
            // 
            this.tbGiderDiger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbGiderDiger.Location = new System.Drawing.Point(67, 308);
            this.tbGiderDiger.Name = "tbGiderDiger";
            this.tbGiderDiger.Size = new System.Drawing.Size(149, 20);
            this.tbGiderDiger.TabIndex = 4;
            // 
            // labelDiger
            // 
            this.labelDiger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDiger.AutoSize = true;
            this.labelDiger.Location = new System.Drawing.Point(5, 311);
            this.labelDiger.Name = "labelDiger";
            this.labelDiger.Size = new System.Drawing.Size(59, 13);
            this.labelDiger.TabIndex = 3;
            this.labelDiger.Text = "Diğer        :";
            // 
            // labelGiderTip
            // 
            this.labelGiderTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGiderTip.AutoSize = true;
            this.labelGiderTip.Location = new System.Drawing.Point(5, 284);
            this.labelGiderTip.Name = "labelGiderTip";
            this.labelGiderTip.Size = new System.Drawing.Size(58, 13);
            this.labelGiderTip.TabIndex = 2;
            this.labelGiderTip.Text = "Gider Tipi :";
            // 
            // cbGider
            // 
            this.cbGider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGider.FormattingEnabled = true;
            this.cbGider.Location = new System.Drawing.Point(67, 281);
            this.cbGider.Name = "cbGider";
            this.cbGider.Size = new System.Drawing.Size(149, 21);
            this.cbGider.TabIndex = 1;
            this.cbGider.SelectedIndexChanged += new System.EventHandler(this.cbGider_SelectedIndexChanged);
            // 
            // tabHesap
            // 
            this.tabHesap.Controls.Add(this.btCariEkle);
            this.tabHesap.Controls.Add(this.listView1);
            this.tabHesap.Location = new System.Drawing.Point(4, 22);
            this.tabHesap.Name = "tabHesap";
            this.tabHesap.Padding = new System.Windows.Forms.Padding(3);
            this.tabHesap.Size = new System.Drawing.Size(465, 380);
            this.tabHesap.TabIndex = 2;
            this.tabHesap.Text = "Hesap";
            this.tabHesap.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chN,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Location = new System.Drawing.Point(3, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(459, 232);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chN
            // 
            this.chN.Text = "Firma adı";
            this.chN.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Faturalar Toplamı";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Yapılan ödemeler";
            this.columnHeader7.Width = 107;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kalan Borç miktarı";
            this.columnHeader8.Width = 111;
            // 
            // tabDb
            // 
            this.tabDb.Controls.Add(this.button1);
            this.tabDb.Controls.Add(this.btKaydet);
            this.tabDb.Controls.Add(this.btDbSil);
            this.tabDb.Controls.Add(this.nudStok);
            this.tabDb.Controls.Add(this.label2);
            this.tabDb.Controls.Add(this.tbUrunAdi);
            this.tabDb.Controls.Add(this.label1);
            this.tabDb.Controls.Add(this.btUrunEkle);
            this.tabDb.Controls.Add(this.lvDb);
            this.tabDb.Location = new System.Drawing.Point(4, 22);
            this.tabDb.Name = "tabDb";
            this.tabDb.Padding = new System.Windows.Forms.Padding(3);
            this.tabDb.Size = new System.Drawing.Size(465, 380);
            this.tabDb.TabIndex = 3;
            this.tabDb.Text = "Veritabanı";
            this.tabDb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btKaydet
            // 
            this.btKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btKaydet.Enabled = false;
            this.btKaydet.Location = new System.Drawing.Point(142, 330);
            this.btKaydet.Name = "btKaydet";
            this.btKaydet.Size = new System.Drawing.Size(75, 23);
            this.btKaydet.TabIndex = 7;
            this.btKaydet.Text = "Kaydet";
            this.btKaydet.UseVisualStyleBackColor = true;
            this.btKaydet.Click += new System.EventHandler(this.btKaydet_Click);
            // 
            // btDbSil
            // 
            this.btDbSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDbSil.Enabled = false;
            this.btDbSil.Location = new System.Drawing.Point(62, 330);
            this.btDbSil.Name = "btDbSil";
            this.btDbSil.Size = new System.Drawing.Size(75, 23);
            this.btDbSil.TabIndex = 6;
            this.btDbSil.Text = "Sil";
            this.btDbSil.UseVisualStyleBackColor = true;
            this.btDbSil.Click += new System.EventHandler(this.btDbSil_Click);
            // 
            // nudStok
            // 
            this.nudStok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudStok.Location = new System.Drawing.Point(83, 304);
            this.nudStok.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(215, 20);
            this.nudStok.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stok miktarı :";
            // 
            // tbUrunAdi
            // 
            this.tbUrunAdi.AcceptsReturn = true;
            this.tbUrunAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbUrunAdi.Location = new System.Drawing.Point(84, 275);
            this.tbUrunAdi.Name = "tbUrunAdi";
            this.tbUrunAdi.Size = new System.Drawing.Size(214, 20);
            this.tbUrunAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı     :";
            // 
            // btUrunEkle
            // 
            this.btUrunEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUrunEkle.Location = new System.Drawing.Point(223, 330);
            this.btUrunEkle.Name = "btUrunEkle";
            this.btUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btUrunEkle.TabIndex = 1;
            this.btUrunEkle.Text = "Ekle";
            this.btUrunEkle.UseVisualStyleBackColor = true;
            this.btUrunEkle.Click += new System.EventHandler(this.btUrunEkle_Click);
            // 
            // lvDb
            // 
            this.lvDb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUrunKodu,
            this.chUrunAdi,
            this.chStok});
            this.lvDb.FullRowSelect = true;
            this.lvDb.Location = new System.Drawing.Point(8, 6);
            this.lvDb.MultiSelect = false;
            this.lvDb.Name = "lvDb";
            this.lvDb.Size = new System.Drawing.Size(451, 263);
            this.lvDb.TabIndex = 0;
            this.lvDb.UseCompatibleStateImageBehavior = false;
            this.lvDb.View = System.Windows.Forms.View.Details;
            this.lvDb.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvDb_ItemSelectionChanged);
            // 
            // chUrunKodu
            // 
            this.chUrunKodu.Text = "Ürün Kodu";
            this.chUrunKodu.Width = 90;
            // 
            // chUrunAdi
            // 
            this.chUrunAdi.Text = "Ürün Adı";
            this.chUrunAdi.Width = 100;
            // 
            // chStok
            // 
            this.chStok.Text = "Stok Miktarı";
            this.chStok.Width = 90;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlabelIsım});
            this.statusStrip.Location = new System.Drawing.Point(0, 384);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(473, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(370, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // stlabelIsım
            // 
            this.stlabelIsım.Name = "stlabelIsım";
            this.stlabelIsım.Size = new System.Drawing.Size(88, 17);
            this.stlabelIsım.Text = "Gültekin Plastik";
            // 
            // btCariEkle
            // 
            this.btCariEkle.Location = new System.Drawing.Point(8, 244);
            this.btCariEkle.Name = "btCariEkle";
            this.btCariEkle.Size = new System.Drawing.Size(79, 23);
            this.btCariEkle.TabIndex = 1;
            this.btCariEkle.Text = "Cari Kart Ekle";
            this.btCariEkle.UseVisualStyleBackColor = true;
            this.btCariEkle.Click += new System.EventHandler(this.btCariEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 406);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ön Muhasebe";
            this.tabControl.ResumeLayout(false);
            this.tabSatis.ResumeLayout(false);
            this.tabSatis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatisAdet)).EndInit();
            this.tabGider.ResumeLayout(false);
            this.tabGider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiderMiktar)).EndInit();
            this.tabHesap.ResumeLayout(false);
            this.tabDb.ResumeLayout(false);
            this.tabDb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSatis;
        private System.Windows.Forms.TabPage tabGider;
        private System.Windows.Forms.TabPage tabHesap;
        private System.Windows.Forms.TabPage tabDb;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btUrunEkle;
        private System.Windows.Forms.ListView lvDb;
        private System.Windows.Forms.Button btDbSil;
        private System.Windows.Forms.ColumnHeader chUrunKodu;
        private System.Windows.Forms.ColumnHeader chUrunAdi;
        private System.Windows.Forms.ColumnHeader chStok;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label labelGiderTip;
        private System.Windows.Forms.ComboBox cbGider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGiderDiger;
        private System.Windows.Forms.Label labelDiger;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudGiderMiktar;
        private System.Windows.Forms.Button btGiderEkle;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.ListView lvGider;
        private System.Windows.Forms.ColumnHeader chGiderTür;
        private System.Windows.Forms.ColumnHeader chGiderMiktar;
        private System.Windows.Forms.ColumnHeader chToplamMasraf;
        private System.Windows.Forms.Button btGiderSil;
        private System.Windows.Forms.Button btKaydet;
        private System.Windows.Forms.Button btGiderKaydet;
        private System.Windows.Forms.ColumnHeader chGiderFiyat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox tbSatis;
        private System.Windows.Forms.Label labelSirket;
        private System.Windows.Forms.ToolStripStatusLabel stlabelIsım;
        private System.Windows.Forms.ListView lvSatis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbSatisFiyat;
        private System.Windows.Forms.Button btSatisEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudSatisAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btSatisKaydet;
        private System.Windows.Forms.Button btSatisSil;
        private System.Windows.Forms.Label labelToplamFiyat;
        private System.Windows.Forms.Button btSat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chN;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btCariEkle;
    }
}

