
namespace Lab0519
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnGetCtrl = new System.Windows.Forms.Button();
            this.lsItem = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Apple",
            "Bee",
            "Cat"});
            this.comboBox1.Location = new System.Drawing.Point(573, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(461, 66);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "增加cbx";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            this.btnAddItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // btnGetCtrl
            // 
            this.btnGetCtrl.Location = new System.Drawing.Point(328, 124);
            this.btnGetCtrl.Name = "btnGetCtrl";
            this.btnGetCtrl.Size = new System.Drawing.Size(110, 23);
            this.btnGetCtrl.TabIndex = 2;
            this.btnGetCtrl.Text = "取得表單控制元件";
            this.btnGetCtrl.UseVisualStyleBackColor = true;
            this.btnGetCtrl.Click += new System.EventHandler(this.btnGetCtrl_Click);
            // 
            // lsItem
            // 
            this.lsItem.FormattingEnabled = true;
            this.lsItem.ItemHeight = 12;
            this.lsItem.Items.AddRange(new object[] {
            "ls"});
            this.lsItem.Location = new System.Drawing.Point(461, 124);
            this.lsItem.Name = "lsItem";
            this.lsItem.Size = new System.Drawing.Size(120, 88);
            this.lsItem.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsItem);
            this.Controls.Add(this.btnGetCtrl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnGetCtrl;
        private System.Windows.Forms.ListBox lsItem;
    }
}

