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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'materiasDataSet.Vista_Materias' Puede moverla o quitarla según sea necesario.
            this.vista_MateriasTableAdapter.Fill(this.materiasDataSet.Vista_Materias);
            // TODO: esta línea de código carga datos en la tabla 'ingenieriasDataSet.Ingenierias' Puede moverla o quitarla según sea necesario.
            this.ingenieriasTableAdapter.Fill(this.ingenieriasDataSet.Ingenierias);

        }

        private void descripcionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (descripcionComboBox.SelectedValue!=null)
                this.vista_MateriasTableAdapter.FillByIngenieria(this.materiasDataSet.Vista_Materias, descripcionComboBox.SelectedValue.ToString());
            else
                return;
        }
    }
}
