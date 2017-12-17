namespace KursL
{
    partial class ProductionForm
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
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Min = new System.Windows.Forms.TextBox();
            this.textBox_Max = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.button_Accept = new System.Windows.Forms.Button();
            this.dataGridView_Prod = new System.Windows.Forms.DataGridView();
            this.NameProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prod)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.Location = new System.Drawing.Point(459, 290);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Отменить";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(459, 13);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(459, 256);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(13, 258);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Min
            // 
            this.textBox_Min.Location = new System.Drawing.Point(221, 258);
            this.textBox_Min.Name = "textBox_Min";
            this.textBox_Min.Size = new System.Drawing.Size(60, 20);
            this.textBox_Min.TabIndex = 5;
            // 
            // textBox_Max
            // 
            this.textBox_Max.Location = new System.Drawing.Point(287, 258);
            this.textBox_Max.Name = "textBox_Max";
            this.textBox_Max.Size = new System.Drawing.Size(60, 20);
            this.textBox_Max.TabIndex = 6;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(353, 258);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price.TabIndex = 7;
            // 
            // button_Accept
            // 
            this.button_Accept.Location = new System.Drawing.Point(378, 290);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(75, 23);
            this.button_Accept.TabIndex = 9;
            this.button_Accept.Text = "Принять";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // dataGridView_Prod
            // 
            this.dataGridView_Prod.AllowUserToAddRows = false;
            this.dataGridView_Prod.AllowUserToDeleteRows = false;
            this.dataGridView_Prod.AllowUserToResizeColumns = false;
            this.dataGridView_Prod.AllowUserToResizeRows = false;
            this.dataGridView_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProd,
            this.Min_num,
            this.Max_num,
            this.Price});
            this.dataGridView_Prod.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Prod.Name = "dataGridView_Prod";
            this.dataGridView_Prod.ReadOnly = true;
            this.dataGridView_Prod.RowHeadersVisible = false;
            this.dataGridView_Prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Prod.Size = new System.Drawing.Size(440, 239);
            this.dataGridView_Prod.TabIndex = 10;
            // 
            // NameProd
            // 
            this.NameProd.HeaderText = "Название";
            this.NameProd.Name = "NameProd";
            this.NameProd.ReadOnly = true;
            this.NameProd.Width = 203;
            // 
            // Min_num
            // 
            this.Min_num.HeaderText = "Мин.";
            this.Min_num.Name = "Min_num";
            this.Min_num.ReadOnly = true;
            this.Min_num.Width = 63;
            // 
            // Max_num
            // 
            this.Max_num.HeaderText = "Макс.";
            this.Max_num.Name = "Max_num";
            this.Max_num.ReadOnly = true;
            this.Max_num.Width = 63;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 103;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 325);
            this.Controls.Add(this.dataGridView_Prod);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Max);
            this.Controls.Add(this.textBox_Min);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProductionForm";
            this.Text = "Продукция";
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Min;
        private System.Windows.Forms.TextBox textBox_Max;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.DataGridView dataGridView_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}