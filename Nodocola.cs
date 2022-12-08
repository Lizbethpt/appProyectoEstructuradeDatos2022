using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class Nodocola
    {
        private string dato;
        private Nodocola siguiente;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodocola Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodocola()
        {
            dato = null;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
