namespace Plantilla_Bonita
{
    partial class frmPanelDeControl
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelDeControl));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pnlSubMenu1 = new System.Windows.Forms.Panel();
            this.pnlContenedorSubMenu1 = new System.Windows.Forms.Panel();
            this.btnAulas = new FontAwesome.Sharp.IconButton();
            this.btnMaterias = new FontAwesome.Sharp.IconButton();
            this.btnIngenierias = new FontAwesome.Sharp.IconButton();
            this.btnAdministrar = new FontAwesome.Sharp.IconButton();
            this.pnlContenedorControles = new System.Windows.Forms.Panel();
            this.btnAforo = new FontAwesome.Sharp.IconButton();
            this.btnAlumnos = new FontAwesome.Sharp.IconButton();
            this.btnAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnDocentes = new FontAwesome.Sharp.IconButton();
            this.btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnslider = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            this.pnlSubMenu1.SuspendLayout();
            this.pnlContenedorSubMenu1.SuspendLayout();
            this.pnlContenedorControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslider)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.MenuVertical.Controls.Add(this.pnlSubMenu1);
            this.MenuVertical.Controls.Add(this.pnlContenedorControles);
            this.MenuVertical.Controls.Add(this.btnCerrarSesion);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.MenuVertical, "MenuVertical");
            this.MenuVertical.Name = "MenuVertical";
            // 
            // pnlSubMenu1
            // 
            resources.ApplyResources(this.pnlSubMenu1, "pnlSubMenu1");
            this.pnlSubMenu1.Controls.Add(this.pnlContenedorSubMenu1);
            this.pnlSubMenu1.Controls.Add(this.btnAdministrar);
            this.pnlSubMenu1.Name = "pnlSubMenu1";
            // 
            // pnlContenedorSubMenu1
            // 
            resources.ApplyResources(this.pnlContenedorSubMenu1, "pnlContenedorSubMenu1");
            this.pnlContenedorSubMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.pnlContenedorSubMenu1.Controls.Add(this.btnAulas);
            this.pnlContenedorSubMenu1.Controls.Add(this.btnMaterias);
            this.pnlContenedorSubMenu1.Controls.Add(this.btnIngenierias);
            this.pnlContenedorSubMenu1.Name = "pnlContenedorSubMenu1";
            // 
            // btnAulas
            // 
            resources.ApplyResources(this.btnAulas, "btnAulas");
            this.btnAulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAulas.FlatAppearance.BorderSize = 0;
            this.btnAulas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAulas.ForeColor = System.Drawing.Color.White;
            this.btnAulas.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnAulas.IconColor = System.Drawing.Color.White;
            this.btnAulas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAulas.IconSize = 32;
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.UseVisualStyleBackColor = false;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // btnMaterias
            // 
            resources.ApplyResources(this.btnMaterias, "btnMaterias");
            this.btnMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnMaterias.ForeColor = System.Drawing.Color.White;
            this.btnMaterias.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnMaterias.IconColor = System.Drawing.Color.White;
            this.btnMaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaterias.IconSize = 32;
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.UseVisualStyleBackColor = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnIngenierias
            // 
            resources.ApplyResources(this.btnIngenierias, "btnIngenierias");
            this.btnIngenierias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnIngenierias.FlatAppearance.BorderSize = 0;
            this.btnIngenierias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnIngenierias.ForeColor = System.Drawing.Color.White;
            this.btnIngenierias.IconChar = FontAwesome.Sharp.IconChar.HardHat;
            this.btnIngenierias.IconColor = System.Drawing.Color.White;
            this.btnIngenierias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngenierias.IconSize = 32;
            this.btnIngenierias.Name = "btnIngenierias";
            this.btnIngenierias.UseVisualStyleBackColor = false;
            this.btnIngenierias.Click += new System.EventHandler(this.btnIngenierias_Click);
            // 
            // btnAdministrar
            // 
            resources.ApplyResources(this.btnAdministrar, "btnAdministrar");
            this.btnAdministrar.FlatAppearance.BorderSize = 0;
            this.btnAdministrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAdministrar.ForeColor = System.Drawing.Color.White;
            this.btnAdministrar.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnAdministrar.IconColor = System.Drawing.Color.White;
            this.btnAdministrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdministrar.IconSize = 32;
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // pnlContenedorControles
            // 
            resources.ApplyResources(this.pnlContenedorControles, "pnlContenedorControles");
            this.pnlContenedorControles.Controls.Add(this.btnAforo);
            this.pnlContenedorControles.Controls.Add(this.btnAlumnos);
            this.pnlContenedorControles.Controls.Add(this.btnAsistencia);
            this.pnlContenedorControles.Controls.Add(this.btnDocentes);
            this.pnlContenedorControles.Controls.Add(this.btnIniciarSesion);
            this.pnlContenedorControles.Name = "pnlContenedorControles";
            // 
            // btnAforo
            // 
            resources.ApplyResources(this.btnAforo, "btnAforo");
            this.btnAforo.FlatAppearance.BorderSize = 0;
            this.btnAforo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAforo.ForeColor = System.Drawing.Color.White;
            this.btnAforo.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnAforo.IconColor = System.Drawing.Color.White;
            this.btnAforo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAforo.IconSize = 32;
            this.btnAforo.Name = "btnAforo";
            this.btnAforo.UseVisualStyleBackColor = true;
            this.btnAforo.Click += new System.EventHandler(this.btnAforo_Click);
            // 
            // btnAlumnos
            // 
            resources.ApplyResources(this.btnAlumnos, "btnAlumnos");
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnAlumnos.IconColor = System.Drawing.Color.White;
            this.btnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlumnos.IconSize = 30;
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click_1);
            // 
            // btnAsistencia
            // 
            resources.ApplyResources(this.btnAsistencia, "btnAsistencia");
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnAsistencia.IconColor = System.Drawing.Color.White;
            this.btnAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsistencia.IconSize = 30;
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnDocentes
            // 
            resources.ApplyResources(this.btnDocentes, "btnDocentes");
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnDocentes.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnDocentes.IconColor = System.Drawing.Color.White;
            this.btnDocentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocentes.IconSize = 32;
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnIniciarSesion
            // 
            resources.ApplyResources(this.btnIniciarSesion, "btnIniciarSesion");
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnIniciarSesion.IconColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesion.IconSize = 30;
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCerrarSesion
            // 
            resources.ApplyResources(this.btnCerrarSesion, "btnCerrarSesion");
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 30;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Plantilla_Bonita.Properties.Resources.Imagen8;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnSalir);
            this.BarraTitulo.Controls.Add(this.btnslider);
            resources.ApplyResources(this.BarraTitulo, "BarraTitulo");
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            resources.ApplyResources(this.btnRestaurar, "btnRestaurar");
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Plantilla_Bonita.Properties.Resources.Imagen5;
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Plantilla_Bonita.Properties.Resources.Imagen4;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            resources.ApplyResources(this.btnMaximizar, "btnMaximizar");
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Plantilla_Bonita.Properties.Resources.Imagen2;
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Plantilla_Bonita.Properties.Resources.Imagen3;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnslider
            // 
            this.btnslider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslider.Image = global::Plantilla_Bonita.Properties.Resources.Imagen6;
            resources.ApplyResources(this.btnslider, "btnslider");
            this.btnslider.Name = "btnslider";
            this.btnslider.TabStop = false;
            this.btnslider.Click += new System.EventHandler(this.btnslider_Click);
            // 
            // pnlContenedor
            // 
            resources.ApplyResources(this.pnlContenedor, "pnlContenedor");
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Name = "pnlContenedor";
            // 
            // frmPanelDeControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPanelDeControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.pnlSubMenu1.ResumeLayout(false);
            this.pnlSubMenu1.PerformLayout();
            this.pnlContenedorSubMenu1.ResumeLayout(false);
            this.pnlContenedorSubMenu1.PerformLayout();
            this.pnlContenedorControles.ResumeLayout(false);
            this.pnlContenedorControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnslider;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private FontAwesome.Sharp.IconButton btnAsistencia;
        private FontAwesome.Sharp.IconButton btnAlumnos;
        private FontAwesome.Sharp.IconButton btnDocentes;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Panel pnlSubMenu1;
        private System.Windows.Forms.Panel pnlContenedorSubMenu1;
        private FontAwesome.Sharp.IconButton btnIngenierias;
        private FontAwesome.Sharp.IconButton btnAdministrar;
        private FontAwesome.Sharp.IconButton btnAulas;
        private FontAwesome.Sharp.IconButton btnMaterias;
        private System.Windows.Forms.Panel pnlContenedorControles;
        private FontAwesome.Sharp.IconButton btnAforo;
    }
}

