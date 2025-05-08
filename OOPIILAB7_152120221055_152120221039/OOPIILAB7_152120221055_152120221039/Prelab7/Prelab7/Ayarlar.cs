using System;
using System.Linq;
using System.Windows.Forms;

namespace Prelab7
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            // Seçenekleri ekle
            cmbSure.Items.AddRange(new string[] { "30", "45", "60" });
            cmbZorluk.Items.AddRange(new string[] { "Kolay", "Orta", "Zor" });
            cmbResimTema.Items.AddRange(new string[] { "Adam As", "Çöp Adam As", "Balon Patlat" });

            // Varsayılan seçimleri ancak eğer gerçekten listede varsa yap
            string sureStr = GameSettings.Sure.ToString();
            if (cmbSure.Items.Contains(sureStr))
                cmbSure.SelectedItem = sureStr;
            else
                cmbSure.SelectedIndex = 0;

            if (cmbZorluk.Items.Contains(GameSettings.Zorluk))
                cmbZorluk.SelectedItem = GameSettings.Zorluk;
            else
                cmbZorluk.SelectedIndex = 0;

            if (cmbResimTema.Items.Contains(GameSettings.ResimTema))
                cmbResimTema.SelectedItem = GameSettings.ResimTema;
            else
                cmbResimTema.SelectedIndex = 0;
        }

        private void btnAyarKaydet_Click(object sender, EventArgs e)
        {
            // Süreyi güvenli şekilde parse et
            if (!int.TryParse(cmbSure.Text, out int sureVal))
            {
                MessageBox.Show("Lütfen geçerli bir süre seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GameSettings.Sure = sureVal;

            // Zorluk ve tema doğrudan Text üzerinden alınıyor
            GameSettings.Zorluk = cmbZorluk.Text;
            GameSettings.ResimTema = cmbResimTema.Text;

            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}