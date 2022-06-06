using Plantilla_Bonita.ClasesAuxiliares;
using Plantilla_Bonita.UI.FormasABC.Altas;
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
    public partial class frmAulas : Form
    {
        private bool IsAdding = false;
        private bool IsEditing = false;

        private Usuario intern;

        public frmAulas(Usuario usuario)
        {
            InitializeComponent();
            this.intern = usuario;
        }

        private void edificiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.edificiosBindingSource.EndEdit();
        }

        private void frmABCAulas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'edificiosDataSet.Edificios' Puede moverla o quitarla según sea necesario.
            this.edificiosTableAdapter.Fill(this.edificiosDataSet.Edificios);
            // TODO: esta línea de código carga datos en la tabla 'aulasDataSet.Aulas' Puede moverla o quitarla según sea necesario.
            this.aulasTableAdapter.Fill(this.aulasDataSet.Aulas);
            // TODO: esta línea de código carga datos en la tabla 'aulasDataSet.Aulas' Puede moverla o quitarla según sea necesario.
            this.aulasTableAdapter.Fill(this.aulasDataSet.Aulas);
            // TODO: esta línea de código carga datos en la tabla 'edificiosDataSet.Edificios' Puede moverla o quitarla según sea necesario.
            this.edificiosTableAdapter.Fill(this.edificiosDataSet.Edificios);

        }

        private void aulasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void aulasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aulasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aulasDataSet);
        }


        private void codigoEdificioComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (IsAdding)
                this.codEdificioTextBox.Text = codigoEdificioComboBox.Text;
            else if (IsEditing)
                this.codEdificioTextBox.Text = codigoEdificioComboBox.Text;

            this.aulasTableAdapter.FillByEdificio(this.aulasDataSet.Aulas, codigoEdificioComboBox.Text);
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            using (AltaAulas obj = new AltaAulas(this.intern))
            {
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    this.aulasTableAdapter.FillByEdificio(this.aulasDataSet.Aulas, codigoEdificioComboBox.Text);
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            IsAdding = false;
            IsEditing = false;
            aulasBindingNavigatorSaveItem.PerformClick();
        }
    }
}
