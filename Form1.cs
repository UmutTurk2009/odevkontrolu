using System.ComponentModel;
using System.Text.Json;
using System.Windows.Forms;

namespace odevkontrolu
{
    public partial class Form1 : Form //umuttur
    {
        BindingList<Ogr> liste = new();
        Ogr gosterilenOgr;
        object[] sınıflar = new object[] { "10-A", "10-C", "10-F", "10-H", "10-G" };

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("bilgiler.txt"))
            {
                string metin = File.ReadAllText("bilgiler.txt");
                var okunanListe = JsonSerializer.Deserialize<List<Ogr>>(metin);
                liste = new(okunanListe);
            }
            Ogrenciler.DataSource = liste;
            Ogrenciler.DisplayMember = "FullName";
            cbSınıf.Items.AddRange(sınıflar);
        }
        void YeniEkle()
        {
           
            cbSınıf.Items.AddRange(sınıflar);
            Ogr yeniPers = new();
            yeniPers.Ad = txtAd.Text;
            yeniPers.Soyad = txtSoyad.Text;
            yeniPers.Sınıf = cbSınıf.SelectedIndex;
            yeniPers.Konu = txtOdevKonusu.Text;
            yeniPers.Numara = txtNumara.Text;


            liste.Add(yeniPers);

            txtAd.Clear();
            txtSoyad.Clear();

            txtAd.Focus();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gosterilenOgr == null)
            {
                YeniEkle();
            }
            else
            {
                Guncelle();
            }

        }
        void Guncelle()
        {
            gosterilenOgr.Ad = txtAd.Text;
            gosterilenOgr.Soyad = txtSoyad.Text;




        }

        private void Ogrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogr pers = Ogrenciler.SelectedItem as Ogr;

            if (pers != null)
            {

                txtSoyad.Text = pers.Soyad;

                txtSoyad.Text = pers.Ad;


                gosterilenOgr = pers;

            }
            else
            {
                gosterilenOgr = null;

            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //Seçili personeli kaldýr, yani yeni personel ekleyeceðim
            Ogrenciler.SelectedIndex = -1;
            //alanlarý temizle
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
            txtPuan.Clear();
            txtOdevKonusu.Clear();
            cbSınıf.SelectedIndex = -1;
            //ilk kontrole TtxtAd odaklan
            txtAd.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Ogrenciler.SelectedItem != null)
            {
                // Seçili personeli kaldır
                liste.Remove((Ogr)Ogrenciler.SelectedItem);
                gosterilenOgr = null;

                // Alanları temizle
                txtAd.Clear();
                txtSoyad.Clear();
                txtNumara.Clear();
                txtOdevKonusu.Clear();
                txtPuan.Clear();

                // Kullanıcıya bilgi mesajı göster
                MessageBox.Show("Seçili personel silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir personel seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string metin = JsonSerializer.Serialize(liste);

            File.WriteAllText("bilgiler.txt", metin);
            MessageBox.Show("Kaydedildi");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
