using System;
using Primer_Parcial.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Primer_Parcial.BLL;

namespace Primer_Parcial.UI.Registros


{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }


        private GrupoEstudiantes LlenaClase()
        {
            GrupoEstudiantes Estudiante = new GrupoEstudiantes();

            Estudiante.GrupoID = Convert.ToInt32(IdNum.Value);
            Estudiante.Nombre = NombreBox.Text;
            Estudiante.Cantidad = Convert.ToInt32(CantidadBox.Text);

            Estudiante.Grupos = Convert.ToInt32(GrupoBox.Text);
            Estudiante.Integrantes = Convert.ToInt32(IntegranteBox.Text);
            Estudiante.Descripcion = DescripcionBox.Text;


            return Estudiante;
        }

        private void Limpiar()
        {
            IdNum.Value = 0;
            NombreBox.Text = string.Empty;
            CantidadBox.Text = " ";
            GrupoBox.Text = " ";
            IntegranteBox.Text = " ";
            DescripcionBox.Text = " ";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscrBoton_Click(object sender, EventArgs e)
        {

            int GrupoID = (int)IdNum.Value;
           GrupoEstudiantes estudiantes = BLL.GrupoEstudiantesBLL.Buscar(GrupoID);

            if (estudiantes != null)
            {
                NombreBox.Text = estudiantes.Nombre;
                IdNum.Value = estudiantes.GrupoID;
                CantidadBox.Text = estudiantes.Cantidad.ToString();
                GrupoBox.Text = estudiantes.Grupos.ToString();
                DescripcionBox.Text = estudiantes.Descripcion;
            }
            else
                MessageBox.Show("No se encontro!");
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NombreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrupoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantidadBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            GrupoEstudiantes estudiantes = LlenaClase();
            bool paso = false;

            if (IdNum.Value == 0)
                paso = BLL.GrupoEstudiantesBLL.Guardar(estudiantes);
            else
                paso = BLL.GrupoEstudiantesBLL.Modificar(LlenaClase());

            if (paso)
                MessageBox.Show("Guardado");
            else
                MessageBox.Show("No se pudo guardar!");
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
