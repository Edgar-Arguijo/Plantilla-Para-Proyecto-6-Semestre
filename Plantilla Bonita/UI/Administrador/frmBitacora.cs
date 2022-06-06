using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Bonita.UI.Administrador
{
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tablaBitacoraDataSet.BitacoraBaseDeDatos' Puede moverla o quitarla según sea necesario.
            this.bitacoraBaseDeDatosTableAdapter1.FillBy(this.tablaBitacoraDataSet.BitacoraBaseDeDatos);
            // TODO: esta línea de código carga datos en la tabla 'actuarioDataSet.BitacoraBaseDeDatos' Puede moverla o quitarla según sea necesario.
            this.bitacoraBaseDeDatosTableAdapter.FillBy(this.actuarioDataSet.BitacoraBaseDeDatos);
            // TODO: esta línea de código carga datos en la tabla 'bitacoraDataSet.BitacoraBaseDeDatos_Vista' Puede moverla o quitarla según sea necesario.
            this.bitacoraBaseDeDatos_VistaTableAdapter.Fill(this.bitacoraDataSet.BitacoraBaseDeDatos_Vista);
        }

        private void actuarioComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
