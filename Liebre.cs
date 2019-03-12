using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevadroClases
{
    class Liebre:Corredor 
    {
        
        public Liebre(int numero) : base(numero)
        {
            
        }

        new public  int  correr()
        {
            int avance=base.correr();
            return 0;
        }

    }
}
