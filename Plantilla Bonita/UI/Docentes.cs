using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_ITSL
{
    public partial class Docentes : Form
    {
        public Docentes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'docentesDataSet.Vista_Docentes' Puede moverla o quitarla según sea necesario.
            this.vista_DocentesTableAdapter.Fill(this.docentesDataSet.Vista_Docentes);

        }
    }
}
