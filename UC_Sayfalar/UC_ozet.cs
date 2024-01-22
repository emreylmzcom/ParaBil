using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaBil.UC_Sayfalar
{
    public partial class UC_ozet : UserControl
    {

        private veritabani myDatabase;
        

        public UC_ozet()
        {
            InitializeComponent();

            // veritabani sınıfını oluştur
            myDatabase = new veritabani();
            myDatabase.veritabaniolustur();


            ozetyazdir();
        }

        public void ozetyazdir()
        {
            // veritabanı sınıfındaki getoplam bakiyeyi çağır ve mevcut_bakiye labeline yazdır
           
            double toplamBakiye = myDatabase.GetToplamBakiye();
            mevcut_bakiye.Text = toplamBakiye.ToString("C2");


            // veritabanı sınıfındaki gettoplam geliri çağır ve toplam_gelir labeline yazdır
            double toplamGelir = myDatabase.GetBuAykiToplamGelir();
            aylik_gelir.Text = toplamGelir.ToString("C2");

            // veritabanı sınıfındaki gettoplam gideri çağır ve toplam_gider labeline yazdır
            double toplamGider = myDatabase.GetBuAykiToplamGider();
            aylik_gider.Text = toplamGider.ToString("C2");
           
            // GetSonBesGelir metodundan bilgileri al
            List<GelirBilgisi> sonBesGelir = myDatabase.GetSonBesGelir();

            // ListBox temizle
            son5gelir.Items.Clear();

            son5gelir.Items.Add("");
            // ListBox'a bilgileri ekle
            foreach (GelirBilgisi gelir in sonBesGelir)
            {

                son5gelir.Items.Add("");
                son5gelir.Items.Add($"{gelir.HesapAdi} - {gelir.KategoriAdi} - {gelir.Miktar:C2} - {gelir.Tarih:dd-MM-yyyy}");
            }


            // GetSonBesGider metodundan bilgileri al
            List<GelirBilgisi> sonBesGider = myDatabase.GetSonBesGider();

            // ListBox temizle
            son5gider.Items.Clear();


            // listbox'a eklenen bilgilerin başlıklarını ekle


            son5gider.Items.Add("");
            // ListBox'a bilgileri ekle
            foreach (GelirBilgisi gider in sonBesGider)
            {
                son5gider.Items.Add("");
                // ListBox'a bilgileri ekle
                son5gider.Items.Add($"{gider.HesapAdi} - {gider.KategoriAdi} - {gider.Miktar:C2} - {gider.Tarih:dd-MM-yyyy}");
            }




            // hesaplar listbox'ını temizle
            hesaplar.Items.Clear();

            // itemlerin eşit hizaları olsun %50 %50 gibi
            hesaplar.HorizontalExtent = 50;


     

            hesaplar.Items.Add("");
            foreach (Hesap hesap in myDatabase.GetHesapBilgileri())
            {
                hesaplar.Items.Add("");
                hesaplar.Items.Add($"{hesap.HesapAdi} {hesap.Bakiye:C2}");
            }


        }


      






        private void btnIslemSil_Click(object sender, EventArgs e)
        {

        }





    }
}
