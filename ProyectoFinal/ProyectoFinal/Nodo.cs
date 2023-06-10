using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Nodo
    {
        public Alumno Datos;
        private Nodo NodoSiguiente;
        private Nodo NodoAnterior;
        public Alumno datos
        {
            get { return Datos; }
            set { Datos = value; }
        }
        public Nodo nodoSiguiente
        {
            get { return NodoSiguiente; }
            set { NodoSiguiente = value; }
        }

        public Nodo nodoAnterior
        {
            get { return NodoAnterior; }
            set { NodoAnterior = value; }
        }
        public Nodo() { }

        public Nodo(Alumno alumno)
        {
            this.Datos = alumno;
            this.NodoSiguiente = null;
        }

        public Nodo(Alumno alumno, Nodo nodo)
        {
            this.Datos = alumno;
            this.NodoSiguiente = nodo;
        }
    }
}
