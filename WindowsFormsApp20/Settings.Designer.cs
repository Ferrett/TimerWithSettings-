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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.changeFormColorButton.Location = new System.Drawing.Point(22, 24);
            this.changeFormColorButton.Name = "button1";
            this.changeFormColorButton.Size = new System.Drawing.Size(222, 23);
            this.changeFormColorButton.TabIndex = 0;
            this.changeFormColorButton.Text = "Change Form Color";
            this.changeFormColorButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.changePanelColorButton.Location = new System.Drawing.Point(22, 66);
            this.changePanelColorButton.Name = "button2";
            this.changePanelColorButton.Size = new System.Drawing.Size(222, 23);
            this.changePanelColorButton.TabIndex = 1;
            this.changePanelColorButton.Text = "Change Panel Color";
            this.changePanelColorButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.changeFontColorButton.Location = new System.Drawing.Point(22, 109);
            this.changeFontColorButton.Name = "button3";
            this.changeFontColorButton.Size = new System.Drawing.Size(222, 23);
            this.changeFontColorButton.TabIndex = 2;
            this.changeFontColorButton.Text = "Change Font Color";
            this.changeFontColorButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 157);
            this.Controls.Add(this.changeFontColorButton);
            this.Controls.Add(this.changePanelColorButton);
            this.Controls.Add(this.changeFormColorButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeFormColorButton;
        private System.Windows.Forms.Button changePanelColorButton;
        private System.Windows.Forms.Button changeFontColorButton;
    }
}