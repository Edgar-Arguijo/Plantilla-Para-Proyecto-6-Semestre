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

namespace Plantilla_Bonita
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private bool VerificarCampos() 
        {
            if (txtNomUsuario.Text == "" | txtContra.Text == "" | txtConfContra.Text == "")
            {
                MessageBox.Show("Las campos no pueden ir vacios");
                return false;
            }

            if (txtContra.Text != txtConfContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }

            return true;
        }

        private void Generar_Registro() 
        {
            try
            {
                ModeloDeUsuario obj = new ModeloDeUsuario();

                if (obj.AltaUsuario(txtNomUsuario.Text, Encriptado_Desencriptado.Encriptar(txtContra.Text)))
                    MessageBox.Show("El usuario fue dado de alta exitosamente");
                else 
                    MessageBox.Show("No se pudo registrar el usuario");
                
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
                Generar_Registro();
        }
    }
}
