using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yazılım_Mimarisi
{
    
    public class JsonRapor : RaporCesidi
    {
        hastaUstte hastaBilgiUstte = new hastaUstte();
        saglikUstte saglikBilgiUstte = new saglikUstte();
        
        Rapor jsonRapor = new Rapor();
        public override void hastaBilgiAl(string ad, string soyad, string Tc)
        {
            
            hastaBilgiUstte.ad = ad;
            hastaBilgiUstte.soyad = soyad;
            hastaBilgiUstte.tc = Tc;

            saglikBilgiUstte.isim = ad;
            saglikBilgiUstte.soyisim = soyad;
            saglikBilgiUstte.tc = Tc;
        }

        public override void saglikBilgiAl(string diyet, string hastalik)
        {
            
            hastaBilgiUstte.diyet = diyet;
            hastaBilgiUstte.hastalik = hastalik;

            saglikBilgiUstte.diyet = diyet;
            saglikBilgiUstte.hastalik = hastalik;
        }

        public override Rapor raporOlustur(string altUst)
        {             
            if (altUst == "Ust")
            {
                string huRaporJson = JsonConvert.SerializeObject(hastaBilgiUstte);
                jsonRapor.rapor = huRaporJson;
            }
            else if(altUst == "Alt")
            {
                string suRaporJson = JsonConvert.SerializeObject(saglikBilgiUstte);
                jsonRapor.rapor = suRaporJson;
            }
            return jsonRapor;
        }
    }
}
