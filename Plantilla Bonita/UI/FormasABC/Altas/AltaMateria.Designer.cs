namespace Plantilla_Bonita.UI.FormasABC.Altas
{
    partial class AltaMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMateria));
            System.Windows.Forms.Label descripcionLabel;
            this.ingenieriasDataSet = new Plantilla_Bonita.DataSets.IngenieriasDataSet();
            this.ingenieriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingenieriasTableAdapter = new Plantilla_Bonita.DataSets.IngenieriasDataSetTableAdapters.IngenieriasTableAdapter();
            this.tableAdapterManager = new Plantilla_Bonita.DataSets.IngenieriasDataSetTableAdapters.TableAdapterManager();
            this.ingenieriasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ingenieriasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descripcionComboBox = new System.Windows.Forms.ComboBox();
            this.ingenieriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numSemestre = new System.Windows.Forms.NumericUpDown();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingNavigator)).BeginInit();
            this.ingenieriasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // ingenieriasDataSet
            // 
            this.ingenieriasDataSet.DataSetName = "IngenieriasDataSet";
            this.ingenieriasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingenieriasBindingSource
            // 
            this.ingenieriasBindingSource.DataMember = "Ingenierias";
            this.ingenieriasBindingSource.DataSource = this.ingenieriasDataSet;
            // 
            // ingenieriasTableAdapter
            // 
            this.ingenieriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Plantilla_Bonita.DataSets.IngenieriasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ingenieriasBindingNavigator
            // 
            this.ingenieriasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ingenieriasBindingNavigator.BindingSource = this.ingenieriasBindingSource;
            this.ingenieriasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ingenieriasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ingenieriasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ingenieriasBindingNavigatorSaveItem});
            this.ingenieriasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ingenieriasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ingenieriasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ingenieriasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ingenieriasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ingenieriasBindingNavigator.Name = "ingenieriasBindingNavigator";
            this.ingenieriasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ingenieriasBindingNavigator.Size = new System.Drawing.Size(762, 25);
            this.ingenieriasBindingNavigator.TabIndex = 0;
            this.ingenieriasBindingNavigator.Text = "bindingNavigator1";
            this.ingenieriasBindingNavigator.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // ingenieriasBindingNavigatorSaveItem
            // 
            this.ingenieriasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ingenieriasBindingNavigatorSaveItem.Enabled = false;
            this.ingenieriasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ingenieriasBindingNavigatorSaveItem.Image")));
            this.ingenieriasBindingNavigatorSaveItem.Name = "ingenieriasBindingNavigatorSaveItem";
            this.ingenieriasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ingenieriasBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(29, 25);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionComboBox
            // 
            this.descripcionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingenieriasBindingSource, "Descripcion", true));
            this.descripcionComboBox.DataSource = this.ingenieriasBindingSource1;
            this.descripcionComboBox.DisplayMember = "Descripcion";
            this.descripcionComboBox.FormattingEnabled = true;
            this.descripcionComboBox.Location = new System.Drawing.Point(32, 52);
            this.descripcionComboBox.Name = "descripcionComboBox";
            this.descripcionComboBox.Size = new System.Drawing.Size(311, 21);
            this.descripcionComboBox.TabIndex = 2;
            this.descripcionComboBox.ValueMember = "Cod_Ing";
            // 
            // ingenieriasBindingSource1
            // 
            this.ingenieriasBindingSource1.DataMember = "Ingenierias";
            this.ingenieriasBindingSource1.DataSource = this.ingenieriasDataSet;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(62, 143);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(215, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(61, 223);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(308, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de la Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(245, 278);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numSemestre
            // 
            this.numSemestre.Location = new System.Drawing.Point(482, 172);
            this.numSemestre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSemestre.Name = "numSemestre";
            this.numSemestre.Size = new System.Drawing.Size(68, 20);
            this.numSemestre.TabIndex = 8;
            this.numSemestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AltaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 472);
            this.Controls.Add(this.numSemestre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionComboBox);
            this.Controls.Add(this.ingenieriasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaMateria";
            this.Text = "AltaMateria";
            this.Load += new System.EventHandler(this.AltaMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingNavigator)).EndInit();
            this.ingenieriasBindingNavigator.ResumeLayout(false);
            this.ingenieriasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSemestre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.IngenieriasDataSet ingenieriasDataSet;
        private System.Windows.Forms.BindingSource ingenieriasBindingSource;
        private DataSets.IngenieriasDataSetTableAdapters.IngenieriasTableAdapter ingenieriasTableAdapter;
        private DataSets.IngenieriasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ingenieriasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ingenieriasBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox descripcionComboBox;
        private System.Windows.Forms.BindingSource ingenieriasBindingSource1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numSemestre;
    }
}