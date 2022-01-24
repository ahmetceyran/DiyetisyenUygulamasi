using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Yazılım_Mimarisi
{
    public class HtmlRapor : RaporCesidi
    {
        hastaUstte hastaBilgiUstte = new hastaUstte();
        saglikUstte saglikBilgiUstte = new saglikUstte();

        Rapor htmlRapor = new Rapor();
        public string altUst;
        public override void hastaBilgiAl(string ad, string soyad, string tc)
        {
            hastaBilgiUstte.ad = ad;
            hastaBilgiUstte.soyad = soyad;
            hastaBilgiUstte.tc = tc;

            saglikBilgiUstte.isim = ad;
            saglikBilgiUstte.soyisim = soyad;
            saglikBilgiUstte.tc = tc;
        }

        public override void saglikBilgiAl(string diyet, string hastalik)
        {
            hastaBilgiUstte.diyet = diyet;
            hastaBilgiUstte.hastalik = hastalik;

            saglikBilgiUstte.diyet = diyet;
            saglikBilgiUstte.hastalik = hastalik;
        }

        public override Rapor raporOlustur(string altust)
        {
            string  html = "<body>";
            html += "<h2>Hasta Bilgileri</h2>";
            html += "<table>";
            if (altust == "Ust")
            {
                html += "<tr>";
                html += "<p>Isim:" + hastaBilgiUstte.ad+ "</p>";
                html += "<p> Soyisim:" + hastaBilgiUstte.soyad + "</p>";
                html += "<p> Tc:" + hastaBilgiUstte.tc + " </p>";
                html += "<lb> Diyet:" + hastaBilgiUstte.diyet + " </p>";
                html += "<p> Hastalık:" + hastaBilgiUstte.hastalik + " </p>";
                html += "</tr> ";
                
            }
            else
            {
                html += "<tr>";
                html += "<p> Diyet:" + saglikBilgiUstte.diyet + " </p>";
                html += "<p> Hastalık:" + saglikBilgiUstte.hastalik + "  </p>";
                html += "<p> Isim:" + saglikBilgiUstte.isim + "  </lb>";
                html += "<p> Soyisim:" + saglikBilgiUstte.soyisim + "  </p>";
                html += "<p> Tc:" + saglikBilgiUstte.tc + "  </lb>";
                html += "</tr> ";
            }
            html += "</table>";
            html += "</body>";

            htmlRapor.rapor = html;
            return htmlRapor;
        }
    }
}
