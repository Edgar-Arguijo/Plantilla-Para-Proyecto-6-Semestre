namespace SGA_ITSL.UI.Administrador
{
    partial class usuarioBC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label nombreDeUsuarioLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label rolLabel;
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnDelete = new FontAwesome.Sharp.IconPictureBox();
            this.btnGuardar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMostrarContra = new FontAwesome.Sharp.IconPictureBox();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.pnlContendor = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            nombreDeUsuarioLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarContra)).BeginInit();
            this.pnlContendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(24, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(308, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(24, 155);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(274, 20);
            this.txtContraseña.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(262, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(300, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(32, 32);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.TabStop = false;
            // 
            // nombreDeUsuarioLabel
            // 
            nombreDeUsuarioLabel.AutoSize = true;
            nombreDeUsuarioLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            nombreDeUsuarioLabel.Location = new System.Drawing.Point(19, 63);
            nombreDeUsuarioLabel.Name = "nombreDeUsuarioLabel";
            nombreDeUsuarioLabel.Size = new System.Drawing.Size(148, 25);
            nombreDeUsuarioLabel.TabIndex = 13;
            nombreDeUsuarioLabel.Text = "Nombre De Usuario:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            contraseñaLabel.Location = new System.Drawing.Point(19, 127);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(98, 25);
            contraseñaLabel.TabIndex = 14;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // btnMostrarContra
            // 
            this.btnMostrarContra.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrarContra.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnMostrarContra.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrarContra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarContra.IconSize = 28;
            this.btnMostrarContra.Location = new System.Drawing.Point(304, 155);
            this.btnMostrarContra.Name = "btnMostrarContra";
            this.btnMostrarContra.Size = new System.Drawing.Size(28, 32);
            this.btnMostrarContra.TabIndex = 15;
            this.btnMostrarContra.TabStop = false;
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            rolLabel.Location = new System.Drawing.Point(127, 197);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(38, 25);
            rolLabel.TabIndex = 16;
            rolLabel.Text = "Rol:";
            // 
            // rolComboBox
            // 
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Docente",
            "Administrativo",
            "User"});
            this.rolComboBox.Location = new System.Drawing.Point(171, 204);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(161, 21);
            this.rolComboBox.TabIndex = 17;
            // 
            // pnlContendor
            // 
            this.pnlContendor.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnlContendor.Controls.Add(this.btnCerrar);
            this.pnlContendor.Controls.Add(this.pnlEncabezado);
            this.pnlContendor.Controls.Add(rolLabel);
            this.pnlContendor.Controls.Add(contraseñaLabel);
            this.pnlContendor.Controls.Add(this.rolComboBox);
            this.pnlContendor.Controls.Add(nombreDeUsuarioLabel);
            this.pnlContendor.Controls.Add(this.btnMostrarContra);
            this.pnlContendor.Controls.Add(this.txtContraseña);
            this.pnlContendor.Controls.Add(this.btnDelete);
            this.pnlContendor.Controls.Add(this.txtNombre);
            this.pnlContendor.Controls.Add(this.btnGuardar);
            this.pnlContendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContendor.Location = new System.Drawing.Point(0, 0);
            this.pnlContendor.Name = "pnlContendor";
            this.pnlContendor.Size = new System.Drawing.Size(355, 312);
            this.pnlContendor.TabIndex = 18;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(355, 37);
            this.pnlEncabezado.TabIndex = 18;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 27;
            this.btnCerrar.Location = new System.Drawing.Point(320, 47);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 27);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // usuarioBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 312);
            this.Controls.Add(this.pnlContendor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuarioBC";
            this.Text = "usuarioBC";
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarContra)).EndInit();
            this.pnlContendor.ResumeLayout(false);
            this.pnlContendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private FontAwesome.Sharp.IconPictureBox btnDelete;
        private FontAwesome.Sharp.IconPictureBox btnGuardar;
        private FontAwesome.Sharp.IconPictureBox btnMostrarContra;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.Panel pnlContendor;
        private System.Windows.Forms.Panel pnlEncabezado;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
    }
}