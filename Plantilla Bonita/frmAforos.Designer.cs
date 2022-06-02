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
            this.dtPck_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dtPck_Fin = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.aforosDataSet = new Plantilla_Bonita.AforosDataSet();
            this.vista_AforosGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_AforosGeneralTableAdapter = new Plantilla_Bonita.AforosDataSetTableAdapters.Vista_AforosGeneralTableAdapter();
            this.tableAdapterManager2 = new Plantilla_Bonita.AforosDataSetTableAdapters.TableAdapterManager();
            this.vista_AforosGeneralDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBxFecha = new System.Windows.Forms.CheckBox();
            codigoAulaLabel = new System.Windows.Forms.Label();
            codigoEdificioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_EdificiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEdificiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aforosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AforosGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AforosGeneralDataGridView)).BeginInit();
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
            // dtPck_Inicio
            // 
            this.dtPck_Inicio.Location = new System.Drawing.Point(204, 124);
            this.dtPck_Inicio.Name = "dtPck_Inicio";
            this.dtPck_Inicio.Size = new System.Drawing.Size(200, 20);
            this.dtPck_Inicio.TabIndex = 5;
            // 
            // dtPck_Fin
            // 
            this.dtPck_Fin.Location = new System.Drawing.Point(427, 124);
            this.dtPck_Fin.Name = "dtPck_Fin";
            this.dtPck_Fin.Size = new System.Drawing.Size(200, 20);
            this.dtPck_Fin.TabIndex = 6;
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
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(424, 108);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(93, 13);
            this.lblFinal.TabIndex = 8;
            this.lblFinal.Text = "Fecha de Termino";
            // 
            // aforosDataSet
            // 
            this.aforosDataSet.DataSetName = "AforosDataSet";
            this.aforosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_AforosGeneralBindingSource
            // 
            this.vista_AforosGeneralBindingSource.DataMember = "Vista_AforosGeneral";
            this.vista_AforosGeneralBindingSource.DataSource = this.aforosDataSet;
            // 
            // vista_AforosGeneralTableAdapter
            // 
            this.vista_AforosGeneralTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = Plantilla_Bonita.AforosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vista_AforosGeneralDataGridView
            // 
            this.vista_AforosGeneralDataGridView.AllowUserToAddRows = false;
            this.vista_AforosGeneralDataGridView.AllowUserToDeleteRows = false;
            this.vista_AforosGeneralDataGridView.AllowUserToOrderColumns = true;
            this.vista_AforosGeneralDataGridView.AutoGenerateColumns = false;
            this.vista_AforosGeneralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista_AforosGeneralDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.vista_AforosGeneralDataGridView.DataSource = this.vista_AforosGeneralBindingSource;
            this.vista_AforosGeneralDataGridView.Location = new System.Drawing.Point(12, 236);
            this.vista_AforosGeneralDataGridView.Name = "vista_AforosGeneralDataGridView";
            this.vista_AforosGeneralDataGridView.ReadOnly = true;
            this.vista_AforosGeneralDataGridView.Size = new System.Drawing.Size(824, 295);
            this.vista_AforosGeneralDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Edificio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Edificio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Aula";
            this.dataGridViewTextBoxColumn2.HeaderText = "Aula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Aforo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Aforo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // chkBxFecha
            // 
            this.chkBxFecha.AutoSize = true;
            this.chkBxFecha.Location = new System.Drawing.Point(546, 65);
            this.chkBxFecha.Name = "chkBxFecha";
            this.chkBxFecha.Size = new System.Drawing.Size(122, 17);
            this.chkBxFecha.TabIndex = 9;
            this.chkBxFecha.Text = "Busqueda por fecha";
            this.chkBxFecha.UseVisualStyleBackColor = true;
            this.chkBxFecha.CheckedChanged += new System.EventHandler(this.chkBxFecha_CheckedChanged);
            // 
            // frmAforos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 543);
            this.Controls.Add(this.chkBxFecha);
            this.Controls.Add(this.vista_AforosGeneralDataGridView);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dtPck_Fin);
            this.Controls.Add(this.dtPck_Inicio);
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
            ((System.ComponentModel.ISupportInitialize)(this.aforosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AforosGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AforosGeneralDataGridView)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtPck_Inicio;
        private System.Windows.Forms.DateTimePicker dtPck_Fin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinal;
        private AforosDataSet aforosDataSet;
        private System.Windows.Forms.BindingSource vista_AforosGeneralBindingSource;
        private AforosDataSetTableAdapters.Vista_AforosGeneralTableAdapter vista_AforosGeneralTableAdapter;
        private AforosDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView vista_AforosGeneralDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.CheckBox chkBxFecha;
    }
}