namespace WindowsFormsApp1
{
    partial class GrossPayCalculatorForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.lengthOfPayCycleLabel = new System.Windows.Forms.Label();
            this.hoursWorkedPerWeekLabel = new System.Windows.Forms.Label();
            this.hourlyWageRateLabel = new System.Windows.Forms.Label();
            this.payCycleLengthTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(69, 187);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 35);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(272, 187);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 35);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lengthOfPayCycleLabel
            // 
            this.lengthOfPayCycleLabel.AutoSize = true;
            this.lengthOfPayCycleLabel.Location = new System.Drawing.Point(32, 48);
            this.lengthOfPayCycleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthOfPayCycleLabel.Name = "lengthOfPayCycleLabel";
            this.lengthOfPayCycleLabel.Size = new System.Drawing.Size(190, 20);
            this.lengthOfPayCycleLabel.TabIndex = 2;
            this.lengthOfPayCycleLabel.Text = "Length of Pay Cycle (wks)";
            // 
            // hoursWorkedPerWeekLabel
            // 
            this.hoursWorkedPerWeekLabel.AutoSize = true;
            this.hoursWorkedPerWeekLabel.Location = new System.Drawing.Point(39, 84);
            this.hoursWorkedPerWeekLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoursWorkedPerWeekLabel.Name = "hoursWorkedPerWeekLabel";
            this.hoursWorkedPerWeekLabel.Size = new System.Drawing.Size(183, 20);
            this.hoursWorkedPerWeekLabel.TabIndex = 3;
            this.hoursWorkedPerWeekLabel.Text = "Hours Worked per Week";
            this.hoursWorkedPerWeekLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // hourlyWageRateLabel
            // 
            this.hourlyWageRateLabel.AutoSize = true;
            this.hourlyWageRateLabel.Location = new System.Drawing.Point(84, 120);
            this.hourlyWageRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hourlyWageRateLabel.Name = "hourlyWageRateLabel";
            this.hourlyWageRateLabel.Size = new System.Drawing.Size(139, 20);
            this.hourlyWageRateLabel.TabIndex = 4;
            this.hourlyWageRateLabel.Text = "Hourly Wage Rate";
            // 
            // payCycleLengthTextBox
            // 
            this.payCycleLengthTextBox.Location = new System.Drawing.Point(236, 48);
            this.payCycleLengthTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payCycleLengthTextBox.Name = "payCycleLengthTextBox";
            this.payCycleLengthTextBox.Size = new System.Drawing.Size(148, 26);
            this.payCycleLengthTextBox.TabIndex = 5;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(236, 84);
            this.hoursWorkedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(148, 26);
            this.hoursWorkedTextBox.TabIndex = 6;
            // 
            // hourlyRateTextBox
            // 
            this.hourlyRateTextBox.Location = new System.Drawing.Point(237, 120);
            this.hourlyRateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hourlyRateTextBox.Name = "hourlyRateTextBox";
            this.hourlyRateTextBox.Size = new System.Drawing.Size(148, 26);
            this.hourlyRateTextBox.TabIndex = 7;
            // 
            // GrossPayCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 264);
            this.Controls.Add(this.hourlyRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.payCycleLengthTextBox);
            this.Controls.Add(this.hourlyWageRateLabel);
            this.Controls.Add(this.hoursWorkedPerWeekLabel);
            this.Controls.Add(this.lengthOfPayCycleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GrossPayCalculatorForm";
            this.Text = "Gross Pay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label lengthOfPayCycleLabel;
        private System.Windows.Forms.Label hoursWorkedPerWeekLabel;
        private System.Windows.Forms.Label hourlyWageRateLabel;
        private System.Windows.Forms.TextBox payCycleLengthTextBox;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox hourlyRateTextBox;
    }
}

