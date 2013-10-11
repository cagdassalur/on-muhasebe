namespace Muhasebe
{
    partial class FaturaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIrNo = new System.Windows.Forms.TextBox();
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
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(85, 40);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(187, 20);
            this.tbNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fatura No      :";
            // 
            // tbIrNo
            // 
            this.tbIrNo.Location = new System.Drawing.Point(85, 68);
            this.tbIrNo.Name = "tbIrNo";
            this.tbIrNo.Size = new System.Drawing.Size(187, 20);
            this.tbIrNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İrsaliye No     :";
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(85, 96);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(187, 20);
            this.tbTutar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fatura Tutarı  :";
            // 
            // btEkle
            // 
            this.btEkle.Location = new System.Drawing.Point(206, 145);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(75, 23);
            this.btEkle.TabIndex = 8;
            this.btEkle.Text = "Kaydet";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // btIptal
            // 
            this.btIptal.Location = new System.Drawing.Point(54, 145);
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
            this.btSil.Location = new System.Drawing.Point(130, 145);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(75, 23);
            this.btSil.TabIndex = 11;
            this.btSil.Text = "Sil";
            this.btSil.UseVisualStyleBackColor = true;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(85, 15);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(187, 20);
            this.dtpTarih.TabIndex = 12;
            // 
            // FaturaGiris
            // 
            this.AcceptButton = this.btEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btSil);
            this.Controls.Add(this.btIptal);
            this.Controls.Add(this.btEkle);
            this.Controls.Add(this.tbTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIrNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaturaGiris";
            this.Text = "Fatura Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIrNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Button btIptal;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.DateTimePicker dtpTarih;
    }
}