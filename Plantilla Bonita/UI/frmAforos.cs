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
    enum Filtro
    {
        Edificio_Aula,
        Edificio_Aula_Fecha
    }

    public partial class frmAforos : Form
    {
        private Filtro filtro = Filtro.Edificio_Aula_Fecha;

        public frmAforos()
        {
            InitializeComponent();
        }

        private void edificiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.edificiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edificiosDataSet);

        }

        private void frmAforos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aforosDataSet.Vista_AforosGeneral' Puede moverla o quitarla según sea necesario.
            this.vista_AforosGeneralTableAdapter.Fill(this.aforosDataSet.Vista_AforosGeneral);
            // TODO: esta línea de código carga datos en la tabla 'edificiosDataSet.Edificios' Puede moverla o quitarla según sea necesario.
            this.edificiosTableAdapter.Fill(this.edificiosDataSet.Edificios);
        }

        private void codigoEdificioComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.aulasTableAdapter.FillByEdificio(this.aulasDataSet.Aulas, codigoEdificioComboBox.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LlenarTabla() {

            switch (this.filtro)
            {
                case Filtro.Edificio_Aula:
                    this.vista_AforosGeneralTableAdapter.FillByEdificioAula(this.aforosDataSet.Vista_AforosGeneral, codigoEdificioComboBox.Text, codigoAulaComboBox.Text);
                    break;

                case Filtro.Edificio_Aula_Fecha:

                    DateTime inicio = dtTPckInicio.Value.Date;
                    DateTime fin = dtTPckFin.Value.Date;
                    string prim = inicio.ToString();
                    string seg = fin.ToString();
                    this.vista_AforosGeneralTableAdapter.FillByEdificioAulaFecha(this.aforosDataSet.Vista_AforosGeneral, codigoEdificioComboBox.Text, codigoAulaComboBox.Text, inicio, fin);                    break;

                default:
                    this.vista_AforosGeneralTableAdapter.Fill(this.aforosDataSet.Vista_AforosGeneral);
                    break;
            }

        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.CheckState==CheckState.Checked)
            {
                this.filtro = Filtro.Edificio_Aula_Fecha;
                dtTPckFin.Enabled = true;
                dtTPckInicio.Enabled = true;
            }
            else
            {
                this.filtro = Filtro.Edificio_Aula;
                dtTPckFin.Enabled = false;
                dtTPckInicio.Enabled = false;
            }

            LlenarTabla();
        }

        private void dtTPckFin_ValueChanged(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void dtTPckInicio_ValueChanged(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = dtTPckInicio.Value.Date.ToString();
            this.label2.Text = dtTPckFin.Value.Date.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte de Aforos";
            printer.SubTitle = $"Periodo: {dtTPckInicio.Value.ToString("dd/MM/yyyy")} - {dtTPckFin.Value.ToString("dd/MM/yyyy")}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "SGA ITSL";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(vista_AforosGeneralDataGridView);
            printer.ColumnWidths.Add("matricula", 50);
            printer.ColumnWidths.Add("nombre", 150);
            printer.ColumnWidths.Add("asistencias", 20);
        }
    }
}
