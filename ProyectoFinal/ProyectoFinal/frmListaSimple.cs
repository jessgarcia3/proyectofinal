using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmListaSimple : Form
    {
        listSimple listSimple = new listSimple();
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            Alumno agregarAlumno = new Alumno();
            agregarAlumno.nombre = txtNombre.Text;
            agregarAlumno.apellido = txtApellido.Text;
            agregarAlumno.edad = txtEdad.Text;
            agregarAlumno.carnet = txtCarnet.Text;
            agregarAlumno.carrera = txtCarrera.Text;
            agregarAlumno.facultad = txtFacultad.Text;

            this.listSimple.insertarNodo(agregarAlumno);
            this.listSimple.mostrarDatosLista(dgvAlumno);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void dgvAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAlumno.Rows.Count)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = e.RowIndex;

                // Obtener los datos del siguiente nodo en la lista
                Alumno siguienteAlumno = listSimple.ObtenerSiguienteNodo();

                if (siguienteAlumno != null)
                {
                    string mensaje = $"Nombre: {siguienteAlumno.nombre}\nEdad: {siguienteAlumno.edad}\nCarrera: {siguienteAlumno.carrera}";
                    MessageBox.Show(mensaje, "Siguiente Alumno");
                }
                else
                {
                    MessageBox.Show("Fin de la lista.");
                }
            }
        }
    }
}
