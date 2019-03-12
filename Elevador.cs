using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevadroClases
{
    class Elevador 
    {
        private int _pisosTotales;
        private bool _puerta;
        private int _pisoActual;

        public int PisosTotales
        {
            get { return _pisosTotales; }
        }

        public int PisoActual
        {
            get { return _pisoActual; }
        }

        public bool Puerta
        {
            get
            {   return _puerta;}
        }

        public Elevador(int Pisostotales)
        {
            _pisosTotales = PisosTotales;
            _puerta = false;
            _pisoActual = 1;
        }

        public bool AbrirPuerta()
        {
            return true;
        }
        public bool CerrarPuerta()
        {
            return false;
        }
        private void Subir()
        {
            if (_pisoActual < _pisosTotales)
                _pisoActual++;
        }

        private void Bajar()
        {
            if (_pisoActual > 1)
                _pisoActual--;
        }

        public override string ToString()
        {
            string edoPuerta = " cerrada";
            if (_puerta)
                edoPuerta = " abierta";
            return _pisoActual.ToString() +
                " de " + _pisosTotales.ToString()
                + edoPuerta;
        }

        public void irA(int pisoDestino)
        {
            CerrarPuerta();
            if (_pisoActual < pisoDestino)
                while (_pisoActual != pisoDestino)
                    Subir();
            else
                while (_pisoActual != pisoDestino)
                    Bajar();
            AbrirPuerta();
        }


    }
}
