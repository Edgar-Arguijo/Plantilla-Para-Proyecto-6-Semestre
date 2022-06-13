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
        public usuarioBC(string ususario, string contraseña, int combo)
        {
            InitializeComponent();

            this.txtNombre.Text = ususario;
            this.txtContraseña.Text = contraseña;
            this.rolComboBox.SelectedIndex = combo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
