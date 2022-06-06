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
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void bitacoraClasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bitacoraClasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bitacoraDataSet);

        }

        private void bitacoraClasesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bitacoraClasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bitacoraDataSet);

        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bitacoraDataSet.BitacoraClases' Puede moverla o quitarla según sea necesario.
            this.bitacoraClasesTableAdapter.Fill(this.bitacoraDataSet.BitacoraClases);

        }
    }
}
