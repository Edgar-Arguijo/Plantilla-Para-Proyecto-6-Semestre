using System;
using System.IO;
using Microsoft.SqlServer.Management.Smo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Acceso_A_Datos;
using System.Drawing;
using System.Linq;
using System.Text;
using Dominio;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Plantilla_Bonita.ClasesAuxiliares;

namespace Plantilla_Bonita
{
    public partial class frmPanelDeControl : Form
    {
        private ConnectionProtection _operaciones = new ConnectionProtection(Application.ExecutablePath);
        private TipoUsuario.NivelAutorizacion permisos = TipoUsuario.NivelAutorizacion.Invitado;
            
        private void Encriptar() {
            if (!_operaciones.IsProtected()){
                _operaciones.EncryptFile();
            }
        }

        public frmPanelDeControl()
        {
            InitializeComponent();
            ActualizarControles(this.permisos);
            Encriptar();
            ModeloDeUsuario obj = new ModeloDeUsuario();
            obj.ProbarConexion();
        }
        //Mover Forma
        //Libreia de using System.Runtime.InteropServices;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL",EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int lparam);

        private void btnslider_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width==180)
            {
                btnIniciarSesion.Text = "";
                btnAsistencia.Text = "";
                btnAlumnos.Text = "";
                btnDocentes.Text = "";
                btnCerrarSesion.Text = "";
                btnAdministrar.Text = "";
                btnAforo.Text = "";

                pnlContenedorSubMenu1.Visible = false;

                MenuVertical.Width = 54;
            }
            else
            {
                btnIniciarSesion.Text = Properties.Resources.Iniciar_Sesion;
                btnAsistencia.Text = Properties.Resources.Asistencia;
                btnAlumnos.Text = Properties.Resources.Alumnos;
                btnDocentes.Text = Properties.Resources.Docentes;
                btnCerrarSesion.Text = Properties.Resources.Cerrar_Sesion;
                btnAdministrar.Text = Properties.Resources.Administrar;
                btnAforo.Text = Properties.Resources.Aforo;

                MenuVertical.Width = 180;
            }
        }

        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO
        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1120, 558);
            this.Location = new Point(LX, LY);
            
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "¡Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
        private void Abrirformaenelpanel(object FormHijo)
        {
            try
            {
                if (this.pnlContenedor.Controls.Count > 0)
                    this.pnlContenedor.Controls.RemoveAt(0);

                Form fh = FormHijo as Form;
                fh.TopLevel = false;
                this.pnlContenedor.Controls.Add(fh);
                this.pnlContenedor.Tag = fh;
                fh.Dock = DockStyle.Fill;
                fh.Show();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION 
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnlContenedor.Region = region;
            this.Invalidate();
        }
        //COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 0, 1));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Brown, sizeGripRectangle);
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        private void MostrarFormLogo()
        {
            Abrirformaenelpanel(new FormLogo());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos fm = new Alumnos();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            Asistencias fm = new Asistencias();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void btnAlumnos_Click_1(object sender, EventArgs e)
        {
            Alumnos fm = new Alumnos();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            Docentes fm = new Docentes();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            using (Login fm = new Login())
            {
                fm.ShowDialog();

                if (fm.DialogResult == DialogResult.OK)
                {
                    this.permisos = fm.Result;
                    fm.Close();
                }
            }

            ActualizarControles(this.permisos);
        }

        private void ActualizarControles(TipoUsuario.NivelAutorizacion permisos)
        {
            switch (permisos)
            {
                case TipoUsuario.NivelAutorizacion.Administrador:
                    ConfigurarN_Admin();
                    break;
                case TipoUsuario.NivelAutorizacion.PersonalAdministrativo:
                    ConfigurarN_Personal();
                    break;
                case TipoUsuario.NivelAutorizacion.Docente:
                    ConfigurarN_Docente();
                    break;

                case TipoUsuario.NivelAutorizacion.Invitado:
                    ConfigurarN_Invitado();
                    break;
                
                default:
                    ConfigurarN_Invitado();
                    break;
            }
        }

        private void ConfigurarN_Invitado()
        {
            pnlContenedorControles.Visible = true;
            pnlSubMenu1.Visible = false;

            btnAdministrar.Visible = false;
            btnMaterias.Visible = false;
            btnAulas.Visible = false;
            btnAforo.Visible = false;
            btnAsistencia.Visible = false;
            btnIniciarSesion.Visible = true;
            btnAlumnos.Visible = false;
            btnDocentes.Visible = false;
            pnlSubMenu1.Visible = false;
        }

        private void ConfigurarN_Docente()
        {
            pnlContenedorControles.Visible = true;
            pnlSubMenu1.Visible = false;

            btnAdministrar.Visible = false;
            btnMaterias.Visible = false;
            btnAulas.Visible = false;
            btnAforo.Visible = false;
            btnAsistencia.Visible = true;
            btnAlumnos.Visible = true;
            btnDocentes.Visible = false;
            pnlSubMenu1.Visible = false;

            btnIniciarSesion.Visible = false;
            btnCerrarSesion.Visible = true;
        }

        private void ConfigurarN_Personal()
        {
            pnlContenedorControles.Visible = true;
            pnlSubMenu1.Visible = false;

            btnAdministrar.Visible = false;
            btnMaterias.Visible = false;
            btnAulas.Visible = false;
            btnAforo.Visible = true;
            btnAsistencia.Visible = false;
            btnAlumnos.Visible = false;
            btnDocentes.Visible = false;
            pnlSubMenu1.Visible = false;

            btnIniciarSesion.Visible = false;
            btnCerrarSesion.Visible = true;
        }

        private void ConfigurarN_Admin()
        {
            pnlContenedorControles.Visible = true;
            pnlSubMenu1.Visible = true;

            btnAdministrar.Visible = true;
            btnMaterias.Visible = true;
            btnAulas.Visible = true;   
            btnAforo.Visible = true;
            btnAsistencia.Visible = true;
            btnAlumnos.Visible = true;
            btnDocentes.Visible = true;
            pnlSubMenu1.Visible = true;

            btnIniciarSesion.Visible = false;
            btnCerrarSesion.Visible = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            btnIniciarSesion.Visible = true;
            btnCerrarSesion.Visible = false;
            this.permisos = TipoUsuario.NivelAutorizacion.Invitado;
            ActualizarControles(this.permisos);
            MostrarFormLogo();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            if (pnlContenedorSubMenu1.Visible == false)
            {
                pnlContenedorSubMenu1.Visible = true;
            }
            else
            {
                pnlContenedorSubMenu1.Visible = false;
            }
        }

        private void btnIngenierias_Click(object sender, EventArgs e)
        {
            frmIngenierias fm = new frmIngenierias();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            frmMaterias fm = new frmMaterias();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void btnAforo_Click(object sender, EventArgs e)
        {
            frmAforos fm = new frmAforos();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            frmABCAulas fm = new frmABCAulas();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios fm = new frmUsuarios();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void btnCopiaSeguridad_Click(object sender, EventArgs e)
        {
            //Para realizar la copia de seguridad

            ModeloDeUsuario obj = new ModeloDeUsuario();

            if (obj.CopiaDeSeguridad())
            {
                MessageBox.Show("Se ha realizado la copia de seguridad exitosamente");
            }
            else
            {
                MessageBox.Show("No se ha podido realizar la copia de seguridad");
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            frmBitacora fm = new frmBitacora();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            Abrirformaenelpanel(fm);
        }

        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

    }
}
