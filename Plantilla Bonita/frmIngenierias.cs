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
    public partial class frmIngenierias : Form
    {
        private bool isNew = false;

        public frmIngenierias()
        {
            InitializeComponent();
        }

        private void frmIngenierias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aBC_IngenieriasDataSet.Ingenierias' Puede moverla o quitarla según sea necesario.
            this.ingenieriasTableAdapter.Fill(this.aBC_IngenieriasDataSet.Ingenierias);

        }

        private void ingenieriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingenieriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_IngenieriasDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingenieriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_IngenieriasDataSet);
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            this.ingenieriasTableAdapter.Fill(this.aBC_IngenieriasDataSet.Ingenierias);
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
            cod_IngTextBox.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
            //guardar cambios
            this.Validate();
            this.ingenieriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_IngenieriasDataSet);
        }
    }
}
