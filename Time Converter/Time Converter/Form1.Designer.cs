namespace Time_Converter
{
    partial class Form1
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
            this.SecondsTextBox = new System.Windows.Forms.TextBox();
            this.HowManySecondsLabel = new System.Windows.Forms.Label();
            this.ConverButton = new System.Windows.Forms.Button();
            this.DaysDisplay = new System.Windows.Forms.Label();
            this.HoursDisplay = new System.Windows.Forms.Label();
            this.MinutesDisplay = new System.Windows.Forms.Label();
            this.SecondsDisplay = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecondsTextBox
            // 
            this.SecondsTextBox.Location = new System.Drawing.Point(173, 12);
            this.SecondsTextBox.Name = "SecondsTextBox";
            this.SecondsTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondsTextBox.TabIndex = 0;
            // 
            // HowManySecondsLabel
            // 
            this.HowManySecondsLabel.AutoSize = true;
            this.HowManySecondsLabel.Location = new System.Drawing.Point(33, 15);
            this.HowManySecondsLabel.Name = "HowManySecondsLabel";
            this.HowManySecondsLabel.Size = new System.Drawing.Size(102, 13);
            this.HowManySecondsLabel.TabIndex = 1;
            this.HowManySecondsLabel.Text = "How many Seconds";
            // 
            // ConverButton
            // 
            this.ConverButton.Location = new System.Drawing.Point(30, 133);
            this.ConverButton.Name = "ConverButton";
            this.ConverButton.Size = new System.Drawing.Size(75, 41);
            this.ConverButton.TabIndex = 2;
            this.ConverButton.Text = "Convert Time";
            this.ConverButton.UseVisualStyleBackColor = true;
            this.ConverButton.Click += new System.EventHandler(this.ConverButton_Click);
            // 
            // DaysDisplay
            // 
            this.DaysDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaysDisplay.Location = new System.Drawing.Point(26, 72);
            this.DaysDisplay.Name = "DaysDisplay";
            this.DaysDisplay.Size = new System.Drawing.Size(57, 20);
            this.DaysDisplay.TabIndex = 3;
            // 
            // HoursDisplay
            // 
            this.HoursDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoursDisplay.Location = new System.Drawing.Point(89, 72);
            this.HoursDisplay.Name = "HoursDisplay";
            this.HoursDisplay.Size = new System.Drawing.Size(57, 20);
            this.HoursDisplay.TabIndex = 4;
            // 
            // MinutesDisplay
            // 
            this.MinutesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinutesDisplay.Location = new System.Drawing.Point(152, 72);
            this.MinutesDisplay.Name = "MinutesDisplay";
            this.MinutesDisplay.Size = new System.Drawing.Size(57, 20);
            this.MinutesDisplay.TabIndex = 5;
            // 
            // SecondsDisplay
            // 
            this.SecondsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondsDisplay.Location = new System.Drawing.Point(215, 72);
            this.SecondsDisplay.Name = "SecondsDisplay";
            this.SecondsDisplay.Size = new System.Drawing.Size(57, 20);
            this.SecondsDisplay.TabIndex = 6;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(111, 133);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 41);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(192, 133);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 41);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Location = new System.Drawing.Point(27, 49);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(31, 13);
            this.DaysLabel.TabIndex = 9;
            this.DaysLabel.Text = "Days";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(86, 49);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel.TabIndex = 10;
            this.HoursLabel.Text = "Hours";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(149, 49);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(44, 13);
            this.MinutesLabel.TabIndex = 11;
            this.MinutesLabel.Text = "Minutes";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(212, 49);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(49, 13);
            this.SecondsLabel.TabIndex = 12;
            this.SecondsLabel.Text = "Seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 186);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SecondsDisplay);
            this.Controls.Add(this.MinutesDisplay);
            this.Controls.Add(this.HoursDisplay);
            this.Controls.Add(this.DaysDisplay);
            this.Controls.Add(this.ConverButton);
            this.Controls.Add(this.HowManySecondsLabel);
            this.Controls.Add(this.SecondsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SecondsTextBox;
        private System.Windows.Forms.Label HowManySecondsLabel;
        private System.Windows.Forms.Button ConverButton;
        private System.Windows.Forms.Label DaysDisplay;
        private System.Windows.Forms.Label HoursDisplay;
        private System.Windows.Forms.Label MinutesDisplay;
        private System.Windows.Forms.Label SecondsDisplay;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label SecondsLabel;
    }
}

