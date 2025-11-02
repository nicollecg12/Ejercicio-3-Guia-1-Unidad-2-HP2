using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_Guia_1_Unidad_2_HP2
{
    public partial class FrmSistemaCursos : Form
    {
        public FrmSistemaCursos()
        {
            InitializeComponent();
            cboTipo.Items.Add("Virtual");
            cboTipo.Items.Add("Presencial");


        }
        public void ReiniciaForms()
        {
            cboTipo.SelectedIndex = -1;
            txtDuracionCurso.Clear();
            txtNombreCurso.Clear();
            txtNombreDocente.Clear();
            txtNumeroEstudiantes.Clear();
            txtPrecio.Clear();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            int cantEstudiantes = int.Parse(txtNumeroEstudiantes.Text);
            string tipo = cboTipo.Text;
            int numeroEstudiantes = int.Parse(txtNumeroEstudiantes.Text);
            string nombreCurso = txtNombreCurso.Text;
            double precio = double.Parse(txtPrecio.Text);
            string nombreDocente = txtNombreDocente.Text;
            int duracionCurso = int.Parse(txtDuracionCurso.Text);

            try
            {   //Factory --> Cursos newcurso = cursos.factory.crearcurso(parametros)
                Cursos nuevoCurso = CursosFactory.CrearCurso(tipo, numeroEstudiantes, nombreCurso, nombreDocente, duracionCurso, precio);
                //Singleton ---> GestorCursos.Instancia.Añadir();
                GestorCursos.Instancia.AñadirCurso(nuevoCurso);
                lstCursos.Items.Add(nuevoCurso);
                ReiniciaForms();
            }
            catch (Exception error)
            {

                MessageBox.Show("Error " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           lstCursos.Items.Clear();

            foreach (var curs in GestorCursos.Instancia.ObtenerCurso())
            {
                lstCursos.Items.Add($"Nombre: {curs.NombreCurso} Precio: {curs.CalcularPrecio()}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            GestorCursos.Instancia.Eliminar();
            lstCursos.Items.Clear();
        }
    }
}
