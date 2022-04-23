using System;
using Dominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Bonita
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingenieriasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ingenieriasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void panelAlumnos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alumnosDataSet.Vista_Alumnos' Puede moverla o quitarla según sea necesario.
            this.vista_AlumnosTableAdapter.Fill(this.alumnosDataSet.Vista_Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'ingenieriasDataSet.Ingenierias' Puede moverla o quitarla según sea necesario.
            this.ingenieriasTableAdapter.Fill(this.ingenieriasDataSet.Ingenierias);
            // TODO: esta línea de código carga datos en la tabla 'ingenieriasDataSet.Ingenierias' Puede moverla o quitarla según sea necesario.
            this.ingenieriasTableAdapter.Fill(this.ingenieriasDataSet.Ingenierias);
        }

        private void ingenieriasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModeloDeUsuario obj = new ModeloDeUsuario();
            this.vista_AlumnosTableAdapter.FillByCodIngenieria(this.alumnosDataSet.Vista_Alumnos, $"{obj.BuscarCodIngenieria(ingenieriasComboBox.Text)}");
        }

        private void txtNombreBusqueda_TextChanged(object sender, EventArgs e)
        {
            ModeloDeUsuario obj = new ModeloDeUsuario();
            this.vista_AlumnosTableAdapter.SearchByName(this.alumnosDataSet.Vista_Alumnos, $"{txtNombreBusqueda.Text}");
        }
    }
}
