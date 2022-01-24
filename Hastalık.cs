using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    class Hastalık
    {
        public string Ad { get; set; }
        public string Belirti1 { get; set; }
        public string Belirti2 { get; set; }
        public string Belirti3 { get; set; }

        public Hastalık(string ad, string belirti1, string belirti2, string belirti3)
        {
            Ad = ad;
            Belirti1 = belirti1;
            Belirti2 = belirti2;
            Belirti3 = belirti3;
        }

        public Hastalık Clone()
        {
            return MemberwiseClone() as Hastalık;
        }
    }
}
