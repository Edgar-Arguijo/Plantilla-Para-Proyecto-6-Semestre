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
            System.Windows.Forms.Label codigoEdificioLabel;
            System.Windows.Forms.Label codigoAulaLabel;
            this.pnlContendor = new System.Windows.Forms.Panel();
            this.btnPrint = new FontAwesome.Sharp.IconPictureBox();
            this.vista_AforosGeneralDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vista_AforosGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aforosDataSet = new Plantilla_Bonita.DataSets.AforosDataSet();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTPckInicio = new System.Windows.Forms.DateTimePicker();
            this.dtTPckFin = new System.Windows.Forms.DateTimePicker();
            this.codigoAulaComboBox = new System.Windows.Forms.ComboBox();
            this.aulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulasDataSet = new Plantilla_Bonita.DataSets.AulasDataSet();
            this.aulasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codigoEdificioComboBox = new System.Windows.Forms.ComboBox();
            this.edificiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edificiosDataSet = new Plantilla_Bonita.DataSets.EdificiosDataSet();
            this.edificiosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.edificiosTableAdapter = new Plantilla_Bonita.DataSets.EdificiosDataSetTableAdapters.EdificiosTableAdapter();
            this.tableAdapterManager = new Plantilla_Bonita.DataSets.EdificiosDataSetTableAdapters.TableAdapterManager();
            this.aulasTableAdapter = new Plantilla_Bonita.DataSets.AulasDataSetTableAdapters.AulasTableAdapter();
            this.tableAdapterManager1 = new Plantilla_Bonita.DataSets.AulasDataSetTableAdapters.TableAdapterManager();
            this.vista_AforosGeneralTableAdapter = new Plantilla_Bonita.DataSets.AforosDataSetTableAdapters.Vista_AforosGeneralTableAdapter();
            this.tableAdapterManager2 = new Plantilla_Bonita.DataSets.AforosDataSetTableAdapters.TableAdapterManager();
            codigoEdificioLabel = new System.Windows.Forms.Label();
            codigoAulaLabel = new System.Windows.Forms.Label();
            this.pnlContendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AforosGeneralDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AforosGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aforosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoEdificioLabel
            // 
            codigoEdificioLabel.AutoSize = true;
            codigoEdificioLabel.Location = new System.Drawing.Point(19, 27);
            codigoEdificioLabel.Name = "codigoEdificioLabel";
            codigoEdificioLabel.Size = new System.Drawing.Size(80, 13);
            codigoEdificioLabel.TabIndex = 0;
            codigoEdificioLabel.Text = "Codigo Edificio:";
            // 
            // codigoAulaLabel
            // 
            codigoAulaLabel.AutoSize = true;
            codigoAulaLabel.Location = new System.Drawing.Point(19, 70);
            codigoAulaLabel.Name = "codigoAulaLabel";
            codigoAulaLabel.Size = new System.Drawing.Size(84, 13);
            codigoAulaLabel.TabIndex = 2;
            codigoAulaLabel.Text = "Codigo del Aula:";
            // 
            // pnlContendor
            // 
            this.pnlContendor.BackColor = System.Drawing.Color.White;
            this.pnlContendor.Controls.Add(this.btnPrint);
            this.pnlContendor.Controls.Add(this.vista_AforosGeneralDataGridView);
            this.pnlContendor.Controls.Add(this.chkFecha);
            this.pnlContendor.Controls.Add(this.label2);
            this.pnlContendor.Controls.Add(this.label1);
            this.pnlContendor.Controls.Add(this.dtTPckInicio);
            this.pnlContendor.Controls.Add(this.dtTPckFin);
            this.pnlContendor.Controls.Add(codigoAulaLabel);
            this.pnlContendor.Controls.Add(this.codigoAulaComboBox);
            this.pnlContendor.Controls.Add(codigoEdificioLabel);
            this.pnlContendor.Controls.Add(this.codigoEdificioComboBox);
            this.pnlContendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContendor.Location = new System.Drawing.Point(0, 0);
            this.pnlContendor.Name = "pnlContendor";
            this.pnlContendor.Size = new System.Drawing.Size(892, 509);
            this.pnlContendor.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.Location = new System.Drawing.Point(833, 162);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 32);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.TabStop = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // vista_AforosGeneralDataGridView
            // 
            this.vista_AforosGeneralDataGridView.AllowUserToAddRows = false;
            this.vista_AforosGeneralDataGridView.AllowUserToDeleteRows = false;
            this.vista_AforosGeneralDataGridView.AllowUserToOrderColumns = true;
            this.vista_AforosGeneralDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vista_AforosGeneralDataGridView.AutoGenerateColumns = false;
            this.vista_AforosGeneralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista_AforosGeneralDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.vista_AforosGeneralDataGridView.DataSource = this.vista_AforosGeneralBindingSource;
            this.vista_AforosGeneralDataGridView.Location = new System.Drawing.Point(21, 200);
            this.vista_AforosGeneralDataGridView.Name = "vista_AforosGeneralDataGridView";
            this.vista_AforosGeneralDataGridView.ReadOnly = true;
            this.vista_AforosGeneralDataGridView.Size = new System.Drawing.Size(844, 287);
            this.vista_AforosGeneralDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Edificio";
            this.dataGridViewTextBoxColumn1.FillWeight = 10F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Edificio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Aula";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Aula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 53;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.FillWeight = 40F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Aforo";
            this.dataGridViewTextBoxColumn3.FillWeight = 10F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Aforo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 57;
            // 
            // vista_AforosGeneralBindingSource
            // 
            this.vista_AforosGeneralBindingSource.DataMember = "Vista_AforosGeneral";
            this.vista_AforosGeneralBindingSource.DataSource = this.aforosDataSet;
            // 
            // aforosDataSet
            // 
            this.aforosDataSet.DataSetName = "AforosDataSet";
            this.aforosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Checked = true;
            this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFecha.Location = new System.Drawing.Point(266, 47);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(125, 17);
            this.chkFecha.TabIndex = 8;
            this.chkFecha.Text = "Busqueda por Fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fin del Periodo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Inicial:";
            // 
            // dtTPckInicio
            // 
            this.dtTPckInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtTPckInicio.Location = new System.Drawing.Point(23, 167);
            this.dtTPckInicio.Name = "dtTPckInicio";
            this.dtTPckInicio.Size = new System.Drawing.Size(200, 20);
            this.dtTPckInicio.TabIndex = 5;
            this.dtTPckInicio.ValueChanged += new System.EventHandler(this.dtTPckInicio_ValueChanged);
            // 
            // dtTPckFin
            // 
            this.dtTPckFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtTPckFin.Location = new System.Drawing.Point(240, 167);
            this.dtTPckFin.Name = "dtTPckFin";
            this.dtTPckFin.Size = new System.Drawing.Size(200, 20);
            this.dtTPckFin.TabIndex = 4;
            this.dtTPckFin.ValueChanged += new System.EventHandler(this.dtTPckFin_ValueChanged);
            // 
            // codigoAulaComboBox
            // 
            this.codigoAulaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "CodigoAula", true));
            this.codigoAulaComboBox.DataSource = this.aulasBindingSource1;
            this.codigoAulaComboBox.DisplayMember = "CodigoAula";
            this.codigoAulaComboBox.FormattingEnabled = true;
            this.codigoAulaComboBox.Location = new System.Drawing.Point(105, 67);
            this.codigoAulaComboBox.Name = "codigoAulaComboBox";
            this.codigoAulaComboBox.Size = new System.Drawing.Size(121, 21);
            this.codigoAulaComboBox.TabIndex = 3;
            this.codigoAulaComboBox.ValueMember = "CodigoAula";
            // 
            // aulasBindingSource
            // 
            this.aulasBindingSource.DataMember = "Aulas";
            this.aulasBindingSource.DataSource = this.aulasDataSet;
            // 
            // aulasDataSet
            // 
            this.aulasDataSet.DataSetName = "AulasDataSet";
            this.aulasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulasBindingSource1
            // 
            this.aulasBindingSource1.DataMember = "Aulas";
            this.aulasBindingSource1.DataSource = this.aulasDataSet;
            // 
            // codigoEdificioComboBox
            // 
            this.codigoEdificioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.edificiosBindingSource, "CodigoEdificio", true));
            this.codigoEdificioComboBox.DataSource = this.edificiosBindingSource1;
            this.codigoEdificioComboBox.DisplayMember = "CodigoEdificio";
            this.codigoEdificioComboBox.FormattingEnabled = true;
            this.codigoEdificioComboBox.Location = new System.Drawing.Point(105, 24);
            this.codigoEdificioComboBox.Name = "codigoEdificioComboBox";
            this.codigoEdificioComboBox.Size = new System.Drawing.Size(121, 21);
            this.codigoEdificioComboBox.TabIndex = 1;
            this.codigoEdificioComboBox.ValueMember = "CodigoEdificio";
            this.codigoEdificioComboBox.SelectedValueChanged += new System.EventHandler(this.codigoEdificioComboBox_SelectedValueChanged);
            // 
            // edificiosBindingSource
            // 
            this.edificiosBindingSource.DataMember = "Edificios";
            this.edificiosBindingSource.DataSource = this.edificiosDataSet;
            // 
            // edificiosDataSet
            // 
            this.edificiosDataSet.DataSetName = "EdificiosDataSet";
            this.edificiosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edificiosBindingSource1
            // 
            this.edificiosBindingSource1.DataMember = "Edificios";
            this.edificiosBindingSource1.DataSource = this.edificiosDataSet;
            // 
            // edificiosTableAdapter
            // 
            this.edificiosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EdificiosTableAdapter = this.edificiosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Plantilla_Bonita.DataSets.EdificiosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aulasTableAdapter
            // 
            this.aulasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AulasTableAdapter = this.aulasTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Plantilla_Bonita.DataSets.AulasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vista_AforosGeneralTableAdapter
            // 
            this.vista_AforosGeneralTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = Plantilla_Bonita.DataSets.AforosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmAforos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 509);
            this.Controls.Add(this.pnlContendor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAforos";
            this.Text = "frmAforos";
            this.Load += new System.EventHandler(this.frmAforos_Load);
            this.pnlContendor.ResumeLayout(false);
            this.pnlContendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AforosGeneralDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AforosGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aforosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContendor;
        private DataSets.EdificiosDataSet edificiosDataSet;
        private System.Windows.Forms.BindingSource edificiosBindingSource;
        private DataSets.EdificiosDataSetTableAdapters.EdificiosTableAdapter edificiosTableAdapter;
        private DataSets.EdificiosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox codigoEdificioComboBox;
        private System.Windows.Forms.BindingSource edificiosBindingSource1;
        private DataSets.AulasDataSet aulasDataSet;
        private System.Windows.Forms.BindingSource aulasBindingSource;
        private DataSets.AulasDataSetTableAdapters.AulasTableAdapter aulasTableAdapter;
        private DataSets.AulasDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox codigoAulaComboBox;
        private System.Windows.Forms.BindingSource aulasBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTPckInicio;
        private System.Windows.Forms.DateTimePicker dtTPckFin;
        private System.Windows.Forms.CheckBox chkFecha;
        private DataSets.AforosDataSet aforosDataSet;
        private System.Windows.Forms.BindingSource vista_AforosGeneralBindingSource;
        private DataSets.AforosDataSetTableAdapters.Vista_AforosGeneralTableAdapter vista_AforosGeneralTableAdapter;
        private DataSets.AforosDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView vista_AforosGeneralDataGridView;
        private FontAwesome.Sharp.IconPictureBox btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}