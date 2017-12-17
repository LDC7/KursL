namespace KursL
{
    partial class CreateProjectForm
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_ProjectName = new System.Windows.Forms.Label();
            this.textBox_ProjectName = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.label_Period = new System.Windows.Forms.Label();
            this.textBox_PeriodStart = new System.Windows.Forms.TextBox();
            this.textBox_PeriodEnd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(269, 119);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_ProjectName
            // 
            this.label_ProjectName.AutoSize = true;
            this.label_ProjectName.Location = new System.Drawing.Point(13, 13);
            this.label_ProjectName.Name = "label_ProjectName";
            this.label_ProjectName.Size = new System.Drawing.Size(104, 13);
            this.label_ProjectName.TabIndex = 1;
            this.label_ProjectName.Text = "Название проекта:";
            // 
            // textBox_ProjectName
            // 
            this.textBox_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ProjectName.Location = new System.Drawing.Point(13, 30);
            this.textBox_ProjectName.Name = "textBox_ProjectName";
            this.textBox_ProjectName.Size = new System.Drawing.Size(330, 23);
            this.textBox_ProjectName.TabIndex = 2;
            // 
            // button_Create
            // 
            this.button_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Create.Location = new System.Drawing.Point(188, 119);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 3;
            this.button_Create.Text = "Создать";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // label_Period
            // 
            this.label_Period.AutoSize = true;
            this.label_Period.Location = new System.Drawing.Point(13, 65);
            this.label_Period.Name = "label_Period";
            this.label_Period.Size = new System.Drawing.Size(48, 13);
            this.label_Period.TabIndex = 4;
            this.label_Period.Text = "Период:";
            // 
            // textBox_PeriodStart
            // 
            this.textBox_PeriodStart.Location = new System.Drawing.Point(13, 81);
            this.textBox_PeriodStart.Name = "textBox_PeriodStart";
            this.textBox_PeriodStart.Size = new System.Drawing.Size(160, 20);
            this.textBox_PeriodStart.TabIndex = 5;
            // 
            // textBox_PeriodEnd
            // 
            this.textBox_PeriodEnd.Location = new System.Drawing.Point(183, 81);
            this.textBox_PeriodEnd.Name = "textBox_PeriodEnd";
            this.textBox_PeriodEnd.Size = new System.Drawing.Size(160, 20);
            this.textBox_PeriodEnd.TabIndex = 6;
            // 
            // CreateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 154);
            this.Controls.Add(this.textBox_PeriodEnd);
            this.Controls.Add(this.textBox_PeriodStart);
            this.Controls.Add(this.label_Period);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_ProjectName);
            this.Controls.Add(this.label_ProjectName);
            this.Controls.Add(this.button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateProjectForm";
            this.Text = "Создать Проект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_ProjectName;
        private System.Windows.Forms.TextBox textBox_ProjectName;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Label label_Period;
        private System.Windows.Forms.TextBox textBox_PeriodStart;
        private System.Windows.Forms.TextBox textBox_PeriodEnd;
    }
}