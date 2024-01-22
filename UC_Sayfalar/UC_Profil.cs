using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaBil.UC_Sayfalar
{
    public partial class UC_Profil : UserControl
    {

        private veritabani myDatabase;


        public UC_Profil()
        {
            InitializeComponent();
            // veritabani sınıfını oluştur
            myDatabase = new veritabani();
            myDatabase.veritabaniolustur();


            txtBakiye.KeyPress += new KeyPressEventHandler(txtBakiye_KeyPress);
        }



        public void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string kategoriAdi = txtKategoriAdi.Text;

            // kategori adı boş ise hata ver

            if (string.IsNullOrWhiteSpace(kategoriAdi))
            {
                MessageBox.Show("Geçerli bir kategori adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // veritabani sınıfını kullanarak kategori ekle
            myDatabase.KategoriEkle(kategoriAdi);

            MessageBox.Show("Kategori başarıyla eklendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void btnHesapEkle_Click(object sender, EventArgs e)
        {
            string hesapAdi = txtHesapAdi.Text;
            double bakiye;

            if (string.IsNullOrWhiteSpace(hesapAdi) || !double.TryParse(txtBakiye.Text, out bakiye))
            {
                MessageBox.Show("Geçerli bir hesap adı ve bakiye giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // veritabani sınıfını kullanarak hesap ekle
            myDatabase.HesapEkle(hesapAdi, bakiye);

            MessageBox.Show("Hesap başarıyla eklendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        // txtMiktar TextBox kontrolü için KeyPress olayı
        private void txtBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            // txtBakiye'ı başlatmadan önce kontrol et
            if (txtBakiye != null)
            {
                // Sadece sayılar, kontrol tuşları ve ondalık ayırıcı (nokta) kabul edilsin
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
                {
                    e.Handled = true;

                    // Hata mesajını kullanıcıya göster
                    MessageBox.Show("Lütfen sadece sayısal değerler giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Eğer nokta veya virgül kullanıcının birinci karakterse, engelle
                if ((e.KeyChar == '.' || e.KeyChar == ',') && txtBakiye.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;

                    // Hata mesajını kullanıcıya göster
                    MessageBox.Show("Lütfen sadece bir ondalık ayırıcı kullanınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
