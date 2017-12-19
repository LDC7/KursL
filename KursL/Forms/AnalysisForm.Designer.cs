namespace KursL
{
    partial class AnalysisForm
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
            this.dataGridView_Analys = new System.Windows.Forms.DataGridView();
            this.button_csv = new System.Windows.Forms.Button();
            this.checkBox_Sales = new System.Windows.Forms.CheckBox();
            this.label_Sales = new System.Windows.Forms.Label();
            this.trackBar_Sales = new System.Windows.Forms.TrackBar();
            this.label_Prices = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Analys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.Location = new System.Drawing.Point(957, 528);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // dataGridView_Analys
            // 
            this.dataGridView_Analys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Analys.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Analys.Name = "dataGridView_Analys";
            this.dataGridView_Analys.ReadOnly = true;
            this.dataGridView_Analys.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Analys.Size = new System.Drawing.Size(724, 335);
            this.dataGridView_Analys.TabIndex = 1;
            // 
            // button_csv
            // 
            this.button_csv.Location = new System.Drawing.Point(876, 528);
            this.button_csv.Name = "button_csv";
            this.button_csv.Size = new System.Drawing.Size(75, 23);
            this.button_csv.TabIndex = 2;
            this.button_csv.Text = "CSV";
            this.button_csv.UseVisualStyleBackColor = true;
            this.button_csv.Click += new System.EventHandler(this.button_csv_Click);
            // 
            // checkBox_Sales
            // 
            this.checkBox_Sales.AutoSize = true;
            this.checkBox_Sales.Checked = true;
            this.checkBox_Sales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Sales.Location = new System.Drawing.Point(12, 366);
            this.checkBox_Sales.Name = "checkBox_Sales";
            this.checkBox_Sales.Size = new System.Drawing.Size(81, 17);
            this.checkBox_Sales.TabIndex = 3;
            this.checkBox_Sales.Text = "Случайный";
            this.checkBox_Sales.UseVisualStyleBackColor = true;
            this.checkBox_Sales.CheckedChanged += new System.EventHandler(this.checkBox_Sales_CheckedChanged);
            // 
            // label_Sales
            // 
            this.label_Sales.AutoSize = true;
            this.label_Sales.Location = new System.Drawing.Point(12, 350);
            this.label_Sales.Name = "label_Sales";
            this.label_Sales.Size = new System.Drawing.Size(86, 13);
            this.label_Sales.TabIndex = 4;
            this.label_Sales.Text = "Объём продаж:";
            // 
            // trackBar_Sales
            // 
            this.trackBar_Sales.Enabled = false;
            this.trackBar_Sales.Location = new System.Drawing.Point(12, 389);
            this.trackBar_Sales.Maximum = 100;
            this.trackBar_Sales.Name = "trackBar_Sales";
            this.trackBar_Sales.Size = new System.Drawing.Size(300, 45);
            this.trackBar_Sales.TabIndex = 5;
            this.trackBar_Sales.Scroll += new System.EventHandler(this.trackBar_Sales_Scroll);
            // 
            // label_Prices
            // 
            this.label_Prices.AutoSize = true;
            this.label_Prices.Location = new System.Drawing.Point(325, 350);
            this.label_Prices.Name = "label_Prices";
            this.label_Prices.Size = new System.Drawing.Size(38, 13);
            this.label_Prices.TabIndex = 6;
            this.label_Prices.Text = "Цены:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(328, 389);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = -50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(300, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 563);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label_Prices);
            this.Controls.Add(this.trackBar_Sales);
            this.Controls.Add(this.label_Sales);
            this.Controls.Add(this.checkBox_Sales);
            this.Controls.Add(this.button_csv);
            this.Controls.Add(this.dataGridView_Analys);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AnalysisForm";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Analys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DataGridView dataGridView_Analys;
        private System.Windows.Forms.Button button_csv;
        private System.Windows.Forms.CheckBox checkBox_Sales;
        private System.Windows.Forms.Label label_Sales;
        private System.Windows.Forms.TrackBar trackBar_Sales;
        private System.Windows.Forms.Label label_Prices;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}