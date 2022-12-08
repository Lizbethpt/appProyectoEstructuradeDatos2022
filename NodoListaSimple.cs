using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class NodoListaSimple
    {
        private int dato;
        private NodoListaSimple siguiente;

        //Propiedades
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoListaSimple Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        //Constructor
        public NodoListaSimple()
        {
            dato = 0;
            siguiente = null;
        }

        public NodoListaSimple(int dato, NodoListaSimple siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
