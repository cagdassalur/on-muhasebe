namespace Muhasebe
{
    partial class KartView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KartView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSirket = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvFatura = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsFatura = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsmiFatEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lvOdeme = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOdeme = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.labelToplam = new System.Windows.Forms.Label();
            this.labelEski = new System.Windows.Forms.Label();
            this.labelBorc = new System.Windows.Forms.Label();
            this.labelOdeme = new System.Windows.Forms.Label();
            this.labelCari = new System.Windows.Forms.Label();
            this.cmsFatura.SuspendLayout();
            this.cmsOdeme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faturalar Toplamı    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eski Kalan Bakiye   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam Borç Miktarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yapılan Ödemeler    :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "04.09.2013";
            // 
            // labelSirket
            // 
            this.labelSirket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSirket.BackColor = System.Drawing.Color.Wheat;
            this.labelSirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSirket.Location = new System.Drawing.Point(243, 5);
            this.labelSirket.Name = "labelSirket";
            this.labelSirket.Size = new System.Drawing.Size(428, 124);
            this.labelSirket.TabIndex = 5;
            this.labelSirket.Text = "Eldiven Yayıncılık";
            this.labelSirket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSirket.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cari Hesap Durumu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tarihli";
            // 
            // lvFatura
            // 
            this.lvFatura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.chN,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvFatura.ContextMenuStrip = this.cmsFatura;
            this.lvFatura.FullRowSelect = true;
            this.lvFatura.Location = new System.Drawing.Point(14, 175);
            this.lvFatura.MultiSelect = false;
            this.lvFatura.Name = "lvFatura";
            this.lvFatura.Size = new System.Drawing.Size(319, 318);
            this.lvFatura.TabIndex = 8;
            this.lvFatura.UseCompatibleStateImageBehavior = false;
            this.lvFatura.View = System.Windows.Forms.View.Details;
            this.lvFatura.DoubleClick += new System.EventHandler(this.lvFatura_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 30;
            // 
            // chN
            // 
            this.chN.Text = "Fatura Tarihi";
            this.chN.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fatura No";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "İrsaliye No";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tutar";
            // 
            // cmsFatura
            // 
            this.cmsFatura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsmiFatEkle});
            this.cmsFatura.Name = "cmsFatura";
            this.cmsFatura.Size = new System.Drawing.Size(96, 26);
            // 
            // cmsmiFatEkle
            // 
            this.cmsmiFatEkle.Name = "cmsmiFatEkle";
            this.cmsmiFatEkle.Size = new System.Drawing.Size(95, 22);
            this.cmsmiFatEkle.Text = "Ekle";
            this.cmsmiFatEkle.Click += new System.EventHandler(this.cmsmiFatEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 37);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fatura Girişi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(395, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ödemeler";
            // 
            // lvOdeme
            // 
            this.lvOdeme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvOdeme.ContextMenuStrip = this.cmsOdeme;
            this.lvOdeme.FullRowSelect = true;
            this.lvOdeme.Location = new System.Drawing.Point(342, 175);
            this.lvOdeme.MultiSelect = false;
            this.lvOdeme.Name = "lvOdeme";
            this.lvOdeme.Size = new System.Drawing.Size(319, 318);
            this.lvOdeme.TabIndex = 10;
            this.lvOdeme.UseCompatibleStateImageBehavior = false;
            this.lvOdeme.View = System.Windows.Forms.View.Details;
            this.lvOdeme.DoubleClick += new System.EventHandler(this.lvOdeme_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ödeme Tarihi";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ödeme Şekli";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tutar";
            this.columnHeader5.Width = 70;
            // 
            // cmsOdeme
            // 
            this.cmsOdeme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEkle});
            this.cmsOdeme.Name = "cmsFatura";
            this.cmsOdeme.Size = new System.Drawing.Size(96, 26);
            // 
            // tsmiEkle
            // 
            this.tsmiEkle.Name = "tsmiEkle";
            this.tsmiEkle.Size = new System.Drawing.Size(95, 22);
            this.tsmiEkle.Text = "Ekle";
            this.tsmiEkle.Click += new System.EventHandler(this.tsmiEkle_Click);
            // 
            // labelToplam
            // 
            this.labelToplam.AutoSize = true;
            this.labelToplam.Location = new System.Drawing.Point(112, 9);
            this.labelToplam.Name = "labelToplam";
            this.labelToplam.Size = new System.Drawing.Size(37, 13);
            this.labelToplam.TabIndex = 14;
            this.labelToplam.Text = "00000";
            // 
            // labelEski
            // 
            this.labelEski.AutoSize = true;
            this.labelEski.Location = new System.Drawing.Point(113, 26);
            this.labelEski.Name = "labelEski";
            this.labelEski.Size = new System.Drawing.Size(37, 13);
            this.labelEski.TabIndex = 15;
            this.labelEski.Text = "00000";
            // 
            // labelBorc
            // 
            this.labelBorc.AutoSize = true;
            this.labelBorc.Location = new System.Drawing.Point(113, 44);
            this.labelBorc.Name = "labelBorc";
            this.labelBorc.Size = new System.Drawing.Size(37, 13);
            this.labelBorc.TabIndex = 16;
            this.labelBorc.Text = "00000";
            // 
            // labelOdeme
            // 
            this.labelOdeme.AutoSize = true;
            this.labelOdeme.Location = new System.Drawing.Point(113, 61);
            this.labelOdeme.Name = "labelOdeme";
            this.labelOdeme.Size = new System.Drawing.Size(37, 13);
            this.labelOdeme.TabIndex = 17;
            this.labelOdeme.Text = "00000";
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Location = new System.Drawing.Point(112, 94);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(37, 13);
            this.labelCari.TabIndex = 18;
            this.labelCari.Text = "00000";
            // 
            // KartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 505);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.labelOdeme);
            this.Controls.Add(this.labelBorc);
            this.Controls.Add(this.labelEski);
            this.Controls.Add(this.labelToplam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvOdeme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvFatura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelSirket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KartView";
            this.Text = "Cari Kart";
            this.cmsFatura.ResumeLayout(false);
            this.cmsOdeme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSirket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvFatura;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader chN;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvOdeme;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip cmsFatura;
        private System.Windows.Forms.ToolStripMenuItem cmsmiFatEkle;
        private System.Windows.Forms.ContextMenuStrip cmsOdeme;
        private System.Windows.Forms.ToolStripMenuItem tsmiEkle;
        private System.Windows.Forms.Label labelToplam;
        private System.Windows.Forms.Label labelEski;
        private System.Windows.Forms.Label labelBorc;
        private System.Windows.Forms.Label labelOdeme;
        private System.Windows.Forms.Label labelCari;
    }
}