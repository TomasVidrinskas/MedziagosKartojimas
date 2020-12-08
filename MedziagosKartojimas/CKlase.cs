using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    public class CKlase : BKlase
    {
        public CKlase(int skaicius)
        {
            Skaicius = skaicius;
        }

        public CKlase(int skaicius, string zodis) : this(skaicius)
        {
            Zodis = zodis;
        }

        public CKlase(int skaicius, string zodis, double doubleSkaicius, AKlase aObjektas) : this(skaicius, zodis)
        {
            DoubleSkaicius = doubleSkaicius;
            AObjektas = aObjektas;
        }

        public int Skaicius { get; set; }
        public string Zodis { get; set; }
        public double DoubleSkaicius { get; set; }
        public AKlase AObjektas { get; set; }

    }
}
