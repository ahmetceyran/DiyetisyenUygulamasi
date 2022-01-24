using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public abstract class RaporCesidi
    {
        public abstract void hastaBilgiAl(string ad, string soyad, string tc);
        public abstract void saglikBilgiAl(string diyet, string hastalik);

        public abstract Rapor raporOlustur(string altUst);
    }
}
