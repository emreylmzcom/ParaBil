using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaBil.UC_Sayfalar
{
    public partial class UC_Ayarlar : UserControl
    {
        public UC_Ayarlar()
        {
            InitializeComponent();
        }



        private void hepsinisil_Click(object sender, EventArgs e)
        {
            // tüm tabloları sil
            DialogResult dialogResult = MessageBox.Show("Tüm verileri silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                veritabani myDatabase = new veritabani();
                myDatabase.veritabaniolustur();
                myDatabase.tumTablolariSil();


                DialogResult dialogResult2 = MessageBox.Show("Tüm veriler silindi.\nProgramı yeniden başlatmak için tamam'a basın.", "Uyarı", MessageBoxButtons.OK);
                if (dialogResult2 == DialogResult.OK)
                {
                    Application.Restart();
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
