namespace SGA_ITSL.UI.FormasABC.BajasCambios
{
    partial class AulasBC
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
            System.Windows.Forms.Label codigoAulaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label codigoEdificioLabel;
            this.btnDelete = new FontAwesome.Sharp.IconPictureBox();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.codigoAulaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.codigoEdificioComboBox = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            codigoAulaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            codigoEdificioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarCambios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(368, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCambios.Location = new System.Drawing.Point(406, 295);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(32, 32);
            this.btnGuardarCambios.TabIndex = 14;
            this.btnGuardarCambios.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(codigoAulaLabel);
            this.panel1.Controls.Add(this.codigoAulaTextBox);
            this.panel1.Controls.Add(descripcionLabel);
            this.panel1.Controls.Add(this.descripcionTextBox);
            this.panel1.Controls.Add(codigoEdificioLabel);
            this.panel1.Controls.Add(this.codigoEdificioComboBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnGuardarCambios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 344);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 35);
            this.panel2.TabIndex = 16;
            // 
            // codigoAulaLabel
            // 
            codigoAulaLabel.AutoSize = true;
            codigoAulaLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            codigoAulaLabel.Location = new System.Drawing.Point(9, 47);
            codigoAulaLabel.Name = "codigoAulaLabel";
            codigoAulaLabel.Size = new System.Drawing.Size(97, 25);
            codigoAulaLabel.TabIndex = 21;
            codigoAulaLabel.Text = "Codigo Aula:";
            // 
            // codigoAulaTextBox
            // 
            this.codigoAulaTextBox.Location = new System.Drawing.Point(12, 75);
            this.codigoAulaTextBox.Name = "codigoAulaTextBox";
            this.codigoAulaTextBox.Size = new System.Drawing.Size(192, 20);
            this.codigoAulaTextBox.TabIndex = 22;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            descripcionLabel.Location = new System.Drawing.Point(9, 99);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(97, 25);
            descripcionLabel.TabIndex = 19;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(12, 127);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(426, 162);
            this.descripcionTextBox.TabIndex = 20;
            // 
            // codigoEdificioLabel
            // 
            codigoEdificioLabel.AutoSize = true;
            codigoEdificioLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            codigoEdificioLabel.Location = new System.Drawing.Point(221, 47);
            codigoEdificioLabel.Name = "codigoEdificioLabel";
            codigoEdificioLabel.Size = new System.Drawing.Size(114, 25);
            codigoEdificioLabel.TabIndex = 17;
            codigoEdificioLabel.Text = "Codigo Edificio:";
            // 
            // codigoEdificioComboBox
            // 
            this.codigoEdificioComboBox.DisplayMember = "CodigoEdificio";
            this.codigoEdificioComboBox.FormattingEnabled = true;
            this.codigoEdificioComboBox.Location = new System.Drawing.Point(226, 75);
            this.codigoEdificioComboBox.Name = "codigoEdificioComboBox";
            this.codigoEdificioComboBox.Size = new System.Drawing.Size(163, 21);
            this.codigoEdificioComboBox.TabIndex = 18;
            this.codigoEdificioComboBox.ValueMember = "CodigoEdificio";
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
            this.btnCerrar.Location = new System.Drawing.Point(416, 41);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 27);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AulasBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 344);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AulasBC";
            this.Text = "AulasBC";
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarCambios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnDelete;
        private FontAwesome.Sharp.IconPictureBox btnGuardarCambios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox codigoAulaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox codigoEdificioComboBox;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
    }
}