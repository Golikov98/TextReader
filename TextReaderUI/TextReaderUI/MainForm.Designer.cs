namespace TextReaderUI
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
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.DeletePunctuationMarkTextBox = new System.Windows.Forms.TextBox();
            this.DeleteWordsLengthTextBox = new System.Windows.Forms.TextBox();
            this.DeletePunctuationMarkLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeletePunctuationMarkButton = new System.Windows.Forms.Button();
            this.DeleteLongerWordButton = new System.Windows.Forms.Button();
            this.FileTextTextBox = new System.Windows.Forms.TextBox();
            this.FileTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OpenFileButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.Location = new System.Drawing.Point(12, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(350, 40);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveFileButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFileButton.Location = new System.Drawing.Point(438, 12);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(350, 40);
            this.SaveFileButton.TabIndex = 1;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = false;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // DeletePunctuationMarkTextBox
            // 
            this.DeletePunctuationMarkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeletePunctuationMarkTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePunctuationMarkTextBox.Location = new System.Drawing.Point(168, 64);
            this.DeletePunctuationMarkTextBox.Multiline = true;
            this.DeletePunctuationMarkTextBox.Name = "DeletePunctuationMarkTextBox";
            this.DeletePunctuationMarkTextBox.Size = new System.Drawing.Size(103, 23);
            this.DeletePunctuationMarkTextBox.TabIndex = 2;
            // 
            // DeleteWordsLengthTextBox
            // 
            this.DeleteWordsLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteWordsLengthTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteWordsLengthTextBox.Location = new System.Drawing.Point(560, 64);
            this.DeleteWordsLengthTextBox.Multiline = true;
            this.DeleteWordsLengthTextBox.Name = "DeleteWordsLengthTextBox";
            this.DeleteWordsLengthTextBox.Size = new System.Drawing.Size(137, 23);
            this.DeleteWordsLengthTextBox.TabIndex = 3;
            // 
            // DeletePunctuationMarkLabel
            // 
            this.DeletePunctuationMarkLabel.AutoSize = true;
            this.DeletePunctuationMarkLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePunctuationMarkLabel.Location = new System.Drawing.Point(9, 67);
            this.DeletePunctuationMarkLabel.Name = "DeletePunctuationMarkLabel";
            this.DeletePunctuationMarkLabel.Size = new System.Drawing.Size(153, 16);
            this.DeletePunctuationMarkLabel.TabIndex = 4;
            this.DeletePunctuationMarkLabel.Text = "Delete punctuation mark:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(435, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delete longer word:";
            // 
            // DeletePunctuationMarkButton
            // 
            this.DeletePunctuationMarkButton.Location = new System.Drawing.Point(277, 64);
            this.DeletePunctuationMarkButton.Name = "DeletePunctuationMarkButton";
            this.DeletePunctuationMarkButton.Size = new System.Drawing.Size(85, 23);
            this.DeletePunctuationMarkButton.TabIndex = 6;
            this.DeletePunctuationMarkButton.Text = "Delete";
            this.DeletePunctuationMarkButton.UseVisualStyleBackColor = true;
            this.DeletePunctuationMarkButton.Click += new System.EventHandler(this.DeletePunctuationMarkButton_Click);
            // 
            // DeleteLongerWordButton
            // 
            this.DeleteLongerWordButton.Location = new System.Drawing.Point(703, 64);
            this.DeleteLongerWordButton.Name = "DeleteLongerWordButton";
            this.DeleteLongerWordButton.Size = new System.Drawing.Size(85, 23);
            this.DeleteLongerWordButton.TabIndex = 7;
            this.DeleteLongerWordButton.Text = "Delete";
            this.DeleteLongerWordButton.UseVisualStyleBackColor = true;
            this.DeleteLongerWordButton.Click += new System.EventHandler(this.DeleteLongerWordButton_Click);
            // 
            // FileTextTextBox
            // 
            this.FileTextTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FileTextTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileTextTextBox.Location = new System.Drawing.Point(12, 133);
            this.FileTextTextBox.Multiline = true;
            this.FileTextTextBox.Name = "FileTextTextBox";
            this.FileTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileTextTextBox.Size = new System.Drawing.Size(776, 305);
            this.FileTextTextBox.TabIndex = 8;
            // 
            // FileTextLabel
            // 
            this.FileTextLabel.AutoSize = true;
            this.FileTextLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileTextLabel.Location = new System.Drawing.Point(344, 98);
            this.FileTextLabel.Name = "FileTextLabel";
            this.FileTextLabel.Size = new System.Drawing.Size(118, 32);
            this.FileTextLabel.TabIndex = 9;
            this.FileTextLabel.Text = "File text:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileTextLabel);
            this.Controls.Add(this.FileTextTextBox);
            this.Controls.Add(this.DeleteLongerWordButton);
            this.Controls.Add(this.DeletePunctuationMarkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeletePunctuationMarkLabel);
            this.Controls.Add(this.DeleteWordsLengthTextBox);
            this.Controls.Add(this.DeletePunctuationMarkTextBox);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "MainForm";
            this.Text = "TextReader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.TextBox DeletePunctuationMarkTextBox;
        private System.Windows.Forms.TextBox DeleteWordsLengthTextBox;
        private System.Windows.Forms.Label DeletePunctuationMarkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeletePunctuationMarkButton;
        private System.Windows.Forms.Button DeleteLongerWordButton;
        private System.Windows.Forms.TextBox FileTextTextBox;
        private System.Windows.Forms.Label FileTextLabel;
    }
}

