namespace SGA_ITSL.UI.FormasABC.Altas
{
    partial class AltaAulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAulas));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.edificiosDataSet = new SGA_ITSL.DataSets.EdificiosDataSet();
            this.edificiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edificiosTableAdapter = new SGA_ITSL.DataSets.EdificiosDataSetTableAdapters.EdificiosTableAdapter();
            this.tableAdapterManager = new SGA_ITSL.DataSets.EdificiosDataSetTableAdapters.TableAdapterManager();
            this.edificiosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.edificiosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoEdificioComboBox = new System.Windows.Forms.ComboBox();
            this.edificiosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            codigoEdificioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingNavigator)).BeginInit();
            this.edificiosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoEdificioLabel
            // 
            codigoEdificioLabel.AutoSize = true;
            codigoEdificioLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            codigoEdificioLabel.Location = new System.Drawing.Point(14, 168);
            codigoEdificioLabel.Name = "codigoEdificioLabel";
            codigoEdificioLabel.Size = new System.Drawing.Size(65, 25);
            codigoEdificioLabel.TabIndex = 22;
            codigoEdificioLabel.Text = "Edificio:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(183, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 38);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 26;
            this.btnCerrar.Location = new System.Drawing.Point(266, 41);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 26);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 40);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(18, 145);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(249, 20);
            this.txtDescripcion.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo del Aula:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(19, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(248, 20);
            this.txtCodigo.TabIndex = 15;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EdificiosTableAdapter = this.edificiosTableAdapter;
            this.tableAdapterManager.UpdateOrder = SGA_ITSL.DataSets.EdificiosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // edificiosBindingNavigator
            // 
            this.edificiosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.edificiosBindingNavigator.BindingSource = this.edificiosBindingSource;
            this.edificiosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.edificiosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.edificiosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.edificiosBindingNavigatorSaveItem});
            this.edificiosBindingNavigator.Location = new System.Drawing.Point(0, 40);
            this.edificiosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.edificiosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.edificiosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.edificiosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.edificiosBindingNavigator.Name = "edificiosBindingNavigator";
            this.edificiosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.edificiosBindingNavigator.Size = new System.Drawing.Size(753, 25);
            this.edificiosBindingNavigator.TabIndex = 22;
            this.edificiosBindingNavigator.Text = "bindingNavigator1";
            this.edificiosBindingNavigator.Visible = false;
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
            // edificiosBindingNavigatorSaveItem
            // 
            this.edificiosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edificiosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("edificiosBindingNavigatorSaveItem.Image")));
            this.edificiosBindingNavigatorSaveItem.Name = "edificiosBindingNavigatorSaveItem";
            this.edificiosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.edificiosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.edificiosBindingNavigatorSaveItem.Click += new System.EventHandler(this.edificiosBindingNavigatorSaveItem_Click);
            // 
            // codigoEdificioComboBox
            // 
            this.codigoEdificioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.edificiosBindingSource, "CodigoEdificio", true));
            this.codigoEdificioComboBox.DataSource = this.edificiosBindingSource1;
            this.codigoEdificioComboBox.DisplayMember = "CodigoEdificio";
            this.codigoEdificioComboBox.FormattingEnabled = true;
            this.codigoEdificioComboBox.Location = new System.Drawing.Point(18, 200);
            this.codigoEdificioComboBox.Name = "codigoEdificioComboBox";
            this.codigoEdificioComboBox.Size = new System.Drawing.Size(121, 21);
            this.codigoEdificioComboBox.TabIndex = 23;
            this.codigoEdificioComboBox.ValueMember = "CodigoEdificio";
            // 
            // edificiosBindingSource1
            // 
            this.edificiosBindingSource1.DataMember = "Edificios";
            this.edificiosBindingSource1.DataSource = this.edificiosDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.codigoEdificioComboBox);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(codigoEdificioLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 245);
            this.panel1.TabIndex = 20;
            // 
            // AltaAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 245);
            this.Controls.Add(this.edificiosBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaAulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AltaAulas";
            this.Load += new System.EventHandler(this.AltaAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingNavigator)).EndInit();
            this.edificiosBindingNavigator.ResumeLayout(false);
            this.edificiosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private DataSets.EdificiosDataSet edificiosDataSet;
        private System.Windows.Forms.BindingSource edificiosBindingSource;
        private DataSets.EdificiosDataSetTableAdapters.EdificiosTableAdapter edificiosTableAdapter;
        private DataSets.EdificiosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator edificiosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton edificiosBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox codigoEdificioComboBox;
        private System.Windows.Forms.BindingSource edificiosBindingSource1;
        private System.Windows.Forms.Panel panel1;
    }
}