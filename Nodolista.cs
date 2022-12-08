using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class Nodolista
    {
        private string dato;
        private Nodolista siguiente;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodolista Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodolista()
        {
            dato = null;
            siguiente = null;
        }
        public Nodolista(string dato, Nodolista siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
