using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class listas
    {
        private Nodo primerNodo;
        private Nodo ultimoNodo;

        public listas()
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

        public void InsertarNodoInicio(Alumno datos)
        {
            if (listaVacia())
            {
                Nodo nuevoNodo = new Nodo(datos);
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                Nodo nuevoNodo = new Nodo(datos, primerNodo);
                primerNodo = nuevoNodo;
            }
        }

        public void insertarNodoFinal(Alumno datos)
        {
            if (listaVacia())
            {
                Nodo nuevoNodo = new Nodo(datos);
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                Nodo nuevoNodo = new Nodo(datos);
                ultimoNodo.nodoSiguiente = nuevoNodo;
                nuevoNodo.nodoSiguiente = null;
            }
        }
        public void eliminarNodoInicial()
        {
            if (listaVacia())
            {
                if(primerNodo==ultimoNodo)
                {
                    primerNodo = null;
                    ultimoNodo = null;
                }
            }
            else
            {
                Nodo auxiliar = primerNodo;
                while(auxiliar.nodoSiguiente != ultimoNodo)
                {
                    auxiliar = auxiliar.nodoSiguiente;
                    ultimoNodo.nodoSiguiente = null;
                }

            }
            {
                MessageBox.Show("La lista esta vacía");
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
