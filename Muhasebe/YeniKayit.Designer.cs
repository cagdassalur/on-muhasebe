namespace Muhasebe
{
    partial class YeniKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirma = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbSifre = new System.Windows.Forms.CheckBox();
            this.tbGider = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btKaydet = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Adı      :";
            // 
            // tbFirma
            // 
            this.tbFirma.Location = new System.Drawing.Point(88, 6);
            this.tbFirma.Name = "tbFirma";
            this.tbFirma.Size = new System.Drawing.Size(203, 20);
            this.tbFirma.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(88, 42);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(137, 20);
            this.tbUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(88, 68);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(137, 20);
            this.tbPass.TabIndex = 5;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre             :";
            // 
            // chbSifre
            // 
            this.chbSifre.AutoSize = true;
            this.chbSifre.Location = new System.Drawing.Point(88, 94);
            this.chbSifre.Name = "chbSifre";
            this.chbSifre.Size = new System.Drawing.Size(88, 17);
            this.chbSifre.TabIndex = 6;
            this.chbSifre.Text = "Şifreyi Göster";
            this.chbSifre.UseVisualStyleBackColor = true;
            this.chbSifre.CheckedChanged += new System.EventHandler(this.chbSifre_CheckedChanged);
            // 
            // tbGider
            // 
            this.tbGider.Location = new System.Drawing.Point(91, 136);
            this.tbGider.Multiline = true;
            this.tbGider.Name = "tbGider";
            this.tbGider.Size = new System.Drawing.Size(203, 170);
            this.tbGider.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gider Tipleri  :";
            // 
            // btKaydet
            // 
            this.btKaydet.Location = new System.Drawing.Point(216, 314);
            this.btKaydet.Name = "btKaydet";
            this.btKaydet.Size = new System.Drawing.Size(75, 23);
            this.btKaydet.TabIndex = 9;
            this.btKaydet.Text = "Kaydet";
            this.btKaydet.UseVisualStyleBackColor = true;
            this.btKaydet.Click += new System.EventHandler(this.btKaydet_Click);
            // 
            // btSil
            // 
            this.btSil.Location = new System.Drawing.Point(135, 314);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(75, 23);
            this.btSil.TabIndex = 10;
            this.btSil.Text = "İptal";
            this.btSil.UseVisualStyleBackColor = true;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // YeniKayit
            // 
            this.AcceptButton = this.btKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 349);
            this.Controls.Add(this.btSil);
            this.Controls.Add(this.btKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGider);
            this.Controls.Add(this.chbSifre);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirma);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YeniKayit";
            this.Text = "Yeni Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirma;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbSifre;
        private System.Windows.Forms.TextBox tbGider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btKaydet;
        private System.Windows.Forms.Button btSil;
    }
}