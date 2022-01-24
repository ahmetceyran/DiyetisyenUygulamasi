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
    public partial class Admin_Ekranı : Form
    {
        public Admin_Ekranı()
        {
            InitializeComponent();
        }

        private void btndekle_Click(object sender, EventArgs e)
        {
            Diyetisyen.ad = txtad.Text;
            Diyetisyen.soyad = txtsoyad.Text;
            Diyetisyen.tc = txttc.Text;
            Diyetisyen.kullaniciadi = txtkullaniciadi.Text;
            Diyetisyen.sifre = txtsifre.Text;

            MessageBox.Show("Diyetisyen başarıyla kaydedildi!!");
            this.Hide();
        }
    }
}
