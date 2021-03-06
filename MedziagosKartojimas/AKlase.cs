﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    public class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
        {
        }

        public override int NameKodas(int sk)
        {
            return RaideIKoda(Skaicius);
        }

        public override string NameMetodas()
        {
            return BalsesIKoda(Name);
        }

        private string BalsesIKoda(string zodis)
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

        private int RaideIKoda(int sk)
        {

            var zodis = Name;
            int suma = 0;
            for (int i = 0; i < zodis.Length; i++)
            {
                suma += (int)zodis[i] * sk;
            }
            return suma;
        }
    }
}
