namespace TextReaderUI
{
    partial class EditTextForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancleButton = new System.Windows.Forms.Button();
            this.DeleteSymbolMarkLabel = new System.Windows.Forms.Label();
            this.FullStopCheckBox = new System.Windows.Forms.CheckBox();
            this.CommaCheckBox = new System.Windows.Forms.CheckBox();
            this.SemiColonCheckBox = new System.Windows.Forms.CheckBox();
            this.ColonCheckBox = new System.Windows.Forms.CheckBox();
            this.HyphenCheckBox = new System.Windows.Forms.CheckBox();
            this.QuestionMarkCheckBox = new System.Windows.Forms.CheckBox();
            this.ExclamationMarkCheckBox = new System.Windows.Forms.CheckBox();
            this.ParenthesisCheckBox = new System.Windows.Forms.CheckBox();
            this.SquareBrecketCheckBox = new System.Windows.Forms.CheckBox();
            this.BraceCheckBox = new System.Windows.Forms.CheckBox();
            this.AngleBracketCheckBox = new System.Windows.Forms.CheckBox();
            this.QuotationMarkCheckBox = new System.Windows.Forms.CheckBox();
            this.AsteriskCheckBox = new System.Windows.Forms.CheckBox();
            this.AmpersandCheckBox = new System.Windows.Forms.CheckBox();
            this.TildeCheckBox = new System.Windows.Forms.CheckBox();
            this.VirguleCheckBox = new System.Windows.Forms.CheckBox();
            this.HashCheckBox = new System.Windows.Forms.CheckBox();
            this.AtCheckBox = new System.Windows.Forms.CheckBox();
            this.MinimumWordLengthLabel = new System.Windows.Forms.Label();
            this.MinimumWordLengthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OKButton.Location = new System.Drawing.Point(12, 326);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancleButton
            // 
            this.CancleButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancleButton.Location = new System.Drawing.Point(497, 326);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(75, 23);
            this.CancleButton.TabIndex = 1;
            this.CancleButton.Text = "Cancle";
            this.CancleButton.UseVisualStyleBackColor = false;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // DeleteSymbolMarkLabel
            // 
            this.DeleteSymbolMarkLabel.AutoSize = true;
            this.DeleteSymbolMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSymbolMarkLabel.Location = new System.Drawing.Point(12, 9);
            this.DeleteSymbolMarkLabel.Name = "DeleteSymbolMarkLabel";
            this.DeleteSymbolMarkLabel.Size = new System.Drawing.Size(307, 16);
            this.DeleteSymbolMarkLabel.TabIndex = 2;
            this.DeleteSymbolMarkLabel.Text = "What punctuation marks would you like to remove?";
            // 
            // FullStopCheckBox
            // 
            this.FullStopCheckBox.AutoSize = true;
            this.FullStopCheckBox.Location = new System.Drawing.Point(15, 28);
            this.FullStopCheckBox.Name = "FullStopCheckBox";
            this.FullStopCheckBox.Size = new System.Drawing.Size(83, 17);
            this.FullStopCheckBox.TabIndex = 3;
            this.FullStopCheckBox.Text = "Full stop ( . )";
            this.FullStopCheckBox.UseVisualStyleBackColor = true;
            this.FullStopCheckBox.CheckedChanged += new System.EventHandler(this.FullStopCheckBox_CheckedChanged);
            // 
            // CommaCheckBox
            // 
            this.CommaCheckBox.AutoSize = true;
            this.CommaCheckBox.Location = new System.Drawing.Point(15, 51);
            this.CommaCheckBox.Name = "CommaCheckBox";
            this.CommaCheckBox.Size = new System.Drawing.Size(79, 17);
            this.CommaCheckBox.TabIndex = 4;
            this.CommaCheckBox.Text = "Comma ( , )";
            this.CommaCheckBox.UseVisualStyleBackColor = true;
            this.CommaCheckBox.CheckedChanged += new System.EventHandler(this.CommaCheckBox_CheckedChanged);
            // 
            // SemiColonCheckBox
            // 
            this.SemiColonCheckBox.AutoSize = true;
            this.SemiColonCheckBox.Location = new System.Drawing.Point(15, 189);
            this.SemiColonCheckBox.Name = "SemiColonCheckBox";
            this.SemiColonCheckBox.Size = new System.Drawing.Size(96, 17);
            this.SemiColonCheckBox.TabIndex = 5;
            this.SemiColonCheckBox.Text = "Semi-colon ( ; )";
            this.SemiColonCheckBox.UseVisualStyleBackColor = true;
            this.SemiColonCheckBox.CheckedChanged += new System.EventHandler(this.SemiColonCheckBox_CheckedChanged);
            // 
            // ColonCheckBox
            // 
            this.ColonCheckBox.AutoSize = true;
            this.ColonCheckBox.Location = new System.Drawing.Point(15, 74);
            this.ColonCheckBox.Name = "ColonCheckBox";
            this.ColonCheckBox.Size = new System.Drawing.Size(71, 17);
            this.ColonCheckBox.TabIndex = 6;
            this.ColonCheckBox.Text = "Colon ( : )";
            this.ColonCheckBox.UseVisualStyleBackColor = true;
            this.ColonCheckBox.CheckedChanged += new System.EventHandler(this.ColonCheckBox_CheckedChanged);
            // 
            // HyphenCheckBox
            // 
            this.HyphenCheckBox.AutoSize = true;
            this.HyphenCheckBox.Location = new System.Drawing.Point(15, 97);
            this.HyphenCheckBox.Name = "HyphenCheckBox";
            this.HyphenCheckBox.Size = new System.Drawing.Size(81, 17);
            this.HyphenCheckBox.TabIndex = 7;
            this.HyphenCheckBox.Text = "Hyphen ( - )";
            this.HyphenCheckBox.UseVisualStyleBackColor = true;
            this.HyphenCheckBox.CheckedChanged += new System.EventHandler(this.HyphenCheckBox_CheckedChanged);
            // 
            // QuestionMarkCheckBox
            // 
            this.QuestionMarkCheckBox.AutoSize = true;
            this.QuestionMarkCheckBox.Location = new System.Drawing.Point(15, 212);
            this.QuestionMarkCheckBox.Name = "QuestionMarkCheckBox";
            this.QuestionMarkCheckBox.Size = new System.Drawing.Size(115, 17);
            this.QuestionMarkCheckBox.TabIndex = 8;
            this.QuestionMarkCheckBox.Text = "Question mark ( ? )";
            this.QuestionMarkCheckBox.UseVisualStyleBackColor = true;
            this.QuestionMarkCheckBox.CheckedChanged += new System.EventHandler(this.QuestionMarkCheckBox_CheckedChanged);
            // 
            // ExclamationMarkCheckBox
            // 
            this.ExclamationMarkCheckBox.AutoSize = true;
            this.ExclamationMarkCheckBox.Location = new System.Drawing.Point(148, 212);
            this.ExclamationMarkCheckBox.Name = "ExclamationMarkCheckBox";
            this.ExclamationMarkCheckBox.Size = new System.Drawing.Size(127, 17);
            this.ExclamationMarkCheckBox.TabIndex = 9;
            this.ExclamationMarkCheckBox.Text = "Exclamation mark ( ! )";
            this.ExclamationMarkCheckBox.UseVisualStyleBackColor = true;
            this.ExclamationMarkCheckBox.CheckedChanged += new System.EventHandler(this.ExclamationMarkCheckBox_CheckedChanged);
            // 
            // ParenthesisCheckBox
            // 
            this.ParenthesisCheckBox.AutoSize = true;
            this.ParenthesisCheckBox.Location = new System.Drawing.Point(15, 166);
            this.ParenthesisCheckBox.Name = "ParenthesisCheckBox";
            this.ParenthesisCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ParenthesisCheckBox.TabIndex = 10;
            this.ParenthesisCheckBox.Text = "Parenthesis ( () )";
            this.ParenthesisCheckBox.UseVisualStyleBackColor = true;
            this.ParenthesisCheckBox.CheckedChanged += new System.EventHandler(this.ParenthesisCheckBox_CheckedChanged);
            // 
            // SquareBrecketCheckBox
            // 
            this.SquareBrecketCheckBox.AutoSize = true;
            this.SquareBrecketCheckBox.Location = new System.Drawing.Point(148, 166);
            this.SquareBrecketCheckBox.Name = "SquareBrecketCheckBox";
            this.SquareBrecketCheckBox.Size = new System.Drawing.Size(123, 17);
            this.SquareBrecketCheckBox.TabIndex = 11;
            this.SquareBrecketCheckBox.Text = "Square bracket ( [ ] )";
            this.SquareBrecketCheckBox.UseVisualStyleBackColor = true;
            this.SquareBrecketCheckBox.CheckedChanged += new System.EventHandler(this.SquareBrecketCheckBox_CheckedChanged);
            // 
            // BraceCheckBox
            // 
            this.BraceCheckBox.AutoSize = true;
            this.BraceCheckBox.Location = new System.Drawing.Point(15, 143);
            this.BraceCheckBox.Name = "BraceCheckBox";
            this.BraceCheckBox.Size = new System.Drawing.Size(77, 17);
            this.BraceCheckBox.TabIndex = 12;
            this.BraceCheckBox.Text = "Brace ( {} )";
            this.BraceCheckBox.UseVisualStyleBackColor = true;
            this.BraceCheckBox.CheckedChanged += new System.EventHandler(this.BraceCheckBox_CheckedChanged);
            // 
            // AngleBracketCheckBox
            // 
            this.AngleBracketCheckBox.AutoSize = true;
            this.AngleBracketCheckBox.Location = new System.Drawing.Point(148, 143);
            this.AngleBracketCheckBox.Name = "AngleBracketCheckBox";
            this.AngleBracketCheckBox.Size = new System.Drawing.Size(122, 17);
            this.AngleBracketCheckBox.TabIndex = 13;
            this.AngleBracketCheckBox.Text = "Angle bracket ( < > )";
            this.AngleBracketCheckBox.UseVisualStyleBackColor = true;
            this.AngleBracketCheckBox.CheckedChanged += new System.EventHandler(this.AngleBracketCheckBox_CheckedChanged);
            // 
            // QuotationMarkCheckBox
            // 
            this.QuotationMarkCheckBox.AutoSize = true;
            this.QuotationMarkCheckBox.Location = new System.Drawing.Point(148, 189);
            this.QuotationMarkCheckBox.Name = "QuotationMarkCheckBox";
            this.QuotationMarkCheckBox.Size = new System.Drawing.Size(118, 17);
            this.QuotationMarkCheckBox.TabIndex = 14;
            this.QuotationMarkCheckBox.Text = "Quotation mark ( \" )";
            this.QuotationMarkCheckBox.UseVisualStyleBackColor = true;
            this.QuotationMarkCheckBox.CheckedChanged += new System.EventHandler(this.QuotationMarkCheckBox_CheckedChanged);
            // 
            // AsteriskCheckBox
            // 
            this.AsteriskCheckBox.AutoSize = true;
            this.AsteriskCheckBox.Location = new System.Drawing.Point(15, 120);
            this.AsteriskCheckBox.Name = "AsteriskCheckBox";
            this.AsteriskCheckBox.Size = new System.Drawing.Size(82, 17);
            this.AsteriskCheckBox.TabIndex = 15;
            this.AsteriskCheckBox.Text = "Asterisk ( * )";
            this.AsteriskCheckBox.UseVisualStyleBackColor = true;
            this.AsteriskCheckBox.CheckedChanged += new System.EventHandler(this.AsteriskCheckBox_CheckedChanged);
            // 
            // AmpersandCheckBox
            // 
            this.AmpersandCheckBox.AutoSize = true;
            this.AmpersandCheckBox.Location = new System.Drawing.Point(148, 97);
            this.AmpersandCheckBox.Name = "AmpersandCheckBox";
            this.AmpersandCheckBox.Size = new System.Drawing.Size(82, 17);
            this.AmpersandCheckBox.TabIndex = 16;
            this.AmpersandCheckBox.Text = "Ampersand ";
            this.AmpersandCheckBox.UseVisualStyleBackColor = true;
            this.AmpersandCheckBox.CheckedChanged += new System.EventHandler(this.AmpersandCheckBox_CheckedChanged);
            // 
            // TildeCheckBox
            // 
            this.TildeCheckBox.AutoSize = true;
            this.TildeCheckBox.Location = new System.Drawing.Point(148, 120);
            this.TildeCheckBox.Name = "TildeCheckBox";
            this.TildeCheckBox.Size = new System.Drawing.Size(71, 17);
            this.TildeCheckBox.TabIndex = 17;
            this.TildeCheckBox.Text = "Tilde ( ~ )";
            this.TildeCheckBox.UseVisualStyleBackColor = true;
            this.TildeCheckBox.CheckedChanged += new System.EventHandler(this.TildeCheckBox_CheckedChanged);
            // 
            // VirguleCheckBox
            // 
            this.VirguleCheckBox.AutoSize = true;
            this.VirguleCheckBox.Location = new System.Drawing.Point(148, 74);
            this.VirguleCheckBox.Name = "VirguleCheckBox";
            this.VirguleCheckBox.Size = new System.Drawing.Size(78, 17);
            this.VirguleCheckBox.TabIndex = 18;
            this.VirguleCheckBox.Text = "Virgule ( / )";
            this.VirguleCheckBox.UseVisualStyleBackColor = true;
            this.VirguleCheckBox.CheckedChanged += new System.EventHandler(this.VirguleCheckBox_CheckedChanged);
            // 
            // HashCheckBox
            // 
            this.HashCheckBox.AutoSize = true;
            this.HashCheckBox.Location = new System.Drawing.Point(148, 28);
            this.HashCheckBox.Name = "HashCheckBox";
            this.HashCheckBox.Size = new System.Drawing.Size(73, 17);
            this.HashCheckBox.TabIndex = 19;
            this.HashCheckBox.Text = "Hash ( # )";
            this.HashCheckBox.UseVisualStyleBackColor = true;
            this.HashCheckBox.CheckedChanged += new System.EventHandler(this.HashCheckBox_CheckedChanged);
            // 
            // AtCheckBox
            // 
            this.AtCheckBox.AutoSize = true;
            this.AtCheckBox.Location = new System.Drawing.Point(148, 51);
            this.AtCheckBox.Name = "AtCheckBox";
            this.AtCheckBox.Size = new System.Drawing.Size(62, 17);
            this.AtCheckBox.TabIndex = 20;
            this.AtCheckBox.Text = "At ( @ )";
            this.AtCheckBox.UseVisualStyleBackColor = true;
            this.AtCheckBox.CheckedChanged += new System.EventHandler(this.AtCheckBox_CheckedChanged);
            // 
            // MinimumWordLengthLabel
            // 
            this.MinimumWordLengthLabel.AutoSize = true;
            this.MinimumWordLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumWordLengthLabel.Location = new System.Drawing.Point(12, 256);
            this.MinimumWordLengthLabel.Name = "MinimumWordLengthLabel";
            this.MinimumWordLengthLabel.Size = new System.Drawing.Size(135, 16);
            this.MinimumWordLengthLabel.TabIndex = 21;
            this.MinimumWordLengthLabel.Text = "Minimum word length:";
            // 
            // MinimumWordLengthTextBox
            // 
            this.MinimumWordLengthTextBox.Location = new System.Drawing.Point(148, 255);
            this.MinimumWordLengthTextBox.Name = "MinimumWordLengthTextBox";
            this.MinimumWordLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinimumWordLengthTextBox.TabIndex = 22;
            // 
            // EditTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.MinimumWordLengthTextBox);
            this.Controls.Add(this.MinimumWordLengthLabel);
            this.Controls.Add(this.AtCheckBox);
            this.Controls.Add(this.HashCheckBox);
            this.Controls.Add(this.VirguleCheckBox);
            this.Controls.Add(this.TildeCheckBox);
            this.Controls.Add(this.AmpersandCheckBox);
            this.Controls.Add(this.AsteriskCheckBox);
            this.Controls.Add(this.QuotationMarkCheckBox);
            this.Controls.Add(this.AngleBracketCheckBox);
            this.Controls.Add(this.BraceCheckBox);
            this.Controls.Add(this.SquareBrecketCheckBox);
            this.Controls.Add(this.ParenthesisCheckBox);
            this.Controls.Add(this.ExclamationMarkCheckBox);
            this.Controls.Add(this.QuestionMarkCheckBox);
            this.Controls.Add(this.HyphenCheckBox);
            this.Controls.Add(this.ColonCheckBox);
            this.Controls.Add(this.SemiColonCheckBox);
            this.Controls.Add(this.CommaCheckBox);
            this.Controls.Add(this.FullStopCheckBox);
            this.Controls.Add(this.DeleteSymbolMarkLabel);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.OKButton);
            this.Name = "EditTextForm";
            this.Text = "EditTextForm";
            this.Load += new System.EventHandler(this.EditTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancleButton;
        private System.Windows.Forms.Label DeleteSymbolMarkLabel;
        private System.Windows.Forms.CheckBox FullStopCheckBox;
        private System.Windows.Forms.CheckBox CommaCheckBox;
        private System.Windows.Forms.CheckBox SemiColonCheckBox;
        private System.Windows.Forms.CheckBox ColonCheckBox;
        private System.Windows.Forms.CheckBox HyphenCheckBox;
        private System.Windows.Forms.CheckBox QuestionMarkCheckBox;
        private System.Windows.Forms.CheckBox ExclamationMarkCheckBox;
        private System.Windows.Forms.CheckBox ParenthesisCheckBox;
        private System.Windows.Forms.CheckBox SquareBrecketCheckBox;
        private System.Windows.Forms.CheckBox BraceCheckBox;
        private System.Windows.Forms.CheckBox AngleBracketCheckBox;
        private System.Windows.Forms.CheckBox QuotationMarkCheckBox;
        private System.Windows.Forms.CheckBox AsteriskCheckBox;
        private System.Windows.Forms.CheckBox AmpersandCheckBox;
        private System.Windows.Forms.CheckBox TildeCheckBox;
        private System.Windows.Forms.CheckBox VirguleCheckBox;
        private System.Windows.Forms.CheckBox HashCheckBox;
        private System.Windows.Forms.CheckBox AtCheckBox;
        private System.Windows.Forms.Label MinimumWordLengthLabel;
        private System.Windows.Forms.TextBox MinimumWordLengthTextBox;
    }
}