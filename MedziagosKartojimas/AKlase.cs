using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
        {
        }

        public override int NameKodas(int sk)
        {
            
        }

        public string NameMetodas(string zodis)
        {
            
            StringBuilder a = new StringBuilder();
            for (int i = 0; i < zodis.Length; i++)
            {
                if (zodis[i] == 'a' || zodis[i] == 'e' || zodis[i] == 'i' || zodis[i] == 'o' || zodis[i] == 'u')
                {
                    a.Append((int)zodis[i]);
                }
                else a.Append(zodis[i]);
            }
            return a.ToString();
        }

        private string BalsesIKoda(string zodis)
        {
            return BalsesIKoda(Name);
        }
    }
}
