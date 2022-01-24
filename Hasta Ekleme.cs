using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Mimarisi
{
    public partial class Hasta_Ekleme : Form
    {
        public Hasta_Ekleme()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (((txtdiyet.Text != "Akdeniz Diyeti") && (txtdiyet.Text != "Gluten Free Diyeti") && (txtdiyet.Text != "Deniz Ürünleri Diyeti") && (txtdiyet.Text != "Yeşillik Dünyası Diyeti")) || ((txthastalik.Text != "Çölyak") && (txthastalik.Text != "Obezite") && (txthastalik.Text != "Diyabet") && (txthastalik.Text != "Hipertansiyon")))
                MessageBox.Show("Diyet veya Hastalık ismi Yanlış yada Sistemde Mevcut Değil!!!\n\tLütfen Tekrar Deneyiniz!!!");
            else
            {
                Hasta.ad = txthastadı.Text;
                Hasta.soyad = txthastasoyad.Text;
                Hasta.tc = txthastatc.Text;
                Hasta.diyet = txtdiyet.Text;
                Hasta.hastalık = txthastalik.Text;

                MessageBox.Show("Hasta Başarıyla Kaydedildi!!!");

                this.Close();
            }
        }
    }
}
