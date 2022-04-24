using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plantilla_Bonita.ClasesAuxiliares;
using Dominio;
using System.Windows.Forms;

namespace Plantilla_Bonita
{
    public partial class Login : Form
    {
        private TipoUsuario.NivelAutorizacion result;
        public TipoUsuario.NivelAutorizacion Result=> result;

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text!="" & txtContraseña.Text!="")
                {
                    ModeloDeUsuario obj = new ModeloDeUsuario();
                    this.result = TipoUsuario.ObtenerNivel(obj.Loggeo(txtUsuario.Text, txtContraseña.Text));
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.result = TipoUsuario.NivelAutorizacion.Administrador;
            this.DialogResult = DialogResult.OK;
        }
    }
}
