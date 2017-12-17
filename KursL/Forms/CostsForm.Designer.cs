namespace KursL
{
    partial class CostsForm
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
            this.textBox_Start = new System.Windows.Forms.TextBox();
            this.textBox_End = new System.Windows.Forms.TextBox();
            this.dataGridView_Cost = new System.Windows.Forms.DataGridView();
            this.button_Accept = new System.Windows.Forms.Button();
            this.NameProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Monthly = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cost)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.Location = new System.Drawing.Point(503, 283);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Отмена";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(503, 12);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(503, 254);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(12, 257);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(170, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Start
            // 
            this.textBox_Start.Location = new System.Drawing.Point(188, 257);
            this.textBox_Start.Name = "textBox_Start";
            this.textBox_Start.Size = new System.Drawing.Size(100, 20);
            this.textBox_Start.TabIndex = 5;
            // 
            // textBox_End
            // 
            this.textBox_End.Location = new System.Drawing.Point(294, 257);
            this.textBox_End.Name = "textBox_End";
            this.textBox_End.Size = new System.Drawing.Size(100, 20);
            this.textBox_End.TabIndex = 7;
            // 
            // dataGridView_Cost
            // 
            this.dataGridView_Cost.AllowUserToAddRows = false;
            this.dataGridView_Cost.AllowUserToDeleteRows = false;
            this.dataGridView_Cost.AllowUserToResizeColumns = false;
            this.dataGridView_Cost.AllowUserToResizeRows = false;
            this.dataGridView_Cost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProf,
            this.Num,
            this.Salary,
            this.Cost});
            this.dataGridView_Cost.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Cost.Name = "dataGridView_Cost";
            this.dataGridView_Cost.ReadOnly = true;
            this.dataGridView_Cost.RowHeadersVisible = false;
            this.dataGridView_Cost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cost.Size = new System.Drawing.Size(485, 239);
            this.dataGridView_Cost.TabIndex = 8;
            // 
            // button_Accept
            // 
            this.button_Accept.Location = new System.Drawing.Point(422, 283);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(75, 23);
            this.button_Accept.TabIndex = 9;
            this.button_Accept.Text = "Принять";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // NameProf
            // 
            this.NameProf.HeaderText = "Название";
            this.NameProf.Name = "NameProf";
            this.NameProf.ReadOnly = true;
            this.NameProf.Width = 173;
            // 
            // Num
            // 
            this.Num.HeaderText = "Начало";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 103;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Конец";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 103;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Ежемесячно";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 103;
            // 
            // textBox_Monthly
            // 
            this.textBox_Monthly.Location = new System.Drawing.Point(400, 257);
            this.textBox_Monthly.Name = "textBox_Monthly";
            this.textBox_Monthly.Size = new System.Drawing.Size(97, 20);
            this.textBox_Monthly.TabIndex = 10;
            // 
            // CostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 318);
            this.Controls.Add(this.textBox_Monthly);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.dataGridView_Cost);
            this.Controls.Add(this.textBox_End);
            this.Controls.Add(this.textBox_Start);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CostsForm";
            this.Text = "Издержки";
            this.Load += new System.EventHandler(this.CostsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Start;
        private System.Windows.Forms.TextBox textBox_End;
        private System.Windows.Forms.DataGridView dataGridView_Cost;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.TextBox textBox_Monthly;
    }
}