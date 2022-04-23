
namespace Plantilla_Bonita
{
    partial class Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            this.panelAlumnos = new System.Windows.Forms.Panel();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.vista_AlumnosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vista_AlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosDataSet = new Plantilla_Bonita.AlumnosDataSet();
            this.ingenieriasComboBox = new System.Windows.Forms.ComboBox();
            this.ingenieriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingenieriasDataSet = new Plantilla_Bonita.IngenieriasDataSet();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ingenieriasTableAdapter = new Plantilla_Bonita.IngenieriasDataSetTableAdapters.IngenieriasTableAdapter();
            this.tableAdapterManager = new Plantilla_Bonita.IngenieriasDataSetTableAdapters.TableAdapterManager();
            this.ingenieriasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ingenieriasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vista_AlumnosTableAdapter = new Plantilla_Bonita.AlumnosDataSetTableAdapters.Vista_AlumnosTableAdapter();
            this.tableAdapterManager1 = new Plantilla_Bonita.AlumnosDataSetTableAdapters.TableAdapterManager();
            this.panelAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AlumnosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingNavigator)).BeginInit();
            this.ingenieriasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlumnos
            // 
            this.panelAlumnos.BackColor = System.Drawing.Color.White;
            this.panelAlumnos.Controls.Add(this.txtNombreBusqueda);
            this.panelAlumnos.Controls.Add(this.vista_AlumnosDataGridView);
            this.panelAlumnos.Controls.Add(this.ingenieriasComboBox);
            this.panelAlumnos.Controls.Add(this.btnCerrar);
            this.panelAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlumnos.Location = new System.Drawing.Point(0, 0);
            this.panelAlumnos.Name = "panelAlumnos";
            this.panelAlumnos.Size = new System.Drawing.Size(1228, 558);
            this.panelAlumnos.TabIndex = 0;
            this.panelAlumnos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAlumnos_Paint);
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Location = new System.Drawing.Point(23, 29);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(219, 20);
            this.txtNombreBusqueda.TabIndex = 7;
            this.txtNombreBusqueda.TextChanged += new System.EventHandler(this.txtNombreBusqueda_TextChanged);
            // 
            // vista_AlumnosDataGridView
            // 
            this.vista_AlumnosDataGridView.AutoGenerateColumns = false;
            this.vista_AlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista_AlumnosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.vista_AlumnosDataGridView.DataSource = this.vista_AlumnosBindingSource;
            this.vista_AlumnosDataGridView.Location = new System.Drawing.Point(23, 166);
            this.vista_AlumnosDataGridView.Name = "vista_AlumnosDataGridView";
            this.vista_AlumnosDataGridView.Size = new System.Drawing.Size(743, 220);
            this.vista_AlumnosDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // vista_AlumnosBindingSource
            // 
            this.vista_AlumnosBindingSource.DataMember = "Vista_Alumnos";
            this.vista_AlumnosBindingSource.DataSource = this.alumnosDataSet;
            // 
            // alumnosDataSet
            // 
            this.alumnosDataSet.DataSetName = "AlumnosDataSet";
            this.alumnosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingenieriasComboBox
            // 
            this.ingenieriasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ingenieriasBindingSource, "Descripcion", true));
            this.ingenieriasComboBox.DataSource = this.ingenieriasBindingSource;
            this.ingenieriasComboBox.DisplayMember = "Descripcion";
            this.ingenieriasComboBox.FormattingEnabled = true;
            this.ingenieriasComboBox.Location = new System.Drawing.Point(23, 66);
            this.ingenieriasComboBox.Name = "ingenieriasComboBox";
            this.ingenieriasComboBox.Size = new System.Drawing.Size(451, 21);
            this.ingenieriasComboBox.TabIndex = 6;
            this.ingenieriasComboBox.ValueMember = "Descripcion";
            this.ingenieriasComboBox.SelectedIndexChanged += new System.EventHandler(this.ingenieriasComboBox_SelectedIndexChanged);
            // 
            // ingenieriasBindingSource
            // 
            this.ingenieriasBindingSource.DataMember = "Ingenierias";
            this.ingenieriasBindingSource.DataSource = this.ingenieriasDataSet;
            // 
            // ingenieriasDataSet
            // 
            this.ingenieriasDataSet.DataSetName = "IngenieriasDataSet";
            this.ingenieriasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCerrar.Location = new System.Drawing.Point(1194, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 26);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ingenieriasTableAdapter
            // 
            this.ingenieriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Plantilla_Bonita.IngenieriasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.ingenieriasBindingNavigator.Size = new System.Drawing.Size(1228, 25);
            this.ingenieriasBindingNavigator.TabIndex = 1;
            this.ingenieriasBindingNavigator.Text = "bindingNavigator1";
            this.ingenieriasBindingNavigator.Visible = false;
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
            // ingenieriasBindingNavigatorSaveItem
            // 
            this.ingenieriasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ingenieriasBindingNavigatorSaveItem.Enabled = false;
            this.ingenieriasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ingenieriasBindingNavigatorSaveItem.Image")));
            this.ingenieriasBindingNavigatorSaveItem.Name = "ingenieriasBindingNavigatorSaveItem";
            this.ingenieriasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ingenieriasBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // vista_AlumnosTableAdapter
            // 
            this.vista_AlumnosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Plantilla_Bonita.AlumnosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 558);
            this.Controls.Add(this.ingenieriasBindingNavigator);
            this.Controls.Add(this.panelAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.panelAlumnos.ResumeLayout(false);
            this.panelAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AlumnosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_AlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingNavigator)).EndInit();
            this.ingenieriasBindingNavigator.ResumeLayout(false);
            this.ingenieriasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAlumnos;
        private System.Windows.Forms.Button btnCerrar;
        private IngenieriasDataSet ingenieriaDataSet;
        private IngenieriasDataSet ingenieriasDataSet;
        private System.Windows.Forms.BindingSource ingenieriasBindingSource;
        private IngenieriasDataSetTableAdapters.IngenieriasTableAdapter ingenieriasTableAdapter;
        private IngenieriasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.ComboBox ingenieriasComboBox;
        private AlumnosDataSet alumnosDataSet;
        private System.Windows.Forms.BindingSource vista_AlumnosBindingSource;
        private AlumnosDataSetTableAdapters.Vista_AlumnosTableAdapter vista_AlumnosTableAdapter;
        private AlumnosDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView vista_AlumnosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
    }
}