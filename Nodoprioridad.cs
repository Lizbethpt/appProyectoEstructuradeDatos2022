using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class Nodoprioridad
    {
        private string dato;
        private Nodoprioridad siguiente;
        private int prioridad;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodoprioridad Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }
        public Nodoprioridad()
        {
            dato = "";
            prioridad = 0;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
