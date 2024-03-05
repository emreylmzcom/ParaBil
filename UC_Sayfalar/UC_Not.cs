using iText.Commons.Bouncycastle.Cert.Ocsp;
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
    public partial class UC_Notcs : UserControl
    {
        private veritabani myDatabase;
        public UC_Notcs()
        {
            InitializeComponent();

            myDatabase = new veritabani();
            myDatabase.veritabaniolustur();


            // DataGridView'a sütunları ekle
            dataGridViewNotlar.Columns.Add("NotID", "NotID");
            dataGridViewNotlar.Columns.Add("Baslik", "Başlık");
            dataGridViewNotlar.Columns.Add("Icerik", "İçerik");
            dataGridViewNotlar.Columns.Add("Tarih", "Tarih");
            dataGridViewNotlar.CellDoubleClick += DataGridViewNotlar_CellDoubleClick;

            //notid gizle 
            dataGridViewNotlar.Columns["NotID"].Visible = false;
            dataGridViewNotlar.Columns["Tarih"].Visible = false;

            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Sil");
            deleteMenuItem.Click += DeleteMenuItem_Click;

            ToolStripMenuItem showMenuItem = new ToolStripMenuItem("Göster");
            showMenuItem.Click += ShowMenuItem_Click;

            contextMenuStrip.Items.Add(deleteMenuItem);
            contextMenuStrip.Items.Add(showMenuItem);

            dataGridViewNotlar.ContextMenuStrip = contextMenuStrip;


            NotlariListele();
        }
        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            ShowSelectedNote();
        }

        private void ShowSelectedNote()
        {
            // Seçilen hücrenin indeksini kontrol et
            if (dataGridViewNotlar.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewNotlar.SelectedRows[0].Index;

                // İlgili hücrenin içeriğini al
                string baslik = dataGridViewNotlar.Rows[rowIndex].Cells["Baslik"].Value.ToString();
                string icerik = dataGridViewNotlar.Rows[rowIndex].Cells["Icerik"].Value.ToString();
                string tarih = dataGridViewNotlar.Rows[rowIndex].Cells["Tarih"].Value.ToString();

                // İçeriği MessageBox ile göster
                MessageBox.Show($"Başlık: {baslik}\nİçerik: {icerik}\nTarih: {tarih}", "Not Detayı");
            }
        }
        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text;
            string icerik = txtIcerik.Text;

            // Not ekleme işlemi
            myDatabase.NotEkle(baslik, icerik);

            // Listeyi güncelle
            NotlariListele();
        }


        public void NotlariListele()
        {
            // Notları getir
            List<Not> notlar = myDatabase.TumNotlariGetir();

            // DataGridView'ı temizle
            dataGridViewNotlar.Rows.Clear();

            // Notları DataGridView'a ekle
            foreach (var not in notlar)
            {
                dataGridViewNotlar.Rows.Add(not.NotID, not.Baslik, not.Icerik, not.Tarih);
            }
        }

        private void DataGridViewNotlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /// Geçerli bir indeks kontrolü yap
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewNotlar.Rows.Count)
            {
                // Seçilen hücrenin içeriğini al
                string baslik = dataGridViewNotlar.Rows[e.RowIndex].Cells["Baslik"].Value.ToString();
                string icerik = dataGridViewNotlar.Rows[e.RowIndex].Cells["Icerik"].Value.ToString();
                string tarih = dataGridViewNotlar.Rows[e.RowIndex].Cells["Tarih"].Value.ToString();

                // İçeriği MessageBox ile göster
                MessageBox.Show($"Başlık: {baslik}\nİçerik: {icerik}\nTarih: {tarih}", "Not Detayı:");
            }
        }




        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            // Silme işlemini gerçekleştir
            DeleteSelectedNote();
        }

        private void DeleteSelectedNote()
        {
            // Silme işlemini gerçekleştir
            if (dataGridViewNotlar.SelectedRows.Count > 0)
            {



                int NotID = Convert.ToInt32(dataGridViewNotlar.SelectedRows[0].Cells["NotID"].Value);

               

                // Silme işlemini gerçekleştir
                myDatabase.NotSil(NotID);

                // Listeyi güncelle
                NotlariListele();
            }


        }
    }
}
