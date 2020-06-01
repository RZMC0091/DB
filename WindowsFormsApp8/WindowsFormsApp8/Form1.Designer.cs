namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database3DataSet = new WindowsFormsApp8.Database3DataSet();
            this.database3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsTableAdapter = new WindowsFormsApp8.Database3DataSetTableAdapters.ContractsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp8.Database3DataSetTableAdapters.TableAdapterManager();
            this.iDContractsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClientInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfConclusionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // database3DataSet
            // 
            this.database3DataSet.DataSetName = "Database3DataSet";
            this.database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database3DataSetBindingSource
            // 
            this.database3DataSetBindingSource.DataSource = this.database3DataSet;
            this.database3DataSetBindingSource.Position = 0;
            this.database3DataSetBindingSource.CurrentChanged += new System.EventHandler(this.database3DataSetBindingSource_CurrentChanged);
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataMember = "Contracts";
            this.contractsBindingSource.DataSource = this.database3DataSet;
            // 
            // contractsTableAdapter
            // 
            this.contractsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientInfoTableAdapter = null;
            this.tableAdapterManager.ConnectionTableAdapter = null;
            this.tableAdapterManager.ContractsTableAdapter = this.contractsTableAdapter;
            this.tableAdapterManager.JournalTableAdapter = null;
            this.tableAdapterManager.ManagersTableAdapter = null;
            this.tableAdapterManager.NumbTableAdapter = null;
            this.tableAdapterManager.PersonalManagerTableAdapter = null;
            this.tableAdapterManager.ServiceAvailabilityTableAdapter = null;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.TariffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp8.Database3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDContractsDataGridViewTextBoxColumn
            // 
            this.iDContractsDataGridViewTextBoxColumn.DataPropertyName = "ID_Contracts";
            this.iDContractsDataGridViewTextBoxColumn.HeaderText = "ID_Contracts";
            this.iDContractsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDContractsDataGridViewTextBoxColumn.Name = "iDContractsDataGridViewTextBoxColumn";
            this.iDContractsDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDClientInfoDataGridViewTextBoxColumn
            // 
            this.iDClientInfoDataGridViewTextBoxColumn.DataPropertyName = "ID_Client info";
            this.iDClientInfoDataGridViewTextBoxColumn.HeaderText = "ID_Client info";
            this.iDClientInfoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClientInfoDataGridViewTextBoxColumn.Name = "iDClientInfoDataGridViewTextBoxColumn";
            this.iDClientInfoDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "Account number";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "Account number";
            this.accountNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfConclusionDataGridViewTextBoxColumn
            // 
            this.dateOfConclusionDataGridViewTextBoxColumn.DataPropertyName = "Date of conclusion";
            this.dateOfConclusionDataGridViewTextBoxColumn.HeaderText = "Date of conclusion";
            this.dateOfConclusionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfConclusionDataGridViewTextBoxColumn.Name = "dateOfConclusionDataGridViewTextBoxColumn";
            this.dateOfConclusionDataGridViewTextBoxColumn.Width = 125;
            // 
            // contractNumberDataGridViewTextBoxColumn
            // 
            this.contractNumberDataGridViewTextBoxColumn.DataPropertyName = "Contract number";
            this.contractNumberDataGridViewTextBoxColumn.HeaderText = "Contract number";
            this.contractNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractNumberDataGridViewTextBoxColumn.Name = "contractNumberDataGridViewTextBoxColumn";
            this.contractNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractNumberDataGridViewTextBoxColumn,
            this.dateOfConclusionDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.iDClientInfoDataGridViewTextBoxColumn,
            this.iDContractsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource database3DataSetBindingSource;
        private Database3DataSet database3DataSet;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private Database3DataSetTableAdapters.ContractsTableAdapter contractsTableAdapter;
        private Database3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDContractsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfConclusionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

