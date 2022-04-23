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

        private void Asistencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'materiasDataSet.Vista_IngenieriasMateria' Puede moverla o quitarla según sea necesario.
            //this.vista_IngenieriasMateriaTableAdapter.Fill(this.materiasDataSet.Vista_IngenieriasMateria);



            // TODO: esta línea de código carga datos en la tabla 'ingenieriasDataSet.Ingenierias' Puede moverla o quitarla según sea necesario.
            this.ingenieriasTableAdapter.Fill(this.ingenieriasDataSet.Ingenierias);
            //cboSemestre.Items.Clear();
        }

        private void fillByIngenieriaToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.vista_IngenieriasMateriaTableAdapter.FillByIngenieria(this.materiasDataSet.Vista_IngenieriasMateria, descripcionComboBox.Text, cboSemestre.SelectedIndex+1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

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
    }
}
