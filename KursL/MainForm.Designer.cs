namespace KursL
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_NewCompany = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.labelCompany = new System.Windows.Forms.Label();
            this.button_Employees = new System.Windows.Forms.Button();
            this.button_Credits = new System.Windows.Forms.Button();
            this.button_Invest = new System.Windows.Forms.Button();
            this.button_Production = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(238, 245);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(100, 30);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_NewCompany
            // 
            this.button_NewCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_NewCompany.Location = new System.Drawing.Point(12, 12);
            this.button_NewCompany.Name = "button_NewCompany";
            this.button_NewCompany.Size = new System.Drawing.Size(100, 30);
            this.button_NewCompany.TabIndex = 1;
            this.button_NewCompany.Text = "Создать";
            this.button_NewCompany.UseVisualStyleBackColor = true;
            this.button_NewCompany.Click += new System.EventHandler(this.button_NewCompany_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(224, 12);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(100, 30);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Load.Location = new System.Drawing.Point(118, 12);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(100, 30);
            this.button_Load.TabIndex = 3;
            this.button_Load.Text = "Загрузить";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.BackColor = System.Drawing.SystemColors.Control;
            this.labelCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompany.Location = new System.Drawing.Point(12, 74);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(94, 22);
            this.labelCompany.TabIndex = 4;
            this.labelCompany.Text = "Компания: ";
            // 
            // button_Employees
            // 
            this.button_Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Employees.Location = new System.Drawing.Point(12, 180);
            this.button_Employees.Name = "button_Employees";
            this.button_Employees.Size = new System.Drawing.Size(100, 30);
            this.button_Employees.TabIndex = 5;
            this.button_Employees.Text = "Сотрудники";
            this.button_Employees.UseVisualStyleBackColor = true;
            this.button_Employees.Click += new System.EventHandler(this.button_Employees_Click);
            // 
            // button_Credits
            // 
            this.button_Credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Credits.Location = new System.Drawing.Point(12, 144);
            this.button_Credits.Name = "button_Credits";
            this.button_Credits.Size = new System.Drawing.Size(100, 30);
            this.button_Credits.TabIndex = 6;
            this.button_Credits.Text = "Кредиты";
            this.button_Credits.UseVisualStyleBackColor = true;
            this.button_Credits.Click += new System.EventHandler(this.button_Credits_Click);
            // 
            // button_Invest
            // 
            this.button_Invest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Invest.Location = new System.Drawing.Point(12, 108);
            this.button_Invest.Name = "button_Invest";
            this.button_Invest.Size = new System.Drawing.Size(100, 30);
            this.button_Invest.TabIndex = 7;
            this.button_Invest.Text = "Инвестиции";
            this.button_Invest.UseVisualStyleBackColor = true;
            this.button_Invest.Click += new System.EventHandler(this.button_Invest_Click);
            // 
            // button_Production
            // 
            this.button_Production.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Production.Location = new System.Drawing.Point(12, 216);
            this.button_Production.Name = "button_Production";
            this.button_Production.Size = new System.Drawing.Size(100, 30);
            this.button_Production.TabIndex = 8;
            this.button_Production.Text = "Продукция";
            this.button_Production.UseVisualStyleBackColor = true;
            this.button_Production.Click += new System.EventHandler(this.button_Production_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 287);
            this.Controls.Add(this.button_Production);
            this.Controls.Add(this.button_Invest);
            this.Controls.Add(this.button_Credits);
            this.Controls.Add(this.button_Employees);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_NewCompany);
            this.Controls.Add(this.button_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_NewCompany;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Button button_Employees;
        private System.Windows.Forms.Button button_Credits;
        private System.Windows.Forms.Button button_Invest;
        private System.Windows.Forms.Button button_Production;
    }
}

