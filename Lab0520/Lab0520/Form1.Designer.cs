
namespace Lab0520
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDimCurrency = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.dgvDemo = new System.Windows.Forms.DataGridView();
            this.adventureWorksDWDataSet = new Lab0520.AdventureWorksDWDataSet();
            this.dimCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dimCurrencyTableAdapter = new Lab0520.AdventureWorksDWDataSetTableAdapters.DimCurrencyTableAdapter();
            this.currencyKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyAlternateKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDimCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimCurrencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDimCurrency
            // 
            this.dgvDimCurrency.AllowUserToAddRows = false;
            this.dgvDimCurrency.AutoGenerateColumns = false;
            this.dgvDimCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDimCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyKeyDataGridViewTextBoxColumn,
            this.currencyAlternateKeyDataGridViewTextBoxColumn,
            this.currencyNameDataGridViewTextBoxColumn});
            this.dgvDimCurrency.DataSource = this.dimCurrencyBindingSource;
            this.dgvDimCurrency.Location = new System.Drawing.Point(47, 101);
            this.dgvDimCurrency.Name = "dgvDimCurrency";
            this.dgvDimCurrency.RowTemplate.Height = 24;
            this.dgvDimCurrency.Size = new System.Drawing.Size(314, 318);
            this.dgvDimCurrency.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "精靈產生的↓";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(594, 55);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "自己帶資料";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // dgvDemo
            // 
            this.dgvDemo.AllowUserToAddRows = false;
            this.dgvDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemo.Location = new System.Drawing.Point(426, 101);
            this.dgvDemo.Name = "dgvDemo";
            this.dgvDemo.RowTemplate.Height = 24;
            this.dgvDemo.Size = new System.Drawing.Size(314, 318);
            this.dgvDemo.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDemo);
            this.Controls.Add(this.dgvDimCurrency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDimCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimCurrencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDimCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.DataGridView dgvDemo;
        private AdventureWorksDWDataSet adventureWorksDWDataSet;
        private System.Windows.Forms.BindingSource dimCurrencyBindingSource;
        private AdventureWorksDWDataSetTableAdapters.DimCurrencyTableAdapter dimCurrencyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyAlternateKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyNameDataGridViewTextBoxColumn;
    }
}

