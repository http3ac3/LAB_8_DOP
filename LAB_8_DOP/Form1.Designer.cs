
namespace LAB_8_DOP
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
            this.OpenTextTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyWordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BiasTB = new System.Windows.Forms.NumericUpDown();
            this.CipherButton = new System.Windows.Forms.Button();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.AnswerTB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BiasTB)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenTextTB
            // 
            this.OpenTextTB.Location = new System.Drawing.Point(134, 6);
            this.OpenTextTB.Name = "OpenTextTB";
            this.OpenTextTB.Size = new System.Drawing.Size(380, 22);
            this.OpenTextTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Открытый текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сдвиг";
            // 
            // KeyWordTB
            // 
            this.KeyWordTB.Location = new System.Drawing.Point(134, 38);
            this.KeyWordTB.Name = "KeyWordTB";
            this.KeyWordTB.Size = new System.Drawing.Size(380, 22);
            this.KeyWordTB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ключевое слово";
            // 
            // BiasTB
            // 
            this.BiasTB.Location = new System.Drawing.Point(134, 70);
            this.BiasTB.Name = "BiasTB";
            this.BiasTB.Size = new System.Drawing.Size(66, 22);
            this.BiasTB.TabIndex = 3;
            // 
            // CipherButton
            // 
            this.CipherButton.Location = new System.Drawing.Point(15, 110);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(247, 31);
            this.CipherButton.TabIndex = 4;
            this.CipherButton.Text = "Зашифровать";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // DecipherButton
            // 
            this.DecipherButton.Location = new System.Drawing.Point(268, 110);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(246, 31);
            this.DecipherButton.TabIndex = 4;
            this.DecipherButton.Text = "Расшифровать";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // AnswerTB
            // 
            this.AnswerTB.Location = new System.Drawing.Point(15, 147);
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.Size = new System.Drawing.Size(499, 223);
            this.AnswerTB.TabIndex = 5;
            this.AnswerTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 379);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.DecipherButton);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.BiasTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyWordTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenTextTB);
            this.Name = "Form1";
            this.Text = "Заплаткин Юрий, Лаб 8_1";
            ((System.ComponentModel.ISupportInitialize)(this.BiasTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OpenTextTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyWordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BiasTB;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.RichTextBox AnswerTB;
    }
}

