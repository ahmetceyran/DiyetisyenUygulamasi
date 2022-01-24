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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if ((txtkullaniciadi.Text == "admin") && (txtsifre.Text == "admin"))
                new Admin_Ekranı().Show();

            if ((txtkullaniciadi.Text == Diyetisyen.kullaniciadi) && (txtsifre.Text == Diyetisyen.sifre))
                new Diyetisyen_Ekranı().Show();

        }
    }
}
