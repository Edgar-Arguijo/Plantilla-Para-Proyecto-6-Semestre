using Dominio;
using SGA_ITSL.ClasesAuxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_ITSL
{
    public partial class frmRegistro : Form
    {
        //Mover Forma
        //Libreia de using System.Runtime.InteropServices;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frmRegistro()
        {
            InitializeComponent();
            txtConfContra.UseSystemPasswordChar = true;
            txtContra.UseSystemPasswordChar = true;
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

                if (obj.AltaUsuario(txtNomUsuario.Text, txtContra.Text))
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

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
                Generar_Registro();
        }

        private void pblEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
