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
            this.trackBar_Prices = new System.Windows.Forms.TrackBar();
            this.label_period = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Analys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Prices)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.Location = new System.Drawing.Point(788, 316);
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
            this.dataGridView_Analys.Size = new System.Drawing.Size(850, 239);
            this.dataGridView_Analys.TabIndex = 1;
            // 
            // button_csv
            // 
            this.button_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_csv.Location = new System.Drawing.Point(707, 316);
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
            this.checkBox_Sales.Location = new System.Drawing.Point(12, 281);
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
            this.label_Sales.Location = new System.Drawing.Point(12, 265);
            this.label_Sales.Name = "label_Sales";
            this.label_Sales.Size = new System.Drawing.Size(86, 13);
            this.label_Sales.TabIndex = 4;
            this.label_Sales.Text = "Объём продаж:";
            // 
            // trackBar_Sales
            // 
            this.trackBar_Sales.Enabled = false;
            this.trackBar_Sales.Location = new System.Drawing.Point(12, 304);
            this.trackBar_Sales.Maximum = 100;
            this.trackBar_Sales.Name = "trackBar_Sales";
            this.trackBar_Sales.Size = new System.Drawing.Size(300, 45);
            this.trackBar_Sales.TabIndex = 5;
            this.trackBar_Sales.Scroll += new System.EventHandler(this.trackBar_Sales_Scroll);
            // 
            // label_Prices
            // 
            this.label_Prices.AutoSize = true;
            this.label_Prices.Location = new System.Drawing.Point(325, 282);
            this.label_Prices.Name = "label_Prices";
            this.label_Prices.Size = new System.Drawing.Size(55, 13);
            this.label_Prices.TabIndex = 6;
            this.label_Prices.Text = "Цены: 0%";
            // 
            // trackBar_Prices
            // 
            this.trackBar_Prices.Enabled = false;
            this.trackBar_Prices.Location = new System.Drawing.Point(328, 304);
            this.trackBar_Prices.Maximum = 50;
            this.trackBar_Prices.Minimum = -50;
            this.trackBar_Prices.Name = "trackBar_Prices";
            this.trackBar_Prices.Size = new System.Drawing.Size(300, 45);
            this.trackBar_Prices.TabIndex = 7;
            this.trackBar_Prices.Scroll += new System.EventHandler(this.trackBar_Prices_Scroll);
            // 
            // label_period
            // 
            this.label_period.AutoSize = true;
            this.label_period.Location = new System.Drawing.Point(631, 265);
            this.label_period.Name = "label_period";
            this.label_period.Size = new System.Drawing.Size(0, 13);
            this.label_period.TabIndex = 8;
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 351);
            this.Controls.Add(this.label_period);
            this.Controls.Add(this.trackBar_Prices);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Prices)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar_Prices;
        private System.Windows.Forms.Label label_period;
    }
}