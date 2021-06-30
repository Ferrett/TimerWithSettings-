namespace WindowsFormsApp20 {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.changeFormColorButton = new System.Windows.Forms.Button();
            this.changePanelColorButton = new System.Windows.Forms.Button();
            this.changeFontColorButton = new System.Windows.Forms.Button();
            this.hoursCheckBox = new System.Windows.Forms.CheckBox();
            this.minutesCheckBox = new System.Windows.Forms.CheckBox();
            this.secondsCheckBox = new System.Windows.Forms.CheckBox();
            this.milisecondsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // changeFormColorButton
            // 
            this.changeFormColorButton.Location = new System.Drawing.Point(22, 24);
            this.changeFormColorButton.Name = "changeFormColorButton";
            this.changeFormColorButton.Size = new System.Drawing.Size(222, 23);
            this.changeFormColorButton.TabIndex = 0;
            this.changeFormColorButton.Text = "Change Form Color";
            this.changeFormColorButton.UseVisualStyleBackColor = true;
            // 
            // changePanelColorButton
            // 
            this.changePanelColorButton.Location = new System.Drawing.Point(22, 66);
            this.changePanelColorButton.Name = "changePanelColorButton";
            this.changePanelColorButton.Size = new System.Drawing.Size(222, 23);
            this.changePanelColorButton.TabIndex = 1;
            this.changePanelColorButton.Text = "Change Panel Color";
            this.changePanelColorButton.UseVisualStyleBackColor = true;
            // 
            // changeFontColorButton
            // 
            this.changeFontColorButton.Location = new System.Drawing.Point(22, 109);
            this.changeFontColorButton.Name = "changeFontColorButton";
            this.changeFontColorButton.Size = new System.Drawing.Size(222, 23);
            this.changeFontColorButton.TabIndex = 2;
            this.changeFontColorButton.Text = "Change Font Color";
            this.changeFontColorButton.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.hoursCheckBox.AutoSize = true;
            this.hoursCheckBox.Location = new System.Drawing.Point(22, 157);
            this.hoursCheckBox.Name = "checkBox1";
            this.hoursCheckBox.Size = new System.Drawing.Size(84, 17);
            this.hoursCheckBox.TabIndex = 3;
            this.hoursCheckBox.Text = "Show Hours";
            this.hoursCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.minutesCheckBox.AutoSize = true;
            this.minutesCheckBox.Location = new System.Drawing.Point(140, 157);
            this.minutesCheckBox.Name = "checkBox2";
            this.minutesCheckBox.Size = new System.Drawing.Size(93, 17);
            this.minutesCheckBox.TabIndex = 4;
            this.minutesCheckBox.Text = "Show Minutes";
            this.minutesCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.secondsCheckBox.AutoSize = true;
            this.secondsCheckBox.Location = new System.Drawing.Point(22, 202);
            this.secondsCheckBox.Name = "checkBox3";
            this.secondsCheckBox.Size = new System.Drawing.Size(98, 17);
            this.secondsCheckBox.TabIndex = 5;
            this.secondsCheckBox.Text = "Show Seconds";
            this.secondsCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.milisecondsCheckBox.AutoSize = true;
            this.milisecondsCheckBox.Location = new System.Drawing.Point(140, 202);
            this.milisecondsCheckBox.Name = "checkBox4";
            this.milisecondsCheckBox.Size = new System.Drawing.Size(111, 17);
            this.milisecondsCheckBox.TabIndex = 6;
            this.milisecondsCheckBox.Text = "Show Miliseconds";
            this.milisecondsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 294);
            this.Controls.Add(this.milisecondsCheckBox);
            this.Controls.Add(this.secondsCheckBox);
            this.Controls.Add(this.minutesCheckBox);
            this.Controls.Add(this.hoursCheckBox);
            this.Controls.Add(this.changeFontColorButton);
            this.Controls.Add(this.changePanelColorButton);
            this.Controls.Add(this.changeFormColorButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeFormColorButton;
        private System.Windows.Forms.Button changePanelColorButton;
        private System.Windows.Forms.Button changeFontColorButton;
        private System.Windows.Forms.CheckBox hoursCheckBox;
        private System.Windows.Forms.CheckBox minutesCheckBox;
        private System.Windows.Forms.CheckBox secondsCheckBox;
        private System.Windows.Forms.CheckBox milisecondsCheckBox;
    }
}