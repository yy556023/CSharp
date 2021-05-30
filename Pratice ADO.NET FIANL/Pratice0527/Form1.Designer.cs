
namespace Pratice0527
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SELECT = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.INSERT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.TBcb = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GET = new System.Windows.Forms.Button();
            this.DBcb = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TABLE = new System.Windows.Forms.Label();
            this.DB = new System.Windows.Forms.Label();
            this.SCcb = new System.Windows.Forms.ComboBox();
            this.SC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 290);
            this.dataGridView1.TabIndex = 10;
            // 
            // SELECT
            // 
            this.SELECT.Location = new System.Drawing.Point(12, 65);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(75, 23);
            this.SELECT.TabIndex = 3;
            this.SELECT.Text = "SELECT";
            this.SELECT.UseVisualStyleBackColor = true;
            this.SELECT.Click += new System.EventHandler(this.SELECT_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(93, 65);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(75, 23);
            this.UPDATE.TabIndex = 4;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(174, 65);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(75, 23);
            this.INSERT.TabIndex = 5;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(255, 65);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(75, 23);
            this.DELETE.TabIndex = 6;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // TBcb
            // 
            this.TBcb.FormattingEnabled = true;
            this.TBcb.Location = new System.Drawing.Point(367, 67);
            this.TBcb.Name = "TBcb";
            this.TBcb.Size = new System.Drawing.Size(121, 20);
            this.TBcb.TabIndex = 2;
            this.TBcb.SelectionChangeCommitted += new System.EventHandler(this.TBcb_SelectionChangeCommitted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(537, 148);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 290);
            this.textBox1.TabIndex = 11;
            // 
            // GET
            // 
            this.GET.Location = new System.Drawing.Point(766, 65);
            this.GET.Name = "GET";
            this.GET.Size = new System.Drawing.Size(75, 23);
            this.GET.TabIndex = 0;
            this.GET.Text = "GET DATA";
            this.GET.UseVisualStyleBackColor = true;
            this.GET.Click += new System.EventHandler(this.GET_Click);
            // 
            // DBcb
            // 
            this.DBcb.FormattingEnabled = true;
            this.DBcb.Location = new System.Drawing.Point(639, 67);
            this.DBcb.Name = "DBcb";
            this.DBcb.Size = new System.Drawing.Size(121, 20);
            this.DBcb.TabIndex = 1;
            this.DBcb.SelectionChangeCommitted += new System.EventHandler(this.DBcb_SelectionChangeCommitted);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(279, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // TABLE
            // 
            this.TABLE.AutoSize = true;
            this.TABLE.Location = new System.Drawing.Point(365, 47);
            this.TABLE.Name = "TABLE";
            this.TABLE.Size = new System.Drawing.Size(41, 12);
            this.TABLE.TabIndex = 9;
            this.TABLE.Text = "資料表";
            // 
            // DB
            // 
            this.DB.AutoSize = true;
            this.DB.Location = new System.Drawing.Point(637, 47);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(41, 12);
            this.DB.TabIndex = 9;
            this.DB.Text = "資料庫";
            // 
            // SCcb
            // 
            this.SCcb.FormattingEnabled = true;
            this.SCcb.Location = new System.Drawing.Point(503, 67);
            this.SCcb.Name = "SCcb";
            this.SCcb.Size = new System.Drawing.Size(121, 20);
            this.SCcb.TabIndex = 2;
            this.SCcb.SelectionChangeCommitted += new System.EventHandler(this.SCcb_SelectionChangeCommitted);
            // 
            // SC
            // 
            this.SC.AutoSize = true;
            this.SC.Location = new System.Drawing.Point(501, 47);
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(29, 12);
            this.SC.TabIndex = 9;
            this.SC.Text = "結構";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.DB);
            this.Controls.Add(this.SC);
            this.Controls.Add(this.TABLE);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.GET);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DBcb);
            this.Controls.Add(this.SCcb);
            this.Controls.Add(this.TBcb);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.SELECT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SELECT;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.ComboBox TBcb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GET;
        private System.Windows.Forms.ComboBox DBcb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label TABLE;
        private System.Windows.Forms.Label DB;
        private System.Windows.Forms.ComboBox SCcb;
        private System.Windows.Forms.Label SC;
    }
}

