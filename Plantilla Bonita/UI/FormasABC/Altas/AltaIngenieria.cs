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
    public partial class AltaIngenieria : Form
    {
        private Usuario intern;

        public AltaIngenieria(Usuario usuario)
        {
            this.intern = usuario;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                ModeloDeUsuario obj = new ModeloDeUsuario();

                if (obj.AltaIngenieria(intern.Nombre, txtCodigo.Text, txtNombre.Text))
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

            if (txtNombre.Text == "")
            {
                MessageBox.Show("El Nombre de la Ingenieria no puede ir vacio");
                return false;
            }

            return true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
