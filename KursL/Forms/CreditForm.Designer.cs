namespace KursL
{
    partial class CreditForm
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
            this.textBox_Start = new System.Windows.Forms.TextBox();
            this.textBox_End = new System.Windows.Forms.TextBox();
            this.textBox_Percent = new System.Windows.Forms.TextBox();
            this.textBox_Loan = new System.Windows.Forms.TextBox();
            this.button_Accept = new System.Windows.Forms.Button();
            this.dataGridView_Prod = new System.Windows.Forms.DataGridView();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loan = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // textBox_Start
            // 
            this.textBox_Start.Location = new System.Drawing.Point(13, 258);
            this.textBox_Start.Name = "textBox_Start";
            this.textBox_Start.Size = new System.Drawing.Size(120, 20);
            this.textBox_Start.TabIndex = 4;
            // 
            // textBox_End
            // 
            this.textBox_End.Location = new System.Drawing.Point(139, 258);
            this.textBox_End.Name = "textBox_End";
            this.textBox_End.Size = new System.Drawing.Size(120, 20);
            this.textBox_End.TabIndex = 5;
            // 
            // textBox_Percent
            // 
            this.textBox_Percent.Location = new System.Drawing.Point(265, 258);
            this.textBox_Percent.Name = "textBox_Percent";
            this.textBox_Percent.Size = new System.Drawing.Size(60, 20);
            this.textBox_Percent.TabIndex = 6;
            // 
            // textBox_Loan
            // 
            this.textBox_Loan.Location = new System.Drawing.Point(331, 258);
            this.textBox_Loan.Name = "textBox_Loan";
            this.textBox_Loan.Size = new System.Drawing.Size(121, 20);
            this.textBox_Loan.TabIndex = 7;
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
            this.StartDate,
            this.EndDate,
            this.Percent,
            this.Loan});
            this.dataGridView_Prod.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Prod.Name = "dataGridView_Prod";
            this.dataGridView_Prod.ReadOnly = true;
            this.dataGridView_Prod.RowHeadersVisible = false;
            this.dataGridView_Prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Prod.Size = new System.Drawing.Size(440, 239);
            this.dataGridView_Prod.TabIndex = 10;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Начало";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 123;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Конец";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 123;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "Процент";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 63;
            // 
            // Loan
            // 
            this.Loan.HeaderText = "Займ";
            this.Loan.Name = "Loan";
            this.Loan.ReadOnly = true;
            this.Loan.Width = 123;
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 325);
            this.Controls.Add(this.dataGridView_Prod);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.textBox_Loan);
            this.Controls.Add(this.textBox_Percent);
            this.Controls.Add(this.textBox_End);
            this.Controls.Add(this.textBox_Start);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreditForm";
            this.Text = "Продукция";
            this.Load += new System.EventHandler(this.CreditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Start;
        private System.Windows.Forms.TextBox textBox_End;
        private System.Windows.Forms.TextBox textBox_Percent;
        private System.Windows.Forms.TextBox textBox_Loan;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.DataGridView dataGridView_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan;
    }
}