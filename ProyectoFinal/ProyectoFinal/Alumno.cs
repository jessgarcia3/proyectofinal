using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Alumno
    {
            private String Nombre;
            private String Apellido;
            private String Carnet;
            private String Edad;
            private String Carrera;
            private String Facultad;

            public string nombre
            {
                get { return Nombre; }
                set { Nombre = value; }
            }
            public string apellido
            {
                get { return Apellido; }
                set { Apellido = value; }
            }
            public string carnet
            {
                get { return Carnet; }
                set { Carnet = value; }
            }
            public string edad
            {
                get { return Edad; }
                set { Edad = value; }
            }
            public string carrera
            {
                get { return Carrera; }
                set { Carrera = value; }
            }
            public string facultad
            {
                get { return Facultad; }
                set { Facultad = value; }
            }

            public void mostrarDatos(DataGridView dgv, int fila)
            {
                dgv[0, fila].Value = Nombre;
                dgv[1, fila].Value = Apellido;
                dgv[2, fila].Value = Carnet;
                dgv[3, fila].Value = Edad;
                dgv[4, fila].Value = Carrera;
                dgv[5, fila].Value = Facultad;

            

            }
    }
}
