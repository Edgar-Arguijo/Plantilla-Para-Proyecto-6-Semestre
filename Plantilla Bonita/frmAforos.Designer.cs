namespace Plantilla_Bonita
{
    partial class frmAforos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoAulaLabel;
            System.Windows.Forms.Label codigoEdificioLabel;
            this.aulasDataSet = new Plantilla_Bonita.AulasDataSet();
            this.aulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulasTableAdapter = new Plantilla_Bonita.AulasDataSetTableAdapters.AulasTableAdapter();
            this.tableAdapterManager = new Plantilla_Bonita.AulasDataSetTableAdapters.TableAdapterManager();
            this.codigoAulaComboBox = new System.Windows.Forms.ComboBox();
            this.edificiosDataSet = new Plantilla_Bonita.EdificiosDataSet();
            this.vista_EdificiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_EdificiosTableAdapter = new Plantilla_Bonita.EdificiosDataSetTableAdapters.Vista_EdificiosTableAdapter();
            this.tableAdapterManager1 = new Plantilla_Bonita.EdificiosDataSetTableAdapters.TableAdapterManager();
            this.codigoEdificioComboBox = new System.Windows.Forms.ComboBox();
            this.vistaEdificiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            codigoAulaLabel = new System.Windows.Forms.Label();
            codigoEdificioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_EdificiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEdificiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // aulasDataSet
            // 
            this.aulasDataSet.DataSetName = "AulasDataSet";
            this.aulasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulasBindingSource
            // 
            this.aulasBindingSource.DataMember = "Aulas";
            this.aulasBindingSource.DataSource = this.aulasDataSet;
            // 
            // aulasTableAdapter
            // 
            this.aulasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulasTableAdapter = this.aulasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Plantilla_Bonita.AulasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codigoAulaLabel
            // 
            codigoAulaLabel.AutoSize = true;
            codigoAulaLabel.Location = new System.Drawing.Point(338, 46);
            codigoAulaLabel.Name = "codigoAulaLabel";
            codigoAulaLabel.Size = new System.Drawing.Size(67, 13);
            codigoAulaLabel.TabIndex = 1;
            codigoAulaLabel.Text = "Codigo Aula:";
            // 
            // codigoAulaComboBox
            // 
            this.codigoAulaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "CodigoAula", true));
            this.codigoAulaComboBox.DataSource = this.aulasBindingSource1;
            this.codigoAulaComboBox.DisplayMember = "CodigoAula";
            this.codigoAulaComboBox.FormattingEnabled = true;
            this.codigoAulaComboBox.Location = new System.Drawing.Point(411, 43);
            this.codigoAulaComboBox.Name = "codigoAulaComboBox";
            this.codigoAulaComboBox.Size = new System.Drawing.Size(121, 21);
            this.codigoAulaComboBox.TabIndex = 2;
            // 
            // edificiosDataSet
            // 
            this.edificiosDataSet.DataSetName = "EdificiosDataSet";
            this.edificiosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_EdificiosBindingSource
            // 
            this.vista_EdificiosBindingSource.DataMember = "Vista_Edificios";
            this.vista_EdificiosBindingSource.DataSource = this.edificiosDataSet;
            // 
            // vista_EdificiosTableAdapter
            // 
            this.vista_EdificiosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Plantilla_Bonita.EdificiosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codigoEdificioLabel
            // 
            codigoEdificioLabel.AutoSize = true;
            codigoEdificioLabel.Location = new System.Drawing.Point(31, 51);
            codigoEdificioLabel.Name = "codigoEdificioLabel";
            codigoEdificioLabel.Size = new System.Drawing.Size(80, 13);
            codigoEdificioLabel.TabIndex = 3;
            codigoEdificioLabel.Text = "Codigo Edificio:";
            // 
            // codigoEdificioComboBox
            // 
            this.codigoEdificioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vista_EdificiosBindingSource, "CodigoEdificio", true));
            this.codigoEdificioComboBox.DataSource = this.vistaEdificiosBindingSource;
            this.codigoEdificioComboBox.DisplayMember = "CodigoEdificio";
            this.codigoEdificioComboBox.FormattingEnabled = true;
            this.codigoEdificioComboBox.Location = new System.Drawing.Point(117, 48);
            this.codigoEdificioComboBox.Name = "codigoEdificioComboBox";
            this.codigoEdificioComboBox.Size = new System.Drawing.Size(121, 21);
            this.codigoEdificioComboBox.TabIndex = 4;
            this.codigoEdificioComboBox.SelectedValueChanged += new System.EventHandler(this.codigoEdificioComboBox_SelectedValueChanged);
            // 
            // vistaEdificiosBindingSource
            // 
            this.vistaEdificiosBindingSource.DataMember = "Vista_Edificios";
            this.vistaEdificiosBindingSource.DataSource = this.edificiosDataSet;
            // 
            // aulasBindingSource1
            // 
            this.aulasBindingSource1.DataMember = "Aulas";
            this.aulasBindingSource1.DataSource = this.aulasDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(427, 124);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(203, 108);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(80, 13);
            this.lblInicio.TabIndex = 7;
            this.lblInicio.Text = "Fecha de Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de Inicio";
            // 
            // frmAforos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(codigoEdificioLabel);
            this.Controls.Add(this.codigoEdificioComboBox);
            this.Controls.Add(codigoAulaLabel);
            this.Controls.Add(this.codigoAulaComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAforos";
            this.Text = "frmAforos";
            this.Load += new System.EventHandler(this.frmAforos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_EdificiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEdificiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AulasDataSet aulasDataSet;
        private System.Windows.Forms.BindingSource aulasBindingSource;
        private AulasDataSetTableAdapters.AulasTableAdapter aulasTableAdapter;
        private AulasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox codigoAulaComboBox;
        private EdificiosDataSet edificiosDataSet;
        private System.Windows.Forms.BindingSource vista_EdificiosBindingSource;
        private EdificiosDataSetTableAdapters.Vista_EdificiosTableAdapter vista_EdificiosTableAdapter;
        private EdificiosDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource aulasBindingSource1;
        private System.Windows.Forms.ComboBox codigoEdificioComboBox;
        private System.Windows.Forms.BindingSource vistaEdificiosBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label1;
    }
}