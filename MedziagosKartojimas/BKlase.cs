using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    public class BKlase : AKlase, IZodisKitaip
    {
        string newName;
        public BKlase(string name) : base(name)
        {
            name = newName;
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

        public string ZodisBePriebalsiu(string zodis)
        {
            StringBuilder a = new StringBuilder();
            for (int i = 0; i < zodis.Length; i++)
            {
                if (zodis[i] != 'a' || zodis[i] != 'e' || zodis[i] != 'i' || zodis[i] != 'o' || zodis[i] != 'u')
                {
                    a.Append(zodis[i]);
                }
                else a.Append(zodis[i]);
            }
            return a.ToString();
        }

        public string ZodisPakeistomisBalsemis(char a)
        {
            StringBuilder ab = new StringBuilder();
            List<char> balses = new List<char> { 'a', 'e', 'y', 'u', 'i', 'o' };
            foreach (var letter in Name)
            {
                ab.Append(balses.Contains(letter) ? a.ToString() : letter.ToString());
            }
            return ab.ToString();
        }

        public string ZodisPakeistomisPriebalsemis(int x)
        {
            StringBuilder ab = new StringBuilder();
            List<char> balses = new List<char> { 'a', 'e', 'y', 'u', 'i', 'o' };
            foreach (var letter in Name)
            {
                ab.Append(balses.Contains(letter) ? x.ToString() : letter.ToString());
            }
            return ab.ToString();
        }
    }
}
