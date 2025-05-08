using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Prelab7
{
    public partial class OyunForm : Form
    {
        // 1) Tarih
        public static Dictionary<string, (string Ipucu, string Zorluk)> Tarih = new Dictionary<string, (string, string)>
        {
            { "Cumhuriyet",        ("Türkiye'de ilan edildiği yıl 1923",                       "Kolay") },
            { "Osmanlı",           ("1299-1922 yılları arasında hüküm süren imparatorluk",     "Kolay") },
            { "Meşrutiyet",        ("1908'de II. Meşrutiyet ilan edildi",                     "Orta") },
            { "Fatih Sultan Mehmet",("İstanbul'u 1453'te fetheden padişah",                   "Kolay") },
            { "Versailles",        ("I. Dünya Savaşı'nı sona erdiren antlaşma",                "Orta") },
            { "Endüstri Devrimi",  ("18. yüzyılda başlayan sanayi dönüşümü",                   "Orta") },
            { "Magna Carta",       ("1215'te İngiltere'de kralın yetkilerini sınırlayan belge","Zor") },
            { "Rönesans",          ("14.-17. yüzyılda İtalya'da sanatsal canlanma",            "Orta") },
            { "Çivi Yazısı",       ("Mezopotamya'da kullanılan en eski yazı sistemi",          "Zor") },
            { "Waterloo",          ("Napolyon'un 1815'te son yenilgiyi tattığı savaş",         "Orta") },
            { "Selçuklu",          ("11. yüzyılda Anadolu'da egemenlik kuran Türk devleti",     "Orta") },
            { "Kubilay Han",       ("Moğol imparatorluğunu yöneten Cengiz Han'ın torunu",       "Zor") },
            { "Sykes-Picot",       ("Orta Doğu sınırlarını belirleyen 1916 anlaşması",         "Zor") },
            { "Berlin Duvarı",     ("1961'de inşa edilen ve 1989'da yıkılan yapı",             "Orta") },
            { "Manastır",          ("I. Balkan Savaşı'nın başladığı Osmanlı şehri",            "Zor") },
            { "Tanzimat",          ("1839'da Osmanlı'da reformların başladığı dönem",          "Orta") },
            { "I. Dünya Savaşı",   ("28 Temmuz 1914'te başlayan küresel çatışma",              "Kolay") },
            { "Köle Ticareti",     ("16.-19. yüzyılda Atlantik boyunca yapılan insan ticareti","Zor") },
            { "Truva",             ("Homeros destanlarında adı geçen antik kent",               "Orta") },
            { "Bizans",            ("330-1453 yılları arasında ayakta kalan imparatorluk",      "Orta") }
        };

        // 2) Coğrafya
        public static Dictionary<string, (string Ipucu, string Zorluk)> Cografya = new Dictionary<string, (string, string)>
        {
            { "Himalaya",         ("Dünyanın en yüksek dağ silsilesi",                      "Kolay") },
            { "Amazon",           ("Dünyanın en büyük yağmur ormanı",                       "Kolay") },
            { "Sahara",           ("Dünyanın en büyük sıcak çölü",                         "Kolay") },
            { "Ekvator",          ("Yeryüzünü iki eşit parçaya bölen çizgi",                "Kolay") },
            { "Gobi",             ("Asya kıtasındaki geniş çöl bölgesi",                    "Orta") },
            { "Mississippi",      ("ABD'deki en uzun nehirlerden biri",                     "Orta") },
            { "Atlas Okyanusu",   ("Avrupa ile Amerika kıtalarını ayıran deniz",            "Kolay") },
            { "Kordiller",        ("Kuzey Amerika'daki dağ sıraları",                       "Orta") },
            { "Tuna",             ("Avrupa'da 10 ülke sınırından geçen nehir",              "Orta") },
            { "Kilimanjaro",      ("Afrika'nın en yüksek dağı",                             "Orta") },
            { "And Dağları",      ("Güney Amerika kıyısında uzanan dağ sıraları",           "Orta") },
            { "Mariana Çukuru",   ("Dünyanın en derin okyanus noktası",                     "Zor") },
            { "Büyük Set Resifi", ("Avustralya açıklarında büyük mercan kayalığı",          "Zor") },
            { "Yukon",            ("Kanada ve Alaska'da akan önemli nehir",                 "Zor") },
            { "Arktik",           ("Kuzey Kutbu çevresindeki kutup bölgesi",                 "Orta") },
            { "Antarktika",       ("Güney Kutbu'ndaki buz örtüsüyle kaplı kıta",            "Orta") },
            { "Nil",              ("Dünyanın en uzun nehirlerinden biri",                   "Kolay") },
            { "Ural Dağları",     ("Avrupa ile Asya'yı ayıran dağ sistemi",                 "Orta") },
            { "Karadeniz",        ("Türkiye'nin kuzeyinde yer alan iç deniz",               "Kolay") },
            { "Hürmüz Boğazı",    ("Umman Körfezi ile Basra Körfezi'ni bağlayan su yolu",   "Zor") }
        };

        // 3) Matematik
        public static Dictionary<string, (string Ipucu, string Zorluk)> Matematik = new Dictionary<string, (string, string)>
        {
            { "İntegral",               ("Fonksiyon altında kalan alanın hesaplanması",               "Kolay") },
            { "Türev",                  ("Fonksiyonun anlık değişim oranı",                           "Kolay") },
            { "Matris",                 ("Sayılardan oluşan iki boyutlu tablo",                      "Kolay") },
            { "Vektör",                 ("Yön ve büyüklüğü olan matematiksel kavram",               "Kolay") },
            { "Kombinasyon",            ("Sırasız seçme işlemidir",                                  "Orta") },
            { "Permütasyon",            ("Sıralı düzenlemelerin sayısı",                             "Orta") },
            { "Logaritma",              ("Üstel işlemin tersidir",                                   "Orta") },
            { "Fourier Dönüşümü",       ("Sinyalleri frekans bileşenlerine ayırır",                  "Zor") },
            { "Pythagoras Teoremi",     ("Dik üçgende kareler toplamı ilişkisi",                     "Kolay") },
            { "Euler Sayısı",           ("Doğal logaritmanın tabanı yaklaşık 2.718",                  "Orta") },
            { "Asal Sayı",              ("Kendisi ve 1 dışında böleni olmayan sayı",                  "Kolay") },
            { "Limit",                  ("Bir değere yaklaşma süreci",                               "Orta") },
            { "Determinant",            ("Kare matrislere özel skaler değer",                        "Orta") },
            { "Karmaşık Sayı",          ("Gerçek olmayan birimi i olan sayı",                        "Zor") },
            { "Polinom",                ("Değişkenlerin toplamı ve katsayılarla ifade edilen ifade", "Orta") },
            { "Diferansiyel Denklemler",("Türev içeren eşitlikler",                                   "Zor") },
            { "Konik",                  ("Elips, hiperbol ve parabol gibi eğriler",                 "Orta") },
            { "Gauss Eliminasyonu",     ("Matrisleri satır işlemleriyle çözme yöntemi",              "Zor") },
            { "Bayes Teoremi",          ("Koşullu olasılıkları hesaplar",                            "Zor") },
            { "Fibonacci Dizisi",       ("Önceki iki sayının toplamı şeklindeki dizi",                "Orta") }
        };

        // 4) Genel Kültür
        public static Dictionary<string, (string Ipucu, string Zorluk)> GenelKultur = new Dictionary<string, (string, string)>
        {
            { "Nobel Ödülü",         ("Fizik, kimya, barış gibi alanlarda verilen prestijli ödül", "Kolay") },
            { "Oscar",               ("Sinema filmlerine verilen ödül",                              "Kolay") },
            { "Eurovision",          ("Avrupa şarkı yarışması",                                      "Orta") },
            { "UNESCO",              ("Eğitim, bilim ve kültür örgütü",                              "Orta") },
            { "Mona Lisa",           ("Leonardo da Vinci'nin ünlü tablosu",                        "Kolay") },
            { "Shakespeare",         ("İngiliz edebiyatının ünlü oyun yazarı",                     "Orta") },
            { "Beatles",             ("1960'larda etkili olan İngiliz müzik grubu",                "Kolay") },
            { "Olimpiyat",           ("Dört yılda bir düzenlenen uluslararası spor etkinliği",      "Kolay") },
            { "Van Gogh",            ("Yıldızlı Gece tablosuyla tanınan ressam",                   "Orta") },
            { "Picasso",             ("Kübizm akımının öncülerinden biri",                         "Orta") },
            { "Dalai Lama",          ("Tibet Budizmi'nin ruhani lideri",                           "Orta") },
            { "Neşet Ertaş",         ("Türk halk müziğinin usta sanatçısı",                        "Kolay") },
            { "Michelin Yıldızı",    ("Restoran kalitesini belirten ödül",                         "Zor") },
            { "Göbeklitepe",         ("Dünyanın bilinen en eski tapınağı",                         "Zor") },
            { "Kaaba",               ("Müslümanların kıblesi",                                     "Orta") },
            { "Çanakkale Şehitleri", ("1915'teki savaşta yaşamını yitiren askerler",               "Orta") },
            { "Anıtkabir",           ("Atatürk'ün anıt mezarı",                                    "Kolay") },
            { "Çernobil",            ("1986'da nükleer kazanın meydana geldiği yer",                "Orta") },
            { "Barış Manço",         ("Türk rock müziğinin öncü isimlerinden",                      "Kolay") },
            { "Chopin",              ("Romantik dönemin ünlü piyanisti ve bestecisi",              "Orta") }
        };

        // 5) Karma
        public static Dictionary<string, (string Ipucu, string Zorluk)> Karma = new Dictionary<string, (string, string)>
        {
            { "Machu Picchu",            ("Peru'da İnka antik kenti",                                  "Orta") },
            { "Schrödinger'in Kedisi",   ("Kuantum süperpozisyon örneği",                              "Zor") },
            { "Sudoku",                  ("Sayı yerleştirme mantık oyunu",                             "Kolay") },
            { "Gutenberg",               ("Matbaanın mucidi",                                          "Orta") },
            { "Maya Takvimi",            ("Antik Maya uygarlığının takvim sistemi",                   "Zor") },
            { "Atatürk",                 ("Türkiye Cumhuriyeti'nin kurucusu",                         "Kolay") },
            { "Euler Sayısı",            ("Matematiksel sabit e",                                      "Orta") },
            { "Amazon Nehri",            ("Güney Amerika'nın en büyük nehri",                         "Kolay") },
            { "Mona Lisa",               ("Louvre Müzesi'nde sergilenen tablo",                       "Kolay") },
            { "Fibonacci Dizisi",        ("Her sayı önceki iki sayının toplamı",                      "Orta") },
            { "Bering Boğazı",           ("Asya ile Amerika'yı ayıran su geçidi",                     "Zor") },
            { "Nobel Ödülü",             ("Bilim ve barışta verilen prestijli ödül",                  "Kolay") },
            { "Fourier Dönüşümü",        ("Fonksiyonları frekans bileşenlerine ayıran yöntem",        "Zor") },
            { "Kilimanjaro",             ("Afrika'nın en yüksek dağı konumunda",                      "Orta") },
            { "Pythagoras Teoremi",      ("Dik üçgende kenarlar arasındaki ilişki",                   "Kolay") },
            { "Versailles Antlaşması",   ("1919'da I. Dünya Savaşı'nı sonlandıran antlaşma",          "Orta") },
            { "Bitcoin",                 ("Merkezi olmayan dijital para birimi",                       "Zor") },
            { "Tesla Bobini",            ("Yüksek voltaj üreten elektriksel devre",                    "Zor") },
            { "Kuantum Dolanıklık",      ("İki parçacığın durumlarının bağlılığı",                     "Zor") },
            { "Çernobil",                ("1986 nükleer kazası ile bilinen şehir",                     "Orta") }
        };

        // 6) Bilgisayar Kavramları
        public static Dictionary<string, (string Ipucu, string Zorluk)> BilgisayarKavramlari = new Dictionary<string, (string, string)>
        {
            { "Algoritma",         ("Bir sorunu çözme adımları bütünüdür",                   "Kolay") },
            { "Veri Yapısı",       ("Verilerin organize edilme şekli",                      "Kolay") },
            { "İşletim Sistemi",   ("Bilgisayar kaynaklarını yöneten yazılım",              "Orta") },
            { "Derleyici",         ("Kaynak kodu makine koduna çeviren program",            "Orta") },
            { "Yığın (Stack)",     ("LIFO önceliğine sahip veri yapısı",                    "Orta") },
            { "Kuyruk (Queue)",    ("FIFO mantığıyla işleyen yapı",                         "Orta") },
            { "Ağaç (Tree)",       ("Dallanarak hiyerarşi oluşturan yapılar",                "Orta") },
            { "Hash Fonksiyonu",   ("Verileri sabit boyutlu anahtara dönüştürür",           "Zor") },
            { "Yapay Zeka",        ("Makinelerin insan benzeri zeka sergilemesi",           "Zor") },
            { "Makine Öğrenmesi",  ("Veriden öğrenme yöntemleri",                           "Zor") },
            { "Büyük Veri",        ("Çok büyük ve karmaşık veri setleri",                   "Zor") },
            { "Bulut Bilişim",     ("İnternet üzerinden hizmet sunumu",                     "Orta") },
            { "Sanal Makine",      ("Donanımdan bağımsız çalışan sistem",                   "Orta") },
            { "İş Parçacığı",      ("Paralel yürütme birimi",                               "Orta") },
            { "İstemci-Sunucu",    ("İki taraflı iletişim mimarisi",                        "Orta") },
            { "TCP/IP",            ("İnternet iletişim protokolü paketi",                   "Zor") },
            { "API",               ("Uygulama programlama arayüzü",                         "Kolay") },
            { "MVC",               ("Model-View-Controller tasarım deseni",                 "Orta") },
            { "Veri Tabanı",       ("Verilerin depolandığı sistem",                         "Kolay") },
            { "Kriptografi",       ("Veri gizliliğini sağlayan teknik",                     "Zor") }
        };

        private readonly Dictionary<string, (string Ipucu, string Zorluk)> kelimeler;
        private readonly string temaKlasor;

        private string secilenKelimeOrjinal;
        private string secilenKelimeNormalized;
        private int puan;
        private int hataliSayac;
        private readonly List<char> dogruHarfler = new List<char>();
        private readonly List<char> yanlisHarfler = new List<char>();
        private int timeLeft;

        // Parametresiz ctor artık kullanılmıyor, ama isterseniz default tema da verebilirsiniz
        public OyunForm() : this(Tarih, "VarsayilanTema") { }

        // Yeni ctor: hem sözlüğü hem de tema klasör adını alır
        public OyunForm(
            Dictionary<string, (string Ipucu, string Zorluk)> liste,
            string temaKlasor)
        {
            InitializeComponent();
            this.kelimeler = liste;
            this.temaKlasor = temaKlasor;
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            dogruHarfler.Clear();
            yanlisHarfler.Clear();
            hataliSayac = 0;
            puan = 100;
            timeLeft = GameSettings.Sure;
            timer1.Interval = 1000;

            var rnd = new Random();
            var entry = kelimeler.ElementAt(rnd.Next(kelimeler.Count));
            secilenKelimeOrjinal = entry.Key;
            secilenKelimeNormalized = entry.Key.ToLowerInvariant();

            // Ekranı ayarla
            lblKelime.Text = string.Join(" ",
                secilenKelimeOrjinal.Select(c =>
                    char.IsWhiteSpace(c) ? ' ' : '_'));
            lblKelimeUzunlugu.Text = $"Uzunluk: {secilenKelimeOrjinal.Length}";
            lblPuan.Text = $"Puan: {puan}";
            lblYanlislar.Text = "Yanlışlar: ";
            lblZorluk.Text = $"Zorluk: {entry.Value.Zorluk}";
            lblSure.Text = $"Kalan Süre: {timeLeft}";

            // İlk resmi yükle
            LoadHangmanImage(1);

            timer1.Start();
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHarf.Text)) return;
            char tahmin = char.ToLower(txtHarf.Text[0]);
            txtHarf.Clear();

            if (secilenKelimeNormalized.Contains(tahmin))
            {
                if (!dogruHarfler.Contains(tahmin))
                    dogruHarfler.Add(tahmin);
            }
            else
            {
                if (!yanlisHarfler.Contains(tahmin))
                {
                    yanlisHarfler.Add(tahmin);
                    hataliSayac++;
                    puan = Math.Max(0, puan - 10);
                    lblPuan.Text = $"Puan: {puan}";
                    lblYanlislar.Text = "Yanlışlar: " + string.Join(", ", yanlisHarfler);
                    LoadHangmanImage(hataliSayac + 1);
                }
            }

            // Ekranı güncelle (_ ve boşluk)
            lblKelime.Text = string.Join(" ",
                secilenKelimeOrjinal.Select(c =>
                    char.IsWhiteSpace(c)
                        ? ' '
                        : dogruHarfler.Contains(char.ToLower(c)) ? c : '_'));

            // Kazanma / kaybetme
            bool kazandi = secilenKelimeOrjinal
                .Where(c => !char.IsWhiteSpace(c))
                .All(c => dogruHarfler.Contains(char.ToLower(c)));

            if (kazandi || hataliSayac >= 9)
            {
                timer1.Stop();
                BackColor = kazandi ? Color.LightGreen : Color.Red;
                MessageBox.Show(
                    kazandi ? "Tebrikler! Kazandınız." :
                              $"Kaybettiniz! Doğru kelime: {secilenKelimeOrjinal}",
                    "Oyun Bitti");
                Close();
                return;
            }

            // Süreyi sıfırla
            timeLeft = GameSettings.Sure;
            lblSure.Text = $"Kalan Süre: {timeLeft}";
        }

        private void btnIpucu_Click(object sender, EventArgs e)
            => MessageBox.Show(
                kelimeler[secilenKelimeOrjinal].Ipucu,
                "İpucu");

        private void btnOyunuBitir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Oyunu bitirmek istiyor musunuz?",
                    "Çıkış",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblSure.Text = $"Kalan Süre: {timeLeft}";
            if (timeLeft <= 0)
            {
                timer1.Stop();
                BackColor = Color.Red;
                MessageBox.Show("Süre doldu!", "Oyun Bitti");
                Close();
            }
        }

        /// <summary>
        /// Tema klasöründeki man-XX.jpg dosyasını yükler.
        /// </summary>
        private void LoadHangmanImage(int adim)
        {
            // Örneğin: temaKlasor = "AdamAs"
            string baseDir = Application.StartupPath;
            string imgPath = Path.Combine(
                baseDir,
                "Images",
                temaKlasor,
                $"man-{adim:00}.jpg");

            if (File.Exists(imgPath))
                picAdam.Image = Image.FromFile(imgPath);
            else
                picAdam.Image = null; // Veya bir default resim
        }
    }
}
