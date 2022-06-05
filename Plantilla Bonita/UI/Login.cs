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
using System.Runtime.InteropServices;

namespace Plantilla_Bonita
{
    public partial class Login : Form
    {
        //Mover Forma
        //Libreia de using System.Runtime.InteropServices;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private TipoUsuario.NivelAutorizacion result;
        public TipoUsuario.NivelAutorizacion Result=> result;

        public Usuario generated;

        public Login()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text!="" & txtContraseña.Text!="")
                {
                    ModeloDeUsuario obj = new ModeloDeUsuario();
                    this.result = TipoUsuario.ObtenerNivel(obj.Loggeo(txtUsuario.Text,  txtContraseña.Text));
                    this.DialogResult = DialogResult.OK;
                    this.generated = new Usuario(txtUsuario.Text);
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

        private void pnlEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMostrarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void btnMostrarContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            this.result = TipoUsuario.NivelAutorizacion.Invitado;
            this.DialogResult = DialogResult.OK;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            this.result = TipoUsuario.NivelAutorizacion.PersonalAdministrativo;
            this.DialogResult = DialogResult.OK;
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            this.result = TipoUsuario.NivelAutorizacion.Docente;
            this.DialogResult = DialogResult.OK;
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
