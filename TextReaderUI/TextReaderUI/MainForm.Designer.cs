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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.FileTextTextBox = new System.Windows.Forms.TextBox();
            this.TextReaderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePunctuationMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeShorterLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTextButton = new System.Windows.Forms.Button();
            this.TextReaderMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenFileButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.Location = new System.Drawing.Point(12, 383);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(55, 55);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFileButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFileButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SaveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileButton.Image")));
            this.SaveFileButton.Location = new System.Drawing.Point(733, 383);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(55, 55);
            this.SaveFileButton.TabIndex = 1;
            this.SaveFileButton.UseVisualStyleBackColor = false;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // FileTextTextBox
            // 
            this.FileTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileTextTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FileTextTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileTextTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileTextTextBox.Location = new System.Drawing.Point(0, 27);
            this.FileTextTextBox.Multiline = true;
            this.FileTextTextBox.Name = "FileTextTextBox";
            this.FileTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileTextTextBox.Size = new System.Drawing.Size(800, 300);
            this.FileTextTextBox.TabIndex = 8;
            // 
            // TextReaderMenuStrip
            // 
            this.TextReaderMenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TextReaderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.TextReaderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TextReaderMenuStrip.Name = "TextReaderMenuStrip";
            this.TextReaderMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.TextReaderMenuStrip.TabIndex = 10;
            this.TextReaderMenuStrip.Text = "TextReaderMenuStrip";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.OpenFolderToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fToolStripMenuItem.Text = "File";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.OpenFileToolStripMenuItem.Text = "Open file";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // OpenFolderToolStripMenuItem
            // 
            this.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem";
            this.OpenFolderToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.OpenFolderToolStripMenuItem.Text = "Open folder";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.SaveAsToolStripMenuItem.Text = "Save as";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removePunctuationMarksToolStripMenuItem,
            this.removeShorterLengthToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removePunctuationMarksToolStripMenuItem
            // 
            this.removePunctuationMarksToolStripMenuItem.Name = "removePunctuationMarksToolStripMenuItem";
            this.removePunctuationMarksToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.removePunctuationMarksToolStripMenuItem.Text = "Remove punctuation marks";
            // 
            // removeShorterLengthToolStripMenuItem
            // 
            this.removeShorterLengthToolStripMenuItem.Name = "removeShorterLengthToolStripMenuItem";
            this.removeShorterLengthToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.removeShorterLengthToolStripMenuItem.Text = "Remove shorter length";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.informationToolStripMenuItem.Text = "Information - F1";
            // 
            // EditTextButton
            // 
            this.EditTextButton.BackColor = System.Drawing.SystemColors.Info;
            this.EditTextButton.Location = new System.Drawing.Point(0, 333);
            this.EditTextButton.Name = "EditTextButton";
            this.EditTextButton.Size = new System.Drawing.Size(800, 23);
            this.EditTextButton.TabIndex = 11;
            this.EditTextButton.Text = "Edit text";
            this.EditTextButton.UseVisualStyleBackColor = false;
            this.EditTextButton.Click += new System.EventHandler(this.EditTextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditTextButton);
            this.Controls.Add(this.FileTextTextBox);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.TextReaderMenuStrip);
            this.MainMenuStrip = this.TextReaderMenuStrip;
            this.Name = "MainForm";
            this.Text = "TextReader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TextReaderMenuStrip.ResumeLayout(false);
            this.TextReaderMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.TextBox FileTextTextBox;
        private System.Windows.Forms.MenuStrip TextReaderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePunctuationMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeShorterLengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Button EditTextButton;
    }
}

