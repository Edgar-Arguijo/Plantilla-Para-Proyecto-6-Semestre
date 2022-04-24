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
        enum Filtros
        {
            Carrera,
            CarreraYBusqueda
        }

        private Filtros filtros = Filtros.Carrera;

        public Alumnos()
        {
            InitializeComponent();
            ingenieriasComboBox.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Filtros ComprobarCampos() {
            if (txtNombreBusqueda.Text != "")
                return Filtros.CarreraYBusqueda;
            else
                return Filtros.Carrera;
        }

        private void RellenarTabla() {
            ModeloDeUsuario obj = new ModeloDeUsuario();
            string carr = obj.BuscarCodIngenieria(ingenieriasComboBox.Text);

            switch (ComprobarCampos())
            {
                case Filtros.Carrera:
                    this.vista_AlumnosTableAdapter.FillByCodIngenieria(this.alumnosDataSet.Vista_Alumnos, $"{carr}");
                    break;

                case Filtros.CarreraYBusqueda:
                    this.vista_AlumnosTableAdapter.SearchByNameAndCareer(this.alumnosDataSet.Vista_Alumnos, $"{txtNombreBusqueda.Text}", $"{carr}");
                    break;

                default:
                    this.vista_AlumnosTableAdapter.FillByCodIngenieria(this.alumnosDataSet.Vista_Alumnos, $"{carr}");
                    break;
            }
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
            RellenarTabla();
        }

        private void txtNombreBusqueda_TextChanged(object sender, EventArgs e)
        {
            RellenarTabla();
        }
    }
}
