namespace Plantilla_Bonita.UI.Administrador
{
    partial class frmBitacora
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
            System.Windows.Forms.Label actuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBitacora));
            this.bitacoraDataSet = new Plantilla_Bonita.BitacoraDataSet();
            this.bitacoraBaseDeDatos_VistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitacoraBaseDeDatos_VistaTableAdapter = new Plantilla_Bonita.BitacoraDataSetTableAdapters.BitacoraBaseDeDatos_VistaTableAdapter();
            this.tableAdapterManager = new Plantilla_Bonita.BitacoraDataSetTableAdapters.TableAdapterManager();
            this.bitacoraBaseDeDatos_VistaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bitacoraBaseDeDatos_VistaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actuarioDataSet = new Plantilla_Bonita.ActuarioDataSet();
            this.bitacoraBaseDeDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitacoraBaseDeDatosTableAdapter = new Plantilla_Bonita.ActuarioDataSetTableAdapters.BitacoraBaseDeDatosTableAdapter();
            this.tableAdapterManager1 = new Plantilla_Bonita.ActuarioDataSetTableAdapters.TableAdapterManager();
            this.actuarioComboBox = new System.Windows.Forms.ComboBox();
            this.bitacoraBaseDeDatosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bitacoraBaseDeDatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.actuarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            actuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatos_VistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatos_VistaBindingNavigator)).BeginInit();
            this.bitacoraBaseDeDatos_VistaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatos_VistaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actuarioDataSetBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // actuarioLabel
            // 
            actuarioLabel.AutoSize = true;
            actuarioLabel.Location = new System.Drawing.Point(29, 20);
            actuarioLabel.Name = "actuarioLabel";
            actuarioLabel.Size = new System.Drawing.Size(49, 13);
            actuarioLabel.TabIndex = 2;
            actuarioLabel.Text = "Actuario:";
            // 
            // bitacoraDataSet
            // 
            this.bitacoraDataSet.DataSetName = "BitacoraDataSet";
            this.bitacoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitacoraBaseDeDatos_VistaBindingSource
            // 
            this.bitacoraBaseDeDatos_VistaBindingSource.DataMember = "BitacoraBaseDeDatos_Vista";
            this.bitacoraBaseDeDatos_VistaBindingSource.DataSource = this.bitacoraDataSet;
            // 
            // bitacoraBaseDeDatos_VistaTableAdapter
            // 
            this.bitacoraBaseDeDatos_VistaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Plantilla_Bonita.BitacoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bitacoraBaseDeDatos_VistaBindingNavigator
            // 
            this.bitacoraBaseDeDatos_VistaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.BindingSource = this.bitacoraBaseDeDatos_VistaBindingSource;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem});
            this.bitacoraBaseDeDatos_VistaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bitacoraBaseDeDatos_VistaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.Name = "bitacoraBaseDeDatos_VistaBindingNavigator";
            this.bitacoraBaseDeDatos_VistaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.Size = new System.Drawing.Size(957, 25);
            this.bitacoraBaseDeDatos_VistaBindingNavigator.TabIndex = 0;
            this.bitacoraBaseDeDatos_VistaBindingNavigator.Text = "bindingNavigator1";
            this.bitacoraBaseDeDatos_VistaBindingNavigator.Visible = false;
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
            // bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem
            // 
            this.bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem.Enabled = false;
            this.bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem.Image")));
            this.bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem.Name = "bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem";
            this.bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // bitacoraBaseDeDatos_VistaDataGridView
            // 
            this.bitacoraBaseDeDatos_VistaDataGridView.AllowUserToAddRows = false;
            this.bitacoraBaseDeDatos_VistaDataGridView.AllowUserToDeleteRows = false;
            this.bitacoraBaseDeDatos_VistaDataGridView.AllowUserToOrderColumns = true;
            this.bitacoraBaseDeDatos_VistaDataGridView.AutoGenerateColumns = false;
            this.bitacoraBaseDeDatos_VistaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bitacoraBaseDeDatos_VistaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bitacoraBaseDeDatos_VistaDataGridView.DataSource = this.bitacoraBaseDeDatos_VistaBindingSource;
            this.bitacoraBaseDeDatos_VistaDataGridView.Location = new System.Drawing.Point(22, 172);
            this.bitacoraBaseDeDatos_VistaDataGridView.Name = "bitacoraBaseDeDatos_VistaDataGridView";
            this.bitacoraBaseDeDatos_VistaDataGridView.ReadOnly = true;
            this.bitacoraBaseDeDatos_VistaDataGridView.Size = new System.Drawing.Size(915, 309);
            this.bitacoraBaseDeDatos_VistaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Actuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Actuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tabla";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tabla";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // actuarioDataSet
            // 
            this.actuarioDataSet.DataSetName = "ActuarioDataSet";
            this.actuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitacoraBaseDeDatosBindingSource
            // 
            this.bitacoraBaseDeDatosBindingSource.DataMember = "BitacoraBaseDeDatos";
            this.bitacoraBaseDeDatosBindingSource.DataSource = this.actuarioDataSet;
            // 
            // bitacoraBaseDeDatosTableAdapter
            // 
            this.bitacoraBaseDeDatosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BitacoraBaseDeDatosTableAdapter = this.bitacoraBaseDeDatosTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Plantilla_Bonita.ActuarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actuarioComboBox
            // 
            this.actuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bitacoraBaseDeDatosBindingSource, "Actuario", true));
            this.actuarioComboBox.DataSource = this.bitacoraBaseDeDatosBindingSource2;
            this.actuarioComboBox.DisplayMember = "Actuario";
            this.actuarioComboBox.FormattingEnabled = true;
            this.actuarioComboBox.Location = new System.Drawing.Point(32, 45);
            this.actuarioComboBox.Name = "actuarioComboBox";
            this.actuarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.actuarioComboBox.TabIndex = 3;
            this.actuarioComboBox.ValueMember = "Actuario";
            this.actuarioComboBox.SelectedValueChanged += new System.EventHandler(this.actuarioComboBox_SelectedValueChanged);
            // 
            // bitacoraBaseDeDatosBindingSource2
            // 
            this.bitacoraBaseDeDatosBindingSource2.DataMember = "BitacoraBaseDeDatos";
            this.bitacoraBaseDeDatosBindingSource2.DataSource = this.actuarioDataSet;
            // 
            // bitacoraBaseDeDatosBindingSource1
            // 
            this.bitacoraBaseDeDatosBindingSource1.DataMember = "BitacoraBaseDeDatos";
            this.bitacoraBaseDeDatosBindingSource1.DataSource = this.actuarioDataSet;
            // 
            // actuarioDataSetBindingSource
            // 
            this.actuarioDataSetBindingSource.DataSource = this.actuarioDataSet;
            this.actuarioDataSetBindingSource.Position = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(957, 25);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 501);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(actuarioLabel);
            this.Controls.Add(this.actuarioComboBox);
            this.Controls.Add(this.bitacoraBaseDeDatos_VistaDataGridView);
            this.Controls.Add(this.bitacoraBaseDeDatos_VistaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBitacora";
            this.Text = "frmBitacora";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatos_VistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatos_VistaBindingNavigator)).EndInit();
            this.bitacoraBaseDeDatos_VistaBindingNavigator.ResumeLayout(false);
            this.bitacoraBaseDeDatos_VistaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatos_VistaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBaseDeDatosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actuarioDataSetBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BitacoraDataSet bitacoraDataSet;
        private System.Windows.Forms.BindingSource bitacoraBaseDeDatos_VistaBindingSource;
        private BitacoraDataSetTableAdapters.BitacoraBaseDeDatos_VistaTableAdapter bitacoraBaseDeDatos_VistaTableAdapter;
        private BitacoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bitacoraBaseDeDatos_VistaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bitacoraBaseDeDatos_VistaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bitacoraBaseDeDatos_VistaDataGridView;
        private ActuarioDataSet actuarioDataSet;
        private System.Windows.Forms.BindingSource bitacoraBaseDeDatosBindingSource;
        private ActuarioDataSetTableAdapters.BitacoraBaseDeDatosTableAdapter bitacoraBaseDeDatosTableAdapter;
        private ActuarioDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox actuarioComboBox;
        private System.Windows.Forms.BindingSource bitacoraBaseDeDatosBindingSource2;
        private System.Windows.Forms.BindingSource bitacoraBaseDeDatosBindingSource1;
        private System.Windows.Forms.BindingSource actuarioDataSetBindingSource;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}