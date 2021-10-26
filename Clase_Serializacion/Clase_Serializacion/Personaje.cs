
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clase_Serializacion
{
    [XmlInclude(typeof(Mago))]
    public class Personaje
    {
        private int puntosDeVida;
        private string nombre;

        public int PuntosDeVida
        {
            get
            {
                return puntosDeVida;
            }
            set
            {
                puntosDeVida = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public Personaje()
        {
        }

        public Personaje(int puntosDeVida, string nombre)
        {
            this.puntosDeVida = puntosDeVida;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return $"Nombre: {this.nombre} Puntos: {this.puntosDeVida}";
        }
    }
}
