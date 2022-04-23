﻿namespace Plantilla_Bonita
{
    partial class Asistencias
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label materiaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencias));
            this.panelAsistencia = new System.Windows.Forms.Panel();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.materiaComboBox = new System.Windows.Forms.ComboBox();
            this.vista_IngenieriasMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasDataSet = new Plantilla_Bonita.MateriasDataSet();
            this.descripcionComboBox = new System.Windows.Forms.ComboBox();
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
            this.vista_IngenieriasMateriaTableAdapter = new Plantilla_Bonita.MateriasDataSetTableAdapters.Vista_IngenieriasMateriaTableAdapter();
            this.tableAdapterManager1 = new Plantilla_Bonita.MateriasDataSetTableAdapters.TableAdapterManager();
            this.fillByIngenieriaToolStrip = new System.Windows.Forms.ToolStrip();
            this.ingenieriaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ingenieriaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByIngenieriaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            materiaLabel = new System.Windows.Forms.Label();
            this.panelAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista_IngenieriasMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingNavigator)).BeginInit();
            this.ingenieriasBindingNavigator.SuspendLayout();
            this.fillByIngenieriaToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(30, 58);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(55, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Ingeniería";
            // 
            // materiaLabel
            // 
            materiaLabel.AutoSize = true;
            materiaLabel.Location = new System.Drawing.Point(30, 163);
            materiaLabel.Name = "materiaLabel";
            materiaLabel.Size = new System.Drawing.Size(45, 13);
            materiaLabel.TabIndex = 6;
            materiaLabel.Text = "Materia:";
            // 
            // panelAsistencia
            // 
            this.panelAsistencia.BackColor = System.Drawing.Color.White;
            this.panelAsistencia.Controls.Add(this.label2);
            this.panelAsistencia.Controls.Add(this.label1);
            this.panelAsistencia.Controls.Add(this.lblSemestre);
            this.panelAsistencia.Controls.Add(this.dateTimePicker2);
            this.panelAsistencia.Controls.Add(this.dateTimePicker1);
            this.panelAsistencia.Controls.Add(this.cboSemestre);
            this.panelAsistencia.Controls.Add(materiaLabel);
            this.panelAsistencia.Controls.Add(this.materiaComboBox);
            this.panelAsistencia.Controls.Add(descripcionLabel);
            this.panelAsistencia.Controls.Add(this.descripcionComboBox);
            this.panelAsistencia.Controls.Add(this.btnCerrar);
            this.panelAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAsistencia.Location = new System.Drawing.Point(0, 0);
            this.panelAsistencia.Name = "panelAsistencia";
            this.panelAsistencia.Size = new System.Drawing.Size(987, 558);
            this.panelAsistencia.TabIndex = 4;
            // 
            // cboSemestre
            // 
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Items.AddRange(new object[] {
            "1er Semestre",
            "2do Semestre",
            "3er Semestre",
            "4to Semestre",
            "5to Semestre",
            "6to Semestre",
            "7mo Semestre",
            "8vo Semestre",
            "9no Semestre"});
            this.cboSemestre.Location = new System.Drawing.Point(33, 130);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(210, 21);
            this.cboSemestre.TabIndex = 8;
            this.cboSemestre.SelectedValueChanged += new System.EventHandler(this.cboSemestre_SelectedValueChanged);
            // 
            // materiaComboBox
            // 
            this.materiaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vista_IngenieriasMateriaBindingSource, "Materia", true));
            this.materiaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vista_IngenieriasMateriaBindingSource, "Materia", true));
            this.materiaComboBox.DataSource = this.vista_IngenieriasMateriaBindingSource;
            this.materiaComboBox.DisplayMember = "Materia";
            this.materiaComboBox.FormattingEnabled = true;
            this.materiaComboBox.Location = new System.Drawing.Point(33, 179);
            this.materiaComboBox.Name = "materiaComboBox";
            this.materiaComboBox.Size = new System.Drawing.Size(210, 21);
            this.materiaComboBox.TabIndex = 7;
            this.materiaComboBox.ValueMember = "Materia";
            // 
            // vista_IngenieriasMateriaBindingSource
            // 
            this.vista_IngenieriasMateriaBindingSource.DataMember = "Vista_IngenieriasMateria";
            this.vista_IngenieriasMateriaBindingSource.DataSource = this.materiasDataSet;
            // 
            // materiasDataSet
            // 
            this.materiasDataSet.DataSetName = "MateriasDataSet";
            this.materiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descripcionComboBox
            // 
            this.descripcionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingenieriasBindingSource, "Descripcion", true));
            this.descripcionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ingenieriasBindingSource, "Descripcion", true));
            this.descripcionComboBox.DataSource = this.ingenieriasBindingSource;
            this.descripcionComboBox.DisplayMember = "Descripcion";
            this.descripcionComboBox.FormattingEnabled = true;
            this.descripcionComboBox.Location = new System.Drawing.Point(33, 77);
            this.descripcionComboBox.Name = "descripcionComboBox";
            this.descripcionComboBox.Size = new System.Drawing.Size(315, 21);
            this.descripcionComboBox.TabIndex = 6;
            this.descripcionComboBox.ValueMember = "Descripcion";
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
            this.btnCerrar.Location = new System.Drawing.Point(953, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 26);
            this.btnCerrar.TabIndex = 5;
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
            this.ingenieriasBindingNavigator.Size = new System.Drawing.Size(1201, 25);
            this.ingenieriasBindingNavigator.TabIndex = 5;
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
            // vista_IngenieriasMateriaTableAdapter
            // 
            this.vista_IngenieriasMateriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Plantilla_Bonita.MateriasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillByIngenieriaToolStrip
            // 
            this.fillByIngenieriaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingenieriaToolStripLabel,
            this.ingenieriaToolStripTextBox,
            this.fillByIngenieriaToolStripButton});
            this.fillByIngenieriaToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByIngenieriaToolStrip.Name = "fillByIngenieriaToolStrip";
            this.fillByIngenieriaToolStrip.Size = new System.Drawing.Size(1201, 25);
            this.fillByIngenieriaToolStrip.TabIndex = 6;
            this.fillByIngenieriaToolStrip.Text = "fillByIngenieriaToolStrip";
            this.fillByIngenieriaToolStrip.Visible = false;
            // 
            // ingenieriaToolStripLabel
            // 
            this.ingenieriaToolStripLabel.Name = "ingenieriaToolStripLabel";
            this.ingenieriaToolStripLabel.Size = new System.Drawing.Size(62, 22);
            this.ingenieriaToolStripLabel.Text = "Ingenieria:";
            // 
            // ingenieriaToolStripTextBox
            // 
            this.ingenieriaToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ingenieriaToolStripTextBox.Name = "ingenieriaToolStripTextBox";
            this.ingenieriaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByIngenieriaToolStripButton
            // 
            this.fillByIngenieriaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByIngenieriaToolStripButton.Name = "fillByIngenieriaToolStripButton";
            this.fillByIngenieriaToolStripButton.Size = new System.Drawing.Size(91, 22);
            this.fillByIngenieriaToolStripButton.Text = "FillByIngenieria";
            this.fillByIngenieriaToolStripButton.Click += new System.EventHandler(this.fillByIngenieriaToolStripButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(696, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(30, 114);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(51, 13);
            this.lblSemestre.TabIndex = 11;
            this.lblSemestre.Text = "Semestre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fin";
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 558);
            this.Controls.Add(this.fillByIngenieriaToolStrip);
            this.Controls.Add(this.ingenieriasBindingNavigator);
            this.Controls.Add(this.panelAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asistencias";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Asistencias_Load);
            this.panelAsistencia.ResumeLayout(false);
            this.panelAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista_IngenieriasMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingenieriasBindingNavigator)).EndInit();
            this.ingenieriasBindingNavigator.ResumeLayout(false);
            this.ingenieriasBindingNavigator.PerformLayout();
            this.fillByIngenieriaToolStrip.ResumeLayout(false);
            this.fillByIngenieriaToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelAsistencia;
        private System.Windows.Forms.Button btnCerrar;
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
        private System.Windows.Forms.ComboBox descripcionComboBox;
        private MateriasDataSet materiasDataSet;
        private System.Windows.Forms.BindingSource vista_IngenieriasMateriaBindingSource;
        private MateriasDataSetTableAdapters.Vista_IngenieriasMateriaTableAdapter vista_IngenieriasMateriaTableAdapter;
        private MateriasDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox materiaComboBox;
        private System.Windows.Forms.ToolStrip fillByIngenieriaToolStrip;
        private System.Windows.Forms.ToolStripLabel ingenieriaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox ingenieriaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByIngenieriaToolStripButton;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSemestre;
    }
}