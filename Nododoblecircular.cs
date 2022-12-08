using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class Nododoblecircular
    {
        private int dato;
        private Nododoblecircular siguiente;
        private Nododoblecircular atras;
        public int Dato
        { get { return dato; } set { dato = value; } }
        public Nododoblecircular Siguiente
        { get { return siguiente; } set { siguiente = value; } }

        public Nododoblecircular Atras
        { get { return atras; } set { atras = value; } }
        public Nododoblecircular()
        {
            dato = 0;
            siguiente = null;
            atras = null;
        }
        public Nododoblecircular(int dato, Nododoblecircular siguiente, Nododoblecircular atras)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.atras = atras;
        }
        public override string ToString()
        {
            return dato + " - ";
        }
    }
}
