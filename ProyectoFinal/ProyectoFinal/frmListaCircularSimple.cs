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
    public partial class frmListaCircularSimple : Form
    {
        listaCircularSimple listaCircular = new listaCircularSimple();
        public frmListaCircularSimple()
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

            this.listaCircular.insertarNodo(agregarAlumno);
            this.listaCircular.mostrarDatosLista(dgvAlumno);
        }
    }
}
