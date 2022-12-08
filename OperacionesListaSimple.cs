using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class OperacionesListaSimple
    {
        private NodoListaSimple head;

        public NodoListaSimple Head
        {
            get { return head; }
            set { head = value; }
        }

        public void Agregar(NodoListaSimple n)
        {
            //Primero
            if (head == null)
            {
                head = n;
                return;
            }
            //Antes
            if (n.Dato < head.Dato)
            {
                n.Siguiente = head;
                head = n;
                return;
            }

            //En medio
            NodoListaSimple h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato > n.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            }

            if (h.Siguiente != null)
            {
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
                return;
            }
            h.Siguiente = n;
        }

        public override string ToString()
        {
            string lista = "";
            NodoListaSimple h = head;
            if (h != null)
            {
                lista += h.ToString();
                h = h.Siguiente;
                while (h != null)
                {
                    lista += "," + h.ToString();
                    h = h.Siguiente;
                }
                return lista;
            }
            else
            {
                return "La lista esta vacia";
            }
        }

        public void Borrar(int dato)
        {
            if (head != null)
            {
                if (head.Dato == dato)
                {
                    head = head.Siguiente;
                    return;
                }
                NodoListaSimple h = head;
                while (h.Siguiente != null)
                {
                    if (h.Siguiente.Dato == dato)
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                        return;
                    }
                    h = h.Siguiente;
                }
            }
        }
    }
}
