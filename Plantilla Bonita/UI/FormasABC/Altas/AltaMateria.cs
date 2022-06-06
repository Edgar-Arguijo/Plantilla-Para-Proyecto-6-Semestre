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
    public partial class AltaMateria : Form
    {
        private Usuario intern;

        public AltaMateria(Usuario usuario)
        {
            InitializeComponent();
            this.intern = usuario;
        }

        private void AltaMateria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ingenieriasDataSet.Ingenierias' Puede moverla o quitarla según sea necesario.
            this.ingenieriasTableAdapter.Fill(this.ingenieriasDataSet.Ingenierias);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                ModeloDeUsuario obj = new ModeloDeUsuario();

                if (obj.AltaMateria(descripcionComboBox.SelectedValue.ToString(),txtCodigo.Text, txtDescripcion.Text,Convert.ToInt16(numSemestre.Value),intern.Nombre))
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
            if (txtCodigo.Text==null)
            {
                return false;
            }
            if (txtDescripcion.Text == null)
            {
                return false;
            }
            if (descripcionComboBox.SelectedValue==null)
            {
                return false;
            }

            return true;

        }
    }
}
