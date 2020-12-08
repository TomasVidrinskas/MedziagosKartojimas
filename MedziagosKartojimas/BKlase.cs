using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    public class BKlase : AKlase, IZodisKitaip
    {
        public BKlase(string name) : base(name)
        {
        }

        public string ZodisBeBalsiu(string zodis)
        {
            StringBuilder a = new StringBuilder();
            for (int i = 0; i < zodis.Length; i++)
            {
                if (zodis[i] == 'a' || zodis[i] == 'e' || zodis[i] == 'i' || zodis[i] == 'o' || zodis[i] == 'u')
                {
                    a.Append(zodis);
                }
                else a.Append(zodis[i]);
            }
            return a.ToString();
        }

        public string ZodisBePriebalsiu()
        {
            throw new NotImplementedException();
        }

        public string ZodisPakeistomisBalsemis(char a)
        {
            throw new NotImplementedException();
        }

        public string ZodisPakeistomisPriebalsemis(int x)
        {
            throw new NotImplementedException();
        }
    }
}
