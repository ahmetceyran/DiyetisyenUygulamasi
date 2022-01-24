using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public class hastaUstte
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public string diyet { get; set; }
        public string hastalik { get; set; }
        public override string ToString()
        {
            return ad + "    " + soyad + "   " + tc + "  " + diyet + "          " + hastalik;
        }
    }
}
