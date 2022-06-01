using System;
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

    enum Filtros
    {
        Edificio_Aula,
        Edificio_Aula_Fecha
    }


    public partial class frmAforos : Form
    {

        private Filtros filtros = Filtros.Edificio_Aula;

        public frmAforos()
        {
            InitializeComponent();
        }

        private void RellenarTable() {
                
        }

        private void frmAforos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aforosDataSet.Vista_AforosGeneral' Puede moverla o quitarla según sea necesario.
            this.vista_AforosGeneralTableAdapter.Fill(this.aforosDataSet.Vista_AforosGeneral);
            // TODO: esta línea de código carga datos en la tabla 'edificiosDataSet.Vista_Edificios' Puede moverla o quitarla según sea necesario.
            this.vista_EdificiosTableAdapter.Fill(this.edificiosDataSet.Vista_Edificios);
            // TODO: esta línea de código carga datos en la tabla 'edificiosDataSet.Vista_Edificios' Puede moverla o quitarla según sea necesario.
            this.vista_EdificiosTableAdapter.Fill(this.edificiosDataSet.Vista_Edificios);
        }

        private void aulasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.aulasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aulasDataSet);

        }

        private void codigoEdificioComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.aulasTableAdapter.FillByEdificio(this.aulasDataSet.Aulas, codigoEdificioComboBox.Text);
        }

        private void chkBxFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxFecha.CheckState == CheckState.Checked)
            {
                dtPck_Fin.Enabled = true;
                dtPck_Inicio.Enabled = true;
                this.filtros = Filtros.Edificio_Aula_Fecha;
            }
            else { 
                dtPck_Fin.Enabled = false;
                dtPck_Inicio.Enabled = false;
                this.filtros = Filtros.Edificio_Aula;
            }
        }
    }
}
