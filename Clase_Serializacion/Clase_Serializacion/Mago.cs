
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Serializacion
{
    public class Mago: Personaje
    {
        private int puntosDeMana;

        public Mago():this()
        {
        }

        public Mago(int puntosDeVida, string nombre, int puntosDeMana):base(puntosDeVida, nombre)
        {
            this.puntosDeMana = puntosDeMana;
        }

        public int PuntosDeMana
        {
            get
            {
                return puntosDeMana;
            }
            set
            {
                puntosDeMana = value;
            }
        }
    }
}
