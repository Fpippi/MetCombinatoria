using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
        public static int fattoriale(int numero)
        {
            int risultato = 1;

            for (int i = 1; i <= numero; i++)//il fattoriale vuol dire che moltiplica tutti i sono tutti i numeri naturali  insieme
            {
                risultato = risultato * i;
            }

            return risultato;
        }
    }
}
