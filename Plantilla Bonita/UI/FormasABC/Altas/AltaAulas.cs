using Plantilla_Bonita.ClasesAuxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Bonita.UI.FormasABC.Altas
{
    public partial class AltaAulas : Form
    {
        private Usuario inter;

        public AltaAulas(Usuario usuario)
        {
            InitializeComponent();
            this.inter = usuario;
        }

        private void edificiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.edificiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edificiosDataSet);

        }

        private void AltaAulas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'edificiosDataSet.Edificios' Puede moverla o quitarla según sea necesario.
            this.edificiosTableAdapter.Fill(this.edificiosDataSet.Edificios);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
