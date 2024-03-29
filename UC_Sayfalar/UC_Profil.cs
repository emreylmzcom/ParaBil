﻿using System;
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


            cmbKategoriTuru.Items.Clear();
            // İşlem türlerini ComboBox'a yükle
            cmbKategoriTuru.Items.Add("Gelir");
            cmbKategoriTuru.Items.Add("Gider");
        }



        public void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string kategoriAdi = txtKategoriAdi.Text;
            // kategori türü combobox'tan al
            string kategoriTuru = cmbKategoriTuru.Text;

            // kategori adı boş ise hata ver
            if (string.IsNullOrWhiteSpace(kategoriAdi))
            {
                MessageBox.Show("Geçerli bir kategori adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // veritabani sınıfını kullanarak kategori ekle
            myDatabase.KategoriEkle(kategoriAdi, kategoriTuru);

            MessageBox.Show("Kategori başarıyla eklendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // textboxları temizle
            txtKategoriAdi.Text = "";
            cmbKategoriTuru.Text = "";
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

            // textboxları temizle
            txtHesapAdi.Text = "";
            txtBakiye.Text = "";

        }



        // txtMiktar TextBox kontrolü için KeyPress olayı
        private void txtBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            // txtBakiye'ı başlatmadan önce kontrol et
            if (txtBakiye != null)
            {
                // Sadece sayılar, kontrol tuşları ve ondalık ayırıcı (nokta) kabul edilsin ve - ile başlayabilsin
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',') && (e.KeyChar != '-'))
                {
                    e.Handled = true;

                    // Hata mesajını kullanıcıya göster
                    MessageBox.Show("Lütfen sadece sayısal değerler giriniz.\nSadece eksi '-' ile başlayabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
