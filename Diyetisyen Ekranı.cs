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
    public partial class Diyetisyen_Ekranı : Form
    {
        public Diyetisyen_Ekranı()
        {
            InitializeComponent();
        }

        private void btnhastaekle_Click(object sender, EventArgs e)
        {
            new Hasta_Ekleme().Show();
        }

        private void btnüst_Click(object sender, EventArgs e)
        {
            new Hasta_Üstte().Show();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            new Hasta_Altta().Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txthastadı.Text != Hasta.ad)
                MessageBox.Show("Girdiğiniz İsimde Bir Hasta Bulunmamaktadır!!!");

            if (txthastadı.Text == Hasta.ad)
            {
                if((txtdiyetadı.Text != "Akdeniz Diyeti") && (txtdiyetadı.Text != "Gluten Free Diyeti") && (txtdiyetadı.Text != "Deniz Ürünleri Diyeti") && (txtdiyetadı.Text != "Yeşillik Dünyası Diyeti"))
                {
                    MessageBox.Show("Diyet İsmini Yanlış Girdiniz veya Mevcut Olmayan Bir Diyet Girdiniz!!! \nDiyet Güncellenemedi!!!");
                }
                else
                {
                    Hasta.diyet = txtdiyetadı.Text;
                    MessageBox.Show("Hasta'nın Diyeti Başarıyla Güncellendi!!");
                    txthastadı.Text = "";
                    txtdiyetadı.Text = "";
                }
            }
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tHastalar\n\n" + "Hasta Adı : " + Hasta.ad + "\nHasta Soyad : " + Hasta.soyad + "\nHasta TC : " + Hasta.tc + "\nHasta'nın Rahatsızlığı : " + Hasta.hastalık
                + "\nHasta Diyeti : " + Hasta.diyet + "\n\n");
        }

        private void btndiyet_Click(object sender, EventArgs e)
        {
            var original = new Diyet("Akdeniz Diyeti",14, "Yarım yağlı yoğurt + 3 kaşık yulaf ezmesi + meyve", "Haşlanmış mercimekli salata + ayran", "Zeytinyağlı sebze yemeği + salata + kepek ekmeği", "Meyve + badem");
            
            var clone1 = original.Clone();
            clone1.Ad = "Gluten Free Diyeti";
            clone1.Gün = 10;
            clone1.Kahvaltı = "Glutensiz ekmek, çiğ sebze (buharda yapılabilir), beyaz peynir, 2 tane kuru erik.";
            clone1.Ogle = "Izgara balık, rokalı salata, mısır ekmeği.";
            clone1.Aksam = "Tavuk sote, pirinçli yayla çorbası, mevsim salatası.";
            clone1.Ara = "Meyve, Kuruyemiş";

            var clone2 = original.Clone();
            clone2.Ad = "Deniz Ürünleri Diyeti";
            clone2.Gün = 20;
            clone2.Kahvaltı = "Avokadolu tost + 1 porsiyon meyve + Bol yeşillik";
            clone2.Ogle = "Izgara balık + haşlama sebze + maden suyu";
            clone2.Aksam = "Izgara balık + bol yeşillikli salata";
            clone2.Ara = "2 adet ceviz veya 5-6 adet badem/fındık";

            var clone3 = original.Clone();
            clone3.Ad = "Yeşillik Dünyası Diyeti";
            clone3.Gün = 15;
            clone3.Kahvaltı = "1 kase badem sütü ile yapılmış yulaf lapası";
            clone3.Ogle = "Sebze yemeği, Büyük bir kase yeşillik salatası";
            clone3.Aksam = "1 kase sebze çorbası, Lahana salatası, Avokadolu yumurta";
            clone3.Ara = "3 adet hurma, 1 fincan şekersiz kahve";

            MessageBox.Show("\t\tDiyetler" + "\nDiyet Adı : " + original.Ad + "\nUygulama Süresi : " + original.Gün + "\nKahvaltı : " + original.Kahvaltı + "\nÖğle : " + original.Ogle + "\nAkşam : " + original.Aksam + "\nAra Öğün : " + original.Ara
                + "\n\n" + "\nDiyet Adı : " + clone1.Ad + "\nUygulama Süresi : " + clone1.Gün + "\nKahvaltı : " + clone1.Kahvaltı + "\nÖğle : " + clone1.Ogle + "\nAkşam : " + clone1.Aksam + "\nAra Öğün : " + clone1.Ara
                + "\n\n" + "\nDiyet Adı : " + clone2.Ad + "\nUygulama Süresi : " + clone2.Gün + "\nKahvaltı : " + clone2.Kahvaltı + "\nÖğle : " + clone2.Ogle + "\nAkşam : " + clone2.Aksam + "\nAra Öğün : " + clone2.Ara
                + "\n\n" + "\nDiyet Adı : " + clone3.Ad + "\nUygulama Süresi : " + clone3.Gün + "\nKahvaltı : " + clone3.Kahvaltı + "\nÖğle : " + clone3.Ogle + "\nAkşam : " + clone3.Aksam + "\nAra Öğün : " + clone3.Ara);
        }

        private void btnhastalık_Click(object sender, EventArgs e)
        {
            var original = new Hastalık("Çölyak", "İshal", "Kusma", "Karın Bölgesinde öne doğru şişkinlik");

            var clone1 = original.Clone();
            clone1.Ad = "Obezite";
            clone1.Belirti1 = "Terleme";
            clone1.Belirti2 = "Çabuk yorulma";
            clone1.Belirti3 = "Aşır Kilo";

            var clone2 = original.Clone();
            clone2.Ad = "Diyabet";
            clone2.Belirti1 = "Halsizlik ve yorgunluk hissi";
            clone2.Belirti2 = "Hızlı ve istemsiz kilo kaybı";
            clone2.Belirti3 = "Ağızda aseton benzeri koku oluşumu";

            var clone3 = original.Clone();
            clone3.Ad = "Hipertansiyon";
            clone3.Belirti1 = "Bulanık ya da çift görme";
            clone3.Belirti2 = "Bacaklarda şişlik";
            clone3.Belirti3 = "Düzensiz kalp atışı ve kalp ağrısı";

            MessageBox.Show("\t\tHastalıklar" + "\nHastalık Adı : " + original.Ad + "\nBelirtiler 1 : " + original.Belirti1 + "\nBelirtiler 2 : " + original.Belirti2 + "\nBelirtiler 3 : " + original.Belirti3
                + "\n\n" + "\nHastalık Adı : " + clone1.Ad + "\nBelirtiler 1 : " + clone1.Belirti1 + "\nBelirtiler 2 : " + clone1.Belirti2 + "\nBelirtiler 3 : " + clone1.Belirti3
                + "\n\n" + "\nHastalık Adı : " + clone2.Ad + "\nBelirtiler 1 : " + clone2.Belirti1 + "\nBelirtiler 2 : " + clone2.Belirti2 + "\nBelirtiler 3 : " + clone2.Belirti3
                + "\n\n" + "\nHastalık Adı : " + clone3.Ad + "\nBelirtiler 1 : " + clone3.Belirti1 + "\nBelirtiler 2 : " + clone3.Belirti2 + "\nBelirtiler 3 : " + clone3.Belirti3);
        }
    }
}
