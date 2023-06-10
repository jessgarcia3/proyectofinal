using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinal
{
    internal class listaCircularSimple
    {
        private Nodo primerNodo;
        private Nodo ultimoNodo;

        public listaCircularSimple() 
        {
            primerNodo = null;
            ultimoNodo = null;
        }
        public bool listaVacia()
        {
            if (primerNodo != null)
            {
                return false;
            }
            else { return true; }
        }

        public void insertarNodo(Alumno datos)
        {
            if (listaVacia())
            {
                Nodo nuevoNodo = new Nodo(datos);
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
                nuevoNodo.nodoSiguiente = primerNodo;
            }
            else
            {
                Nodo nuevoNodo = new Nodo(datos, primerNodo);
                ultimoNodo.nodoSiguiente = nuevoNodo;
                ultimoNodo = nuevoNodo;
                ultimoNodo.nodoSiguiente = primerNodo;
            }
        }
        public int contarNodos()
        {
            if (!listaVacia())
            {
                int numeroNodos = 0;
                Nodo auxiliar = primerNodo;
                while (auxiliar != null)
                {
                    numeroNodos++;
                    auxiliar = auxiliar.nodoSiguiente;
                }
                return numeroNodos;
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
                return 0;
            }
        }
        public void mostrarDatosLista(DataGridView dgv)
        {
            if (!listaVacia())
            {
                dgv.Rows.Clear();
                dgv.RowCount = contarNodos();
                Nodo auxiliar = primerNodo;
                int fila = 0;
                while (auxiliar != null)
                {
                    auxiliar.datos.mostrarDatos(dgv, fila);
                    auxiliar = auxiliar.nodoSiguiente;
                    fila++;
                }
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
                dgv.Rows.Clear();
            }
        }
    }
}
