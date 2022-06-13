
namespace SGA_ITSL
{
    partial class Docentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docentes));
            this.panelDocentes = new System.Windows.Forms.Panel();
            this.vista_DocentesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vista_DocentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docentesDataSet = new SGA_ITSL.DataSets.DocentesDataSet();
            this.vista_DocentesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vista_DocentesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vista_DocentesTableAdapter = new SGA_ITSL.DataSets.DocentesDataSetTableAdapters.Vista_DocentesTableAdapter();
            this.tableAdapterManager = new SGA_ITSL.DataSets.DocentesDataSetTableAdapters.TableAdapterManager();
            this.panelDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista_DocentesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_DocentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_DocentesBindingNavigator)).BeginInit();
            this.vista_DocentesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDocentes
            // 
            this.panelDocentes.BackColor = System.Drawing.Color.White;
            this.panelDocentes.Controls.Add(this.vista_DocentesDataGridView);
            this.panelDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDocentes.Location = new System.Drawing.Point(0, 0);
            this.panelDocentes.Name = "panelDocentes";
            this.panelDocentes.Size = new System.Drawing.Size(757, 558);
            this.panelDocentes.TabIndex = 0;
            // 
            // vista_DocentesDataGridView
            // 
            this.vista_DocentesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vista_DocentesDataGridView.AutoGenerateColumns = false;
            this.vista_DocentesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista_DocentesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.vista_DocentesDataGridView.DataSource = this.vista_DocentesBindingSource;
            this.vista_DocentesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vista_DocentesDataGridView.Name = "vista_DocentesDataGridView";
            this.vista_DocentesDataGridView.Size = new System.Drawing.Size(733, 534);
            this.vista_DocentesDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Identificador";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // vista_DocentesBindingSource
            // 
            this.vista_DocentesBindingSource.DataMember = "Vista_Docentes";
            this.vista_DocentesBindingSource.DataSource = this.docentesDataSet;
            // 
            // docentesDataSet
            // 
            this.docentesDataSet.DataSetName = "DocentesDataSet";
            this.docentesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_DocentesBindingNavigator
            // 
            this.vista_DocentesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vista_DocentesBindingNavigator.BindingSource = this.vista_DocentesBindingSource;
            this.vista_DocentesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vista_DocentesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vista_DocentesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vista_DocentesBindingNavigatorSaveItem});
            this.vista_DocentesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vista_DocentesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vista_DocentesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vista_DocentesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vista_DocentesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vista_DocentesBindingNavigator.Name = "vista_DocentesBindingNavigator";
            this.vista_DocentesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vista_DocentesBindingNavigator.Size = new System.Drawing.Size(1129, 25);
            this.vista_DocentesBindingNavigator.TabIndex = 1;
            this.vista_DocentesBindingNavigator.Text = "bindingNavigator1";
            this.vista_DocentesBindingNavigator.Visible = false;
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
            // vista_DocentesBindingNavigatorSaveItem
            // 
            this.vista_DocentesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vista_DocentesBindingNavigatorSaveItem.Enabled = false;
            this.vista_DocentesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vista_DocentesBindingNavigatorSaveItem.Image")));
            this.vista_DocentesBindingNavigatorSaveItem.Name = "vista_DocentesBindingNavigatorSaveItem";
            this.vista_DocentesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vista_DocentesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // vista_DocentesTableAdapter
            // 
            this.vista_DocentesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SGA_ITSL.DataSets.DocentesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 558);
            this.Controls.Add(this.vista_DocentesBindingNavigator);
            this.Controls.Add(this.panelDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Docentes";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.Docentes_Load);
            this.panelDocentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vista_DocentesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_DocentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_DocentesBindingNavigator)).EndInit();
            this.vista_DocentesBindingNavigator.ResumeLayout(false);
            this.vista_DocentesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDocentes;
        private DataSets.DocentesDataSet docentesDataSet;
        private System.Windows.Forms.BindingSource vista_DocentesBindingSource;
        private DataSets.DocentesDataSetTableAdapters.Vista_DocentesTableAdapter vista_DocentesTableAdapter;
        private DataSets.DocentesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vista_DocentesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vista_DocentesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vista_DocentesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}