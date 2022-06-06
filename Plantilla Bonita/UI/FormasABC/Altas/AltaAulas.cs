using Dominio;
using Plantilla_Bonita.ClasesAuxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Bonita.UI.FormasABC.Altas
{
    public partial class AltaAulas : Form
    {
        private Usuario intern;

        public AltaAulas(Usuario usuario)
        {
            InitializeComponent();
            this.intern = usuario;
        }

        private void edificiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.edificiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edificiosDataSet);

        }

        private void AltaAulas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'edificiosDataSet.Edificios' Puede moverla o quitarla según sea necesario.
            this.edificiosTableAdapter.Fill(this.edificiosDataSet.Edificios);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                ModeloDeUsuario obj = new ModeloDeUsuario();

                if (obj.AltaAula(intern.Nombre, codigoEdificioComboBox.SelectedValue.ToString(),txtCodigo.Text,txtDescripcion.Text))
                {
                    MessageBox.Show("El registro se ha generado correctamente", "Alta realizada exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("El registro no se ha realizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }

                this.Close();
            }
        }

        private bool Verificar()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("El Codigo no puede ir vacio");
                return false;
            }

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("La Descripcion de la materia no puede ir vacia");
                return false;
            }
            
            if (codigoEdificioComboBox.SelectedValue == null)
            {
                MessageBox.Show("Porfavor seleccione un edificio");
                return false;
            }

            return true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
