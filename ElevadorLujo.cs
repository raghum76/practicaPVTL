using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevadroClases
{
    class ElevadorLujo : Elevador
    {
        private bool _alarma;
        public ElevadorLujo(int pisosTotales)
            :base(pisosTotales)
        {
            _alarma = false;
        }
    }
}
