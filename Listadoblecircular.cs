using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class Listadoblecircular
    {
        Nododoblecircular head = new Nododoblecircular();

        public Listadoblecircular()
        {
            head = null;
        }
        public void Agregar(Nododoblecircular n)
        {
            //primero

            if (head == null)
            {
                head = n;
                head.Siguiente = head;
                head.Atras = head;
                return;
            }
            //antes
            if (n.Dato < head.Dato)
            {
                n.Siguiente = head;
                n.Atras = head.Atras;
                head.Atras.Siguiente = n;
                head.Atras = n;
                head = n;
                return;
            }
            //en medio
            Nododoblecircular h = head;
            while (h.Siguiente != head)
            {

                if (h.Siguiente.Dato > n.Dato)
                {

                    break;
                }
                h = h.Siguiente;
            }

            n.Siguiente = h.Siguiente;
            n.Atras = h;
            h.Siguiente.Atras = n;
            h.Siguiente = n;
        }
        public bool Buscar(int valorbuscar)
        {
            bool encontrado = false;
            if (head.Dato == valorbuscar)
            {
                return encontrado = true;
            }
            Nododoblecircular h = head;

            while (h.Siguiente != head)
            {
                if (h.Siguiente.Dato == valorbuscar)
                {
                    return true;
                }
                h = h.Siguiente;
            }
            return encontrado;
        }
        public void Eliminar(int valoreliminar)
        {

            if (head.Dato == valoreliminar)
            {
                head.Atras.Siguiente = head.Siguiente;
                head.Siguiente.Atras = head.Atras;
                head = head.Siguiente;
                return;
            }
            Nododoblecircular h = head;

            while (h.Siguiente != head)
            {
                if (h.Siguiente.Dato == valoreliminar)
                {
                    h.Siguiente.Siguiente.Atras = h;
                    h.Siguiente = h.Siguiente.Siguiente;
                    return;
                }
                h = h.Siguiente;
            }
            return;

        }
        public void ImprimirPU()
        {
            string listadatos = "";
            Nododoblecircular h = head;
            if (h != null)
            {
                do
                {
                    listadatos += h.ToString();
                    h = h.Siguiente;
                } while (h != head);
                
            }
            else
            {
                //MessageBox.Show("La lista se encuentra vacia");
            }
        }
    }
}
