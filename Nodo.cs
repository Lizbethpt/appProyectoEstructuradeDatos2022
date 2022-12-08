using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace appProyectoEstructuradeDatos2022
{
    class Nodo
    {
        public int dato { get; set; }
        public Nodo izquierdo { get; set; }
        public Nodo derecho { get; set; }

        public Nodo(int dato)
        {
            this.dato = dato;
            this.izquierdo = null;
            this.derecho = null;
        }
    }
}
