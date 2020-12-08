﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    public abstract class BaseClass
    {
        public BaseClass(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int Skaicius { get; set; }

        public abstract string NameMetodas();

        public abstract int NameKodas(int skaicius);
    
  
    }



}
