using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    class saglikUstte
    {
        public string diyet { get; set; }
        public string hastalik { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string tc { get; set; }
        
        public override string ToString()
        {
            return diyet + "    " + hastalik + "    " + isim + "    " + soyisim + "         " + tc;
        }
    }
}
