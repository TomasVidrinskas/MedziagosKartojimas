using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    public interface IZodisKitaip
    {
        string ZodisBeBalsiu(string zodis);
        string ZodisBePriebalsiu();
        string ZodisPakeistomisBalsemis(char a);
        string ZodisPakeistomisPriebalsemis(int x);



    }
}
