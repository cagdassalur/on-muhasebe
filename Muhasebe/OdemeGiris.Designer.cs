namespace Muhasebe
{
    partial class OdemeGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSekil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btEkle = new System.Windows.Forms.Button();
            this.btIptal = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura Tarihi  :";
            // 
            // tbSekil
            // 
            this.tbSekil.Location = new System.Drawing.Point(85, 40);
            this.tbSekil.Name = "tbSekil";
            this.tbSekil.Size = new System.Drawing.Size(221, 20);
            this.tbSekil.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ödeme Şekli  :";
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(85, 92);
            this.tbAciklama.Multiline = true;
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(221, 141);
            this.tbAciklama.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama       :";
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(85, 66);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(221, 20);
            this.tbTutar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ödeme Tutarı :";
            // 
            // btEkle
            // 
            this.btEkle.Location = new System.Drawing.Point(231, 264);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(75, 23);
            this.btEkle.TabIndex = 8;
            this.btEkle.Text = "Kaydet";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // btIptal
            // 
            this.btIptal.Location = new System.Drawing.Point(79, 264);
            this.btIptal.Name = "btIptal";
            this.btIptal.Size = new System.Drawing.Size(75, 23);
            this.btIptal.TabIndex = 10;
            this.btIptal.Text = "İptal";
            this.btIptal.UseVisualStyleBackColor = true;
            this.btIptal.Click += new System.EventHandler(this.btIptal_Click);
            // 
            // btSil
            // 
            this.btSil.Enabled = false;
            this.btSil.Location = new System.Drawing.Point(155, 264);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(75, 23);
            this.btSil.TabIndex = 11;
            this.btSil.Text = "Sil";
            this.btSil.UseVisualStyleBackColor = true;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(85, 14);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(221, 20);
            this.dtpTarih.TabIndex = 13;
            // 
            // OdemeGiris
            // 
            this.AcceptButton = this.btEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 291);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btSil);
            this.Controls.Add(this.btIptal);
            this.Controls.Add(this.btEkle);
            this.Controls.Add(this.tbTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSekil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdemeGiris";
            this.Text = "Ödeme Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSekil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Button btIptal;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.DateTimePicker dtpTarih;
    }
}