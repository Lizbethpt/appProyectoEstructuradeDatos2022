using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProyectoEstructuradeDatos2022
{
    class Colaprioridad
    {
        private Nodoprioridad[] prioridades;
        private int frente;
        private int final;
        public Colaprioridad()
        {
            prioridades = null;
            frente = -1;
            final = -1;
        }
        public void CrearArreglo(int num)
        {
            prioridades = new Nodoprioridad[num];
        }
        public void Agregar(Nodoprioridad nuevo)
        {
            if (frente == -1)
            {
                frente = 0;
                final = 0;
                prioridades[0] = nuevo;
                return;
            }
            if (prioridades[nuevo.Prioridad] == null)
            {
                final = nuevo.Prioridad;
                prioridades[nuevo.Prioridad] = nuevo;
                return;
            }
            Nodoprioridad h = prioridades[nuevo.Prioridad];
            while (h.Siguiente != null)
            {
                h = h.Siguiente;
            }
            h.Siguiente = nuevo;
        }
        public void Eliminar()
        {
            if (frente == -1)
            {
                return;
            }
            if (frente == final)
            {
                if (prioridades[frente].Siguiente == null)
                {
                    prioridades[frente] = null;
                    frente = -1;
                    final = -1;
                }
                else
                {
                    prioridades[frente] = prioridades[frente].Siguiente;
                }
                return;
            }
            if (prioridades[frente].Siguiente != null)
            {
                prioridades[frente] = prioridades[frente].Siguiente;
                return;
            }
            if (prioridades[frente].Siguiente == null)
            {
                if (frente == prioridades.Length - 1)
                {
                    prioridades[frente] = null;
                    frente = 0;
                }
                else
                {
                    prioridades[frente] = null;
                    frente++;
                }
                return;
            }
        }
        public override string ToString()
        {
            string cadena = "";
            if (frente != -1)
            {
                for (int i = frente; i < prioridades.Length; i++)
                {
                    if (prioridades[i] == null)
                    {
                        return cadena += "";
                    }
                    cadena += prioridades[i].ToString();
                    Nodoprioridad h = prioridades[i];
                    if (h == null)
                    {
                        cadena += "";
                    }
                    else
                    {
                        while (h.Siguiente != null)
                        {
                            cadena += ", " + h.Siguiente.ToString();
                            h = h.Siguiente;
                        }
                    }
                    cadena += "\r\n";
                }
                return cadena;
            }
            else
            {
                return "Cola vacía";
            }
        }
    }
}
