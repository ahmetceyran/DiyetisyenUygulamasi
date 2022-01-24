using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Yazılım_Mimarisi
{
    
    public partial class Hasta_Üstte : Form
    {
        public Hasta_Üstte()
        {
            InitializeComponent();
        }

       
        JsonRapor jsonRapor = new JsonRapor();
        HtmlRapor htmlRapor = new HtmlRapor();
        Rapor rpr = new Rapor();
        public string altUst = "Ust";
        private void btnjson_Click(object sender, EventArgs e)
        {
            jsonRapor.hastaBilgiAl(Hasta.ad, Hasta.soyad, Hasta.tc);
            jsonRapor.saglikBilgiAl(Hasta.diyet, Hasta.hastalık);

            rpr= jsonRapor.raporOlustur(altUst);

            File.WriteAllText(@"C:\\Users\\erhan\\OneDrive\\Masaüstü\\Rapor.json", rpr.rapor);
            MessageBox.Show("Rapor json formatında oluşturuldu.");
        }

        private void btnhtml_Click(object sender, EventArgs e)
        {
            htmlRapor.hastaBilgiAl(Hasta.ad, Hasta.soyad, Hasta.tc);
            htmlRapor.saglikBilgiAl(Hasta.diyet, Hasta.hastalık);

            rpr = htmlRapor.raporOlustur(altUst);

            File.WriteAllText(@"C:\\Users\\erhan\\OneDrive\\Masaüstü\\Rapor.html", rpr.rapor);
            MessageBox.Show("Rapor json formatında oluşturuldu.");

        }
    }
}
