using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_ITSL.UI.Administrador
{
    public partial class usuarioBC : Form
    {
        private Usuario local;

        internal class Usuario 
        {
            private string nombre;
            private string contra;
            public string rol;

            public string Nombre { get => nombre; }
            public string Contra { get => contra; }

            public Usuario(string nom, string con) 
            {
                this.contra = con;
                this.nombre = nom;
            }

            public void SetRol(string rol) 
            {
                this.rol = rol;
            }

            public string convertirContra() 
            {
                return Encriptado_Desencriptado.Encriptado_Desencriptado.Desencriptar(this.contra);
            }

        }

        public usuarioBC(string ususario, string contraseña, int combo)
        {
            InitializeComponent();
            this.rolComboBox.SelectedIndex = combo;
            local = new Usuario(ususario, contraseña);
            this.txtNombre.Text = local.Nombre;
            this.txtContraseña.Text = local.Contra;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuarioBC_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            local.SetRol(this.rolComboBox.Text);
        }

        private void btnMostrarContra_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.Text = local.convertirContra();
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void btnMostrarContra_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseña.Text = local.Contra;
            txtContraseña.UseSystemPasswordChar = true;
        }
    }
}
