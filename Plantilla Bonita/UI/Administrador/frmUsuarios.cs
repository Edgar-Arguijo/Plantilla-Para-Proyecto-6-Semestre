using SGA_ITSL.UI.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_ITSL
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usuariosDataSet);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuariosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.usuariosDataSet.Usuarios);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuariosBindingNavigatorSaveItem.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
            usuariosBindingNavigatorSaveItem.PerformClick();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.usuariosDataSet.Usuarios);
        }

        private void usuariosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string usuario = usuariosDataGridView.SelectedCells[0].Value.ToString();
            string contra = usuariosDataGridView.SelectedCells[1].Value.ToString();
            int rol = rolComboBox.SelectedIndex;

            usuarioBC form = new usuarioBC(usuario, contra, rol);
            form.ShowDialog();
        }
    }
}
