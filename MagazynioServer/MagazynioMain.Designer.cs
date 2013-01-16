namespace MagazynioServer
{
    partial class MagazynioMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.magazynioDataSet = new MagazynioServer.MagazynioDataSet();
            this.productsSaledProducedAvailableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsSaledProducedAvailableTableAdapter = new MagazynioServer.MagazynioDataSetTableAdapters.ProductsSaledProducedAvailableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qProducedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qSaledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSaledProducedAvailableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.qProducedDataGridViewTextBoxColumn,
            this.qSaledDataGridViewTextBoxColumn,
            this.qAvailableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsSaledProducedAvailableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 105);
            this.dataGridView1.TabIndex = 0;
            // 
            // magazynioDataSet
            // 
            this.magazynioDataSet.DataSetName = "MagazynioDataSet";
            this.magazynioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsSaledProducedAvailableBindingSource
            // 
            this.productsSaledProducedAvailableBindingSource.DataMember = "ProductsSaledProducedAvailable";
            this.productsSaledProducedAvailableBindingSource.DataSource = this.magazynioDataSet;
            // 
            // productsSaledProducedAvailableTableAdapter
            // 
            this.productsSaledProducedAvailableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qProducedDataGridViewTextBoxColumn
            // 
            this.qProducedDataGridViewTextBoxColumn.DataPropertyName = "QProduced";
            this.qProducedDataGridViewTextBoxColumn.HeaderText = "QProduced";
            this.qProducedDataGridViewTextBoxColumn.Name = "qProducedDataGridViewTextBoxColumn";
            this.qProducedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qSaledDataGridViewTextBoxColumn
            // 
            this.qSaledDataGridViewTextBoxColumn.DataPropertyName = "QSaled";
            this.qSaledDataGridViewTextBoxColumn.HeaderText = "QSaled";
            this.qSaledDataGridViewTextBoxColumn.Name = "qSaledDataGridViewTextBoxColumn";
            this.qSaledDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qAvailableDataGridViewTextBoxColumn
            // 
            this.qAvailableDataGridViewTextBoxColumn.DataPropertyName = "QAvailable";
            this.qAvailableDataGridViewTextBoxColumn.HeaderText = "QAvailable";
            this.qAvailableDataGridViewTextBoxColumn.Name = "qAvailableDataGridViewTextBoxColumn";
            this.qAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista produktów";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MagazynioMain
            // 
            this.ClientSize = new System.Drawing.Size(994, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MagazynioMain";
            this.Load += new System.EventHandler(this.MagazynioMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSaledProducedAvailableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazynioDataSet magazynioDataSet;
        private System.Windows.Forms.BindingSource productsSaledProducedAvailableBindingSource;
        private MagazynioDataSetTableAdapters.ProductsSaledProducedAvailableTableAdapter productsSaledProducedAvailableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qProducedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qSaledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;


    }
}

