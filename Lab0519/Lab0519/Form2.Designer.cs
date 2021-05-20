
namespace Lab0519
{
    partial class Form2
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
            this.adventureWorksDWDataSet = new Lab0519.AdventureWorksDWDataSet();
            this.dimCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dimCurrencyTableAdapter = new Lab0519.AdventureWorksDWDataSetTableAdapters.DimCurrencyTableAdapter();
            this.currencyKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyAlternateKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimCurrencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyKeyDataGridViewTextBoxColumn,
            this.currencyAlternateKeyDataGridViewTextBoxColumn,
            this.currencyNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dimCurrencyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // adventureWorksDWDataSet
            // 
            this.adventureWorksDWDataSet.DataSetName = "AdventureWorksDWDataSet";
            this.adventureWorksDWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dimCurrencyBindingSource
            // 
            this.dimCurrencyBindingSource.DataMember = "DimCurrency";
            this.dimCurrencyBindingSource.DataSource = this.adventureWorksDWDataSet;
            // 
            // dimCurrencyTableAdapter
            // 
            this.dimCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // currencyKeyDataGridViewTextBoxColumn
            // 
            this.currencyKeyDataGridViewTextBoxColumn.DataPropertyName = "CurrencyKey";
            this.currencyKeyDataGridViewTextBoxColumn.HeaderText = "CurrencyKey";
            this.currencyKeyDataGridViewTextBoxColumn.Name = "currencyKeyDataGridViewTextBoxColumn";
            this.currencyKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currencyAlternateKeyDataGridViewTextBoxColumn
            // 
            this.currencyAlternateKeyDataGridViewTextBoxColumn.DataPropertyName = "CurrencyAlternateKey";
            this.currencyAlternateKeyDataGridViewTextBoxColumn.HeaderText = "CurrencyAlternateKey";
            this.currencyAlternateKeyDataGridViewTextBoxColumn.Name = "currencyAlternateKeyDataGridViewTextBoxColumn";
            // 
            // currencyNameDataGridViewTextBoxColumn
            // 
            this.currencyNameDataGridViewTextBoxColumn.DataPropertyName = "CurrencyName";
            this.currencyNameDataGridViewTextBoxColumn.HeaderText = "CurrencyName";
            this.currencyNameDataGridViewTextBoxColumn.Name = "currencyNameDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimCurrencyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdventureWorksDWDataSet adventureWorksDWDataSet;
        private System.Windows.Forms.BindingSource dimCurrencyBindingSource;
        private AdventureWorksDWDataSetTableAdapters.DimCurrencyTableAdapter dimCurrencyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyAlternateKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyNameDataGridViewTextBoxColumn;
    }
}