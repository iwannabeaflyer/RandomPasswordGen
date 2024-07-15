namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.SymbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.NumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.UppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.LengthComboBox = new System.Windows.Forms.ComboBox();
            this.IncludeLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.CopyClipboardButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(11, 155);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(97, 28);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate Password";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GeneratePassword);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(135, 100);
            this.InputTextBox.MaxLength = 5;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputTextBox.TabIndex = 5;
            // 
            // SymbolsCheckBox
            // 
            this.SymbolsCheckBox.AutoSize = true;
            this.SymbolsCheckBox.Checked = true;
            this.SymbolsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SymbolsCheckBox.Location = new System.Drawing.Point(135, 12);
            this.SymbolsCheckBox.Name = "SymbolsCheckBox";
            this.SymbolsCheckBox.Size = new System.Drawing.Size(65, 17);
            this.SymbolsCheckBox.TabIndex = 8;
            this.SymbolsCheckBox.Text = "Symbols";
            this.SymbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumbersCheckBox
            // 
            this.NumbersCheckBox.AutoSize = true;
            this.NumbersCheckBox.Checked = true;
            this.NumbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumbersCheckBox.Location = new System.Drawing.Point(135, 32);
            this.NumbersCheckBox.Name = "NumbersCheckBox";
            this.NumbersCheckBox.Size = new System.Drawing.Size(68, 17);
            this.NumbersCheckBox.TabIndex = 9;
            this.NumbersCheckBox.Text = "Numbers";
            this.NumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // UppercaseCheckBox
            // 
            this.UppercaseCheckBox.AutoSize = true;
            this.UppercaseCheckBox.Checked = true;
            this.UppercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UppercaseCheckBox.Location = new System.Drawing.Point(135, 52);
            this.UppercaseCheckBox.Name = "UppercaseCheckBox";
            this.UppercaseCheckBox.Size = new System.Drawing.Size(78, 17);
            this.UppercaseCheckBox.TabIndex = 10;
            this.UppercaseCheckBox.Text = "Uppercase";
            this.UppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // LengthComboBox
            // 
            this.LengthComboBox.FormattingEnabled = true;
            this.LengthComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.LengthComboBox.Location = new System.Drawing.Point(10, 10);
            this.LengthComboBox.Name = "LengthComboBox";
            this.LengthComboBox.Size = new System.Drawing.Size(116, 21);
            this.LengthComboBox.TabIndex = 12;
            this.LengthComboBox.Text = "Password Length";
            // 
            // IncludeLabel
            // 
            this.IncludeLabel.AutoSize = true;
            this.IncludeLabel.Location = new System.Drawing.Point(135, 80);
            this.IncludeLabel.Name = "IncludeLabel";
            this.IncludeLabel.Size = new System.Drawing.Size(124, 13);
            this.IncludeLabel.TabIndex = 14;
            this.IncludeLabel.Text = "Password should include";
            // 
            // NoteLabel
            // 
            this.NoteLabel.Location = new System.Drawing.Point(135, 130);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(130, 59);
            this.NoteLabel.TabIndex = 16;
            this.NoteLabel.Text = "*Having recognizable words in your password makes it weaker but easier to remembe" +
    "r.*";
            // 
            // CopyClipboardButton
            // 
            this.CopyClipboardButton.Location = new System.Drawing.Point(12, 195);
            this.CopyClipboardButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyClipboardButton.Name = "CopyClipboardButton";
            this.CopyClipboardButton.Size = new System.Drawing.Size(97, 36);
            this.CopyClipboardButton.TabIndex = 17;
            this.CopyClipboardButton.Text = "Copy to Clipboard";
            this.CopyClipboardButton.UseVisualStyleBackColor = true;
            this.CopyClipboardButton.Click += new System.EventHandler(this.CopyClipboardButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(8, 81);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(106, 13);
            this.OutputLabel.TabIndex = 18;
            this.OutputLabel.Text = "Generated Password";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(11, 99);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(103, 20);
            this.OutputTextBox.TabIndex = 19;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 241);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.CopyClipboardButton);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.IncludeLabel);
            this.Controls.Add(this.LengthComboBox);
            this.Controls.Add(this.UppercaseCheckBox);
            this.Controls.Add(this.NumbersCheckBox);
            this.Controls.Add(this.SymbolsCheckBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.CheckBox SymbolsCheckBox;
        private System.Windows.Forms.CheckBox NumbersCheckBox;
        private System.Windows.Forms.CheckBox UppercaseCheckBox;
        private System.Windows.Forms.ComboBox LengthComboBox;
        private System.Windows.Forms.Label IncludeLabel;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Button CopyClipboardButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}