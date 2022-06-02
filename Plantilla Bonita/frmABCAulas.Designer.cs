namespace Plantilla_Bonita
{
    partial class frmABCAulas
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label codigoAulaLabel;
            System.Windows.Forms.Label codEdificioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABCAulas));
            this.aulasDataSet = new Plantilla_Bonita.AulasDataSet();
            this.aulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulasTableAdapter = new Plantilla_Bonita.AulasDataSetTableAdapters.AulasTableAdapter();
            this.tableAdapterManager = new Plantilla_Bonita.AulasDataSetTableAdapters.TableAdapterManager();
            this.aulasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aulasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aulasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edificiosDataSet = new Plantilla_Bonita.EdificiosDataSet();
            this.edificiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edificiosTableAdapter = new Plantilla_Bonita.EdificiosDataSetTableAdapters.EdificiosTableAdapter();
            this.tableAdapterManager1 = new Plantilla_Bonita.EdificiosDataSetTableAdapters.TableAdapterManager();
            this.codigoEdificioComboBox = new System.Windows.Forms.ComboBox();
            this.edificiosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.edificiosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.codigoAulaTextBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new FontAwesome.Sharp.IconPictureBox();
            this.btnAgregarNuevo = new FontAwesome.Sharp.IconPictureBox();
            this.btnUpdateData = new FontAwesome.Sharp.IconPictureBox();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconPictureBox();
            this.codEdificioTextBox = new System.Windows.Forms.TextBox();
            codigoEdificioLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            codigoAulaLabel = new System.Windows.Forms.Label();
            codEdificioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingNavigator)).BeginInit();
            this.aulasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarCambios)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoEdificioLabel
            // 
            codigoEdificioLabel.AutoSize = true;
            codigoEdificioLabel.Location = new System.Drawing.Point(232, 82);
            codigoEdificioLabel.Name = "codigoEdificioLabel";
            codigoEdificioLabel.Size = new System.Drawing.Size(80, 13);
            codigoEdificioLabel.TabIndex = 2;
            codigoEdificioLabel.Text = "Codigo Edificio:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(21, 151);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // codigoAulaLabel
            // 
            codigoAulaLabel.AutoSize = true;
            codigoAulaLabel.Location = new System.Drawing.Point(21, 99);
            codigoAulaLabel.Name = "codigoAulaLabel";
            codigoAulaLabel.Size = new System.Drawing.Size(67, 13);
            codigoAulaLabel.TabIndex = 6;
            codigoAulaLabel.Text = "Codigo Aula:";
            // 
            // codEdificioLabel
            // 
            codEdificioLabel.AutoSize = true;
            codEdificioLabel.Location = new System.Drawing.Point(260, 127);
            codEdificioLabel.Name = "codEdificioLabel";
            codEdificioLabel.Size = new System.Drawing.Size(65, 13);
            codEdificioLabel.TabIndex = 13;
            codEdificioLabel.Text = "cod Edificio:";
            codEdificioLabel.Visible = false;
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
            // aulasBindingNavigator
            // 
            this.aulasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aulasBindingNavigator.BindingSource = this.aulasBindingSource;
            this.aulasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aulasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aulasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aulasBindingNavigatorSaveItem});
            this.aulasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aulasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aulasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aulasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aulasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aulasBindingNavigator.Name = "aulasBindingNavigator";
            this.aulasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aulasBindingNavigator.Size = new System.Drawing.Size(980, 25);
            this.aulasBindingNavigator.TabIndex = 0;
            this.aulasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aulasBindingNavigatorSaveItem
            // 
            this.aulasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aulasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aulasBindingNavigatorSaveItem.Image")));
            this.aulasBindingNavigatorSaveItem.Name = "aulasBindingNavigatorSaveItem";
            this.aulasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aulasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.aulasBindingNavigatorSaveItem.Click += new System.EventHandler(this.aulasBindingNavigatorSaveItem_Click);
            // 
            // aulasDataGridView
            // 
            this.aulasDataGridView.AllowUserToAddRows = false;
            this.aulasDataGridView.AllowUserToDeleteRows = false;
            this.aulasDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aulasDataGridView.AutoGenerateColumns = false;
            this.aulasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aulasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.aulasDataGridView.DataSource = this.aulasBindingSource;
            this.aulasDataGridView.Location = new System.Drawing.Point(451, 40);
            this.aulasDataGridView.Name = "aulasDataGridView";
            this.aulasDataGridView.ReadOnly = true;
            this.aulasDataGridView.Size = new System.Drawing.Size(365, 279);
            this.aulasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codEdificio";
            this.dataGridViewTextBoxColumn1.HeaderText = "codEdificio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodigoAula";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodigoAula";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // edificiosDataSet
            // 
            this.edificiosDataSet.DataSetName = "EdificiosDataSet";
            this.edificiosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edificiosBindingSource
            // 
            this.edificiosBindingSource.DataMember = "Edificios";
            this.edificiosBindingSource.DataSource = this.edificiosDataSet;
            // 
            // edificiosTableAdapter
            // 
            this.edificiosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EdificiosTableAdapter = this.edificiosTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Plantilla_Bonita.EdificiosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codigoEdificioComboBox
            // 
            this.codigoEdificioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.edificiosBindingSource, "CodigoEdificio", true));
            this.codigoEdificioComboBox.DataSource = this.edificiosBindingSource1;
            this.codigoEdificioComboBox.DisplayMember = "CodigoEdificio";
            this.codigoEdificioComboBox.FormattingEnabled = true;
            this.codigoEdificioComboBox.Location = new System.Drawing.Point(318, 79);
            this.codigoEdificioComboBox.Name = "codigoEdificioComboBox";
            this.codigoEdificioComboBox.Size = new System.Drawing.Size(121, 21);
            this.codigoEdificioComboBox.TabIndex = 3;
            this.codigoEdificioComboBox.ValueMember = "CodigoEdificio";
            this.codigoEdificioComboBox.SelectedValueChanged += new System.EventHandler(this.codigoEdificioComboBox_SelectedValueChanged);
            // 
            // edificiosBindingSource1
            // 
            this.edificiosBindingSource1.DataMember = "Edificios";
            this.edificiosBindingSource1.DataSource = this.edificiosDataSetBindingSource;
            // 
            // edificiosDataSetBindingSource
            // 
            this.edificiosDataSetBindingSource.DataSource = this.edificiosDataSet;
            this.edificiosDataSetBindingSource.Position = 0;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(24, 173);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(415, 82);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // codigoAulaTextBox
            // 
            this.codigoAulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "CodigoAula", true));
            this.codigoAulaTextBox.Location = new System.Drawing.Point(24, 124);
            this.codigoAulaTextBox.Name = "codigoAulaTextBox";
            this.codigoAulaTextBox.Size = new System.Drawing.Size(192, 20);
            this.codigoAulaTextBox.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(290, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.TabStop = false;
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarNuevo.BackColor = System.Drawing.Color.White;
            this.btnAgregarNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAgregarNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarNuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAgregarNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(328, 287);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(32, 32);
            this.btnAgregarNuevo.TabIndex = 12;
            this.btnAgregarNuevo.TabStop = false;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateData.BackColor = System.Drawing.Color.White;
            this.btnUpdateData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnUpdateData.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnUpdateData.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnUpdateData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateData.Location = new System.Drawing.Point(366, 287);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(32, 32);
            this.btnUpdateData.TabIndex = 11;
            this.btnUpdateData.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarCambios.BackColor = System.Drawing.Color.White;
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCambios.Location = new System.Drawing.Point(404, 287);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(32, 32);
            this.btnGuardarCambios.TabIndex = 10;
            this.btnGuardarCambios.TabStop = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // codEdificioTextBox
            // 
            this.codEdificioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "codEdificio", true));
            this.codEdificioTextBox.Location = new System.Drawing.Point(331, 124);
            this.codEdificioTextBox.Name = "codEdificioTextBox";
            this.codEdificioTextBox.Size = new System.Drawing.Size(100, 20);
            this.codEdificioTextBox.TabIndex = 14;
            this.codEdificioTextBox.Visible = false;
            // 
            // frmABCAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 471);
            this.Controls.Add(codEdificioLabel);
            this.Controls.Add(this.codEdificioTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(codigoAulaLabel);
            this.Controls.Add(this.codigoAulaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(codigoEdificioLabel);
            this.Controls.Add(this.codigoEdificioComboBox);
            this.Controls.Add(this.aulasDataGridView);
            this.Controls.Add(this.aulasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmABCAulas";
            this.Text = "frmABCAulas";
            this.Load += new System.EventHandler(this.frmABCAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingNavigator)).EndInit();
            this.aulasBindingNavigator.ResumeLayout(false);
            this.aulasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarCambios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AulasDataSet aulasDataSet;
        private System.Windows.Forms.BindingSource aulasBindingSource;
        private AulasDataSetTableAdapters.AulasTableAdapter aulasTableAdapter;
        private AulasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aulasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aulasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView aulasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private EdificiosDataSet edificiosDataSet;
        private System.Windows.Forms.BindingSource edificiosBindingSource;
        private EdificiosDataSetTableAdapters.EdificiosTableAdapter edificiosTableAdapter;
        private EdificiosDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox codigoEdificioComboBox;
        private System.Windows.Forms.BindingSource edificiosBindingSource1;
        private System.Windows.Forms.BindingSource edificiosDataSetBindingSource;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox codigoAulaTextBox;
        private FontAwesome.Sharp.IconPictureBox btnDelete;
        private FontAwesome.Sharp.IconPictureBox btnAgregarNuevo;
        private FontAwesome.Sharp.IconPictureBox btnUpdateData;
        private FontAwesome.Sharp.IconPictureBox btnGuardarCambios;
        private System.Windows.Forms.TextBox codEdificioTextBox;
    }
}