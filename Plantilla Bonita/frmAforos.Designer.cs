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
            this.pnlContendor = new System.Windows.Forms.Panel();
            this.edificiosDataSet = new Plantilla_Bonita.EdificiosDataSet();
            this.edificiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edificiosTableAdapter = new Plantilla_Bonita.EdificiosDataSetTableAdapters.EdificiosTableAdapter();
            this.tableAdapterManager = new Plantilla_Bonita.EdificiosDataSetTableAdapters.TableAdapterManager();
            this.codigoEdificioComboBox = new System.Windows.Forms.ComboBox();
            this.edificiosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            codigoEdificioLabel = new System.Windows.Forms.Label();
            this.pnlContendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContendor
            // 
            this.pnlContendor.Controls.Add(codigoEdificioLabel);
            this.pnlContendor.Controls.Add(this.codigoEdificioComboBox);
            this.pnlContendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContendor.Location = new System.Drawing.Point(0, 0);
            this.pnlContendor.Name = "pnlContendor";
            this.pnlContendor.Size = new System.Drawing.Size(800, 450);
            this.pnlContendor.TabIndex = 0;
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
            this.tableAdapterManager.UpdateOrder = Plantilla_Bonita.EdificiosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codigoEdificioLabel
            // 
            codigoEdificioLabel.AutoSize = true;
            codigoEdificioLabel.Location = new System.Drawing.Point(172, 150);
            codigoEdificioLabel.Name = "codigoEdificioLabel";
            codigoEdificioLabel.Size = new System.Drawing.Size(80, 13);
            codigoEdificioLabel.TabIndex = 0;
            codigoEdificioLabel.Text = "Codigo Edificio:";
            // 
            // codigoEdificioComboBox
            // 
            this.codigoEdificioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.edificiosBindingSource, "CodigoEdificio", true));
            this.codigoEdificioComboBox.DataSource = this.edificiosBindingSource1;
            this.codigoEdificioComboBox.DisplayMember = "CodigoEdificio";
            this.codigoEdificioComboBox.FormattingEnabled = true;
            this.codigoEdificioComboBox.Location = new System.Drawing.Point(258, 147);
            this.codigoEdificioComboBox.Name = "codigoEdificioComboBox";
            this.codigoEdificioComboBox.Size = new System.Drawing.Size(121, 21);
            this.codigoEdificioComboBox.TabIndex = 1;
            this.codigoEdificioComboBox.ValueMember = "CodigoEdificio";
            // 
            // edificiosBindingSource1
            // 
            this.edificiosBindingSource1.DataMember = "Edificios";
            this.edificiosBindingSource1.DataSource = this.edificiosDataSet;
            // 
            // frmAforos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContendor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAforos";
            this.Text = "frmAforos";
            this.Load += new System.EventHandler(this.frmAforos_Load);
            this.pnlContendor.ResumeLayout(false);
            this.pnlContendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContendor;
        private EdificiosDataSet edificiosDataSet;
        private System.Windows.Forms.BindingSource edificiosBindingSource;
        private EdificiosDataSetTableAdapters.EdificiosTableAdapter edificiosTableAdapter;
        private EdificiosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox codigoEdificioComboBox;
        private System.Windows.Forms.BindingSource edificiosBindingSource1;
    }
}