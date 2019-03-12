using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevadroClases
{
    class Corredor
    {
        private int _numero;
        protected int _posicion;
        private static Random gen = new Random();

        public Corredor(int numero)
        {
            _numero = numero;
            _posicion = 0;
        }

        public int Posicion
        {
            get { return _posicion; }
        }
        /// <summary>
        /// Propiedad para conocer el numero
        /// </summary>
        public int Numero
        {
            get { return _numero; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        
        public  int correr()
        {
            return gen.Next(20) + 1;
        }

    }
}
