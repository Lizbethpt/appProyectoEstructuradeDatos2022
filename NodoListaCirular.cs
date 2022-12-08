using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class NodoListaCirular
    {
        private int dato;
        private NodoListaCirular siguiente;
        private NodoListaCirular atras;
        public int Dato
        { get { return dato; } set { dato = value; } }
        public NodoListaCirular Siguiente
        { get { return siguiente; } set { siguiente = value; } }

        public NodoListaCirular Atras
        { get { return atras; } set { atras = value; } }
        public NodoListaCirular()
        {
            dato = 0;
            siguiente = null;
            atras = null;
        }
        public NodoListaCirular(int dato, NodoListaCirular siguiente, NodoListaCirular atras)
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
