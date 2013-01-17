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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsSaledProducedAvailableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynioDataSet = new MagazynioServer.MagazynioDataSet();
            this.productsSaledProducedAvailableTableAdapter = new MagazynioServer.MagazynioDataSetTableAdapters.ProductsSaledProducedAvailableTableAdapter();
            this.MagazynioTabs = new System.Windows.Forms.TabControl();
            this.ProductListTab = new System.Windows.Forms.TabPage();
            this.ProductManagmentTab = new System.Windows.Forms.TabPage();
            this.ProductListRefresh = new System.Windows.Forms.Button();
            this.ProductionTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSaledProducedAvailableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet)).BeginInit();
            this.MagazynioTabs.SuspendLayout();
            this.ProductListTab.SuspendLayout();
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
            this.qAvailableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsSaledProducedAvailableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 316);
            this.dataGridView1.TabIndex = 0;
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
            // qAvailableDataGridViewTextBoxColumn
            // 
            this.qAvailableDataGridViewTextBoxColumn.DataPropertyName = "QAvailable";
            this.qAvailableDataGridViewTextBoxColumn.HeaderText = "QAvailable";
            this.qAvailableDataGridViewTextBoxColumn.Name = "qAvailableDataGridViewTextBoxColumn";
            this.qAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsSaledProducedAvailableBindingSource
            // 
            this.productsSaledProducedAvailableBindingSource.DataMember = "ProductsSaledProducedAvailable";
            this.productsSaledProducedAvailableBindingSource.DataSource = this.magazynioDataSet;
            // 
            // magazynioDataSet
            // 
            this.magazynioDataSet.DataSetName = "MagazynioDataSet";
            this.magazynioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsSaledProducedAvailableTableAdapter
            // 
            this.productsSaledProducedAvailableTableAdapter.ClearBeforeFill = true;
            // 
            // MagazynioTabs
            // 
            this.MagazynioTabs.Controls.Add(this.ProductListTab);
            this.MagazynioTabs.Controls.Add(this.ProductManagmentTab);
            this.MagazynioTabs.Controls.Add(this.ProductionTab);
            this.MagazynioTabs.Location = new System.Drawing.Point(12, 12);
            this.MagazynioTabs.Name = "MagazynioTabs";
            this.MagazynioTabs.SelectedIndex = 0;
            this.MagazynioTabs.Size = new System.Drawing.Size(566, 387);
            this.MagazynioTabs.TabIndex = 4;
            // 
            // ProductListTab
            // 
            this.ProductListTab.Controls.Add(this.dataGridView1);
            this.ProductListTab.Controls.Add(this.ProductListRefresh);
            this.ProductListTab.Location = new System.Drawing.Point(4, 22);
            this.ProductListTab.Name = "ProductListTab";
            this.ProductListTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductListTab.Size = new System.Drawing.Size(558, 361);
            this.ProductListTab.TabIndex = 0;
            this.ProductListTab.Text = "Lista produktów";
            this.ProductListTab.UseVisualStyleBackColor = true;
            // 
            // ProductManagmentTab
            // 
            this.ProductManagmentTab.Location = new System.Drawing.Point(4, 22);
            this.ProductManagmentTab.Name = "ProductManagmentTab";
            this.ProductManagmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductManagmentTab.Size = new System.Drawing.Size(558, 361);
            this.ProductManagmentTab.TabIndex = 1;
            this.ProductManagmentTab.Text = "Zarządzanie produktami";
            this.ProductManagmentTab.UseVisualStyleBackColor = true;
            // 
            // ProductListRefresh
            // 
            this.ProductListRefresh.Image = global::MagazynioServer.Properties.Resources._1358455773_arrow_circle_double;
            this.ProductListRefresh.Location = new System.Drawing.Point(521, 7);
            this.ProductListRefresh.Name = "ProductListRefresh";
            this.ProductListRefresh.Size = new System.Drawing.Size(28, 25);
            this.ProductListRefresh.TabIndex = 3;
            this.ProductListRefresh.UseCompatibleTextRendering = true;
            this.ProductListRefresh.UseVisualStyleBackColor = true;
            this.ProductListRefresh.Click += new System.EventHandler(this.ProductListRefresh_Click);
            // 
            // ProductionTab
            // 
            this.ProductionTab.Location = new System.Drawing.Point(4, 22);
            this.ProductionTab.Name = "ProductionTab";
            this.ProductionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductionTab.Size = new System.Drawing.Size(558, 361);
            this.ProductionTab.TabIndex = 2;
            this.ProductionTab.Text = "Produkcja";
            this.ProductionTab.UseVisualStyleBackColor = true;
            // 
            // MagazynioMain
            // 
            this.ClientSize = new System.Drawing.Size(590, 412);
            this.Controls.Add(this.MagazynioTabs);
            this.Name = "MagazynioMain";
            this.Text = "Magazynio - Aplikacja dziwna, acz serwerowa (:";
            this.Load += new System.EventHandler(this.MagazynioMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSaledProducedAvailableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet)).EndInit();
            this.MagazynioTabs.ResumeLayout(false);
            this.ProductListTab.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn qAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ProductListRefresh;
        private System.Windows.Forms.TabControl MagazynioTabs;
        private System.Windows.Forms.TabPage ProductListTab;
        private System.Windows.Forms.TabPage ProductManagmentTab;
        private System.Windows.Forms.TabPage ProductionTab;


    }
}

