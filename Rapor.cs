using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public class Rapor
    {
            public string HastaBilgi { get; set; }
            public string SaglikBilgi { get; set; }

            public string rapor { get; set; }
        public override string ToString()
        {
            return rapor;
        }

    }
}
