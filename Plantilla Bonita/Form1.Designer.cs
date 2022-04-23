namespace Plantilla_Bonita
{
    partial class Form1
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
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnslider = new System.Windows.Forms.PictureBox();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.MenuVertical.Controls.Add(this.btnDocentes);
            this.MenuVertical.Controls.Add(this.btnAlumnos);
            this.MenuVertical.Controls.Add(this.btnAsistencia);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(180, 558);
            this.MenuVertical.TabIndex = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnSalir);
            this.BarraTitulo.Controls.Add(this.btnslider);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(180, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(940, 53);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.Window;
            this.pnlContenedor.Location = new System.Drawing.Point(180, 53);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(940, 482);
            this.pnlContenedor.TabIndex = 2;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Plantilla_Bonita.Properties.Resources.Imagen5;
            this.btnRestaurar.Location = new System.Drawing.Point(882, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Plantilla_Bonita.Properties.Resources.Imagen4;
            this.btnMinimizar.Location = new System.Drawing.Point(856, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Plantilla_Bonita.Properties.Resources.Imagen2;
            this.btnMaximizar.Location = new System.Drawing.Point(882, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Plantilla_Bonita.Properties.Resources.Imagen3;
            this.btnSalir.Location = new System.Drawing.Point(908, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 1;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnslider
            // 
            this.btnslider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslider.Image = global::Plantilla_Bonita.Properties.Resources.Imagen6;
            this.btnslider.Location = new System.Drawing.Point(6, 3);
            this.btnslider.Name = "btnslider";
            this.btnslider.Size = new System.Drawing.Size(35, 44);
            this.btnslider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslider.TabIndex = 0;
            this.btnslider.TabStop = false;
            this.btnslider.Click += new System.EventHandler(this.btnslider_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.Image = global::Plantilla_Bonita.Properties.Resources.docente3;
            this.btnDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.Location = new System.Drawing.Point(12, 174);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(190, 45);
            this.btnDocentes.TabIndex = 3;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.Image = global::Plantilla_Bonita.Properties.Resources.clientes;
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(3, 123);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(199, 45);
            this.btnAlumnos.TabIndex = 2;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Image = global::Plantilla_Bonita.Properties.Resources.lista1;
            this.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Location = new System.Drawing.Point(12, 72);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(190, 45);
            this.btnAsistencia.TabIndex = 1;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Plantilla_Bonita.Properties.Resources.Imagen8;
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 558);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnAlumnos;
    }
}

