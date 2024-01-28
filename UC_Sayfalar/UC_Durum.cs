using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

namespace ParaBil.UC_Sayfalar
{
    public partial class UC_Durum : UserControl
    {

        private veritabani myDatabase;

        public UC_Durum()
        {
            InitializeComponent();

            // veritabani sınıfını oluştur
            myDatabase = new veritabani();
            myDatabase.veritabaniolustur();

            gelirchartdurum.Series.Clear();
            giderchartdurum.Series.Clear();


            ozetyazdir();
            ozetgider();
            HarcamalariGoster();
        }


        public void ozetyazdir()
        {

            gelirchartdurum.Visible = true;
            giderchartdurum.Visible = true;

            gelirchartdurum.Series.Clear();

            gelirchartdurum.AxisX.Clear();
            gelirchartdurum.AxisY.Clear();


            // Ay isimleri
            string[] months = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

            // Aylık gelir verilerini al
            List<gelirchart> aylikGelirler = myDatabase.GetAylikGelirler();

            // Chart'ı temizle
            gelirchartdurum.Series.Clear();

            // Gelir serisini oluştur
            SeriesCollection gelirSeries = new SeriesCollection();
            ColumnSeries gelirColumnSeries = new ColumnSeries
            {
                Title = "Gelirler",
                Values = new ChartValues<double>()
            };

            // Her bir ay için geliri ekle
            foreach (var gelir in aylikGelirler)
            {
                gelirColumnSeries.Values.Add(gelir.Miktar);
            }

            // Seriyi chart'a ekle
            gelirSeries.Add(gelirColumnSeries);

            // Chart'ı yapılandır
            gelirchartdurum.Series = gelirSeries;
            gelirchartdurum.AxisX.Add(new Axis
            {
                Title = "Aylar",
                Labels = months
            });
            gelirchartdurum.AxisY.Add(new Axis
            {
                Title = "Gelir (TL)"
               

            });



        }

        public void ozetgider()
        {
            giderchartdurum.Series.Clear();
            giderchartdurum.AxisX.Clear();
            giderchartdurum.AxisY.Clear();



            // gider 
            string[] months = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };


            // Aylık gider verilerini al
            List<giderchart> aylikGiderler = myDatabase.GetAylikGiderler(); // GetAylikGiderler fonksiyonunu tanımlamanız gerekiyor.

            // Chart'ı temizle
            giderchartdurum.Series.Clear();

            // Gider serisini oluştur
            SeriesCollection giderSeries = new SeriesCollection();
            ColumnSeries giderColumnSeries = new ColumnSeries
            {
                Title = "Giderler",
                Values = new ChartValues<double>()
            };

            // Her bir ay için gideri ekle
            foreach (var gider in aylikGiderler)
            {
                giderColumnSeries.Values.Add(gider.Miktar);
            }

            // gider cubugu rengi kırmızı olsun
            giderColumnSeries.Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0));

            // Seriyi chart'a ekle
            giderSeries.Add(giderColumnSeries);

            // Chart'ı yapılandır
            giderchartdurum.Series = giderSeries;
            giderchartdurum.AxisX.Add(new Axis
            {
                Title = "Aylar",
                Labels = months
            });
            giderchartdurum.AxisY.Add(new Axis
            {
                Title = "Gider (TL)"
            });
        }

        public void RaporOlusturAll()
        {
            // Gelir işlemlerini al
            List<IslemRaporu> gelirRaporu = myDatabase.GetIslemRaporu("Gelir");

            // Gider işlemlerini al
            List<IslemRaporu> giderRaporu = myDatabase.GetIslemRaporu("Gider");

            // Raporu oluştur
            StringBuilder rapor = new StringBuilder();

            rapor.AppendLine("Gelir Raporu:");
            rapor.AppendLine("----------------------------------------------------");
            foreach (var gelir in gelirRaporu)
            {


                rapor.AppendLine($"Hesap Adı: {gelir.HesapAdi}, Kategori Adı: {gelir.KategoriAdi}, Miktar: {gelir.Miktar}, Tarih: {gelir.Tarih}");
            }

            rapor.AppendLine();
            rapor.AppendLine("Gider Raporu:");
            rapor.AppendLine("----------------------------------------------------");
            foreach (var gider in giderRaporu)
            {
                rapor.AppendLine($"Hesap Adı: {gider.HesapAdi}, Kategori Adı: {gider.KategoriAdi}, Miktar: {gider.Miktar}, Tarih: {gider.Tarih}");
            }


            // Deneme amaçlı MessageBox ile ekrana yazdıralım.
            // MessageBox.Show(rapor.ToString(), "İşlem Raporu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Raporu PDF dosyasına kaydet
            KaydetPDF(rapor.ToString());


        }

        private void islempdf_Click(object sender, EventArgs e)
        {
            RaporOlusturAll();
        }



        public void HarcamalariGoster()
        {
            // Toplam harcamaları al
            List<ToplamHarcama> toplamHarcamalar = myDatabase.GetToplamHarcamalar();

            // Label metnini oluştur
           string labelText = "";

            // Eğer toplam harcama listesi boş değilse
            if (toplamHarcamalar.Count > 0)
            {
                // En çok harcama yapılan kategoriyi bul
                var enCokHarcamaYapilanKategori = toplamHarcamalar.OrderByDescending(h => h.Miktar).First();

                // Label metnine ekleyerek güncelle
                labelText += $"{enCokHarcamaYapilanKategori.KategoriAdi}: {enCokHarcamaYapilanKategori.Miktar} TL";
            }
            else
            {
                labelText += "Gelir veya Gider ekledikten\n sonra tekrar kontrol ediniz.";
            }

            // Label kontrolünün metnini güncelle
            labelEnCokHarcama.Text = labelText;
        }




        private void aylilislemrapor()
        {
            // Gelir işlemlerini al
            List<IslemRaporu> gelirRaporu = myDatabase.GetIslemRaporu("Gelir");

            // Gider işlemlerini al
            List<IslemRaporu> giderRaporu = myDatabase.GetIslemRaporu("Gider");

            // Raporu oluştur
            StringBuilder rapor = new StringBuilder();

            rapor.AppendLine("Gelir Raporu:");
            rapor.AppendLine("----------------------------------------------------");
            foreach (var gelir in gelirRaporu)
            {
                if (gelir.Tarih.Month == DateTime.Now.Month)
                {
                    rapor.AppendLine($"Hesap Adı: {gelir.HesapAdi}, Kategori Adı: {gelir.KategoriAdi}, Miktar: {gelir.Miktar}, Tarih: {gelir.Tarih}");
                }
            }

            rapor.AppendLine();
            rapor.AppendLine("Gider Raporu:");
            rapor.AppendLine("----------------------------------------------------");
            foreach (var gider in giderRaporu)
            {
                if (gider.Tarih.Month == DateTime.Now.Month)
                {
                    rapor.AppendLine($"Hesap Adı: {gider.HesapAdi}, Kategori Adı: {gider.KategoriAdi}, Miktar: {gider.Miktar}, Tarih: {gider.Tarih}");
                }
            }

            // Raporu bir dosyaya veya ekrana yazdırabilirsiniz.
            // Örneğin, MessageBox ile ekrana yazdıralım.
            //MessageBox.Show(rapor.ToString(), "İşlem Raporu", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Raporu PDF dosyasına kaydet
            KaydetPDF(rapor.ToString());

         
        }

        private void KaydetPDF(string icerik)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Dosyaları (*.pdf)|*.pdf";
                saveFileDialog.Title = "PDF Dosyasını Kaydet";
                saveFileDialog.FileName = "Rapor.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dosyaYolu = saveFileDialog.FileName;

                    using (PdfWriter writer = new PdfWriter(dosyaYolu))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            Document document = new Document(pdf);
                            // Türkçe karakterleri destekleyen bir font kullan
                            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                            document.SetFont(font);

                            document.Add(new Paragraph(icerik));
                        }
                    }

                    MessageBox.Show("Rapor başarıyla kaydedildi: " + dosyaYolu, "İşlem Raporu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


            private void buayrapor_Click(object sender, EventArgs e)
        {
            aylilislemrapor();
        }


    }
}
