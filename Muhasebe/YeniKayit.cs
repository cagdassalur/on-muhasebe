using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace Muhasebe
{
    public partial class YeniKayit : Form
    {
        string version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
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
            List<string> st = new List<string>();
            foreach (string gider in tbGider.Text.Split('\n'))
            {
                if (gider != "") st.Add(gider);
            }
            
            Form1.User newUser = new Form1.User(tbUserName.Text, tbFirma.Text, st.ToArray(), tbPass.Text);
            Form1.SaveData savedata = new Form1.SaveData(new List<Form1.Urun>(), new List<Form1.Gider>(), 
                                            new List<Form1.CKart>(),new List<Form1.Satis>(), newUser);

            var json = new JavaScriptSerializer().Serialize(savedata);
            System.IO.File.WriteAllText(dir.FullName + "\\" + tbUserName.Text + ".json", json);

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
