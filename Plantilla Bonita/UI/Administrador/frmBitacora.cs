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
        Actuario_Tabla,
        Actuario_Tabla_Fecha
    }
    public partial class frmBitacora : Form
    {
        private Busqueda busqueda;

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
            if (actuarioComboBox.SelectedValue==null)
                return;
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

        private void tablaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (tablaComboBox.SelectedValue == null)
                return;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void LlenarTabla()
        {
            switch (busqueda)
            {
                case Busqueda.Actuario_Tabla:
                    this.bitacoraBaseDeDatos_VistaTableAdapter.FillByActuarioTabla(this.bitacoraDataSet.BitacoraBaseDeDatos_Vista, actuarioComboBox.SelectedValue.ToString(), tablaComboBox.SelectedValue.ToString());
                    break;
                case Busqueda.Actuario_Tabla_Fecha:
                    this.bitacoraBaseDeDatos_VistaTableAdapter.FillByFecha(this.bitacoraDataSet.BitacoraBaseDeDatos_Vista, actuarioComboBox.SelectedValue.ToString(), tablaComboBox.SelectedValue.ToString(), dtPckrInicio.Value, dtPckrFin.Value);
                    break;
                default:
                    this.bitacoraBaseDeDatos_VistaTableAdapter.Fill(this.bitacoraDataSet.BitacoraBaseDeDatos_Vista);
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte de Bitacora de la Base de Datos";
            printer.SubTitle = $"Periodo: {dtPckrInicio.Value.ToString("dd/MM/yyyy")} - {dtPckrFin.Value.ToString("dd/MM/yyyy")}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "SGA ITSL";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(bitacoraBaseDeDatos_VistaDataGridView);
            printer.ColumnWidths.Add("matricula", 50);
            printer.ColumnWidths.Add("nombre", 150);
            printer.ColumnWidths.Add("asistencias", 20);
        }
    }
}
