using System;
using System.IO;
using Microsoft.SqlServer.Management.Smo;
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
    public partial class frmCopiaSeguridad : Form
    {
        public frmCopiaSeguridad()
        {
            InitializeComponent();
        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    lnkCarpeta.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnCrearCopia_Click(object sender, EventArgs e)
        {
            try
            {
                Server sqlServer = new Server(txtNombreServidor.Text);

                foreach (Database db in sqlServer.Databases)
                {
                    if (db.Name == txtNombreBaseDeDatos.Text)
                    {
                        Backup bk = new Backup();
                        bk.Devices.AddDevice(lnkCarpeta.Text, DeviceType.File);
                        bk.Devices.AddDevice(lnkCarpeta.Text, DeviceType.File);
                        bk.Action = BackupActionType.Database;
                        bk.BackupSetDescription = "Copia de Seguridad de la Base de Datos " + db.Name;
                        bk.Database = db.Name;
                        bk.Initialize = true;
                        bk.SqlBackup(sqlServer);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
