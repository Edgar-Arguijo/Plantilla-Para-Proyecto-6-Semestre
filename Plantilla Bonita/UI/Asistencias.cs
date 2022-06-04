using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Dominio;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Bonita
{
    public partial class Asistencias : Form
    {
        public Asistencias()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSemestre_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.vista_IngenieriasMateriaTableAdapter.FillByIngenieria(this.materiasDataSet.Vista_IngenieriasMateria, descripcionComboBox.Text, cboSemestre.SelectedIndex + 1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDeUsuario obj = new ModeloDeUsuario();
                string codIng = obj.BuscarCodIngenieria(descripcionComboBox.Text);
                string codMateria = obj.BuscarCodMateria(codIng, materiaComboBox.Text);

                DateTime inicio = DateTime.Parse($"{dtPickerInicio.Value.Year}-{dtPickerInicio.Value.Month}-{dtPickerInicio.Value.Day} 00:00:00");
                DateTime fin = DateTime.Parse($"{dtPickerFin.Value.Year}-{dtPickerFin.Value.Month}-{dtPickerFin.Value.Day} 11:59:59");

                int? cant = 3;
                this.listaAsistenciasTableAdapter.SearchByAllFilters(this.asistenciasDataSet.ListaAsistencias, codMateria, codIng, inicio, fin, ref cant);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Asistencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ingenieriasDataSet.Ingenierias' Puede moverla o quitarla según sea necesario.
            this.ingenieriasTableAdapter.Fill(this.ingenieriasDataSet.Ingenierias);
        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte de Asistencias";
            printer.SubTitle = $"Periodo: {dtPickerInicio.Value.ToString("dd/MM/yyyy")} - {dtPickerFin.Value.ToString("dd/MM/yyyy")}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "SGA ITSL";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(listaAsistenciasDataGridView);
            printer.ColumnWidths.Add("matricula", 50);
            printer.ColumnWidths.Add("nombre", 150);
            printer.ColumnWidths.Add("asistencias", 20);
        }
    }
}
