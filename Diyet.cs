using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    class Diyet
    {
        public string Ad { get; set; }
        public int Gün { get; set; }
        public string Kahvaltı { get; set; }
        public string Ogle { get; set; }
        public string Aksam { get; set; }
        public string Ara { get; set; }

        public Diyet(string ad, int gün, string kahvaltı, string ogle, string aksam, string ara)
        {
            Ad = ad;
            Gün = gün;
            Kahvaltı = kahvaltı;
            Ogle = ogle;
            Aksam = aksam;
            Ara = ara;
        }

        public Diyet Clone()
        {
            return MemberwiseClone() as Diyet;
        }
    }
}
