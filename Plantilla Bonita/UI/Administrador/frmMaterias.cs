using Plantilla_Bonita.ClasesAuxiliares;
using Plantilla_Bonita.UI.FormasABC.Altas;
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
        private Usuario intern;

        public frmMaterias(Usuario usuario)
        {
            InitializeComponent();
            this.intern = usuario;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (AltaMateria obj = new AltaMateria(this.intern))
            {
                if (obj.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
