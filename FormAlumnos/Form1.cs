using FormAlumnos.BDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Model1 bd = new Model1();
            combocurso.DataSource = bd.Cursos.ToList();
            combocurso.DisplayMember = "Nombre";


        }

        private void combocurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model1 bd = new Model1();

            Curso cursoSeleccionado = (Curso)combocurso.SelectedItem;
            List<Alumno> alumnosCurso = bd.Alumnos.Where
                (Alumno => Alumno.idcurso == cursoSeleccionado.idcurso).ToList();
            Grid1.DataSource = alumnosCurso;

            Grid1.Columns[0].Visible = false;
            Grid1.Columns[3].Visible = false;
            Grid1.Columns[4].Visible = false;

            txtprofesor.Text = cursoSeleccionado.Profesore.nombre;

        }
    }

}