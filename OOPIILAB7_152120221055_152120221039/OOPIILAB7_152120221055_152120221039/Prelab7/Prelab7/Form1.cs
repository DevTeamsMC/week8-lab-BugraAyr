using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prelab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.AddRange(new string[]
            {
                "Tarih",
                "Coğrafya",
                "Matematik",
                "Genel Kültür",
                "Karma",
                "Bilgisayar Kavramları"
            });
            cmbKategori.SelectedIndex = 0;
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            using (var ayarForm = new Ayarlar())
                ayarForm.ShowDialog();

            lblSecilenAyarlar.Text =
                $"Süre: {GameSettings.Sure} sn - " +
                $"Zorluk: {GameSettings.Zorluk} - " +
                $"Tema: {GameSettings.ResimTema}";
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            // 1) Kategori ve tema ayarlarını al
            string secilenKategori = cmbKategori.SelectedItem.ToString();
            GameSettings.Kategori = secilenKategori;
            string tema = GameSettings.ResimTema;

            // 2) Doğru sözlüğü seç
            Dictionary<string, (string Ipucu, string Zorluk)> sozluk;
            switch (secilenKategori)
            {
                case "Tarih":
                    sozluk = OyunForm.Tarih; break;
                case "Coğrafya":
                    sozluk = OyunForm.Cografya; break;
                case "Matematik":
                    sozluk = OyunForm.Matematik; break;
                case "Genel Kültür":
                    sozluk = OyunForm.GenelKultur; break;
                case "Karma":
                    sozluk = OyunForm.Karma; break;
                case "Bilgisayar Kavramları":
                    sozluk = OyunForm.BilgisayarKavramlari; break;
                default:
                    sozluk = OyunForm.Tarih; break;
            }

            

            // 4) OyunForm'u başlatırken sözlük ve tema klasörünü geç
            var oyun = new OyunForm(sozluk, tema);
            oyun.Show();
            this.Hide();
        }
    }
}