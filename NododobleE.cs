using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class NododobleE
    {
        private string dato;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        private NododobleE siguiente;
        public NododobleE Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        private NododobleE anterior;
        public NododobleE Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public NododobleE()
        {
            dato = "";
            siguiente = null;
            anterior = null;
        }
        public NododobleE(string dato, NododobleE siguiente, NododobleE anterior)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.anterior = anterior;
        }
        public override string ToString()
        {
            return " - " + Dato.ToString();
        }
    }
}
