namespace Plantilla_Bonita
{
    partial class frmCopiaSeguridad
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
            this.lnkCarpeta = new System.Windows.Forms.LinkLabel();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.txtNombreServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreBaseDeDatos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearCopia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnkCarpeta
            // 
            this.lnkCarpeta.AutoSize = true;
            this.lnkCarpeta.Location = new System.Drawing.Point(45, 65);
            this.lnkCarpeta.Name = "lnkCarpeta";
            this.lnkCarpeta.Size = new System.Drawing.Size(0, 13);
            this.lnkCarpeta.TabIndex = 0;
            // 
            // btnDireccion
            // 
            this.btnDireccion.Location = new System.Drawing.Point(172, 27);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(132, 23);
            this.btnDireccion.TabIndex = 1;
            this.btnDireccion.Text = "Seleccionar Carpeta";
            this.btnDireccion.UseVisualStyleBackColor = true;
            this.btnDireccion.Click += new System.EventHandler(this.btnDireccion_Click);
            // 
            // txtNombreServidor
            // 
            this.txtNombreServidor.Location = new System.Drawing.Point(48, 122);
            this.txtNombreServidor.Name = "txtNombreServidor";
            this.txtNombreServidor.Size = new System.Drawing.Size(256, 20);
            this.txtNombreServidor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Servidor";
            // 
            // txtNombreBaseDeDatos
            // 
            this.txtNombreBaseDeDatos.Location = new System.Drawing.Point(48, 187);
            this.txtNombreBaseDeDatos.Name = "txtNombreBaseDeDatos";
            this.txtNombreBaseDeDatos.Size = new System.Drawing.Size(256, 20);
            this.txtNombreBaseDeDatos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de la base de datos";
            // 
            // btnCrearCopia
            // 
            this.btnCrearCopia.Location = new System.Drawing.Point(231, 230);
            this.btnCrearCopia.Name = "btnCrearCopia";
            this.btnCrearCopia.Size = new System.Drawing.Size(73, 23);
            this.btnCrearCopia.TabIndex = 6;
            this.btnCrearCopia.Text = "Crear";
            this.btnCrearCopia.UseVisualStyleBackColor = true;
            this.btnCrearCopia.Click += new System.EventHandler(this.btnCrearCopia_Click);
            // 
            // frmCopiaSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearCopia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreBaseDeDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreServidor);
            this.Controls.Add(this.btnDireccion);
            this.Controls.Add(this.lnkCarpeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCopiaSeguridad";
            this.Text = "frmCopiaSeguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkCarpeta;
        private System.Windows.Forms.Button btnDireccion;
        private System.Windows.Forms.TextBox txtNombreServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreBaseDeDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearCopia;
    }
}