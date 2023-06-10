using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoFinal
{
    internal class listSimple
    {
        private Nodo primerNodo;

        public listSimple()
        {
            primerNodo = null;
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
            Nodo nuevoNodo = new Nodo(datos);

            if (this.primerNodo == null)
            {
                this.primerNodo = nuevoNodo;
            }
            else
            {
                Nodo actualNodo = this.primerNodo;
                while (actualNodo.nodoSiguiente != null)
                {
                    actualNodo = actualNodo.nodoSiguiente;
                }
                actualNodo.nodoSiguiente = nuevoNodo;
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

