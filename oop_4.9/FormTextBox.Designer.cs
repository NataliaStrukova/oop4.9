namespace oop_4._9
{
    partial class FormTextBox
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regularExpressionTextBox2 = new oop_4._9.RegularExpressionTextBox();
            this.regularExpressionTextBox1 = new oop_4._9.RegularExpressionTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата в формате ДД.ММ.ГГГГ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слово с заглавной буквы:";
            // 
            // regularExpressionTextBox2
            // 
            this.regularExpressionTextBox2.BackColorError = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.regularExpressionTextBox2.BackColorNormal = System.Drawing.Color.Empty;
            this.regularExpressionTextBox2.ForeColorError = System.Drawing.Color.Empty;
            this.regularExpressionTextBox2.ForeColorNormal = System.Drawing.Color.Empty;
            this.regularExpressionTextBox2.Location = new System.Drawing.Point(21, 100);
            this.regularExpressionTextBox2.Name = "regularExpressionTextBox2";
            this.regularExpressionTextBox2.RegularExoression = "^[А-ЯЁ][а-яё]+$";
            this.regularExpressionTextBox2.Size = new System.Drawing.Size(176, 20);
            this.regularExpressionTextBox2.TabIndex = 1;
            // 
            // regularExpressionTextBox1
            // 
            this.regularExpressionTextBox1.BackColorError = System.Drawing.Color.PeachPuff;
            this.regularExpressionTextBox1.BackColorNormal = System.Drawing.Color.Empty;
            this.regularExpressionTextBox1.ForeColorError = System.Drawing.Color.Red;
            this.regularExpressionTextBox1.ForeColorNormal = System.Drawing.Color.Black;
            this.regularExpressionTextBox1.Location = new System.Drawing.Point(21, 42);
            this.regularExpressionTextBox1.Name = "regularExpressionTextBox1";
            this.regularExpressionTextBox1.RegularExoression = "^(0[1-9]|[12][0-9]|3[01]).(0[1-9]|1[012]).[0-9]{4}$";
            this.regularExpressionTextBox1.Size = new System.Drawing.Size(176, 20);
            this.regularExpressionTextBox1.TabIndex = 0;
            // 
            // FormTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 174);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regularExpressionTextBox2);
            this.Controls.Add(this.regularExpressionTextBox1);
            this.Name = "FormTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegularExpressionTextBox regularExpressionTextBox1;
        private RegularExpressionTextBox regularExpressionTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

