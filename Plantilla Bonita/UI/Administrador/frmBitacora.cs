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
    enum Busqueda
    {
        Ninguno,
        Acturaio,
        Tabla,
        Actuario_Tabla,
        Actuario_Tabla_Fecha
    }
    public partial class frmBitacora : Form
    {
        private Busqueda busqueda = Busqueda.Ninguno;

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
            if (actuarioComboBox.SelectedValue == null)
            {
                MessageBox.Show("");
            }
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.CheckState == CheckState.Unchecked)
            {
                this.busqueda = Busqueda.Actuario_Tabla;
                dtPckrInicio.Enabled = false;
                dtPckrFin.Enabled = false;
            }
            else if (chkFecha.CheckState == CheckState.Checked) 
            {
                this.busqueda = Busqueda.Actuario_Tabla_Fecha;
                dtPckrInicio.Enabled = true;
                dtPckrFin.Enabled = true;
            }
        }
    }
}
