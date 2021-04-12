namespace WindowsFormsApp1
{
    partial class Form1
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
            this.BTN_TRNSLT = new System.Windows.Forms.Button();
            this.Text_string = new System.Windows.Forms.TextBox();
            this.Label_1 = new System.Windows.Forms.Label();
            this.Label_2 = new System.Windows.Forms.Label();
            this.Text_Numbers = new System.Windows.Forms.TextBox();
            this.Label_3 = new System.Windows.Forms.Label();
            this.Text_Roman = new System.Windows.Forms.TextBox();
            this.Text_errors = new System.Windows.Forms.TextBox();
            this.Label_4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_TRNSLT
            // 
            this.BTN_TRNSLT.Location = new System.Drawing.Point(37, 390);
            this.BTN_TRNSLT.Name = "BTN_TRNSLT";
            this.BTN_TRNSLT.Size = new System.Drawing.Size(75, 23);
            this.BTN_TRNSLT.TabIndex = 0;
            this.BTN_TRNSLT.Text = "Перевести";
            this.BTN_TRNSLT.UseVisualStyleBackColor = true;
            this.BTN_TRNSLT.Click += new System.EventHandler(this.BTN_TRNSLT_Click);
            // 
            // Text_string
            // 
            this.Text_string.Location = new System.Drawing.Point(39, 69);
            this.Text_string.Name = "Text_string";
            this.Text_string.Size = new System.Drawing.Size(316, 20);
            this.Text_string.TabIndex = 1;
            // 
            // Label_1
            // 
            this.Label_1.AutoSize = true;
            this.Label_1.Location = new System.Drawing.Point(36, 53);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(237, 13);
            this.Label_1.TabIndex = 2;
            this.Label_1.Text = "Число текстом на английском языке (0-999):";
            // 
            // Label_2
            // 
            this.Label_2.AutoSize = true;
            this.Label_2.Location = new System.Drawing.Point(36, 108);
            this.Label_2.Name = "Label_2";
            this.Label_2.Size = new System.Drawing.Size(252, 13);
            this.Label_2.TabIndex = 3;
            this.Label_2.Text = "Число, преобразованное в цифровые значения:";
            // 
            // Text_Numbers
            // 
            this.Text_Numbers.Location = new System.Drawing.Point(37, 124);
            this.Text_Numbers.Name = "Text_Numbers";
            this.Text_Numbers.Size = new System.Drawing.Size(318, 20);
            this.Text_Numbers.TabIndex = 4;
            // 
            // Label_3
            // 
            this.Label_3.AutoSize = true;
            this.Label_3.Location = new System.Drawing.Point(36, 166);
            this.Label_3.Name = "Label_3";
            this.Label_3.Size = new System.Drawing.Size(231, 13);
            this.Label_3.TabIndex = 5;
            this.Label_3.Text = "Число, преобразованное в римские цифры:";
            // 
            // Text_Roman
            // 
            this.Text_Roman.Location = new System.Drawing.Point(39, 192);
            this.Text_Roman.Name = "Text_Roman";
            this.Text_Roman.Size = new System.Drawing.Size(316, 20);
            this.Text_Roman.TabIndex = 6;
            // 
            // Text_errors
            // 
            this.Text_errors.Location = new System.Drawing.Point(35, 255);
            this.Text_errors.Multiline = true;
            this.Text_errors.Name = "Text_errors";
            this.Text_errors.Size = new System.Drawing.Size(442, 95);
            this.Text_errors.TabIndex = 7;
            // 
            // Label_4
            // 
            this.Label_4.AutoSize = true;
            this.Label_4.Location = new System.Drawing.Point(36, 229);
            this.Label_4.Name = "Label_4";
            this.Label_4.Size = new System.Drawing.Size(50, 13);
            this.Label_4.TabIndex = 8;
            this.Label_4.Text = "Ошибки:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.Label_4);
            this.Controls.Add(this.Text_errors);
            this.Controls.Add(this.Text_Roman);
            this.Controls.Add(this.Label_3);
            this.Controls.Add(this.Text_Numbers);
            this.Controls.Add(this.Label_2);
            this.Controls.Add(this.Label_1);
            this.Controls.Add(this.Text_string);
            this.Controls.Add(this.BTN_TRNSLT);
            this.Name = "Form1";
            this.Text = "Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_TRNSLT;
        private System.Windows.Forms.TextBox Text_string;
        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.Label Label_2;
        private System.Windows.Forms.TextBox Text_Numbers;
        private System.Windows.Forms.Label Label_3;
        private System.Windows.Forms.TextBox Text_Roman;
        private System.Windows.Forms.TextBox Text_errors;
        private System.Windows.Forms.Label Label_4;
    }
}

