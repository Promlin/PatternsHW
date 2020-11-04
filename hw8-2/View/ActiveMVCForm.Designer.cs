namespace hw8_2
{
    partial class ActiveMVCForm
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
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonIncrementValue = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(59, 203);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(203, 22);
            this.textBoxValue.TabIndex = 0;
            // 
            // buttonIncrementValue
            // 
            this.buttonIncrementValue.Location = new System.Drawing.Point(301, 203);
            this.buttonIncrementValue.Name = "buttonIncrementValue";
            this.buttonIncrementValue.Size = new System.Drawing.Size(126, 23);
            this.buttonIncrementValue.TabIndex = 1;
            this.buttonIncrementValue.Text = "Add";
            this.buttonIncrementValue.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(59, 56);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(275, 84);
            this.listBox.TabIndex = 2;
            // 
            // ActiveMVCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonIncrementValue);
            this.Controls.Add(this.textBoxValue);
            this.Name = "ActiveMVCForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonIncrementValue;
        private System.Windows.Forms.ListBox listBox;
    }
}

